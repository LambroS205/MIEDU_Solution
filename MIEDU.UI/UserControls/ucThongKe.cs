using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MIEDU.BLL.Services;
using MIEDU.Models.Entities;

namespace MIEDU.UI.UserControls
{
    public partial class ucThongKe : UserControl
    {
        private readonly ThongKeBLL _thongKeBLL;
        private List<ThongKeHocVi> _listHocVi = new List<ThongKeHocVi>();

        public ucThongKe()
        {
            InitializeComponent();
            _thongKeBLL = new ThongKeBLL();

            // Kích hoạt DoubleBuffering cho panel vẽ biểu đồ để chống hiện tượng chớp/nháy hình khi tải lại
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                null, pnlChart, new object[] { true });
        }

        private void ucThongKe_Load(object sender, EventArgs e)
        {
            LoadThongKe();
        }

        private void LoadThongKe()
        {
            try
            {
                // 1. Load dữ liệu thẻ (Cards)
                var tongQuan = _thongKeBLL.GetTongQuan();
                lblCountGV.Text = tongQuan.TongGiangVien.ToString("N0");
                lblCountCV.Text = tongQuan.TongChuyenVien.ToString("N0");
                lblCountMon.Text = tongQuan.TongMonHoc.ToString("N0");
                lblCountPC.Text = tongQuan.TongPhanCong.ToString("N0");

                // 2. Load dữ liệu cho biểu đồ và yêu cầu vẽ lại Panel
                _listHocVi = _thongKeBLL.GetThongKeHocVi();
                pnlChart.Invalidate();

                // 3. Load danh sách Top Giảng Viên
                dgvTopGV.DataSource = _thongKeBLL.GetTopGiangVien();
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGrid()
        {
            if (dgvTopGV.Columns["MaGV"] != null) dgvTopGV.Columns["MaGV"].HeaderText = "Mã GV";
            if (dgvTopGV.Columns["HoTen"] != null) dgvTopGV.Columns["HoTen"].HeaderText = "Họ Tên";
            if (dgvTopGV.Columns["TongTinChi"] != null) dgvTopGV.Columns["TongTinChi"].HeaderText = "Tổng Tín Chỉ";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadThongKe();
        }

        // Kỹ thuật GDI+: Tự động vẽ Biểu đồ Tròn (Pie Chart) trực tiếp lên Panel
        private void pnlChart_Paint(object sender, PaintEventArgs e)
        {
            // Bật chế độ khử răng cưa để đường cong tròn trịa, mượt mà hơn
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (_listHocVi == null || _listHocVi.Count == 0)
            {
                e.Graphics.DrawString("Chưa có dữ liệu để vẽ biểu đồ", new Font("Segoe UI", 12, FontStyle.Italic), Brushes.Gray, 50, 100);
                return;
            }

            int total = _listHocVi.Sum(x => x.SoLuong);
            if (total == 0) return;

            // Kích thước và tọa độ của hình tròn biểu đồ
            Rectangle rect = new Rectangle(10, 10, 200, 200);
            float startAngle = 0;

            // Khai báo bảng màu sắc hiện đại cho các múi của biểu đồ
            Color[] colors = {
                Color.FromArgb(0, 122, 204),   // Xanh dương
                Color.FromArgb(40, 167, 69),   // Xanh lá
                Color.FromArgb(255, 193, 7),   // Vàng
                Color.FromArgb(220, 53, 69),   // Đỏ
                Color.FromArgb(111, 66, 193),  // Tím
                Color.FromArgb(23, 162, 184)   // Xanh ngọc
            };

            int colorIndex = 0;
            int legendY = 20;  // Tọa độ Y của phần chú thích
            int legendX = 240; // Tọa độ X của phần chú thích

            foreach (var item in _listHocVi)
            {
                // Tính toán góc của múi (dựa trên tỉ lệ phần trăm)
                float sweepAngle = (float)item.SoLuong / total * 360f;

                using (Brush brush = new SolidBrush(colors[colorIndex % colors.Length]))
                {
                    // Vẽ múi của biểu đồ tròn
                    e.Graphics.FillPie(brush, rect, startAngle, sweepAngle);

                    // Vẽ ô màu chú thích hình vuông nhỏ
                    e.Graphics.FillRectangle(brush, legendX, legendY, 16, 16);

                    // Vẽ chữ hiển thị phần trăm
                    float percentage = (float)item.SoLuong / total * 100;
                    e.Graphics.DrawString($"{item.HocVi}: {item.SoLuong} ({percentage:F1}%)",
                        new Font("Segoe UI", 10), Brushes.Black, legendX + 25, legendY - 2);
                }

                startAngle += sweepAngle;
                legendY += 30; // Đẩy chữ tiếp theo xuống dòng
                colorIndex++;
            }
        }
    }
}