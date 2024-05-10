namespace QuanLySieuThi
{
    partial class frmTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaiKhoan));
            this.label1 = new System.Windows.Forms.Label();
            this.tableForm = new System.Windows.Forms.TableLayoutPanel();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.dtpTaiKhoan = new System.Windows.Forms.DateTimePicker();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.gbTaiKhoan = new System.Windows.Forms.GroupBox();
            this.tableButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.tableDGVTaiKhoan = new System.Windows.Forms.TableLayoutPanel();
            this.tableButton2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTimTKTheoCV = new System.Windows.Forms.Button();
            this.btnTimTKTheoTenNV = new System.Windows.Forms.Button();
            this.tableForm.SuspendLayout();
            this.gbTaiKhoan.SuspendLayout();
            this.tableButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.tableDGVTaiKhoan.SuspendLayout();
            this.tableButton2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(731, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Tài Khoản";
            // 
            // tableForm
            // 
            this.tableForm.ColumnCount = 2;
            this.tableForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.29097F));
            this.tableForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.70903F));
            this.tableForm.Controls.Add(this.txtHoTen, 1, 2);
            this.tableForm.Controls.Add(this.txtMatKhau, 1, 1);
            this.tableForm.Controls.Add(this.label2, 0, 0);
            this.tableForm.Controls.Add(this.label3, 0, 1);
            this.tableForm.Controls.Add(this.label4, 0, 2);
            this.tableForm.Controls.Add(this.label5, 0, 3);
            this.tableForm.Controls.Add(this.label6, 0, 4);
            this.tableForm.Controls.Add(this.txtTaiKhoan, 1, 0);
            this.tableForm.Controls.Add(this.dtpTaiKhoan, 1, 3);
            this.tableForm.Controls.Add(this.cboChucVu, 1, 4);
            this.tableForm.Location = new System.Drawing.Point(26, 25);
            this.tableForm.Name = "tableForm";
            this.tableForm.RowCount = 5;
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableForm.Size = new System.Drawing.Size(598, 221);
            this.tableForm.TabIndex = 1;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(226, 98);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(369, 44);
            this.txtHoTen.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(226, 54);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(369, 44);
            this.txtMatKhau.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tài Khoản:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 44);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật Khẩu:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 44);
            this.label4.TabIndex = 4;
            this.label4.Text = "Họ Tên:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 44);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày Tạo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 45);
            this.label6.TabIndex = 6;
            this.label6.Text = "Chức Vụ:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(226, 10);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(369, 44);
            this.txtTaiKhoan.TabIndex = 0;
            // 
            // dtpTaiKhoan
            // 
            this.dtpTaiKhoan.CustomFormat = "dd/MM/yyyy";
            this.dtpTaiKhoan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTaiKhoan.Location = new System.Drawing.Point(226, 142);
            this.dtpTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dtpTaiKhoan.Name = "dtpTaiKhoan";
            this.dtpTaiKhoan.Size = new System.Drawing.Size(369, 44);
            this.dtpTaiKhoan.TabIndex = 3;
            // 
            // cboChucVu
            // 
            this.cboChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cboChucVu.Location = new System.Drawing.Point(226, 186);
            this.cboChucVu.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(369, 44);
            this.cboChucVu.TabIndex = 4;
            // 
            // gbTaiKhoan
            // 
            this.gbTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbTaiKhoan.Controls.Add(this.tableForm);
            this.gbTaiKhoan.Location = new System.Drawing.Point(103, 128);
            this.gbTaiKhoan.Name = "gbTaiKhoan";
            this.gbTaiKhoan.Size = new System.Drawing.Size(654, 262);
            this.gbTaiKhoan.TabIndex = 2;
            this.gbTaiKhoan.TabStop = false;
            this.gbTaiKhoan.Text = "Thông Tin Tài Khoản";
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
            this.tableButton.Location = new System.Drawing.Point(129, 410);
            this.tableButton.Name = "tableButton";
            this.tableButton.RowCount = 1;
            this.tableButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableButton.Size = new System.Drawing.Size(598, 52);
            this.tableButton.TabIndex = 3;
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
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AllowUserToAddRows = false;
            this.dgvTaiKhoan.AllowUserToDeleteRows = false;
            this.dgvTaiKhoan.AllowUserToResizeColumns = false;
            this.dgvTaiKhoan.AllowUserToResizeRows = false;
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaiKhoan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(3, 3);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersWidth = 82;
            this.dgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(855, 257);
            this.dgvTaiKhoan.TabIndex = 0;
            this.dgvTaiKhoan.Click += new System.EventHandler(this.dgvTaiKhoan_Click);
            // 
            // tableDGVTaiKhoan
            // 
            this.tableDGVTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableDGVTaiKhoan.ColumnCount = 1;
            this.tableDGVTaiKhoan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDGVTaiKhoan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDGVTaiKhoan.Controls.Add(this.dgvTaiKhoan, 0, 0);
            this.tableDGVTaiKhoan.Location = new System.Drawing.Point(0, 558);
            this.tableDGVTaiKhoan.Name = "tableDGVTaiKhoan";
            this.tableDGVTaiKhoan.RowCount = 1;
            this.tableDGVTaiKhoan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDGVTaiKhoan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 263F));
            this.tableDGVTaiKhoan.Size = new System.Drawing.Size(861, 263);
            this.tableDGVTaiKhoan.TabIndex = 4;
            // 
            // tableButton2
            // 
            this.tableButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableButton2.ColumnCount = 2;
            this.tableButton2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableButton2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableButton2.Controls.Add(this.btnTimTKTheoCV, 1, 0);
            this.tableButton2.Controls.Add(this.btnTimTKTheoTenNV, 0, 0);
            this.tableButton2.Location = new System.Drawing.Point(132, 477);
            this.tableButton2.Name = "tableButton2";
            this.tableButton2.RowCount = 1;
            this.tableButton2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButton2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableButton2.Size = new System.Drawing.Size(592, 64);
            this.tableButton2.TabIndex = 5;
            // 
            // btnTimTKTheoCV
            // 
            this.btnTimTKTheoCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimTKTheoCV.Image = ((System.Drawing.Image)(resources.GetObject("btnTimTKTheoCV.Image")));
            this.btnTimTKTheoCV.Location = new System.Drawing.Point(299, 3);
            this.btnTimTKTheoCV.Name = "btnTimTKTheoCV";
            this.btnTimTKTheoCV.Size = new System.Drawing.Size(290, 58);
            this.btnTimTKTheoCV.TabIndex = 1;
            this.btnTimTKTheoCV.Text = "Tìm Tài Khoản Theo Chức Vụ";
            this.btnTimTKTheoCV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimTKTheoCV.UseVisualStyleBackColor = true;
            this.btnTimTKTheoCV.Click += new System.EventHandler(this.btnTimTKTheoCV_Click);
            // 
            // btnTimTKTheoTenNV
            // 
            this.btnTimTKTheoTenNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimTKTheoTenNV.Image = ((System.Drawing.Image)(resources.GetObject("btnTimTKTheoTenNV.Image")));
            this.btnTimTKTheoTenNV.Location = new System.Drawing.Point(3, 3);
            this.btnTimTKTheoTenNV.Name = "btnTimTKTheoTenNV";
            this.btnTimTKTheoTenNV.Size = new System.Drawing.Size(290, 58);
            this.btnTimTKTheoTenNV.TabIndex = 0;
            this.btnTimTKTheoTenNV.Text = "Tìm Tài Khoản Theo Tên Nhân Viên";
            this.btnTimTKTheoTenNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimTKTheoTenNV.UseVisualStyleBackColor = true;
            this.btnTimTKTheoTenNV.Click += new System.EventHandler(this.btnTimTKTheoTenNV_Click);
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 821);
            this.ControlBox = false;
            this.Controls.Add(this.tableButton2);
            this.Controls.Add(this.tableDGVTaiKhoan);
            this.Controls.Add(this.tableButton);
            this.Controls.Add(this.gbTaiKhoan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTaiKhoan";
            this.Text = "frmTaiKhoan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTaiKhoan_FormClosing);
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            this.tableForm.ResumeLayout(false);
            this.tableForm.PerformLayout();
            this.gbTaiKhoan.ResumeLayout(false);
            this.tableButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.tableDGVTaiKhoan.ResumeLayout(false);
            this.tableButton2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.DateTimePicker dtpTaiKhoan;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.GroupBox gbTaiKhoan;
        private System.Windows.Forms.TableLayoutPanel tableButton;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.TableLayoutPanel tableDGVTaiKhoan;
        private System.Windows.Forms.TableLayoutPanel tableButton2;
        private System.Windows.Forms.Button btnTimTKTheoCV;
        private System.Windows.Forms.Button btnTimTKTheoTenNV;
    }
}