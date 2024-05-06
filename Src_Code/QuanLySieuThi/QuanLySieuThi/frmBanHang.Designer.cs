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
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(596, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Bán Hàng";
            // 
            // dgvSP
            // 
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSP.Location = new System.Drawing.Point(1, 422);
            this.dgvSP.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.RowHeadersWidth = 51;
            this.dgvSP.Size = new System.Drawing.Size(644, 506);
            this.dgvSP.TabIndex = 2;
            this.dgvSP.Click += new System.EventHandler(this.dgvSP_Click);
            // 
            // dgvMuaHang
            // 
            this.dgvMuaHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuaHang.Location = new System.Drawing.Point(682, 675);
            this.dgvMuaHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMuaHang.Name = "dgvMuaHang";
            this.dgvMuaHang.RowHeadersWidth = 51;
            this.dgvMuaHang.Size = new System.Drawing.Size(990, 193);
            this.dgvMuaHang.TabIndex = 3;
            this.dgvMuaHang.Click += new System.EventHandler(this.dgvMuaHang_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 4;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 385);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sản Phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1137, 638);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mua Hàng";
            // 
            // gbBanHang
            // 
            this.gbBanHang.Controls.Add(this.tableForm);
            this.gbBanHang.Location = new System.Drawing.Point(815, 127);
            this.gbBanHang.Margin = new System.Windows.Forms.Padding(4);
            this.gbBanHang.Name = "gbBanHang";
            this.gbBanHang.Padding = new System.Windows.Forms.Padding(4);
            this.gbBanHang.Size = new System.Drawing.Size(797, 405);
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
            this.tableForm.Location = new System.Drawing.Point(88, 57);
            this.tableForm.Margin = new System.Windows.Forms.Padding(4);
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
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableForm.Size = new System.Drawing.Size(672, 319);
            this.tableForm.TabIndex = 0;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtThanhTien.Location = new System.Drawing.Point(340, 238);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(328, 22);
            this.txtThanhTien.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoLuong.Location = new System.Drawing.Point(340, 199);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(328, 22);
            this.txtSoLuong.TabIndex = 5;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(328, 39);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã Chi Tiết:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(328, 39);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã Đơn Hàng:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(328, 39);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mã Sản Phẩm:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 117);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(328, 39);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tên Sản Phẩm:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 156);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(328, 39);
            this.label9.TabIndex = 7;
            this.label9.Text = "Giá Bán:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 195);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(328, 39);
            this.label10.TabIndex = 8;
            this.label10.Text = "Số Lượng:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 234);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(328, 39);
            this.label11.TabIndex = 9;
            this.label11.Text = "Thành Tiền:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 273);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(328, 46);
            this.label12.TabIndex = 10;
            this.label12.Text = "Đơn Vị Tính:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaChiTiet
            // 
            this.txtMaChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaChiTiet.Location = new System.Drawing.Point(340, 4);
            this.txtMaChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaChiTiet.Name = "txtMaChiTiet";
            this.txtMaChiTiet.Size = new System.Drawing.Size(328, 22);
            this.txtMaChiTiet.TabIndex = 0;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaSP.Location = new System.Drawing.Point(340, 82);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(328, 22);
            this.txtMaSP.TabIndex = 11;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenSP.Location = new System.Drawing.Point(340, 121);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(328, 22);
            this.txtTenSP.TabIndex = 11;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGiaBan.Location = new System.Drawing.Point(340, 160);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(328, 22);
            this.txtGiaBan.TabIndex = 11;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDonViTinh.Location = new System.Drawing.Point(340, 277);
            this.txtDonViTinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(328, 22);
            this.txtDonViTinh.TabIndex = 11;
            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaDonHang.Location = new System.Drawing.Point(340, 43);
            this.txtMaDonHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.Size = new System.Drawing.Size(328, 22);
            this.txtMaDonHang.TabIndex = 12;
            // 
            // tableButton
            // 
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
            this.tableButton.Location = new System.Drawing.Point(815, 551);
            this.tableButton.Margin = new System.Windows.Forms.Padding(4);
            this.tableButton.Name = "tableButton";
            this.tableButton.RowCount = 1;
            this.tableButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableButton.Size = new System.Drawing.Size(797, 64);
            this.tableButton.TabIndex = 8;
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThoat.Location = new System.Drawing.Point(640, 4);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(153, 56);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLamMoi.Location = new System.Drawing.Point(481, 4);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(151, 56);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua.Location = new System.Drawing.Point(322, 4);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(151, 56);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.Location = new System.Drawing.Point(163, 4);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(151, 56);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.Location = new System.Drawing.Point(4, 4);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(151, 56);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gbDonHang
            // 
            this.gbDonHang.Controls.Add(this.tableLayoutPanel1);
            this.gbDonHang.Location = new System.Drawing.Point(1, 86);
            this.gbDonHang.Name = "gbDonHang";
            this.gbDonHang.Size = new System.Drawing.Size(519, 280);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(471, 213);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(3, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(229, 54);
            this.label13.TabIndex = 4;
            this.label13.Text = "Nhân Viên Tạo Đơn Hàng:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(229, 53);
            this.label14.TabIndex = 1;
            this.label14.Text = "Mã Đơn Hàng:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(3, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(229, 53);
            this.label15.TabIndex = 2;
            this.label15.Text = "Ngày Bán:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(3, 106);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(229, 53);
            this.label16.TabIndex = 3;
            this.label16.Text = "Tổng Giá Trị Đơn Hàng:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaDon
            // 
            this.txtMaDon.Location = new System.Drawing.Point(238, 20);
            this.txtMaDon.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.txtMaDon.Name = "txtMaDon";
            this.txtMaDon.Size = new System.Drawing.Size(230, 22);
            this.txtMaDon.TabIndex = 0;
            // 
            // txtTongGiaTriDH
            // 
            this.txtTongGiaTriDH.Location = new System.Drawing.Point(238, 126);
            this.txtTongGiaTriDH.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.txtTongGiaTriDH.Name = "txtTongGiaTriDH";
            this.txtTongGiaTriDH.Size = new System.Drawing.Size(230, 22);
            this.txtTongGiaTriDH.TabIndex = 2;
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBan.Location = new System.Drawing.Point(238, 73);
            this.dtpNgayBan.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(230, 22);
            this.dtpNgayBan.TabIndex = 1;
            // 
            // cboMaNV
            // 
            this.cboMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(238, 179);
            this.cboMaNV.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(230, 24);
            this.cboMaNV.TabIndex = 3;
            // 
            // btnThemDH
            // 
            this.btnThemDH.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDH.Location = new System.Drawing.Point(526, 331);
            this.btnThemDH.Name = "btnThemDH";
            this.btnThemDH.Size = new System.Drawing.Size(202, 35);
            this.btnThemDH.TabIndex = 10;
            this.btnThemDH.Text = "Tạo Đơn Hàng";
            this.btnThemDH.UseVisualStyleBackColor = true;
            this.btnThemDH.Click += new System.EventHandler(this.btnThemDH_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1055, 893);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 19);
            this.label17.TabIndex = 11;
            this.label17.Text = "Tổng Tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(1204, 890);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(226, 22);
            this.txtTongTien.TabIndex = 12;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(1436, 882);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(202, 30);
            this.btnThanhToan.TabIndex = 13;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1672, 927);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBanHang";
            this.Text = "frmBanHang";
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