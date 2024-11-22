using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using travel_experts_phase_2.Models;

namespace travel_experts_phase_2
{
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }
        private void Suppliers_Load(object sender, EventArgs e)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                //get suppliers from db and then display them
                //List<Supplier>
                var suppliers = db.Suppliers.Select(
                  s => new
                  {
                      s.SupplierId,
                      s.SupName

                  }).ToList();
                SupplierView.DataSource = suppliers;

            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string keyword = SearchBox.Text;

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            /*SearchBox_TextChanged();
            var suppliers = db.Suppliers.Select(
                  s => new {
                      s.SupplierId,
                      s.SupName

                  }).ToList();
            SupplierView.DataSource = suppliers;*/
        }

       
    }
}
