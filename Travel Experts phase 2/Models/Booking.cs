﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace travel_experts_phase_2.Models
{
    [Index("CustomerId", Name = "BookingsCustomerId")]
    [Index("CustomerId", Name = "CustomersBookings")]
    [Index("PackageId", Name = "PackageId")]
    [Index("PackageId", Name = "PackagesBookings")]
    [Index("TripTypeId", Name = "TripTypesBookings")]
    public partial class Booking
    {
        public Booking()
        {
            BookingDetails = new HashSet<BookingDetail>();
        }

        [Key]
        public int BookingId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BookingDate { get; set; }
        [StringLength(50)]
        public string? BookingNo { get; set; }
        public double? TravelerCount { get; set; }
        public int? CustomerId { get; set; }
        [StringLength(1)]
        public string? TripTypeId { get; set; }
        public int? PackageId { get; set; }
        [Column("paymentStatus")]
        [StringLength(50)]
        public string PaymentStatus { get; set; } = null!;
        [Column("balance", TypeName = "decimal(10, 2)")]
        public decimal Balance { get; set; }
        [Column("totalPaid", TypeName = "decimal(10, 2)")]
        public decimal TotalPaid { get; set; }

        [ForeignKey("CustomerId")]
        [InverseProperty("Bookings")]
        public virtual Customer? Customer { get; set; }
        [ForeignKey("PackageId")]
        [InverseProperty("Bookings")]
        public virtual Package? Package { get; set; }
        [ForeignKey("TripTypeId")]
        [InverseProperty("Bookings")]
        public virtual TripType? TripType { get; set; }
        [InverseProperty("Booking")]
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
    }
}
