namespace MIEDU.UI.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnThongTinCaNhan = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnPhanCong = new System.Windows.Forms.Button();
            this.btnQuanLyGV = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.pnlSidebar.Controls.Add(this.btnThongTinCaNhan);
            this.pnlSidebar.Controls.Add(this.btnThongKe);
            this.pnlSidebar.Controls.Add(this.btnPhanCong);
            this.pnlSidebar.Controls.Add(this.btnQuanLyGV);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.lblUserInfo);
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(250, 681);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnThongTinCaNhan
            // 
            this.btnThongTinCaNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongTinCaNhan.FlatAppearance.BorderSize = 0;
            this.btnThongTinCaNhan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnThongTinCaNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTinCaNhan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThongTinCaNhan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnThongTinCaNhan.Location = new System.Drawing.Point(0, 300);
            this.btnThongTinCaNhan.Name = "btnThongTinCaNhan";
            this.btnThongTinCaNhan.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnThongTinCaNhan.Size = new System.Drawing.Size(250, 50);
            this.btnThongTinCaNhan.TabIndex = 6;
            this.btnThongTinCaNhan.Text = "👤 Tài khoản cá nhân";
            this.btnThongTinCaNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongTinCaNhan.UseVisualStyleBackColor = true;
            this.btnThongTinCaNhan.Click += new System.EventHandler(this.btnThongTinCaNhan_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThongKe.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnThongKe.Location = new System.Drawing.Point(0, 250);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(250, 50);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "📊 Báo cáo Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhanCong.FlatAppearance.BorderSize = 0;
            this.btnPhanCong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnPhanCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhanCong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPhanCong.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPhanCong.Location = new System.Drawing.Point(0, 200);
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPhanCong.Size = new System.Drawing.Size(250, 50);
            this.btnPhanCong.TabIndex = 4;
            this.btnPhanCong.Text = "📅 Phân công Giảng dạy";
            this.btnPhanCong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhanCong.UseVisualStyleBackColor = true;
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);
            // 
            // btnQuanLyGV
            // 
            this.btnQuanLyGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyGV.FlatAppearance.BorderSize = 0;
            this.btnQuanLyGV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnQuanLyGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyGV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuanLyGV.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuanLyGV.Location = new System.Drawing.Point(0, 150);
            this.btnQuanLyGV.Name = "btnQuanLyGV";
            this.btnQuanLyGV.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnQuanLyGV.Size = new System.Drawing.Size(250, 50);
            this.btnQuanLyGV.TabIndex = 3;
            this.btnQuanLyGV.Text = "👨‍🏫 Quản lý Giảng viên";
            this.btnQuanLyGV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyGV.UseVisualStyleBackColor = true;
            this.btnQuanLyGV.Click += new System.EventHandler(this.btnQuanLyGV_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.Location = new System.Drawing.Point(0, 631);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(250, 50);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "🚪 Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserInfo.ForeColor = System.Drawing.Color.Silver;
            this.lblUserInfo.Location = new System.Drawing.Point(0, 80);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(250, 50);
            this.lblUserInfo.TabIndex = 1;
            this.lblUserInfo.Text = "Xin chào, User\nVai trò: Unknown";
            this.lblUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogo
            // 
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(250, 80);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "MIEDU";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(250, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1014, 681);
            this.pnlContent.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản lý Giảng viên MIEDU";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnQuanLyGV;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnPhanCong;
        private System.Windows.Forms.Button btnThongTinCaNhan;
    }
}