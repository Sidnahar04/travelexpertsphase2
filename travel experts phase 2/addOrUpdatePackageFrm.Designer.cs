﻿namespace travel_experts_phase_2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            packageIdTxt = new TextBox();
            packageNameTxt = new TextBox();
            packageBasePriceTxt = new TextBox();
            packageCommisionTxt = new TextBox();
            PackageStartDateTxt = new DateTimePicker();
            packageDescTxt = new RichTextBox();
            PackageEndDateTxt = new DateTimePicker();
            okBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 55);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "PackageId:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 116);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 172);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Start Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 226);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 3;
            label4.Text = "End Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 274);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 4;
            label5.Text = "Description:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 361);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 5;
            label6.Text = "Base Price:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 404);
            label7.Name = "label7";
            label7.Size = new Size(146, 20);
            label7.TabIndex = 6;
            label7.Text = "Agency Commission:";
            // 
            // packageIdTxt
            // 
            packageIdTxt.Location = new Point(247, 55);
            packageIdTxt.Name = "packageIdTxt";
            packageIdTxt.Size = new Size(173, 27);
            packageIdTxt.TabIndex = 7;
            // 
            // packageNameTxt
            // 
            packageNameTxt.Location = new Point(247, 116);
            packageNameTxt.Name = "packageNameTxt";
            packageNameTxt.Size = new Size(173, 27);
            packageNameTxt.TabIndex = 8;
            // 
            // packageBasePriceTxt
            // 
            packageBasePriceTxt.Location = new Point(247, 361);
            packageBasePriceTxt.Name = "packageBasePriceTxt";
            packageBasePriceTxt.Size = new Size(173, 27);
            packageBasePriceTxt.TabIndex = 10;
            // 
            // packageCommisionTxt
            // 
            packageCommisionTxt.Location = new Point(247, 401);
            packageCommisionTxt.Name = "packageCommisionTxt";
            packageCommisionTxt.Size = new Size(173, 27);
            packageCommisionTxt.TabIndex = 11;
            // 
            // PackageStartDateTxt
            // 
            PackageStartDateTxt.Location = new Point(247, 165);
            PackageStartDateTxt.Name = "PackageStartDateTxt";
            PackageStartDateTxt.Size = new Size(173, 27);
            PackageStartDateTxt.TabIndex = 12;
            // 
            // packageDescTxt
            // 
            packageDescTxt.Location = new Point(247, 274);
            packageDescTxt.Name = "packageDescTxt";
            packageDescTxt.Size = new Size(230, 73);
            packageDescTxt.TabIndex = 13;
            packageDescTxt.Text = "";
            // 
            // PackageEndDateTxt
            // 
            PackageEndDateTxt.Location = new Point(247, 226);
            PackageEndDateTxt.Name = "PackageEndDateTxt";
            PackageEndDateTxt.Size = new Size(173, 27);
            PackageEndDateTxt.TabIndex = 14;
            // 
            // okBtn
            // 
            okBtn.Location = new Point(49, 480);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(187, 29);
            okBtn.TabIndex = 15;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(326, 480);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(177, 29);
            cancelBtn.TabIndex = 16;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // addOrUpdatePackageFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 533);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(PackageEndDateTxt);
            Controls.Add(packageDescTxt);
            Controls.Add(PackageStartDateTxt);
            Controls.Add(packageCommisionTxt);
            Controls.Add(packageBasePriceTxt);
            Controls.Add(packageNameTxt);
            Controls.Add(packageIdTxt);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "addOrUpdatePackageFrm";
            Text = "addOrUpdatePackageFrm";
            Load += addOrUpdatePackageFrm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox packageIdTxt;
        private TextBox packageNameTxt;
        private TextBox packageBasePriceTxt;
        private TextBox packageCommisionTxt;
        private DateTimePicker PackageStartDateTxt;
        private RichTextBox packageDescTxt;
        private DateTimePicker PackageEndDateTxt;
        private Button okBtn;
        private Button cancelBtn;
    }
}