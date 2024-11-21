using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using travel_experts_phase_2.Models;
using travel_experts_phase_2.ViewModels;

namespace travel_experts_phase_2.Controllers
{
    public class AgentController
    {
        public List<AgentViewModel> GetAllAgents()
        {

            var agents = new List<AgentViewModel>();
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                agents = db.Agents.Select(agent => new AgentViewModel
                {
                    FirstName = agent.AgtFirstName,
                    MiddleInitial = agent.AgtMiddleInitial,
                    LastName = agent.AgtLastName,
                    Email = agent.AgtEmail,
                    PhoneNumber = agent.AgtBusPhone,
                    Role = agent.AgtPosition
                }
                    ).ToList();

                return agents;
            }
        }

        public bool IsUserAnAgent(string email)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                Agent? user = db.Agents.FirstOrDefault(agent => agent.AgtEmail == email);
                return user != null;
            }
        }
    }
}
