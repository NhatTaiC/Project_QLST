/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 01/04/2024
 * program.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //// Mở frmFlashForm trước
            //frmFlashForm f = new frmFlashForm();
            //f.ShowDialog();

            //// Xác thực frmFlash == OK
            //if (f.DialogResult == DialogResult.OK)
            //{
            //    // Mở frmDangNhap
            //    frmDangNhap f1 = new frmDangNhap();
            //    f1.ShowDialog();
            //}

            Application.Run(new frmChiTietDonHang());
        }
    }
}
