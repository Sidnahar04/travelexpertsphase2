using System.Security.Cryptography;
using System.Text;
using travel_experts_phase_2.Models;
using travel_experts_phase_2.ViewModels;

namespace travel_experts_phase_2.Controllers
{
    public class UserController
    {
        private TravelExpertsContext context = new();

        // Retrieve all users
        public List<UserViewModel> GetAllUsers()
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                var users = db.Users.Select(user => new UserViewModel
                {
                    Id = user.UserId,
                    Email = user.Email,
                    Role = user.Role,
                    AdminId = user.AdminId,
                    AgentId = user.AgentId,
                    CustomerId = user.CustomerId
                }).ToList();

                return users;
            }
        }

        // Add a new user
        public void AddUser(UserViewModel userViewModel)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                var user = new User
                {
                    Email = userViewModel.Email,
                    Password = HashPassword(userViewModel.Password),
                    Role = userViewModel.Role,
                    AdminId = userViewModel.AdminId,
                    AgentId = userViewModel.AgentId,
                    CustomerId = userViewModel.CustomerId
                };
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        // Login Validation
        public UserViewModel ValidateLogin(string email, string password)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Email == email);
                if (user != null && VerifyPassword(password, user.Password))
                {
                    return new UserViewModel
                    {
                        Id = user.UserId,
                        Email = user.Email,
                        Role = user.Role,
                        AdminId = user.AdminId,
                        AgentId = user.AgentId,
                        CustomerId = user.CustomerId
                    };
                }
                return null; // Invalid credentials
            }
        }

        // Hash Password
        private string HashPassword(string plainText)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(plainText));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // Verify Password
        private bool VerifyPassword(string plainText, string hashedPassword)
        {
            System.Diagnostics.Debug.WriteLine($"enteredpassword {HashPassword(plainText)} savedPassword {hashedPassword}");
            MessageBox.Show($"enteredpassword {HashPassword(plainText)} savedPassword {hashedPassword}");
            return HashPassword(plainText) == hashedPassword;
        }
    }
}
