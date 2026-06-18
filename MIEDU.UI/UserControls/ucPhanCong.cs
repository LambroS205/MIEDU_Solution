using MIEDU.BLL.Services;
using MIEDU.Models.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MIEDU.UI.UserControls
{
    public partial class ucPhanCong : UserControl
    {
        private readonly PhanCongBLL _phanCongBLL;
        private readonly GiangVienBLL _giangVienBLL;
        private readonly MonHocBLL _monHocBLL;

        public ucPhanCong()
        {
            InitializeComponent();
            _phanCongBLL = new PhanCongBLL();
            _giangVienBLL = new GiangVienBLL();
            _monHocBLL = new MonHocBLL();
        }

        private void ucPhanCong_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
            LoadGridData();
        }

        private void LoadComboBoxData()
        {
            try
            {
                // Đổ dữ liệu Giảng viên
                cbGiangVien.DataSource = _giangVienBLL.GetAll();
                cbGiangVien.DisplayMember = "HoTen";
                cbGiangVien.ValueMember = "MaNhanSu";

                // Đổ dữ liệu Môn học
                cbMonHoc.DataSource = _monHocBLL.GetAll();
                cbMonHoc.DisplayMember = "TenMon";
                cbMonHoc.ValueMember = "MaMon";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadGridData()
        {
            try
            {
                var data = _phanCongBLL.GetAll();
                // Dùng LINQ tạo ra object Anonymous để mapping hiển thị lên Grid cho đẹp
                var displayData = data.Select(x => new {
                    x.ID,
                    TenGiangVien = x.GiangVienInfo.HoTen,
                    TenMonHoc = x.MonHocInfo.TenMon,
                    x.HocKy,
                    x.NamHoc
                }).ToList();

                dgvPhanCong.DataSource = displayData;
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách phân công: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGrid()
        {
            if (dgvPhanCong.Columns["ID"] != null) dgvPhanCong.Columns["ID"].Visible = false;
            if (dgvPhanCong.Columns["TenGiangVien"] != null) dgvPhanCong.Columns["TenGiangVien"].HeaderText = "Tên Giảng Viên";
            if (dgvPhanCong.Columns["TenMonHoc"] != null) dgvPhanCong.Columns["TenMonHoc"].HeaderText = "Tên Môn Học";
            if (dgvPhanCong.Columns["HocKy"] != null) dgvPhanCong.Columns["HocKy"].HeaderText = "Học Kỳ";
            if (dgvPhanCong.Columns["NamHoc"] != null) dgvPhanCong.Columns["NamHoc"].HeaderText = "Năm Học";
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                string maGV = cbGiangVien.SelectedValue?.ToString() ?? "";
                string maMon = cbMonHoc.SelectedValue?.ToString() ?? "";
                int hocKy = (int)numHocKy.Value;
                string namHoc = txtNamHoc.Text.Trim();

                bool result = _phanCongBLL.AddPhanCong(maGV, maMon, hocKy, namHoc);
                if (result)
                {
                    MessageBox.Show("Phân công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGridData(); // Refresh Grid
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Nghiệp vụ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}