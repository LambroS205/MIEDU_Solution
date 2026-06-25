namespace MIEDU.UI.UserControls
{
    partial class ucThongTinCaNhan
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox gbProfile;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblMaNhanSu;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnSaveProfile;

        private System.Windows.Forms.GroupBox gbPassword;
        private System.Windows.Forms.Label lblOldPass;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Button btnChangePassword;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.gbProfile = new System.Windows.Forms.GroupBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblMaNhanSu = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnSaveProfile = new System.Windows.Forms.Button();

            this.gbPassword = new System.Windows.Forms.GroupBox();
            this.lblOldPass = new System.Windows.Forms.Label();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();

            this.gbProfile.SuspendLayout();
            this.gbPassword.SuspendLayout();
            this.SuspendLayout();

            // lblHeader
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblHeader.Location = new System.Drawing.Point(20, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(264, 30);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "THÔNG TIN TÀI KHOẢN";

            // gbProfile
            this.gbProfile.Controls.Add(this.lblUsername);
            this.gbProfile.Controls.Add(this.lblRole);
            this.gbProfile.Controls.Add(this.lblMaNhanSu);
            this.gbProfile.Controls.Add(this.lblHoTen);
            this.gbProfile.Controls.Add(this.lblKhoa);
            this.gbProfile.Controls.Add(this.lblEmail);
            this.gbProfile.Controls.Add(this.txtEmail);
            this.gbProfile.Controls.Add(this.lblSDT);
            this.gbProfile.Controls.Add(this.txtSDT);
            this.gbProfile.Controls.Add(this.btnSaveProfile);
            this.gbProfile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbProfile.Location = new System.Drawing.Point(25, 70);
            this.gbProfile.Name = "gbProfile";
            this.gbProfile.Size = new System.Drawing.Size(350, 360);
            this.gbProfile.TabIndex = 1;
            this.gbProfile.TabStop = false;
            this.gbProfile.Text = "Hồ sơ cá nhân";

            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(20, 40);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Text = "Tài khoản: -";

            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(20, 70);
            this.lblRole.Name = "lblRole";
            this.lblRole.Text = "Vai trò: -";

            this.lblMaNhanSu.AutoSize = true;
            this.lblMaNhanSu.Location = new System.Drawing.Point(20, 100);
            this.lblMaNhanSu.Name = "lblMaNhanSu";
            this.lblMaNhanSu.Text = "Mã nhân sự: -";

            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(20, 130);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Text = "Họ tên: -";

            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(20, 160);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Text = "Trực thuộc: -";

            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 200);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Text = "Email liên hệ:";

            this.txtEmail.Location = new System.Drawing.Point(20, 220);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 25);

            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(20, 260);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Text = "Số điện thoại:";

            this.txtSDT.Location = new System.Drawing.Point(20, 280);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(300, 25);

            this.btnSaveProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSaveProfile.FlatAppearance.BorderSize = 0;
            this.btnSaveProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProfile.ForeColor = System.Drawing.Color.White;
            this.btnSaveProfile.Location = new System.Drawing.Point(20, 315);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(120, 30);
            this.btnSaveProfile.Text = "Lưu thông tin";
            this.btnSaveProfile.UseVisualStyleBackColor = false;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);

            // gbPassword
            this.gbPassword.Controls.Add(this.lblOldPass);
            this.gbPassword.Controls.Add(this.txtOldPass);
            this.gbPassword.Controls.Add(this.lblNewPass);
            this.gbPassword.Controls.Add(this.txtNewPass);
            this.gbPassword.Controls.Add(this.lblConfirmPass);
            this.gbPassword.Controls.Add(this.txtConfirmPass);
            this.gbPassword.Controls.Add(this.btnChangePassword);
            this.gbPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbPassword.Location = new System.Drawing.Point(395, 70);
            this.gbPassword.Name = "gbPassword";
            this.gbPassword.Size = new System.Drawing.Size(350, 360);
            this.gbPassword.TabIndex = 2;
            this.gbPassword.TabStop = false;
            this.gbPassword.Text = "Đổi mật khẩu";

            this.lblOldPass.AutoSize = true;
            this.lblOldPass.Location = new System.Drawing.Point(20, 40);
            this.lblOldPass.Name = "lblOldPass";
            this.lblOldPass.Text = "Mật khẩu hiện tại:";

            this.txtOldPass.Location = new System.Drawing.Point(20, 65);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '*';
            this.txtOldPass.Size = new System.Drawing.Size(300, 25);

            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Location = new System.Drawing.Point(20, 105);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Text = "Mật khẩu mới:";

            this.txtNewPass.Location = new System.Drawing.Point(20, 130);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(300, 25);

            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Location = new System.Drawing.Point(20, 170);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Text = "Xác nhận mật khẩu mới:";

            this.txtConfirmPass.Location = new System.Drawing.Point(20, 195);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.Size = new System.Drawing.Size(300, 25);

            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.ForeColor = System.Drawing.Color.Black;
            this.btnChangePassword.Location = new System.Drawing.Point(20, 240);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(120, 30);
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);

            // ucThongTinCaNhan
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbPassword);
            this.Controls.Add(this.gbProfile);
            this.Controls.Add(this.lblHeader);
            this.Name = "ucThongTinCaNhan";
            this.Size = new System.Drawing.Size(780, 600);
            this.Load += new System.EventHandler(this.ucThongTinCaNhan_Load);

            this.gbProfile.ResumeLayout(false);
            this.gbProfile.PerformLayout();
            this.gbPassword.ResumeLayout(false);
            this.gbPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}