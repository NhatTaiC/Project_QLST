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
using BUS;
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

        // Initialize Variables
        BUS_SanPham bus_sp = new BUS_SanPham();

        // Function LoadData()
        public void LoadData() { 
            // txtTenSanPham
            txtTenSanPham.Focus();
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
            if (txtTenSanPham.Text != string.Empty)
            {
                if (bus_sp.TimSP_TheoTenSP_3(txtTenSanPham.Text) >= 1)
                {
                    frmInDanhSachSanPham_TheoTenSanPham_KetQua f = new frmInDanhSachSanPham_TheoTenSanPham_KetQua(txtTenSanPham.Text);
                    f.ShowDialog();
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Không có tên sản phẩm trong Database!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
            else
            {
                // Thông báo
                MessageBox.Show("Vui lòng không để trống tên sản phẩm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
