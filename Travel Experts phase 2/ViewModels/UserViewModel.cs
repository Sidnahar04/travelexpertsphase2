using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travel_experts_phase_2.ViewModels
{
    
        public class UserViewModel
        {
            public int Id { get; set; } // UserId
            public string Email { get; set; }
            public string Password { get; set; } // Plain text for simplicity; should handle hashed passwords
            public string Role { get; set; } // Admin, Agent, or Customer
            public int? AdminId { get; set; }
            public int? AgentId { get; set; }
            public int? CustomerId { get; set; }
        }
    
}
