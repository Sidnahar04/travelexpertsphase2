﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travel_experts_phase_2.ViewModels
{
    public class ProductSupplierViewModel
    {
        public int ProductSupplierId { get; set; }
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public string SupName { get; set; }
        public string ProdName { get; set; }
    }
}
