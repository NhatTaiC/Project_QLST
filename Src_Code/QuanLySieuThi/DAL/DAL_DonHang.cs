/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 28/04/2024
 * DAL_DonHang.cs
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
    public class DAL_DonHang
    {
        // Fields
        private QLSTDataContext db;
        private string serverName = ".\\SQLEXPRESS";
        private string dbName = "QLST";

        // Constructors
        public DAL_DonHang(QLSTDataContext db, string serverName, string dbName)
        {
            this.db = db;
            this.serverName = serverName;
            this.dbName = dbName;
        }

        public DAL_DonHang()
        {
            string sql = "Data Source=" + ServerName + ";Initial Catalog=" + DbName + ";Integrated Security=True;";
            db = new QLSTDataContext(sql);
        }

        // Properties
        public QLSTDataContext Db { get => db; set => db = value; }
        public string ServerName { get => serverName; set => serverName = value; }
        public string DbName { get => dbName; set => dbName = value; }

        // Methods
        // LayDSDonHang()
        public IQueryable LayDSDonHang()
        {
            IQueryable temp = from dh in db.DonHangs
                              select new
                              {
                                  MaDon = dh.MaDon,
                                  NgayBan = dh.NgayBan,
                                  TongGiaTri = dh.TongGiaTri,
                                  MaNV = dh.MaNV
                              };
            return temp;
        }

        // ThemDonHang()
        public bool ThemDonHang(DTO_DonHang dh)
        {
            try
            {
                // Check dh.MaDon có != null hay không?
                if (dh.MaDon != string.Empty)
                {
                    // Check xem Đơn Hàng đã có trong DB DonHang hay chưa?
                    var temp = from d in db.DonHangs
                               where d.MaDon == dh.MaDon
                               select d;

                    if (temp.Count() != 1)
                    {
                        // Tạo đối tượng Đơn Hàng
                        DonHang dh_insert = new DonHang
                        {
                            MaDon = dh.MaDon,
                            NgayBan = dh.NgayBan,
                            TongGiaTri = dh.TongGiaTri,
                            MaNV = dh.MaNV
                        };

                        db.DonHangs.InsertOnSubmit(dh_insert); // Thêm Đơn Hàng vào DB DonHang
                        db.SubmitChanges(); // Xác nhận thêm Đơn Hàng vào DB DonHang

                        // Thông báo
                        MessageBox.Show($"Thêm đơn hàng +{dh.MaDon}+ thành công!", "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        // Thông báo
                        MessageBox.Show($"Đơn hàng +{dh.MaDon}+ đã có trong danh sách đơn hàng!", "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    } 
                }
                // Thông báo
                MessageBox.Show("Mã đơn hàng không hợp lệ!", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Throw Exception
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        // XoaDonHang()
        public bool XoaDonHang(string maDonHang){
            try
            {
                // Check xoaDonHang có != null không mới xóa
                if (maDonHang != string.Empty)
                {
                    // Tìm Đơn Hàng Cần Xóa = Mã Đơn Hàng
                    var d_delete = from d in db.DonHangs
                                   where d.MaDon == maDonHang
                                   select d;

                    foreach (var item in d_delete)
                    {
                        db.DonHangs.DeleteOnSubmit(item); // Xóa Đơn Hàng
                        db.SubmitChanges(); // Xác nhận Xóa Đơn Hàng trong DB DonHang
                    }

                    // Thông báo
                    MessageBox.Show($"Xóa đơn hàng +{maDonHang}+ thành công!", "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return true; 
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Mã đơn hàng không hợp lệ!", "Thông báo",
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

        // SuaDonHang()
        public bool SuaDonHang(DTO_DonHang dh) {
            try
            {
                // Check dh.MaDon có != null không mới sửa thông tin
                if (dh.MaDon != string.Empty)
                {
                    // Tìm Đơn Hàng cần sửa thông tin
                    var d_update = db.DonHangs.Single(d => d.MaDon == dh.MaDon);

                    // Update Thông tin Đơn Hàng
                    d_update.NgayBan = dh.NgayBan;
                    d_update.TongGiaTri = dh.TongGiaTri;

                    // Xác nhận sửa thông tin Đơn Hàng
                    db.SubmitChanges();

                    // Thông báo
                    MessageBox.Show($"Sửa thông tin đơn hàng +{dh.MaDon}+ thành công!", "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Mã đơn hàng không hợp lệ!", "Thông báo",
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

        // TimDonHang_TheoMaDH()
        public IQueryable TimDonHang_TheoMaDH(string maDH) {
            IQueryable temp = from dh in db.DonHangs
                              where dh.MaDon == maDH
                              select new
                              {
                                  MaDon = dh.MaDon,
                                  NgayBan = dh.NgayBan,
                                  TongGiaTri = dh.TongGiaTri,
                                  MaNV = dh.MaNV
                              };
            return temp;
        }

        // TimDonHang_TheoMaNV()
        public IQueryable TimDonHang_TheoMaNV(string maNV)
        {
            IQueryable temp = from dh in db.DonHangs
                              join nv in db.NhanViens
                              on dh.MaNV equals nv.MaNV
                              where nv.MaNV == maNV
                              select new
                              {
                                  MaDon = dh.MaDon,
                                  NgayBan = dh.NgayBan,
                                  TongGiaTri = dh.TongGiaTri,
                                  MaNV = nv.MaNV
                              };
            return temp;
        }

        // TimDonHang_TheoNgayBan()
        public int TimDonHang_TheoNgayBan(DateTime ngayBan)
        {
            var temp = from dh in db.DonHangs
                       where dh.NgayBan == ngayBan
                       select dh;
            return temp.Count();
        }

        // TimDonHang_TheoTenNV()
        public int TimDonHang_TheoTenNV(string tenNV)
        {
            var temp = from nv in db.NhanViens
                       join dh in db.DonHangs
                       on nv.MaNV equals dh.MaNV
                       where nv.TenNV.Contains(tenNV)
                       select new {
                           TenNV = nv.TenNV
                       };
            return temp.Count();
        }

        // TimDonHang_TheoMaDH_2()
        public int TimDonHang_TheoMaDH_2(string maDH)
        {
            var temp = from dh in db.DonHangs
                              where dh.MaDon == maDH
                              select new
                              {
                                  MaDon = dh.MaDon,
                                  NgayBan = dh.NgayBan,
                                  TongGiaTri = dh.TongGiaTri,
                                  MaNV = dh.MaNV
                              };
            return temp.Count();
        }
    }
}
