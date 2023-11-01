namespace PRN211_FBlogAcademy
{
    partial class Images
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
            txtId = new TextBox();
            lbId = new Label();
            dgvImages = new DataGridView();
            btnDelete = new Button();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnBack = new Button();
            lbLabel = new Label();
            lbURL = new Label();
            txtPostId = new TextBox();
            lbPostId = new Label();
            txtURL = new TextBox();
            cbPost = new ComboBox();
            lbSelectPost = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvImages).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(96, 176);
            txtId.Name = "txtId";
            txtId.Size = new Size(169, 23);
            txtId.TabIndex = 23;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(26, 179);
            lbId.Name = "lbId";
            lbId.Size = new Size(17, 15);
            lbId.TabIndex = 22;
            lbId.Text = "Id";
            // 
            // dgvImages
            // 
            dgvImages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImages.Location = new Point(312, 147);
            dgvImages.Name = "dgvImages";
            dgvImages.RowTemplate.Height = 25;
            dgvImages.Size = new Size(639, 276);
            dgvImages.TabIndex = 21;
            dgvImages.CellDoubleClick += dgvImages_CellDoubleClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(190, 302);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(128, 255, 255);
            btnCreate.Location = new Point(190, 263);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 19;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(96, 263);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(104, 23);
            btnBack.TabIndex = 15;
            btnBack.Text = "Back to Main";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lbLabel
            // 
            lbLabel.AutoSize = true;
            lbLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbLabel.Location = new Point(428, 47);
            lbLabel.Name = "lbLabel";
            lbLabel.Size = new Size(92, 32);
            lbLabel.TabIndex = 14;
            lbLabel.Text = "IMAGE";
            // 
            // lbURL
            // 
            lbURL.AutoSize = true;
            lbURL.Location = new Point(26, 237);
            lbURL.Name = "lbURL";
            lbURL.Size = new Size(28, 15);
            lbURL.TabIndex = 13;
            lbURL.Text = "URL";
            // 
            // txtPostId
            // 
            txtPostId.Location = new Point(96, 205);
            txtPostId.Name = "txtPostId";
            txtPostId.Size = new Size(169, 23);
            txtPostId.TabIndex = 25;
            // 
            // lbPostId
            // 
            lbPostId.AutoSize = true;
            lbPostId.Location = new Point(26, 208);
            lbPostId.Name = "lbPostId";
            lbPostId.Size = new Size(43, 15);
            lbPostId.TabIndex = 24;
            lbPostId.Text = "Post Id";
            // 
            // txtURL
            // 
            txtURL.Location = new Point(96, 234);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(169, 23);
            txtURL.TabIndex = 26;
            txtURL.TextChanged += txtURL_TextChanged;
            // 
            // cbPost
            // 
            cbPost.FormattingEnabled = true;
            cbPost.Location = new Point(96, 147);
            cbPost.Name = "cbPost";
            cbPost.Size = new Size(169, 23);
            cbPost.TabIndex = 27;
            // 
            // lbSelectPost
            // 
            lbSelectPost.AutoSize = true;
            lbSelectPost.Location = new Point(26, 150);
            lbSelectPost.Name = "lbSelectPost";
            lbSelectPost.Size = new Size(64, 15);
            lbSelectPost.TabIndex = 28;
            lbSelectPost.Text = "Select post";
            // 
            // Images
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 450);
            Controls.Add(lbSelectPost);
            Controls.Add(cbPost);
            Controls.Add(txtURL);
            Controls.Add(txtPostId);
            Controls.Add(lbPostId);
            Controls.Add(txtId);
            Controls.Add(lbId);
            Controls.Add(dgvImages);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(btnUpdate);
            Controls.Add(btnBack);
            Controls.Add(lbLabel);
            Controls.Add(lbURL);
            Name = "Images";
            Text = "Image";
            ((System.ComponentModel.ISupportInitialize)dgvImages).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label lbId;
        private DataGridView dgvImages;
        private Button btnDelete;
        private Button btnCreate;
        private Button btnUpdate;
        private TextBox txtTitle;
        private Button btnBack;
        private Label lbLabel;
        private Label lbURL;
        private TextBox txtPostId;
        private Label lbPostId;
        private Label lbTitle;
        private TextBox txtURL;
        private ComboBox cbPost;
        private Label lbSelectPost;
    }
}