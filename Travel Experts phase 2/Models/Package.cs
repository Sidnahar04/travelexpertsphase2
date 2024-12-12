using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace travel_experts_phase_2.Models
{
    public partial class Package
    {
        public Package()
        {
            Bookings = new HashSet<Booking>();
            PackagesProductsSuppliers = new HashSet<PackagesProductsSupplier>();
            ProductsPackages = new HashSet<ProductsPackage>();
        }

        [Key]
        public int PackageId { get; set; }
        [StringLength(50)]
        public string PkgName { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? PkgStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PkgEndDate { get; set; }
        [StringLength(50)]
        public string? PkgDesc { get; set; }
        [Column(TypeName = "money")]
        public decimal PkgBasePrice { get; set; }
        [Column(TypeName = "money")]
        public decimal? PkgAgencyCommission { get; set; }
        [Column("imagePath")]
        [StringLength(255)]
        [Unicode(false)]
        public string? ImagePath { get; set; }

        [InverseProperty("Package")]
        public virtual ICollection<Booking> Bookings { get; set; }
        [InverseProperty("Package")]
        public virtual ICollection<PackagesProductsSupplier> PackagesProductsSuppliers { get; set; }
        [InverseProperty("Package")]
        public virtual ICollection<ProductsPackage> ProductsPackages { get; set; }
    }
}
