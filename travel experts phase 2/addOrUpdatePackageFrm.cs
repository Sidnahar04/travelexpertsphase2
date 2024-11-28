using travel_experts_phase_2.Controllers;
using travel_experts_phase_2.Models;
using travel_experts_phase_2.ViewModels;

namespace travel_experts_phase_2
{
    public partial class addOrUpdatePackageFrm : Form
    {
        public PackageViewModel Package { get; set; } = null!;
        public bool IsViewPackage { get; set; } = false;
        private Product selectedProduct;
        public addOrUpdatePackageFrm()
        {
            InitializeComponent();
            displayProducts();
        }

        private void addOrUpdatePackageFrm_Load(object sender, EventArgs e)
        {
            if (Package == null)
            {
                Text = "Add Package";
                Package = new PackageViewModel();
            }
            else if (IsViewPackage)
            {
                Text = "View Package";
                DisplayPackageDetails();
                packageNameTxt.Enabled = false;
                PackageStartDateTxt.Enabled = false;
                PackageEndDateTxt.Enabled = false;
                packageDescTxt.Enabled = false;
                packageBasePriceTxt.Enabled = false;
                packageCommisionTxt.Enabled = false;
                productsCombo.Enabled = false;
            }
            else
            {
                Text = "Update Package";
                DisplayPackageDetails();
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInputs() && ValidateDates())
            {
                //Package.PackageId = int.Parse(packageIdTxt.Text);
                Package.PkgName = packageNameTxt.Text;
                Package.PkgDesc = packageDescTxt.Text;
                Package.PkgStartDate = PackageStartDateTxt.Value;
                Package.PkgEndDate = PackageEndDateTxt.Value;
                Package.PkgBasePrice = decimal.Parse(packageBasePriceTxt.Text);
                Package.PkgAgencyCommission = decimal.Parse(packageCommisionTxt.Text);
                DialogResult = DialogResult.OK;
            }
        }

        private void DisplayPackageDetails()
        {
            //packageIdTxt.Text = Package.PackageId.ToString();
            packageNameTxt.Text = Package.PkgName;
            PackageStartDateTxt.Value = (DateTime)Package.PkgStartDate;
            PackageEndDateTxt.Value = (DateTime)Package.PkgEndDate;
            packageDescTxt.Text = Package.PkgDesc;
            packageBasePriceTxt.Text = Package.PkgBasePrice.ToString();
            packageCommisionTxt.Text = Package.PkgAgencyCommission.ToString();
            SetSelectedProduct(Package.ProdName);
            packageNameTxt.Focus();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool ValidateInputs()
        {
            if (!Validator.IsNotEmpty(packageNameTxt.Text, "Package Name", packageNameTxt)) return false;
            if (!Validator.IsNotEmpty(packageDescTxt.Text, "Package Description", packageDescTxt)) return false;
            if (!Validator.IsNotEmpty(packageBasePriceTxt.Text, "Package Base Price", packageBasePriceTxt)) return false;
            if (!Validator.IsNotEmpty(packageCommisionTxt.Text, "Package Commission Price", packageCommisionTxt)) return false;

            if (!Validator.IsPositiveDecimal(packageBasePriceTxt.Text, "Package Base Price", packageBasePriceTxt)) return false;
            if (!Validator.IsPositiveDecimal(packageCommisionTxt.Text, "Package Commission Price", packageCommisionTxt)) return false;

            if (!Validator.IsCommissionValid(decimal.Parse(packageBasePriceTxt.Text), decimal.Parse(packageCommisionTxt.Text), packageCommisionTxt)) return false;

            if (!Validator.CheckCharacterLimit("Package Name", 50, packageNameTxt.Text, packageNameTxt)) return false;
            if (!Validator.CheckCharacterLimit("Package Description", 200, packageDescTxt.Text, packageDescTxt)) return false;

            return true;
        }

        public bool ValidateDates()
        {
            if (PackageStartDateTxt.Value >= PackageEndDateTxt.Value)
            {
                MessageBox.Show("End Date must be later than Start Date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PackageEndDateTxt.Focus();
                return false;
            }
            return true;
        }

        private void packageDescTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void displayProducts()
        {
            PackageController packageController = new PackageController();
            var products = packageController.GetAllProducts();

            // Bind products to the ComboBox
            productsCombo.DataSource = products;
            productsCombo.DisplayMember = "ProdName"; // Display name for the ComboBox
            productsCombo.ValueMember = "ProductId"; // Unique identifier for the ComboBox
        }

        private void productsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productsCombo.SelectedItem is Product selectedProduct && Package != null)
            {
                //selectedProductPackage = selectedProduct;
                Package.ProdName = selectedProduct.ProdName;
                Package.ProdID = selectedProduct.ProductId;
            }
        }

        public void SetSelectedProduct(string prodName)
        {
            var products = (List<Product>)productsCombo.DataSource;
            var selectedProduct = products.FirstOrDefault(p => p.ProdName == prodName);

            if (selectedProduct != null)
            {
                productsCombo.SelectedValue = selectedProduct.ProductId;
            }
        }
    }
}
