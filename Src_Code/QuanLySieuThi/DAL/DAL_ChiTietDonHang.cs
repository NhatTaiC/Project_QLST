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
using System.Text.RegularExpressions;
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
        public bool ThemChiTietDonHang(DTO_ChiTietDonHang ctdh)
        {
            try
            {
                // Check xem MaChiTiet, MaDon, MaSP có != null không?
                if (ctdh.MaChiTiet != string.Empty)
                {
                    // Tạo đối tượng Chi Tiết Đơn Hàng
                    ChiTietDonHang ct_insert = new ChiTietDonHang
                    {
                        MaChiTiet = ctdh.MaChiTiet,
                        MaDon = ctdh.MaDon,
                        MaSP = ctdh.MaSP,
                        TenSP = ctdh.TenSP,
                        GiaBan = ctdh.GiaBan,
                        SoLuong = ctdh.SoLuong,
                        ThanhTien = ctdh.ThanhTien,
                        DonViTinh = ctdh.DonViTinh
                    };

                    // Check Chi Tiết Đơn Hàng đã có trong DB ChiTietDonHang hay chưa?
                    var temp = from ct in db.ChiTietDonHangs
                               where ct.MaChiTiet == ctdh.MaChiTiet
                               select ct;

                    if (temp.Count() != 1)
                    {
                        db.ChiTietDonHangs.InsertOnSubmit(ct_insert); // Thêm Chi Tiết Đơn Hàng vào DB ChiTietDonHang
                        db.SubmitChanges(); // Xác nhận thay đổi DB ChiTietDonHang

                        // Thông báo
                        MessageBox.Show("Thêm Chi Tiết Đơn Hàng mới thành công!", "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        return true;
                    }
                    else
                    {
                        // Thông báo
                        MessageBox.Show("Chi Tiết Đơn Hàng đã có trong DB ChiTietDonHang!", "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Mã Chi Tiết Đơn Hàng không hợp lệ, Không thể thêm!", "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Throw Exception
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        // XoaChiTietDonHang()
        public bool XoaChiTietDonHang(string maCTDH)
        {
            try
            {
                // Check xem MaChiTiet != null không? mới Xóa
                if (maCTDH != string.Empty)
                {
                    // Tìm maCTDH để xóa = maCTDH
                    var ctdh_delete = from ct in db.ChiTietDonHangs
                                      where ct.MaChiTiet == maCTDH
                                      select ct;

                    foreach (var item in ctdh_delete)
                    {
                        db.ChiTietDonHangs.DeleteOnSubmit(item); // Xóa CTDH trong DB CTDH
                        db.SubmitChanges(); // Xác nhận thay đổi DB CTDH
                    }

                    // Thông báo
                    MessageBox.Show("Xóa Chi Tiết Đơn Hàng thành công!", "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return true;

                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Mã Chi Tiết Đơn Hàng không hợp lệ, Không thể thêm!", "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Throw Exception
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        // SuaChiTietDonHang()
        public bool SuaChiTietDonHang(DTO_ChiTietDonHang ctdh) {
            try
            {
                // Check xem MaChiTiet, MaDon, MaSP có != null không?
                if (ctdh.MaChiTiet != string.Empty)
                {
                    // Tìm CTDH trong DB CTDH
                    var ctdh_update = db.ChiTietDonHangs.Single(ct => ct.MaChiTiet == ctdh.MaChiTiet);

                    // Cập nhật thông tin CTDH
                    ctdh_update.TenSP = ctdh.TenSP;
                    ctdh_update.GiaBan = ctdh.GiaBan;
                    ctdh_update.SoLuong = ctdh.SoLuong;
                    ctdh_update.ThanhTien = ctdh.ThanhTien;
                    ctdh_update.DonViTinh = ctdh.DonViTinh;

                    // Xác nhận thay đổi DB CTDH
                    db.SubmitChanges();

                    // Thông báo
                    MessageBox.Show("Sửa thông tin Chi Tiết Đơn Hàng thành công!", "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return true;

                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Mã Chi Tiết Đơn Hàng không hợp lệ, Không thể thêm!", "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
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
