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
            packagesSuppliersButton = new Button();
            productsButton = new Button();
            productSuppliersButton = new Button();
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
            // packagesSuppliersButton
            // 
            packagesSuppliersButton.BackColor = SystemColors.ActiveCaption;
            packagesSuppliersButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            packagesSuppliersButton.Location = new Point(109, 185);
            packagesSuppliersButton.Name = "packagesSuppliersButton";
            packagesSuppliersButton.Size = new Size(239, 64);
            packagesSuppliersButton.TabIndex = 2;
            packagesSuppliersButton.Text = "Packages Suppliers";
            packagesSuppliersButton.UseVisualStyleBackColor = false;
            packagesSuppliersButton.Click += button2_Click;
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
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(productsButton);
            Controls.Add(productSuppliersButton);
            Controls.Add(packagesButton);
            Controls.Add(packagesSuppliersButton);
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
        private Button packagesSuppliersButton;
        private Button productsButton;
        private Button productSuppliersButton;
    }
}