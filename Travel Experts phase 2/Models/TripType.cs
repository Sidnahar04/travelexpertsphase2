﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace travel_experts_phase_2.Models
{
    public partial class TripType
    {
        public TripType()
        {
            Bookings = new HashSet<Booking>();
        }

        [Key]
        [StringLength(1)]
        public string TripTypeId { get; set; } = null!;
        [Column("TTName")]
        [StringLength(25)]
        public string? Ttname { get; set; }

        [InverseProperty("TripType")]
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
