namespace QuanLySieuThi
{
    partial class frmTraCuuDonHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuDonHang));
            this.label1 = new System.Windows.Forms.Label();
            this.tableForm = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.cboTraCuu = new System.Windows.Forms.ComboBox();
            this.tableDGVTraCuuDonHang = new System.Windows.Forms.TableLayoutPanel();
            this.dgvTraCuuDonHang = new System.Windows.Forms.DataGridView();
            this.gbForm = new System.Windows.Forms.GroupBox();
            this.gbDGVTraCuuDonHang = new System.Windows.Forms.GroupBox();
            this.tableButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.tableForm.SuspendLayout();
            this.tableDGVTraCuuDonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuuDonHang)).BeginInit();
            this.gbForm.SuspendLayout();
            this.gbDGVTraCuuDonHang.SuspendLayout();
            this.tableButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tra Cứu Đơn Hàng";
            // 
            // tableForm
            // 
            this.tableForm.ColumnCount = 2;
            this.tableForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableForm.Controls.Add(this.label2, 0, 0);
            this.tableForm.Controls.Add(this.label3, 0, 1);
            this.tableForm.Controls.Add(this.txtNoiDung, 1, 0);
            this.tableForm.Controls.Add(this.cboTraCuu, 1, 1);
            this.tableForm.Location = new System.Drawing.Point(51, 47);
            this.tableForm.Name = "tableForm";
            this.tableForm.RowCount = 2;
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableForm.Size = new System.Drawing.Size(527, 138);
            this.tableForm.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 69);
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
            this.label3.Size = new System.Drawing.Size(257, 69);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tra Cứu Theo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNoiDung.Location = new System.Drawing.Point(266, 20);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(258, 26);
            this.txtNoiDung.TabIndex = 0;
            // 
            // cboTraCuu
            // 
            this.cboTraCuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboTraCuu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTraCuu.FormattingEnabled = true;
            this.cboTraCuu.Items.AddRange(new object[] {
            "Mã Đơn Hàng",
            "Mã Nhân Viên",
            "Tên Nhân Viên"});
            this.cboTraCuu.Location = new System.Drawing.Point(266, 89);
            this.cboTraCuu.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.cboTraCuu.Name = "cboTraCuu";
            this.cboTraCuu.Size = new System.Drawing.Size(258, 26);
            this.cboTraCuu.TabIndex = 1;
            // 
            // tableDGVTraCuuDonHang
            // 
            this.tableDGVTraCuuDonHang.ColumnCount = 1;
            this.tableDGVTraCuuDonHang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDGVTraCuuDonHang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDGVTraCuuDonHang.Controls.Add(this.dgvTraCuuDonHang, 0, 0);
            this.tableDGVTraCuuDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDGVTraCuuDonHang.Location = new System.Drawing.Point(3, 22);
            this.tableDGVTraCuuDonHang.Name = "tableDGVTraCuuDonHang";
            this.tableDGVTraCuuDonHang.RowCount = 1;
            this.tableDGVTraCuuDonHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDGVTraCuuDonHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableDGVTraCuuDonHang.Size = new System.Drawing.Size(820, 124);
            this.tableDGVTraCuuDonHang.TabIndex = 3;
            // 
            // dgvTraCuuDonHang
            // 
            this.dgvTraCuuDonHang.AllowUserToAddRows = false;
            this.dgvTraCuuDonHang.AllowUserToDeleteRows = false;
            this.dgvTraCuuDonHang.AllowUserToResizeColumns = false;
            this.dgvTraCuuDonHang.AllowUserToResizeRows = false;
            this.dgvTraCuuDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTraCuuDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraCuuDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTraCuuDonHang.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTraCuuDonHang.Location = new System.Drawing.Point(3, 3);
            this.dgvTraCuuDonHang.Name = "dgvTraCuuDonHang";
            this.dgvTraCuuDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTraCuuDonHang.Size = new System.Drawing.Size(814, 118);
            this.dgvTraCuuDonHang.TabIndex = 0;
            // 
            // gbForm
            // 
            this.gbForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbForm.Controls.Add(this.tableForm);
            this.gbForm.Location = new System.Drawing.Point(75, 122);
            this.gbForm.Name = "gbForm";
            this.gbForm.Size = new System.Drawing.Size(641, 227);
            this.gbForm.TabIndex = 4;
            this.gbForm.TabStop = false;
            this.gbForm.Text = "Thông Tin Tra Cứu";
            // 
            // gbDGVTraCuuDonHang
            // 
            this.gbDGVTraCuuDonHang.Controls.Add(this.tableDGVTraCuuDonHang);
            this.gbDGVTraCuuDonHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbDGVTraCuuDonHang.Location = new System.Drawing.Point(0, 474);
            this.gbDGVTraCuuDonHang.Name = "gbDGVTraCuuDonHang";
            this.gbDGVTraCuuDonHang.Size = new System.Drawing.Size(826, 149);
            this.gbDGVTraCuuDonHang.TabIndex = 5;
            this.gbDGVTraCuuDonHang.TabStop = false;
            this.gbDGVTraCuuDonHang.Text = "Kết Quả Tra Cứu:";
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
            this.tableButton.Controls.Add(this.btnTraCuu, 0, 0);
            this.tableButton.Location = new System.Drawing.Point(100, 381);
            this.tableButton.Name = "tableButton";
            this.tableButton.RowCount = 1;
            this.tableButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableButton.Size = new System.Drawing.Size(569, 64);
            this.tableButton.TabIndex = 6;
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThoat.Image = global::QuanLySieuThi.Properties.Resources.logout;
            this.btnThoat.Location = new System.Drawing.Point(381, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(185, 58);
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
            this.btnLamMoi.Location = new System.Drawing.Point(192, 3);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(183, 58);
            this.btnLamMoi.TabIndex = 1;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTraCuu.Image = ((System.Drawing.Image)(resources.GetObject("btnTraCuu.Image")));
            this.btnTraCuu.Location = new System.Drawing.Point(3, 3);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(183, 58);
            this.btnTraCuu.TabIndex = 0;
            this.btnTraCuu.Text = "Tra Cứu";
            this.btnTraCuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // frmTraCuuDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 623);
            this.ControlBox = false;
            this.Controls.Add(this.tableButton);
            this.Controls.Add(this.gbDGVTraCuuDonHang);
            this.Controls.Add(this.gbForm);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTraCuuDonHang";
            this.Text = "frmTraCuuDonHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTraCuuDonHang_FormClosing);
            this.Load += new System.EventHandler(this.frmTraCuuDonHang_Load);
            this.tableForm.ResumeLayout(false);
            this.tableForm.PerformLayout();
            this.tableDGVTraCuuDonHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuuDonHang)).EndInit();
            this.gbForm.ResumeLayout(false);
            this.gbDGVTraCuuDonHang.ResumeLayout(false);
            this.tableButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TableLayoutPanel tableDGVTraCuuDonHang;
        private System.Windows.Forms.DataGridView dgvTraCuuDonHang;
        private System.Windows.Forms.GroupBox gbForm;
        private System.Windows.Forms.GroupBox gbDGVTraCuuDonHang;
        private System.Windows.Forms.ComboBox cboTraCuu;
        private System.Windows.Forms.TableLayoutPanel tableButton;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTraCuu;
    }
}