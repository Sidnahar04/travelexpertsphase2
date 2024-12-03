namespace travel_experts_phase_2
{
    partial class addOrUpdateProductSupplierForm
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
            label1 = new Label();
            label2 = new Label();
            productcombo = new ComboBox();
            okBtn = new Button();
            cancelBtn = new Button();
            label3 = new Label();
            supplierCombobox = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 108);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Supplier Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 185);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Product Name:";
            // 
            // productcombo
            // 
            productcombo.FormattingEnabled = true;
            productcombo.Location = new Point(168, 177);
            productcombo.Name = "productcombo";
            productcombo.Size = new Size(371, 28);
            productcombo.TabIndex = 3;
            // 
            // okBtn
            // 
            okBtn.Location = new Point(31, 350);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(94, 29);
            okBtn.TabIndex = 4;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(205, 350);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 5;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(220, 20);
            label3.Name = "label3";
            label3.Size = new Size(307, 37);
            label3.TabIndex = 6;
            label3.Text = "Product Supplier Form";
            // 
            // supplierCombobox
            // 
            supplierCombobox.FormattingEnabled = true;
            supplierCombobox.Location = new Point(168, 105);
            supplierCombobox.Name = "supplierCombobox";
            supplierCombobox.Size = new Size(371, 28);
            supplierCombobox.TabIndex = 7;
            supplierCombobox.SelectedIndexChanged += supplierCombobox_SelectedIndexChanged;
            // 
            // addOrUpdateProductSupplierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(supplierCombobox);
            Controls.Add(label3);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(productcombo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "addOrUpdateProductSupplierForm";
            Text = "addOrUpdateProductSupplierForm";
            Load += addOrUpdateProductSupplierForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox productcombo;
        private Button okBtn;
        private Button cancelBtn;
        private Label label3;
        private ComboBox supplierCombobox;
    }
}