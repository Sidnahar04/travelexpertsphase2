namespace travel_experts_phase_2
{
    partial class AgentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gdvAgentsTable = new DataGridView();
            btnAgentTableView = new Button();
            btnAddAgent = new Button();
            btnUpdateAgent = new Button();
            btnDeleteAgent = new Button();
            ((System.ComponentModel.ISupportInitialize)gdvAgentsTable).BeginInit();
            SuspendLayout();
            // 
            // gdvAgentsTable
            // 
            gdvAgentsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdvAgentsTable.Location = new Point(23, 70);
            gdvAgentsTable.Name = "gdvAgentsTable";
            gdvAgentsTable.RowHeadersWidth = 51;
            gdvAgentsTable.RowTemplate.Height = 29;
            gdvAgentsTable.Size = new Size(325, 156);
            gdvAgentsTable.TabIndex = 0;
            // 
            // btnAgentTableView
            // 
            btnAgentTableView.BackColor = SystemColors.ActiveCaption;
            btnAgentTableView.Location = new Point(23, 12);
            btnAgentTableView.Name = "btnAgentTableView";
            btnAgentTableView.Size = new Size(325, 36);
            btnAgentTableView.TabIndex = 1;
            btnAgentTableView.Text = "Click to View All Available Agents";
            btnAgentTableView.UseVisualStyleBackColor = false;
            // 
            // btnAddAgent
            // 
            btnAddAgent.BackColor = SystemColors.ActiveCaption;
            btnAddAgent.Location = new Point(23, 265);
            btnAddAgent.Name = "btnAddAgent";
            btnAddAgent.Size = new Size(148, 39);
            btnAddAgent.TabIndex = 2;
            btnAddAgent.Text = "Add a New Agent";
            btnAddAgent.UseVisualStyleBackColor = false;
            // 
            // btnUpdateAgent
            // 
            btnUpdateAgent.BackColor = SystemColors.ActiveCaption;
            btnUpdateAgent.Location = new Point(23, 321);
            btnUpdateAgent.Name = "btnUpdateAgent";
            btnUpdateAgent.Size = new Size(192, 42);
            btnUpdateAgent.TabIndex = 3;
            btnUpdateAgent.Text = "Update Agent Information";
            btnUpdateAgent.UseVisualStyleBackColor = false;
            // 
            // btnDeleteAgent
            // 
            btnDeleteAgent.BackColor = SystemColors.ActiveCaption;
            btnDeleteAgent.Location = new Point(23, 377);
            btnDeleteAgent.Name = "btnDeleteAgent";
            btnDeleteAgent.Size = new Size(192, 38);
            btnDeleteAgent.TabIndex = 4;
            btnDeleteAgent.Text = "Delete Agent Information";
            btnDeleteAgent.UseVisualStyleBackColor = false;
            // 
            // AgentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteAgent);
            Controls.Add(btnUpdateAgent);
            Controls.Add(btnAddAgent);
            Controls.Add(btnAgentTableView);
            Controls.Add(gdvAgentsTable);
            Name = "AgentsForm";
            Text = "Agents";
            ((System.ComponentModel.ISupportInitialize)gdvAgentsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gdvAgentsTable;
        private Button btnAgentTableView;
        private Button btnAddAgent;
        private Button btnUpdateAgent;
        private Button btnDeleteAgent;
    }
}