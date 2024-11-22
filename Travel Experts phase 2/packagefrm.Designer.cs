namespace travel_experts_phase_2
{
    partial class packagefrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPackages = new DataGridView();
            addBtn = new Button();
            modifyBtn = new Button();
            deleteBtn = new Button();
            exitBtn = new Button();
            viewBtn = new Button();
            label1 = new Label();
            searchBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPackages).BeginInit();
            SuspendLayout();
            // 
            // dgvPackages
            // 
            dgvPackages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPackages.Location = new Point(35, 77);
            dgvPackages.Name = "dgvPackages";
            dgvPackages.RowHeadersWidth = 51;
            dgvPackages.RowTemplate.Height = 29;
            dgvPackages.Size = new Size(822, 212);
            dgvPackages.TabIndex = 0;
            dgvPackages.CellContentClick += dgvPackages_CellContentClick;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(35, 324);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(123, 44);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add Package";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // modifyBtn
            // 
            modifyBtn.Location = new Point(193, 324);
            modifyBtn.Name = "modifyBtn";
            modifyBtn.Size = new Size(157, 44);
            modifyBtn.TabIndex = 2;
            modifyBtn.Text = "Modify Package";
            modifyBtn.UseVisualStyleBackColor = true;
            modifyBtn.Click += modifyBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(376, 324);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(151, 44);
            deleteBtn.TabIndex = 3;
            deleteBtn.Text = "Delete Package";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(763, 324);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(94, 44);
            exitBtn.TabIndex = 4;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // viewBtn
            // 
            viewBtn.Location = new Point(562, 324);
            viewBtn.Name = "viewBtn";
            viewBtn.Size = new Size(117, 44);
            viewBtn.TabIndex = 5;
            viewBtn.Text = "View Package";
            viewBtn.UseVisualStyleBackColor = true;
            viewBtn.Click += viewBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(218, 20);
            label1.Name = "label1";
            label1.Size = new Size(74, 28);
            label1.TabIndex = 6;
            label1.Text = "Search:";
            // 
            // searchBox
            // 
            searchBox.Location = new Point(298, 20);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(307, 27);
            searchBox.TabIndex = 7;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // packagefrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 423);
            Controls.Add(searchBox);
            Controls.Add(label1);
            Controls.Add(viewBtn);
            Controls.Add(exitBtn);
            Controls.Add(deleteBtn);
            Controls.Add(modifyBtn);
            Controls.Add(addBtn);
            Controls.Add(dgvPackages);
            Name = "packagefrm";
            Text = "Package";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPackages).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPackages;
        private Button addBtn;
        private Button modifyBtn;
        private Button deleteBtn;
        private Button exitBtn;
        private Button viewBtn;
        private Label label1;
        private TextBox searchBox;
    }
}