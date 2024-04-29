namespace QuanLySieuThi
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MNS = new System.Windows.Forms.MenuStrip();
            this.heThongMNS = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatMNS = new System.Windows.Forms.ToolStripMenuItem();
            this.qlyMNS = new System.Windows.Forms.ToolStripMenuItem();
            this.taiKhoanMNS = new System.Windows.Forms.ToolStripMenuItem();
            this.nhaCungCapMNS = new System.Windows.Forms.ToolStripMenuItem();
            this.loaiSanPhamMNS = new System.Windows.Forms.ToolStripMenuItem();
            this.sanPhamMNS = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanVienMNS = new System.Windows.Forms.ToolStripMenuItem();
            this.donHangMNS = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTietDonHangMNS = new System.Windows.Forms.ToolStripMenuItem();
            this.banHangMNS = new System.Windows.Forms.ToolStripMenuItem();
            this.traCuuMNS = new System.Windows.Forms.ToolStripMenuItem();
            this.inAnMNS = new System.Windows.Forms.ToolStripMenuItem();
            this.MNS.SuspendLayout();
            this.SuspendLayout();
            // 
            // MNS
            // 
            this.MNS.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MNS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongMNS,
            this.qlyMNS,
            this.banHangMNS,
            this.traCuuMNS,
            this.inAnMNS});
            this.MNS.Location = new System.Drawing.Point(0, 0);
            this.MNS.Name = "MNS";
            this.MNS.Size = new System.Drawing.Size(1200, 24);
            this.MNS.TabIndex = 0;
            this.MNS.Text = "menuStrip1";
            // 
            // heThongMNS
            // 
            this.heThongMNS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoatMNS});
            this.heThongMNS.Name = "heThongMNS";
            this.heThongMNS.Size = new System.Drawing.Size(71, 20);
            this.heThongMNS.Text = "Hệ Thống";
            // 
            // thoatMNS
            // 
            this.thoatMNS.Name = "thoatMNS";
            this.thoatMNS.Size = new System.Drawing.Size(104, 22);
            this.thoatMNS.Text = "Thoát";
            this.thoatMNS.Click += new System.EventHandler(this.thoatMNS_Click);
            // 
            // qlyMNS
            // 
            this.qlyMNS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taiKhoanMNS,
            this.nhaCungCapMNS,
            this.loaiSanPhamMNS,
            this.sanPhamMNS,
            this.nhanVienMNS,
            this.donHangMNS,
            this.chiTietDonHangMNS});
            this.qlyMNS.Name = "qlyMNS";
            this.qlyMNS.Size = new System.Drawing.Size(62, 20);
            this.qlyMNS.Text = "Quản Lý";
            // 
            // taiKhoanMNS
            // 
            this.taiKhoanMNS.Name = "taiKhoanMNS";
            this.taiKhoanMNS.Size = new System.Drawing.Size(180, 22);
            this.taiKhoanMNS.Text = "Tài Khoản";
            this.taiKhoanMNS.Click += new System.EventHandler(this.taiKhoanMNS_Click);
            // 
            // nhaCungCapMNS
            // 
            this.nhaCungCapMNS.Name = "nhaCungCapMNS";
            this.nhaCungCapMNS.Size = new System.Drawing.Size(180, 22);
            this.nhaCungCapMNS.Text = "Nhà Cung Cấp";
            this.nhaCungCapMNS.Click += new System.EventHandler(this.nhaCungCapMNS_Click);
            // 
            // loaiSanPhamMNS
            // 
            this.loaiSanPhamMNS.Name = "loaiSanPhamMNS";
            this.loaiSanPhamMNS.Size = new System.Drawing.Size(180, 22);
            this.loaiSanPhamMNS.Text = "Loại Sản Phẩm";
            // 
            // sanPhamMNS
            // 
            this.sanPhamMNS.Name = "sanPhamMNS";
            this.sanPhamMNS.Size = new System.Drawing.Size(180, 22);
            this.sanPhamMNS.Text = "Sản Phẩm";
            // 
            // nhanVienMNS
            // 
            this.nhanVienMNS.Name = "nhanVienMNS";
            this.nhanVienMNS.Size = new System.Drawing.Size(180, 22);
            this.nhanVienMNS.Text = "Nhân Viên";
            this.nhanVienMNS.Click += new System.EventHandler(this.nhanVienMNS_Click);
            // 
            // donHangMNS
            // 
            this.donHangMNS.Name = "donHangMNS";
            this.donHangMNS.Size = new System.Drawing.Size(180, 22);
            this.donHangMNS.Text = "Đơn Hàng";
            this.donHangMNS.Click += new System.EventHandler(this.donHangMNS_Click);
            // 
            // chiTietDonHangMNS
            // 
            this.chiTietDonHangMNS.Name = "chiTietDonHangMNS";
            this.chiTietDonHangMNS.Size = new System.Drawing.Size(180, 22);
            this.chiTietDonHangMNS.Text = "Chi Tiết Đơn Hàng";
            this.chiTietDonHangMNS.Click += new System.EventHandler(this.chiTietDonHangMNS_Click);
            // 
            // banHangMNS
            // 
            this.banHangMNS.Name = "banHangMNS";
            this.banHangMNS.Size = new System.Drawing.Size(71, 20);
            this.banHangMNS.Text = "Bán Hàng";
            // 
            // traCuuMNS
            // 
            this.traCuuMNS.Name = "traCuuMNS";
            this.traCuuMNS.Size = new System.Drawing.Size(59, 20);
            this.traCuuMNS.Text = "Tra Cứu";
            // 
            // inAnMNS
            // 
            this.inAnMNS.Name = "inAnMNS";
            this.inAnMNS.Size = new System.Drawing.Size(47, 20);
            this.inAnMNS.Text = "In Ấn";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.MNS);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MNS;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.MNS.ResumeLayout(false);
            this.MNS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MNS;
        private System.Windows.Forms.ToolStripMenuItem heThongMNS;
        private System.Windows.Forms.ToolStripMenuItem thoatMNS;
        private System.Windows.Forms.ToolStripMenuItem qlyMNS;
        private System.Windows.Forms.ToolStripMenuItem banHangMNS;
        private System.Windows.Forms.ToolStripMenuItem traCuuMNS;
        private System.Windows.Forms.ToolStripMenuItem inAnMNS;
        private System.Windows.Forms.ToolStripMenuItem taiKhoanMNS;
        private System.Windows.Forms.ToolStripMenuItem nhaCungCapMNS;
        private System.Windows.Forms.ToolStripMenuItem loaiSanPhamMNS;
        private System.Windows.Forms.ToolStripMenuItem sanPhamMNS;
        private System.Windows.Forms.ToolStripMenuItem nhanVienMNS;
        private System.Windows.Forms.ToolStripMenuItem donHangMNS;
        private System.Windows.Forms.ToolStripMenuItem chiTietDonHangMNS;
    }
}

