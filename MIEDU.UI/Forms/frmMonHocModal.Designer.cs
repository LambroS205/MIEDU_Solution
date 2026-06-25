namespace MIEDU.UI.Forms
{
    partial class frmMonHocModal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaMon;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label lblSoTinChi;
        private System.Windows.Forms.NumericUpDown numSoTinChi;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMaMon = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.lblSoTinChi = new System.Windows.Forms.Label();
            this.numSoTinChi = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTinChi)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(242, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÊM MỚI MÔN HỌC";

            // lblMaMon
            this.lblMaMon.AutoSize = true;
            this.lblMaMon.Location = new System.Drawing.Point(20, 80);
            this.lblMaMon.Name = "lblMaMon";
            this.lblMaMon.Text = "Mã môn học:";

            // txtMaMon
            this.txtMaMon.Location = new System.Drawing.Point(120, 77);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(200, 23);

            // lblTenMon
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Location = new System.Drawing.Point(20, 120);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Text = "Tên môn học:";

            // txtTenMon
            this.txtTenMon.Location = new System.Drawing.Point(120, 117);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(200, 23);

            // lblSoTinChi
            this.lblSoTinChi.AutoSize = true;
            this.lblSoTinChi.Location = new System.Drawing.Point(20, 160);
            this.lblSoTinChi.Name = "lblSoTinChi";
            this.lblSoTinChi.Text = "Số tín chỉ:";

            // numSoTinChi
            this.numSoTinChi.Location = new System.Drawing.Point(120, 157);
            this.numSoTinChi.Minimum = 1;
            this.numSoTinChi.Maximum = 10;
            this.numSoTinChi.Name = "numSoTinChi";
            this.numSoTinChi.Size = new System.Drawing.Size(60, 23);
            this.numSoTinChi.Value = 3;

            // btnSave
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(120, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.Text = "Lưu lại";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(230, 210);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // frmMonHocModal
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 270);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numSoTinChi);
            this.Controls.Add(this.lblSoTinChi);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.lblTenMon);
            this.Controls.Add(this.txtMaMon);
            this.Controls.Add(this.lblMaMon);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin Môn Học";
            this.Load += new System.EventHandler(this.frmMonHocModal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSoTinChi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}