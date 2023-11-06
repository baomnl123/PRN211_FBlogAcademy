using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_FBlogAcademy
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            this.Hide();
            Posts post = new();
            post.ShowDialog();
            //this.Close();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Images image = new();
            image.ShowDialog();
            //this.Close();
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Videos video = new();
            video.ShowDialog();
            //this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new();
            login.ShowDialog();
            this.Close();
        }
    }
}
