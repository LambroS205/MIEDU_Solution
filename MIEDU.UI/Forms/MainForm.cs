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
            ApplyAuthorization(); // Gọi hàm phân quyền khi form load
        }

        private void LoadUserInfo()
        {
            if (Session.CurrentUser != null)
            {
                lblUserInfo.Text = $"Xin chào, {Session.CurrentUser.Username}\nVai trò: {Session.CurrentUser.GetRoleName()}";
            }
        }

        private void ApplyAuthorization()
        {
            if (Session.CurrentUser == null) return;

            // Kiểm tra Role của User hiện tại
            if (Session.CurrentUser.RoleName == "GiangVien")
            {
                // 1. Ẩn các chức năng Quản trị đối với Giảng viên
                btnQuanLyGV.Visible = false;
                btnQuanLyMonHoc.Visible = false;
                btnPhanCong.Visible = false;

                // 2. Dịch chuyển các nút còn lại lên trên để lấp khoảng trống (tọa độ Y bắt đầu từ 150)
                int startY = 150;
                btnThongKe.Location = new System.Drawing.Point(0, startY);
                btnThongTinCaNhan.Location = new System.Drawing.Point(0, startY + 50);

                // 3. Màn hình khởi động mặc định cho Giảng viên
                btnThongTinCaNhan.PerformClick();
            }
            else // Admin hoặc Chuyên viên
            {
                // 1. Hiện đầy đủ chức năng
                btnQuanLyGV.Visible = true;
                btnQuanLyMonHoc.Visible = true;
                btnPhanCong.Visible = true;

                // 2. Khôi phục tọa độ gốc cho các nút
                btnQuanLyGV.Location = new System.Drawing.Point(0, 150);
                btnQuanLyMonHoc.Location = new System.Drawing.Point(0, 200);
                btnPhanCong.Location = new System.Drawing.Point(0, 250);
                btnThongKe.Location = new System.Drawing.Point(0, 300);
                btnThongTinCaNhan.Location = new System.Drawing.Point(0, 350);

                // 3. Màn hình khởi động mặc định cho Admin
                btnQuanLyGV.PerformClick();
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

        private void btnQuanLyMonHoc_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucQuanLyMonHoc());
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