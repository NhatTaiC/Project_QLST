/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 28/04/2024
 * frmDonHang.cs
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
    public partial class frmDonHang : Form
    {
        public frmDonHang()
        {
            InitializeComponent();
        }

        // Initialize Variables
        BUS_DonHang bus_dh = new BUS_DonHang();
        BUS_NhanVien bus_nv = new BUS_NhanVien();

        // function LoadData()
        public void LoadData()
        {
            // dgvDonHang
            dgvDonHang.DataSource = bus_dh.LayDSDH();

            // Columns["NgayBan"]
            dgvDonHang.Columns["NgayBan"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // dtpNgayBan
            dtpNgayBan.Value = DateTime.Now;

            // cboMaNV
            cboMaNV.DataSource = bus_nv.LayDSNV();
            cboMaNV.DisplayMember = "HoTenNV";
            cboMaNV.ValueMember = "MaNV";

            // Others
            txtMaDon.Focus();
            cboMaNV.Enabled = true;
            txtMaDon.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

        }

        // function Reset()
        public void Reset()
        {
            // Reset Text
            txtMaDon.Text = string.Empty;
            txtTongGiaTriDH.Text = string.Empty;

            // Called LoadData()
            LoadData();
        }

        // function CheckNumber()
        public bool CheckNumber(string n)
        {
            if (n == string.Empty)
            {
                return false;
            }
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] >= '0' && n[i] <= '9')
                {
                    return true;
                }
            }
            return false;
        }

        // frmDonHang_FormClosing
        private void frmDonHang_FormClosing(object sender, FormClosingEventArgs e)
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

        // frmDonHang_Load
        private void frmDonHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // dgvDonHang_Click
        private void dgvDonHang_Click(object sender, EventArgs e)
        {
            // Initialize Variable
            int n = dgvDonHang.CurrentCell.RowIndex;

            if (n >= 0)
            {
                // Buttons & Cbo
                cboMaNV.Enabled = false;
                txtMaDon.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;

                // txtMaDon
                txtMaDon.Text = dgvDonHang.Rows[n].Cells[0].Value.ToString();

                // dtpNgayBan
                dtpNgayBan.Value = DateTime.Parse(dgvDonHang.Rows[n].Cells[1].Value.ToString());

                // txtTongGiaTriDH
                txtTongGiaTriDH.Text = dgvDonHang.Rows[n].Cells[2].Value.ToString();

                // cboMaNV
                cboMaNV.DataSource = bus_nv.LayDSNV_TheoMaNV(dgvDonHang.Rows[n].Cells[3].Value.ToString());
                cboMaNV.DisplayMember = "HoTenNV";
                cboMaNV.ValueMember = "MaNV";

            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa hoặc sửa thông tin Đơn Hàng!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // btnThem_Click
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Check txtTongGiaTriDH = Number
            if (CheckNumber(txtTongGiaTriDH.Text))
            {
                DTO_DonHang dh = new DTO_DonHang(txtMaDon.Text, dtpNgayBan.Value,
                int.Parse(txtTongGiaTriDH.Text), cboMaNV.SelectedValue.ToString());

                bus_dh.ThemDH(dh);

                Reset();
            }
            else
            {
                MessageBox.Show("Tổng Giá Trị Đơn Hàng phải là số!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // btnXoa_click
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Check txtTongGiaTriDH = Number
            if (CheckNumber(txtTongGiaTriDH.Text))
            {
                DialogResult r = MessageBox.Show($"Bạn có chắc muốn xóa Đơn Hàng có mã là: +{txtMaDon.Text}+ không?",
    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (r == DialogResult.Yes)
                {
                    bus_dh.XoaDH(txtMaDon.Text);

                    Reset();
                }
            }
            else
            {
                MessageBox.Show("Tổng Giá Trị Đơn Hàng phải là số!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // btnSua_Click
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Check txtTongGiaTriDH = Number
            if (CheckNumber(txtTongGiaTriDH.Text))
            {
                DialogResult r = MessageBox.Show($"Bạn có chắc muốn sửa thông tin Đơn Hàng có mã là: +{txtMaDon.Text}+ không?",
"Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (r == DialogResult.Yes)
                {
                    DTO_DonHang dh = new DTO_DonHang(txtMaDon.Text, dtpNgayBan.Value,
                            int.Parse(txtTongGiaTriDH.Text), cboMaNV.ValueMember.ToString());

                    bus_dh.SuaDH(dh);

                    Reset();
                }
            }
            else
            {
                MessageBox.Show("Tổng Giá Trị Đơn Hàng phải là số!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // btnTim_Click
        private void btnTim_Click(object sender, EventArgs e)
        {
            // Check maDH có != null hay không?
            if (txtMaDon.Text != string.Empty)
            {
                // Tìm SP theo tenSP
                dgvDonHang.DataSource = bus_dh.TimDonHang_TheoMaDonHang(txtMaDon.Text);
            }
            else
            {
                // Thông báo
                MessageBox.Show("Vui lòng không để trống mã đơn hàng!", "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        // btnTimTenNV_Click
        private void btnTimTenNV_Click(object sender, EventArgs e)
        {
            // Tìm SP theo tenNV
            dgvDonHang.DataSource = bus_dh.TimDonHang_TheoMaNV(cboMaNV.SelectedValue.ToString());
        }
    }
}
