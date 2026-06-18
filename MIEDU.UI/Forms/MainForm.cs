using System;
using System.Windows.Forms;
using MIEDU.UI.Utils;
using MIEDU.UI.UserControls; // Thêm dòng này

namespace MIEDU.UI.Forms
{
    public partial class MainForm : Form
    {
        private LoginForm _loginForm;

        public MainForm(LoginForm loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Hiển thị thông tin người dùng đang đăng nhập
            if (Session.IsLoggedIn)
            {
                lblUserInfo.Text = $"Xin chào, {Session.CurrentUser.Username}\nVai trò: {Session.CurrentUser.GetRoleName()}";
            }

            // Mở mặc định trang Quản lý giảng viên
            btnQuanLyGV_Click(null, null);
        }

        // Hàm hỗ trợ để load UserControl vào pnlContent
        private void LoadUserControl(UserControl uc)
        {
            pnlContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

        private void btnQuanLyGV_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucQuanLyGiangVien());
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucPhanCong());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucThongKe());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Xóa session và hiển thị lại form login
            Session.Logout();
            this.Hide();
            _loginForm.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Tắt hoàn toàn ứng dụng nếu tắt MainForm
            Application.Exit();
        }
    }
}