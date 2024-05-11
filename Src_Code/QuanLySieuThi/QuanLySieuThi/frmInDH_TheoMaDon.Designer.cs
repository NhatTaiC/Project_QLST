namespace QuanLySieuThi
{
    partial class frmInDH_TheoMaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInDH_TheoMaDon));
            this.label1 = new System.Windows.Forms.Label();
            this.tableForm = new System.Windows.Forms.TableLayoutPanel();
            this.tableButton = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDon = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tableForm.SuspendLayout();
            this.tableButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "In Hóa Đơn Theo Mã Đơn Hàng";
            // 
            // tableForm
            // 
            this.tableForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableForm.ColumnCount = 2;
            this.tableForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableForm.Controls.Add(this.label2, 0, 0);
            this.tableForm.Controls.Add(this.txtMaDon, 1, 0);
            this.tableForm.Location = new System.Drawing.Point(124, 147);
            this.tableForm.Name = "tableForm";
            this.tableForm.RowCount = 1;
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableForm.Size = new System.Drawing.Size(589, 83);
            this.tableForm.TabIndex = 1;
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
            this.tableButton.Controls.Add(this.btnIn, 0, 0);
            this.tableButton.Location = new System.Drawing.Point(130, 293);
            this.tableButton.Name = "tableButton";
            this.tableButton.RowCount = 1;
            this.tableButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableButton.Size = new System.Drawing.Size(583, 66);
            this.tableButton.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 83);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập Mã Đơn Hàng:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaDon
            // 
            this.txtMaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaDon.Location = new System.Drawing.Point(297, 30);
            this.txtMaDon.Margin = new System.Windows.Forms.Padding(3, 30, 3, 30);
            this.txtMaDon.Name = "txtMaDon";
            this.txtMaDon.Size = new System.Drawing.Size(289, 26);
            this.txtMaDon.TabIndex = 0;
            // 
            // btnIn
            // 
            this.btnIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIn.Image = global::QuanLySieuThi.Properties.Resources.printer;
            this.btnIn.Location = new System.Drawing.Point(3, 3);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(188, 60);
            this.btnIn.TabIndex = 0;
            this.btnIn.Text = "In";
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLamMoi.Image = global::QuanLySieuThi.Properties.Resources.loop;
            this.btnLamMoi.Location = new System.Drawing.Point(197, 3);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(188, 60);
            this.btnLamMoi.TabIndex = 1;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThoat.Image = global::QuanLySieuThi.Properties.Resources.logout;
            this.btnThoat.Location = new System.Drawing.Point(391, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(189, 60);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmInDH_TheoMaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 411);
            this.ControlBox = false;
            this.Controls.Add(this.tableButton);
            this.Controls.Add(this.tableForm);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInDH_TheoMaDon";
            this.Text = "frmLayDH_TheoMaDon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInDH_TheoMaDon_FormClosing);
            this.Load += new System.EventHandler(this.frmInDH_TheoMaDon_Load);
            this.tableForm.ResumeLayout(false);
            this.tableForm.PerformLayout();
            this.tableButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableForm;
        private System.Windows.Forms.TableLayoutPanel tableButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaDon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnIn;
    }
}