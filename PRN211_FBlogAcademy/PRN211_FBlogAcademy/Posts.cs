using Data.Models;
using Data.Repository;

namespace PRN211_FBlogAcademy
{
    public partial class Posts : Form
    {
        public PostRepository postRepository;

        public Posts()
        {
            InitializeComponent();
            postRepository = new PostRepository();

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            updateGridView();
        }

        public void updateGridView()
        {
            var posts = postRepository.GetAll().ToList();
            if (posts != null)
            {
                var listPost = posts.ToList();

                dgvPosts.DataSource = listPost.Select(p => new
                {
                    Id = p.Id,
                    Title = p.Title,
                    Content = p.Content,
                    Created_at = p.CreatedAt,
                    Updated_at = p.UpdatedAt,
                    Status = p.Status,
                }).ToList();
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

        private void btnUpdate_Click(object sender, EventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtId.Text.Trim());
            var post = postRepository.GetAll().FirstOrDefault(p => p.Id == id);
            if (post == null)
            {
                MessageBox.Show("Post does not exists!");
                return;
            }

            postRepository.DeleteEntity(post);

            updateGridView();

            btnCreate.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
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
    }
}
