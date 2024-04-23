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
    }
}
