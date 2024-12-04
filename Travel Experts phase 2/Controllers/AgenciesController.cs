using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using travel_experts_phase_2.Models;
using travel_experts_phase_2.ViewModels;

namespace travel_experts_phase_2.Controllers
{
    public class AgencyController
    {
        public List<AgenciesViewModel> GetAllAgencies()
        {
            var agencies = new List<AgenciesViewModel>();
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                agencies = db.Agencies.Select(agencies => new AgenciesViewModel
                {
                    AgencyId = agencies.AgencyId,
                    AgencyAdress = agencies.AgncyAddress,
                    AgencyCity = agencies.AgncyCity,
                    AgencyProvince = agencies.AgncyProv,
                    AgencyCountry = agencies.AgncyCountry,
                    AgencyPostal = agencies.AgncyPostal,
                    AgencyPhone = agencies.AgncyPostal,
                    AgencyFax = agencies.AgncyFax
                }
                ).ToList;

                return agencies;
            }
        }
    }
}
