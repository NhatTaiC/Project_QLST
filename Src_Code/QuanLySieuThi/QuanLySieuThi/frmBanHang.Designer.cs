namespace QuanLySieuThi
{
    partial class frmBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanHang));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.dgvMuaHang = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbBanHang = new System.Windows.Forms.GroupBox();
            this.tableForm = new System.Windows.Forms.TableLayoutPanel();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaChiTiet = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtMaDonHang = new System.Windows.Forms.TextBox();
            this.tableButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.gbDonHang = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMaDon = new System.Windows.Forms.TextBox();
            this.txtTongGiaTriDH = new System.Windows.Forms.TextBox();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.btnThemDH = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuaHang)).BeginInit();
            this.gbBanHang.SuspendLayout();
            this.tableForm.SuspendLayout();
            this.tableButton.SuspendLayout();
            this.gbDonHang.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Bán Hàng";
            // 
            // dgvSP
            // 
            this.dgvSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSP.Location = new System.Drawing.Point(74, 349);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.RowHeadersWidth = 51;
            this.dgvSP.Size = new System.Drawing.Size(483, 411);
            this.dgvSP.TabIndex = 2;
            this.dgvSP.Click += new System.EventHandler(this.dgvSP_Click);
            // 
            // dgvMuaHang
            // 
            this.dgvMuaHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMuaHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuaHang.Location = new System.Drawing.Point(593, 572);
            this.dgvMuaHang.Name = "dgvMuaHang";
            this.dgvMuaHang.RowHeadersWidth = 51;
            this.dgvMuaHang.Size = new System.Drawing.Size(742, 157);
            this.dgvMuaHang.TabIndex = 3;
            this.dgvMuaHang.Click += new System.EventHandler(this.dgvMuaHang_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sản Phẩm";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(934, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mua Hàng";
            // 
            // gbBanHang
            // 
            this.gbBanHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbBanHang.Controls.Add(this.tableForm);
            this.gbBanHang.Location = new System.Drawing.Point(684, 109);
            this.gbBanHang.Name = "gbBanHang";
            this.gbBanHang.Size = new System.Drawing.Size(598, 329);
            this.gbBanHang.TabIndex = 7;
            this.gbBanHang.TabStop = false;
            // 
            // tableForm
            // 
            this.tableForm.ColumnCount = 2;
            this.tableForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableForm.Controls.Add(this.txtThanhTien, 1, 6);
            this.tableForm.Controls.Add(this.txtSoLuong, 1, 5);
            this.tableForm.Controls.Add(this.label5, 0, 0);
            this.tableForm.Controls.Add(this.label6, 0, 1);
            this.tableForm.Controls.Add(this.label7, 0, 2);
            this.tableForm.Controls.Add(this.label8, 0, 3);
            this.tableForm.Controls.Add(this.label9, 0, 4);
            this.tableForm.Controls.Add(this.label10, 0, 5);
            this.tableForm.Controls.Add(this.label11, 0, 6);
            this.tableForm.Controls.Add(this.label12, 0, 7);
            this.tableForm.Controls.Add(this.txtMaChiTiet, 1, 0);
            this.tableForm.Controls.Add(this.txtMaSP, 1, 2);
            this.tableForm.Controls.Add(this.txtTenSP, 1, 3);
            this.tableForm.Controls.Add(this.txtGiaBan, 1, 4);
            this.tableForm.Controls.Add(this.txtDonViTinh, 1, 7);
            this.tableForm.Controls.Add(this.txtMaDonHang, 1, 1);
            this.tableForm.Location = new System.Drawing.Point(66, 46);
            this.tableForm.Name = "tableForm";
            this.tableForm.RowCount = 8;
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableForm.Size = new System.Drawing.Size(504, 259);
            this.tableForm.TabIndex = 0;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtThanhTien.Location = new System.Drawing.Point(255, 195);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(246, 20);
            this.txtThanhTien.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoLuong.Location = new System.Drawing.Point(255, 163);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(246, 20);
            this.txtSoLuong.TabIndex = 5;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã Chi Tiết:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã Đơn Hàng:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mã Sản Phẩm:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 32);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tên Sản Phẩm:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(246, 32);
            this.label9.TabIndex = 7;
            this.label9.Text = "Giá Bán:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(246, 32);
            this.label10.TabIndex = 8;
            this.label10.Text = "Số Lượng:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(246, 32);
            this.label11.TabIndex = 9;
            this.label11.Text = "Thành Tiền:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(246, 35);
            this.label12.TabIndex = 10;
            this.label12.Text = "Đơn Vị Tính:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaChiTiet
            // 
            this.txtMaChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaChiTiet.Location = new System.Drawing.Point(255, 3);
            this.txtMaChiTiet.Name = "txtMaChiTiet";
            this.txtMaChiTiet.Size = new System.Drawing.Size(246, 20);
            this.txtMaChiTiet.TabIndex = 0;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaSP.Location = new System.Drawing.Point(255, 67);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(246, 20);
            this.txtMaSP.TabIndex = 11;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenSP.Location = new System.Drawing.Point(255, 99);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(246, 20);
            this.txtTenSP.TabIndex = 11;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGiaBan.Location = new System.Drawing.Point(255, 131);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(246, 20);
            this.txtGiaBan.TabIndex = 11;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDonViTinh.Location = new System.Drawing.Point(255, 227);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(246, 20);
            this.txtDonViTinh.TabIndex = 11;
            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaDonHang.Location = new System.Drawing.Point(255, 35);
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.Size = new System.Drawing.Size(246, 20);
            this.txtMaDonHang.TabIndex = 12;
            // 
            // tableButton
            // 
            this.tableButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableButton.ColumnCount = 5;
            this.tableButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableButton.Controls.Add(this.btnThoat, 4, 0);
            this.tableButton.Controls.Add(this.btnLamMoi, 3, 0);
            this.tableButton.Controls.Add(this.btnSua, 2, 0);
            this.tableButton.Controls.Add(this.btnXoa, 1, 0);
            this.tableButton.Controls.Add(this.btnThem, 0, 0);
            this.tableButton.Location = new System.Drawing.Point(684, 467);
            this.tableButton.Name = "tableButton";
            this.tableButton.RowCount = 1;
            this.tableButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableButton.Size = new System.Drawing.Size(598, 52);
            this.tableButton.TabIndex = 8;
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThoat.Image = global::QuanLySieuThi.Properties.Resources.logout;
            this.btnThoat.Location = new System.Drawing.Point(479, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 46);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLamMoi.Image = global::QuanLySieuThi.Properties.Resources.reset;
            this.btnLamMoi.Location = new System.Drawing.Point(360, 3);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(113, 46);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua.Image = global::QuanLySieuThi.Properties.Resources.loop;
            this.btnSua.Location = new System.Drawing.Point(241, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(113, 46);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.Image = global::QuanLySieuThi.Properties.Resources.bin;
            this.btnXoa.Location = new System.Drawing.Point(122, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 46);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 46);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gbDonHang
            // 
            this.gbDonHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbDonHang.Controls.Add(this.tableLayoutPanel1);
            this.gbDonHang.Location = new System.Drawing.Point(74, 76);
            this.gbDonHang.Margin = new System.Windows.Forms.Padding(2);
            this.gbDonHang.Name = "gbDonHang";
            this.gbDonHang.Padding = new System.Windows.Forms.Padding(2);
            this.gbDonHang.Size = new System.Drawing.Size(389, 228);
            this.gbDonHang.TabIndex = 9;
            this.gbDonHang.TabStop = false;
            this.gbDonHang.Text = "Tạo Đơn Hàng";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtMaDon, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTongGiaTriDH, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtpNgayBan, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboMaNV, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 32);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(353, 173);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(2, 129);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(172, 44);
            this.label13.TabIndex = 4;
            this.label13.Text = "Nhân Viên Tạo Đơn Hàng:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(2, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(172, 43);
            this.label14.TabIndex = 1;
            this.label14.Text = "Mã Đơn Hàng:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(2, 43);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(172, 43);
            this.label15.TabIndex = 2;
            this.label15.Text = "Ngày Bán:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(2, 86);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(172, 43);
            this.label16.TabIndex = 3;
            this.label16.Text = "Tổng Giá Trị Đơn Hàng:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaDon
            // 
            this.txtMaDon.Location = new System.Drawing.Point(178, 16);
            this.txtMaDon.Margin = new System.Windows.Forms.Padding(2, 16, 2, 16);
            this.txtMaDon.Name = "txtMaDon";
            this.txtMaDon.Size = new System.Drawing.Size(173, 20);
            this.txtMaDon.TabIndex = 0;
            // 
            // txtTongGiaTriDH
            // 
            this.txtTongGiaTriDH.Location = new System.Drawing.Point(178, 102);
            this.txtTongGiaTriDH.Margin = new System.Windows.Forms.Padding(2, 16, 2, 16);
            this.txtTongGiaTriDH.Name = "txtTongGiaTriDH";
            this.txtTongGiaTriDH.Size = new System.Drawing.Size(173, 20);
            this.txtTongGiaTriDH.TabIndex = 2;
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBan.Location = new System.Drawing.Point(178, 59);
            this.dtpNgayBan.Margin = new System.Windows.Forms.Padding(2, 16, 2, 16);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(173, 20);
            this.dtpNgayBan.TabIndex = 1;
            // 
            // cboMaNV
            // 
            this.cboMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(178, 145);
            this.cboMaNV.Margin = new System.Windows.Forms.Padding(2, 16, 2, 16);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(173, 21);
            this.cboMaNV.TabIndex = 3;
            // 
            // btnThemDH
            // 
            this.btnThemDH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemDH.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDH.Image = global::QuanLySieuThi.Properties.Resources.plus;
            this.btnThemDH.Location = new System.Drawing.Point(467, 254);
            this.btnThemDH.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemDH.Name = "btnThemDH";
            this.btnThemDH.Size = new System.Drawing.Size(176, 49);
            this.btnThemDH.TabIndex = 10;
            this.btnThemDH.Text = "Tạo Đơn Hàng";
            this.btnThemDH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemDH.UseVisualStyleBackColor = true;
            this.btnThemDH.Click += new System.EventHandler(this.btnThemDH_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(795, 764);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 19);
            this.label17.TabIndex = 11;
            this.label17.Text = "Tổng Tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(896, 764);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(170, 20);
            this.txtTongTien.TabIndex = 12;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(1080, 761);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(152, 24);
            this.btnThanhToan.TabIndex = 13;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 827);
            this.ControlBox = false;
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnThemDH);
            this.Controls.Add(this.gbDonHang);
            this.Controls.Add(this.tableButton);
            this.Controls.Add(this.gbBanHang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMuaHang);
            this.Controls.Add(this.dgvSP);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBanHang";
            this.Text = "frmBanHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuaHang)).EndInit();
            this.gbBanHang.ResumeLayout(false);
            this.tableForm.ResumeLayout(false);
            this.tableForm.PerformLayout();
            this.tableButton.ResumeLayout(false);
            this.gbDonHang.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSP;
        private System.Windows.Forms.DataGridView dgvMuaHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbBanHang;
        private System.Windows.Forms.TableLayoutPanel tableForm;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMaChiTiet;
        private System.Windows.Forms.TableLayoutPanel tableButton;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtMaDonHang;
        private System.Windows.Forms.GroupBox gbDonHang;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMaDon;
        private System.Windows.Forms.TextBox txtTongGiaTriDH;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.Button btnThemDH;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnThanhToan;
    }
}