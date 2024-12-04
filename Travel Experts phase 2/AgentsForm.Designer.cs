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
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            middleInitialDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            agentViewModelBindingSource = new BindingSource(components);
            agentBindingSource = new BindingSource(components);
            btnAddAgent = new Button();
            btnUpdateAgent = new Button();
            btnDeleteAgent = new Button();
            agencyBindingSource = new BindingSource(components);
            agentControllerBindingSource = new BindingSource(components);
            lblAgentsTable = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtInitial = new TextBox();
            lblInitial = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtRoles = new TextBox();
            lblRoles = new Label();
            cmbAgentId = new ComboBox();
            lblAgentId = new Label();
            backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)gdvAgentsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agentViewModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agencyBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agentControllerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // gdvAgentsTable
            // 
            gdvAgentsTable.AutoGenerateColumns = false;
            gdvAgentsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdvAgentsTable.Columns.AddRange(new DataGridViewColumn[] { firstNameDataGridViewTextBoxColumn, middleInitialDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, roleDataGridViewTextBoxColumn });
            gdvAgentsTable.DataSource = agentViewModelBindingSource;
            gdvAgentsTable.Location = new Point(23, 56);
            gdvAgentsTable.Name = "gdvAgentsTable";
            gdvAgentsTable.RowHeadersWidth = 51;
            gdvAgentsTable.RowTemplate.Height = 29;
            gdvAgentsTable.Size = new Size(804, 194);
            gdvAgentsTable.TabIndex = 0;
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
            // agentViewModelBindingSource
            // 
            agentViewModelBindingSource.DataSource = typeof(ViewModels.AgentViewModel);
            // 
            // agentBindingSource
            // 
            agentBindingSource.DataSource = typeof(Models.Agent);
            // 
            // btnAddAgent
            // 
            btnAddAgent.BackColor = SystemColors.ActiveCaption;
            btnAddAgent.Location = new Point(23, 285);
            btnAddAgent.Name = "btnAddAgent";
            btnAddAgent.Size = new Size(148, 39);
            btnAddAgent.TabIndex = 2;
            btnAddAgent.Text = "Add a New Agent";
            btnAddAgent.UseVisualStyleBackColor = false;
            btnAddAgent.Click += btnAddAgent_Click;
            // 
            // btnUpdateAgent
            // 
            btnUpdateAgent.BackColor = SystemColors.ActiveCaption;
            btnUpdateAgent.Location = new Point(23, 347);
            btnUpdateAgent.Name = "btnUpdateAgent";
            btnUpdateAgent.Size = new Size(255, 42);
            btnUpdateAgent.TabIndex = 3;
            btnUpdateAgent.Text = "Update Above Agent Information";
            btnUpdateAgent.UseVisualStyleBackColor = false;
            btnUpdateAgent.Click += btnUpdateAgent_Click;
            // 
            // btnDeleteAgent
            // 
            btnDeleteAgent.BackColor = SystemColors.ActiveCaption;
            btnDeleteAgent.Location = new Point(23, 411);
            btnDeleteAgent.Name = "btnDeleteAgent";
            btnDeleteAgent.Size = new Size(255, 38);
            btnDeleteAgent.TabIndex = 4;
            btnDeleteAgent.Text = "Delete Selected Agent Information";
            btnDeleteAgent.UseVisualStyleBackColor = false;
            btnDeleteAgent.Click += btnDeleteAgent_Click;
            // 
            // agencyBindingSource
            // 
            agencyBindingSource.DataSource = typeof(Models.Agency);
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
            // txtFirstName
            // 
            txtFirstName.Location = new Point(422, 297);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 6;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(422, 274);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 7;
            lblFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(570, 297);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 8;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(570, 274);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 9;
            lblLastName.Text = "Last Name";
            // 
            // txtInitial
            // 
            txtInitial.Location = new Point(356, 355);
            txtInitial.Name = "txtInitial";
            txtInitial.Size = new Size(70, 27);
            txtInitial.TabIndex = 10;
            // 
            // lblInitial
            // 
            lblInitial.AutoSize = true;
            lblInitial.Location = new Point(352, 332);
            lblInitial.Name = "lblInitial";
            lblInitial.Size = new Size(116, 20);
            lblInitial.TabIndex = 11;
            lblInitial.Text = "Initial (optional)";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(491, 332);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(491, 355);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(204, 27);
            txtEmail.TabIndex = 13;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(356, 422);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 14;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(352, 399);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(108, 20);
            lblPhone.TabIndex = 15;
            lblPhone.Text = "Phone Number";
            // 
            // txtRoles
            // 
            txtRoles.Location = new Point(570, 422);
            txtRoles.Name = "txtRoles";
            txtRoles.Size = new Size(125, 27);
            txtRoles.TabIndex = 16;
            // 
            // lblRoles
            // 
            lblRoles.AutoSize = true;
            lblRoles.Location = new Point(570, 399);
            lblRoles.Name = "lblRoles";
            lblRoles.Size = new Size(39, 20);
            lblRoles.TabIndex = 17;
            lblRoles.Text = "Role";
            // 
            // cmbAgentId
            // 
            cmbAgentId.FormattingEnabled = true;
            cmbAgentId.Location = new Point(231, 297);
            cmbAgentId.Name = "cmbAgentId";
            cmbAgentId.Size = new Size(76, 28);
            cmbAgentId.TabIndex = 18;
            // 
            // lblAgentId
            // 
            lblAgentId.AutoSize = true;
            lblAgentId.Location = new Point(231, 274);
            lblAgentId.Name = "lblAgentId";
            lblAgentId.Size = new Size(76, 20);
            lblAgentId.TabIndex = 19;
            lblAgentId.Text = "Account #";
            // 
            // backButton
            // 
            backButton.BackColor = SystemColors.ActiveCaption;
            backButton.Location = new Point(687, 474);
            backButton.Name = "backButton";
            backButton.Size = new Size(140, 41);
            backButton.TabIndex = 21;
            backButton.Text = "Back to Home";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // AgentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 527);
            Controls.Add(backButton);
            Controls.Add(lblAgentId);
            Controls.Add(cmbAgentId);
            Controls.Add(lblRoles);
            Controls.Add(txtRoles);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblInitial);
            Controls.Add(txtInitial);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblAgentsTable);
            Controls.Add(btnDeleteAgent);
            Controls.Add(btnUpdateAgent);
            Controls.Add(btnAddAgent);
            Controls.Add(gdvAgentsTable);
            Name = "AgentsForm";
            Text = "Agents";
            Load += AgentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)gdvAgentsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)agentViewModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)agentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)agencyBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)agentControllerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox txtFirstName;
        private Label lblFirstName;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtInitial;
        private Label lblInitial;
        private Label lblEmail;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Label lblPhone;
        private TextBox txtRoles;
        private Label lblRoles;
        private ComboBox cmbAgentId;
        private Label lblAgentId;
        private Button backButton;
    }
}