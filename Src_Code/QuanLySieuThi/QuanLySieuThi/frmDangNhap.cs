/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 05/05/2024
 * frmDangNhap.cs
 */
using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        // Initialize Variables
        BUS_TaiKhoan bus_tk = new BUS_TaiKhoan();
        public static SqlConnection Con; // Khai báo đối tượng kết nối DB

        // Function LoadData()
        public void LoadData()
        {
            // txtTaiKhoan
            txtTaiKhoan.Focus();

            // cboChucVu
            cboChucVu.DataSource = bus_tk.LayDSTK_TheoChucVuAll();
            cboChucVu.DisplayMember = "ChucVu";
            cboChucVu.ValueMember = "ChucVu";
        }

        // Function Reset()
        public void Reset()
        {
            // Reset Text
            txtTaiKhoan.Text = string.Empty;
            txtMatKhau.Text = string.Empty;

            // Called LoadData()
            LoadData();
        }

        // Function OpenConnect()
        public void OpenConnect() {
            // Mở kết nối DB
            Con = new SqlConnection();
            Con.ConnectionString = Properties.Settings.Default.tspConnect;
            Con.Open();
        }

        // Function CloseConnect()
        public void CloseConnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close(); // Đóng kết nối DB
                Con.Dispose(); // Giải phóng tài nguyên
                Con = null;
            }
        }

        // frmDangNhap_Load
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            // Mở kết nối DB
            OpenConnect();

            // Nạp dữ liệu Tài khoản vào frmDangNhap
            LoadData();
        }

        // btnThoat_Click
        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Đóng kết nối DB
            CloseConnect();

            // Thoát APP
            Application.Exit();
        }

        // btnLamMoi_Click
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Reset();
        }

        // btnDangNhap_Click
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            string chucVu = cboChucVu.SelectedValue.ToString();

            if (bus_tk.CheckTaiKhoan(taiKhoan, matKhau, chucVu))
            {
                frmMain f = new frmMain(taiKhoan, chucVu);
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Thông tin tài khoản không hợp lệ!\nVui lòng kiểm tra lại các thông tin vừa nhập!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
