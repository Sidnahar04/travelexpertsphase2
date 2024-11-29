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
using travel_experts_phase_2.Models;
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
            displayProducts();
            displaySuppliers();
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
            if (ProductSupplier == null)
            {
                Text = "Add Package";
                ProductSupplier = new ProductSupplierViewModel();
            }
            else
            {
                Text = "Update Package";
                setProductSuppliers(ProductSupplier);
            }
        }



        private void okBtn_Click(object sender, EventArgs e)
        {
            ProductSupplier.SupplierId = (int)supplierCombobox.SelectedValue;
            ProductSupplier.ProductId = (int)productcombo.SelectedValue;
            ProductSupplier.ProdName = productcombo.Text;
            ProductSupplier.SupName = supplierCombobox.Text;
            DialogResult = DialogResult.OK;
        }

        private void supplierCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (supplierCombobox.SelectedItem is ProductSupplierViewModel selectedSupplier && ProductSupplier !=null)
            {
                ProductSupplier.SupplierId = selectedSupplier.SupplierId;
                ProductSupplier.SupName = selectedSupplier.SupName;
            }
        }

        private void setProductSuppliers(ProductSupplierViewModel setprodSupplier)
        {
            if (setprodSupplier != null)
            {
                productcombo.SelectedValue = setprodSupplier.ProductId;
                supplierCombobox.SelectedValue = setprodSupplier.SupplierId;
            }
        }

        private void productcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productcombo.SelectedItem is ProductSupplierViewModel selectedProduct && ProductSupplier != null)
            {
                ProductSupplier.ProductId = selectedProduct.ProductId;
                ProductSupplier.ProdName = selectedProduct.ProdName;
            }
        }
    }
}
