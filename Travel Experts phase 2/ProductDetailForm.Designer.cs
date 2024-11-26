namespace travel_experts_phase_2
{
    partial class ProductDetailForm
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
            headerLabel = new Label();
            productIdLabel = new Label();
            productIdTextBox = new TextBox();
            productNameTextBox = new TextBox();
            productNameLabel = new Label();
            updateButton = new Button();
            addButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.Location = new Point(41, 21);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(229, 35);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "View Product";
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            productIdLabel.Location = new Point(30, 103);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new Size(113, 23);
            productIdLabel.TabIndex = 1;
            productIdLabel.Text = "Product Id:";
            // 
            // productIdTextBox
            // 
            productIdTextBox.Location = new Point(199, 103);
            productIdTextBox.Name = "productIdTextBox";
            productIdTextBox.ReadOnly = true;
            productIdTextBox.Size = new Size(125, 27);
            productIdTextBox.TabIndex = 2;
            // 
            // productNameTextBox
            // 
            productNameTextBox.Location = new Point(199, 156);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.Size = new Size(314, 27);
            productNameTextBox.TabIndex = 4;
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            productNameLabel.Location = new Point(30, 160);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(149, 23);
            productNameLabel.TabIndex = 3;
            productNameLabel.Text = "Product Name:";
            productNameLabel.Click += label1_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.FromArgb(0, 192, 192);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(287, 284);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(142, 29);
            updateButton.TabIndex = 5;
            updateButton.Text = "UPDATE";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Visible = false;
            updateButton.Click += updateButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(0, 192, 192);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(287, 249);
            addButton.Name = "addButton";
            addButton.Size = new Size(142, 29);
            addButton.TabIndex = 6;
            addButton.Text = "ADD NEW";
            addButton.UseVisualStyleBackColor = false;
            addButton.Visible = false;
            addButton.Click += addButton_Click;
            // 
            // ProductDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addButton);
            Controls.Add(updateButton);
            Controls.Add(productNameTextBox);
            Controls.Add(productNameLabel);
            Controls.Add(productIdTextBox);
            Controls.Add(productIdLabel);
            Controls.Add(headerLabel);
            Name = "ProductDetailForm";
            Text = "ProductDetailForm";
            Load += ProductDetailForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label productIdLabel;
        private TextBox productIdTextBox;
        private TextBox productNameTextBox;
        private Label productNameLabel;
        private Button updateButton;
        private Button addButton;
    }
}