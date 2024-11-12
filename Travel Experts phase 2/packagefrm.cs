using travel_experts_phase_2.Controllers;
using travel_experts_phase_2.ViewModels;

namespace travel_experts_phase_2
{
    public partial class packagefrm : Form
    {
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
    }
}