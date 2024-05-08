/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 05/05/2024
 * frmTraCuuSanPham.cs
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
    public partial class frmTraCuuSanPham : Form
    {
        public frmTraCuuSanPham()
        {
            InitializeComponent();
        }

        // Initialize Variables
        BUS_SanPham bus_sp = new BUS_SanPham();

        // Function LoadData()
        public void LoadData()
        {
            // txtNoiDung
            txtNoiDung.Focus();

            // cboTraCuu
            cboTraCuu.SelectedIndex = 0;

            // dgvTraCuuNV 
            dgvTraCuuSanPham.DataSource = bus_sp.LayDSSP_2();

            // Columns["HanSuDung"]
            dgvTraCuuSanPham.Columns["HanSuDung"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        // Function Reset()
        public void Reset()
        {
            // Reset Text
            txtNoiDung.Text = string.Empty;
            gbDGVTraCuuSanPham.Text = $"Kết Quả Tra Cứu:";

            // Called LoadData()
            LoadData();
        }

        // frmTraCuuSanPham_FormClosing
        private void frmTraCuuSanPham_FormClosing(object sender, FormClosingEventArgs e)
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

        // frmTraCuuSanPham_Load
        private void frmTraCuuSanPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // btnTim_Click
        private void btnTim_Click(object sender, EventArgs e)
        {
            // Check NoiDung đã được nhập chưa trước khi tra cứu
            if (txtNoiDung.Text != string.Empty)
            {
                // Tra Cứu
                if (dgvTraCuuSanPham.RowCount != 0)
                {
                    if (cboTraCuu.SelectedItem.ToString() == "Tên Sản Phẩm")
                    {
                        dgvTraCuuSanPham.DataSource = bus_sp.TimSP_TheoTenSP_2(txtNoiDung.Text);
                        gbDGVTraCuuSanPham.Text = $"Kết Quả Tra Cứu: {dgvTraCuuSanPham.RowCount}";
                    }
                    else if (cboTraCuu.SelectedItem.ToString() == "Mã Sản Phẩm")
                    {
                        dgvTraCuuSanPham.DataSource = bus_sp.TimSP_TheoMaSP_2(txtNoiDung.Text);
                        gbDGVTraCuuSanPham.Text = $"Kết Quả Tra Cứu: {dgvTraCuuSanPham.RowCount}";
                    }
                    else if (cboTraCuu.SelectedItem.ToString() == "Giá Bán Sản Phẩm")
                    {
                        dgvTraCuuSanPham.DataSource = bus_sp.TimSP_TheoGiaBan(txtNoiDung.Text);
                        gbDGVTraCuuSanPham.Text = $"Kết Quả Tra Cứu: {dgvTraCuuSanPham.RowCount}";
                    }
                    else
                    {
                        dgvTraCuuSanPham.DataSource = bus_sp.TimSP_TheoDonViTinh(txtNoiDung.Text);
                        gbDGVTraCuuSanPham.Text = $"Kết Quả Tra Cứu: {dgvTraCuuSanPham.RowCount}";
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
    }
}
