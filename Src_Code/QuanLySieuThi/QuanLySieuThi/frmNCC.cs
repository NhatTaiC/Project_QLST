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
    public partial class frmNCC : Form
    {
        public frmNCC()
        {
            InitializeComponent();
        }

        private BUS_SQL bus = new BUS_SQL();

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            dgvNCC.DataSource = bus.LayDSNCC();
            txtMaNCC.Focus();
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        // Function Reset
        private void Reset()
        {
            txtMaNCC.Text = string.Empty;
            txtTenNCC.Text = string.Empty;
            txtDiaChiNCC.Text = string.Empty;
            txtSDTNCC.Text = string.Empty;

            LoadData();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_NCC ncc = new DTO_NCC(txtMaNCC.Text, txtTenNCC.Text,
            txtDiaChiNCC.Text, txtSDTNCC.Text);

            bus.ThemNCC(ncc);
            Reset();
        }

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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void frmNCC_Load(object sender, EventArgs e)
        {
            LoadData();
        }

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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                bus.XoaNCC(txtMaNCC.Text);
                Reset();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn sửa không?", "Thông báo",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                DTO_NCC ncc = new DTO_NCC(txtMaNCC.Text, txtTenNCC.Text,
            txtDiaChiNCC.Text, txtSDTNCC.Text);

                bus.SuaNCC(ncc);
                Reset();
            }
        }
    }
}
