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

        BUS_SanPham bus_sp = new BUS_SanPham();
        BUS_NhaCungCap bus_ncc = new BUS_NhaCungCap();
        BUS_LoaiSanPham bus_lsp = new BUS_LoaiSanPham();
        BUS_BanHang bus_bh = new BUS_BanHang();

        // Function Reset()
        public void Reset()
        {
            txtMaChiTiet.Enabled = true;
            txtMaDonHang.Enabled = true;
            txtMaSP.Enabled = true;
            txtTenSP.Enabled = true;
            txtGiaBan.Enabled = true;
            txtThanhTien.Enabled = true;
            txtDonViTinh.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            // Reset text
            txtMaChiTiet.Text = string.Empty;
            txtSoLuong.Text = "0";
            txtThanhTien.Text = string.Empty;

            // Called LoadData()
            LoadData();
        }

        // CheckNumber
        public bool CheckNumber(string text)
        {
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
            // dgvSP
            dgvSP.DataSource = bus_sp.LayDSSP();
            dgvMuaHang.DataSource = bus_bh.LayDSCTDH();

        }
        

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            // Check TenSP có != null hay không?
            if (txtMaSPCanTim.Text != string.Empty)
            {
                // Tìm SP theo tenSP
                dgvSP.DataSource = bus_bh.TimSP_TheoMaSP(txtMaSPCanTim.Text);
            }
            else
            {
                // Thông báo
                MessageBox.Show("Vui lòng không để trống tên sản phẩm!", "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaSPCanTim.Text = string.Empty;
            LoadData();
        }

        private void dgvSP_Click(object sender, EventArgs e)
        {
            int n = dgvSP.CurrentCell.RowIndex;

            if (n >= 0)
            {
                txtMaChiTiet.Enabled = true;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;

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


                // cboDonViTinh
                txtDonViTinh.Text = dgvSP.Rows[n].Cells[5].Value.ToString();
            }
            else
            {
                // Thông báo
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa hoặc sửa thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            // Check soLuong có != null hay không?
            if (CheckNumber(txtSoLuong.Text))
            {
                DTO_ChiTietDonHang ctdh = new DTO_ChiTietDonHang(txtMaChiTiet.Text,
                txtMaDonHang.Text, txtMaSP.Text,
                txtTenSP.Text, int.Parse(txtGiaBan.Text),
                int.Parse(txtSoLuong.Text), int.Parse(txtThanhTien.Text), txtDonViTinh.Text);

                bus_bh.ThemChiTietDonHang(ctdh);

                Reset();
            }
            else
            {
                // Thông báo
                MessageBox.Show("Vui lòng nhập số lượng là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            // Check soLuong có != null hay không?
            if (CheckNumber(txtSoLuong.Text))
            {
                int thanhTien = int.Parse(txtSoLuong.Text) * int.Parse(txtGiaBan.Text);
                txtThanhTien.Text = $"{thanhTien}";
            }
            else
            {
                // Thông báo
                MessageBox.Show("Vui lòng nhập số lượng là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Reset Value
                txtThanhTien.Text = string.Empty;
            }
        }

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
                btnXoa.Enabled = true;
                btnSua.Enabled = true;

                // txtMaChiTiet
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

                Reset();
            }
        }

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

                Reset();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
