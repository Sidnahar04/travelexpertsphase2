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
    public partial class AgenciesForm : Form
    {
        public AgenciesForm()
        {
            InitializeComponent();
            PopulateGridView();
        }

        private void PopulateGridView()
        {
            AgencyController agencyController = new AgencyController();
            List<AgenciesViewModel> agencies = agencyController.GetAllAgencies();
            grdAgencies.DataSource = agencies;
        }

        private void btnAddAgency_Click(object sender, EventArgs e)
        {
            Agency newAgency = new Agency
            {
                //AgencyId = txtAgencyId.Text,
                AgncyAddress = txtAgencyAddress.Text,
                AgncyCity = txtAgencyCity.Text,
                AgncyProv = txtAgencyProvince.Text,
                AgncyCountry = txtAgencyCountry.Text,
                AgncyPhone = txtAgencyPhone.Text,
                AgncyPostal = txtAgencyPostal.Text,
                AgncyFax = txtAgencyFax.Text
            };
            Agency agency = newAgency;
            using (var context = new TravelExpertsContext())
            {
                context.Agencies.Add(agency);
                context.SaveChanges();
            }
        }

        private void btnEditAgency_Click(object sender, EventArgs e)
        {
            using (var context = new TravelExpertsContext())
            {
                var agencies = context.Agencies.FirstOrDefault();
                if (agencies != null)
                {
                    agencies.AgncyAddress = txtAgencyAddress.Text;
                    agencies.AgncyCity = txtAgencyCity.Text;
                    agencies.AgncyProv = txtAgencyProvince.Text;
                    agencies.AgncyCountry = txtAgencyCountry.Text;
                    agencies.AgncyPhone = txtAgencyPhone.Text;
                    agencies.AgncyPostal = txtAgencyPostal.Text;
                    agencies.AgncyFax = txtAgencyFax.Text;
                    context.SaveChanges();
                }
            }
        }

        private void btnDeleteAgency_Click(object sender, EventArgs e)
        {
            using (var context = new TravelExpertsContext())
            {
                var agencies = context.Agencies.FirstOrDefault();
                if (agencies != null)
                {
                    context.Agencies.Remove(agencies);
                    context.SaveChanges();
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgenciesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
