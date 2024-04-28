/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 22/04/2024
 * DAL_TaiKhoan.cs
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
    public class DAL_TaiKhoan
    {
        // Fields
        private QLSTDataContext db;
        private string serverName = ".\\SQLEXPRESS";
        private string dbName = "QLST";

        // Constructors
        public DAL_TaiKhoan(QLSTDataContext db, string serverName, string dbName)
        {
            this.db = db;
            this.serverName = serverName;
            this.dbName = dbName;
        }

        public DAL_TaiKhoan()
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
            // Lấy DSTK
            IQueryable temp = from t in db.TaiKhoans
                              select new
                              {
                                  TaiKhoan = t.TaiKhoan1,
                                  MatKhau = t.MatKhau,
                                  HoTen = t.HoTen,
                                  NgayTao = t.NgayTao,
                                  ChucVu = t.ChucVu
                              };
            return temp;
        }

        // ThemTK()
        public bool ThemTK(DTO_TaiKhoan tk)
        {
            try
            {
                // Check TaiKhoan có # null ko mới add vào DB TaiKhoan
                if (tk.TaiKhoan != string.Empty)
                {
                    // Tạo đối tượng TaiKhoan
                    TaiKhoan t_insert = new TaiKhoan
                    {
                        TaiKhoan1 = tk.TaiKhoan,
                        MatKhau = tk.MatKhau,
                        HoTen = tk.HoTen,
                        NgayTao = tk.NgayTao,
                        ChucVu = tk.ChucVu
                    };

                    // Check xem đã có TaiKhoan trong DB TaiKhoan chưa?
                    var temp = from t in db.TaiKhoans
                               where t.TaiKhoan1 == tk.TaiKhoan
                               select t;

                    if (temp.Count() != 1)
                    {
                        db.TaiKhoans.InsertOnSubmit(t_insert); // Thêm DB TaiKhoan
                        db.SubmitChanges(); // Xác nhận thay đổi DB TaiKhoan

                        // Thông báo
                        MessageBox.Show("Thêm Tài Khoản mới thành công!", "Thông báo",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                        return true;

                    }
                    else
                    {
                        // Thông báo
                        MessageBox.Show("Đã có Tài Khoản trong DB TaiKhoan!", "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    } 
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Tài Khoản không hợp lệ, không thể thêm Tài Khoản mới!", "Thông báo",
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
                    // Truy vấn NhanVien có cùng TaiKhoan và xóa đi trước khi thông báo
                    var tk_nv = from t in db.NhanViens
                                where t.MaNV == tk
                                select t;

                    // Xóa NhanVien có cùng TaiKhoan
                    foreach (var item in tk_nv)
                    {
                        db.NhanViens.DeleteOnSubmit(item); // Xóa NhanVien có cùng TaiKhoan trong DB NhanVien
                        db.SubmitChanges(); // Xác nhận thay đổi DB NhanVien
                    }

                    // Truy vấn TaiKhoan có trong DSTK hay ko?
                    var t_delete = from t in db.TaiKhoans
                                   where t.TaiKhoan1 == tk
                                   select t;

                    // Xóa TK
                    foreach (var item in t_delete)
                    {
                        db.TaiKhoans.DeleteOnSubmit(item); // Xóa TaiKhoan trong DB TaiKhoan
                        db.SubmitChanges(); // Xác nhận thay đổi DB TaiKhoan
                    }

                    // Thông báo
                    MessageBox.Show("Xóa Tài Khoản thành công!", "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Tài khoản không hợp lệ, không thể xóa Tài Khoản!", "Thông báo",
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
                if (tk.TaiKhoan != string.Empty)
                {
                    // Tạo đối tượng TaiKhoan = cách truy vấn DB
                    TaiKhoan t_update = db.TaiKhoans.Single(t => t.TaiKhoan1 == tk.TaiKhoan);

                    // Sửa thông tin TaiKhoan
                    t_update.MatKhau = tk.MatKhau;
                    t_update.HoTen = tk.HoTen;
                    t_update.NgayTao = tk.NgayTao;
                    t_update.ChucVu = tk.ChucVu;

                    // Xác nhận thay đổi DB
                    db.SubmitChanges();

                    // Thông báo
                    MessageBox.Show("Sửa thông tin Tài Khoản thành công!", "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    return true; 
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Tài khoản không hợp lệ, không thể sửa thông tin Tài Khoản!", "Thông báo",
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
            // Lấy DSTK Theo TK
            IQueryable temp = from t in db.TaiKhoans
                              where t.TaiKhoan1 == tk
                              select new
                              {
                                  TaiKhoan = t.TaiKhoan1,
                              };
            return temp;
        }

        // LayDSTK_TheoChucVu()
        public IQueryable LayDSTK_TheoChucVuAll()
        {
            // Lấy DSTK Theo TK
            IQueryable temp = from t in db.TaiKhoans
                              group t by t.ChucVu into cv
                              select new
                              {
                                  ChucVu = cv.Key,
                              };
            return temp;
        }
    }
}
