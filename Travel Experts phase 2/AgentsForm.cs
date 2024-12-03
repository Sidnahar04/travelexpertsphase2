using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using travel_experts_phase_2.Controllers;
using travel_experts_phase_2.Models;
using travel_experts_phase_2.ViewModels;

namespace travel_experts_phase_2
{
    public partial class AgentsForm : Form
    {
        public AgentsForm()
        {
            InitializeComponent();
        }

        //populating combobox
        private void PopulateComboBox()
        {
            AgentController agentController = new AgentController();
            List<AgentViewModel> agents = agentController.GetAllAgents();
            foreach (var AgentId in agents)
            {
                cmbAgentId.Items.Add(AgentId.FirstName);
            }
            gdvAgentsTable.DataSource = agents;
        }

        //using textbox info to create new agent 
        private void btnAddAgent_Click(object sender, EventArgs e)
        {
            Agent newAgent = new Agent
            {
                AgtFirstName = txtFirstName.Text,
                AgtMiddleInitial = txtInitial.Text,
                AgtLastName = txtLastName.Text,
                AgtEmail = txtEmail.Text,
                AgtBusPhone = txtPhone.Text,
                AgtPosition = txtRoles.Text
            };
            Agent agent = newAgent;
            using (var context = new TravelExpertsContext())
            {
                context.Agents.Add(agent);
                context.SaveChanges();
            }
            cmbAgentId.Items.Clear();
            PopulateComboBox();
        }

        //using textbox data to update agent info
        private void btnUpdateAgent_Click(object sender, EventArgs e)
        {
            using (var context = new TravelExpertsContext())
            {
                var agent = context.Agents.FirstOrDefault();
                if (agent != null)
                {
                    agent.AgtFirstName = txtFirstName.Text;
                    agent.AgtMiddleInitial = txtInitial.Text;
                    agent.AgtLastName = txtLastName.Text;
                    agent.AgtBusPhone = txtPhone.Text;
                    agent.AgtEmail = txtEmail.Text;
                    agent.AgtPosition = txtRoles.Text;
                    context.SaveChanges();
                }
            }
            cmbAgentId.Items.Clear();
            PopulateComboBox();
        }

        //using checkbox info for agent id to delete agent
        private void btnDeleteAgent_Click(object sender, EventArgs e)
        {
            using (var context = new TravelExpertsContext())
            {
                var agent = context.Agents.Where(a => a.AgtFirstName == txtFirstName.Text ).FirstOrDefault();
                if (agent != null)
                {
                    context.Agents.Remove(agent);
                    context.SaveChanges();
                }
            }
            cmbAgentId.Items.Clear();
            PopulateComboBox();
        }

        private void AgentsForm_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
        }
    }
}
