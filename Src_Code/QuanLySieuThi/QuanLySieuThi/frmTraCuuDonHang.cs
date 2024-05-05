/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 05/05/2024
 * frmTraCuuDonHang.cs
 */

using BUS;
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
    public partial class frmTraCuuDonHang : Form
    {
        public frmTraCuuDonHang()
        {
            InitializeComponent();
        }

        // Initialize Variables
        BUS_ChiTietDonHang bus_ctdh = new BUS_ChiTietDonHang();

        // Function LoadData()
        public void LoadData()
        {
            // txtNoiDung
            txtNoiDung.Focus();

            // cboTraCuu
            cboTraCuu.SelectedIndex = 0;

            // dgvTraCuuNV 
            dgvTraCuuDonHang.DataSource = bus_ctdh.LayDSCTDH();

        }

        // Function Reset()
        public void Reset()
        {
            // Reset Text
            txtNoiDung.Text = string.Empty;
            gbDGVTraCuuDonHang.Text = $"Kết Quả Tra Cứu:";

            // Called LoadData()
            LoadData();
        }

        // frmTraCuuDonHang_FormClosing
        private void frmTraCuuDonHang_FormClosing(object sender, FormClosingEventArgs e)
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

        // frmTraCuuDonHang_Load
        private void frmTraCuuDonHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // btnTraCuu_Click
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            // Tra Cứu
            if (dgvTraCuuDonHang.RowCount != 0)
            {
                if (cboTraCuu.SelectedItem.ToString() == "Mã Đơn Hàng")
                {
                    dgvTraCuuDonHang.DataSource = bus_ctdh.TimDonHang_TheoMaDon(txtNoiDung.Text);
                    gbDGVTraCuuDonHang.Text = $"Kết Quả Tra Cứu: {dgvTraCuuDonHang.RowCount}";
                }
                else if (cboTraCuu.SelectedItem.ToString() == "Mã Nhân Viên")
                {
                    dgvTraCuuDonHang.DataSource = bus_ctdh.TimDonHang_TheoMaNV(txtNoiDung.Text);
                    gbDGVTraCuuDonHang.Text = $"Kết Quả Tra Cứu: {dgvTraCuuDonHang.RowCount}";
                }
                else
                {
                    dgvTraCuuDonHang.DataSource = bus_ctdh.TimDonHang_TheoTenNV(txtNoiDung.Text);
                    gbDGVTraCuuDonHang.Text = $"Kết Quả Tra Cứu: {dgvTraCuuDonHang.RowCount}";
                }
            }
            else
            {
                MessageBox.Show("Nội dung bạn tìm không có trong dữ liệu!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                Reset();
            }
        }
    }
}
