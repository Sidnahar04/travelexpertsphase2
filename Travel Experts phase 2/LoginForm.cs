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


            //check if email is in admin to validate if present asign role as admin and return, if email is not in admin table then check agent table and if missing show error ogin failure,
            AdminController controller = new AdminController();
            if (controller.IsUserAdmin(email))
            {
                HomeForm adminHome = new HomeForm(true);
                adminHome.Show();
                loginForm.Hide();
            }
            else
            {
                AgentController agentController = new AgentController();
                if (agentController.IsUserAnAgent(email))
                {
                    HomeForm agentHome = new HomeForm();
                    agentHome.Show();
                    loginForm.Hide();

                }
                else
                {
                    MessageBox.Show("The email does not exist, try a correct email address", "User does not exist", MessageBoxButtons.OK, MessageBoxIcon.Information);

                };
            };
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String email = emailTextBox.Text;
            if (IsValidEmail(email))
            {
                login(email, this);
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
    }
}
