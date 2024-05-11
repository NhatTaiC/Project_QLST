/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 07/05/2024
 * frmInDSDH_TheoNgayBan_KetQua.cs
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
    public partial class frmInDSDH_TheoNgayBan_KetQua : Form
    {
        public frmInDSDH_TheoNgayBan_KetQua()
        {
            InitializeComponent();
        }

        // Initialize Variables
        DateTime ngayBan = new DateTime();

        public frmInDSDH_TheoNgayBan_KetQua(DateTime temp)
        {
            ngayBan = temp;
            InitializeComponent();
        }

        // frmInDSDH_TheoNgayBan_KetQua_FormClosing
        private void frmInDSDH_TheoNgayBan_KetQua_FormClosing(object sender, FormClosingEventArgs e)
        {
            ngayBan = DateTime.Now;
        }

        // frmInDSDH_TheoNgayBan_KetQua_Load
        private void frmInDSDH_TheoNgayBan_KetQua_Load(object sender, EventArgs e)
        {

            // Khởi tạo đối tượng rpt
            DSDH_TheoNgayBan rpt = new DSDH_TheoNgayBan();

            // Khởi tạo ParameterValues
            ParameterValues para = new ParameterValues();

            // Khởi tạo ParameterDiscreteValue
            ParameterDiscreteValue val = new ParameterDiscreteValue();

            // Gán giá trị cho ParameterDiscreteValue
            val.Value = ngayBan.ToString();

            // Thêm val vào para
            para.Add(val);

            // Định nghĩa biến tham gia cho rpt
            rpt.DataDefinition.ParameterFields["@ngayBan"].ApplyCurrentValues(para);

            // Gọi rpt
            crvDSDH_TheoNgayBan.ReportSource = rpt;
        }
    }
}
