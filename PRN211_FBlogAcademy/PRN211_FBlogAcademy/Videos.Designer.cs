namespace PRN211_FBlogAcademy
{
    partial class Videos
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
            txtPostId = new TextBox();
            lbPostId = new Label();
            txtId = new TextBox();
            lbId = new Label();
            dgvVideos = new DataGridView();
            btnBack = new Button();
            lbLabel = new Label();
            lbSelectPost = new Label();
            cbPost = new ComboBox();
            btnVideo = new Button();
            btnDelete = new Button();
            btnCreate = new Button();
            btnUpdate = new Button();
            txtURL = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvVideos).BeginInit();
            SuspendLayout();
            // 
            // txtPostId
            // 
            txtPostId.Location = new Point(111, 213);
            txtPostId.Name = "txtPostId";
            txtPostId.Size = new Size(169, 23);
            txtPostId.TabIndex = 37;
            // 
            // lbPostId
            // 
            lbPostId.AutoSize = true;
            lbPostId.Location = new Point(46, 216);
            lbPostId.Name = "lbPostId";
            lbPostId.Size = new Size(43, 15);
            lbPostId.TabIndex = 36;
            lbPostId.Text = "Post Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(111, 184);
            txtId.Name = "txtId";
            txtId.Size = new Size(169, 23);
            txtId.TabIndex = 35;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(46, 187);
            lbId.Name = "lbId";
            lbId.Size = new Size(17, 15);
            lbId.TabIndex = 34;
            lbId.Text = "Id";
            // 
            // dgvVideos
            // 
            dgvVideos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVideos.Location = new Point(315, 155);
            dgvVideos.Name = "dgvVideos";
            dgvVideos.RowTemplate.Height = 25;
            dgvVideos.Size = new Size(756, 352);
            dgvVideos.TabIndex = 33;
            dgvVideos.CellDoubleClick += dgvVideos_CellDoubleClick;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(104, 23);
            btnBack.TabIndex = 29;
            btnBack.Text = "Back to Main";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lbLabel
            // 
            lbLabel.AutoSize = true;
            lbLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbLabel.Location = new Point(496, 57);
            lbLabel.Name = "lbLabel";
            lbLabel.Size = new Size(87, 32);
            lbLabel.TabIndex = 28;
            lbLabel.Text = "VIDEO";
            // 
            // lbSelectPost
            // 
            lbSelectPost.AutoSize = true;
            lbSelectPost.Location = new Point(41, 158);
            lbSelectPost.Name = "lbSelectPost";
            lbSelectPost.Size = new Size(64, 15);
            lbSelectPost.TabIndex = 40;
            lbSelectPost.Text = "Select post";
            // 
            // cbPost
            // 
            cbPost.FormattingEnabled = true;
            cbPost.Location = new Point(111, 155);
            cbPost.Name = "cbPost";
            cbPost.Size = new Size(169, 23);
            cbPost.TabIndex = 39;
            // 
            // btnVideo
            // 
            btnVideo.Location = new Point(15, 242);
            btnVideo.Name = "btnVideo";
            btnVideo.Size = new Size(90, 23);
            btnVideo.TabIndex = 45;
            btnVideo.Text = "Upload Video";
            btnVideo.UseVisualStyleBackColor = true;
            btnVideo.Click += btnVideo_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(205, 300);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 43;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(128, 255, 255);
            btnCreate.Location = new Point(205, 271);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 42;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(111, 271);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 41;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtURL
            // 
            txtURL.Location = new Point(111, 242);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(169, 23);
            txtURL.TabIndex = 46;
            // 
            // Videos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 519);
            Controls.Add(txtURL);
            Controls.Add(btnVideo);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(btnUpdate);
            Controls.Add(lbSelectPost);
            Controls.Add(cbPost);
            Controls.Add(txtPostId);
            Controls.Add(lbPostId);
            Controls.Add(txtId);
            Controls.Add(lbId);
            Controls.Add(dgvVideos);
            Controls.Add(btnBack);
            Controls.Add(lbLabel);
            Name = "Videos";
            Text = "Video";
            ((System.ComponentModel.ISupportInitialize)dgvVideos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPostId;
        private Label lbPostId;
        private TextBox txtId;
        private Label lbId;
        private DataGridView dgvVideos;
        private Button btnBack;
        private Label lbLabel;
        private Label lbSelectPost;
        private ComboBox cbPost;
        private Button btnVideo;
        private Button btnDelete;
        private Button btnCreate;
        private Button btnUpdate;
        private TextBox txtURL;
    }
}