/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 12/05/2024
 * frmInDH_TheoMaDon_KetQua.cs
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
    public partial class frmInDH_TheoMaDon_KetQua : Form
    {
        public frmInDH_TheoMaDon_KetQua()
        {
            InitializeComponent();
        }

        // Initialize Variables
        string maDon = string.Empty;

        public frmInDH_TheoMaDon_KetQua(string temp)
        {
            maDon = temp;
            InitializeComponent();
        }

        // frmInDH_TheoMaDon_KetQua_Load
        private void frmInDH_TheoMaDon_KetQua_Load(object sender, EventArgs e)
        {
            // Khởi tạo đối tượng rpt
            LayDH_TheoMaDon rpt = new LayDH_TheoMaDon();

            // Khởi tạo ParameterValues
            ParameterValues para = new ParameterValues();

            // Khởi tạo ParameterDiscreteValue
            ParameterDiscreteValue val = new ParameterDiscreteValue();

            // Gán giá trị cho ParameterDiscreteValue
            val.Value = maDon;

            // Thêm val vào para
            para.Add(val);

            // Định nghĩa biến tham gia cho rpt
            rpt.DataDefinition.ParameterFields["@maDon"].ApplyCurrentValues(para);

            // Gọi rpt
            crvInDH_TheoMaDon.ReportSource = rpt;
        }

        // frmInDH_TheoMaDon_KetQua_FormClosing
        private void frmInDH_TheoMaDon_KetQua_FormClosing(object sender, FormClosingEventArgs e)
        {
            maDon = string.Empty;
        }
    }
}
