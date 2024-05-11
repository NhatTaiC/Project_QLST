namespace QuanLySieuThi
{
    partial class frmInDH_TheoMaDon_KetQua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInDH_TheoMaDon_KetQua));
            this.tableReport = new System.Windows.Forms.TableLayoutPanel();
            this.crvInDH_TheoMaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tableReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableReport
            // 
            this.tableReport.ColumnCount = 1;
            this.tableReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableReport.Controls.Add(this.crvInDH_TheoMaDon, 0, 0);
            this.tableReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableReport.Location = new System.Drawing.Point(0, 0);
            this.tableReport.Name = "tableReport";
            this.tableReport.RowCount = 1;
            this.tableReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableReport.Size = new System.Drawing.Size(1200, 623);
            this.tableReport.TabIndex = 0;
            // 
            // crvInDH_TheoMaDon
            // 
            this.crvInDH_TheoMaDon.ActiveViewIndex = -1;
            this.crvInDH_TheoMaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvInDH_TheoMaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvInDH_TheoMaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvInDH_TheoMaDon.Location = new System.Drawing.Point(3, 3);
            this.crvInDH_TheoMaDon.Name = "crvInDH_TheoMaDon";
            this.crvInDH_TheoMaDon.Size = new System.Drawing.Size(1194, 617);
            this.crvInDH_TheoMaDon.TabIndex = 0;
            // 
            // frmInDH_TheoMaDon_KetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.tableReport);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInDH_TheoMaDon_KetQua";
            this.Text = "frmInDH_TheoMaDon_KetQua";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInDH_TheoMaDon_KetQua_FormClosing);
            this.Load += new System.EventHandler(this.frmInDH_TheoMaDon_KetQua_Load);
            this.tableReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableReport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvInDH_TheoMaDon;
    }
}