namespace MIEDU.UI.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnQuanLyGV;
        private System.Windows.Forms.Button btnPhanCong;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Label lblLogo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnQuanLyGV = new System.Windows.Forms.Button();
            this.btnPhanCong = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();

            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();

            // pnlSidebar
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.pnlSidebar.Controls.Add(this.lblUserInfo);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnPhanCong);
            this.pnlSidebar.Controls.Add(this.btnQuanLyGV);
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 600);
            this.pnlSidebar.TabIndex = 0;

            // lblLogo
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.lblLogo.Location = new System.Drawing.Point(0, 20);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(220, 40);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "MIEDU";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblUserInfo
            this.lblUserInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblUserInfo.Location = new System.Drawing.Point(0, 60);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(220, 40);
            this.lblUserInfo.TabIndex = 1;
            this.lblUserInfo.Text = "Xin chào, ...";
            this.lblUserInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // btnQuanLyGV
            this.btnQuanLyGV.FlatAppearance.BorderSize = 0;
            this.btnQuanLyGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyGV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuanLyGV.Location = new System.Drawing.Point(0, 120);
            this.btnQuanLyGV.Name = "btnQuanLyGV";
            this.btnQuanLyGV.Size = new System.Drawing.Size(220, 50);
            this.btnQuanLyGV.TabIndex = 2;
            this.btnQuanLyGV.Text = "📚 Quản lý Giảng viên";
            this.btnQuanLyGV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyGV.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnQuanLyGV.UseVisualStyleBackColor = true;
            this.btnQuanLyGV.Click += new System.EventHandler(this.btnQuanLyGV_Click);

            // btnPhanCong
            this.btnPhanCong.FlatAppearance.BorderSize = 0;
            this.btnPhanCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhanCong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPhanCong.Location = new System.Drawing.Point(0, 170);
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Size = new System.Drawing.Size(220, 50);
            this.btnPhanCong.TabIndex = 3;
            this.btnPhanCong.Text = "📅 Phân công giảng dạy";
            this.btnPhanCong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhanCong.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnPhanCong.UseVisualStyleBackColor = true;
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);

            // btnLogout
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.IndianRed;
            this.btnLogout.Location = new System.Drawing.Point(0, 540);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(220, 50);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // pnlContent
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(220, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(780, 600);
            this.pnlContent.TabIndex = 1;

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản lý Giảng viên MIEDU";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}