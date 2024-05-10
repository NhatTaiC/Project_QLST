namespace QuanLySieuThi
{
    partial class frmTraCuuSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuSanPham));
            this.label1 = new System.Windows.Forms.Label();
            this.tableForm = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.cboTraCuu = new System.Windows.Forms.ComboBox();
            this.tableButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.tableDGVTraCuuSanPham = new System.Windows.Forms.TableLayoutPanel();
            this.dgvTraCuuSanPham = new System.Windows.Forms.DataGridView();
            this.gbForm = new System.Windows.Forms.GroupBox();
            this.gbDGVTraCuuSanPham = new System.Windows.Forms.GroupBox();
            this.tableForm.SuspendLayout();
            this.tableButton.SuspendLayout();
            this.tableDGVTraCuuSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuuSanPham)).BeginInit();
            this.gbForm.SuspendLayout();
            this.gbDGVTraCuuSanPham.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(723, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tra Cứu Sản Phẩm";
            // 
            // tableForm
            // 
            this.tableForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableForm.ColumnCount = 2;
            this.tableForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableForm.Controls.Add(this.label2, 0, 0);
            this.tableForm.Controls.Add(this.label3, 0, 1);
            this.tableForm.Controls.Add(this.txtNoiDung, 1, 0);
            this.tableForm.Controls.Add(this.cboTraCuu, 1, 1);
            this.tableForm.Location = new System.Drawing.Point(28, 49);
            this.tableForm.Name = "tableForm";
            this.tableForm.RowCount = 2;
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableForm.Size = new System.Drawing.Size(516, 139);
            this.tableForm.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 69);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập Nội Dung:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 70);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tra Cứu Theo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNoiDung.Location = new System.Drawing.Point(261, 25);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(3, 25, 3, 25);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(252, 44);
            this.txtNoiDung.TabIndex = 2;
            // 
            // cboTraCuu
            // 
            this.cboTraCuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboTraCuu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTraCuu.FormattingEnabled = true;
            this.cboTraCuu.Items.AddRange(new object[] {
            "Tên Sản Phẩm",
            "Mã Sản Phẩm",
            "Giá Bán Sản Phẩm",
            "Đơn Vị Tính Sản Phẩm"});
            this.cboTraCuu.Location = new System.Drawing.Point(261, 94);
            this.cboTraCuu.Margin = new System.Windows.Forms.Padding(3, 25, 3, 25);
            this.cboTraCuu.Name = "cboTraCuu";
            this.cboTraCuu.Size = new System.Drawing.Size(252, 44);
            this.cboTraCuu.TabIndex = 3;
            // 
            // tableButton
            // 
            this.tableButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableButton.ColumnCount = 3;
            this.tableButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableButton.Controls.Add(this.btnThoat, 2, 0);
            this.tableButton.Controls.Add(this.btnLamMoi, 1, 0);
            this.tableButton.Controls.Add(this.btnTim, 0, 0);
            this.tableButton.Location = new System.Drawing.Point(225, 362);
            this.tableButton.Name = "tableButton";
            this.tableButton.RowCount = 1;
            this.tableButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableButton.Size = new System.Drawing.Size(316, 52);
            this.tableButton.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThoat.Image = global::QuanLySieuThi.Properties.Resources.logout;
            this.btnThoat.Location = new System.Drawing.Point(213, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 46);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLamMoi.Image = global::QuanLySieuThi.Properties.Resources.reset;
            this.btnLamMoi.Location = new System.Drawing.Point(108, 3);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(99, 46);
            this.btnLamMoi.TabIndex = 1;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTim
            // 
            this.btnTim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTim.Image = global::QuanLySieuThi.Properties.Resources.research1;
            this.btnTim.Location = new System.Drawing.Point(3, 3);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(99, 46);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "Tra Cứu";
            this.btnTim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // tableDGVTraCuuSanPham
            // 
            this.tableDGVTraCuuSanPham.ColumnCount = 1;
            this.tableDGVTraCuuSanPham.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDGVTraCuuSanPham.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDGVTraCuuSanPham.Controls.Add(this.dgvTraCuuSanPham, 0, 0);
            this.tableDGVTraCuuSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDGVTraCuuSanPham.Location = new System.Drawing.Point(3, 40);
            this.tableDGVTraCuuSanPham.Name = "tableDGVTraCuuSanPham";
            this.tableDGVTraCuuSanPham.RowCount = 1;
            this.tableDGVTraCuuSanPham.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDGVTraCuuSanPham.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableDGVTraCuuSanPham.Size = new System.Drawing.Size(758, 127);
            this.tableDGVTraCuuSanPham.TabIndex = 3;
            // 
            // dgvTraCuuSanPham
            // 
            this.dgvTraCuuSanPham.AllowUserToAddRows = false;
            this.dgvTraCuuSanPham.AllowUserToDeleteRows = false;
            this.dgvTraCuuSanPham.AllowUserToResizeColumns = false;
            this.dgvTraCuuSanPham.AllowUserToResizeRows = false;
            this.dgvTraCuuSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTraCuuSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraCuuSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTraCuuSanPham.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTraCuuSanPham.Location = new System.Drawing.Point(3, 3);
            this.dgvTraCuuSanPham.Name = "dgvTraCuuSanPham";
            this.dgvTraCuuSanPham.RowHeadersWidth = 82;
            this.dgvTraCuuSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTraCuuSanPham.Size = new System.Drawing.Size(752, 121);
            this.dgvTraCuuSanPham.TabIndex = 0;
            // 
            // gbForm
            // 
            this.gbForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbForm.Controls.Add(this.tableForm);
            this.gbForm.Location = new System.Drawing.Point(85, 120);
            this.gbForm.Name = "gbForm";
            this.gbForm.Size = new System.Drawing.Size(580, 216);
            this.gbForm.TabIndex = 4;
            this.gbForm.TabStop = false;
            this.gbForm.Text = "Thông Tin Tra Cứu";
            // 
            // gbDGVTraCuuSanPham
            // 
            this.gbDGVTraCuuSanPham.Controls.Add(this.tableDGVTraCuuSanPham);
            this.gbDGVTraCuuSanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbDGVTraCuuSanPham.Location = new System.Drawing.Point(0, 453);
            this.gbDGVTraCuuSanPham.Name = "gbDGVTraCuuSanPham";
            this.gbDGVTraCuuSanPham.Size = new System.Drawing.Size(764, 170);
            this.gbDGVTraCuuSanPham.TabIndex = 5;
            this.gbDGVTraCuuSanPham.TabStop = false;
            this.gbDGVTraCuuSanPham.Text = "Kết Quả Tra Cứu:";
            // 
            // frmTraCuuSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 623);
            this.ControlBox = false;
            this.Controls.Add(this.gbDGVTraCuuSanPham);
            this.Controls.Add(this.gbForm);
            this.Controls.Add(this.tableButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTraCuuSanPham";
            this.Text = "frmTraCuuSanPham";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTraCuuSanPham_FormClosing);
            this.Load += new System.EventHandler(this.frmTraCuuSanPham_Load);
            this.tableForm.ResumeLayout(false);
            this.tableForm.PerformLayout();
            this.tableButton.ResumeLayout(false);
            this.tableDGVTraCuuSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuuSanPham)).EndInit();
            this.gbForm.ResumeLayout(false);
            this.gbDGVTraCuuSanPham.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableForm;
        private System.Windows.Forms.TableLayoutPanel tableButton;
        private System.Windows.Forms.TableLayoutPanel tableDGVTraCuuSanPham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.ComboBox cboTraCuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvTraCuuSanPham;
        private System.Windows.Forms.GroupBox gbForm;
        private System.Windows.Forms.GroupBox gbDGVTraCuuSanPham;
    }
}