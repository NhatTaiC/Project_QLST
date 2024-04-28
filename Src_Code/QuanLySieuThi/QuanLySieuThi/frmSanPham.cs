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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        private BUS_SQL bus = new BUS_SQL();

        private void LoadData()
        {
            dgvSP.DataSource = bus.LayDSSP();
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
            txtGiaNhap.Text = string.Empty;
            txtGiaBan.Text = string.Empty;
            txtSoLuong.Text = string.Empty;
            txtDonViTinh.Text = string.Empty;
            txtNoiSanXuat.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            txtMaNCC.Text = string.Empty;
            txtMaLoaiSP.Text = string.Empty;


            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_SanPham sp = new DTO_SanPham(txtMaSP.Text, txtTenSP.Text,
            int.Parse(txtGiaNhap.Text),int.Parse(txtGiaBan.Text), int.Parse(txtSoLuong.Text), txtDonViTinh.Text, txtNoiSanXuat.Text, dateTimePicker1.Value.ToString(), txtMaNCC.Text, txtMaLoaiSP.Text);

            bus.ThemSP(sp);
            Reset();
        }

        private void frmSanPham_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmSanPham_Load(object sender, EventArgs e)
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
                bus.XoaTK(txtMaSP.Text);
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
                DTO_SanPham sp = new DTO_SanPham(txtMaSP.Text, txtTenSP.Text,
            int.Parse(txtGiaNhap.Text), int.Parse(txtGiaBan.Text), int.Parse(txtSoLuong.Text), txtDonViTinh.Text, txtNoiSanXuat.Text, dateTimePicker1.Value.ToString(), txtMaNCC.Text, txtMaLoaiSP.Text);

                bus.SuaSP(sp);
                Reset();
            }
        }

        private void dgvSP_Click(object sender, EventArgs e)
        {
            int n = dgvSP.CurrentCell.RowIndex;

            if (n >= 0)
            {
                txtMaSP.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;

                txtMaSP.Text = dgvSP.Rows[n].Cells[0].Value.ToString();
                txtTenSP.Text = dgvSP.Rows[n].Cells[1].Value.ToString();
                txtGiaNhap.Text = dgvSP.Rows[n].Cells[2].Value.ToString();
                txtGiaBan.Text = dgvSP.Rows[n].Cells[3].Value.ToString();
                txtSoLuong.Text = dgvSP.Rows[n].Cells[4].Value.ToString();
                txtDonViTinh.Text = dgvSP.Rows[n].Cells[5].Value.ToString();
                txtNoiSanXuat.Text = dgvSP.Rows[n].Cells[6].Value.ToString();
                dateTimePicker1.Text = dgvSP.Rows[n].Cells[7].Value.ToString();
                txtMaNCC.Text = dgvSP.Rows[n].Cells[8].Value.ToString();
                txtMaLoaiSP.Text = dgvSP.Rows[n].Cells[9].Value.ToString();
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
