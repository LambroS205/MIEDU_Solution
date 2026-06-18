using System;
using System.Windows.Forms;
using MIEDU.BLL.Services;

namespace MIEDU.UI.UserControls
{
    public partial class ucQuanLyGiangVien : UserControl
    {
        private GiangVienBLL _giangVienBLL;

        public ucQuanLyGiangVien()
        {
            InitializeComponent();
            _giangVienBLL = new GiangVienBLL();
        }

        private void ucQuanLyGiangVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvGiangVien.DataSource = _giangVienBLL.GetAll();
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGrid()
        {
            // Tùy chỉnh hiển thị các cột (Ẩn bớt cột không cần thiết hoặc đổi tên tiếng Việt)
            if (dgvGiangVien.Columns["LoaiNhanSu"] != null) dgvGiangVien.Columns["LoaiNhanSu"].Visible = false;

            if (dgvGiangVien.Columns["MaNhanSu"] != null) dgvGiangVien.Columns["MaNhanSu"].HeaderText = "Mã GV";
            if (dgvGiangVien.Columns["HoTen"] != null) dgvGiangVien.Columns["HoTen"].HeaderText = "Họ Tên";
            if (dgvGiangVien.Columns["NgaySinh"] != null) dgvGiangVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            if (dgvGiangVien.Columns["GioiTinh"] != null) dgvGiangVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
            if (dgvGiangVien.Columns["MaKhoa"] != null) dgvGiangVien.Columns["MaKhoa"].HeaderText = "Mã Khoa";
            if (dgvGiangVien.Columns["HocVi"] != null) dgvGiangVien.Columns["HocVi"].HeaderText = "Học Vị";
            if (dgvGiangVien.Columns["ChucDanh"] != null) dgvGiangVien.Columns["ChucDanh"].HeaderText = "Chức Danh";
            if (dgvGiangVien.Columns["SoGioChuan"] != null) dgvGiangVien.Columns["SoGioChuan"].HeaderText = "Giờ Chuẩn";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            dgvGiangVien.DataSource = _giangVienBLL.Search(keyword);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            dgvGiangVien.DataSource = _giangVienBLL.GetSortedByName();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadData();
        }
    }
}