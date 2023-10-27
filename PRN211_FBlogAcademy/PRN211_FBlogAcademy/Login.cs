using Data;

namespace PRN211_FBlogAcademy
{
    public partial class Login : Form
    {
        private readonly ConfigHelper _configHelper;

        public Login()
        {
            _configHelper = new();
            InitializeComponent();
            btnLogin.Enabled = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            var adminEmail = _configHelper.config["Admin:email"];
            var adminPassword = _configHelper.config["Admin:password"];

            if (email == adminEmail && password == adminPassword)
            {
                this.Hide();
                Main main = new();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login failed");
            }

        }
    }
}