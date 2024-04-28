/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 22/04/2024
 * DbSql.cs
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
    public class DbSql
    {
        // Fields
        private QLSTDataContext db;
        private string serverName = ".\\SQLEXPRESS";
        private string dbName = "QLST";

        // Constructors
        public DbSql(QLSTDataContext db, string serverName, string dbName)
        {
            this.db = db;
            this.serverName = serverName;
            this.dbName = dbName;
        }

        public DbSql()
        {
            string sql = "Data Source=" + ServerName + ";Initial Catalog=" + DbName + ";Integrated Security=True;";
            Db = new QLSTDataContext(sql);
        }

        // Properties
        public QLSTDataContext Db { get => db; set => db = value; }
        public string ServerName { get => serverName; set => serverName = value; }
        public string DbName { get => dbName; set => dbName = value; }

        // Methods
        // LayDSTK()
        public IQueryable LayDSTK()
        {
            // Truy vấn lấy DSTK
            IQueryable temp = from t in db.TaiKhoans
                              select t;
            return temp;
        }

        // ThemTK()
        public bool ThemTK(DTO_TaiKhoan tk)
        {
            try
            {
                // Tạo đối tượng TaiKhoan
                TaiKhoan t_insert = new TaiKhoan
                {
                    TaiKhoan1 = tk.TaiKhoan,
                    MatKhau = tk.MatKhau,
                    HoTen = tk.HoTen,
                    NgayTao = DateTime.Parse(tk.NgayTao),
                    ChucVu = tk.ChucVu
                };

                // Check TaiKhoan có # null ko mới add vào DB
                if (t_insert.TaiKhoan1 != string.Empty)
                {
                    db.TaiKhoans.InsertOnSubmit(t_insert); // Thêm DB
                    db.SubmitChanges(); // Xác nhận thay đổi DB
                    MessageBox.Show("Thêm thành công!", "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Tài khoản không hợp lệ!", "Thông báo",
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

        // XoaTK()
        public bool XoaTK(string tk)
        {
            try
            {
                // Check TaiKhoan có # null ko? mới xóa
                if (tk != string.Empty)
                {
                    // Truy vấn TaiKhoan có trong DSTK hay ko?
                    var t_delete = from t in db.TaiKhoans
                                   where t.TaiKhoan1 == tk
                                   select t;

                    // Xóa TK
                    foreach (var item in t_delete)
                    {
                        db.TaiKhoans.DeleteOnSubmit(item); // Xóa DB
                        db.SubmitChanges(); // Xác nhận thay đổi DB
                    }

                    MessageBox.Show("Xóa thành công!", "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Tài khoản không hợp lệ!", "Thông báo",
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

        // SuaTK()
        public bool SuaTK(DTO_TaiKhoan tk)
        {
            try
            {
                // Tạo đối tượng TaiKhoan = cách truy vấn DB
                TaiKhoan t_update = db.TaiKhoans.Single(t => t.TaiKhoan1 == tk.TaiKhoan);

                // Check TaiKhoan != Null ko? mới sửa thông tin TaiKhoan
                if (t_update.TaiKhoan1 != string.Empty)
                {
                    // Sửa thông tin TaiKhoan
                    t_update.MatKhau = tk.MatKhau;
                    t_update.HoTen = tk.HoTen;
                    t_update.NgayTao = DateTime.Parse(tk.NgayTao);
                    t_update.ChucVu = tk.ChucVu;

                    // Xác nhận thay đổi DB
                    db.SubmitChanges();

                    MessageBox.Show("Sửa thành công!", "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Tài khoản không hợp lệ!", "Thông báo",
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

        // LayDSTK_TheoTK()
        public IQueryable LayDSTK_TheoTK(string tk) {
            // Truy vấn DB
            IQueryable temp = from t in db.TaiKhoans
                              where t.TaiKhoan1 == tk
                              select t;
            return temp;
        }


        // LayDSLoaiSP()
        public IQueryable LayDSLoaiSP()
        {
            // Truy vấn lấy DSLoaiSP
            IQueryable temp = from t in db.LoaiSanPhams
                              select t;
            return temp;
        }
        // ThemLoaiSP()
        public bool ThemLoaiSP(DTO_LoaiSP lsp)
        {
            try
            {
                // Tạo đối tượng LoaiSP
                LoaiSanPham t_insert = new LoaiSanPham
                {
                    MaLoaiSP = lsp.MaLSP,
                    TenLoaiSP = lsp.TenLSP,
                    MoTa = lsp.MoTa,
                };

                // Check LoaiSP có # null ko mới add vào DB
                if (t_insert.MaLoaiSP != string.Empty)
                {
                    db.LoaiSanPhams.InsertOnSubmit(t_insert); // Thêm DB
                    db.SubmitChanges(); // Xác nhận thay đổi DB
                    MessageBox.Show("Thêm thành công!", "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Loại sản phẩm không hợp lệ!", "Thông báo",
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

        // XoaLoaiSP()
        public bool XoaLoaiSP(string lsp)
        {
            try
            {
                // Check LoaiSP có # null ko? mới xóa
                if (lsp != string.Empty)
                {
                    // Truy vấn LoaiSP có trong DSLoaiSP hay ko?
                    var t_delete = from t in db.LoaiSanPhams
                                   where t.MaLoaiSP == lsp
                                   select t;

                    // Xóa TK
                    foreach (var item in t_delete)
                    {
                        db.LoaiSanPhams.DeleteOnSubmit(item); // Xóa DB
                        db.SubmitChanges(); // Xác nhận thay đổi DB
                    }

                    MessageBox.Show("Xóa thành công!", "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Loại sản phẩm không hợp lệ!", "Thông báo",
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

        // SuaLoaiSP()
        public bool SuaLoaiSP(DTO_LoaiSP lsp)
        {
            try
            {
                // Tạo đối tượng LoaiSP = cách truy vấn DB
                LoaiSanPham t_update = db.LoaiSanPhams.Single(t => t.MaLoaiSP == lsp.MaLSP);

                // Check LoaiSP != Null ko? mới sửa thông tin LoaiSP
                if (t_update.MaLoaiSP != string.Empty)
                {
                    // Sửa thông tin LoaiSP
                    t_update.TenLoaiSP = lsp.TenLSP;
                    t_update.MoTa = lsp.MoTa;

                    // Xác nhận thay đổi DB
                    db.SubmitChanges();

                    MessageBox.Show("Sửa thành công!", "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Loại sản phẩm không hợp lệ!", "Thông báo",
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

        // LayDSLoaiSP_TheoMaSP()
        public IQueryable LayDSLSP_TheoMaLSP(string lsp)
        {
            // Truy vấn DB
            IQueryable temp = from t in db.LoaiSanPhams
                              where t.MaLoaiSP == lsp
                              select t;
            return temp;
        }

        //NCC
        // LayDSLoaiSP()
        public IQueryable LayDSNCC()
        {
            // Truy vấn lấy DSLoaiSP
            IQueryable temp = from t in db.NhaCungCaps
                              select t;
            return temp;
        }
        // ThemLoaiSP()
        public bool ThemNCC(DTO_NCC ncc)
        {
            try
            {
                // Tạo đối tượng NCC
                NhaCungCap t_insert = new NhaCungCap
                {
                    MaNCC = ncc.MaNCC,
                    TenNCC = ncc.TenNCC,
                    DiaChiNCC = ncc.DiaChiNCC,
                    SdtNCC = ncc.SdtNCC,
                };

                // Check NCC có # null ko mới add vào DB
                if (t_insert.MaNCC != string.Empty)
                {
                    db.NhaCungCaps.InsertOnSubmit(t_insert); // Thêm DB
                    db.SubmitChanges(); // Xác nhận thay đổi DB
                    MessageBox.Show("Thêm thành công!", "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Nhà cung cấp không hợp lệ!", "Thông báo",
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

        // XoaNCC()
        public bool XoaNCC(string maNCC)
        {
            try
            {
                // Check LoaiSP có # null ko? mới xóa
                if (maNCC != string.Empty)
                {
                    // Truy vấn LoaiSP có trong DSLoaiSP hay ko?
                    var t_delete = from t in db.NhaCungCaps
                                   where t.MaNCC == maNCC
                                   select t;

                    // Xóa TK
                    foreach (var item in t_delete)
                    {
                        db.NhaCungCaps.DeleteOnSubmit(item); // Xóa DB
                        db.SubmitChanges(); // Xác nhận thay đổi DB
                    }

                    MessageBox.Show("Xóa thành công!", "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Nhà cung cấp không hợp lệ!", "Thông báo",
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

        // SuaLoaiSP()
        public bool SuaNCC(DTO_NCC ncc)
        {
            try
            {
                // Tạo đối tượng LoaiSP = cách truy vấn DB
                NhaCungCap t_update = db.NhaCungCaps.Single(t => t.MaNCC == ncc.MaNCC);

                // Check LoaiSP != Null ko? mới sửa thông tin LoaiSP
                if (t_update.MaNCC != string.Empty)
                {
                    // Sửa thông tin LoaiSP
                    t_update.TenNCC = ncc.TenNCC;
                    t_update.DiaChiNCC = ncc.DiaChiNCC;
                    t_update.SdtNCC = ncc.SdtNCC;

                    // Xác nhận thay đổi DB
                    db.SubmitChanges();

                    MessageBox.Show("Sửa thành công!", "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Loại sản phẩm không hợp lệ!", "Thông báo",
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

        // LayDSTK_TheoTK()
        public IQueryable LayDSNCC_TheoMaNCC(string maNCC)
        {
            // Truy vấn DB
            IQueryable temp = from t in db.NhaCungCaps
                              where t.MaNCC == maNCC
                              select t;
            return temp;
        }


        //NCC
        // LayDSLoaiSP()
        public IQueryable LayDSSP()
        {
            // Truy vấn lấy DSLoaiSP
            IQueryable temp = from t in db.SanPhams
                              select t;
            return temp;
        }
        // ThemLoaiSP()
        public bool ThemSP(DTO_SanPham sp)
        {
            try
            {
                // Tạo đối tượng NCC
                SanPham t_insert = new SanPham
                {
                    MaSP = sp.MaSP,
                    TenSP = sp.TenSP,
                    GiaNhap = sp.GiaNhap,
                    GiaBan = sp.GiaBan,
                    SoLuong = sp.SoLuong,
                    DonViTinh = sp.DonViTinh,
                    NoiSanXuat = sp.NoiSanXuat,
                    HanSuDung = DateTime.Parse(sp.HanSuDung),
                    MaNCC = sp.MaNCC,
                    MaLoaiSP = sp.MaLoaiSP,
                };

                // Check NCC có # null ko mới add vào DB
                if (t_insert.MaSP != string.Empty)
                {
                    db.SanPhams.InsertOnSubmit(t_insert); // Thêm DB
                    db.SubmitChanges(); // Xác nhận thay đổi DB
                    MessageBox.Show("Thêm thành công!", "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Nhà cung cấp không hợp lệ!", "Thông báo",
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

        // XoaNCC()
        public bool XoaSP(string maSP)
        {
            try
            {
                // Check LoaiSP có # null ko? mới xóa
                if (maSP != string.Empty)
                {
                    // Truy vấn LoaiSP có trong DSLoaiSP hay ko?
                    var t_delete = from t in db.SanPhams
                                   where t.MaNCC == maSP
                                   select t;

                    // Xóa TK
                    foreach (var item in t_delete)
                    {
                        db.SanPhams.DeleteOnSubmit(item); // Xóa DB
                        db.SubmitChanges(); // Xác nhận thay đổi DB
                    }

                    MessageBox.Show("Xóa thành công!", "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Sản phẩm không hợp lệ!", "Thông báo",
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

        // SuaLoaiSP()
        public bool SuaSP(DTO_SanPham sp)
        {
            try
            {
                // Tạo đối tượng LoaiSP = cách truy vấn DB
                SanPham t_update = db.SanPhams.Single(t => t.MaNCC == sp.MaSP);

                // Check LoaiSP != Null ko? mới sửa thông tin LoaiSP
                if (t_update.MaNCC != string.Empty)
                {
                    // Sửa thông tin LoaiSP
                    t_update.TenSP = sp.TenSP;
                    t_update.GiaNhap = sp.GiaNhap;
                    t_update.GiaBan = sp.GiaBan;
                    t_update.SoLuong = sp.SoLuong;
                    t_update.DonViTinh = sp.DonViTinh;
                    t_update.NoiSanXuat = sp.NoiSanXuat;
                    t_update.HanSuDung = DateTime.Parse(sp.HanSuDung);
                    t_update.MaNCC = sp.MaNCC;
                    t_update.MaLoaiSP = sp.MaLoaiSP;


                    // Xác nhận thay đổi DB
                    db.SubmitChanges();

                    MessageBox.Show("Sửa thành công!", "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Sản phẩm không hợp lệ!", "Thông báo",
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

        // LayDSTK_TheoTK()
        public IQueryable LayDSSP_TheoMaSP(string maSP)
        {
            // Truy vấn DB
            IQueryable temp = from t in db.SanPhams
                              where t.MaSP == maSP
                              select t;
            return temp;
        }
    }
}
