using travel_experts_phase_2.Controllers;
using travel_experts_phase_2.ViewModels;

namespace travel_experts_phase_2
{
    public partial class packagefrm : Form
    {
        PackageViewModel selectedPackage = null;
        public packagefrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PackageController packageController = new PackageController();
            List<PackageViewModel> packages = packageController.GetAllPackages();
            dgvPackages.DataSource = packages;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {

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
    }
}