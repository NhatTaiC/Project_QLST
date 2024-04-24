﻿/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 22/04/2024
 * BUS_NhanVien.cs
 */
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_NhanVien
    {
        // Fields
        private DAL_NhanVien dal_nv = new DAL_NhanVien();

        // Methods
        // LayDSNV()
        public IQueryable LayDSNV()
        {
            return dal_nv.LayDSNV();
        }

        // ThemNV()
        public bool ThemNV(DTO_NhanVien nv)
        {
            return dal_nv.ThemNV(nv);
        }

        // XoaNV()
        public bool XoaNV(string nv, string tk)
        {
            return dal_nv.XoaNV(nv, tk);
        }

        // SuaNV()
        public bool SuaNV(DTO_NhanVien nv)
        {
            return dal_nv.SuaNV(nv);
        }

        // LayDSNV_TheoMaNV()
        public IQueryable LayDSNV_TheoMaNV(string nv)
        {
            return dal_nv.LayDSNV_TheoMaNV(nv);
        }

        // LayDSNV_TheoMaNV2()
        public int LayDSNV_TheoMaNV2(string nv)
        {
            return dal_nv.LayDSNV_TheoMaNV2(nv);
        }
    }
}