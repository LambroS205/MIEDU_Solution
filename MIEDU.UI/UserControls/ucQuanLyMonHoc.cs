using System;
using System.Windows.Forms;
using MIEDU.BLL.Services;
using MIEDU.Models.Entities;
using MIEDU.UI.Forms;

namespace MIEDU.UI.UserControls
{
    public partial class ucQuanLyMonHoc : UserControl
    {
        private MonHocBLL _monHocBLL;

        public ucQuanLyMonHoc()
        {
            InitializeComponent();
            _monHocBLL = new MonHocBLL();
        }

        private void ucQuanLyMonHoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvMonHoc.DataSource = _monHocBLL.GetAll();
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGrid()
        {
            if (dgvMonHoc.Columns["MaMon"] != null) dgvMonHoc.Columns["MaMon"].HeaderText = "Mã Môn Học";
            if (dgvMonHoc.Columns["TenMon"] != null) dgvMonHoc.Columns["TenMon"].HeaderText = "Tên Môn Học";
            if (dgvMonHoc.Columns["SoTinChi"] != null) dgvMonHoc.Columns["SoTinChi"].HeaderText = "Số Tín Chỉ";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtSearch.Text.Trim();
                dgvMonHoc.DataSource = _monHocBLL.Search(keyword);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new frmMonHocModal();
            frm.ShowDialog();
            if (frm.IsSaved) LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMonHoc.CurrentRow != null)
            {
                var mh = (MonHoc)dgvMonHoc.CurrentRow.DataBoundItem;
                var frm = new frmMonHocModal(mh);
                frm.ShowDialog();
                if (frm.IsSaved) LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMonHoc.CurrentRow != null)
            {
                var mh = (MonHoc)dgvMonHoc.CurrentRow.DataBoundItem;
                if (MessageBox.Show($"Bạn có chắc muốn xóa môn {mh.TenMon}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        _monHocBLL.Delete(mh.MaMon);
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể xóa môn học này vì đã có dữ liệu phân công liên quan.\nChi tiết: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}