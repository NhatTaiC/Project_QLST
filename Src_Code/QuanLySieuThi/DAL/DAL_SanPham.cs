/*
* Châu Nhật Tài, Lê Văn Toàn
* Project CN.NET
* Quản Lý Siêu Thị
* 29/04/2024
* DAL_SanPham.cs
*/
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_SanPham
    {
        // Fields
        private QLSTDataContext db;
        private string serverName = ".\\SQLEXPRESS";
        private string dbName = "QLST";

        // Constructors
        public DAL_SanPham(QLSTDataContext db, string serverName, string dbName)
        {
            this.db = db;
            this.serverName = serverName;
            this.dbName = dbName;
        }

        public DAL_SanPham()
        {
            string sql = "Data Source=" + ServerName + ";Initial Catalog=" + DbName + ";Integrated Security=True;";
            db = new QLSTDataContext(sql);
        }

        // Properties
        public QLSTDataContext Db { get => db; set => db = value; }
        public string ServerName { get => serverName; set => serverName = value; }
        public string DbName { get => dbName; set => dbName = value; }

        // Methods
        // LayDSSP()
        public IQueryable LayDSSP()
        {
            IQueryable temp = from sp in db.SanPhams
                              select new
                              {
                                  MaSP = sp.MaSP,
                                  TenSP = sp.TenSP,
                                  GiaNhap = sp.GiaNhap,
                                  GiaBan = sp.GiaBan,
                                  SoLuong = sp.SoLuong,
                                  DonViTinh = sp.DonViTinh,
                                  NoiSanXuat = sp.NoiSanXuat,
                                  HanSuDung = sp.HanSuDung,
                                  MaNCC = sp.MaNCC,
                                  MaLoaiSP = sp.MaLoaiSP
                              };
            return temp;
        }

        // LayDSSP_TheoMaSP()
        public IQueryable LayDSSP_TheoMaSP(string maSP)
        {
            IQueryable temp = from sp in db.SanPhams
                              where sp.MaSP == maSP
                              select new
                              {
                                  MaSP = sp.MaSP,
                                  TenSP = sp.TenSP,
                                  GiaNhap = sp.GiaNhap,
                                  GiaBan = sp.GiaBan,
                                  SoLuong = sp.SoLuong,
                                  DonViTinh = sp.DonViTinh,
                                  NoiSanXuat = sp.NoiSanXuat,
                                  HanSuDung = sp.HanSuDung,
                                  MaNCC = sp.MaNCC,
                                  MaLoaiSP = sp.MaLoaiSP
                              };
            return temp;
        }

        // ThemSP()
        public bool ThemSP(DTO_SanPham sp)
        {
            try
            {
                // Check sp.MaSP có != null hay không?
                if (sp.MaSP != string.Empty)
                {
                    // Check Sản Phẩm đã có trong DB SanPham hay chưa?
                    var temp = from s in db.SanPhams
                               where s.MaSP == sp.MaSP
                               select s;

                    if (temp.Count() != 1)
                    {
                        // Tạo đối tượng sản phẩm
                        SanPham sp_insert = new SanPham
                        {
                            MaSP = sp.MaSP,
                            TenSP = sp.TenSP,
                            GiaNhap = sp.GiaNhap,
                            GiaBan = sp.GiaBan,
                            SoLuong = sp.SoLuong,
                            DonViTinh = sp.DonViTinh,
                            NoiSanXuat = sp.NoiSanXuat,
                            HanSuDung = sp.HanSuDung,
                            MaNCC = sp.MaNCC,
                            MaLoaiSP = sp.MaLoaiSP
                        };

                        db.SanPhams.InsertOnSubmit(sp_insert); // Thêm Sản Phẩm mới vào DB SanPham
                        db.SubmitChanges(); // Xác nhận thay đổi DB SanPham

                        // Thông báo
                        MessageBox.Show($"Thêm sản phẩm +{sp.MaSP}+ thành công!", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        // Thông báo
                        MessageBox.Show($"Sản phẩm +{sp.MaSP}+ đã có trong danh sách sản phẩm!", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Mã sản phẩm không hợp lệ!", "Thông báo", MessageBoxButtons.OK,
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

        // XoaSP()
        public bool XoaSP(string maSP)
        {
            try
            {
                // Check sp.MaSP có != null hay không?
                if (maSP != string.Empty)
                {
                    // Tìm sản phẩm muốn xóa == maSP
                    var sp_delete = from sp in db.SanPhams
                                    where sp.MaSP == maSP
                                    select sp;

                    foreach (var item in sp_delete)
                    {
                        db.SanPhams.DeleteOnSubmit(item); // Xóa Sản Phẩm trong DB SanPham
                        db.SubmitChanges(); // Xác nhận thay đổi DB SanPham
                    }

                    // Thông báo
                    MessageBox.Show($"Xóa sản phẩm +{maSP}+ thành công!", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return true;

                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Mã sản phẩm không hợp lệ!", "Thông báo", MessageBoxButtons.OK,
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

        // SuaSP()
        public bool SuaSP(DTO_SanPham sp)
        {
            try
            {
                // Check sp.MaSP có != null hay không?
                if (sp.MaSP != string.Empty)
                {
                    // Tìm sản phẩm để sửa thông tin == sp.MaSP
                    var sp_update = db.SanPhams.Single(s => s.MaSP == sp.MaSP);

                    // Cập nhật thông tin sản phẩm
                    sp_update.TenSP = sp.TenSP;
                    sp_update.GiaNhap = sp.GiaNhap;
                    sp_update.GiaBan = sp.GiaBan;
                    sp_update.SoLuong = sp.SoLuong;
                    sp_update.DonViTinh = sp.DonViTinh;
                    sp_update.NoiSanXuat = sp.NoiSanXuat;
                    sp_update.HanSuDung = sp.HanSuDung;
                    sp_update.MaNCC = sp.MaNCC;
                    sp_update.MaLoaiSP = sp.MaLoaiSP;

                    // Xác nhận thay đổi DB SanPham
                    db.SubmitChanges();

                    // Thông báo
                    MessageBox.Show($"Sửa thông tin sản phẩm +{sp.MaSP}+ thành công!", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return true;

                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Mã sản phẩm không hợp lệ!", "Thông báo", MessageBoxButtons.OK,
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

        // TimSP_TheoTenSP()
        public IQueryable TimSP_TheoTenSP(string tenSP)
        {
            IQueryable temp = from sp in db.SanPhams
                              where sp.TenSP.Contains(tenSP)
                              select new
                              {
                                  MaSP = sp.MaSP,
                                  TenSP = sp.TenSP,
                                  GiaNhap = sp.GiaNhap,
                                  GiaBan = sp.GiaBan,
                                  SoLuong = sp.SoLuong,
                                  DonViTinh = sp.DonViTinh,
                                  NoiSanXuat = sp.NoiSanXuat,
                                  HanSuDung = sp.HanSuDung,
                                  MaNCC = sp.MaNCC,
                                  MaLoaiSP = sp.MaLoaiSP
                              };
            return temp;
        }

        // TimSP_TheoMaSP()
        public IQueryable TimSP_TheoMaSP(string maSP) {
            IQueryable temp = from sp in db.SanPhams
                              where sp.MaSP == maSP
                              select new
                              {
                                  MaSP = sp.MaSP,
                                  TenSP = sp.TenSP,
                                  GiaNhap = sp.GiaNhap,
                                  GiaBan = sp.GiaBan,
                                  SoLuong = sp.SoLuong,
                                  DonViTinh = sp.DonViTinh,
                                  NoiSanXuat = sp.NoiSanXuat,
                                  HanSuDung = sp.HanSuDung,
                                  MaNCC = sp.MaNCC,
                                  MaLoaiSP = sp.MaLoaiSP
                              };
            return temp;
        }
    }
}
