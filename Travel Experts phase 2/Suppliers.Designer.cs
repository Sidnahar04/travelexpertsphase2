namespace travel_experts_phase_2
{
    partial class Suppliers
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
            AddBtn = new Button();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            SearchBoxLbl = new Label();
            SearchBox = new TextBox();
            SupplierView = new DataGridView();
            SuppliersLbl = new Label();
            ViewBtn = new Button();
            UpdateLbl = new Label();
            AddLbl = new Label();
            SupNameLbl = new Label();
            NameAddBox = new TextBox();
            confirmBtn = new Button();
            cancelBtn = new Button();
            confrimAddButton = new Button();
            backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)SupplierView).BeginInit();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(32, 207);
            AddBtn.Margin = new Padding(3, 4, 3, 4);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(233, 31);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "Add Supplier";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(32, 280);
            UpdateBtn.Margin = new Padding(3, 4, 3, 4);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(233, 31);
            UpdateBtn.TabIndex = 2;
            UpdateBtn.Text = "Update Selected Supplier";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(32, 353);
            DeleteBtn.Margin = new Padding(3, 4, 3, 4);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(233, 31);
            DeleteBtn.TabIndex = 3;
            DeleteBtn.Text = "Delete Selected Supplier";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // SearchBoxLbl
            // 
            SearchBoxLbl.AutoSize = true;
            SearchBoxLbl.Location = new Point(378, 99);
            SearchBoxLbl.Name = "SearchBoxLbl";
            SearchBoxLbl.Size = new Size(56, 20);
            SearchBoxLbl.TabIndex = 5;
            SearchBoxLbl.Text = "Search:";
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(477, 95);
            SearchBox.Margin = new Padding(3, 4, 3, 4);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(318, 27);
            SearchBox.TabIndex = 6;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // SupplierView
            // 
            SupplierView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SupplierView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SupplierView.Location = new Point(306, 176);
            SupplierView.Margin = new Padding(3, 4, 3, 4);
            SupplierView.Name = "SupplierView";
            SupplierView.RowHeadersWidth = 51;
            SupplierView.RowTemplate.Height = 25;
            SupplierView.Size = new Size(529, 244);
            SupplierView.TabIndex = 7;
            SupplierView.CellContentClick += SupplierView_CellContentClick;
            // 
            // SuppliersLbl
            // 
            SuppliersLbl.AutoSize = true;
            SuppliersLbl.Location = new Point(115, 64);
            SuppliersLbl.Name = "SuppliersLbl";
            SuppliersLbl.Size = new Size(70, 20);
            SuppliersLbl.TabIndex = 8;
            SuppliersLbl.Text = "Suppliers";
            // 
            // ViewBtn
            // 
            ViewBtn.Location = new Point(303, 464);
            ViewBtn.Margin = new Padding(3, 4, 3, 4);
            ViewBtn.Name = "ViewBtn";
            ViewBtn.Size = new Size(233, 31);
            ViewBtn.TabIndex = 9;
            ViewBtn.Text = "View Selected Supplier";
            ViewBtn.UseVisualStyleBackColor = true;
            ViewBtn.Click += ViewBtn_Click;
            // 
            // UpdateLbl
            // 
            UpdateLbl.AutoSize = true;
            UpdateLbl.Location = new Point(53, 531);
            UpdateLbl.Name = "UpdateLbl";
            UpdateLbl.Size = new Size(199, 20);
            UpdateLbl.TabIndex = 11;
            UpdateLbl.Text = "Update Supplier Information";
            // 
            // AddLbl
            // 
            AddLbl.AutoSize = true;
            AddLbl.Location = new Point(103, 531);
            AddLbl.Name = "AddLbl";
            AddLbl.Size = new Size(96, 20);
            AddLbl.TabIndex = 12;
            AddLbl.Text = "Add Supplier";
            // 
            // SupNameLbl
            // 
            SupNameLbl.AutoSize = true;
            SupNameLbl.Location = new Point(154, 604);
            SupNameLbl.Name = "SupNameLbl";
            SupNameLbl.Size = new Size(111, 20);
            SupNameLbl.TabIndex = 13;
            SupNameLbl.Text = "Supplier Name:";
            // 
            // NameAddBox
            // 
            NameAddBox.Location = new Point(303, 601);
            NameAddBox.Margin = new Padding(3, 4, 3, 4);
            NameAddBox.Name = "NameAddBox";
            NameAddBox.Size = new Size(532, 27);
            NameAddBox.TabIndex = 14;
            // 
            // confirmBtn
            // 
            confirmBtn.Location = new Point(238, 697);
            confirmBtn.Margin = new Padding(3, 4, 3, 4);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(151, 31);
            confirmBtn.TabIndex = 15;
            confirmBtn.Text = "Confirm Update";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(411, 697);
            cancelBtn.Margin = new Padding(3, 4, 3, 4);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(86, 31);
            cancelBtn.TabIndex = 16;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // confrimAddButton
            // 
            confrimAddButton.Location = new Point(238, 697);
            confrimAddButton.Margin = new Padding(3, 4, 3, 4);
            confrimAddButton.Name = "confrimAddButton";
            confrimAddButton.Size = new Size(151, 31);
            confrimAddButton.TabIndex = 19;
            confrimAddButton.Text = "Confirm Add";
            confrimAddButton.UseVisualStyleBackColor = true;
            confrimAddButton.Visible = false;
            confrimAddButton.Click += confrimAddButton_Click;
            // 
            // backButton
            // 
            backButton.BackColor = SystemColors.ActiveCaption;
            backButton.Location = new Point(27, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(140, 41);
            backButton.TabIndex = 20;
            backButton.Text = "Back to Home";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // Suppliers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 776);
            Controls.Add(backButton);
            Controls.Add(confrimAddButton);
            Controls.Add(cancelBtn);
            Controls.Add(confirmBtn);
            Controls.Add(NameAddBox);
            Controls.Add(SupNameLbl);
            Controls.Add(AddLbl);
            Controls.Add(UpdateLbl);
            Controls.Add(ViewBtn);
            Controls.Add(SuppliersLbl);
            Controls.Add(SupplierView);
            Controls.Add(SearchBox);
            Controls.Add(SearchBoxLbl);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Suppliers";
            Text = "Suppliers";
            Load += Suppliers_Load;
            ((System.ComponentModel.ISupportInitialize)SupplierView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AddBtn;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Label SearchBoxLbl;
        private TextBox SearchBox;
        private DataGridView SupplierView;
        private Label SuppliersLbl;
        private Button ViewBtn;
        private Label UpdateLbl;
        private Label AddLbl;
        private Label SupNameLbl;
        private TextBox NameAddBox;
        private Button confirmBtn;
        private Button cancelBtn;
        private Button confrimAddButton;
        private Button backButton;
    }
}