using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace travel_experts_phase_2
{
    public partial class HomeForm : Form
    {
        bool isAdmin;
        public HomeForm(bool isAdmin = false)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                agenciesButton.Visible = true;
                agentButton.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Open SuppliersForm and hide HomeForm
            OpenFormAndHideHome(new Suppliers());
        }

        private void OpenFormAndHideHome(Form formToOpen)
        {
            // Hide the HomeForm
            this.Hide();

            // Show the other form modally and reshow HomeForm after it is closed
            formToOpen.ShowDialog();
            this.Show();
        }

        private void agentButton_Click(object sender, EventArgs e)
        {
            // Open AgentsForm and hide HomeForm
            OpenFormAndHideHome(new AgentsForm());
        }

        private void agenciesButton_Click(object sender, EventArgs e)
        {
            // Open AgenciesForm and hide HomeForm
            OpenFormAndHideHome(new AgenciesForm());
        }

        private void packagesButton_Click(object sender, EventArgs e)
        {
            // Open packagefrm and hide HomeForm
            OpenFormAndHideHome(new packagefrm());
        }

        private void productSuppliersButton_Click(object sender, EventArgs e)
        {
            // Open ProductSupplierFrm and hide HomeForm
            OpenFormAndHideHome(new ProductSupplierFrm());
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            // Open ProductsForm and hide HomeForm
            OpenFormAndHideHome(new ProductsForm());
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Confirm before exiting (optional)
            var result = MessageBox.Show("Are you sure you want to exit the application?",
                                          "Exit Confirmation",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Close the entire application
                Application.Exit();
            }
        }
    }
}
