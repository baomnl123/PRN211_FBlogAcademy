
using Data.Models;
using Data.Repository;

namespace PRN211_FBlogAcademy
{
    public partial class Images : Form
    {
        public PostRepository postRepository;
        public ImageRepository imageRepository;

        public Images()
        {
            InitializeComponent();

            postRepository = new PostRepository();
            imageRepository = new ImageRepository();

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            updateGridView();
        }

        public void updateGridView()
        {
            var images = imageRepository.GetAll().ToList();
            if (images != null)
            {
                var listImage = images.ToList();

                dgvImages.DataSource = listImage.Select(p => new
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
                MessageBox.Show("Image URL required!");
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

            var image = new Data.Models.Image()
            {
                PostId = int.Parse(txtPostId.Text.Trim()),
                Url = txtURL.Text.Trim(),
                CreatedAt = DateTime.Now,
                Status = true
            };

            imageRepository.Add(image);
            updateGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!checkData()) return;

            var id = int.Parse(txtId.Text.Trim());
            var image = imageRepository.GetAll().FirstOrDefault(p => p.Id == id);
            if (image == null)
            {
                MessageBox.Show("Image is not exists!");
                return;
            }

            var post = postRepository.GetAll().FirstOrDefault(p => p.Id == int.Parse(txtPostId.Text));
            if (post == null)
            {
                MessageBox.Show("Post is not exists!");
                return;
            }

            image.Url = txtURL.Text.Trim();
            imageRepository.UpdateEntity(image);

            updateGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!checkData()) return;

            var id = int.Parse(txtId.Text.Trim());
            var image = imageRepository.GetAll().FirstOrDefault(p => p.Id == id);
            if (image == null)
            {
                MessageBox.Show("Image is not exists!");
                return;
            }

            var post = postRepository.GetAll().FirstOrDefault(p => p.Id == int.Parse(txtPostId.Text));
            if (post == null)
            {
                MessageBox.Show("Post is not exists!");
                return;
            }

            imageRepository.DeleteEntity(image);

            updateGridView();
        }

        private void dgvImages_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvImages.Rows[e.RowIndex];
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
