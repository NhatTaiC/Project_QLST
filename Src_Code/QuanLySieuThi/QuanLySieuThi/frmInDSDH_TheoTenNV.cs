/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 07/05/2024
 * frmInDSDH_TheoTenNV.cs
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
using BUS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using QuanLySieuThi.Report;

namespace QuanLySieuThi
{
    public partial class frmInDSDH_TheoTenNV : Form
    {
        public frmInDSDH_TheoTenNV()
        {
            InitializeComponent();
        }

        // Initialize Variables
        BUS_DonHang bus_dh = new BUS_DonHang();

        // Function LoadData()
        public void LoadData()
        {
            // txtTenNhanVien
            txtTenNhanVien.Focus();

            // crvDSDH_TheoTenNV
            crvDSDH_TheoTenNV.ReportSource = null;
        }

        // Function Reset()
        public void Reset()
        {
            // Reset Text
            txtTenNhanVien.Text = string.Empty;

            // Called LoadData()
            LoadData();
        }

        // frmInDSDH_TheoTenNV_FormClosing
        private void frmInDSDH_TheoTenNV_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        // frmInDSDH_TheoTenNV_Load
        private void frmInDSDH_TheoTenNV_Load(object sender, EventArgs e)
        {
            LoadData();
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
            if (txtTenNhanVien.Text != string.Empty)
            {
                // Check TenNV có trong DB hay ko?
                if (bus_dh.TimDonHang_TheoTenNV(txtTenNhanVien.Text) >= 1)
                {
                    // Khởi tạo đối tượng rpt
                    DSDH_TheoTenNV rpt = new DSDH_TheoTenNV();

                    // Khởi tạo ParameterValues
                    ParameterValues para = new ParameterValues();

                    // Khởi tạo ParameterDiscreteValue
                    ParameterDiscreteValue val = new ParameterDiscreteValue();

                    // Gán giá trị cho ParameterDiscreteValue
                    val.Value = txtTenNhanVien.Text;

                    // Thêm val vào para
                    para.Add(val);

                    // Định nghĩa biến tham gia cho rpt
                    rpt.DataDefinition.ParameterFields["@tenNV"].ApplyCurrentValues(para);

                    // Gọi rpt
                    crvDSDH_TheoTenNV.ReportSource = rpt; 
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Không có tên nhân viên trong Database!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Thông báo
                MessageBox.Show("Vui lòng không để trống tên nhân viên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
