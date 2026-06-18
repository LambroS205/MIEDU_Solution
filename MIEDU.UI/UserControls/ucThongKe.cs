using System;
using System.Windows.Forms;
using MIEDU.BLL.Services;

namespace MIEDU.UI.UserControls
{
    public partial class ucThongKe : UserControl
    {
        private readonly ThongKeBLL _thongKeBLL;

        public ucThongKe()
        {
            InitializeComponent();
            _thongKeBLL = new ThongKeBLL();
        }

        private void ucThongKe_Load(object sender, EventArgs e)
        {
            LoadThongKe();
        }

        private void LoadThongKe()
        {
            try
            {
                // Load dữ liệu thẻ (Cards)
                var tongQuan = _thongKeBLL.GetTongQuan();
                lblCountGV.Text = tongQuan.TongGiangVien.ToString("N0");
                lblCountCV.Text = tongQuan.TongChuyenVien.ToString("N0");
                lblCountMon.Text = tongQuan.TongMonHoc.ToString("N0");
                lblCountPC.Text = tongQuan.TongPhanCong.ToString("N0");

                // Load dữ liệu Grid (Thống kê theo học vị)
                dgvHocVi.DataSource = _thongKeBLL.GetThongKeHocVi();

                if (dgvHocVi.Columns["HocVi"] != null) dgvHocVi.Columns["HocVi"].HeaderText = "Học Vị";
                if (dgvHocVi.Columns["SoLuong"] != null) dgvHocVi.Columns["SoLuong"].HeaderText = "Số Lượng (Người)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadThongKe();
        }
    }
}