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
    public partial class ProductSupplierFrm : Form
    {
        ProductSupplierViewModel selectedProductSupplier = null;

        ProductSupplierController productSupplierController = new ProductSupplierController();

        public ProductSupplierFrm()
        {
            InitializeComponent();
        }

        private void ProductSupplierFrm_Load(object sender, EventArgs e)
        {
            List<ProductSupplierViewModel> productSuppliers = productSupplierController.GetAllProductsAndSuppliers();

            dgvProductSupplier.AutoGenerateColumns = false;

            dgvProductSupplier.DataSource = productSuppliers;

            dgvProductSupplier.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SupName",
                DataPropertyName = "SupName",
                HeaderText = "Supplier Name",
                Width = 250
            });
            dgvProductSupplier.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name ="ProdName",
                DataPropertyName = "ProdName",
                HeaderText = "Product Name",
                Width = 250
            });
            dgvProductSupplier.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProductSupplierId", // Set the Name explicitly
                DataPropertyName = "ProductSupplierId",
                HeaderText = "ProductSupplierId",
                Visible = false
            });
            dgvProductSupplier.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProductId", // Set the Name explicitly
                DataPropertyName = "ProductId",
                HeaderText = "ProductId",
                Visible = false
            });
            dgvProductSupplier.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SupplierId", // Set the Name explicitly
                DataPropertyName = "SupplierId",
                HeaderText = "SupplierId",
                Visible = false
            });
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if(dgvProductSupplier.SelectedRows.Count > 0)
            {

                // Get the selected row
                DataGridViewRow selectedRow = dgvProductSupplier.SelectedRows[0];

                // Create and display the update form with the selected row's data
                addOrUpdateProductSupplierForm UpdateProductSupplierForm = new()
                {
                    ProductSupplier = productSupplierController.ConvertToProductSupplierModel(selectedRow)
                };
                DialogResult result = UpdateProductSupplierForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Get the updated package info from the form
                    var UpdatedProductSupplierInfo = UpdateProductSupplierForm.ProductSupplier;

                    // Update the package in the database
                    productSupplierController.UpdateProductSupplier(UpdatedProductSupplierInfo);

                    // Refresh the displayed packages
                    displayAllProductSuppliers();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to modify.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvProductSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductSupplier.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvProductSupplier.SelectedRows[0];

                addOrUpdatePackageFrm UpdatePackageForm = new()
                {
                    //Package = productSupplierController.ConvertToPackageModel(selectedRow)
                };

                DialogResult result = UpdatePackageForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    var UpdatedPackageInfo = UpdatePackageForm.Package;
                    //productSupplierController.UpdatePackage(UpdatedPackageInfo);
                    displayAllProductSuppliers();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void displayAllProductSuppliers()
        {
            List<ProductSupplierViewModel> productSuppliers = productSupplierController.GetAllProductsAndSuppliers();
            dgvProductSupplier.DataSource = productSuppliers;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            addOrUpdateProductSupplierForm addOrUpdateProductSupplierFrm = new();
            DialogResult result = addOrUpdateProductSupplierFrm.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedProductSupplier = addOrUpdateProductSupplierFrm.ProductSupplier;
                productSupplierController.AddProductSupplier(selectedProductSupplier);
                displayAllProductSuppliers();
            }
        }
    }
}
