namespace MIEDU.UI.UserControls
{
    partial class ucPhanCong
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGV;
        private System.Windows.Forms.ComboBox cbGiangVien;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.NumericUpDown numHocKy;
        private System.Windows.Forms.Label lblNamHoc;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnDelete; // Khai báo thêm nút Delete
        private System.Windows.Forms.DataGridView dgvPhanCong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGV = new System.Windows.Forms.Label();
            this.cbGiangVien = new System.Windows.Forms.ComboBox();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.numHocKy = new System.Windows.Forms.NumericUpDown();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button(); // Khởi tạo
            this.dgvPhanCong = new System.Windows.Forms.DataGridView();

            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHocKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).BeginInit();
            this.SuspendLayout();

            // pnlTop
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.lblGV);
            this.pnlTop.Controls.Add(this.cbGiangVien);
            this.pnlTop.Controls.Add(this.lblMonHoc);
            this.pnlTop.Controls.Add(this.cbMonHoc);
            this.pnlTop.Controls.Add(this.lblHocKy);
            this.pnlTop.Controls.Add(this.numHocKy);
            this.pnlTop.Controls.Add(this.lblNamHoc);
            this.pnlTop.Controls.Add(this.txtNamHoc);
            this.pnlTop.Controls.Add(this.btnAssign);
            this.pnlTop.Controls.Add(this.btnDelete); // Thêm vào Panel
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(780, 150);
            this.pnlTop.TabIndex = 0;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PHÂN CÔNG GIẢNG DẠY";

            // lblGV
            this.lblGV.AutoSize = true;
            this.lblGV.Location = new System.Drawing.Point(20, 70);
            this.lblGV.Name = "lblGV";
            this.lblGV.Text = "Giảng viên:";

            // cbGiangVien
            this.cbGiangVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGiangVien.FormattingEnabled = true;
            this.cbGiangVien.Location = new System.Drawing.Point(90, 67);
            this.cbGiangVien.Name = "cbGiangVien";
            this.cbGiangVien.Size = new System.Drawing.Size(200, 23);

            // lblMonHoc
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Location = new System.Drawing.Point(310, 70);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Text = "Môn học:";

            // cbMonHoc
            this.cbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(375, 67);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(200, 23);

            // lblHocKy
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Location = new System.Drawing.Point(20, 110);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Text = "Học kỳ:";

            // numHocKy
            this.numHocKy.Location = new System.Drawing.Point(90, 107);
            this.numHocKy.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            this.numHocKy.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numHocKy.Name = "numHocKy";
            this.numHocKy.Size = new System.Drawing.Size(60, 23);
            this.numHocKy.Value = new decimal(new int[] { 1, 0, 0, 0 });

            // lblNamHoc
            this.lblNamHoc.AutoSize = true;
            this.lblNamHoc.Location = new System.Drawing.Point(170, 110);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Text = "Năm học:";

            // txtNamHoc
            this.txtNamHoc.Location = new System.Drawing.Point(230, 107);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(100, 23);
            this.txtNamHoc.Text = "2025-2026";

            // btnAssign
            this.btnAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAssign.FlatAppearance.BorderSize = 0;
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.ForeColor = System.Drawing.Color.White;
            this.btnAssign.Location = new System.Drawing.Point(375, 104);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(100, 28);
            this.btnAssign.TabIndex = 3;
            this.btnAssign.Text = "+ Phân công";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);

            // btnDelete
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(485, 104);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 28);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "🗑️ Hủy phân công";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // dgvPhanCong
            this.dgvPhanCong.AllowUserToAddRows = false;
            this.dgvPhanCong.AllowUserToDeleteRows = false;
            this.dgvPhanCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhanCong.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhanCong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhanCong.Location = new System.Drawing.Point(0, 150);
            this.dgvPhanCong.Name = "dgvPhanCong";
            this.dgvPhanCong.ReadOnly = true;
            this.dgvPhanCong.RowHeadersVisible = false;
            this.dgvPhanCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhanCong.Size = new System.Drawing.Size(780, 450);

            // ucPhanCong
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvPhanCong);
            this.Controls.Add(this.pnlTop);
            this.Name = "ucPhanCong";
            this.Size = new System.Drawing.Size(780, 600);
            this.Load += new System.EventHandler(this.ucPhanCong_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHocKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).EndInit();
            this.ResumeLayout(false);
        }
    }
}