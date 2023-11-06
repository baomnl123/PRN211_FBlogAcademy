using Data.Models;
using Data.Repository;
using Microsoft.EntityFrameworkCore;
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
            txtURL.ReadOnly = true;
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
            var videos = videoRepository.GetAll().Where(p => p.Status).Include(p => p.Post).ToList();
            if (videos != null && videos.Count > 0)
            {
                dgvVideos.DataSource = videos.Select(p => new
                {
                    Id = p.Id,
                    Post = p.Post?.Title,
                    Url = p.Url,
                    CreatedAt = p.CreatedAt,
                }).ToList();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                string videoUrl = txtURL.Text.Trim();
                if (txtURL.Text.Trim() == null)
                {
                    MessageBox.Show("Video is required!");
                    return;
                }

                string fileExtension = System.IO.Path.GetExtension(videoUrl);
                if (fileExtension != ".mp4")
                {
                    MessageBox.Show("You must upload a video file with a .mp4 extension.");
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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


                video.Url = txtURL.Text.Trim();
                if (txtURL.Text.Contains("png") || txtURL.Text.Contains("jpg"))
                {
                    MessageBox.Show("You must upload Video");
                    return;
                }
                videoRepository.UpdateEntity(video);

                btnCreate.Enabled = true;
                updateGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

                video.Status = false;
                videoRepository.DeleteEntity(video);

                btnCreate.Enabled = true;
                updateGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvVideos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dgvVideos.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                cbPost.Text = row.Cells[1].Value.ToString();
                txtURL.Text = row.Cells[2].Value.ToString();

                btnCreate.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtId.Text = null;
            txtURL.Text = null;

            btnCreate.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
    }
}
