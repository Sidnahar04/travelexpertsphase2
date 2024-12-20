﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travel_experts_phase_2.ViewModels
{
    public class PackageViewModel
    {
        public int PackageId {  get; set; }
        public string PkgName { get; set; }
        public DateTime? PkgStartDate { get; set; }
        public DateTime? PkgEndDate { get; set; }
        public string PkgDesc { get; set; }
        public decimal? PkgBasePrice { get; set; }
        public decimal? PkgAgencyCommission { get; set; }
        public string ProdName { get; set; }
        public int ProdID { get; set; }
    }
}
