﻿/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 01/04/2024
 * frmNhanVien.cs
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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        // Initialize Variables
        BUS_SQL bus = new BUS_SQL();

        // Function LoadData()
        public void LoadData() {
            // dgvNhanVien
            dgvNhanVien.DataSource = bus.LayDSNV();

            // cboTaiKhoan
            cboTaiKhoan.DataSource = bus.LayDSTK();
            cboTaiKhoan.DisplayMember = "TaiKhoan";
            cboTaiKhoan.ValueMember = "TaiKhoan";

            // cboGioiTinh
            cboGioiTinh.SelectedIndex = 0;

            // Others
            txtMaNV.Focus();
            cboTaiKhoan.SelectedIndex = 0;
            cboTaiKhoan.Enabled = true;
            txtMaNV.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        // Form Closing
        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}