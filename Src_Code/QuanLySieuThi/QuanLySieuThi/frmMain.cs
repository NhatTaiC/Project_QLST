/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 01/04/2024
 * frmMain.cs
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

namespace QuanLySieuThi
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // Function CheckFormExist
        private bool CheckFormExist(string name)
        {
            foreach (Form item in MdiChildren)
            {
                if (item.Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        // Function ActForm
        private void ActForm(string name) {
            foreach (Form item in MdiChildren)
            {
                if (item.Name == name)
                {
                    item.Activate();
                    break;
                }
            }
        }

        // Form Closing
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        // ThoatMNS_Click
        private void thoatMNS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // TaiKhoanMNS_Click
        private void taiKhoanMNS_Click(object sender, EventArgs e)
        {
            if (!CheckFormExist("frmTaiKhoan"))
            {
                frmTaiKhoan f = new frmTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmTaiKhoan");
            }
        }

        // nhanVienMNS_Click
        private void nhanVienMNS_Click(object sender, EventArgs e)
        {
            if (!CheckFormExist("frmNhanVien"))
            {
                frmNhanVien f = new frmNhanVien();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmNhanVien");
            }
        }

        // donHangMNS_Click
        private void donHangMNS_Click(object sender, EventArgs e)
        {
            if (!CheckFormExist("frmDonHang"))
            {
                frmDonHang f = new frmDonHang();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmDonHang");
            }
        }

        // chiTietDonHangMNS_Click
        private void chiTietDonHangMNS_Click(object sender, EventArgs e)
        {
            if (!CheckFormExist("frmChiTietDonHang"))
            {
                frmChiTietDonHang f = new frmChiTietDonHang();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmChiTietDonHang");
            }
        }

        // nhaCungCapMNS_Click
        private void nhaCungCapMNS_Click(object sender, EventArgs e)
        {
            if (!CheckFormExist("frmNhaCungCap"))
            {
                frmNhaCungCap f = new frmNhaCungCap();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmNhaCungCap");
            }
        }
        
        // loaiSanPhamMNS_Click
        private void loaiSanPhamMNS_Click(object sender, EventArgs e)
        {
            if (!CheckFormExist("frmLoaiSanPham"))
            {
                frmLoaiSanPham f = new frmLoaiSanPham();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmLoaiSanPham");
            }
        }

        // sanPhamMNS_Click
        private void sanPhamMNS_Click(object sender, EventArgs e)
        {
            if (!CheckFormExist("frmSanPham"))
            {
                frmSanPham f = new frmSanPham();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmSanPham");
            }
        }

        // gioiThieuMNS_Click
        private void gioiThieuMNS_Click(object sender, EventArgs e)
        {
            if (!CheckFormExist("frmGioiThieu"))
            {
                frmGioiThieu f = new frmGioiThieu();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmGioiThieu");
            }
        }

        // timer1_Tick - Hiện thời gian
        private void timer1_Tick(object sender, EventArgs e)
        {
            statusLabelHienThoiGian.Text = DateTime.Now.ToString();
        }
    }
}
