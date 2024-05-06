/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 07/05/2024
 * frmInDanhSachSanPham_TheoTenSanPham.cs
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using QuanLySieuThi.Report;

namespace QuanLySieuThi
{
    public partial class frmInDanhSachSanPham_TheoTenSanPham : Form
    {
        public frmInDanhSachSanPham_TheoTenSanPham()
        {
            InitializeComponent();
        }

        // Function LoadData()
        public void LoadData() { 
            // txtTenSanPham
            txtTenSanPham.Focus();

            // crvDSSP_TheoTenSP
            crvDSSP_TheoTenSP.ReportSource = null;
        }

        // Function Reset()
        public void Reset() {
            // Reset Text
            txtTenSanPham.Text = string.Empty;

            // Called LoadData()
            LoadData();
        }

        // frmInDanhSachSanPham_TheoTenSanPham_Load
        private void frmInDanhSachSanPham_TheoTenSanPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // frmInDanhSachSanPham_TheoTenSanPham_FormClosing
        private void frmInDanhSachSanPham_TheoTenSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        // btnThoat_Click
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // btnLamMoi_Click
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Reset();
        }

        // btnIn_Click
        private void btnIn_Click(object sender, EventArgs e)
        {
            // Khởi tạo đối tượng rpt
            DSSP_TheoTenSanPham rpt = new DSSP_TheoTenSanPham();

            // Khởi tạo ParameterValues
            ParameterValues para = new ParameterValues();

            // Khởi tạo ParameterDiscreteValue
            ParameterDiscreteValue val = new ParameterDiscreteValue();

            // Gán giá trị cho ParameterDiscreteValue
            val.Value = txtTenSanPham.Text;

            // Thêm val vào para
            para.Add(val);

            // Định nghĩa biến tham gia cho rpt
            rpt.DataDefinition.ParameterFields["@tenSP"].ApplyCurrentValues(para);

            // Gọi rpt
            crvDSSP_TheoTenSP.ReportSource = rpt;
        }
    }
}
