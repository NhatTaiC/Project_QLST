namespace QuanLySieuThi
{
    partial class frmChiTietDonHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietDonHang));
            this.label1 = new System.Windows.Forms.Label();
            this.tableForm = new System.Windows.Forms.TableLayoutPanel();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.cboDonViTinh = new System.Windows.Forms.ComboBox();
            this.cboGiaBan = new System.Windows.Forms.ComboBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaChiTiet = new System.Windows.Forms.TextBox();
            this.cboTenSanPham = new System.Windows.Forms.ComboBox();
            this.txtMaDonHang = new System.Windows.Forms.TextBox();
            this.gbChiTietDonHang = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tableDGVChiTietDonHang = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCTDH = new System.Windows.Forms.DataGridView();
            this.tableButton2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTim = new System.Windows.Forms.Button();
            this.tableForm.SuspendLayout();
            this.gbChiTietDonHang.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableDGVChiTietDonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDH)).BeginInit();
            this.tableButton2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Chi Tiết Đơn Hàng";
            // 
            // tableForm
            // 
            this.tableForm.ColumnCount = 2;
            this.tableForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableForm.Controls.Add(this.txtMaSanPham, 1, 2);
            this.tableForm.Controls.Add(this.cboDonViTinh, 1, 7);
            this.tableForm.Controls.Add(this.cboGiaBan, 1, 4);
            this.tableForm.Controls.Add(this.txtThanhTien, 1, 6);
            this.tableForm.Controls.Add(this.txtSoLuong, 1, 5);
            this.tableForm.Controls.Add(this.label2, 0, 0);
            this.tableForm.Controls.Add(this.label3, 0, 1);
            this.tableForm.Controls.Add(this.label4, 0, 2);
            this.tableForm.Controls.Add(this.label5, 0, 3);
            this.tableForm.Controls.Add(this.label6, 0, 4);
            this.tableForm.Controls.Add(this.label7, 0, 5);
            this.tableForm.Controls.Add(this.label8, 0, 6);
            this.tableForm.Controls.Add(this.label9, 0, 7);
            this.tableForm.Controls.Add(this.txtMaChiTiet, 1, 0);
            this.tableForm.Controls.Add(this.cboTenSanPham, 1, 3);
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
            this.tableForm.Size = new System.Drawing.Size(638, 259);
            this.tableForm.TabIndex = 0;
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaSanPham.Location = new System.Drawing.Point(322, 67);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(313, 26);
            this.txtMaSanPham.TabIndex = 2;
            this.txtMaSanPham.TextChanged += new System.EventHandler(this.txtMaSanPham_TextChanged);
            // 
            // cboDonViTinh
            // 
            this.cboDonViTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboDonViTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDonViTinh.FormattingEnabled = true;
            this.cboDonViTinh.Location = new System.Drawing.Point(322, 227);
            this.cboDonViTinh.Name = "cboDonViTinh";
            this.cboDonViTinh.Size = new System.Drawing.Size(313, 26);
            this.cboDonViTinh.TabIndex = 7;
            // 
            // cboGiaBan
            // 
            this.cboGiaBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboGiaBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGiaBan.FormattingEnabled = true;
            this.cboGiaBan.Location = new System.Drawing.Point(322, 131);
            this.cboGiaBan.Name = "cboGiaBan";
            this.cboGiaBan.Size = new System.Drawing.Size(313, 26);
            this.cboGiaBan.TabIndex = 4;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtThanhTien.Location = new System.Drawing.Point(322, 195);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(313, 26);
            this.txtThanhTien.TabIndex = 6;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoLuong.Location = new System.Drawing.Point(322, 163);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(313, 26);
            this.txtSoLuong.TabIndex = 5;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Chi Tiết:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Đơn Hàng:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã Sản Phẩm:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên Sản Phẩm:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(313, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "Giá Bán:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(313, 32);
            this.label7.TabIndex = 8;
            this.label7.Text = "Số Lượng:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(313, 32);
            this.label8.TabIndex = 9;
            this.label8.Text = "Thành Tiền:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(313, 35);
            this.label9.TabIndex = 10;
            this.label9.Text = "Đơn Vị Tính:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaChiTiet
            // 
            this.txtMaChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaChiTiet.Location = new System.Drawing.Point(322, 3);
            this.txtMaChiTiet.Name = "txtMaChiTiet";
            this.txtMaChiTiet.Size = new System.Drawing.Size(313, 26);
            this.txtMaChiTiet.TabIndex = 0;
            // 
            // cboTenSanPham
            // 
            this.cboTenSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboTenSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenSanPham.FormattingEnabled = true;
            this.cboTenSanPham.Location = new System.Drawing.Point(322, 99);
            this.cboTenSanPham.Name = "cboTenSanPham";
            this.cboTenSanPham.Size = new System.Drawing.Size(313, 26);
            this.cboTenSanPham.TabIndex = 3;
            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaDonHang.Location = new System.Drawing.Point(322, 35);
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.Size = new System.Drawing.Size(313, 26);
            this.txtMaDonHang.TabIndex = 1;
            // 
            // gbChiTietDonHang
            // 
            this.gbChiTietDonHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbChiTietDonHang.Controls.Add(this.tableForm);
            this.gbChiTietDonHang.Location = new System.Drawing.Point(112, 109);
            this.gbChiTietDonHang.Name = "gbChiTietDonHang";
            this.gbChiTietDonHang.Size = new System.Drawing.Size(802, 339);
            this.gbChiTietDonHang.TabIndex = 2;
            this.gbChiTietDonHang.TabStop = false;
            this.gbChiTietDonHang.Text = "Thông Tin Chi Tiết Đơn Hàng";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnThoat, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLamMoi, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSua, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnXoa, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnThem, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(112, 463);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(802, 53);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThoat.Image = global::QuanLySieuThi.Properties.Resources.logout;
            this.btnThoat.Location = new System.Drawing.Point(643, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(156, 47);
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
            this.btnLamMoi.Location = new System.Drawing.Point(483, 3);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(154, 47);
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
            this.btnSua.Location = new System.Drawing.Point(323, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(154, 47);
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
            this.btnXoa.Location = new System.Drawing.Point(163, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(154, 47);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(154, 47);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tableDGVChiTietDonHang
            // 
            this.tableDGVChiTietDonHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableDGVChiTietDonHang.ColumnCount = 1;
            this.tableDGVChiTietDonHang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDGVChiTietDonHang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDGVChiTietDonHang.Controls.Add(this.dgvCTDH, 0, 0);
            this.tableDGVChiTietDonHang.Location = new System.Drawing.Point(0, 603);
            this.tableDGVChiTietDonHang.Name = "tableDGVChiTietDonHang";
            this.tableDGVChiTietDonHang.RowCount = 1;
            this.tableDGVChiTietDonHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDGVChiTietDonHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 278F));
            this.tableDGVChiTietDonHang.Size = new System.Drawing.Size(979, 278);
            this.tableDGVChiTietDonHang.TabIndex = 4;
            // 
            // dgvCTDH
            // 
            this.dgvCTDH.AllowUserToAddRows = false;
            this.dgvCTDH.AllowUserToDeleteRows = false;
            this.dgvCTDH.AllowUserToResizeColumns = false;
            this.dgvCTDH.AllowUserToResizeRows = false;
            this.dgvCTDH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCTDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTDH.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCTDH.Location = new System.Drawing.Point(3, 3);
            this.dgvCTDH.Name = "dgvCTDH";
            this.dgvCTDH.RowHeadersWidth = 82;
            this.dgvCTDH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTDH.Size = new System.Drawing.Size(973, 272);
            this.dgvCTDH.TabIndex = 0;
            this.dgvCTDH.Click += new System.EventHandler(this.dgvCTDH_Click);
            // 
            // tableButton2
            // 
            this.tableButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableButton2.ColumnCount = 1;
            this.tableButton2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButton2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableButton2.Controls.Add(this.btnTim, 0, 0);
            this.tableButton2.Location = new System.Drawing.Point(388, 535);
            this.tableButton2.Name = "tableButton2";
            this.tableButton2.RowCount = 1;
            this.tableButton2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButton2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableButton2.Size = new System.Drawing.Size(238, 50);
            this.tableButton2.TabIndex = 5;
            // 
            // btnTim
            // 
            this.btnTim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTim.Image = global::QuanLySieuThi.Properties.Resources.research1;
            this.btnTim.Location = new System.Drawing.Point(3, 3);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(232, 44);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "Tìm CTDH Theo Mã Đơn Hàng";
            this.btnTim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // frmChiTietDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 881);
            this.ControlBox = false;
            this.Controls.Add(this.tableButton2);
            this.Controls.Add(this.tableDGVChiTietDonHang);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gbChiTietDonHang);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChiTietDonHang";
            this.Text = "frmChiTietDonHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChiTietDonHang_FormClosing);
            this.Load += new System.EventHandler(this.frmChiTietDonHang_Load);
            this.tableForm.ResumeLayout(false);
            this.tableForm.PerformLayout();
            this.gbChiTietDonHang.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableDGVChiTietDonHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDH)).EndInit();
            this.tableButton2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableForm;
        private System.Windows.Forms.GroupBox gbChiTietDonHang;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaChiTiet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TableLayoutPanel tableDGVChiTietDonHang;
        private System.Windows.Forms.DataGridView dgvCTDH;
        private System.Windows.Forms.ComboBox cboDonViTinh;
        private System.Windows.Forms.ComboBox cboGiaBan;
        private System.Windows.Forms.ComboBox cboTenSanPham;
        private System.Windows.Forms.TableLayoutPanel tableButton2;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.TextBox txtMaDonHang;
    }
}