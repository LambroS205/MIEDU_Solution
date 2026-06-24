namespace MIEDU.UI.Forms
{
    partial class frmEditGiangVien
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1, label2, label3, label4, label5, label6, label7, label8, label9, label10;
        private System.Windows.Forms.TextBox txtMaGV, txtHoTen, txtSDT, txtEmail, txtChucDanh;
        private System.Windows.Forms.ComboBox cbGioiTinh, cbKhoa, cbHocVi;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.NumericUpDown numSoGioChuan;
        private System.Windows.Forms.Button btnSave, btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            label1 = new Label();
            txtMaGV = new TextBox();
            label2 = new Label();
            txtHoTen = new TextBox();
            label3 = new Label();
            dtpNgaySinh = new DateTimePicker();
            label4 = new Label();
            cbGioiTinh = new ComboBox();
            label5 = new Label();
            txtSDT = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            cbKhoa = new ComboBox();
            label8 = new Label();
            cbHocVi = new ComboBox();
            label9 = new Label();
            txtChucDanh = new TextBox();
            label10 = new Label();
            numSoGioChuan = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numSoGioChuan).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(330, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "THÔNG TIN GIẢNG VIÊN";
            // 
            // label1
            // 
            label1.Location = new Point(30, 80);
            label1.Name = "label1";
            label1.Size = new Size(84, 23);
            label1.TabIndex = 1;
            label1.Text = "Mã GV (*):";
            // 
            // txtMaGV
            // 
            txtMaGV.Location = new Point(120, 77);
            txtMaGV.Name = "txtMaGV";
            txtMaGV.Size = new Size(180, 27);
            txtMaGV.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(30, 120);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 3;
            label2.Text = "Họ Tên (*):";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(120, 117);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(180, 27);
            txtHoTen.TabIndex = 4;
            // 
            // label3
            // 
            label3.Location = new Point(30, 160);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 5;
            label3.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(120, 157);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(180, 27);
            dtpNgaySinh.TabIndex = 6;
            // 
            // label4
            // 
            label4.Location = new Point(30, 200);
            label4.Name = "label4";
            label4.Size = new Size(84, 23);
            label4.TabIndex = 7;
            label4.Text = "Giới tính:";
            // 
            // cbGioiTinh
            // 
            cbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGioiTinh.Location = new Point(120, 197);
            cbGioiTinh.Name = "cbGioiTinh";
            cbGioiTinh.Size = new Size(180, 28);
            cbGioiTinh.TabIndex = 8;
            // 
            // label5
            // 
            label5.Location = new Point(30, 240);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 9;
            label5.Text = "Số ĐT (*):";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(120, 237);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(180, 27);
            txtSDT.TabIndex = 10;
            // 
            // label6
            // 
            label6.Location = new Point(330, 80);
            label6.Name = "label6";
            label6.Size = new Size(74, 23);
            label6.TabIndex = 11;
            label6.Text = "Email (*):";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(410, 77);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(180, 27);
            txtEmail.TabIndex = 12;
            // 
            // label7
            // 
            label7.Location = new Point(330, 120);
            label7.Name = "label7";
            label7.Size = new Size(74, 23);
            label7.TabIndex = 13;
            label7.Text = "Khoa:";
            // 
            // cbKhoa
            // 
            cbKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKhoa.Location = new Point(410, 117);
            cbKhoa.Name = "cbKhoa";
            cbKhoa.Size = new Size(180, 28);
            cbKhoa.TabIndex = 14;
            // 
            // label8
            // 
            label8.Location = new Point(330, 160);
            label8.Name = "label8";
            label8.Size = new Size(74, 23);
            label8.TabIndex = 15;
            label8.Text = "Học vị:";
            // 
            // cbHocVi
            // 
            cbHocVi.Location = new Point(410, 157);
            cbHocVi.Name = "cbHocVi";
            cbHocVi.Size = new Size(180, 28);
            cbHocVi.TabIndex = 16;
            // 
            // label9
            // 
            label9.Location = new Point(330, 200);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 17;
            label9.Text = "Chức danh:";
            // 
            // txtChucDanh
            // 
            txtChucDanh.Location = new Point(410, 197);
            txtChucDanh.Name = "txtChucDanh";
            txtChucDanh.Size = new Size(180, 27);
            txtChucDanh.TabIndex = 18;
            // 
            // label10
            // 
            label10.Location = new Point(330, 240);
            label10.Name = "label10";
            label10.Size = new Size(82, 23);
            label10.TabIndex = 19;
            label10.Text = "Giờ chuẩn:";
            // 
            // numSoGioChuan
            // 
            numSoGioChuan.Location = new Point(418, 236);
            numSoGioChuan.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoGioChuan.Name = "numSoGioChuan";
            numSoGioChuan.Size = new Size(80, 27);
            numSoGioChuan.TabIndex = 20;
            numSoGioChuan.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 122, 204);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(360, 300);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 35);
            btnSave.TabIndex = 21;
            btnSave.Text = "💾 Lưu Lại";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(480, 300);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "❌ Hủy Bỏ";
            btnCancel.Click += btnCancel_Click;
            // 
            // frmEditGiangVien
            // 
            ClientSize = new Size(630, 370);
            Controls.Add(txtChucDanh);
            Controls.Add(lblTitle);
            Controls.Add(label1);
            Controls.Add(txtMaGV);
            Controls.Add(label2);
            Controls.Add(txtHoTen);
            Controls.Add(label3);
            Controls.Add(dtpNgaySinh);
            Controls.Add(label4);
            Controls.Add(cbGioiTinh);
            Controls.Add(label5);
            Controls.Add(txtSDT);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(cbKhoa);
            Controls.Add(label8);
            Controls.Add(cbHocVi);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(numSoGioChuan);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEditGiangVien";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chỉnh Sửa Giảng Viên";
            Load += frmEditGiangVien_Load;
            ((System.ComponentModel.ISupportInitialize)numSoGioChuan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}