namespace PRN211_FBlogAcademy
{
    partial class Main
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
            btnPost = new Button();
            btnImage = new Button();
            btnVideo = new Button();
            btnLogout = new Button();
            fblogLabel = new Label();
            SuspendLayout();
            // 
            // btnPost
            // 
            btnPost.Location = new Point(153, 176);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(90, 90);
            btnPost.TabIndex = 0;
            btnPost.Text = "View Post";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // btnImage
            // 
            btnImage.Location = new Point(357, 176);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(90, 90);
            btnImage.TabIndex = 1;
            btnImage.Text = "View Image";
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += btnImage_Click;
            // 
            // btnVideo
            // 
            btnVideo.Location = new Point(556, 176);
            btnVideo.Name = "btnVideo";
            btnVideo.Size = new Size(90, 90);
            btnVideo.TabIndex = 2;
            btnVideo.Text = "View Video";
            btnVideo.UseVisualStyleBackColor = true;
            btnVideo.Click += btnVideo_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Brown;
            btnLogout.ForeColor = SystemColors.Control;
            btnLogout.Location = new Point(12, 415);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // fblogLabel
            // 
            fblogLabel.AutoSize = true;
            fblogLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            fblogLabel.ForeColor = Color.Red;
            fblogLabel.Location = new Point(207, 88);
            fblogLabel.Name = "fblogLabel";
            fblogLabel.Size = new Size(394, 32);
            fblogLabel.TabIndex = 4;
            fblogLabel.Text = "FBLOG ACADEMY MANAGEMENT";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(fblogLabel);
            Controls.Add(btnLogout);
            Controls.Add(btnVideo);
            Controls.Add(btnImage);
            Controls.Add(btnPost);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPost;
        private Button btnImage;
        private Button btnVideo;
        private Button btnLogout;
        private Label fblogLabel;
    }
}