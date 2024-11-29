using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using travel_experts_phase_2.Controllers;
using travel_experts_phase_2.ViewModels;

namespace travel_experts_phase_2
{
    public partial class addOrUpdateProductSupplierForm : Form
    {
        public ProductSupplierViewModel ProductSupplier { get; set; } = null;
        ProductSupplierController productSupplierController = new ProductSupplierController();

        public addOrUpdateProductSupplierForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void displayProducts()
        {
            var products = productSupplierController.GetAllProducts();

            // Bind products to the ComboBox
            productcombo.DataSource = products;
            productcombo.DisplayMember = "ProdName"; // Display name for the ComboBox
            productcombo.ValueMember = "ProductId"; // Unique identifier for the ComboBox
        }

        private void displaySuppliers()
        {
            var suppliers = productSupplierController.GetAllSuppliers();
            supplierCombobox.DataSource = suppliers;
            supplierCombobox.DisplayMember = "SupName";
            supplierCombobox.ValueMember = "SupplierId";
        }

        private void addOrUpdateProductSupplierForm_Load(object sender, EventArgs e)
        {
            displayProducts();
            displaySuppliers();
            ProductSupplier = new ProductSupplierViewModel();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            ProductSupplier.SupplierId = (int)supplierCombobox.SelectedValue;
            ProductSupplier.ProductId = (int)productcombo.SelectedValue;
            ProductSupplier.ProdName = productcombo.Text;
            ProductSupplier.SupName = supplierCombobox.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
