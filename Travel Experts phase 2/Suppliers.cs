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
    public partial class Suppliers : Form
    {
        SupplierController supplierController = new SupplierController();

        public Suppliers()
        {
            InitializeComponent();
        }
        private void Suppliers_Load(object sender, EventArgs e)
        {
            List<SuppliersViewModel> supplier = supplierController.GetAllSuppliers();
            SupplierView.DataSource = supplier;
        }

       

        private void AddBtn_Click(object sender, EventArgs e)
        {



        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {

        }
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}