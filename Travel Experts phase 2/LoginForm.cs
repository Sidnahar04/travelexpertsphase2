using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using travel_experts_phase_2.Controllers;

namespace travel_experts_phase_2
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }
        LoginForm currentForm;
        public static void login(string email, LoginForm loginForm)
        {


        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String email = emailTextBox.Text;
            if (IsValidEmail(email))
            {

                string password = txtPassword.Text;

                UserController userController = new UserController();
                var user = userController.ValidateLogin(email, password);

                if (user != null)
                {
                    MessageBox.Show($"Welcome, {user.Email}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Navigate to appropriate form
                    switch (user.Role)
                    {
                        case "Admin":
                            HomeForm adminForm = new HomeForm(true);
                            this.Hide();
                            adminForm.ShowDialog();
                            this.Close();
                            break;

                        case "Agent":
                            HomeForm agentForm = new HomeForm();
                            this.Hide();
                            agentForm.ShowDialog();
                            this.Close();
                            break;

                        case "Customer":
                            MessageBox.Show("This service is not for customers and only available for admin and agents", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            break;

                        default:
                            MessageBox.Show("Invalid role assigned.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Wrong email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("The email is invalid. Enter correct email to proceed", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        /// <summary>
        /// Validates if the given email is in a correct format.
        /// </summary>
        /// <param name="email">The email address to validate.</param>
        /// <returns>True if the email is valid; otherwise, false.</returns>
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false; // Email cannot be empty or whitespace
            }

            // Regular expression for a valid email
            const string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            // Match email with the pattern
            return Regex.IsMatch(email, emailPattern);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            currentForm = this;
        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {

        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !showPasswordCheckBox.Checked;
            
        }
    }
}
