﻿using System;
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

        Supplier = new SuppliersViewModel();

            SupplierController supplierController = new SupplierController();
            selectedSupplier = Supplier;
            supplierController.AddSupplier(selectedSupplier);
            displaySuppliers();


            AddLbl.Visible = true;
            UpdateLbl.Visible = false;
            SupNameLbl.Visible = true;
            NameAddBox.Visible = true;
            confirmBtn.Visible = true;
            cancelBtn.Visible = true;
            NameAddBox.Visible = true;
            NameAddBox.Text = string.Empty;

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Supplier = new SuppliersViewModel();

            if (SupplierView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = SupplierView.SelectedRows[0];


                Supplier = supplierController.ConvertToSuppliersViewModel(selectedRow);




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

                var filteredPackages = supplierController.GetAllSuppliers()
                    .Where(s => s.SupplierName.ToLower().Contains(FilterText))
                    .ToList();

                // Display the filtered packages in the DataGridView
                SupplierView.DataSource = filteredPackages;
            }
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            String viewDisp;
            if (SupplierView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = SupplierView.SelectedRows[0];

                viewDisp = supplierController.ConvertToSuppliersViewModel(selectedRow).ToString(); ;

            }
            else
            {
                MessageBox.Show("Please select a row to modify.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            MessageBox.Show("Operation Cancelled");



        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {








            
            AddLbl.Visible = false;
            UpdateLbl.Visible = false;
            SupNameLbl.Visible = false;
            NameAddBox.Visible = false;
            confirmBtn.Visible = false;
            cancelBtn.Visible = false;
            NameAddBox.Visible = false;
            NameAddBox.Text = string.Empty;

        }


    }
}