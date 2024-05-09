/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 09/05/2024
 * frmBanHang.cs
 */
using BUS;
using DTO;
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
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }
        int sum = 0;
        BUS_SanPham bus_sp = new BUS_SanPham();
        BUS_BanHang bus_bh = new BUS_BanHang();
        BUS_DonHang bus_dh = new BUS_DonHang();
        BUS_NhanVien bus_nv = new BUS_NhanVien();

        // Function Reset()
        public void Reset()
        {
            // turnOffRight
            turnOffRight();

            // Reset right
            txtMaChiTiet.Text = string.Empty;
            txtSoLuong.Text = "0";
            txtThanhTien.Text = "0";

            // Called LoadData()
            LoadData();
        }

        // Function Reset2()
        public void Reset2()
        {
            txtMaChiTiet.Enabled = true;
            txtMaDonHang.Enabled = false;
            txtMaSP.Enabled = true;
            txtTenSP.Enabled = false;
            txtGiaBan.Enabled = false;
            txtThanhTien.Enabled = false;
            txtDonViTinh.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;

            // Reset text
            //txtMaChiTiet.Text = string.Empty;
            txtSoLuong.Text = "0";
            txtThanhTien.Text = "0";

            //// Called LoadData()
            //LoadData();

            dgvMuaHang.DataSource = bus_bh.LayDSCTDH(txtMaDonHang.Text);
        }

        // Function Reset3()
        public void Reset3()
        {
            txtMaChiTiet.Enabled = true;
            txtMaDonHang.Enabled = false;
            txtMaSP.Enabled = false;
            txtTenSP.Enabled = false;
            txtGiaBan.Enabled = false;
            txtSoLuong.Text = "0";
            txtThanhTien.Text = "0";
            txtTongTien.Text = "0";
            txtDonViTinh.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThanhToan.Enabled = true;

            // Called LoadData()
            LoadData();
        }

        // Function Reset3()
        public void Reset4()
        {
            txtMaChiTiet.Enabled = true;
            txtMaDonHang.Enabled = false;
            txtMaSP.Enabled = false;
            txtTenSP.Enabled = false;
            txtGiaBan.Enabled = false;
            txtSoLuong.Text = "0";
            txtThanhTien.Text = "0";
            txtDonViTinh.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThanhToan.Enabled = true;
            btnThemDH.Enabled = true;

            // Called LoadData()
            LoadData();
        }

        // Function turnOffLeft()
        public void turnOffLeft()
        {
            txtMaDon.Enabled = false;
            dtpNgayBan.Enabled = false;
            txtTongGiaTriDH.Enabled = false;
            cboMaNV.Enabled = false;
        }

        // Function turnOffRight()
        public void turnOffRight()
        {
            txtMaChiTiet.Enabled = false;
            txtMaDonHang.Enabled = false;
            txtMaSP.Enabled = false;
            txtTenSP.Enabled = false;
            txtGiaBan.Enabled = false;
            txtSoLuong.Enabled = false;
            txtThanhTien.Enabled = false;
            txtDonViTinh.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLamMoi.Enabled = true;
            btnThanhToan.Enabled = false;
        }

        // CheckNumber
        public bool CheckNumber(string text)
        {
            if (text == string.Empty)
            {
                return false;
            }
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= '0' && text[i] <= '9')
                {
                    return true;
                }
            }
            return false;
        }

        // Function LoadData()
        private void LoadData()
        {
            // left
            txtMaDon.Focus();
            dtpNgayBan.Value = DateTime.Now;
            txtTongGiaTriDH.Text = "0";
            txtTongGiaTriDH.Enabled = false;
            cboMaNV.SelectedIndex = 0;

            // dgvSP
            dgvSP.DataSource = bus_sp.LayDSSP();
            txtTongTien.Enabled = false;
            txtGiaBan.Text = "0";
            txtSoLuong.Text = "0";
            txtThanhTien.Text = "0";
            dgvMuaHang.DataSource = bus_bh.LayDSCTDH(txtMaDonHang.Text);

            txtMaChiTiet.Enabled = true;
            txtMaDonHang.Enabled = true;
            txtMaSP.Enabled = false;
            txtTenSP.Enabled = false;
            txtGiaBan.Enabled = false;
            txtSoLuong.Enabled = true;
            txtThanhTien.Enabled = false;
            txtDonViTinh.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLamMoi.Enabled = true;
            btnThanhToan.Enabled = true;
        }

        // btnLamMoi_Click
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Reset4();
        }

        // frmBanHang_Load
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            // cboMaNV
            cboMaNV.DataSource = bus_nv.LayDSNV();
            cboMaNV.DisplayMember = "HoTenNV";
            cboMaNV.ValueMember = "MaNV";
            LoadData();
        }

        // dgvSP_Click
        private void dgvSP_Click(object sender, EventArgs e)
        {
            int n = dgvSP.CurrentCell.RowIndex;

            if (n >= 0)
            {
                txtMaChiTiet.Enabled = true;
                txtMaDonHang.Enabled = true;
                txtMaSP.Enabled = true;
                btnThem.Enabled = true;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;

                // txtMaChiTiet
                //txtMaChiTiet.Text = dgvSP.Rows[n].Cells[0].Value.ToString();


                // cboMaDonHang
                //txtMaDonHang.Text = dgvSP.Rows[n].Cells[1].Value.ToString();

                // cboMaSanPham
                txtMaSP.Text = dgvSP.Rows[n].Cells[0].Value.ToString();

                // cboTenSanPham
                txtTenSP.Text = dgvSP.Rows[n].Cells[1].Value.ToString();

                // cboGiaBan
                txtGiaBan.Text = dgvSP.Rows[n].Cells[3].Value.ToString();

                // txtSoLuong
                txtSoLuong.Text = "0";

                // txtThanhTien
                txtThanhTien.Text = "0";

                // cboDonViTinh
                txtDonViTinh.Text = dgvSP.Rows[n].Cells[5].Value.ToString();
            }
            else
            {
                // Thông báo
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa hoặc sửa thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // btnThem_Click
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Check soLuong có != null hay không?
            if (CheckNumber(txtSoLuong.Text))
            {
                // Check MaSP có hợp lệ hay không?
                if (bus_sp.TimSP_TheoMaSP_3(txtMaSP.Text) == 1)
                {
                    if (txtThanhTien.Text != string.Empty)
                    {
                        DTO_ChiTietDonHang ctdh = new DTO_ChiTietDonHang(txtMaChiTiet.Text,
                                           txtMaDonHang.Text, txtMaSP.Text,
                                           txtTenSP.Text, int.Parse(txtGiaBan.Text),
                                           int.Parse(txtSoLuong.Text), int.Parse(txtThanhTien.Text), txtDonViTinh.Text);

                        if (bus_bh.ThemChiTietDonHang(ctdh))
                        {
                            sum += int.Parse(txtThanhTien.Text);
                            txtTongTien.Text = $"{sum}";
                            Reset4();
                            btnThanhToan.Enabled = true;
                        }
                    }
                    else
                    {
                        // Thông báo
                        MessageBox.Show("Thành tiền không hợp lệ!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Mã sản phẩm không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Thông báo
                MessageBox.Show("Vui lòng nhập số lượng là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // txtSoLuong_TextChanged
        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            // Check soLuong có != null hay không?
            if (CheckNumber(txtSoLuong.Text))
            {

                if (txtSoLuong.Text != null)
                {
                    int thanhTien = int.Parse(txtSoLuong.Text) * int.Parse(txtGiaBan.Text);
                    txtThanhTien.Text = $"{thanhTien}";
                }
                else
                {
                    txtSoLuong.Text = "0";
                    txtGiaBan.Text = "0";
                    txtThanhTien.Text = "0";
                }
            }
            else
            {
                // Thông báo
                MessageBox.Show("Vui lòng nhập số lượng là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Reset Value
                txtThanhTien.Text = string.Empty;
            }
        }

        // dgvMuaHang_Click
        private void dgvMuaHang_Click(object sender, EventArgs e)
        {
            int n = dgvMuaHang.CurrentCell.RowIndex;

            if (n >= 0)
            {
                txtMaChiTiet.Enabled = false;
                txtMaDonHang.Enabled = false;
                txtMaSP.Enabled = false;
                txtTenSP.Enabled = false;
                txtGiaBan.Enabled = false;
                txtThanhTien.Enabled = false;
                txtDonViTinh.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;

                txtMaChiTiet.Text = dgvMuaHang.Rows[n].Cells[0].Value.ToString();

                // cboMaDonHang
                txtMaDonHang.Text = dgvMuaHang.Rows[n].Cells[1].Value.ToString();

                // cboMaSanPham
                txtMaSP.Text = dgvMuaHang.Rows[n].Cells[2].Value.ToString();

                // cboTenSanPham
                txtTenSP.Text = dgvMuaHang.Rows[n].Cells[3].Value.ToString();

                // cboGiaBan
                txtGiaBan.Text = dgvMuaHang.Rows[n].Cells[4].Value.ToString();

                // txtSoLuong
                txtSoLuong.Text = dgvMuaHang.Rows[n].Cells[5].Value.ToString();

                // txtThanhTien
                txtThanhTien.Text = dgvMuaHang.Rows[n].Cells[6].Value.ToString();

                // cboDonViTinh
                txtDonViTinh.Text = dgvMuaHang.Rows[n].Cells[7].Value.ToString();
            }
            else
            {
                // Thông báo
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa hoặc sửa thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // btnXoa_Click
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"Bạn có chắc muốn xóa chi tiết đơn hàng +{txtMaChiTiet.Text}+ không?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                DTO_ChiTietDonHang ctdh = new DTO_ChiTietDonHang(txtMaChiTiet.Text,
                txtMaDonHang.Text, txtMaSP.Text,
                txtTenSP.Text, int.Parse(txtGiaBan.Text),
                int.Parse(txtSoLuong.Text), int.Parse(txtThanhTien.Text), txtDonViTinh.Text);

                bus_bh.XoaChiTietDonHang(ctdh);

                Reset3();
            }
        }

        // btnSua_Click
        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"Bạn có chắc muốn sửa thông tin chi tiết đơn hàng +{txtMaChiTiet.Text}+ không?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                DTO_ChiTietDonHang ctdh = new DTO_ChiTietDonHang(txtMaChiTiet.Text,
                txtMaDonHang.Text, txtMaSP.Text,
                txtTenSP.Text, int.Parse(txtGiaBan.Text),
                int.Parse(txtSoLuong.Text), int.Parse(txtThanhTien.Text), txtDonViTinh.Text);

                bus_bh.SuaChiTietDonHang(ctdh);

                Reset3();
            }
        }

        // btnThoat_Click
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // btnThemDH_Click
        private void btnThemDH_Click(object sender, EventArgs e)
        {
            // Check txtTongGiaTriDH = Number
            if (CheckNumber(txtTongGiaTriDH.Text))
            {
                if (bus_dh.TimDonHang_TheoMaDH_2(txtMaDon.Text) != 1)
                {
                    DTO_DonHang dh = new DTO_DonHang(txtMaDon.Text, dtpNgayBan.Value,
                            int.Parse(txtTongGiaTriDH.Text), cboMaNV.SelectedValue.ToString());
                    bus_dh.ThemDH(dh);

                    Reset();

                    txtMaChiTiet.Enabled = true;
                    txtMaDonHang.Text = txtMaDon.Text;
                    txtMaDonHang.Enabled = false;
                    txtMaSP.Enabled = false;
                    txtTenSP.Enabled = false;
                    txtGiaBan.Enabled = false;
                    txtSoLuong.Enabled = true;
                    txtThanhTien.Enabled = false;
                    txtDonViTinh.Enabled = false;
                    btnThemDH.Enabled = false;
                    btnThem.Enabled = true;
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                    btnLamMoi.Enabled = true;
                }
                else
                {
                    MessageBox.Show($"Đã có +{txtMaDon.Text}+ trong database!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tổng Giá Trị Đơn Hàng phải là số!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // btnThanhToan_Click
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            bus_bh.CapNhatGiaTriTongTien(txtMaDon.Text, txtTongTien.Text);
            txtTongTien.Text = "";
            dgvMuaHang.DataSource = null;
            MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
