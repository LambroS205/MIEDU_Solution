using System;
using System.Windows.Forms;
using MIEDU.Models.Entities;
using MIEDU.BLL.Services;

namespace MIEDU.UI.Forms
{
    public partial class frmMonHocModal : Form
    {
        private MonHoc _monHoc;
        private MonHocBLL _monHocBLL;
        public bool IsSaved { get; private set; } = false;

        public frmMonHocModal(MonHoc mh = null)
        {
            InitializeComponent();
            _monHoc = mh;
            _monHocBLL = new MonHocBLL();
        }

        private void frmMonHocModal_Load(object sender, EventArgs e)
        {
            if (_monHoc != null)
            {
                lblTitle.Text = "CẬP NHẬT MÔN HỌC";
                txtMaMon.Text = _monHoc.MaMon;
                txtMaMon.Enabled = false; // Không cho sửa mã khi Update
                txtTenMon.Text = _monHoc.TenMon;
                numSoTinChi.Value = _monHoc.SoTinChi;
            }
            else
            {
                lblTitle.Text = "THÊM MỚI MÔN HỌC";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var mh = new MonHoc
                {
                    MaMon = txtMaMon.Text.Trim(),
                    TenMon = txtTenMon.Text.Trim(),
                    SoTinChi = (int)numSoTinChi.Value
                };

                if (_monHoc == null) // Chế độ Thêm mới
                {
                    _monHocBLL.Add(mh);
                    MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // Chế độ Cập nhật
                {
                    _monHocBLL.Update(mh);
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                IsSaved = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}