﻿namespace PRN211_FBlogAcademy
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
            cbPost = new ComboBox();
            lbSelectPost = new Label();
            pctImage = new PictureBox();
            btnImage = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvImages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctImage).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(110, 176);
            txtId.Name = "txtId";
            txtId.Size = new Size(169, 23);
            txtId.TabIndex = 23;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(40, 179);
            lbId.Name = "lbId";
            lbId.Size = new Size(17, 15);
            lbId.TabIndex = 22;
            lbId.Text = "Id";
            // 
            // dgvImages
            // 
            dgvImages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvImages.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvImages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImages.Location = new Point(306, 147);
            dgvImages.Name = "dgvImages";
            dgvImages.RowTemplate.Height = 25;
            dgvImages.Size = new Size(763, 357);
            dgvImages.TabIndex = 21;
            dgvImages.CellDoubleClick += dgvImages_CellDoubleClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(204, 343);
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
            btnCreate.Location = new Point(204, 314);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 19;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(110, 314);
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
            lbLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbLabel.Location = new Point(487, 58);
            lbLabel.Name = "lbLabel";
            lbLabel.Size = new Size(367, 45);
            lbLabel.TabIndex = 14;
            lbLabel.Text = "IMAGE MANAGEMENT";
            // 
            // cbPost
            // 
            cbPost.FormattingEnabled = true;
            cbPost.Location = new Point(110, 147);
            cbPost.Name = "cbPost";
            cbPost.Size = new Size(169, 23);
            cbPost.TabIndex = 27;
            // 
            // lbSelectPost
            // 
            lbSelectPost.AutoSize = true;
            lbSelectPost.Location = new Point(40, 150);
            lbSelectPost.Name = "lbSelectPost";
            lbSelectPost.Size = new Size(64, 15);
            lbSelectPost.TabIndex = 28;
            lbSelectPost.Text = "Select post";
            // 
            // pctImage
            // 
            pctImage.Location = new Point(110, 205);
            pctImage.Name = "pctImage";
            pctImage.Size = new Size(169, 103);
            pctImage.SizeMode = PictureBoxSizeMode.Zoom;
            pctImage.TabIndex = 29;
            pctImage.TabStop = false;
            // 
            // btnImage
            // 
            btnImage.Location = new Point(14, 254);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(90, 23);
            btnImage.TabIndex = 30;
            btnImage.Text = "Upload Image";
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += btnImage_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(110, 343);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 31;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // Images
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 514);
            Controls.Add(btnRefresh);
            Controls.Add(btnImage);
            Controls.Add(pctImage);
            Controls.Add(lbSelectPost);
            Controls.Add(cbPost);
            Controls.Add(txtId);
            Controls.Add(lbId);
            Controls.Add(dgvImages);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(btnUpdate);
            Controls.Add(btnBack);
            Controls.Add(lbLabel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Images";
            Text = "Image";
            ((System.ComponentModel.ISupportInitialize)dgvImages).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctImage).EndInit();
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
        private Label lbTitle;
        private ComboBox cbPost;
        private Label lbSelectPost;
        private PictureBox pctImage;
        private Button btnImage;
        private Button btnRefresh;
    }
}