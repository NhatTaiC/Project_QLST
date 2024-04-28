/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 01/04/2024
 * frmTaiKhoan.cs
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
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        // Initialize Variables
        private BUS_TaiKhoan bus_tk = new BUS_TaiKhoan();
        private BUS_NhanVien bus_nv = new BUS_NhanVien();

        // Function LoadData
        private void LoadData() {
            // dgvTaiKhoan
            dgvTaiKhoan.DataSource = bus_tk.LayDSTK();

            // Columns["NgayTao"]
            dgvTaiKhoan.Columns["NgayTao"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // dtpTaiKhoan
            dtpTaiKhoan.Value = DateTime.Now;

            // Others
            txtTaiKhoan.Focus();
            cboChucVu.SelectedIndex = 1;
            txtTaiKhoan.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        // Function Reset
        private void Reset()
        {
            // Reset Text
            txtTaiKhoan.Text = string.Empty;
            txtMatKhau.Text = string.Empty;
            txtHoTen.Text = string.Empty;

            // Call LoadData()
            LoadData();
        }

        // Form Closing
        private void frmTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Thông báo
            DialogResult r = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        // BtnThoat_Click
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // BtnLamMoi_Click
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Reset();
        }

        // Form Load
        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // DgvTaiKhoan_Click
        private void dgvTaiKhoan_Click(object sender, EventArgs e)
        {
            // Get Index Row Selected
            int n = dgvTaiKhoan.CurrentCell.RowIndex;

            if (n >= 0)
            {
                // Others
                txtTaiKhoan.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;

                txtTaiKhoan.Text = dgvTaiKhoan.Rows[n].Cells[0].Value.ToString();
                txtMatKhau.Text = dgvTaiKhoan.Rows[n].Cells[1].Value.ToString();
                txtHoTen.Text = dgvTaiKhoan.Rows[n].Cells[2].Value.ToString();

                //Xử lý DateTimePicker
                dtpTaiKhoan.Value = DateTime.Parse(dgvTaiKhoan.Rows[n].Cells[3].Value.ToString());

                //Xử lý ComboBox
                if (dgvTaiKhoan.Rows[n].Cells[4].Value.ToString() == "0")
                {
                    cboChucVu.SelectedIndex = 0;
                }
                else
                {
                    cboChucVu.SelectedIndex = 1;
                }
            }
            else
            {
                // Thông báo
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa/sửa!", "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }
        
        // BtnThem_CLick
        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_TaiKhoan tk = new DTO_TaiKhoan(txtTaiKhoan.Text, txtMatKhau.Text,
            txtHoTen.Text, dtpTaiKhoan.Value.ToString(), int.Parse(cboChucVu.SelectedIndex.ToString()));

            bus_tk.ThemTK(tk);
            Reset();
        }

        // BtnXoa_Click
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Check TaiKhoan muốn xóa có gắn với NhanVien nào ko?
            int tk_nv = bus_nv.LayDSNV_TheoMaNV2(txtTaiKhoan.Text);

            if (tk_nv == 1)
            {
                DialogResult r = MessageBox.Show("Xóa Tài Khoản sẽ xóa luôn thông tin Nhân Viên gắn với Tài Khoản\n" +
                        $"\nBạn có chắc muốn xóa Tài Khoản +{txtHoTen.Text}+ không?", "Thông báo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                if (r == DialogResult.Yes)
                {
                    bus_tk.XoaTK(txtTaiKhoan.Text);
                    Reset();
                } 
            }
            else
            {
                DialogResult r = MessageBox.Show($"Bạn có chắc muốn xóa Tài Khoản +{txtHoTen.Text}+ không?", "Thông báo",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning);

                if (r == DialogResult.Yes)
                {
                    bus_tk.XoaTK(txtTaiKhoan.Text);
                    Reset();
                }
            }
        }

        // BtnSua_Click
        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"Bạn có chắc muốn sửa thông tin Tài Khoản +{txtHoTen.Text}+ không?", "Thông báo",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                DTO_TaiKhoan tk = new DTO_TaiKhoan(txtTaiKhoan.Text, txtMatKhau.Text,
                txtHoTen.Text, dtpTaiKhoan.Value.ToString(), int.Parse(cboChucVu.SelectedIndex.ToString()));

                bus_tk.SuaTK(tk);
                Reset();
            }
        }
    }
}
