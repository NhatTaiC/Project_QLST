﻿/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 01/04/2024
 * DTO_TaiKhoan.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TaiKhoan
    {
        //Fields
        private string taiKhoan;
        private string matKhau;
        private string hoTen;
        private DateTime ngayTao;
        private string chucVu;

        //Constructors
        public DTO_TaiKhoan(string taiKhoan, string matKhau, string hoTen, DateTime ngayTao, string chucVu)
        {
            this.TaiKhoan = taiKhoan;
            this.MatKhau = matKhau;
            this.HoTen = hoTen;
            this.NgayTao = ngayTao;
            this.ChucVu = chucVu;
        }

        //Properties
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
    }
}
