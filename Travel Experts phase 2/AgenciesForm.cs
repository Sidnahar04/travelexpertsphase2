using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
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
                AgencyId = int.Parse(txtAgencyId.Text),
                AgncyAddress = txtAgencyAddress.Text,
                AgncyCity = txtAgencyCity.Text,
                AgncyProv = txtAgencyProvince.Text,
                AgncyCountry = txtAgencyCountry.Text,
                AgncyPhone = txtAgencyPhone.Text,
                AgncyPostal = txtAgencyPostal.Text,
                AgncyFax = txtAgencyFax.Text
            };
            if (txtAgencyId == null)
            {
                MessageBox.Show("Please enter an Agency Id number");
            }
            if (txtAgencyAddress == null)
            {
                MessageBox.Show("Please enter an Agencies Address");
            }
            if (txtAgencyCity == null)
            {
                MessageBox.Show("Please enter an Agencies City");
            }
            if (txtAgencyProvince == null)
            {
                MessageBox.Show("Please enter an Agencies Province");
            }
            if (txtAgencyCountry == null)
            {
                MessageBox.Show("Please enter an Agencies Country");
            }
            if (txtAgencyPhone == null)
            {
                MessageBox.Show("Please enter an Agency Phone Number");
            }
            if (txtAgencyPostal == null)
            {
                MessageBox.Show("Please enter an Agency Postal Number");
            }
            if (txtAgencyFax == null)
            {
                MessageBox.Show("Please enter an Agency Fax Number");
            }
            else
            {
                //Agency agency = newAgency;
                using (var context = new TravelExpertsContext())
                {
                    context.Agencies.Add(newAgency);
                    context.SaveChanges();
                }

            }
        }

        private void btnEditAgency_Click(object sender, EventArgs e)
        {
            using (var context = new TravelExpertsContext())
            {
                var agencies = context.Agencies.FirstOrDefault();
                if (agencies != null)
                {
                    if (txtAgencyAddress != null)
                    {
                        agencies.AgncyAddress = txtAgencyAddress.Text;
                    }
                    if (txtAgencyCity != null)
                    {
                        agencies.AgncyCity = txtAgencyCity.Text;
                    }
                    if (txtAgencyProvince != null)
                    {
                        agencies.AgncyProv = txtAgencyProvince.Text;
                    }
                    if (txtAgencyCountry != null)
                    {
                        agencies.AgncyCountry = txtAgencyCountry.Text;
                    }
                    if (txtAgencyPhone != null)
                    {
                        agencies.AgncyPhone = txtAgencyPhone.Text;
                    }
                    if (txtAgencyPostal != null)
                    {
                        agencies.AgncyPostal = txtAgencyPostal.Text;
                    }
                    if (txtAgencyFax != null)
                    {
                        agencies.AgncyFax = txtAgencyFax.Text;
                    }
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
