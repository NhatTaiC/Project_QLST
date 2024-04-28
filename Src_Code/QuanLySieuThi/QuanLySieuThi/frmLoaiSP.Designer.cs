namespace QuanLySieuThi
{
    partial class frmLoaiSP
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
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.tableButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvLoaiSP = new System.Windows.Forms.DataGridView();
            this.gbLoaiSP.SuspendLayout();
            this.tableForm.SuspendLayout();
            this.tableButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Loại Sản Phẩm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbLoaiSP
            // 
            this.gbLoaiSP.Controls.Add(this.tableForm);
            this.gbLoaiSP.Location = new System.Drawing.Point(257, 168);
            this.gbLoaiSP.Name = "gbLoaiSP";
            this.gbLoaiSP.Size = new System.Drawing.Size(654, 229);
            this.gbLoaiSP.TabIndex = 3;
            this.gbLoaiSP.TabStop = false;
            this.gbLoaiSP.Text = "Thông Tin Loại Sản Phẩm";
            // 
            // tableForm
            // 
            this.tableForm.ColumnCount = 2;
            this.tableForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.70286F));
            this.tableForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.29714F));
            this.tableForm.Controls.Add(this.txtTenSP, 1, 1);
            this.tableForm.Controls.Add(this.label2, 0, 0);
            this.tableForm.Controls.Add(this.label3, 0, 1);
            this.tableForm.Controls.Add(this.label4, 0, 2);
            this.tableForm.Controls.Add(this.txtMoTa, 1, 2);
            this.tableForm.Controls.Add(this.txtMaSP, 1, 0);
            this.tableForm.Location = new System.Drawing.Point(26, 42);
            this.tableForm.Name = "tableForm";
            this.tableForm.RowCount = 3;
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableForm.Size = new System.Drawing.Size(598, 163);
            this.tableForm.TabIndex = 1;
            this.tableForm.Paint += new System.Windows.Forms.PaintEventHandler(this.tableForm_Paint);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(240, 57);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(355, 22);
            this.txtTenSP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Loại Sản Phẩm:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 54);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Loại Sản Phẩm:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 55);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mô Tả:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(240, 111);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(355, 22);
            this.txtMoTa.TabIndex = 2;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(240, 3);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(355, 22);
            this.txtMaSP.TabIndex = 0;
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
            this.tableButton.Location = new System.Drawing.Point(283, 422);
            this.tableButton.Name = "tableButton";
            this.tableButton.RowCount = 1;
            this.tableButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableButton.Size = new System.Drawing.Size(598, 52);
            this.tableButton.TabIndex = 4;
            this.tableButton.Paint += new System.Windows.Forms.PaintEventHandler(this.tableButton_Paint);
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThoat.Location = new System.Drawing.Point(479, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 46);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLamMoi.Location = new System.Drawing.Point(360, 3);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(113, 46);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua.Location = new System.Drawing.Point(241, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(113, 46);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.Location = new System.Drawing.Point(122, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 46);
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
            this.btnThem.Size = new System.Drawing.Size(113, 46);
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
            this.dgvLoaiSP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLoaiSP.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLoaiSP.Location = new System.Drawing.Point(0, 519);
            this.dgvLoaiSP.Name = "dgvLoaiSP";
            this.dgvLoaiSP.RowHeadersWidth = 51;
            this.dgvLoaiSP.RowTemplate.Height = 24;
            this.dgvLoaiSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiSP.Size = new System.Drawing.Size(1200, 280);
            this.dgvLoaiSP.TabIndex = 5;
            this.dgvLoaiSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiSP_CellContentClick);
            this.dgvLoaiSP.Click += new System.EventHandler(this.dgvLoaiSP_Click);
            // 
            // frmLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 799);
            this.Controls.Add(this.dgvLoaiSP);
            this.Controls.Add(this.tableButton);
            this.Controls.Add(this.gbLoaiSP);
            this.Controls.Add(this.label1);
            this.Name = "frmLoaiSP";
            this.Text = "frmLoaiSP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLoaiSP_FormClosing);
            this.Load += new System.EventHandler(this.frmLoaiSP_Load);
            this.gbLoaiSP.ResumeLayout(false);
            this.tableForm.ResumeLayout(false);
            this.tableForm.PerformLayout();
            this.tableButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSP)).EndInit();
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
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TableLayoutPanel tableButton;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvLoaiSP;
    }
}