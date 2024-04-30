﻿/*
* Châu Nhật Tài, Lê Văn Toàn
* Project CN.NET
* Quản Lý Siêu Thị
* 29/04/2024
* frmChiTietDonHang.cs
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
    public partial class frmChiTietDonHang : Form
    {
        public frmChiTietDonHang()
        {
            InitializeComponent();
        }

        // Initialize Variables
        BUS_ChiTietDonHang bus_ctdh = new BUS_ChiTietDonHang();
        BUS_DonHang bus_dh = new BUS_DonHang();
        BUS_SanPham bus_sp = new BUS_SanPham();

        // Function LoadData()
        public void LoadData()
        {
            // dgvChiTietDonHang
            dgvCTDH.DataSource = bus_ctdh.LayDSCTDH();

            // cboMaDonHang
            cboMaDonHang.DataSource = bus_dh.LayDSDH();
            cboMaDonHang.DisplayMember = "MaDon";
            cboMaDonHang.ValueMember = "MaDon";
            cboMaDonHang.SelectedIndex = 0;

            // cboMaSanPham
            cboMaSanPham.DataSource = bus_sp.LayDSSP();
            cboMaSanPham.DisplayMember = "MaSP";
            cboMaSanPham.ValueMember = "MaSP";
            cboMaSanPham.SelectedIndex = 0;

            // cboTenSanPham
            cboTenSanPham.DataSource = bus_sp.LayDSSP();
            cboTenSanPham.DisplayMember = "TenSP";
            cboTenSanPham.ValueMember = "TenSP";
            cboTenSanPham.SelectedIndex = 0;

            // cboGiaBan
            cboGiaBan.DataSource = bus_sp.NhomSP_TheoGiaBan();
            cboGiaBan.DisplayMember = "GiaBan";
            cboGiaBan.ValueMember = "GiaBan";
            cboGiaBan.SelectedIndex = 0;

            // cboDonViTinh
            cboDonViTinh.DataSource = bus_sp.NhomSP_TheoDonViTinh();
            cboDonViTinh.DisplayMember = "DonViTinh";
            cboDonViTinh.ValueMember = "DonViTinh";
            cboDonViTinh.SelectedIndex = 0;

            // Others
            txtMaChiTiet.Focus();
            txtMaChiTiet.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txtThanhTien.Enabled = false;
        }

        // Function Reset()
        public void Reset()
        {
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

        // frmChiTietDonHang_FormClosing
        private void frmChiTietDonHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (r == DialogResult.No) { e.Cancel = true; }
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

        // frmChiTietDonHang_Load
        private void frmChiTietDonHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // dgvCTDH_Click
        private void dgvCTDH_Click(object sender, EventArgs e)
        {
            int n = dgvCTDH.CurrentCell.RowIndex;

            if (n >= 0)
            {
                txtMaChiTiet.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;

                // txtMaChiTiet
                txtMaChiTiet.Text = dgvCTDH.Rows[n].Cells[0].Value.ToString();


                // cboMaDonHang
                cboMaDonHang.SelectedIndex = cboMaDonHang.FindStringExact(dgvCTDH.Rows[n].Cells[1].Value.ToString());

                // cboMaSanPham
                cboMaSanPham.SelectedIndex = cboMaSanPham.FindStringExact(dgvCTDH.Rows[n].Cells[2].Value.ToString());

                // cboTenSanPham
                cboTenSanPham.SelectedIndex = cboTenSanPham.FindStringExact(dgvCTDH.Rows[n].Cells[3].Value.ToString());

                // cboGiaBan
                cboGiaBan.SelectedIndex = cboGiaBan.FindStringExact(dgvCTDH.Rows[n].Cells[4].Value.ToString());

                // txtSoLuong
                txtSoLuong.Text = dgvCTDH.Rows[n].Cells[5].Value.ToString();

                // txtThanhTien
                txtThanhTien.Text = dgvCTDH.Rows[n].Cells[6].Value.ToString();

                // cboDonViTinh
                cboDonViTinh.SelectedIndex = cboDonViTinh.FindStringExact(dgvCTDH.Rows[n].Cells[7].Value.ToString());
            }
            else
            {
                // Thông báo
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa hoặc sửa thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // cboMaSanPham_SelectedValueChanged
        private void cboMaSanPham_SelectedValueChanged(object sender, EventArgs e)
        {
            // cboTenSanPham
            cboTenSanPham.DataSource = bus_sp.LayDSSP_TheoMaSP(cboMaSanPham.SelectedValue.ToString());
            cboTenSanPham.DisplayMember = "TenSP";
            cboTenSanPham.ValueMember = "TenSP";

            // cboGiaBan
            cboGiaBan.DataSource = bus_sp.LayDSSP_TheoMaSP(cboMaSanPham.SelectedValue.ToString());
            cboGiaBan.DisplayMember = "GiaBan";
            cboGiaBan.ValueMember = "GiaBan";

            // cboDonViTinh
            cboDonViTinh.DataSource = bus_sp.LayDSSP_TheoMaSP(cboMaSanPham.SelectedValue.ToString());
            cboDonViTinh.DisplayMember = "DonViTinh";
            cboDonViTinh.ValueMember = "DonViTinh";
        }

        // txtSoLuong_TextChanged
        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            // Check soLuong có != null hay không?
            if (CheckNumber(txtSoLuong.Text))
            {
                int thanhTien = int.Parse(txtSoLuong.Text) * int.Parse(cboGiaBan.SelectedValue.ToString());
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

        // btnThem_Click
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Check soLuong có != null hay không?
            if (CheckNumber(txtSoLuong.Text))
            {
                DTO_ChiTietDonHang ctdh = new DTO_ChiTietDonHang(txtMaChiTiet.Text,
                cboMaDonHang.SelectedValue.ToString(), cboMaSanPham.SelectedValue.ToString(),
                cboTenSanPham.SelectedValue.ToString(), int.Parse(cboGiaBan.SelectedValue.ToString()),
                int.Parse(txtSoLuong.Text), int.Parse(txtThanhTien.Text), cboDonViTinh.SelectedValue.ToString());

                bus_ctdh.ThemChiTietDonHang(ctdh);

                Reset();
            }
            else
            {
                // Thông báo
                MessageBox.Show("Vui lòng nhập số lượng là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
               cboMaDonHang.SelectedValue.ToString(), cboMaSanPham.SelectedValue.ToString(),
               cboTenSanPham.SelectedValue.ToString(), int.Parse(cboGiaBan.SelectedValue.ToString()),
               int.Parse(txtSoLuong.Text), int.Parse(txtThanhTien.Text), cboDonViTinh.SelectedValue.ToString());

                bus_ctdh.XoaChiTietDonHang(ctdh);

                Reset();
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
               cboMaDonHang.SelectedValue.ToString(), cboMaSanPham.SelectedValue.ToString(),
               cboTenSanPham.SelectedValue.ToString(), int.Parse(cboGiaBan.SelectedValue.ToString()),
               int.Parse(txtSoLuong.Text), int.Parse(txtThanhTien.Text), cboDonViTinh.SelectedValue.ToString());

                bus_ctdh.SuaChiTietDonHang(ctdh);

                Reset();
            }
        }

        // btnTim_Click
        private void btnTim_Click(object sender, EventArgs e)
        {
            // dgvCTDH
            dgvCTDH.DataSource = bus_ctdh.TimDonHang_TheoMaDon(cboMaDonHang.SelectedValue.ToString());
        }
    }
}
