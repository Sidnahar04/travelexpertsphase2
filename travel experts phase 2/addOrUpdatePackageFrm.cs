using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using travel_experts_phase_2.Models;
using travel_experts_phase_2.ViewModels;

namespace travel_experts_phase_2
{
    public partial class addOrUpdatePackageFrm : Form
    {
        public PackageViewModel Package { get; set; } = null!;

        public addOrUpdatePackageFrm()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            //Package.PackageID = int.Parse(packageIdTxt.Text);
            Package.PkgName = packageNameTxt.Text;
            Package.PkgDesc = packageDescTxt.Text;
            Package.PkgStartDate=PackageStartDateTxt.Value;
            Package.PkgEndDate=PackageEndDateTxt.Value;
            Package.PkgBasePrice=decimal.Parse(packageBasePriceTxt.Text);
            Package.PkgAgencyCommission=decimal.Parse(packageCommisionTxt.Text);
            DialogResult = DialogResult.OK;
        }

        private void addOrUpdatePackageFrm_Load(object sender, EventArgs e)
        {
            if (Package == null)
            {
                Text = "Add Package";
                Package = new PackageViewModel();
            }
            else
            {
                Text = "Update Product";
                DisplayPackageDetails();
            }
        }

        private void DisplayPackageDetails()
        {
            //packageIdTxt.Text=Package.PackageID.ToString();
            packageNameTxt.Text = Package.PkgName;
            PackageStartDateTxt.Value = (DateTime) Package.PkgStartDate;
            PackageEndDateTxt.Value = (DateTime)Package.PkgEndDate;
            packageDescTxt.Text = Package.PkgDesc;
            packageBasePriceTxt.Text= Package.PkgBasePrice.ToString();
            packageCommisionTxt.Text=Package.PkgAgencyCommission.ToString();
            packageIdTxt.Focus();
        }
    }
}
