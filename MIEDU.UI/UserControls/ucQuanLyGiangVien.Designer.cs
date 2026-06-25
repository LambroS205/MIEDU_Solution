namespace MIEDU.UI.UserControls
{
    partial class ucQuanLyGiangVien
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dgvGiangVien;
        private System.Windows.Forms.Panel pnlTop;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnExport = new Button();
            dgvGiangVien = new DataGridView();
            pnlTop = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvGiangVien).BeginInit();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(50, 50, 50);
            lblTitle.Location = new Point(3, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(296, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ GIẢNG VIÊN";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Location = new Point(297, 37);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập tên hoặc mã...";
            txtSearch.Size = new Size(182, 32);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 122, 204);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(491, 36);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(74, 40);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Gray;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(577, 36);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(69, 40);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Tải lại";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(40, 167, 69);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(657, 36);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(69, 40);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "+ Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(255, 193, 7);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(737, 36);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(63, 40);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(710, 27);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(55, 30);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(40, 167, 69);
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(806, 37);
            btnExport.Margin = new Padding(3, 4, 3, 4);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(63, 40);
            btnExport.TabIndex = 8;
            btnExport.Text = "📥 Xuất Excel";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // dgvGiangVien
            // 
            dgvGiangVien.AllowUserToAddRows = false;
            dgvGiangVien.AllowUserToDeleteRows = false;
            dgvGiangVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGiangVien.BackgroundColor = Color.White;
            dgvGiangVien.BorderStyle = BorderStyle.None;
            dgvGiangVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGiangVien.Dock = DockStyle.Fill;
            dgvGiangVien.Location = new Point(0, 107);
            dgvGiangVien.Margin = new Padding(3, 4, 3, 4);
            dgvGiangVien.Name = "dgvGiangVien";
            dgvGiangVien.ReadOnly = true;
            dgvGiangVien.RowHeadersVisible = false;
            dgvGiangVien.RowHeadersWidth = 51;
            dgvGiangVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGiangVien.Size = new Size(891, 693);
            dgvGiangVien.TabIndex = 1;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Controls.Add(txtSearch);
            pnlTop.Controls.Add(btnSearch);
            pnlTop.Controls.Add(btnRefresh);
            pnlTop.Controls.Add(btnEdit);
            pnlTop.Controls.Add(btnAdd);
            pnlTop.Controls.Add(btnExport);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(3, 4, 3, 4);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(891, 107);
            pnlTop.TabIndex = 0;
            // 
            // ucQuanLyGiangVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgvGiangVien);
            Controls.Add(pnlTop);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ucQuanLyGiangVien";
            Size = new Size(891, 800);
            Load += ucQuanLyGiangVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGiangVien).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
        }
    }
}