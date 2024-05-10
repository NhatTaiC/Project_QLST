/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 05/05/2024
 * frmTraCuuNhanVien.cs
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
    public partial class frmTraCuuNhanVien : Form
    {
        public frmTraCuuNhanVien()
        {
            InitializeComponent();
        }

        // Initialize Variables
        BUS_NhanVien bus_nv = new BUS_NhanVien();

        // Function LoadData()
        public void LoadData() {
            // txtNoiDung
            txtNoiDung.Focus();

            // cboTraCuu
            cboTraCuu.SelectedIndex = 0;

            // dgvTraCuuNV 
            dgvTraCuuNV.DataSource = bus_nv.LayDSNV();
            dgvTraCuuNV.Columns[0].HeaderText = "Mã Nhân Viên";
            dgvTraCuuNV.Columns[1].HeaderText = "Tên Nhân Viên";
            dgvTraCuuNV.Columns[2].HeaderText = "Ngày Sinh";
            dgvTraCuuNV.Columns[3].HeaderText = "Giới Tính";
            dgvTraCuuNV.Columns[4].HeaderText = "Địa Chỉ";
            dgvTraCuuNV.Columns[5].HeaderText = "Số Điện Thoại";
            dgvTraCuuNV.Columns[6].HeaderText = "Tài Khoản";

            // Columns["NgaySinh"]
            dgvTraCuuNV.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        // Function Reset()
        public void Reset() { 
            // Reset Text
            txtNoiDung.Text = string.Empty;
            gbDGVTraCuuNV.Text = $"Kết Quả Tra Cứu:";

            // Called LoadData()
            LoadData();
        }

        // frmTraCuuNhanVien_FormClosing
        private void frmTraCuuNhanVien_FormClosing(object sender, FormClosingEventArgs e)
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

        // btnTraCuu_Click
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            // Check NoiDung đã được nhập chưa trước khi tra cứu
            if (txtNoiDung.Text != string.Empty)
            {
                // Tra Cứu
                if (dgvTraCuuNV.RowCount != 0)
                {
                    if (cboTraCuu.SelectedItem.ToString() == "Tên Nhân Viên")
                    {
                        dgvTraCuuNV.DataSource = bus_nv.TimNV_TheoTenNV_2(txtNoiDung.Text);
                        gbDGVTraCuuNV.Text = $"Kết Quả Tra Cứu: {dgvTraCuuNV.RowCount}";
                    }
                    else if (cboTraCuu.SelectedItem.ToString() == "Mã Nhân Viên")
                    {
                        dgvTraCuuNV.DataSource = bus_nv.TimNV_TheoMaNV_2(txtNoiDung.Text);
                        gbDGVTraCuuNV.Text = $"Kết Quả Tra Cứu: {dgvTraCuuNV.RowCount}";
                    }
                    else if (cboTraCuu.SelectedItem.ToString() == "Giới Tính Nhân Viên")
                    {
                        dgvTraCuuNV.DataSource = bus_nv.TimNV_TheoGioiTinh(txtNoiDung.Text);
                        gbDGVTraCuuNV.Text = $"Kết Quả Tra Cứu: {dgvTraCuuNV.RowCount}";
                    }
                    else
                    {
                        dgvTraCuuNV.DataSource = bus_nv.TimNV_TheoNamSinh(txtNoiDung.Text);
                        gbDGVTraCuuNV.Text = $"Kết Quả Tra Cứu: {dgvTraCuuNV.RowCount}";
                    }
                }
                else
                {
                    MessageBox.Show("Nội dung bạn tìm không có trong dữ liệu!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    Reset();
                }
            }
            else
            {
                // Thông báo
                MessageBox.Show("Vui lòng không để trống nội dung cần tra cứu!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // frmTraCuuNhanVien_Load
        private void frmTraCuuNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
