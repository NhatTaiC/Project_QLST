/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 01/04/2024
 * frmNhanVien.cs
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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        // Initialize Variables
        BUS_NhanVien bus_nv = new BUS_NhanVien();
        BUS_TaiKhoan bus_tk = new BUS_TaiKhoan();

        // Function LoadData()
        public void LoadData() {
            // dgvNhanVien
            dgvNhanVien.DataSource = bus_nv.LayDSNV();

            // dtpNgaySinh
            dtpNgaySinh.Value = DateTime.Now;

            // Columns[NgaySinh]
            dgvNhanVien.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // cboGioiTinh
            cboGioiTinh.SelectedIndex = 0;

            // Others
            txtMaNV.Focus();
            cboTaiKhoan.Enabled = false;
            txtMaNV.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        // Function Reset()
        public void Reset() {
            // Reset Text
            txtMaNV.Text = string.Empty;
            txtTenNV.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtSoDT.Text = string.Empty;

            // dtpNgaySinh
            dtpNgaySinh.Value = DateTime.Now;

            // cboGioiTinh
            cboGioiTinh.SelectedIndex = 0;

            // Call LoadData()
            LoadData();
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

        // frmNhanVien_Load
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // btnLamMoi_Click
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Reset();
        }

        // dgvNhanVien_Click
        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            // Get Index Row Selected
            int n = dgvNhanVien.CurrentCell.RowIndex;

            // Processing
            if (n >= 0)
            {
                // Others
                txtMaNV.Focus();
                cboTaiKhoan.Enabled = false;
                txtMaNV.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;

                txtMaNV.Text = dgvNhanVien.Rows[n].Cells[0].Value.ToString();
                txtTenNV.Text = dgvNhanVien.Rows[n].Cells[1].Value.ToString();

                // dtpNgaySinh
                dtpNgaySinh.Value = DateTime.Parse(dgvNhanVien.Rows[n].Cells[2].Value.ToString());

                // cboGioiTinh
                if (dgvNhanVien.Rows[n].Cells[3].Value.ToString() == "Nam")
                {
                    cboGioiTinh.SelectedIndex = 0;
                }
                else
                {
                    cboGioiTinh.SelectedIndex = 1;
                }

                txtDiaChi.Text = dgvNhanVien.Rows[n].Cells[4].Value.ToString();
                txtSoDT.Text = dgvNhanVien.Rows[n].Cells[5].Value.ToString();

                // cboTaiKhoan
                cboTaiKhoan.DataSource = bus_tk.LayDSTK_TheoTK(dgvNhanVien.Rows[n].Cells[6].Value.ToString());
                cboTaiKhoan.DisplayMember = "TaiKhoan";
                cboTaiKhoan.ValueMember = "TaiKhoan";

            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa hoặc xóa!", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // btnThem_Click
        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_NhanVien nv = new DTO_NhanVien(txtMaNV.Text, txtTenNV.Text,
                dtpNgaySinh.Value, cboGioiTinh.SelectedItem.ToString(), txtDiaChi.Text,
                txtSoDT.Text, cboTaiKhoan.Text.ToString());

            bus_nv.ThemNV(nv);
            Reset();
        }

        // btnXoa_Click
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"Bạn có chắc muốn xóa thông tin Nhân Viên +{txtTenNV.Text}+ không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                bus_nv.XoaNV(txtMaNV.Text, cboTaiKhoan.SelectedValue.ToString());
                Reset();
            }
        }

        // btnSua_Click
        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"Bạn có chắc muốn sửa thông tin Nhân Viên +{txtTenNV.Text}+ không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                DTO_NhanVien nv = new DTO_NhanVien(txtMaNV.Text, txtTenNV.Text,
                dtpNgaySinh.Value, cboGioiTinh.SelectedItem.ToString(), txtDiaChi.Text,
                txtSoDT.Text, cboTaiKhoan.SelectedValue.ToString());

                bus_nv.SuaNV(nv);
                Reset();
            }
        }

        // txtMaNV_TextChanged
        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            cboTaiKhoan.Text = txtMaNV.Text;
        }
    }
}
