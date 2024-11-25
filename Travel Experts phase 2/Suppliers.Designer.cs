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
            SupplierViewBox = new TextBox();
            UpdateLbl = new Label();
            AddLbl = new Label();
            SupNameLbl = new Label();
            NameAddBox = new TextBox();
            confirmBtn = new Button();
            cancelBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)SupplierView).BeginInit();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(28, 155);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(204, 23);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "Add Supplier";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(28, 210);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(204, 23);
            UpdateBtn.TabIndex = 2;
            UpdateBtn.Text = "Update Selected Supplier";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(28, 265);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(204, 23);
            DeleteBtn.TabIndex = 3;
            DeleteBtn.Text = "Delete Selected Supplier";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // SearchBoxLbl
            // 
            SearchBoxLbl.AutoSize = true;
            SearchBoxLbl.Location = new Point(331, 74);
            SearchBoxLbl.Name = "SearchBoxLbl";
            SearchBoxLbl.Size = new Size(45, 15);
            SearchBoxLbl.TabIndex = 5;
            SearchBoxLbl.Text = "Search:";
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(417, 71);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(279, 23);
            SearchBox.TabIndex = 6;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // SupplierView
            // 
            SupplierView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SupplierView.Location = new Point(268, 132);
            SupplierView.Name = "SupplierView";
            SupplierView.RowTemplate.Height = 25;
            SupplierView.Size = new Size(463, 183);
            SupplierView.TabIndex = 7;
            SupplierView.CellContentClick += SupplierView_CellContentClick;
            // 
            // SuppliersLbl
            // 
            SuppliersLbl.AutoSize = true;
            SuppliersLbl.Location = new Point(101, 48);
            SuppliersLbl.Name = "SuppliersLbl";
            SuppliersLbl.Size = new Size(55, 15);
            SuppliersLbl.TabIndex = 8;
            SuppliersLbl.Text = "Suppliers";
            // 
            // ViewBtn
            // 
            ViewBtn.Location = new Point(28, 339);
            ViewBtn.Name = "ViewBtn";
            ViewBtn.Size = new Size(204, 23);
            ViewBtn.TabIndex = 9;
            ViewBtn.Text = "View Selected Supplier";
            ViewBtn.UseVisualStyleBackColor = true;
            ViewBtn.Click += ViewBtn_Click;
            // 
            // SupplierViewBox
            // 
            SupplierViewBox.AcceptsReturn = true;
            SupplierViewBox.Location = new Point(268, 340);
            SupplierViewBox.Name = "SupplierViewBox";
            SupplierViewBox.Size = new Size(463, 23);
            SupplierViewBox.TabIndex = 10;
            // 
            // UpdateLbl
            // 
            UpdateLbl.AutoSize = true;
            UpdateLbl.Location = new Point(46, 398);
            UpdateLbl.Name = "UpdateLbl";
            UpdateLbl.Size = new Size(157, 15);
            UpdateLbl.TabIndex = 11;
            UpdateLbl.Text = "Update Supplier Information";
            // 
            // AddLbl
            // 
            AddLbl.AutoSize = true;
            AddLbl.Location = new Point(90, 398);
            AddLbl.Name = "AddLbl";
            AddLbl.Size = new Size(75, 15);
            AddLbl.TabIndex = 12;
            AddLbl.Text = "Add Supplier";
            // 
            // SupNameLbl
            // 
            SupNameLbl.AutoSize = true;
            SupNameLbl.Location = new Point(171, 476);
            SupNameLbl.Name = "SupNameLbl";
            SupNameLbl.Size = new Size(88, 15);
            SupNameLbl.TabIndex = 13;
            SupNameLbl.Text = "Supplier Name:";
            // 
            // NameAddBox
            // 
            NameAddBox.Location = new Point(265, 473);
            NameAddBox.Name = "NameAddBox";
            NameAddBox.Size = new Size(466, 23);
            NameAddBox.TabIndex = 14;
            // 
            // confirmBtn
            // 
            confirmBtn.Location = new Point(265, 523);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(75, 23);
            confirmBtn.TabIndex = 15;
            confirmBtn.Text = "Confirm";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(360, 523);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 16;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // Suppliers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 582);
            Controls.Add(cancelBtn);
            Controls.Add(confirmBtn);
            Controls.Add(NameAddBox);
            Controls.Add(SupNameLbl);
            Controls.Add(AddLbl);
            Controls.Add(UpdateLbl);
            Controls.Add(SupplierViewBox);
            Controls.Add(ViewBtn);
            Controls.Add(SuppliersLbl);
            Controls.Add(SupplierView);
            Controls.Add(SearchBox);
            Controls.Add(SearchBoxLbl);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
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
        private TextBox SupplierViewBox;
        private Label UpdateLbl;
        private Label AddLbl;
        private Label SupNameLbl;
        private TextBox NameAddBox;
        private Button confirmBtn;
        private Button cancelBtn;
    }
}