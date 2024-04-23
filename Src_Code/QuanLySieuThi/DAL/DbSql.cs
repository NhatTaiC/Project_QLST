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
                    MessageBox.Show("Tài khoản không hợp lệ, không thể thêm TaiKhoan mới!", "Thông báo",
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
                    MessageBox.Show("Tài khoản không hợp lệ, không thể xóa TaiKhoan!", "Thông báo",
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
                    MessageBox.Show("Tài khoản không hợp lệ, không thể sửa thông tin TaiKhoan!", "Thông báo",
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
        public IQueryable LayDSTK_TheoTK(string tk)
        {
            // Truy vấn DB
            IQueryable temp = from t in db.TaiKhoans
                              where t.TaiKhoan1 == tk
                              select t;
            return temp;
        }

        // LayDSNV()
        public IQueryable LayDSNV()
        {
            IQueryable temp = from nv in Db.NhanViens
                              select nv;
            return temp;
        }

        // ThemNV()
        public bool ThemNV(DTO_NhanVien nv)
        {
            try
            {
                // Tạo đối tượng NhanVien
                NhanVien n_insert = new NhanVien
                {
                    MaNV = nv.MaNV,
                    TenNV = nv.TenNV,
                    NgaySinh = nv.NgaySinh,
                    GioiTinh = nv.GioiTinh,
                    DiaChi = nv.DiaChi,
                    Sdt = nv.SoDT,
                    TaiKhoan = nv.TaiKhoan
                };

                // Check TaiKhoan có != null hay ko? => Thêm vào DB TaiKhoan
                if (n_insert.TaiKhoan != string.Empty)
                {
                    string taiKhoan = n_insert.TaiKhoan;
                    string matKhau = "123456";
                    string hoTen = n_insert.TenNV;
                    string ngayTao = $"{DateTime.Now}";
                    int chucVu = 1;

                    // Tạo đối tượng TaiKhoan mới
                    TaiKhoan tk = new TaiKhoan { 
                        TaiKhoan1 = taiKhoan, 
                        MatKhau = matKhau, 
                        HoTen = hoTen, 
                        NgayTao = DateTime.Parse(ngayTao), 
                        ChucVu = chucVu };

                    // Them TaiKhoan NV mới vào DB TaiKhoan trước
                    db.TaiKhoans.InsertOnSubmit(tk);

                    // Xác nhận lưu vào DB TaiKhoan
                    db.SubmitChanges();

                    // Check MaNV có != null hay ko? => Thêm vào DB NhanVien
                    if (n_insert.MaNV != string.Empty)
                    {
                        db.NhanViens.InsertOnSubmit(n_insert); // Thêm vào DB NhanVien
                        db.SubmitChanges(); // Xác nhận lưu xuống DB NhanVien
                        MessageBox.Show("Thêm thành công!", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Mã Nhân Viên không hợp lệ, không thể thêm NhanVien mới!", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    } 
                }
                else
                {
                    MessageBox.Show("Tài khoản không hợp lệ, không thể thêm NhanVien mới!", "Thông báo",
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

        // XoaNV()
        public bool XoaNV(string nv, string tk) {
            try
            {
                // Check MaNV có != null hay ko? => Thêm vào DB
                if (nv != string.Empty)
                {
                    // Truy vấn MaNV có tồn tại trong Table NhanVien ko?
                    var n_delete = from n in db.NhanViens
                                   where n.MaNV == nv && n.TaiKhoan == tk
                                   select n;

                    foreach (var item in n_delete)
                    {
                        db.NhanViens.DeleteOnSubmit(item); // Xóa NhanVien
                        db.SubmitChanges(); // Xác nhận lưu vào DB NhanVien
                    }

                    // Check tk của NV có tồn tại ko?
                    if (tk != string.Empty)
                    {
                        var t_delete = from t in db.TaiKhoans
                                       where t.TaiKhoan1 == tk
                                       select t;

                        foreach (var item in t_delete)
                        {
                            db.TaiKhoans.DeleteOnSubmit(item); // Xóa TaiKhoan trong DB
                            db.SubmitChanges(); // Xác nhận xóa
                        }

                        MessageBox.Show("Xóa thành công!", "Thông báo",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                        return true; 
                    }
                    else
                    {
                        MessageBox.Show("TaiKhoan không hợp lệ, không thể xóa TaiKhoan!", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Mã Nhân Viên không hợp lệ, Không thể xóa NhanVien!", "Thông báo",
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

        // SuaNV()
        public bool SuaNV(DTO_NhanVien nv) {
            try
            {
                // Tao đối tượng NhanVien
                NhanVien n_update = db.NhanViens.Single(n => n.MaNV == nv.MaNV && n.TaiKhoan == nv.TaiKhoan);

                // Check MaNV, TaiKhoan có != null hay ko? => Thêm vào DB
                if (n_update.MaNV != string.Empty && n_update.TaiKhoan != string.Empty)
                {
                    n_update.TenNV = nv.TenNV;
                    n_update.NgaySinh = nv.NgaySinh;
                    n_update.GioiTinh = nv.GioiTinh;
                    n_update.DiaChi = nv.DiaChi;
                    n_update.Sdt = nv.SoDT;

                    // Sửa TaiKhoan DB
                    TaiKhoan tk = db.TaiKhoans.Single(t => t.TaiKhoan1 == nv.TaiKhoan);

                    tk.TaiKhoan1 = nv.TaiKhoan;
                    tk.MatKhau = "123456";
                    tk.HoTen = n_update.TenNV;
                    tk.NgayTao = n_update.NgaySinh;
                    tk.ChucVu = 1;

                    // Sửa TaiKhoan NhanVien
                    n_update.TaiKhoan = nv.TaiKhoan;

                    // Xác nhận thay đổi NhanVien DB
                    db.SubmitChanges();

                    MessageBox.Show("Sửa thành công!", "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Mã Nhân Viên không hợp lệ, không thể sửa thông tin NhanVien", "Thông báo",
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

        // LayDSNV_TheoMaNV()
        public IQueryable LayDSNV_TheoMaNV(string nv) {
            IQueryable temp = from n in db.NhanViens
                              where n.MaNV == nv
                              select n;
            return temp;
        }
    }
}
