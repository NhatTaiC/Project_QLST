/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 07/05/2024
 * frmInDSDH_TheoNgayBan.cs
 */
using BUS;
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
    public partial class frmInDSDH_TheoNgayBan : Form
    {
        public frmInDSDH_TheoNgayBan()
        {
            InitializeComponent();
        }

        // Initialize Variables
        BUS_DonHang bus_dh = new BUS_DonHang();

        // Function LoadData()
        public void LoadData()
        {
            // dtpNgayBan
            dtpNgayBan.Value = DateTime.Now;

            // crvDSDH_TheoTenNV
            crvDSDH_TheoNgayBan.ReportSource = null;
        }

        // Function Reset()
        public void Reset()
        {
            // Called LoadData()
            LoadData();
        }

        // frmInDSDH_TheoNgayBan_Load
        private void frmInDSDH_TheoNgayBan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // frmInDSDH_TheoNgayBan_FormClosing
        private void frmInDSDH_TheoNgayBan_FormClosing(object sender, FormClosingEventArgs e)
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
            if (bus_dh.TimDonHang_TheoNgayBan(dtpNgayBan.Value) >= 1)
            {
                // Khởi tạo đối tượng rpt
                DSDH_TheoNgayBan rpt = new DSDH_TheoNgayBan();

                // Khởi tạo ParameterValues
                ParameterValues para = new ParameterValues();

                // Khởi tạo ParameterDiscreteValue
                ParameterDiscreteValue val = new ParameterDiscreteValue();

                // Gán giá trị cho ParameterDiscreteValue
                val.Value = dtpNgayBan.Value.ToString();

                // Thêm val vào para
                para.Add(val);

                // Định nghĩa biến tham gia cho rpt
                rpt.DataDefinition.ParameterFields["@ngayBan"].ApplyCurrentValues(para);

                // Gọi rpt
                crvDSDH_TheoNgayBan.ReportSource = rpt; 
            }
            else
            {
                // Thông báo
                MessageBox.Show("Ngày bán không có trong Database!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
