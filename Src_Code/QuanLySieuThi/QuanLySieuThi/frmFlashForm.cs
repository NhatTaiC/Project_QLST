﻿/*
* Châu Nhật Tài, Lê Văn Toàn
* Project CN.NET
* Quản Lý Siêu Thị
* 05/05/2024
* frmFlashForm.cs
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
    public partial class frmFlashForm : Form
    {
        public frmFlashForm()
        {
            InitializeComponent();
        }

        // Initialize Variables
        public static SqlConnection Con; // Khai báo đối tượng kết nối DB

        // Function OpenConnect()
        public void OpenConnect()
        {
            // Mở kết nối DB
            Con = new SqlConnection();
            Con.ConnectionString = Properties.Settings.Default.tspConnect;
            Con.Open();
        }

        // frmFlashForm_Load
        private void frmFlashForm_Load(object sender, EventArgs e)
        {
            //// Mở kết nối DB
            //OpenConnect();
        }

        // timer1_Tick
        private void timer1_Tick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            timer1.Enabled = false;
        }
    }
}
