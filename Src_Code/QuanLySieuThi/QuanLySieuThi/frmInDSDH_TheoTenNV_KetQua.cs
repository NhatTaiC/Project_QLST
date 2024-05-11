/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 07/05/2024
 * frmInDSDH_TheoTenNV_KetQua.cs
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
    public partial class frmInDSDH_TheoTenNV_KetQua : Form
    {
        public frmInDSDH_TheoTenNV_KetQua()
        {
            InitializeComponent();
        }

        // Initialize Variables
        string tenNV = string.Empty;

        public frmInDSDH_TheoTenNV_KetQua(string temp)
        {
            tenNV = temp;
            InitializeComponent();
        }

        // frmInDSDH_TheoTenNV_KetQua_Load
        private void frmInDSDH_TheoTenNV_KetQua_Load(object sender, EventArgs e)
        {
            // Khởi tạo đối tượng rpt
            DSDH_TheoTenNV rpt = new DSDH_TheoTenNV();

            // Khởi tạo ParameterValues
            ParameterValues para = new ParameterValues();

            // Khởi tạo ParameterDiscreteValue
            ParameterDiscreteValue val = new ParameterDiscreteValue();

            // Gán giá trị cho ParameterDiscreteValue
            val.Value = tenNV;

            // Thêm val vào para
            para.Add(val);

            // Định nghĩa biến tham gia cho rpt
            rpt.DataDefinition.ParameterFields["@tenNV"].ApplyCurrentValues(para);

            // Gọi rpt
            crvDSDH_TheoTenNV.ReportSource = rpt;
        }

        // frmInDSDH_TheoTenNV_KetQua_FormClosing
        private void frmInDSDH_TheoTenNV_KetQua_FormClosing(object sender, FormClosingEventArgs e)
        {
            tenNV = string.Empty;
        }
    }
}
