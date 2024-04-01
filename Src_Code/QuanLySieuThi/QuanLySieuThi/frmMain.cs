/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 01/04/2024
 * frmMain.cs
 */
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //Function CheckFormExist
        private bool CheckFormExist(string name)
        {
            foreach (Form item in MdiChildren)
            {
                if (item.Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        //Function ActForm
        private void ActForm(string name) {
            foreach (Form item in MdiChildren)
            {
                if (item.Name == name)
                {
                    item.Activate();
                    break;
                }
            }
        }

        //Form Closing
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //ThoatMNS_Click
        private void thoatMNS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //TaiKhoanMNS_Click
        private void taiKhoanMNS_Click(object sender, EventArgs e)
        {
            if (!CheckFormExist("frmTaiKhoan"))
            {
                frmTaiKhoan f = new frmTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmTaiKhoan");
            }
        }
    }
}
