namespace QuanLySieuThi
{
    partial class frmTraCuuNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuNhanVien));
            this.label1 = new System.Windows.Forms.Label();
            this.tableForm = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.cboTraCuu = new System.Windows.Forms.ComboBox();
            this.tableDGVTraCuuNV = new System.Windows.Forms.TableLayoutPanel();
            this.dgvTraCuuNV = new System.Windows.Forms.DataGridView();
            this.tableButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.gbForm = new System.Windows.Forms.GroupBox();
            this.gbDGVTraCuuNV = new System.Windows.Forms.GroupBox();
            this.tableForm.SuspendLayout();
            this.tableDGVTraCuuNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuuNV)).BeginInit();
            this.tableButton.SuspendLayout();
            this.gbForm.SuspendLayout();
            this.gbDGVTraCuuNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tra Cứu Nhân Viên";
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
            this.tableForm.Location = new System.Drawing.Point(44, 49);
            this.tableForm.Name = "tableForm";
            this.tableForm.RowCount = 2;
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableForm.Size = new System.Drawing.Size(474, 129);
            this.tableForm.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 64);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập Nội Dung:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 65);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tra Cứu Theo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNoiDung.Location = new System.Drawing.Point(240, 20);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(3, 20, 3, 10);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(231, 26);
            this.txtNoiDung.TabIndex = 0;
            // 
            // cboTraCuu
            // 
            this.cboTraCuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboTraCuu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTraCuu.FormattingEnabled = true;
            this.cboTraCuu.Items.AddRange(new object[] {
            "Tên Nhân Viên",
            "Mã Nhân Viên",
            "Giới Tính Nhân Viên",
            "Năm Sinh Nhân Viên"});
            this.cboTraCuu.Location = new System.Drawing.Point(240, 84);
            this.cboTraCuu.Margin = new System.Windows.Forms.Padding(3, 20, 3, 10);
            this.cboTraCuu.Name = "cboTraCuu";
            this.cboTraCuu.Size = new System.Drawing.Size(231, 26);
            this.cboTraCuu.TabIndex = 1;
            // 
            // tableDGVTraCuuNV
            // 
            this.tableDGVTraCuuNV.ColumnCount = 1;
            this.tableDGVTraCuuNV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDGVTraCuuNV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDGVTraCuuNV.Controls.Add(this.dgvTraCuuNV, 0, 0);
            this.tableDGVTraCuuNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDGVTraCuuNV.Location = new System.Drawing.Point(3, 22);
            this.tableDGVTraCuuNV.Name = "tableDGVTraCuuNV";
            this.tableDGVTraCuuNV.RowCount = 1;
            this.tableDGVTraCuuNV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDGVTraCuuNV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableDGVTraCuuNV.Size = new System.Drawing.Size(716, 174);
            this.tableDGVTraCuuNV.TabIndex = 2;
            // 
            // dgvTraCuuNV
            // 
            this.dgvTraCuuNV.AllowUserToAddRows = false;
            this.dgvTraCuuNV.AllowUserToDeleteRows = false;
            this.dgvTraCuuNV.AllowUserToResizeColumns = false;
            this.dgvTraCuuNV.AllowUserToResizeRows = false;
            this.dgvTraCuuNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTraCuuNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraCuuNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTraCuuNV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTraCuuNV.Location = new System.Drawing.Point(3, 3);
            this.dgvTraCuuNV.Name = "dgvTraCuuNV";
            this.dgvTraCuuNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTraCuuNV.Size = new System.Drawing.Size(710, 168);
            this.dgvTraCuuNV.TabIndex = 0;
            // 
            // tableButton
            // 
            this.tableButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableButton.ColumnCount = 3;
            this.tableButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableButton.Controls.Add(this.btnLamMoi, 1, 0);
            this.tableButton.Controls.Add(this.btnTraCuu, 0, 0);
            this.tableButton.Controls.Add(this.btnThoat, 2, 0);
            this.tableButton.Location = new System.Drawing.Point(112, 335);
            this.tableButton.Name = "tableButton";
            this.tableButton.RowCount = 1;
            this.tableButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButton.Size = new System.Drawing.Size(474, 65);
            this.tableButton.TabIndex = 3;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLamMoi.Image = global::QuanLySieuThi.Properties.Resources.reset;
            this.btnLamMoi.Location = new System.Drawing.Point(161, 3);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(152, 59);
            this.btnLamMoi.TabIndex = 1;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTraCuu.Image = global::QuanLySieuThi.Properties.Resources.research1;
            this.btnTraCuu.Location = new System.Drawing.Point(3, 3);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(152, 59);
            this.btnTraCuu.TabIndex = 0;
            this.btnTraCuu.Text = "Tra Cứu";
            this.btnTraCuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThoat.Image = global::QuanLySieuThi.Properties.Resources.logout;
            this.btnThoat.Location = new System.Drawing.Point(319, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(152, 59);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // gbForm
            // 
            this.gbForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbForm.Controls.Add(this.tableForm);
            this.gbForm.Location = new System.Drawing.Point(71, 84);
            this.gbForm.Name = "gbForm";
            this.gbForm.Size = new System.Drawing.Size(573, 222);
            this.gbForm.TabIndex = 4;
            this.gbForm.TabStop = false;
            this.gbForm.Text = "Thông Tin Tra Cứu";
            // 
            // gbDGVTraCuuNV
            // 
            this.gbDGVTraCuuNV.Controls.Add(this.tableDGVTraCuuNV);
            this.gbDGVTraCuuNV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbDGVTraCuuNV.Location = new System.Drawing.Point(0, 424);
            this.gbDGVTraCuuNV.Name = "gbDGVTraCuuNV";
            this.gbDGVTraCuuNV.Size = new System.Drawing.Size(722, 199);
            this.gbDGVTraCuuNV.TabIndex = 5;
            this.gbDGVTraCuuNV.TabStop = false;
            this.gbDGVTraCuuNV.Text = "Kết Quả Tra Cứu:";
            // 
            // frmTraCuuNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 623);
            this.ControlBox = false;
            this.Controls.Add(this.gbDGVTraCuuNV);
            this.Controls.Add(this.gbForm);
            this.Controls.Add(this.tableButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTraCuuNhanVien";
            this.Text = "frmTraCuuNhanVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTraCuuNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.frmTraCuuNhanVien_Load);
            this.tableForm.ResumeLayout(false);
            this.tableForm.PerformLayout();
            this.tableDGVTraCuuNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuuNV)).EndInit();
            this.tableButton.ResumeLayout(false);
            this.gbForm.ResumeLayout(false);
            this.gbDGVTraCuuNV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.ComboBox cboTraCuu;
        private System.Windows.Forms.TableLayoutPanel tableDGVTraCuuNV;
        private System.Windows.Forms.DataGridView dgvTraCuuNV;
        private System.Windows.Forms.TableLayoutPanel tableButton;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.GroupBox gbForm;
        private System.Windows.Forms.GroupBox gbDGVTraCuuNV;
        private System.Windows.Forms.Button btnThoat;
    }
}