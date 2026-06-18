namespace MIEDU.UI.UserControls
{
    partial class ucThongKe
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlCardGV;
        private System.Windows.Forms.Label lblTitleGV;
        private System.Windows.Forms.Label lblCountGV;
        private System.Windows.Forms.Panel pnlCardCV;
        private System.Windows.Forms.Label lblTitleCV;
        private System.Windows.Forms.Label lblCountCV;
        private System.Windows.Forms.Panel pnlCardMon;
        private System.Windows.Forms.Label lblTitleMon;
        private System.Windows.Forms.Label lblCountMon;
        private System.Windows.Forms.Panel pnlCardPC;
        private System.Windows.Forms.Label lblTitlePC;
        private System.Windows.Forms.Label lblCountPC;
        private System.Windows.Forms.DataGridView dgvHocVi;
        private System.Windows.Forms.Label lblHocViTitle;
        private System.Windows.Forms.Button btnRefresh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlCardGV = new System.Windows.Forms.Panel();
            this.lblTitleGV = new System.Windows.Forms.Label();
            this.lblCountGV = new System.Windows.Forms.Label();
            this.pnlCardCV = new System.Windows.Forms.Panel();
            this.lblTitleCV = new System.Windows.Forms.Label();
            this.lblCountCV = new System.Windows.Forms.Label();
            this.pnlCardMon = new System.Windows.Forms.Panel();
            this.lblTitleMon = new System.Windows.Forms.Label();
            this.lblCountMon = new System.Windows.Forms.Label();
            this.pnlCardPC = new System.Windows.Forms.Panel();
            this.lblTitlePC = new System.Windows.Forms.Label();
            this.lblCountPC = new System.Windows.Forms.Label();
            this.dgvHocVi = new System.Windows.Forms.DataGridView();
            this.lblHocViTitle = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();

            this.pnlCardGV.SuspendLayout();
            this.pnlCardCV.SuspendLayout();
            this.pnlCardMon.SuspendLayout();
            this.pnlCardPC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocVi)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(262, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BÁO CÁO THỐNG KÊ";

            // btnRefresh
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(640, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 30);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // pnlCardGV
            this.pnlCardGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184))))); // Info Blue
            this.pnlCardGV.Controls.Add(this.lblCountGV);
            this.pnlCardGV.Controls.Add(this.lblTitleGV);
            this.pnlCardGV.Location = new System.Drawing.Point(25, 70);
            this.pnlCardGV.Name = "pnlCardGV";
            this.pnlCardGV.Size = new System.Drawing.Size(160, 100);

            this.lblTitleGV.AutoSize = true;
            this.lblTitleGV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleGV.ForeColor = System.Drawing.Color.White;
            this.lblTitleGV.Location = new System.Drawing.Point(10, 15);
            this.lblTitleGV.Text = "TỔNG GIẢNG VIÊN";

            this.lblCountGV.AutoSize = true;
            this.lblCountGV.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountGV.ForeColor = System.Drawing.Color.White;
            this.lblCountGV.Location = new System.Drawing.Point(10, 40);
            this.lblCountGV.Text = "0";

            // pnlCardCV
            this.pnlCardCV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69))))); // Success Green
            this.pnlCardCV.Controls.Add(this.lblCountCV);
            this.pnlCardCV.Controls.Add(this.lblTitleCV);
            this.pnlCardCV.Location = new System.Drawing.Point(205, 70);
            this.pnlCardCV.Name = "pnlCardCV";
            this.pnlCardCV.Size = new System.Drawing.Size(160, 100);

            this.lblTitleCV.AutoSize = true;
            this.lblTitleCV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleCV.ForeColor = System.Drawing.Color.White;
            this.lblTitleCV.Location = new System.Drawing.Point(10, 15);
            this.lblTitleCV.Text = "CHUYÊN VIÊN";

            this.lblCountCV.AutoSize = true;
            this.lblCountCV.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountCV.ForeColor = System.Drawing.Color.White;
            this.lblCountCV.Location = new System.Drawing.Point(10, 40);
            this.lblCountCV.Text = "0";

            // pnlCardMon
            this.pnlCardMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7))))); // Warning Yellow
            this.pnlCardMon.Controls.Add(this.lblCountMon);
            this.pnlCardMon.Controls.Add(this.lblTitleMon);
            this.pnlCardMon.Location = new System.Drawing.Point(385, 70);
            this.pnlCardMon.Name = "pnlCardMon";
            this.pnlCardMon.Size = new System.Drawing.Size(160, 100);

            this.lblTitleMon.AutoSize = true;
            this.lblTitleMon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleMon.ForeColor = System.Drawing.Color.White;
            this.lblTitleMon.Location = new System.Drawing.Point(10, 15);
            this.lblTitleMon.Text = "TỔNG MÔN HỌC";

            this.lblCountMon.AutoSize = true;
            this.lblCountMon.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountMon.ForeColor = System.Drawing.Color.White;
            this.lblCountMon.Location = new System.Drawing.Point(10, 40);
            this.lblCountMon.Text = "0";

            // pnlCardPC
            this.pnlCardPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69))))); // Danger Red
            this.pnlCardPC.Controls.Add(this.lblCountPC);
            this.pnlCardPC.Controls.Add(this.lblTitlePC);
            this.pnlCardPC.Location = new System.Drawing.Point(565, 70);
            this.pnlCardPC.Name = "pnlCardPC";
            this.pnlCardPC.Size = new System.Drawing.Size(185, 100);

            this.lblTitlePC.AutoSize = true;
            this.lblTitlePC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitlePC.ForeColor = System.Drawing.Color.White;
            this.lblTitlePC.Location = new System.Drawing.Point(10, 15);
            this.lblTitlePC.Text = "TỔNG LƯỢT PHÂN CÔNG";

            this.lblCountPC.AutoSize = true;
            this.lblCountPC.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountPC.ForeColor = System.Drawing.Color.White;
            this.lblCountPC.Location = new System.Drawing.Point(10, 40);
            this.lblCountPC.Text = "0";

            // lblHocViTitle
            this.lblHocViTitle.AutoSize = true;
            this.lblHocViTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHocViTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblHocViTitle.Location = new System.Drawing.Point(20, 200);
            this.lblHocViTitle.Text = "Tỉ lệ giảng viên theo Học Vị";

            // dgvHocVi
            this.dgvHocVi.AllowUserToAddRows = false;
            this.dgvHocVi.AllowUserToDeleteRows = false;
            this.dgvHocVi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocVi.BackgroundColor = System.Drawing.Color.White;
            this.dgvHocVi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHocVi.Location = new System.Drawing.Point(25, 235);
            this.dgvHocVi.Name = "dgvHocVi";
            this.dgvHocVi.ReadOnly = true;
            this.dgvHocVi.RowHeadersVisible = false;
            this.dgvHocVi.Size = new System.Drawing.Size(725, 300);

            // ucThongKe
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblHocViTitle);
            this.Controls.Add(this.dgvHocVi);
            this.Controls.Add(this.pnlCardPC);
            this.Controls.Add(this.pnlCardMon);
            this.Controls.Add(this.pnlCardCV);
            this.Controls.Add(this.pnlCardGV);
            this.Controls.Add(this.lblTitle);
            this.Name = "ucThongKe";
            this.Size = new System.Drawing.Size(780, 600);
            this.Load += new System.EventHandler(this.ucThongKe_Load);

            this.pnlCardGV.ResumeLayout(false);
            this.pnlCardGV.PerformLayout();
            this.pnlCardCV.ResumeLayout(false);
            this.pnlCardCV.PerformLayout();
            this.pnlCardMon.ResumeLayout(false);
            this.pnlCardMon.PerformLayout();
            this.pnlCardPC.ResumeLayout(false);
            this.pnlCardPC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocVi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}