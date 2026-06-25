using System;
using System.Windows.Forms;
using MIEDU.UI.UserControls;
using MIEDU.UI.Utils;

namespace MIEDU.UI.Forms
{
    public partial class MainForm : Form
    {
        private Form _loginForm;

        public MainForm(Form loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
            // Tự động load màn hình Quản lý Giảng viên khi vừa đăng nhập xong
            btnQuanLyGV.PerformClick();
        }

        private void LoadUserInfo()
        {
            if (Session.CurrentUser != null)
            {
                lblUserInfo.Text = $"Xin chào, {Session.CurrentUser.Username}\nVai trò: {Session.CurrentUser.GetRoleName()}";
            }
        }

        // Hàm hỗ trợ để chuyển đổi giữa các màn hình chức năng (UserControl)
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

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucThongTinCaNhan());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Session.Logout();
                this.Hide();
                _loginForm.Show();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}