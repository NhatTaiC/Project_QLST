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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.MNS = new System.Windows.Forms.MenuStrip();
            this.heThongMNS = new System.Windows.Forms.ToolStripMenuItem();
            this.gioiThieuMNS = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuatMNS = new System.Windows.Forms.ToolStripMenuItem();
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
            this.banHangMNSI = new System.Windows.Forms.ToolStripMenuItem();
            this.traCuuMNS = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanVienTraCuuMNSI = new System.Windows.Forms.ToolStripMenuItem();
            this.sanPhamTraCuuMNSI = new System.Windows.Forms.ToolStripMenuItem();
            this.donHangTraCuuMNSI = new System.Windows.Forms.ToolStripMenuItem();
            this.inAnMNS = new System.Windows.Forms.ToolStripMenuItem();
            this.dSSP_TheoTenSPMNSI = new System.Windows.Forms.ToolStripMenuItem();
            this.DSDH_TheoTenNVMNSI = new System.Windows.Forms.ToolStripMenuItem();
            this.DSDH_TheoNgayBanMNSI = new System.Windows.Forms.ToolStripMenuItem();
            this.inDHTheoMaDonMNSI = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabelHienThoiGian = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.statusLabelUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.MNS.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
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
            this.gioiThieuMNS,
            this.dangXuatMNS,
            this.thoatMNS});
            this.heThongMNS.Name = "heThongMNS";
            this.heThongMNS.Size = new System.Drawing.Size(71, 20);
            this.heThongMNS.Text = "Hệ Thống";
            // 
            // gioiThieuMNS
            // 
            this.gioiThieuMNS.Name = "gioiThieuMNS";
            this.gioiThieuMNS.Size = new System.Drawing.Size(129, 22);
            this.gioiThieuMNS.Text = "Giới Thiệu";
            this.gioiThieuMNS.Click += new System.EventHandler(this.gioiThieuMNS_Click);
            // 
            // dangXuatMNS
            // 
            this.dangXuatMNS.Name = "dangXuatMNS";
            this.dangXuatMNS.Size = new System.Drawing.Size(129, 22);
            this.dangXuatMNS.Text = "Đăng Xuất";
            this.dangXuatMNS.Click += new System.EventHandler(this.dangXuatMNS_Click);
            // 
            // thoatMNS
            // 
            this.thoatMNS.Name = "thoatMNS";
            this.thoatMNS.Size = new System.Drawing.Size(129, 22);
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
            this.taiKhoanMNS.Size = new System.Drawing.Size(171, 22);
            this.taiKhoanMNS.Text = "Tài Khoản";
            this.taiKhoanMNS.Click += new System.EventHandler(this.taiKhoanMNS_Click);
            // 
            // nhaCungCapMNS
            // 
            this.nhaCungCapMNS.Name = "nhaCungCapMNS";
            this.nhaCungCapMNS.Size = new System.Drawing.Size(171, 22);
            this.nhaCungCapMNS.Text = "Nhà Cung Cấp";
            this.nhaCungCapMNS.Click += new System.EventHandler(this.nhaCungCapMNS_Click);
            // 
            // loaiSanPhamMNS
            // 
            this.loaiSanPhamMNS.Name = "loaiSanPhamMNS";
            this.loaiSanPhamMNS.Size = new System.Drawing.Size(171, 22);
            this.loaiSanPhamMNS.Text = "Loại Sản Phẩm";
            this.loaiSanPhamMNS.Click += new System.EventHandler(this.loaiSanPhamMNS_Click);
            // 
            // sanPhamMNS
            // 
            this.sanPhamMNS.Name = "sanPhamMNS";
            this.sanPhamMNS.Size = new System.Drawing.Size(171, 22);
            this.sanPhamMNS.Text = "Sản Phẩm";
            this.sanPhamMNS.Click += new System.EventHandler(this.sanPhamMNS_Click);
            // 
            // nhanVienMNS
            // 
            this.nhanVienMNS.Name = "nhanVienMNS";
            this.nhanVienMNS.Size = new System.Drawing.Size(171, 22);
            this.nhanVienMNS.Text = "Nhân Viên";
            this.nhanVienMNS.Click += new System.EventHandler(this.nhanVienMNS_Click);
            // 
            // donHangMNS
            // 
            this.donHangMNS.Name = "donHangMNS";
            this.donHangMNS.Size = new System.Drawing.Size(171, 22);
            this.donHangMNS.Text = "Đơn Hàng";
            this.donHangMNS.Click += new System.EventHandler(this.donHangMNS_Click);
            // 
            // chiTietDonHangMNS
            // 
            this.chiTietDonHangMNS.Name = "chiTietDonHangMNS";
            this.chiTietDonHangMNS.Size = new System.Drawing.Size(171, 22);
            this.chiTietDonHangMNS.Text = "Chi Tiết Đơn Hàng";
            this.chiTietDonHangMNS.Click += new System.EventHandler(this.chiTietDonHangMNS_Click);
            // 
            // banHangMNS
            // 
            this.banHangMNS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.banHangMNSI});
            this.banHangMNS.Name = "banHangMNS";
            this.banHangMNS.Size = new System.Drawing.Size(71, 20);
            this.banHangMNS.Text = "Bán Hàng";
            // 
            // banHangMNSI
            // 
            this.banHangMNSI.Name = "banHangMNSI";
            this.banHangMNSI.Size = new System.Drawing.Size(126, 22);
            this.banHangMNSI.Text = "Bán Hàng";
            this.banHangMNSI.Click += new System.EventHandler(this.banHangMNSI_Click);
            // 
            // traCuuMNS
            // 
            this.traCuuMNS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhanVienTraCuuMNSI,
            this.sanPhamTraCuuMNSI,
            this.donHangTraCuuMNSI});
            this.traCuuMNS.Name = "traCuuMNS";
            this.traCuuMNS.Size = new System.Drawing.Size(59, 20);
            this.traCuuMNS.Text = "Tra Cứu";
            // 
            // nhanVienTraCuuMNSI
            // 
            this.nhanVienTraCuuMNSI.Name = "nhanVienTraCuuMNSI";
            this.nhanVienTraCuuMNSI.Size = new System.Drawing.Size(129, 22);
            this.nhanVienTraCuuMNSI.Text = "Nhân Viên";
            this.nhanVienTraCuuMNSI.Click += new System.EventHandler(this.nhanVienTraCuuMNSI_Click);
            // 
            // sanPhamTraCuuMNSI
            // 
            this.sanPhamTraCuuMNSI.Name = "sanPhamTraCuuMNSI";
            this.sanPhamTraCuuMNSI.Size = new System.Drawing.Size(129, 22);
            this.sanPhamTraCuuMNSI.Text = "Sản Phẩm";
            this.sanPhamTraCuuMNSI.Click += new System.EventHandler(this.sanPhamTraCuuMNSI_Click);
            // 
            // donHangTraCuuMNSI
            // 
            this.donHangTraCuuMNSI.Name = "donHangTraCuuMNSI";
            this.donHangTraCuuMNSI.Size = new System.Drawing.Size(129, 22);
            this.donHangTraCuuMNSI.Text = "Đơn Hàng";
            this.donHangTraCuuMNSI.Click += new System.EventHandler(this.donHangTraCuuMNSI_Click);
            // 
            // inAnMNS
            // 
            this.inAnMNS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dSSP_TheoTenSPMNSI,
            this.DSDH_TheoTenNVMNSI,
            this.DSDH_TheoNgayBanMNSI,
            this.inDHTheoMaDonMNSI});
            this.inAnMNS.Name = "inAnMNS";
            this.inAnMNS.Size = new System.Drawing.Size(47, 20);
            this.inAnMNS.Text = "In Ấn";
            // 
            // dSSP_TheoTenSPMNSI
            // 
            this.dSSP_TheoTenSPMNSI.Name = "dSSP_TheoTenSPMNSI";
            this.dSSP_TheoTenSPMNSI.Size = new System.Drawing.Size(295, 22);
            this.dSSP_TheoTenSPMNSI.Text = "Danh Sách Sản Phẩm Theo Tên Sản Phẩm";
            this.dSSP_TheoTenSPMNSI.Click += new System.EventHandler(this.dSSP_TheoTenSPMNSI_Click);
            // 
            // DSDH_TheoTenNVMNSI
            // 
            this.DSDH_TheoTenNVMNSI.Name = "DSDH_TheoTenNVMNSI";
            this.DSDH_TheoTenNVMNSI.Size = new System.Drawing.Size(295, 22);
            this.DSDH_TheoTenNVMNSI.Text = "Danh Sách Đơn Hàng Theo Tên Nhân Viên";
            this.DSDH_TheoTenNVMNSI.Click += new System.EventHandler(this.DSDH_TheoTenNVMNSI_Click);
            // 
            // DSDH_TheoNgayBanMNSI
            // 
            this.DSDH_TheoNgayBanMNSI.Name = "DSDH_TheoNgayBanMNSI";
            this.DSDH_TheoNgayBanMNSI.Size = new System.Drawing.Size(295, 22);
            this.DSDH_TheoNgayBanMNSI.Text = "Danh Sách Đơn Hàng Theo Ngày Bán";
            this.DSDH_TheoNgayBanMNSI.Click += new System.EventHandler(this.DSDH_TheoNgayBanMNSI_Click);
            // 
            // inDHTheoMaDonMNSI
            // 
            this.inDHTheoMaDonMNSI.Name = "inDHTheoMaDonMNSI";
            this.inDHTheoMaDonMNSI.Size = new System.Drawing.Size(295, 22);
            this.inDHTheoMaDonMNSI.Text = "In Đơn Hàng Theo Mã Đơn";
            this.inDHTheoMaDonMNSI.Click += new System.EventHandler(this.inDHTheoMaDonMNSI_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelHienThoiGian});
            this.statusStrip1.Location = new System.Drawing.Point(0, 589);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1200, 34);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelHienThoiGian
            // 
            this.statusLabelHienThoiGian.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabelHienThoiGian.Name = "statusLabelHienThoiGian";
            this.statusLabelHienThoiGian.Size = new System.Drawing.Size(187, 29);
            this.statusLabelHienThoiGian.Text = "Hiện Thời Gian";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelUserName});
            this.statusStrip2.Location = new System.Drawing.Point(0, 555);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1200, 34);
            this.statusStrip2.TabIndex = 4;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // statusLabelUserName
            // 
            this.statusLabelUserName.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabelUserName.Name = "statusLabelUserName";
            this.statusLabelUserName.Size = new System.Drawing.Size(268, 29);
            this.statusLabelUserName.Text = "Hiện Tên Người Dùng";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MNS);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MNS;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MNS.ResumeLayout(false);
            this.MNS.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem gioiThieuMNS;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelHienThoiGian;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem dangXuatMNS;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelUserName;
        private System.Windows.Forms.ToolStripMenuItem nhanVienTraCuuMNSI;
        private System.Windows.Forms.ToolStripMenuItem sanPhamTraCuuMNSI;
        private System.Windows.Forms.ToolStripMenuItem donHangTraCuuMNSI;
        private System.Windows.Forms.ToolStripMenuItem dSSP_TheoTenSPMNSI;
        private System.Windows.Forms.ToolStripMenuItem DSDH_TheoTenNVMNSI;
        private System.Windows.Forms.ToolStripMenuItem DSDH_TheoNgayBanMNSI;
        private System.Windows.Forms.ToolStripMenuItem banHangMNSI;
        private System.Windows.Forms.ToolStripMenuItem inDHTheoMaDonMNSI;
    }
}

