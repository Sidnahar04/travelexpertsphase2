using travel_experts_phase_2.Models;

namespace travel_experts_phase_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using(TravelExpertsContext db = new TravelExpertsContext())
            {
                var packages = db.Packages.Select(
                    package=> new
                    {
                        package.PkgName,
                        package.PkgStartDate,
                        package.PkgEndDate,
                        package.PkgDesc,
                        package.PkgBasePrice,
                        package.PkgAgencyCommission
                    }).ToList();
                dgvPackages.DataSource = packages;
            }
        }
    }
}