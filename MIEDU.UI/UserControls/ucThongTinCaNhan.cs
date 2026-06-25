using System;
using System.Windows.Forms;
using MIEDU.BLL.Services;
using MIEDU.UI.Utils;

namespace MIEDU.UI.UserControls
{
    public partial class ucThongTinCaNhan : UserControl
    {
        private readonly UserBLL _userBLL;

        public ucThongTinCaNhan()
        {
            InitializeComponent();
            _userBLL = new UserBLL();
        }

        private void ucThongTinCaNhan_Load(object sender, EventArgs e)
        {
            LoadProfileData();
        }

        private void LoadProfileData()
        {
            try
            {
                var currentUser = Session.CurrentUser;
                if (currentUser == null) return;

                lblUsername.Text = $"Tài khoản: {currentUser.Username}";
                lblRole.Text = $"Vai trò: {currentUser.RoleName}";
                lblMaNhanSu.Text = $"Mã nhân sự: {currentUser.MaNhanSu}";

                // Lấy thông tin từ bảng NhanSu
                var profile = _userBLL.GetProfile(currentUser.MaNhanSu);
                lblHoTen.Text = $"Họ tên: {profile.HoTen}";
                lblKhoa.Text = $"Trực thuộc: {profile.Khoa}";

                txtEmail.Text = profile.Email;
                txtSDT.Text = profile.SoDienThoai;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();
                string sdt = txtSDT.Text.Trim();
                string maNhanSu = Session.CurrentUser.MaNhanSu;

                if (_userBLL.UpdateProfile(maNhanSu, email, sdt))
                {
                    MessageBox.Show("Cập nhật thông tin liên hệ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                string oldPass = txtOldPass.Text;
                string newPass = txtNewPass.Text;
                string confirmPass = txtConfirmPass.Text;
                string username = Session.CurrentUser.Username;

                if (_userBLL.ChangePassword(username, oldPass, newPass, confirmPass))
                {
                    MessageBox.Show("Đổi mật khẩu thành công! Vui lòng ghi nhớ mật khẩu mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtOldPass.Clear();
                    txtNewPass.Clear();
                    txtConfirmPass.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}