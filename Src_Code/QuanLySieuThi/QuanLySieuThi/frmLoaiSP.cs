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
    public partial class frmLoaiSP : Form
    {
        public frmLoaiSP()
        {
            InitializeComponent();
        }

        private BUS_SQL bus = new BUS_SQL();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableButton_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadData()
        {
            dgvLoaiSP.DataSource = bus.LayDSLoaiSP();
            txtMaSP.Focus();
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        // Function Reset
        private void Reset()
        {
            txtMaSP.Text = string.Empty;
            txtTenSP.Text = string.Empty;
            txtMoTa.Text = string.Empty;

            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_LoaiSP lsp = new DTO_LoaiSP(txtMaSP.Text, txtTenSP.Text,
            txtMoTa.Text);

            bus.ThemLoaiSP(lsp);
            Reset();
        }

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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void frmLoaiSP_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                bus.XoaLoaiSP(txtMaSP.Text);
                Reset();
            }
        }

        private void dgvLoaiSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLoaiSP_Click(object sender, EventArgs e)
        {

            int n = dgvLoaiSP.CurrentCell.RowIndex;

            if (n != 0)
            {
                txtMaSP.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;

                txtMaSP.Text = dgvLoaiSP.Rows[n].Cells[0].Value.ToString();
                txtTenSP.Text = dgvLoaiSP.Rows[n].Cells[1].Value.ToString();
                txtMoTa.Text = dgvLoaiSP.Rows[n].Cells[2].Value.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa/sửa!", "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }
    }
}
