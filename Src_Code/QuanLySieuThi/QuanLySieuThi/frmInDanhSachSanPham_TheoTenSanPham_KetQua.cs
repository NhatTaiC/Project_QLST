/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 07/05/2024
 * frmInDanhSachSanPham_TheoTenSanPham_KetQua.cs
 */
using CrystalDecisions.Shared;
using QuanLySieuThi.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi
{
    public partial class frmInDanhSachSanPham_TheoTenSanPham_KetQua : Form
    {
        public frmInDanhSachSanPham_TheoTenSanPham_KetQua()
        {
            InitializeComponent();
        }

        // Initialize Variables
        string tenSP = string.Empty;

        public frmInDanhSachSanPham_TheoTenSanPham_KetQua(string temp)
        {
            tenSP = temp;
            InitializeComponent();
        }

        // frmInDanhSachSanPham_TheoTenSanPham_KetQua_Load
        private void frmInDanhSachSanPham_TheoTenSanPham_KetQua_Load(object sender, EventArgs e)
        {
            // Khởi tạo đối tượng rpt
            DSSP_TheoTenSanPham rpt = new DSSP_TheoTenSanPham();

            // Khởi tạo ParameterValues
            ParameterValues para = new ParameterValues();

            // Khởi tạo ParameterDiscreteValue
            ParameterDiscreteValue val = new ParameterDiscreteValue();

            // Gán giá trị cho ParameterDiscreteValue
            val.Value = tenSP;

            // Thêm val vào para
            para.Add(val);

            // Định nghĩa biến tham gia cho rpt
            rpt.DataDefinition.ParameterFields["@tenSP"].ApplyCurrentValues(para);

            // Gọi rpt
            crvDSSP_TheoTenSP.ReportSource = rpt;
        }

        // frmInDanhSachSanPham_TheoTenSanPham_KetQua_FormClosing
        private void frmInDanhSachSanPham_TheoTenSanPham_KetQua_FormClosing(object sender, FormClosingEventArgs e)
        {
            tenSP = string.Empty;
        }
    }
}
