namespace travel_experts_phase_2
{
    partial class HomeForm
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
            agentButton = new Button();
            agenciesButton = new Button();
            packagesButton = new Button();
            suppliersButton = new Button();
            productsButton = new Button();
            productSuppliersButton = new Button();
            closeButton = new Button();
            logoutButton = new Button();
            SuspendLayout();
            // 
            // agentButton
            // 
            agentButton.BackColor = SystemColors.ActiveCaption;
            agentButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            agentButton.Location = new Point(109, 74);
            agentButton.Name = "agentButton";
            agentButton.Size = new Size(239, 64);
            agentButton.TabIndex = 0;
            agentButton.Text = "Agents";
            agentButton.UseVisualStyleBackColor = false;
            agentButton.Visible = false;
            agentButton.Click += agentButton_Click;
            // 
            // agenciesButton
            // 
            agenciesButton.BackColor = SystemColors.ActiveCaption;
            agenciesButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            agenciesButton.Location = new Point(407, 74);
            agenciesButton.Name = "agenciesButton";
            agenciesButton.Size = new Size(170, 64);
            agenciesButton.TabIndex = 1;
            agenciesButton.Text = "Agencies";
            agenciesButton.UseVisualStyleBackColor = false;
            agenciesButton.Visible = false;
            agenciesButton.Click += agenciesButton_Click;
            // 
            // packagesButton
            // 
            packagesButton.BackColor = SystemColors.ActiveCaption;
            packagesButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            packagesButton.Location = new Point(407, 185);
            packagesButton.Name = "packagesButton";
            packagesButton.Size = new Size(170, 64);
            packagesButton.TabIndex = 3;
            packagesButton.Text = "Packages";
            packagesButton.UseVisualStyleBackColor = false;
            packagesButton.Click += packagesButton_Click;
            // 
            // suppliersButton
            // 
            suppliersButton.BackColor = SystemColors.ActiveCaption;
            suppliersButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            suppliersButton.Location = new Point(109, 185);
            suppliersButton.Name = "suppliersButton";
            suppliersButton.Size = new Size(239, 64);
            suppliersButton.TabIndex = 2;
            suppliersButton.Text = "Suppliers";
            suppliersButton.UseVisualStyleBackColor = false;
            suppliersButton.Click += button2_Click;
            // 
            // productsButton
            // 
            productsButton.BackColor = SystemColors.ActiveCaption;
            productsButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            productsButton.Location = new Point(407, 283);
            productsButton.Name = "productsButton";
            productsButton.Size = new Size(170, 64);
            productsButton.TabIndex = 5;
            productsButton.Text = "Products";
            productsButton.UseVisualStyleBackColor = false;
            productsButton.Click += productsButton_Click;
            // 
            // productSuppliersButton
            // 
            productSuppliersButton.BackColor = SystemColors.ActiveCaption;
            productSuppliersButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            productSuppliersButton.Location = new Point(109, 283);
            productSuppliersButton.Name = "productSuppliersButton";
            productSuppliersButton.Size = new Size(239, 64);
            productSuppliersButton.TabIndex = 4;
            productSuppliersButton.Text = "Product Suppliers";
            productSuppliersButton.UseVisualStyleBackColor = false;
            productSuppliersButton.Click += productSuppliersButton_Click;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.Red;
            closeButton.Font = new Font("Impact", 12F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.ForeColor = SystemColors.ControlLightLight;
            closeButton.Location = new Point(703, 453);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(131, 44);
            closeButton.TabIndex = 6;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.Yellow;
            logoutButton.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            logoutButton.ForeColor = SystemColors.ActiveCaptionText;
            logoutButton.Location = new Point(703, 29);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(131, 44);
            logoutButton.TabIndex = 7;
            logoutButton.Text = "Log out";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 549);
            Controls.Add(logoutButton);
            Controls.Add(closeButton);
            Controls.Add(productsButton);
            Controls.Add(productSuppliersButton);
            Controls.Add(packagesButton);
            Controls.Add(suppliersButton);
            Controls.Add(agenciesButton);
            Controls.Add(agentButton);
            Name = "HomeForm";
            Text = "HomeForm";
            Load += HomeForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button agentButton;
        private Button agenciesButton;
        private Button packagesButton;
        private Button suppliersButton;
        private Button productsButton;
        private Button productSuppliersButton;
        private Button closeButton;
        private Button logoutButton;
    }
}