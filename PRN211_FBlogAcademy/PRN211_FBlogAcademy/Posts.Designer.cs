namespace PRN211_FBlogAcademy
{
    partial class Posts
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
            lbTitle = new Label();
            lbContent = new Label();
            lbLabel = new Label();
            btnBack = new Button();
            txtTitle = new TextBox();
            txtContent = new TextBox();
            btnUpdate = new Button();
            btnCreate = new Button();
            btnDelete = new Button();
            dgvPosts = new DataGridView();
            lbId = new Label();
            txtId = new TextBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPosts).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new Point(22, 164);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(29, 15);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Title";
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.Location = new Point(22, 193);
            lbContent.Name = "lbContent";
            lbContent.Size = new Size(50, 15);
            lbContent.TabIndex = 1;
            lbContent.Text = "Content";
            // 
            // lbLabel
            // 
            lbLabel.AutoSize = true;
            lbLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbLabel.Location = new Point(416, 37);
            lbLabel.Name = "lbLabel";
            lbLabel.Size = new Size(344, 45);
            lbLabel.TabIndex = 2;
            lbLabel.Text = "POST MANAGEMENT";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(104, 23);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back to Main";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(87, 161);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(169, 23);
            txtTitle.TabIndex = 4;
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(87, 190);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(169, 23);
            txtContent.TabIndex = 5;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(87, 219);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(128, 255, 255);
            btnCreate.Location = new Point(181, 219);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(181, 258);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvPosts
            // 
            dgvPosts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPosts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvPosts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPosts.Location = new Point(306, 132);
            dgvPosts.Name = "dgvPosts";
            dgvPosts.RowTemplate.Height = 25;
            dgvPosts.Size = new Size(653, 306);
            dgvPosts.TabIndex = 9;
            dgvPosts.CellDoubleClick += dgvPosts_CellDoubleClick;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(22, 135);
            lbId.Name = "lbId";
            lbId.Size = new Size(17, 15);
            lbId.TabIndex = 10;
            lbId.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(87, 132);
            txtId.Name = "txtId";
            txtId.Size = new Size(169, 23);
            txtId.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(306, 103);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(387, 103);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(572, 23);
            txtSearch.TabIndex = 13;
            // 
            // Posts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 450);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(txtId);
            Controls.Add(lbId);
            Controls.Add(dgvPosts);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(btnUpdate);
            Controls.Add(txtContent);
            Controls.Add(txtTitle);
            Controls.Add(btnBack);
            Controls.Add(lbLabel);
            Controls.Add(lbContent);
            Controls.Add(lbTitle);
            Name = "Posts";
            Text = "Post";
            ((System.ComponentModel.ISupportInitialize)dgvPosts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label lbContent;
        private Label lbLabel;
        private Button btnBack;
        private TextBox txtTitle;
        private TextBox txtContent;
        private Button btnUpdate;
        private Button btnCreate;
        private Button btnDelete;
        private DataGridView dgvPosts;
        private Label lbId;
        private TextBox txtId;
        private Button btnSearch;
        private TextBox txtSearch;
    }
}