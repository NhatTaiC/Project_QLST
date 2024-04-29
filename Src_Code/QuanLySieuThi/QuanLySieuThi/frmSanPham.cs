/*
* Châu Nhật Tài, Lê Văn Toàn
* Project CN.NET
* Quản Lý Siêu Thị
* 29/04/2024
* frmSanPham.cs
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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        // Initialize Variables
        BUS_SanPham bus_sp = new BUS_SanPham();
        BUS_NhaCungCap bus_ncc = new BUS_NhaCungCap();
        BUS_LoaiSanPham bus_lsp = new BUS_LoaiSanPham();

        // Function LoadData()
        private void LoadData()
        {
            // dgvSP
            dgvSP.DataSource = bus_sp.LayDSSP();

            // Columns["HanSuDung"]
            dgvSP.Columns["HanSuDung"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // dtpHanSuDung
            dtpHanSuDung.Value = DateTime.Now;

            // cboNhaCungCap
            cboNhaCungCap.DataSource = bus_ncc.LayDSNCC();
            cboNhaCungCap.DisplayMember = "TenNCC";
            cboNhaCungCap.ValueMember = "MaNCC";
            cboNhaCungCap.SelectedIndex = 0;

            // cboLoaiSanPham
            cboLoaiSanPham.DataSource = bus_lsp.LayDSLSP();
            cboLoaiSanPham.DisplayMember = "TenLoaiSP";
            cboLoaiSanPham.ValueMember = "MaLoaiSP";
            cboLoaiSanPham.SelectedIndex = 0;

            // Others
            txtMaSP.Focus();
            txtMaSP.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        // Function Reset()
        private void Reset()
        {
            // Reset Test
            txtMaSP.Text = string.Empty;
            txtTenSP.Text = string.Empty;
            txtGiaNhap.Text = string.Empty;
            txtGiaBan.Text = string.Empty;
            txtSoLuong.Text = string.Empty;
            txtDonViTinh.Text = string.Empty;
            txtNoiSanXuat.Text = string.Empty;
            
            // Called LoadData()
            LoadData();
        }

        // Function CheckNumber()
        public bool CheckNumber(string maSP) {
            if (maSP == string.Empty)
            {
                return false;
            }
            for (int i = 0; i < maSP.Length; i++)
            {
                if (maSP[i] >= '0' && maSP[i] <= '9')
                {
                    return true;
                }

            }
            return false;
        }

        // btnThem_Click
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckNumber(txtGiaNhap.Text) && CheckNumber(txtGiaBan.Text) && CheckNumber(txtSoLuong.Text))
            {
                DTO_SanPham sp = new DTO_SanPham(txtMaSP.Text, txtTenSP.Text,
                    int.Parse(txtGiaNhap.Text), int.Parse(txtGiaBan.Text), int.Parse(txtSoLuong.Text), txtDonViTinh.Text, txtNoiSanXuat.Text,
                    dtpHanSuDung.Value, cboNhaCungCap.SelectedValue.ToString(), cboLoaiSanPham.SelectedValue.ToString());

                bus_sp.ThemSP(sp);
                Reset(); 
            }
            else
            {
                // Thông báo
                MessageBox.Show("Giá nhập, giá bán, số lượng phải là số và không để trống!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // frmSanPham_FormClosing
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

        // frmSanPham_Load
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // btnXoa_Click
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"Bạn có chắc muốn xóa +{txtMaSP.Text}+ không?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                bus_sp.XoaSP(txtMaSP.Text);
                Reset();
            }
        }

        // btnSua_Click
        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"Bạn có chắc muốn sửa thông tin +{txtMaSP.Text}+ không?", "Thông báo",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                DTO_SanPham sp = new DTO_SanPham(txtMaSP.Text, txtTenSP.Text,
            int.Parse(txtGiaNhap.Text), int.Parse(txtGiaBan.Text), int.Parse(txtSoLuong.Text), txtDonViTinh.Text, txtNoiSanXuat.Text,
            dtpHanSuDung.Value, cboNhaCungCap.SelectedValue.ToString(), cboLoaiSanPham.SelectedValue.ToString());

                bus_sp.SuaSP(sp);
                Reset();
            }
        }

        // dgvSP_Click
        private void dgvSP_Click(object sender, EventArgs e)
        {
            int n = dgvSP.CurrentCell.RowIndex;

            if (n >= 0)
            {
                // Buttons
                txtMaSP.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;

                // Textbox
                txtMaSP.Text = dgvSP.Rows[n].Cells[0].Value.ToString();
                txtTenSP.Text = dgvSP.Rows[n].Cells[1].Value.ToString();
                txtGiaNhap.Text = dgvSP.Rows[n].Cells[2].Value.ToString();
                txtGiaBan.Text = dgvSP.Rows[n].Cells[3].Value.ToString();
                txtSoLuong.Text = dgvSP.Rows[n].Cells[4].Value.ToString();
                txtDonViTinh.Text = dgvSP.Rows[n].Cells[5].Value.ToString();
                txtNoiSanXuat.Text = dgvSP.Rows[n].Cells[6].Value.ToString();

                // dtpHanSuDung
                dtpHanSuDung.Value = DateTime.Parse(dgvSP.Rows[n].Cells[7].Value.ToString());

                // cboNhaCungCap
                // Tìm tenNCC theoTenNCC
                cboNhaCungCap.DataSource = bus_ncc.LayDSNCC_TheoTenNCC(dgvSP.Rows[n].Cells[8].Value.ToString());
                cboNhaCungCap.DisplayMember = "TenNCC";
                cboNhaCungCap.ValueMember = "TenNCC";

                // Lưu lại tên NCC = strNCC
                string strNCC = cboNhaCungCap.SelectedValue.ToString();

                // Lấy lại hết NCC
                cboNhaCungCap.DataSource = bus_ncc.LayDSNCC();
                cboNhaCungCap.DisplayMember = "TenNCC";
                cboNhaCungCap.ValueMember = "MaNCC";

                // Tìm vị trí tenNCC
                cboNhaCungCap.SelectedIndex = cboNhaCungCap.FindStringExact(strNCC);

                // cboLoaiSanPham
                // Tìm tenLSP theo maLSP
                cboLoaiSanPham.DataSource = bus_lsp.LayDSLSP_TheoTenLSP(dgvSP.Rows[n].Cells[9].Value.ToString());
                cboLoaiSanPham.DisplayMember = "TenLoaiSP";
                cboLoaiSanPham.ValueMember = "TenLoaiSP";

                // Lưu lại tenLSP = strLSP
                string strLSP = cboLoaiSanPham.SelectedValue.ToString();

                // Lấy lại hết tenLSP
                cboLoaiSanPham.DataSource = bus_lsp.LayDSLSP();
                cboLoaiSanPham.DisplayMember = "TenLoaiSP";
                cboLoaiSanPham.ValueMember = "MaLoaiSP";

                // Tìm vị trí strLSP
                cboLoaiSanPham.SelectedIndex = cboLoaiSanPham.FindStringExact(strLSP);

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
