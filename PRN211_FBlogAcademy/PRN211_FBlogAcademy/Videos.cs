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

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            updateGridView();
        }
        public void updateGridView()
        {
            var videos = videoRepository.GetAll().ToList();
            if (videos != null)
            {
                var listVideo = videos.ToList();

                dgvVideos.DataSource = listVideo.Select(p => new
                {
                    Id = p.Id,
                    PostId = p.PostId,
                    Url = p.Url,
                    Created_at = p.CreatedAt,
                    Status = p.Status,
                }).ToList();
            }
        }

        public bool checkData()
        {
            if (txtPostId.Text.Trim() == "")
            {
                MessageBox.Show("Post Id required!");
                return false;
            }

            if (txtURL.Text.Trim() == "")
            {
                MessageBox.Show("Video URL required!");
                return false;
            }

            return true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!checkData()) return;

            var post = postRepository.GetAll().FirstOrDefault(p => p.Id == int.Parse(txtPostId.Text));
            if (post == null)
            {
                MessageBox.Show("Post is not exists!");
                return;
            }

            var video = new Data.Models.Video()
            {
                PostId = int.Parse(txtPostId.Text.Trim()),
                Url = txtURL.Text.Trim(),
                CreatedAt = DateTime.Now,
                Status = true
            };

            videoRepository.Add(video);
            updateGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!checkData()) return;

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

            updateGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!checkData()) return;

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

            videoRepository.DeleteEntity(video);

            updateGridView();
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
