namespace travel_experts_phase_2
{
    partial class addOrUpdatePackageFrm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            packageNameTxt = new TextBox();
            packageBasePriceTxt = new TextBox();
            packageCommisionTxt = new TextBox();
            PackageStartDateTxt = new DateTimePicker();
            packageDescTxt = new RichTextBox();
            PackageEndDateTxt = new DateTimePicker();
            okBtn = new Button();
            cancelBtn = new Button();
            label1 = new Label();
            productsCombo = new ComboBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 31);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 77);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Start Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 117);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "End Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;

            label5.Location = new Point(34, 167);

            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 4;
            label5.Text = "Description:";
            // 
            // label6
            // 
            label6.AutoSize = true;

            label6.Location = new Point(34, 271);

            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 5;
            label6.Text = "Base Price:";
            // 
            // label7
            // 
            label7.AutoSize = true;

            label7.Location = new Point(34, 303);

            label7.Name = "label7";
            label7.Size = new Size(120, 15);
            label7.TabIndex = 6;
            label7.Text = "Agency Commission:";
            // 
            // packageNameTxt
            // 

            packageNameTxt.Location = new Point(216, 31);
            packageNameTxt.Margin = new Padding(3, 2, 3, 2);

            packageNameTxt.Name = "packageNameTxt";
            packageNameTxt.Size = new Size(152, 23);
            packageNameTxt.TabIndex = 8;
            packageNameTxt.TextChanged += packageNameTxt_TextChanged;
            // 
            // packageBasePriceTxt
            // 

            packageBasePriceTxt.Location = new Point(216, 268);
            packageBasePriceTxt.Margin = new Padding(3, 2, 3, 2);

            packageBasePriceTxt.Name = "packageBasePriceTxt";
            packageBasePriceTxt.Size = new Size(152, 23);
            packageBasePriceTxt.TabIndex = 10;
            // 
            // packageCommisionTxt
            // 

            packageCommisionTxt.Location = new Point(216, 301);
            packageCommisionTxt.Margin = new Padding(3, 2, 3, 2);

            packageCommisionTxt.Name = "packageCommisionTxt";
            packageCommisionTxt.Size = new Size(152, 23);
            packageCommisionTxt.TabIndex = 11;
            // 
            // PackageStartDateTxt
            // 
            PackageStartDateTxt.Location = new Point(216, 77);
            PackageStartDateTxt.Margin = new Padding(3, 2, 3, 2);
            PackageStartDateTxt.Name = "PackageStartDateTxt";
            PackageStartDateTxt.Size = new Size(152, 23);
            PackageStartDateTxt.TabIndex = 12;
            // 
            // packageDescTxt
            // 

            packageDescTxt.Location = new Point(216, 167);
            packageDescTxt.Margin = new Padding(3, 2, 3, 2);
            packageDescTxt.Name = "packageDescTxt";
            packageDescTxt.Size = new Size(202, 85);

            packageDescTxt.TabIndex = 13;
            packageDescTxt.Text = "";
            packageDescTxt.TextChanged += packageDescTxt_TextChanged;
            // 
            // PackageEndDateTxt
            // 
            PackageEndDateTxt.Location = new Point(216, 117);
            PackageEndDateTxt.Margin = new Padding(3, 2, 3, 2);
            PackageEndDateTxt.Name = "PackageEndDateTxt";
            PackageEndDateTxt.Size = new Size(152, 23);
            PackageEndDateTxt.TabIndex = 14;
            // 
            // okBtn
            // 
            okBtn.Location = new Point(43, 360);
            okBtn.Margin = new Padding(3, 2, 3, 2);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(164, 22);
            okBtn.TabIndex = 15;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(285, 360);
            cancelBtn.Margin = new Padding(3, 2, 3, 2);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(155, 22);
            cancelBtn.TabIndex = 16;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 426);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 17;
            label1.Text = "Products:";
            // 
            // productsCombo
            // 
            productsCombo.FormattingEnabled = true;
            productsCombo.Location = new Point(247, 426);
            productsCombo.Name = "productsCombo";
            productsCombo.Size = new Size(173, 28);
            productsCombo.TabIndex = 18;
            productsCombo.SelectedIndexChanged += productsCombo_SelectedIndexChanged;
            // 
            // addOrUpdatePackageFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(702, 400);

            ClientSize = new Size(802, 533);
            Controls.Add(productsCombo);
            Controls.Add(label1);

            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(PackageEndDateTxt);
            Controls.Add(packageDescTxt);
            Controls.Add(PackageStartDateTxt);
            Controls.Add(packageCommisionTxt);
            Controls.Add(packageBasePriceTxt);
            Controls.Add(packageNameTxt);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "addOrUpdatePackageFrm";
            Text = "addOrUpdatePackageFrm";
            Load += addOrUpdatePackageFrm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox packageNameTxt;
        private TextBox packageBasePriceTxt;
        private TextBox packageCommisionTxt;
        private DateTimePicker PackageStartDateTxt;
        private RichTextBox packageDescTxt;
        private DateTimePicker PackageEndDateTxt;
        private Button okBtn;
        private Button cancelBtn;
        private Label label1;
        private ComboBox productsCombo;
    }
}