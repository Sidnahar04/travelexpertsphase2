﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace travel_experts_phase_2.Models
{
    [Index("Email", Name = "UQ__Users__A9D10534565CB852", IsUnique = true)]
    public partial class User
    {
        [Key]
        public int UserId { get; set; }
        [StringLength(100)]
        public string Email { get; set; } = null!;
        public int? AgentId { get; set; }
        public int? AdminId { get; set; }
        public int? CustomerId { get; set; }
        [StringLength(50)]
        public string Role { get; set; } = null!;
        [StringLength(255)]
        public string Password { get; set; } = null!;

        [ForeignKey("AdminId")]
        [InverseProperty("Users")]
        public virtual Admin? Admin { get; set; }
        [ForeignKey("AgentId")]
        [InverseProperty("Users")]
        public virtual Agent? Agent { get; set; }
        [ForeignKey("CustomerId")]
        [InverseProperty("Users")]
        public virtual Customer? Customer { get; set; }
    }
}
