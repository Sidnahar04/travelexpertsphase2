﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace travel_experts_phase_2.Models
{
    public partial class Reward
    {
        public Reward()
        {
            CustomersRewards = new HashSet<CustomersReward>();
        }

        [Key]
        public int RewardId { get; set; }
        [StringLength(50)]
        public string? RwdName { get; set; }
        [StringLength(50)]
        public string? RwdDesc { get; set; }

        [InverseProperty("Reward")]
        public virtual ICollection<CustomersReward> CustomersRewards { get; set; }
    }
}
