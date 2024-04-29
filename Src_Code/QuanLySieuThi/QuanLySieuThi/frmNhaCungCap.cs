/*
* Châu Nhật Tài, Lê Văn Toàn
* Project CN.NET
* Quản Lý Siêu Thị
* 29/04/2024
* frmNhaCungCap.cs
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
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        // Initialize Variables
        BUS_NhaCungCap bus_ncc = new BUS_NhaCungCap();

        // Function LoadData()
        private void LoadData()
        {
            // dgvNCC
            dgvNCC.DataSource = bus_ncc.LayDSNCC();

            // Others
            txtMaNCC.Focus();
            txtMaNCC.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        // Function Reset
        private void Reset()
        {
            // Reset Test
            txtMaNCC.Text = string.Empty;
            txtTenNCC.Text = string.Empty;
            txtDiaChiNCC.Text = string.Empty;
            txtSDTNCC.Text = string.Empty;

            // Called LoadData()
            LoadData();
        }

        // btnThem_Click
        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_NhaCungCap ncc = new DTO_NhaCungCap(txtMaNCC.Text, txtTenNCC.Text,
            txtDiaChiNCC.Text, txtSDTNCC.Text);

            bus_ncc.ThemNCC(ncc);

            Reset();
        }

        // frmNCC_formClosing
        private void frmNCC_FormClosing(object sender, FormClosingEventArgs e)
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

        // frmNCC_Load
        private void frmNCC_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // btnXoa_Click
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"Bạn có chắc muốn xóa Nhà Cung Cấp có mã là: +{txtMaNCC.Text}+ không?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                bus_ncc.XoaNCC(txtMaNCC.Text);

                Reset();
            }
        }

        // btnSua_Click
        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"Bạn có chắc muốn sửa thông tin của Nhà Cung Cấp có mã là: +{txtMaNCC.Text}+ không?", "Thông báo",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                DTO_NhaCungCap ncc = new DTO_NhaCungCap(txtMaNCC.Text, txtTenNCC.Text,
            txtDiaChiNCC.Text, txtSDTNCC.Text);

                bus_ncc.SuaNCC(ncc);

                Reset();
            }
        }

        // dgvNCC_Click
        private void dgvNCC_Click(object sender, EventArgs e)
        {
            int n = dgvNCC.CurrentCell.RowIndex;

            if (n >= 0)
            {
                txtMaNCC.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;

                txtMaNCC.Text = dgvNCC.Rows[n].Cells[0].Value.ToString();
                txtTenNCC.Text = dgvNCC.Rows[n].Cells[1].Value.ToString();
                txtDiaChiNCC.Text = dgvNCC.Rows[n].Cells[2].Value.ToString();
                txtSDTNCC.Text = dgvNCC.Rows[n].Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa/sửa!", "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        // btnTim_Click
        private void btnTim_Click(object sender, EventArgs e)
        {
            // Check tenNCC có != null hay không?
            if (txtTenNCC.Text != string.Empty)
            {
                // Tìm tenNCC 
                dgvNCC.DataSource = bus_ncc.TimNCC_TheoTenNCC(txtTenNCC.Text);
            }
            else
            {
                // Thông báo
                MessageBox.Show("Vui lòng không để trống tên nhà cung cấp!", "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }
    }
}
