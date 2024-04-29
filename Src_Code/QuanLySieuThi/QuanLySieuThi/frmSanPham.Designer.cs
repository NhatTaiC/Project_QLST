namespace QuanLySieuThi
{
    partial class frmSanPham
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
            this.tableButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.gbTaiKhoan = new System.Windows.Forms.GroupBox();
            this.tableForm = new System.Windows.Forms.TableLayoutPanel();
            this.txtNoiSanXuat = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.cboLoaiSanPham = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboNhaCungCap = new System.Windows.Forms.ComboBox();
            this.dtpHanSuDung = new System.Windows.Forms.DateTimePicker();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.tableDGVSanPham = new System.Windows.Forms.TableLayoutPanel();
            this.tableButton.SuspendLayout();
            this.gbTaiKhoan.SuspendLayout();
            this.tableForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            this.tableDGVSanPham.SuspendLayout();
            this.SuspendLayout();
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
            this.tableButton.Location = new System.Drawing.Point(108, 627);
            this.tableButton.Name = "tableButton";
            this.tableButton.RowCount = 1;
            this.tableButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableButton.Size = new System.Drawing.Size(672, 60);
            this.tableButton.TabIndex = 9;
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThoat.Location = new System.Drawing.Point(539, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(130, 54);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLamMoi.Location = new System.Drawing.Point(405, 3);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(128, 54);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua.Location = new System.Drawing.Point(271, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(128, 54);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.Location = new System.Drawing.Point(137, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(128, 54);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(128, 54);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gbTaiKhoan
            // 
            this.gbTaiKhoan.Controls.Add(this.tableForm);
            this.gbTaiKhoan.Location = new System.Drawing.Point(78, 146);
            this.gbTaiKhoan.Name = "gbTaiKhoan";
            this.gbTaiKhoan.Size = new System.Drawing.Size(735, 448);
            this.gbTaiKhoan.TabIndex = 8;
            this.gbTaiKhoan.TabStop = false;
            this.gbTaiKhoan.Text = "Thông Tin Sản Phẩm";
            // 
            // tableForm
            // 
            this.tableForm.ColumnCount = 2;
            this.tableForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.29097F));
            this.tableForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.70903F));
            this.tableForm.Controls.Add(this.txtNoiSanXuat, 1, 6);
            this.tableForm.Controls.Add(this.txtDonViTinh, 1, 5);
            this.tableForm.Controls.Add(this.txtSoLuong, 1, 4);
            this.tableForm.Controls.Add(this.txtGiaBan, 1, 3);
            this.tableForm.Controls.Add(this.txtGiaNhap, 1, 2);
            this.tableForm.Controls.Add(this.txtTenSP, 1, 1);
            this.tableForm.Controls.Add(this.cboLoaiSanPham, 1, 9);
            this.tableForm.Controls.Add(this.label11, 0, 9);
            this.tableForm.Controls.Add(this.label2, 0, 0);
            this.tableForm.Controls.Add(this.label3, 0, 1);
            this.tableForm.Controls.Add(this.label4, 0, 2);
            this.tableForm.Controls.Add(this.label5, 0, 3);
            this.tableForm.Controls.Add(this.label6, 0, 4);
            this.tableForm.Controls.Add(this.label7, 0, 5);
            this.tableForm.Controls.Add(this.label8, 0, 6);
            this.tableForm.Controls.Add(this.label9, 0, 7);
            this.tableForm.Controls.Add(this.label10, 0, 8);
            this.tableForm.Controls.Add(this.cboNhaCungCap, 1, 8);
            this.tableForm.Controls.Add(this.dtpHanSuDung, 1, 7);
            this.tableForm.Controls.Add(this.txtMaSP, 1, 0);
            this.tableForm.Location = new System.Drawing.Point(30, 47);
            this.tableForm.Name = "tableForm";
            this.tableForm.RowCount = 10;
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableForm.Size = new System.Drawing.Size(672, 375);
            this.tableForm.TabIndex = 1;
            // 
            // txtNoiSanXuat
            // 
            this.txtNoiSanXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNoiSanXuat.Location = new System.Drawing.Point(253, 232);
            this.txtNoiSanXuat.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.txtNoiSanXuat.Name = "txtNoiSanXuat";
            this.txtNoiSanXuat.Size = new System.Drawing.Size(416, 26);
            this.txtNoiSanXuat.TabIndex = 28;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDonViTinh.Location = new System.Drawing.Point(253, 195);
            this.txtDonViTinh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(416, 26);
            this.txtDonViTinh.TabIndex = 27;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoLuong.Location = new System.Drawing.Point(253, 158);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(416, 26);
            this.txtSoLuong.TabIndex = 26;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGiaBan.Location = new System.Drawing.Point(253, 121);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(416, 26);
            this.txtGiaBan.TabIndex = 25;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGiaNhap.Location = new System.Drawing.Point(253, 84);
            this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(416, 26);
            this.txtGiaNhap.TabIndex = 24;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenSP.Location = new System.Drawing.Point(253, 47);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(416, 26);
            this.txtTenSP.TabIndex = 23;
            // 
            // cboLoaiSanPham
            // 
            this.cboLoaiSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboLoaiSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiSanPham.FormattingEnabled = true;
            this.cboLoaiSanPham.Location = new System.Drawing.Point(253, 343);
            this.cboLoaiSanPham.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.cboLoaiSanPham.Name = "cboLoaiSanPham";
            this.cboLoaiSanPham.Size = new System.Drawing.Size(416, 26);
            this.cboLoaiSanPham.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(244, 42);
            this.label11.TabIndex = 11;
            this.label11.Text = "Tên Loại Sản Phẩm:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Sản Phẩm:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Sản Phẩm:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá Nhập:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giá Bán:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 37);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số Lượng:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 37);
            this.label7.TabIndex = 7;
            this.label7.Text = "Đơn Vị Tính:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 37);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nơi Sản Xuất:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(244, 37);
            this.label9.TabIndex = 9;
            this.label9.Text = "Hạn Sử Dụng:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(244, 37);
            this.label10.TabIndex = 10;
            this.label10.Text = "Tên Nhà Cung Cấp:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhaCungCap.FormattingEnabled = true;
            this.cboNhaCungCap.Location = new System.Drawing.Point(253, 306);
            this.cboNhaCungCap.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(416, 26);
            this.cboNhaCungCap.TabIndex = 19;
            // 
            // dtpHanSuDung
            // 
            this.dtpHanSuDung.CustomFormat = "dd/MM/yyyy";
            this.dtpHanSuDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpHanSuDung.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHanSuDung.Location = new System.Drawing.Point(253, 269);
            this.dtpHanSuDung.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dtpHanSuDung.Name = "dtpHanSuDung";
            this.dtpHanSuDung.Size = new System.Drawing.Size(416, 26);
            this.dtpHanSuDung.TabIndex = 21;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaSP.Location = new System.Drawing.Point(253, 10);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(416, 26);
            this.txtMaSP.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quản Lý Sản Phẩm";
            // 
            // dgvSP
            // 
            this.dgvSP.AllowUserToAddRows = false;
            this.dgvSP.AllowUserToDeleteRows = false;
            this.dgvSP.AllowUserToResizeColumns = false;
            this.dgvSP.AllowUserToResizeRows = false;
            this.dgvSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSP.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSP.Location = new System.Drawing.Point(3, 3);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.RowHeadersWidth = 51;
            this.dgvSP.RowTemplate.Height = 24;
            this.dgvSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSP.Size = new System.Drawing.Size(918, 158);
            this.dgvSP.TabIndex = 10;
            this.dgvSP.Click += new System.EventHandler(this.dgvSP_Click);
            // 
            // tableDGVSanPham
            // 
            this.tableDGVSanPham.ColumnCount = 1;
            this.tableDGVSanPham.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDGVSanPham.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDGVSanPham.Controls.Add(this.dgvSP, 0, 0);
            this.tableDGVSanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableDGVSanPham.Location = new System.Drawing.Point(0, 717);
            this.tableDGVSanPham.Name = "tableDGVSanPham";
            this.tableDGVSanPham.RowCount = 1;
            this.tableDGVSanPham.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDGVSanPham.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDGVSanPham.Size = new System.Drawing.Size(924, 164);
            this.tableDGVSanPham.TabIndex = 11;
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 881);
            this.ControlBox = false;
            this.Controls.Add(this.tableDGVSanPham);
            this.Controls.Add(this.tableButton);
            this.Controls.Add(this.gbTaiKhoan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSanPham";
            this.Text = "frmSanPham";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSanPham_FormClosing);
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.tableButton.ResumeLayout(false);
            this.gbTaiKhoan.ResumeLayout(false);
            this.tableForm.ResumeLayout(false);
            this.tableForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            this.tableDGVSanPham.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableButton;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox gbTaiKhoan;
        private System.Windows.Forms.TableLayoutPanel tableForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvSP;
        private System.Windows.Forms.TableLayoutPanel tableDGVSanPham;
        private System.Windows.Forms.TextBox txtNoiSanXuat;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.ComboBox cboLoaiSanPham;
        private System.Windows.Forms.ComboBox cboNhaCungCap;
        private System.Windows.Forms.DateTimePicker dtpHanSuDung;
        private System.Windows.Forms.TextBox txtMaSP;
    }
}