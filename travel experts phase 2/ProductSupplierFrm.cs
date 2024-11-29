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
                DataPropertyName = "SupName",
                HeaderText = "Supplier Name",
                Width = 250
            });
            dgvProductSupplier.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProdName",
                HeaderText = "Product Name",
                Width = 250
            });
        }

        private void editbtn_Click(object sender, EventArgs e)
        {

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
