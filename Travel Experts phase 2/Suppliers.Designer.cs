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
            RefreshBtn = new Button();
            SearchBoxLbl = new Label();
            SearchBox = new TextBox();
            SupplierView = new DataGridView();
            SuppliersLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)SupplierView).BeginInit();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(90, 142);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 23);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "Add Supplier";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(90, 216);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(75, 23);
            UpdateBtn.TabIndex = 2;
            UpdateBtn.Text = "Update Selected Supplier";
            UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(90, 292);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 23);
            DeleteBtn.TabIndex = 3;
            DeleteBtn.Text = "Delete Selected Supplier";
            DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // RefreshBtn
            // 
            RefreshBtn.Location = new Point(90, 367);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(75, 23);
            RefreshBtn.TabIndex = 4;
            RefreshBtn.Text = "Update Changes";
            RefreshBtn.UseVisualStyleBackColor = true;
            // 
            // SearchBoxLbl
            // 
            SearchBoxLbl.AutoSize = true;
            SearchBoxLbl.Location = new Point(401, 63);
            SearchBoxLbl.Name = "SearchBoxLbl";
            SearchBoxLbl.Size = new Size(45, 15);
            SearchBoxLbl.TabIndex = 5;
            SearchBoxLbl.Text = "Search:";
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(487, 60);
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
            SupplierView.Size = new Size(463, 268);
            SupplierView.TabIndex = 7;
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
            // Suppliers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SuppliersLbl);
            Controls.Add(SupplierView);
            Controls.Add(SearchBox);
            Controls.Add(SearchBoxLbl);
            Controls.Add(RefreshBtn);
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
        private Button RefreshBtn;
        private Label SearchBoxLbl;
        private TextBox SearchBox;
        private DataGridView SupplierView;
        private Label SuppliersLbl;
    }
}