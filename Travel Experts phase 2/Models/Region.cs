﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace travel_experts_phase_2.Models
{
    public partial class Region
    {
        public Region()
        {
            BookingDetails = new HashSet<BookingDetail>();
        }

        [Key]
        [StringLength(5)]
        public string RegionId { get; set; } = null!;
        [StringLength(25)]
        public string? RegionName { get; set; }

        [InverseProperty("Region")]
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
    }
}
