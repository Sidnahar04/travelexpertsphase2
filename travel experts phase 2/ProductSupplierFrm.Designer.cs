namespace travel_experts_phase_2
{
    partial class ProductSupplierFrm
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
            dgvProductSupplier = new DataGridView();
            addbtn = new Button();
            editbtn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductSupplier).BeginInit();
            SuspendLayout();
            // 
            // dgvProductSupplier
            // 
            dgvProductSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductSupplier.Location = new Point(26, 126);
            dgvProductSupplier.Name = "dgvProductSupplier";
            dgvProductSupplier.RowHeadersWidth = 51;
            dgvProductSupplier.RowTemplate.Height = 29;
            dgvProductSupplier.Size = new Size(927, 297);
            dgvProductSupplier.TabIndex = 0;
            dgvProductSupplier.CellContentClick += dgvProductSupplier_CellContentClick;
            // 
            // addbtn
            // 
            addbtn.Location = new Point(26, 442);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(108, 40);
            addbtn.TabIndex = 1;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += addbtn_Click;
            // 
            // editbtn
            // 
            editbtn.Location = new Point(208, 442);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(105, 40);
            editbtn.TabIndex = 2;
            editbtn.Text = "Edit";
            editbtn.UseVisualStyleBackColor = true;
            editbtn.Click += editbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(331, 9);
            label1.Name = "label1";
            label1.Size = new Size(377, 40);
            label1.TabIndex = 4;
            label1.Text = "Product Supplier Information";
            // 
            // ProductSupplierFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 503);
            Controls.Add(label1);
            Controls.Add(editbtn);
            Controls.Add(addbtn);
            Controls.Add(dgvProductSupplier);
            Name = "ProductSupplierFrm";
            Text = "ProductSupplierFrm";
            Load += ProductSupplierFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductSupplier).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductSupplier;
        private Button addbtn;
        private Button editbtn;
        private Button deletebtn;
        private Label label1;
    }
}