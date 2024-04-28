/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 28/04/2024
 * DAL_ChiTietDonHang.cs
 */
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_ChiTietDonHang
    {
        // Fields
        private QLSTDataContext db;
        private string serverName = ".\\SQLEXPRESS";
        private string dbName = "QLST";

        // Constructors
        public DAL_ChiTietDonHang(QLSTDataContext db, string serverName, string dbName)
        {
            this.db = db;
            this.serverName = serverName;
            this.dbName = dbName;
        }

        public DAL_ChiTietDonHang()
        {
            string sql = "Data Source=" + ServerName + ";Initial Catalog=" + DbName + ";Integrated Security=True;";
            db = new QLSTDataContext(sql);
        }

        // Properties
        public QLSTDataContext Db { get => db; set => db = value; }
        public string ServerName { get => serverName; set => serverName = value; }
        public string DbName { get => dbName; set => dbName = value; }

        // Methods
        // LayDSChiTietDonHang()
        public IQueryable LayDSChiTietDonHang()
        {
            IQueryable temp = from ct in db.ChiTietDonHangs
                              select new
                              {
                                  MaChiTiet = ct.MaChiTiet,
                                  MaDon = ct.MaDon,
                                  MaSP = ct.MaSP,
                                  TenSP = ct.TenSP,
                                  GiaBan = ct.GiaBan,
                                  SoLuong = ct.SoLuong,
                                  ThanhTien = ct.ThanhTien,
                                  DonViTinh = ct.DonViTinh
                              };
            return temp;
        }

        // ThemChiTietDonHang()
        public bool ThemChiTietDonHang(DTO_ChiTietDonHang ctdh) {
            try
            {
                // Check xem MaChiTiet, MaDon, MaSP có != null không?
                if (ctdh.MaChiTiet != string.Empty && ctdh.MaDon != string.Empty )
                {

                }
            }
            catch (Exception ex)
            {
                // Throw Exception
                MessageBox.Show(ex.Message);
            }
            return false;
        }
    }
}
