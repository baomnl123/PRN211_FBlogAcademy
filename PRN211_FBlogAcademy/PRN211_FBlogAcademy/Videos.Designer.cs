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
            txtURL = new TextBox();
            txtPostId = new TextBox();
            lbPostId = new Label();
            txtId = new TextBox();
            lbId = new Label();
            dgvVideos = new DataGridView();
            btnDelete = new Button();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnBack = new Button();
            lbLabel = new Label();
            lbURL = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVideos).BeginInit();
            SuspendLayout();
            // 
            // txtURL
            // 
            txtURL.Location = new Point(96, 213);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(169, 23);
            txtURL.TabIndex = 38;
            txtURL.TextChanged += txtURL_TextChanged;
            // 
            // txtPostId
            // 
            txtPostId.Location = new Point(96, 184);
            txtPostId.Name = "txtPostId";
            txtPostId.Size = new Size(169, 23);
            txtPostId.TabIndex = 37;
            // 
            // lbPostId
            // 
            lbPostId.AutoSize = true;
            lbPostId.Location = new Point(31, 187);
            lbPostId.Name = "lbPostId";
            lbPostId.Size = new Size(43, 15);
            lbPostId.TabIndex = 36;
            lbPostId.Text = "Post Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(96, 155);
            txtId.Name = "txtId";
            txtId.Size = new Size(169, 23);
            txtId.TabIndex = 35;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(31, 158);
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
            dgvVideos.Size = new Size(471, 276);
            dgvVideos.TabIndex = 33;
            dgvVideos.CellDoubleClick += dgvVideos_CellDoubleClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(190, 281);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 32;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(128, 255, 255);
            btnCreate.Location = new Point(190, 242);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 31;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(96, 242);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
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
            lbLabel.Location = new Point(359, 84);
            lbLabel.Name = "lbLabel";
            lbLabel.Size = new Size(87, 32);
            lbLabel.TabIndex = 28;
            lbLabel.Text = "VIDEO";
            // 
            // lbURL
            // 
            lbURL.AutoSize = true;
            lbURL.Location = new Point(31, 216);
            lbURL.Name = "lbURL";
            lbURL.Size = new Size(28, 15);
            lbURL.TabIndex = 27;
            lbURL.Text = "URL";
            // 
            // Videos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtURL);
            Controls.Add(txtPostId);
            Controls.Add(lbPostId);
            Controls.Add(txtId);
            Controls.Add(lbId);
            Controls.Add(dgvVideos);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(btnUpdate);
            Controls.Add(btnBack);
            Controls.Add(lbLabel);
            Controls.Add(lbURL);
            Name = "Videos";
            Text = "Video";
            ((System.ComponentModel.ISupportInitialize)dgvVideos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtURL;
        private TextBox txtPostId;
        private Label lbPostId;
        private TextBox txtId;
        private Label lbId;
        private DataGridView dgvVideos;
        private Button btnDelete;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnBack;
        private Label lbLabel;
        private Label lbURL;
    }
}