namespace travel_experts_phase_2
{
    partial class ProductsForm
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
            ViewButton = new Button();
            modifyButton = new Button();
            deleteButton = new Button();
            productsDataGridView = new DataGridView();
            label1 = new Label();
            searchBox = new TextBox();
            label2 = new Label();
            addButton = new Button();
            backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ViewButton
            // 
            ViewButton.BackColor = Color.Olive;
            ViewButton.Location = new Point(40, 190);
            ViewButton.Name = "ViewButton";
            ViewButton.Size = new Size(145, 44);
            ViewButton.TabIndex = 0;
            ViewButton.Text = "View";
            ViewButton.UseVisualStyleBackColor = false;
            ViewButton.Click += ViewButton_Click;
            // 
            // modifyButton
            // 
            modifyButton.BackColor = Color.Olive;
            modifyButton.Location = new Point(41, 271);
            modifyButton.Name = "modifyButton";
            modifyButton.Size = new Size(145, 44);
            modifyButton.TabIndex = 1;
            modifyButton.Text = "Modify";
            modifyButton.UseVisualStyleBackColor = false;
            modifyButton.Click += modifyButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Olive;
            deleteButton.Location = new Point(41, 355);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(145, 44);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // productsDataGridView
            // 
            productsDataGridView.AllowUserToAddRows = false;
            productsDataGridView.AllowUserToDeleteRows = false;
            productsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDataGridView.Location = new Point(251, 115);
            productsDataGridView.Name = "productsDataGridView";
            productsDataGridView.ReadOnly = true;
            productsDataGridView.RowHeadersWidth = 51;
            productsDataGridView.RowTemplate.Height = 29;
            productsDataGridView.Size = new Size(451, 323);
            productsDataGridView.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 9);
            label1.Name = "label1";
            label1.Size = new Size(152, 37);
            label1.TabIndex = 4;
            label1.Text = "PRODUCTS";
            // 
            // searchBox
            // 
            searchBox.Location = new Point(315, 62);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(307, 27);
            searchBox.TabIndex = 9;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(235, 62);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 8;
            label2.Text = "Search:";
            // 
            // addButton
            // 
            addButton.BackColor = Color.Olive;
            addButton.Location = new Point(41, 128);
            addButton.Name = "addButton";
            addButton.Size = new Size(145, 44);
            addButton.TabIndex = 10;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // backButton
            // 
            backButton.BackColor = SystemColors.ActiveCaption;
            backButton.Location = new Point(805, 59);
            backButton.Name = "backButton";
            backButton.Size = new Size(140, 41);
            backButton.TabIndex = 21;
            backButton.Text = "Back to Home";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 450);
            Controls.Add(backButton);
            Controls.Add(addButton);
            Controls.Add(searchBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(productsDataGridView);
            Controls.Add(deleteButton);
            Controls.Add(modifyButton);
            Controls.Add(ViewButton);
            Name = "ProductsForm";
            Text = "ProductsForm";
            Load += ProductsForm_Load;
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ViewButton;
        private Button modifyButton;
        private Button deleteButton;
        private DataGridView productsDataGridView;
        private Label label1;
        private TextBox searchBox;
        private Label label2;
        private Button addButton;
        private Button backButton;
    }
}