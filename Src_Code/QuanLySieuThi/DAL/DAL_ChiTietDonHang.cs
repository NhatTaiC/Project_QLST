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
        private int soLuongSP = 0;

        // Constructors
        public DAL_ChiTietDonHang(QLSTDataContext db, string serverName, string dbName, int soLuongSP)
        {
            this.db = db;
            this.serverName = serverName;
            this.dbName = dbName;
            this.soLuongSP= soLuongSP;
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
        public int SoLuongSP { get => soLuongSP; set => soLuongSP = value; }

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
                    // Check Chi Tiết Đơn Hàng đã có trong DB ChiTietDonHang hay chưa?
                    var temp = from ct in db.ChiTietDonHangs
                               where ct.MaChiTiet == ctdh.MaChiTiet
                               select ct;

                    if (temp.Count() != 1)
                    {
                        // Check Mã Sản Phẩm đã có trong DB ChiTietDonHang hay chưa?
                        var temp2 = from ct in db.ChiTietDonHangs
                                    where ct.MaSP == ctdh.MaSP
                                    select ct;

                        if (temp2.Count() != 1)
                        {
                            // Tìm MaSP để cập nhật lại số lượng cho Sản Phẩm đó trước khi thêm vào DB ChiTietDonHang
                            var temp3 = db.SanPhams.Single(sp => sp.MaSP == ctdh.MaSP);

                            // Cập nhật số lượng sản phẩm trong DB SanPham
                            int soLuongSPConLai = (int)(temp3.SoLuong - ctdh.SoLuong);

                            if (soLuongSPConLai >= 0)
                            {
                                temp3.SoLuong = soLuongSPConLai;

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

                                db.ChiTietDonHangs.InsertOnSubmit(ct_insert); // Thêm Chi Tiết Đơn Hàng vào DB ChiTietDonHang
                                db.SubmitChanges(); // Xác nhận thay đổi DB ChiTietDonHang

                                // Thông báo
                                MessageBox.Show($"Thêm chi tiết đơn hàng +{ctdh.MaChiTiet}+ thành công!", "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                                return true;
                            }
                            else
                            {
                                // Thông báo
                                MessageBox.Show($"Số lượng sản phẩm +{ctdh.MaSP}+ vừa nhập nhiều hơn Sản Phẩm có trong danh sách Sản Phẩm, không thể thêm Chi Tiết Đơn Hàng!", "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            // Thông báo
                            MessageBox.Show($"Mã sản phẩm +{ctdh.MaSP}+ đã có trong danh sách chi tiết đơn hàng!", "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Thông báo
                        MessageBox.Show($"Chi tiết đơn hàng +{ctdh.MaDon}+ đã có trong danh sách chi tiết đơn hàng!", "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Mã chi tiết đơn hàng không hợp lệ!", "Thông báo",
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
        public bool XoaChiTietDonHang(DTO_ChiTietDonHang ctdh)
        {
            try
            {
                // Check xem MaChiTiet != null không? mới Xóa
                if (ctdh.MaChiTiet != string.Empty)
                {
                    // Cập nhật số lượng Sản Phẩm trước khi xóa ChiTietDonHang khỏi DB
                    var temp = db.SanPhams.Single(sp => sp.MaSP == ctdh.MaSP);
                    temp.SoLuong = temp.SoLuong + ctdh.SoLuong;

                    // Tìm maCTDH để xóa = maCTDH
                    var ctdh_delete = from ct in db.ChiTietDonHangs
                                      where ct.MaChiTiet == ctdh.MaChiTiet
                                      select ct;

                    foreach (var item in ctdh_delete)
                    {
                        db.ChiTietDonHangs.DeleteOnSubmit(item); // Xóa CTDH trong DB CTDH
                        db.SubmitChanges(); // Xác nhận thay đổi DB CTDH
                    }

                    // Thông báo
                    MessageBox.Show($"Xóa chi tiết đơn hàng +{ctdh.MaChiTiet}+ thành công!", "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return true;

                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Mã chi tiết đơn hàng không hợp lệ!", "Thông báo",
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
        public bool SuaChiTietDonHang(DTO_ChiTietDonHang ctdh)
        {
            try
            {
                // Check xem MaChiTiet có != null không?
                if (ctdh.MaChiTiet != string.Empty)
                {
                    // Cập nhật lại số lượng sản phẩm trong DB SanPham
                    var temp = db.SanPhams.Single(s => s.MaSP == ctdh.MaSP);

                    int tongSP = (int)temp.SoLuong;

                    if (ctdh.SoLuong <= tongSP)
                    {
                        int soLuongSPConLai = (int)(tongSP - ctdh.SoLuong);

                        temp.SoLuong = soLuongSPConLai;

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
                        MessageBox.Show($"Sửa thông tin chi tiết đơn hàng +{ctdh.MaChiTiet}+ thành công!", "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        return true;
                    }
                    else
                    {
                        // Thông báo
                        MessageBox.Show($"Số lượng sản phẩm +{ctdh.MaSP}+ vừa nhập nhiều hơn tổng sản phẩm +{temp.SoLuong}+ có trong danh sách Sản Phẩm, không thể sửa thông tin Chi Tiết Đơn Hàng!", "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Mã chi tiết đơn hàng không hợp lệ!", "Thông báo",
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

        // TimDonHang_TheoMaCT()
        public IQueryable TimDonHang_TheoMaCT(string maCT)
        {
            IQueryable temp = from ct in db.ChiTietDonHangs
                              where ct.MaDon == maCT
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

        // TimDonHang_TheoMaDon()
        public IQueryable TimDonHang_TheoMaDon(string maDon)
        {
            IQueryable temp = from ct in db.ChiTietDonHangs
                              where ct.MaDon == maDon
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
    }
}
