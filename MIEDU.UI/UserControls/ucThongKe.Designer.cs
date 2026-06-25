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

        private System.Windows.Forms.Panel pnlChart;
        private System.Windows.Forms.Label lblHocViTitle;

        private System.Windows.Forms.DataGridView dgvTopGV;
        private System.Windows.Forms.Label lblTopGVTitle;

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
            this.pnlChart = new System.Windows.Forms.Panel();
            this.lblHocViTitle = new System.Windows.Forms.Label();
            this.dgvTopGV = new System.Windows.Forms.DataGridView();
            this.lblTopGVTitle = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();

            this.pnlCardGV.SuspendLayout();
            this.pnlCardCV.SuspendLayout();
            this.pnlCardMon.SuspendLayout();
            this.pnlCardPC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopGV)).BeginInit();
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
            this.btnRefresh.Location = new System.Drawing.Point(850, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 30);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // pnlCardGV
            this.pnlCardGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.pnlCardGV.Controls.Add(this.lblCountGV);
            this.pnlCardGV.Controls.Add(this.lblTitleGV);
            this.pnlCardGV.Location = new System.Drawing.Point(25, 70);
            this.pnlCardGV.Name = "pnlCardGV";
            this.pnlCardGV.Size = new System.Drawing.Size(200, 100);

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
            this.pnlCardCV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.pnlCardCV.Controls.Add(this.lblCountCV);
            this.pnlCardCV.Controls.Add(this.lblTitleCV);
            this.pnlCardCV.Location = new System.Drawing.Point(250, 70);
            this.pnlCardCV.Name = "pnlCardCV";
            this.pnlCardCV.Size = new System.Drawing.Size(200, 100);

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
            this.pnlCardMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.pnlCardMon.Controls.Add(this.lblCountMon);
            this.pnlCardMon.Controls.Add(this.lblTitleMon);
            this.pnlCardMon.Location = new System.Drawing.Point(475, 70);
            this.pnlCardMon.Name = "pnlCardMon";
            this.pnlCardMon.Size = new System.Drawing.Size(200, 100);

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
            this.pnlCardPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.pnlCardPC.Controls.Add(this.lblCountPC);
            this.pnlCardPC.Controls.Add(this.lblTitlePC);
            this.pnlCardPC.Location = new System.Drawing.Point(700, 70);
            this.pnlCardPC.Name = "pnlCardPC";
            this.pnlCardPC.Size = new System.Drawing.Size(260, 100);

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
            this.lblHocViTitle.Text = "Biểu đồ Tỉ lệ Giảng viên theo Học vị";

            // pnlChart
            this.pnlChart.BackColor = System.Drawing.Color.White;
            this.pnlChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChart.Location = new System.Drawing.Point(25, 235);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Size = new System.Drawing.Size(425, 250);
            this.pnlChart.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChart_Paint);

            // lblTopGVTitle
            this.lblTopGVTitle.AutoSize = true;
            this.lblTopGVTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTopGVTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblTopGVTitle.Location = new System.Drawing.Point(470, 200);
            this.lblTopGVTitle.Text = "Bảng xếp hạng Top 5 Giảng viên dạy nhiều tín chỉ nhất";

            // dgvTopGV
            this.dgvTopGV.AllowUserToAddRows = false;
            this.dgvTopGV.AllowUserToDeleteRows = false;
            this.dgvTopGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopGV.BackgroundColor = System.Drawing.Color.White;
            this.dgvTopGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTopGV.Location = new System.Drawing.Point(475, 235);
            this.dgvTopGV.Name = "dgvTopGV";
            this.dgvTopGV.ReadOnly = true;
            this.dgvTopGV.RowHeadersVisible = false;
            this.dgvTopGV.Size = new System.Drawing.Size(485, 250);

            // ucThongKe
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTopGVTitle);
            this.Controls.Add(this.dgvTopGV);
            this.Controls.Add(this.pnlChart);
            this.Controls.Add(this.lblHocViTitle);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.pnlCardPC);
            this.Controls.Add(this.pnlCardMon);
            this.Controls.Add(this.pnlCardCV);
            this.Controls.Add(this.pnlCardGV);
            this.Controls.Add(this.lblTitle);
            this.Name = "ucThongKe";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Load += new System.EventHandler(this.ucThongKe_Load);

            this.pnlCardGV.ResumeLayout(false);
            this.pnlCardGV.PerformLayout();
            this.pnlCardCV.ResumeLayout(false);
            this.pnlCardCV.PerformLayout();
            this.pnlCardMon.ResumeLayout(false);
            this.pnlCardMon.PerformLayout();
            this.pnlCardPC.ResumeLayout(false);
            this.pnlCardPC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}