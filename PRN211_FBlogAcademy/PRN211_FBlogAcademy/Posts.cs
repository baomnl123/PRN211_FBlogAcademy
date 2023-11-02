using Data.Models;
using Data.Repository;

namespace PRN211_FBlogAcademy
{
    public partial class Posts : Form
    {
        public PostRepository postRepository;
        public ImageRepository imageRepository;
        public VideoRepository videoRepository;

        public Posts()
        {
            InitializeComponent();
            postRepository = new PostRepository();
            imageRepository = new ImageRepository();
            videoRepository = new VideoRepository();

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            txtId.ReadOnly = true;

            updateGridView();
        }

        public void updateGridView()
        {
            var posts = postRepository.GetAll().ToList();
            if (posts != null)
            {
                var listPost = posts.ToList();

                dgvPosts.DataSource = listPost.Where(p => p.Status == true).ToList();
            }
        }

        public bool checkData()
        {
            if (txtTitle.Text.Trim() == "")
            {
                MessageBox.Show("Title required!");
                return false;
            }

            if (txtContent.Text.Trim() == "")
            {
                MessageBox.Show("Content required!");
                return false;
            }

            return true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkData()) return;

                var post = new Post()
                {
                    Title = txtTitle.Text,
                    Content = txtContent.Text,
                    CreatedAt = DateTime.Now,
                    Status = true
                };
                postRepository.Add(post);
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
                if (!checkData()) return;

                var id = int.Parse(txtId.Text.Trim());
                var post = postRepository.GetAll().FirstOrDefault(p => p.Id == id);
                if (post == null)
                {
                    MessageBox.Show("Post does not exists!");
                    return;
                }

                post.Title = txtTitle.Text;
                post.Content = txtContent.Text;
                post.UpdatedAt = DateTime.Now;
                postRepository.UpdateEntity(post);

                updateGridView();

                btnCreate.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
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
                var post = postRepository.GetAll().FirstOrDefault(p => p.Id == id);
                if (post == null)
                {
                    MessageBox.Show("Post does not exists!");
                    return;
                }

                post.Status = false;
                postRepository.DeleteEntity(post);

                var images = imageRepository.GetAll().Where(p => p.PostId == post.Id).ToList();
                foreach (var image in images)
                {
                    image.Status = false;
                    imageRepository.DeleteEntity(image);
                }

                var videos = videoRepository.GetAll().Where(p => p.PostId == post.Id).ToList();
                foreach (var video in videos)
                {
                    video.Status = false;
                    videoRepository.DeleteEntity(video);
                }

                updateGridView();

                btnCreate.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPosts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvPosts.Rows[e.RowIndex];
            txtId.Text = row.Cells[0].Value.ToString();
            txtTitle.Text = row.Cells[1].Value.ToString();
            txtContent.Text = row.Cells[2].Value.ToString();

            btnCreate.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new();
            main.ShowDialog();
            this.Close();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            btnCreate.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var posts = postRepository.GetAll().Where(p => p.Title.Contains(txtSearch.Text) && p.Status == true);
            if (posts != null)
            {
                var listPost = posts.ToList();

                dgvPosts.DataSource = listPost.ToList();
            }

            btnCreate.Enabled = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtId.Text = null;
            txtTitle.Text = null;
            txtContent.Text = null;

            btnCreate.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
    }
}
