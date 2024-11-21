using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using travel_experts_phase_2.Models;
using travel_experts_phase_2.ViewModels;

namespace travel_experts_phase_2.Controllers
{
    public class AdminController
    {
        public List<AdminViewModel> GetAllAdmins()
        {

            var admins = new List<AdminViewModel>();
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                admins = db.Admins.Select(admin => new AdminViewModel
                {
                    FirstName = admin.FirstName,
                    LastName = admin.LastName,
                    Email = admin.Email,
                    PhoneNumber = admin.PhoneNumber,
                    Role = admin.Role
                }
                    ).ToList();

                return admins;
            }
        }

        public bool IsUserAdmin(string email)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                Admin? user = db.Admins.FirstOrDefault(admin => admin.Email == email);
                return user != null;
            }
        }

    }
}
