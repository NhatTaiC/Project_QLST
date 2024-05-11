namespace QuanLySieuThi
{
    partial class frmInDSDH_TheoTenNV_KetQua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInDSDH_TheoTenNV_KetQua));
            this.tableReport = new System.Windows.Forms.TableLayoutPanel();
            this.crvDSDH_TheoTenNV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tableReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableReport
            // 
            this.tableReport.ColumnCount = 1;
            this.tableReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableReport.Controls.Add(this.crvDSDH_TheoTenNV, 0, 0);
            this.tableReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableReport.Location = new System.Drawing.Point(0, 0);
            this.tableReport.Name = "tableReport";
            this.tableReport.RowCount = 1;
            this.tableReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableReport.Size = new System.Drawing.Size(1200, 623);
            this.tableReport.TabIndex = 0;
            // 
            // crvDSDH_TheoTenNV
            // 
            this.crvDSDH_TheoTenNV.ActiveViewIndex = -1;
            this.crvDSDH_TheoTenNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvDSDH_TheoTenNV.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvDSDH_TheoTenNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvDSDH_TheoTenNV.Location = new System.Drawing.Point(3, 3);
            this.crvDSDH_TheoTenNV.Name = "crvDSDH_TheoTenNV";
            this.crvDSDH_TheoTenNV.Size = new System.Drawing.Size(1194, 617);
            this.crvDSDH_TheoTenNV.TabIndex = 0;
            // 
            // frmInDSDH_TheoTenNV_KetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.tableReport);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInDSDH_TheoTenNV_KetQua";
            this.Text = "frmInDSDH_TheoTenNV_KetQua";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInDSDH_TheoTenNV_KetQua_FormClosing);
            this.Load += new System.EventHandler(this.frmInDSDH_TheoTenNV_KetQua_Load);
            this.tableReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableReport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvDSDH_TheoTenNV;
    }
}