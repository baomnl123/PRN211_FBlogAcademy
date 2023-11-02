
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
            var images = imageRepository.GetAll().ToList();
            if (images != null)
            {
                var listImage = images.ToList();
                dgvImages.DataSource = listImage.Where(p => p.Status == true).ToList();
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            try
            {
                String imageLocation = "";
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg) | *.jpg | PNG files(*.png) | *.png | All files(*.*) | *.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pctImage.ImageLocation = imageLocation;
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

                if (pctImage == null)
                {
                    MessageBox.Show("Image is required!");
                    return;
                }

                var image = new Data.Models.Image()
                {
                    PostId = post.Id,
                    Url = pctImage.ImageLocation,
                    CreatedAt = DateTime.Now,
                    Status = true
                };

                imageRepository.Add(image);
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

                image.Url = pctImage.ImageLocation;
                imageRepository.UpdateEntity(image);

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

                image.Status = false;
                imageRepository.DeleteEntity(image);

                btnCreate.Enabled = true;
                updateGridView();
            }
            catch
            {
                MessageBox.Show("An error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvImages_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvImages.Rows[e.RowIndex];
            txtId.Text = row.Cells[0].Value.ToString();
            txtPostId.Text = row.Cells[1].Value.ToString();
            pctImage.ImageLocation = row.Cells[2].Value.ToString();

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

        private void cbPost_SelectedIndexChanged(object sender, EventArgs e)
        {
            var post = cbPost.SelectedItem as Post;
            txtPostId.Text = post.Id.ToString();
            var images = imageRepository.GetAll().Where(p => p.PostId == post.Id && p.Status == true);
            if (images != null)
            {
                var listImage = images.ToList();

                dgvImages.DataSource = listImage.ToList();
            }
        }
    }
}
