using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using travel_experts_phase_2.Models;

namespace travel_experts_phase_2.ViewModels
{
    public class AgenciesViewModel
    {
        public int AgencyId { get; set; }
        public string AgencyAdress { get; set; }
        public string AgencyCity { get; set; }
        public string AgencyProvince { get; set; }
        public string AgencyPostal { get; set; }
        public string AgencyCountry { get; set; }
        public string AgencyPhone { get; set; }
        public string AgencyFax { get; set; }
    }
}
