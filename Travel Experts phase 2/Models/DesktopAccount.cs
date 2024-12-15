using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace travel_experts_phase_2.Models
{
    [Index("Email", Name = "UQ__DesktopA__A9D10534E8F22383", IsUnique = true)]
    public partial class DesktopAccount
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
        [StringLength(64)]
        public string Password { get; set; } = null!;

        [ForeignKey("AdminId")]
        [InverseProperty("DesktopAccounts")]
        public virtual Admin? Admin { get; set; }
        [ForeignKey("AgentId")]
        [InverseProperty("DesktopAccounts")]
        public virtual Agent? Agent { get; set; }
        [ForeignKey("CustomerId")]
        [InverseProperty("DesktopAccounts")]
        public virtual Customer? Customer { get; set; }
    }
}
