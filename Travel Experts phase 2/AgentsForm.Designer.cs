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
            components = new System.ComponentModel.Container();
            gdvAgentsTable = new DataGridView();
            agentBindingSource = new BindingSource(components);
            btnAddAgent = new Button();
            btnUpdateAgent = new Button();
            btnDeleteAgent = new Button();
            agencyBindingSource = new BindingSource(components);
            agentViewModelBindingSource = new BindingSource(components);
            agentControllerBindingSource = new BindingSource(components);
            lblAgentsTable = new Label();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            middleInitialDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gdvAgentsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agencyBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agentViewModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agentControllerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // gdvAgentsTable
            // 
            gdvAgentsTable.AutoGenerateColumns = false;
            gdvAgentsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdvAgentsTable.Columns.AddRange(new DataGridViewColumn[] { firstNameDataGridViewTextBoxColumn, middleInitialDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, roleDataGridViewTextBoxColumn });
            gdvAgentsTable.DataSource = agentViewModelBindingSource;
            gdvAgentsTable.Location = new Point(23, 54);
            gdvAgentsTable.Name = "gdvAgentsTable";
            gdvAgentsTable.RowHeadersWidth = 51;
            gdvAgentsTable.RowTemplate.Height = 29;
            gdvAgentsTable.Size = new Size(742, 194);
            gdvAgentsTable.TabIndex = 0;
            // 
            // agentBindingSource
            // 
            agentBindingSource.DataSource = typeof(Models.Agent);
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
            // agencyBindingSource
            // 
            agencyBindingSource.DataSource = typeof(Models.Agency);
            // 
            // agentViewModelBindingSource
            // 
            agentViewModelBindingSource.DataSource = typeof(ViewModels.AgentViewModel);
            // 
            // agentControllerBindingSource
            // 
            agentControllerBindingSource.DataSource = typeof(Controllers.AgentController);
            // 
            // lblAgentsTable
            // 
            lblAgentsTable.BorderStyle = BorderStyle.FixedSingle;
            lblAgentsTable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAgentsTable.Location = new Point(23, 9);
            lblAgentsTable.Name = "lblAgentsTable";
            lblAgentsTable.Size = new Size(192, 35);
            lblAgentsTable.TabIndex = 5;
            lblAgentsTable.Text = "All Current Agents";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // middleInitialDataGridViewTextBoxColumn
            // 
            middleInitialDataGridViewTextBoxColumn.DataPropertyName = "MiddleInitial";
            middleInitialDataGridViewTextBoxColumn.HeaderText = "MiddleInitial";
            middleInitialDataGridViewTextBoxColumn.MinimumWidth = 6;
            middleInitialDataGridViewTextBoxColumn.Name = "middleInitialDataGridViewTextBoxColumn";
            middleInitialDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            roleDataGridViewTextBoxColumn.HeaderText = "Role";
            roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            roleDataGridViewTextBoxColumn.Width = 125;
            // 
            // AgentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAgentsTable);
            Controls.Add(btnDeleteAgent);
            Controls.Add(btnUpdateAgent);
            Controls.Add(btnAddAgent);
            Controls.Add(gdvAgentsTable);
            Name = "AgentsForm";
            Text = "Agents";
            ((System.ComponentModel.ISupportInitialize)gdvAgentsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)agentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)agencyBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)agentViewModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)agentControllerBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gdvAgentsTable;
        private Button btnAddAgent;
        private Button btnUpdateAgent;
        private Button btnDeleteAgent;
        private BindingSource agentBindingSource;
        private BindingSource agencyBindingSource;
        private BindingSource agentViewModelBindingSource;
        private BindingSource agentControllerBindingSource;
        private Label lblAgentsTable;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn middleInitialDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
    }
}