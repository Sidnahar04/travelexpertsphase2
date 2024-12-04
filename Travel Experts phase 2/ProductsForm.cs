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
    public partial class ProductsForm : Form
    {
        ProductViewModel selectedProduct = null;
        public bool isViewProduct = false;
        ProductController productController = new ProductController();
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            displayAllProducts();
        }
        private void displayAllProducts()
        {
            List<ProductViewModel> products = productController.GetAllProducts();
            productsDataGridView.DataSource = products;
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            if (productsDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = productsDataGridView.SelectedRows[0];
                ProductDetailForm viewProductForm = new()
                {
                    Product = productController.ConvertToProductViewModel(selectedRow),
                    IsViewProduct = true
                };

                DialogResult result = viewProductForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    displayAllProducts();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to view.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (productsDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = productsDataGridView.SelectedRows[0];
                ProductDetailForm updateProductForm = new()
                {
                    Product = productController.ConvertToProductViewModel(selectedRow),
                };
                DialogResult result = updateProductForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    productController.UpdateProduct(updateProductForm.Product);
                    displayAllProducts();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to modify.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (productsDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = productsDataGridView.SelectedRows[0];
                var productToDelete = productController.ConvertToProductFromDataGrid(selectedRow);
                DialogResult result = MessageBox.Show($"Are you sure you want to delete {productToDelete.ProdName}?",
                    "Confirm Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    productController.deleteProduct(productToDelete);
                    displayAllProducts();
                }
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
                displayAllProducts();
            }
            else
            {
                string searchText = searchBox.Text.ToLower();

                var filteredPackages = productController.GetAllProducts()
                    .Where(p => p.ProductName.ToLower().Contains(searchText) ||
                                p.Id.ToString().ToLower().Contains(searchText))
                    .ToList();

                // Display the filtered packages in the DataGridView
                productsDataGridView.DataSource = filteredPackages;
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ProductDetailForm addProductForm = new()
            {
            };
            DialogResult result = addProductForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                productController.AddProduct(addProductForm.Product);
                displayAllProducts();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
