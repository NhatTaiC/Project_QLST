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
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi
{
    public partial class frmMain : Form
    {
        // Initialize Variables
        public static SqlConnection Con;
        private string taiKhoan = string.Empty;
        private string chucVu = string.Empty;

        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(string taiKhoan, string chucVu)
        {
            InitializeComponent();
            this.taiKhoan = taiKhoan;
            this.chucVu = chucVu;
        }

        // Function OpenConnect()
        public void OpenConnect() {
            // Mở kết nối DB
            Con = new SqlConnection();
            Con.ConnectionString = Properties.Settings.Default.tspConnect;
            Con.Open();
        }

        // Function CloseConnect()
        public void CloseConnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close(); // Đóng kết nối DB
                Con.Dispose(); // Giải phóng tài nguyên
                Con = null;
            }
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
            //// Đóng kết nối DB
            //CloseConnect();

            // Đóng App
            Application.Exit();
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

        // frmMain_Load
        private void frmMain_Load(object sender, EventArgs e)
        {
            //// Mở kết nối DB
            //OpenConnect();

            // Hiện tên người dùng
            statusLabelUserName.Text = $"Xin Chào {taiKhoan}!";

            // Phân quyền
            if (chucVu == "Nhân Viên" || chucVu == "User")
            {
                qlyMNS.Enabled = false;
            }
            else
            {
                qlyMNS.Enabled = true;
            }
        }

        // dangXuatMNS_Click
        private void dangXuatMNS_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.ShowDialog();
        }

        // nhanVienTraCuuMNSI_Click
        private void nhanVienTraCuuMNSI_Click(object sender, EventArgs e)
        {
            if (!CheckFormExist("frmTraCuuNhanVien"))
            {
                frmTraCuuNhanVien f = new frmTraCuuNhanVien();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmTraCuuNhanVien");
            }
        }

        // donHangTraCuuMNSI_Click
        private void donHangTraCuuMNSI_Click(object sender, EventArgs e)
        {
            if (!CheckFormExist("frmTraCuuDonHang"))
            {
                frmTraCuuDonHang f = new frmTraCuuDonHang();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmTraCuuDonHang");
            }
        }

        // sanPhamTraCuuMNSI_Click
        private void sanPhamTraCuuMNSI_Click(object sender, EventArgs e)
        {
            if (!CheckFormExist("frmTraCuuSanPham"))
            {
                frmTraCuuSanPham f = new frmTraCuuSanPham();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmTraCuuSanPham");
            }
        }

        // dSSP_TheoTenSPMNSI_Click
        private void dSSP_TheoTenSPMNSI_Click(object sender, EventArgs e)
        {
            if (!CheckFormExist("frmInDanhSachSanPham_TheoTenSanPham"))
            {
                frmInDanhSachSanPham_TheoTenSanPham f = new frmInDanhSachSanPham_TheoTenSanPham();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmInDanhSachSanPham_TheoTenSanPham");
            }
        }

        // DSDH_TheoTenNVMNSI_Click
        private void DSDH_TheoTenNVMNSI_Click(object sender, EventArgs e)
        {
            if (!CheckFormExist("frmInDSDH_TheoTenNV"))
            {
                frmInDSDH_TheoTenNV f = new frmInDSDH_TheoTenNV();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmInDSDH_TheoTenNV");
            }
        }

        // DSDH_TheoNgayBanMNSI_Click
        private void DSDH_TheoNgayBanMNSI_Click(object sender, EventArgs e)
        {
            if (!CheckFormExist("frmInDSDH_TheoNgayBan"))
            {
                frmInDSDH_TheoNgayBan f = new frmInDSDH_TheoNgayBan();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmInDSDH_TheoNgayBan");
            }
        }

        // banHangMNSI_Click
        private void banHangMNSI_Click(object sender, EventArgs e)
        {
            if (!CheckFormExist("frmBanHang"))
            {
                frmBanHang f = new frmBanHang();
                f.Show();
            }
            else
            {
                ActForm("frmBanHang");
            }
        }

        // inDHTheoMaDonMNSI_Click
        private void inDHTheoMaDonMNSI_Click(object sender, EventArgs e)
        {
            if (!CheckFormExist("frmInDH_TheoMaDon"))
            {
                frmInDH_TheoMaDon f = new frmInDH_TheoMaDon();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmInDH_TheoMaDon");
            }
        }
    }
}
