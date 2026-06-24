using System;
using System.Windows.Forms;
using MIEDU.BLL.Services;
using MIEDU.Models.Entities;

namespace MIEDU.UI.Forms
{
    public partial class frmEditGiangVien : Form
    {
        private GiangVienBLL _giangVienBLL;
        private GiangVien _giangVien;
        private bool _isEditMode;

        public frmEditGiangVien(GiangVien gv = null)
        {
            InitializeComponent();
            _giangVienBLL = new GiangVienBLL();
            _giangVien = gv;
            _isEditMode = (gv != null);
        }

        private void frmEditGiangVien_Load(object sender, EventArgs e)
        {
            // Set up ComboBox
            cbGioiTinh.Items.AddRange(new string[] { "Nam", "Nữ" });
            cbKhoa.Items.AddRange(new string[] { "CNTT", "KT" });
            cbHocVi.Items.AddRange(new string[] { "Cử nhân", "Thạc sĩ", "Tiến sĩ", "Phó Giáo sư" });

            if (_isEditMode)
            {
                lblTitle.Text = "CẬP NHẬT GIẢNG VIÊN";
                txtMaGV.Text = _giangVien.MaNhanSu;
                txtMaGV.Enabled = false; // Mã không được sửa

                txtHoTen.Text = _giangVien.HoTen;
                if (_giangVien.NgaySinh.HasValue) dtpNgaySinh.Value = _giangVien.NgaySinh.Value;
                cbGioiTinh.Text = _giangVien.GioiTinh;
                txtSDT.Text = _giangVien.SoDienThoai;
                txtEmail.Text = _giangVien.Email;
                cbKhoa.Text = _giangVien.MaKhoa;
                cbHocVi.Text = _giangVien.HocVi;
                txtChucDanh.Text = _giangVien.ChucDanh;
                numSoGioChuan.Value = _giangVien.SoGioChuan;
            }
            else
            {
                lblTitle.Text = "THÊM MỚI GIẢNG VIÊN";
                cbGioiTinh.SelectedIndex = 0;
                cbKhoa.SelectedIndex = 0;
                cbHocVi.SelectedIndex = 1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Bắt lỗi Validation từ Setter của Model NhanSu (Email, SDT) và logic từ Form
                var newGv = new GiangVien
                {
                    MaNhanSu = txtMaGV.Text.Trim(),
                    HoTen = txtHoTen.Text.Trim(),
                    NgaySinh = dtpNgaySinh.Value,
                    GioiTinh = cbGioiTinh.Text,
                    SoDienThoai = txtSDT.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    MaKhoa = cbKhoa.Text,
                    HocVi = cbHocVi.Text,
                    ChucDanh = txtChucDanh.Text.Trim(),
                    SoGioChuan = (int)numSoGioChuan.Value
                };

                if (_isEditMode)
                {
                    _giangVienBLL.Update(newGv);
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _giangVienBLL.Add(newGv);
                    MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK; // Báo hiệu cho UserControl load lại Grid
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}