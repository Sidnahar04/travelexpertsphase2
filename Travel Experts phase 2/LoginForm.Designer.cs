﻿namespace travel_experts_phase_2
{
    partial class LoginForm
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
            emailTextBox = new TextBox();
            loginButton = new Button();
            clearButton = new Button();
            txtPassword = new TextBox();
            label4 = new Label();
            showPasswordCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(36, 44);
            label1.Name = "label1";
            label1.Size = new Size(548, 35);
            label1.TabIndex = 0;
            label1.Text = "Travel Expert Management System";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(325, 98);
            label2.Name = "label2";
            label2.Size = new Size(99, 31);
            label2.TabIndex = 1;
            label2.Text = "SIGN IN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(114, 176);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(219, 176);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(506, 27);
            emailTextBox.TabIndex = 3;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Navy;
            loginButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(219, 322);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(152, 42);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = SystemColors.AppWorkspace;
            clearButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            clearButton.Location = new Point(404, 322);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(131, 42);
            clearButton.TabIndex = 5;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(219, 228);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(506, 27);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(114, 227);
            label4.Name = "label4";
            label4.Size = new Size(102, 28);
            label4.TabIndex = 6;
            label4.Text = "Password:";
            // 
            // showPasswordCheckBox
            // 
            showPasswordCheckBox.AutoSize = true;
            showPasswordCheckBox.Location = new Point(336, 276);
            showPasswordCheckBox.Name = "showPasswordCheckBox";
            showPasswordCheckBox.Size = new Size(132, 24);
            showPasswordCheckBox.TabIndex = 8;
            showPasswordCheckBox.Text = "Show Password";
            showPasswordCheckBox.UseVisualStyleBackColor = true;
            showPasswordCheckBox.CheckedChanged += showPasswordCheckBox_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(showPasswordCheckBox);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(clearButton);
            Controls.Add(loginButton);
            Controls.Add(emailTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox emailTextBox;
        private Button loginButton;
        private Button clearButton;
        private TextBox txtPassword;
        private Label label4;
        private CheckBox showPasswordCheckBox;
    }
}