﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travel_experts_phase_2.ViewModels
{
    public class PackageViewModel
    {
        public string PkgName { get; set; }
        public DateTime? PkgStartDate { get; set; }
        public DateTime? PkgEndDate { get; set; }
        public string PkgDesc { get; set; }
        public decimal PkgBasePrice { get; set; }
        public decimal? PkgAgencyCommission { get; set; }
    }
}
