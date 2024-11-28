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
    public partial class ProductDetailForm : Form
    {
        public ProductViewModel Product { get; set; } = null!;
        public bool IsViewProduct { get; set; } = false;

        ProductController productController = new ProductController();
        public ProductDetailForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProductDetailForm_Load(object sender, EventArgs e)
        {
            productIdTextBox.Enabled = false;
            if (Product == null)
            {
                this.Text = "Add New Product";
                headerLabel.Text = "Add New Product";
                productIdTextBox.Enabled = false;
                addButton.Visible = true;
                updateButton.Visible = false;
                productNameTextBox.Enabled = true;
                Product = new ProductViewModel();
            }
            else if (IsViewProduct)
            {
                this.Text = "View Product";
                headerLabel.Text = "View Product";
                productIdTextBox.Enabled = false;
                addButton.Visible = false;
                updateButton.Visible = false;
                productNameTextBox.Enabled = false;
                displayProduct();
            }
            else
            {
                this.Text = "Update Product";
                headerLabel.Text = "Update Product";
                productIdTextBox.Enabled = false;
                addButton.Visible = false;
                updateButton.Visible = true;
                productNameTextBox.Enabled = true;
                displayProduct();
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            if (Validator.IsNotEmpty(productNameTextBox.Text, "Package Name", productNameTextBox)) {
                Product.ProductName = productNameTextBox.Text;
                DialogResult = DialogResult.OK;
            };
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            
            if (Validator.IsNotEmpty(productNameTextBox.Text, "Package Name", productNameTextBox)) {  
                Product.ProductName = productNameTextBox.Text;
                DialogResult = DialogResult.OK;
            };

        }
       
        private void displayProduct() {
            productIdTextBox.Text = Product.Id.ToString();
            productNameTextBox.Text = Product.ProductName;
            //DialogResult = DialogResult.OK;
        }
    }
}
