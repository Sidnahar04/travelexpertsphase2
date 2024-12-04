namespace travel_experts_phase_2
{
    partial class AgenciesForm
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
            grdAgencies = new DataGridView();
            agencyBindingSource = new BindingSource(components);
            agencyBindingSource1 = new BindingSource(components);
            btnAddAgency = new Button();
            btnEditAgency = new Button();
            btnDeleteAgency = new Button();
            txtAgencyAddress = new TextBox();
            lblAgencyAddress = new Label();
            txtAgencyCity = new TextBox();
            lblAgencyCity = new Label();
            lblAgencyProvince = new Label();
            txtAgencyProvince = new TextBox();
            txtAgencyPhone = new TextBox();
            lblAgencyPhone = new Label();
            lblAgencyCountry = new Label();
            txtAgencyCountry = new TextBox();
            txtAgencyPostal = new TextBox();
            txtAgencyFax = new TextBox();
            lblAgencyPostal = new Label();
            lblAgencyFax = new Label();
            txtAgencyId = new TextBox();
            lblAgencyId = new Label();
            ((System.ComponentModel.ISupportInitialize)grdAgencies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agencyBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agencyBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // grdAgencies
            // 
            grdAgencies.AutoGenerateColumns = false;
            grdAgencies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdAgencies.DataSource = agencyBindingSource;
            grdAgencies.Location = new Point(35, 22);
            grdAgencies.Name = "grdAgencies";
            grdAgencies.RowHeadersWidth = 51;
            grdAgencies.RowTemplate.Height = 29;
            grdAgencies.Size = new Size(728, 207);
            grdAgencies.TabIndex = 0;
            // 
            // btnAddAgency
            // 
            btnAddAgency.BackColor = SystemColors.ActiveCaption;
            btnAddAgency.Location = new Point(37, 266);
            btnAddAgency.Name = "btnAddAgency";
            btnAddAgency.Size = new Size(135, 37);
            btnAddAgency.TabIndex = 1;
            btnAddAgency.Text = "Add Agency";
            btnAddAgency.UseVisualStyleBackColor = false;
            btnAddAgency.Click += btnAddAgency_Click;
            // 
            // btnEditAgency
            // 
            btnEditAgency.BackColor = SystemColors.ActiveCaption;
            btnEditAgency.Location = new Point(37, 319);
            btnEditAgency.Name = "btnEditAgency";
            btnEditAgency.Size = new Size(135, 37);
            btnEditAgency.TabIndex = 2;
            btnEditAgency.Text = "Edit Agency";
            btnEditAgency.UseVisualStyleBackColor = false;
            btnEditAgency.Click += btnEditAgency_Click;
            // 
            // btnDeleteAgency
            // 
            btnDeleteAgency.BackColor = SystemColors.ActiveCaption;
            btnDeleteAgency.Location = new Point(37, 375);
            btnDeleteAgency.Name = "btnDeleteAgency";
            btnDeleteAgency.Size = new Size(135, 37);
            btnDeleteAgency.TabIndex = 3;
            btnDeleteAgency.Text = "Delete Agency";
            btnDeleteAgency.UseVisualStyleBackColor = false;
            btnDeleteAgency.Click += btnDeleteAgency_Click;
            // 
            // txtAgencyAddress
            // 
            txtAgencyAddress.Location = new Point(416, 276);
            txtAgencyAddress.Name = "txtAgencyAddress";
            txtAgencyAddress.Size = new Size(125, 27);
            txtAgencyAddress.TabIndex = 6;
            // 
            // lblAgencyAddress
            // 
            lblAgencyAddress.AutoSize = true;
            lblAgencyAddress.Location = new Point(416, 253);
            lblAgencyAddress.Name = "lblAgencyAddress";
            lblAgencyAddress.Size = new Size(115, 20);
            lblAgencyAddress.TabIndex = 7;
            lblAgencyAddress.Text = "Agency Address";
            // 
            // txtAgencyCity
            // 
            txtAgencyCity.Location = new Point(248, 329);
            txtAgencyCity.Name = "txtAgencyCity";
            txtAgencyCity.Size = new Size(125, 27);
            txtAgencyCity.TabIndex = 8;
            // 
            // lblAgencyCity
            // 
            lblAgencyCity.AutoSize = true;
            lblAgencyCity.Location = new Point(248, 306);
            lblAgencyCity.Name = "lblAgencyCity";
            lblAgencyCity.Size = new Size(87, 20);
            lblAgencyCity.TabIndex = 9;
            lblAgencyCity.Text = "Agency City";
            // 
            // lblAgencyProvince
            // 
            lblAgencyProvince.AutoSize = true;
            lblAgencyProvince.Location = new Point(416, 306);
            lblAgencyProvince.Name = "lblAgencyProvince";
            lblAgencyProvince.Size = new Size(118, 20);
            lblAgencyProvince.TabIndex = 10;
            lblAgencyProvince.Text = "Agency Province";
            // 
            // txtAgencyProvince
            // 
            txtAgencyProvince.Location = new Point(416, 329);
            txtAgencyProvince.Name = "txtAgencyProvince";
            txtAgencyProvince.Size = new Size(125, 27);
            txtAgencyProvince.TabIndex = 11;
            // 
            // txtAgencyPhone
            // 
            txtAgencyPhone.Location = new Point(571, 276);
            txtAgencyPhone.Name = "txtAgencyPhone";
            txtAgencyPhone.Size = new Size(125, 27);
            txtAgencyPhone.TabIndex = 12;
            // 
            // lblAgencyPhone
            // 
            lblAgencyPhone.AutoSize = true;
            lblAgencyPhone.Location = new Point(571, 253);
            lblAgencyPhone.Name = "lblAgencyPhone";
            lblAgencyPhone.Size = new Size(103, 20);
            lblAgencyPhone.TabIndex = 13;
            lblAgencyPhone.Text = "Agency Phone";
            // 
            // lblAgencyCountry
            // 
            lblAgencyCountry.AutoSize = true;
            lblAgencyCountry.Location = new Point(571, 306);
            lblAgencyCountry.Name = "lblAgencyCountry";
            lblAgencyCountry.Size = new Size(113, 20);
            lblAgencyCountry.TabIndex = 14;
            lblAgencyCountry.Text = "Agency Country";
            // 
            // txtAgencyCountry
            // 
            txtAgencyCountry.Location = new Point(571, 329);
            txtAgencyCountry.Name = "txtAgencyCountry";
            txtAgencyCountry.Size = new Size(125, 27);
            txtAgencyCountry.TabIndex = 15;
            // 
            // txtAgencyPostal
            // 
            txtAgencyPostal.Location = new Point(416, 380);
            txtAgencyPostal.Name = "txtAgencyPostal";
            txtAgencyPostal.Size = new Size(125, 27);
            txtAgencyPostal.TabIndex = 16;
            // 
            // txtAgencyFax
            // 
            txtAgencyFax.Location = new Point(571, 380);
            txtAgencyFax.Name = "txtAgencyFax";
            txtAgencyFax.Size = new Size(125, 27);
            txtAgencyFax.TabIndex = 17;
            // 
            // lblAgencyPostal
            // 
            lblAgencyPostal.AutoSize = true;
            lblAgencyPostal.Location = new Point(416, 357);
            lblAgencyPostal.Name = "lblAgencyPostal";
            lblAgencyPostal.Size = new Size(101, 20);
            lblAgencyPostal.TabIndex = 18;
            lblAgencyPostal.Text = "Agency Postal";
            // 
            // lblAgencyFax
            // 
            lblAgencyFax.AutoSize = true;
            lblAgencyFax.Location = new Point(571, 359);
            lblAgencyFax.Name = "lblAgencyFax";
            lblAgencyFax.Size = new Size(83, 20);
            lblAgencyFax.TabIndex = 19;
            lblAgencyFax.Text = "Agency Fax";
            // 
            // txtAgencyId
            // 
            txtAgencyId.Location = new Point(248, 276);
            txtAgencyId.Name = "txtAgencyId";
            txtAgencyId.Size = new Size(125, 27);
            txtAgencyId.TabIndex = 20;
            // 
            // lblAgencyId
            // 
            lblAgencyId.AutoSize = true;
            lblAgencyId.Location = new Point(248, 253);
            lblAgencyId.Name = "lblAgencyId";
            lblAgencyId.Size = new Size(75, 20);
            lblAgencyId.TabIndex = 21;
            lblAgencyId.Text = "Agency Id";
            // 
            // AgenciesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAgencyId);
            Controls.Add(txtAgencyId);
            Controls.Add(lblAgencyFax);
            Controls.Add(lblAgencyPostal);
            Controls.Add(txtAgencyFax);
            Controls.Add(txtAgencyPostal);
            Controls.Add(txtAgencyCountry);
            Controls.Add(lblAgencyCountry);
            Controls.Add(lblAgencyPhone);
            Controls.Add(txtAgencyPhone);
            Controls.Add(txtAgencyProvince);
            Controls.Add(lblAgencyProvince);
            Controls.Add(lblAgencyCity);
            Controls.Add(txtAgencyCity);
            Controls.Add(lblAgencyAddress);
            Controls.Add(txtAgencyAddress);
            Controls.Add(btnDeleteAgency);
            Controls.Add(btnEditAgency);
            Controls.Add(btnAddAgency);
            Controls.Add(grdAgencies);
            Name = "AgenciesForm";
            Text = "Agencies";
            ((System.ComponentModel.ISupportInitialize)grdAgencies).EndInit();
            ((System.ComponentModel.ISupportInitialize)agencyBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)agencyBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdAgencies;
        private BindingSource agencyBindingSource;
        private Button btnAddAgency;
        private BindingSource agencyBindingSource1;
        private Button btnEditAgency;
        private Button btnDeleteAgency;
        private TextBox txtAgencyAddress;
        private Label lblAgencyAddress;
        private TextBox txtAgencyCity;
        private Label lblAgencyCity;
        private Label lblAgencyProvince;
        private TextBox txtAgencyProvince;
        private TextBox txtAgencyPhone;
        private Label lblAgencyPhone;
        private Label lblAgencyCountry;
        private TextBox txtAgencyCountry;
        private TextBox txtAgencyPostal;
        private TextBox txtAgencyFax;
        private Label lblAgencyPostal;
        private Label lblAgencyFax;
        private DataGridViewTextBoxColumn agencyIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn agncyAddressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn agncyCityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn agncyProvDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn agncyPostalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn agncyCountryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn agncyPhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn agncyFaxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn agentsDataGridViewTextBoxColumn;
        private TextBox txtAgencyId;
        private Label lblAgencyId;
    }
}