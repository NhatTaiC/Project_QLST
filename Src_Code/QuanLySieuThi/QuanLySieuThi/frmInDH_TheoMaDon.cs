/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 12/05/2024
 * frmInDH_TheoMaDon.cs
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
    public partial class frmInDH_TheoMaDon : Form
    {
        public frmInDH_TheoMaDon()
        {
            InitializeComponent();
        }

        // Initialize Variables
        BUS_DonHang bus_dh = new BUS_DonHang();

        // Function LoadData()
        public void LoadData() {
            txtMaDon.Focus();
        }

        // Function Reset()
        public void Reset() {
            txtMaDon.Text = string.Empty;
        }

        // frmInDH_TheoMaDon_Load
        private void frmInDH_TheoMaDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // frmInDH_TheoMaDon_FormClosing
        private void frmInDH_TheoMaDon_FormClosing(object sender, FormClosingEventArgs e)
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
            if (txtMaDon.Text != string.Empty)
            {
                if (bus_dh.CheckDH_TheoMaDH_2(txtMaDon.Text) >= 1)
                {
                    frmInDH_TheoMaDon_KetQua f = new frmInDH_TheoMaDon_KetQua(txtMaDon.Text);
                    f.ShowDialog();
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Không có mã đơn hàng trong Database!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Thông báo
                MessageBox.Show("Vui lòng không để trống mã đơn hàng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
