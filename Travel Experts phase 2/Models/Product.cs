using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace travel_experts_phase_2.Models
{
    [Index("ProductId", Name = "ProductId")]
    public partial class Product
    {
        public Product()
        {
            ProductsPackages = new HashSet<ProductsPackage>();
            ProductsSuppliers = new HashSet<ProductsSupplier>();
        }

        [Key]
        public int ProductId { get; set; }
        [StringLength(50)]
        public string ProdName { get; set; } = null!;

        [InverseProperty("Product")]
        public virtual ICollection<ProductsPackage> ProductsPackages { get; set; }
        [InverseProperty("Product")]
        public virtual ICollection<ProductsSupplier> ProductsSuppliers { get; set; }
    }
}
