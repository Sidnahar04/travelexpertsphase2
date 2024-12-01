using travel_experts_phase_2.Controllers;
using travel_experts_phase_2.Models;
using travel_experts_phase_2.ViewModels;

namespace travel_experts_phase_2
{
    public partial class packagefrm : Form
    {
        PackageViewModel selectedPackage = null;
        public bool isViewPackage = false;
        PackageController packageController = new PackageController();

        public packagefrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<PackageViewModel> packages = packageController.GetAllPackages();
            dgvPackages.DataSource = packages;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addOrUpdatePackageFrm addOrUpdatePackageFrm = new();
            DialogResult result = addOrUpdatePackageFrm.ShowDialog();
            if (result == DialogResult.OK)
            {
                PackageController packageController = new PackageController();
                selectedPackage = addOrUpdatePackageFrm.Package;
                packageController.AddPackage(selectedPackage);
                displayAllPackages();
            }
        }

        private void displayAllPackages()
        {
            PackageController packageController = new PackageController();
            List<PackageViewModel> packages = packageController.GetAllPackages();
            dgvPackages.DataSource = packages;
        }

        private void dgvPackages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPackages.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvPackages.SelectedRows[0];

                addOrUpdatePackageFrm UpdatePackageForm = new()
                {
                    Package = packageController.ConvertToPackageModel(selectedRow)
                };

                DialogResult result = UpdatePackageForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    var UpdatedPackageInfo = UpdatePackageForm.Package;
                    packageController.UpdatePackage(UpdatedPackageInfo);
                    displayAllPackages();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dgvPackages.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPackages.SelectedRows[0];
                var packageToDelete = packageController.ConvertToPackageForDataGrid(selectedRow);
                DialogResult result = MessageBox.Show($"Are you sure you want to delete {packageToDelete.PkgName}?",
                    "Confirm Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    packageController.deletePackage(packageToDelete);
                    displayAllPackages();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to modify.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            if (dgvPackages.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvPackages.SelectedRows[0];

                // Create and display the update form with the selected row's data
                addOrUpdatePackageFrm UpdatePackageForm = new()
                {
                    Package = packageController.ConvertToPackageModel(selectedRow)
                };

                DialogResult result = UpdatePackageForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Get the updated package info from the form
                    var UpdatedPackageInfo = UpdatePackageForm.Package;

                    // Update the package in the database
                    packageController.UpdatePackage(UpdatedPackageInfo);

                    // Refresh the displayed packages
                    displayAllPackages();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to modify.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            if (dgvPackages.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPackages.SelectedRows[0];
                addOrUpdatePackageFrm ViewPackageForm = new()
                {
                    Package = packageController.ConvertToPackageModel(selectedRow),
                    IsViewPackage = true
                };
                DialogResult result = ViewPackageForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row to modify.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchBox.Text))
            {
                displayAllPackages();
            }
            else
            {
                string searchText = searchBox.Text.ToLower();

                var filteredPackages = packageController.GetAllPackages()
                    .Where(p => p.PkgName.ToLower().Contains(searchText) ||
                                p.PkgDesc.ToLower().Contains(searchText))
                    .ToList();

                // Display the filtered packages in the DataGridView
                dgvPackages.DataSource = filteredPackages;
            }
        }
    }
}