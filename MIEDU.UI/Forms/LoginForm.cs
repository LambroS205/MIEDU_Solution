using System;
using System.Windows.Forms;
using MIEDU.BLL.Services;
using MIEDU.UI.Utils;

namespace MIEDU.UI.Forms
{
    public partial class LoginForm : Form
    {
        private AuthBLL _authBLL;

        public LoginForm()
        {
            InitializeComponent();
            _authBLL = new AuthBLL();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = _authBLL.Login(username, password);

            if (user != null)
            {
                // Lưu session
                Session.CurrentUser = user;

                // Mở MainForm và ẩn Form Đăng nhập
                MainForm mainForm = new MainForm(this);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}