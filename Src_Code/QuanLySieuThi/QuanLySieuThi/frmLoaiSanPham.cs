/*
* Châu Nhật Tài, Lê Văn Toàn
* Project CN.NET
* Quản Lý Siêu Thị
* 29/04/2024
* frmLoaiSanPham.cs
*/
using DTO;
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
    public partial class frmLoaiSanPham : Form
    {
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }

        //Initialize Variables
        BUS_LoaiSanPham bus_lsp = new BUS_LoaiSanPham();

        // Function LoadData()
        private void LoadData()
        {
            // dgvLoaiSP
            dgvLoaiSP.DataSource = bus_lsp.LayDSLSP();
            dgvLoaiSP.Columns[0].HeaderText = "Mã Loại Sản Phẩm";
            dgvLoaiSP.Columns[1].HeaderText = "Tên Loại Sản Phẩm";
            dgvLoaiSP.Columns[2].HeaderText = "Mô tả";

            // Others
            txtMaLSP.Focus();
            txtMaLSP.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        // Function Reset
        private void Reset()
        {
            // Reset Teset
            txtMaLSP.Text = string.Empty;
            txtTenLSP.Text = string.Empty;
            txtMoTa.Text = string.Empty;

            // Called LoadData()
            LoadData();
        }

        // frmLoaiSP_FormClosing
        private void frmLoaiSP_FormClosing(object sender, FormClosingEventArgs e)
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

        // dgvLoaiSP_Click
        private void dgvLoaiSP_Click(object sender, EventArgs e)
        {
            int n = dgvLoaiSP.CurrentCell.RowIndex;

            if (n >= 0)
            {
                txtMaLSP.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;

                txtMaLSP.Text = dgvLoaiSP.Rows[n].Cells[0].Value.ToString();
                txtTenLSP.Text = dgvLoaiSP.Rows[n].Cells[1].Value.ToString();
                txtMoTa.Text = dgvLoaiSP.Rows[n].Cells[2].Value.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa hoặc sửa thông tin!", "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        // btnThem_Click
        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_LoaiSanPham lsp = new DTO_LoaiSanPham(txtMaLSP.Text, txtTenLSP.Text,
            txtMoTa.Text);

            bus_lsp.ThemLSP(lsp);
            Reset();
        }

        // btnXoa_Click
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"Bạn có chắc muốn xóa Loại Sản Phẩm có mã là: +{txtMaLSP.Text}+ không?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                bus_lsp.XoaLSP(txtMaLSP.Text);
                Reset();
            }
        }

        // btnSua_Click
        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"Bạn có chắc muốn sửa thông tin Loại Sản Phẩm có mã là: +{txtMaLSP.Text}+ không?", "Thông báo",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                DTO_LoaiSanPham lsp = new DTO_LoaiSanPham(txtMaLSP.Text, txtTenLSP.Text,txtMoTa.Text);

                bus_lsp.SuaLSP(lsp);
                Reset();
            }
        }

        // frmLoaiSanPham_Load
        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // btnTim_Click
        private void btnTim_Click(object sender, EventArgs e)
        {
            // Check TenLSP có != null hay không?
            if (txtTenLSP.Text != string.Empty)
            {
                // Tìm LSP theo tenLSP
                dgvLoaiSP.DataSource = bus_lsp.TimLSP_TheoTenLSP(txtTenLSP.Text);
            }
            else
            {
                // Thông báo
                MessageBox.Show("Vui lòng không để trống tên loại sản phẩm!", "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }
    }
}
