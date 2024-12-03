using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using travel_experts_phase_2.Controllers;
using travel_experts_phase_2.Models;
using travel_experts_phase_2.ViewModels;

namespace travel_experts_phase_2
{
    public partial class Suppliers : Form
    {
        public SuppliersViewModel Supplier { get; set; } = null!;

        SupplierController supplierController = new SupplierController();
        SuppliersViewModel selectedSupplier = null;

        public Suppliers()
        {
            InitializeComponent();
        }
        private void Suppliers_Load(object sender, EventArgs e)
        {
            List<SuppliersViewModel> supplier = supplierController.GetAllSuppliers();
            SupplierView.DataSource = supplier;
            AddLbl.Visible = false;
            UpdateLbl.Visible = false;
            SupNameLbl.Visible = false;
            NameAddBox.Visible = false;
            confirmBtn.Visible = false;
            cancelBtn.Visible = false;
            NameAddBox.Visible = false;
            NameAddBox.Text = string.Empty;
            selectedSupplierIdTextbox.Visible = false;
            selectedSupplierIdlabel.Visible = false;

        }

        private void displaySuppliers()
        {
            SupplierController supplierController = new SupplierController();
            List<SuppliersViewModel> supplier = supplierController.GetAllSuppliers();
            SupplierView.DataSource = supplier;

        }

        private void SupplierView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = SupplierView.SelectedRows[0];

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            selectedSupplierIdTextbox.ReadOnly = false;
            confirmBtn.Visible = false;
            confrimAddButton.Visible = true;

            selectedSupplierIdTextbox.ReadOnly = false;

            selectedSupplierIdTextbox.Visible = true;
            selectedSupplierIdlabel.Visible = true;
            AddLbl.Visible = true;
            UpdateLbl.Visible = false;
            SupNameLbl.Visible = true;
            NameAddBox.Visible = true;
            confirmBtn.Visible = true;
            cancelBtn.Visible = true;
            NameAddBox.Visible = true;
            NameAddBox.Text = string.Empty;
            selectedSupplierIdTextbox.Text = string.Empty;

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

            selectedSupplierIdTextbox.ReadOnly = true;
            selectedSupplierIdTextbox.Visible = true;
            selectedSupplierIdlabel.Visible = true;
            confirmBtn.Visible = true;
            confrimAddButton.Visible = false;
            Supplier = new SuppliersViewModel();

            if (SupplierView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = SupplierView.SelectedRows[0];

                Supplier = supplierController.ConvertToSuppliersViewModel(selectedRow);
                NameAddBox.Visible = true;
                SupNameLbl.Visible = true;
                NameAddBox.Text = Supplier.SupplierName;
                selectedSupplierIdTextbox.Text = Supplier.SupplierId.ToString();
                confirmBtn.Visible = true;




            }
            else 
            {
                MessageBox.Show("Please select a row to modify.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            AddLbl.Visible = false;
            UpdateLbl.Visible = true;
            SupNameLbl.Visible = true;
            NameAddBox.Visible = true;
            confirmBtn.Visible = true;
            cancelBtn.Visible = true;
            NameAddBox.Visible = true;
            NameAddBox.Text = string.Empty;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (SupplierView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = SupplierView.SelectedRows[0];
                var supplierDelete = supplierController.ConvertToSupplierFromDataGrid(selectedRow);
                DialogResult result = MessageBox.Show($"Are you sure you want to delete supplier: {supplierDelete.SupName}?",
                    "Confirm Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    supplierController.deleteSupplier(supplierDelete);
                    displaySuppliers();
                    MessageBox.Show("Supplier Deleted");

                }
            }
            else
            {
                MessageBox.Show("No supplier selected. Please select a supplier.");
            }

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {

        }
        public void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchBox.Text))
            {
                displaySuppliers();
            }
            else
            {
                string FilterText = SearchBox.Text.ToLower();

                var filteredSupplierss = supplierController.GetAllSuppliers()
                    .Where(s => s.SupplierName.ToLower().Contains(FilterText))
                    .ToList();

                // Display the filtered suppliers in the DataGridView
                SupplierView.DataSource = filteredSupplierss;
            }
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            String viewDisp;
            if (SupplierView.SelectedRows.Count > 0)
            {
                selectedSupplierIdTextbox.ReadOnly = true;
                DataGridViewRow selectedRow = SupplierView.SelectedRows[0];

                SuppliersViewModel selectedRowViewModel = supplierController.ConvertToSuppliersViewModel(selectedRow);
                NameAddBox.Visible = true;
                SupNameLbl.Visible = true;
                NameAddBox.Text = selectedRowViewModel.SupplierName;
                selectedSupplierIdTextbox.Text = selectedRowViewModel.SupplierId.ToString();
                selectedSupplierIdTextbox.Visible = true;
                selectedSupplierIdlabel.Visible = true;
                confrimAddButton.Visible = false;
                confirmBtn.Visible = false;
                cancelBtn.Visible = false;
            }
            else
            {
                MessageBox.Show("Please select a row to view.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            AddLbl.Visible = false;
            UpdateLbl.Visible = false;
            SupNameLbl.Visible = false;
            NameAddBox.Visible = false;
            confirmBtn.Visible = false;
            cancelBtn.Visible = false;
            NameAddBox.Visible = false;
            NameAddBox.Text = string.Empty;
            selectedSupplierIdlabel.Visible = false;
            selectedSupplierIdTextbox.Visible = false;
            SupNameLbl.Visible = false;
            NameAddBox.Visible = false;
            confrimAddButton.Visible = false;

            MessageBox.Show("Operation Cancelled");



        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (SupplierValidation()) {

                SuppliersViewModel supplierViewModel = new SuppliersViewModel { SupplierId = int.Parse(selectedSupplierIdTextbox.Text), SupplierName = NameAddBox.Text };

                supplierController.UpdateSupplier(supplierViewModel);

                AddLbl.Visible = false;
                UpdateLbl.Visible = false;
                confirmBtn.Visible = false;
                cancelBtn.Visible = false;
                NameAddBox.Visible = false;
                NameAddBox.Text = string.Empty;
                selectedSupplierIdlabel.Visible = false;
                selectedSupplierIdTextbox.Visible = false;
                SupNameLbl.Visible = false;
                NameAddBox.Visible = false;
                displaySuppliers();
                MessageBox.Show("Supplier Updated");

            }

        }

        private void confrimAddButton_Click(object sender, EventArgs e)
        {
            if (SupplierValidation() && SupplierIDValidation())
            {
                SuppliersViewModel supplierViewModel = new SuppliersViewModel
                {
                    SupplierId = int.Parse(selectedSupplierIdTextbox.Text),
                    SupplierName = NameAddBox.Text
                };

                supplierController.AddSupplier(supplierViewModel);
                displaySuppliers();
                selectedSupplierIdlabel.Visible = false;
                selectedSupplierIdTextbox.Visible = false;
                SupNameLbl.Visible = false;
                NameAddBox.Visible = false;
                confrimAddButton.Visible = false;
                confirmBtn.Visible = false;
                cancelBtn.Visible = false;
                AddLbl.Visible = false;
                MessageBox.Show("Supplier Added");


            }
        }

        public bool SupplierValidation()
        {
            if (!Validator.IsNotEmpty(NameAddBox.Text, "Supplier Name", NameAddBox)) return false;

            return true;
        }
        public bool SupplierIDValidation()
        {
            if (!Validator.IsPositiveInt(selectedSupplierIdTextbox.Text, "Supplier ID", selectedSupplierIdTextbox)) return false;

            return true;
        }
       
            

        
    }
}
