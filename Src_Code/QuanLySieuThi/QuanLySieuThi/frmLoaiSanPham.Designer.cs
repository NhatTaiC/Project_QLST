namespace QuanLySieuThi
{
    partial class frmLoaiSanPham
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
            this.gbLoaiSP = new System.Windows.Forms.GroupBox();
            this.tableForm = new System.Windows.Forms.TableLayoutPanel();
            this.txtTenLSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtMaLSP = new System.Windows.Forms.TextBox();
            this.tableButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvLoaiSP = new System.Windows.Forms.DataGridView();
            this.tableDGVLoaiSanPham = new System.Windows.Forms.TableLayoutPanel();
            this.tableButton2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTim = new System.Windows.Forms.Button();
            this.gbLoaiSP.SuspendLayout();
            this.tableForm.SuspendLayout();
            this.tableButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSP)).BeginInit();
            this.tableDGVLoaiSanPham.SuspendLayout();
            this.tableButton2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Loại Sản Phẩm";
            // 
            // gbLoaiSP
            // 
            this.gbLoaiSP.Controls.Add(this.tableForm);
            this.gbLoaiSP.Location = new System.Drawing.Point(89, 187);
            this.gbLoaiSP.Name = "gbLoaiSP";
            this.gbLoaiSP.Size = new System.Drawing.Size(711, 209);
            this.gbLoaiSP.TabIndex = 3;
            this.gbLoaiSP.TabStop = false;
            this.gbLoaiSP.Text = "Thông Tin Loại Sản Phẩm";
            // 
            // tableForm
            // 
            this.tableForm.ColumnCount = 2;
            this.tableForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.70286F));
            this.tableForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.29714F));
            this.tableForm.Controls.Add(this.txtTenLSP, 1, 1);
            this.tableForm.Controls.Add(this.label2, 0, 0);
            this.tableForm.Controls.Add(this.label3, 0, 1);
            this.tableForm.Controls.Add(this.label4, 0, 2);
            this.tableForm.Controls.Add(this.txtMoTa, 1, 2);
            this.tableForm.Controls.Add(this.txtMaLSP, 1, 0);
            this.tableForm.Location = new System.Drawing.Point(15, 42);
            this.tableForm.Name = "tableForm";
            this.tableForm.RowCount = 3;
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableForm.Size = new System.Drawing.Size(672, 135);
            this.tableForm.TabIndex = 1;
            // 
            // txtTenLSP
            // 
            this.txtTenLSP.Location = new System.Drawing.Point(269, 54);
            this.txtTenLSP.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.txtTenLSP.Name = "txtTenLSP";
            this.txtTenLSP.Size = new System.Drawing.Size(398, 26);
            this.txtTenLSP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Loại Sản Phẩm:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 45);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Loại Sản Phẩm:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 46);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mô Tả:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(269, 99);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(398, 26);
            this.txtMoTa.TabIndex = 2;
            // 
            // txtMaLSP
            // 
            this.txtMaLSP.Location = new System.Drawing.Point(269, 10);
            this.txtMaLSP.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.txtMaLSP.Name = "txtMaLSP";
            this.txtMaLSP.Size = new System.Drawing.Size(398, 26);
            this.txtMaLSP.TabIndex = 0;
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
            this.tableButton.Location = new System.Drawing.Point(104, 419);
            this.tableButton.Name = "tableButton";
            this.tableButton.RowCount = 1;
            this.tableButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableButton.Size = new System.Drawing.Size(672, 58);
            this.tableButton.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThoat.Location = new System.Drawing.Point(539, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(130, 52);
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
            this.btnLamMoi.Size = new System.Drawing.Size(128, 52);
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
            this.btnSua.Size = new System.Drawing.Size(128, 52);
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
            this.btnXoa.Size = new System.Drawing.Size(128, 52);
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
            this.btnThem.Size = new System.Drawing.Size(128, 52);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvLoaiSP
            // 
            this.dgvLoaiSP.AllowUserToAddRows = false;
            this.dgvLoaiSP.AllowUserToDeleteRows = false;
            this.dgvLoaiSP.AllowUserToResizeColumns = false;
            this.dgvLoaiSP.AllowUserToResizeRows = false;
            this.dgvLoaiSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoaiSP.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLoaiSP.Location = new System.Drawing.Point(3, 3);
            this.dgvLoaiSP.Name = "dgvLoaiSP";
            this.dgvLoaiSP.RowHeadersWidth = 51;
            this.dgvLoaiSP.RowTemplate.Height = 24;
            this.dgvLoaiSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiSP.Size = new System.Drawing.Size(907, 290);
            this.dgvLoaiSP.TabIndex = 0;
            this.dgvLoaiSP.Click += new System.EventHandler(this.dgvLoaiSP_Click);
            // 
            // tableDGVLoaiSanPham
            // 
            this.tableDGVLoaiSanPham.ColumnCount = 1;
            this.tableDGVLoaiSanPham.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDGVLoaiSanPham.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDGVLoaiSanPham.Controls.Add(this.dgvLoaiSP, 0, 0);
            this.tableDGVLoaiSanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableDGVLoaiSanPham.Location = new System.Drawing.Point(0, 585);
            this.tableDGVLoaiSanPham.Name = "tableDGVLoaiSanPham";
            this.tableDGVLoaiSanPham.RowCount = 1;
            this.tableDGVLoaiSanPham.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDGVLoaiSanPham.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 296F));
            this.tableDGVLoaiSanPham.Size = new System.Drawing.Size(913, 296);
            this.tableDGVLoaiSanPham.TabIndex = 6;
            // 
            // tableButton2
            // 
            this.tableButton2.ColumnCount = 1;
            this.tableButton2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButton2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableButton2.Controls.Add(this.btnTim, 0, 0);
            this.tableButton2.Location = new System.Drawing.Point(273, 483);
            this.tableButton2.Name = "tableButton2";
            this.tableButton2.RowCount = 1;
            this.tableButton2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButton2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableButton2.Size = new System.Drawing.Size(339, 80);
            this.tableButton2.TabIndex = 7;
            // 
            // btnTim
            // 
            this.btnTim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTim.Location = new System.Drawing.Point(3, 3);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(333, 74);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "Tìm Sản Phẩm Theo Tên Loại Sản Phẩm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // frmLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 881);
            this.ControlBox = false;
            this.Controls.Add(this.tableButton2);
            this.Controls.Add(this.tableDGVLoaiSanPham);
            this.Controls.Add(this.tableButton);
            this.Controls.Add(this.gbLoaiSP);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLoaiSanPham";
            this.Text = "frmLoaiSP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLoaiSP_FormClosing);
            this.Load += new System.EventHandler(this.frmLoaiSanPham_Load);
            this.gbLoaiSP.ResumeLayout(false);
            this.tableForm.ResumeLayout(false);
            this.tableForm.PerformLayout();
            this.tableButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSP)).EndInit();
            this.tableDGVLoaiSanPham.ResumeLayout(false);
            this.tableButton2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbLoaiSP;
        private System.Windows.Forms.TableLayoutPanel tableForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTenLSP;
        private System.Windows.Forms.TextBox txtMaLSP;
        private System.Windows.Forms.TableLayoutPanel tableButton;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvLoaiSP;
        private System.Windows.Forms.TableLayoutPanel tableDGVLoaiSanPham;
        private System.Windows.Forms.TableLayoutPanel tableButton2;
        private System.Windows.Forms.Button btnTim;
    }
}