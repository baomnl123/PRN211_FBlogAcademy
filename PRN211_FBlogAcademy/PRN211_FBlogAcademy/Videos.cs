using Data.Models;
using Data.Repository;
using System.Data;

namespace PRN211_FBlogAcademy
{
    public partial class Videos : Form
    {
        public PostRepository postRepository;
        public VideoRepository videoRepository;

        public Videos()
        {
            InitializeComponent();

            postRepository = new PostRepository();
            videoRepository = new VideoRepository();

            txtId.ReadOnly = true;
            txtPostId.ReadOnly = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            var posts = postRepository.GetAll().Where(p => p.Status == true).ToList();
            if (posts != null && posts.Count > 0)
            {
                cbPost.DataSource = posts;
                cbPost.DisplayMember = "Title";
                cbPost.ValueMember = "Id";
            }

            updateGridView();
        }
        public void updateGridView()
        {
            var videos = videoRepository.GetAll().ToList();
            if (videos != null)
            {
                var listVideo = videos.ToList();
                dgvVideos.DataSource = listVideo.Where(p => p.Status == true).ToList();
            }
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            try
            {
                String videoLocation = "";
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "mp4 files(*.mp4) | *.mp4 | All files(*.*) | *.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    videoLocation = dialog.FileName;
                    txtURL.Text = videoLocation;
                }
            }
            catch
            {
                MessageBox.Show("An error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {

                var post = cbPost.SelectedItem as Post;
                if (post == null)
                {
                    MessageBox.Show("Post is not exists!");
                    return;
                }

                if (txtURL.Text.Trim() == null)
                {
                    MessageBox.Show("Video is required!");
                    return;
                }

                var video = new Video()
                {
                    PostId = post.Id,
                    Url = txtURL.Text.Trim(),
                    CreatedAt = DateTime.Now,
                    Status = true
                };

                videoRepository.Add(video);
                updateGridView();
            }
            catch
            {
                MessageBox.Show("An error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                var id = int.Parse(txtId.Text.Trim());
                var video = videoRepository.GetAll().FirstOrDefault(p => p.Id == id);
                if (video == null)
                {
                    MessageBox.Show("Video is not exists!");
                    return;
                }

                var post = postRepository.GetAll().FirstOrDefault(p => p.Id == int.Parse(txtPostId.Text));
                if (post == null)
                {
                    MessageBox.Show("Post is not exists!");
                    return;
                }

                video.Url = txtURL.Text.Trim();
                videoRepository.UpdateEntity(video);

                btnCreate.Enabled = true;
                updateGridView();
            }
            catch
            {
                MessageBox.Show("An error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = int.Parse(txtId.Text.Trim());
                var video = videoRepository.GetAll().FirstOrDefault(p => p.Id == id);
                if (video == null)
                {
                    MessageBox.Show("Video is not exists!");
                    return;
                }

                var post = postRepository.GetAll().FirstOrDefault(p => p.Id == int.Parse(txtPostId.Text));
                if (post == null)
                {
                    MessageBox.Show("Post is not exists!");
                    return;
                }

                video.Status = false;
                videoRepository.DeleteEntity(video);

                btnCreate.Enabled = true;
                updateGridView();
            }
            catch
            {
                MessageBox.Show("An error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvVideos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvVideos.Rows[e.RowIndex];
            txtId.Text = row.Cells[0].Value.ToString();
            txtPostId.Text = row.Cells[1].Value.ToString();
            txtURL.Text = row.Cells[2].Value.ToString();

            btnCreate.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {
            btnCreate.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new();
            main.ShowDialog();
            this.Close();
        }
    }
}
