/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 22/04/2024
 * DAL_NhanVien.cs
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
    public class DAL_NhanVien
    {
        // Fields
        private QLSTDataContext db;
        private string serverName = ".\\SQLEXPRESS";
        private string dbName = "QLST";

        // Constructors
        public DAL_NhanVien(QLSTDataContext db, string serverName, string dbName)
        {
            this.db = db;
            this.serverName = serverName;
            this.dbName = dbName;
        }

        public DAL_NhanVien()
        {
            string sql = "Data Source=" + ServerName + ";Initial Catalog=" + DbName + ";Integrated Security=True;";
            Db = new QLSTDataContext(sql);
        }

        // Properties
        public QLSTDataContext Db { get => db; set => db = value; }
        public string ServerName { get => serverName; set => serverName = value; }
        public string DbName { get => dbName; set => dbName = value; }

        // Methods
        // LayDSNV()
        public IQueryable LayDSNV()
        {
            // Lấy DSNV
            IQueryable temp = from nv in Db.NhanViens
                              select new
                              {
                                  MaNV = nv.MaNV,
                                  HoTenNV = nv.TenNV,
                                  NgaySinh = nv.NgaySinh,
                                  GioiTinh = nv.GioiTinh,
                                  DiaChi = nv.DiaChi,
                                  SDT = nv.Sdt,
                                  TaiKhoan = nv.TaiKhoan
                              };
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

                // Check TaiKhoan đã có trong DB TaiKhoan hay chưa?
                var temp_tk = from t in db.TaiKhoans
                              where t.TaiKhoan1 == n_insert.TaiKhoan
                              select t;

                if (temp_tk.Count() != 1)
                {
                    // Check NhanVien đã có trong DB NhanVien hay chưa?
                    var temp = from n in Db.NhanViens
                               where n.MaNV == nv.MaNV
                               select n;

                    if (temp.Count() != 1)
                    {
                        // Check TaiKhoan có != null hay ko? => Thêm vào DB TaiKhoan
                        if (n_insert.TaiKhoan != string.Empty)
                        {
                            string taiKhoan = n_insert.TaiKhoan;
                            string matKhau = "123456";
                            string hoTen = n_insert.TenNV;
                            DateTime ngayTao = DateTime.Now;
                            int chucVu = 1;

                            // Tạo đối tượng TaiKhoan mới
                            TaiKhoan tk = new TaiKhoan
                            {
                                TaiKhoan1 = taiKhoan,
                                MatKhau = matKhau,
                                HoTen = hoTen,
                                NgayTao = ngayTao,
                                ChucVu = chucVu
                            };

                            // Them TaiKhoan NV mới vào DB TaiKhoan trước
                            db.TaiKhoans.InsertOnSubmit(tk);

                            // Xác nhận lưu vào DB TaiKhoan
                            db.SubmitChanges();

                            // Check MaNV có != null hay ko? => Thêm vào DB NhanVien
                            if (n_insert.MaNV != string.Empty)
                            {
                                db.NhanViens.InsertOnSubmit(n_insert); // Thêm vào DB NhanVien
                                db.SubmitChanges(); // Xác nhận lưu xuống DB NhanVien

                                // Thông báo
                                MessageBox.Show("Thêm Nhân Viên thành công!", "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                                return true;
                            }
                            else
                            {
                                // Thông báo
                                MessageBox.Show("Mã Nhân Viên không hợp lệ, không thể thêm NhanVien mới!", "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            // Thông báo
                            MessageBox.Show("Tài Khoản không hợp lệ, không thể thêm NhanVien mới!", "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Thông báo
                        MessageBox.Show("Đã có Nhân Viên trong DB NhanVien!", "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    } 
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Đã có Tài Khoản trong DB TaiKhoan!", "Thông báo",
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
        public bool XoaNV(string nv, string tk)
        {
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

                        // Thông báo
                        MessageBox.Show("Xóa Nhân Viên thành công!", "Thông báo",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        // Thông báo
                        MessageBox.Show("Tài Khoản không hợp lệ, không thể xóa Tài Khoản!", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Mã Nhân Viên không hợp lệ, Không thể xóa Nhân Viên!", "Thông báo",
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
        public bool SuaNV(DTO_NhanVien nv)
        {
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

                    // Sửa TaiKhoan trong DB TaiKhoan
                    TaiKhoan tk = db.TaiKhoans.Single(t => t.TaiKhoan1 == nv.TaiKhoan);

                    tk.TaiKhoan1 = nv.TaiKhoan;
                    tk.MatKhau = "123456";
                    tk.HoTen = n_update.TenNV;
                    tk.NgayTao = DateTime.Now;
                    tk.ChucVu = 1;

                    // Xác nhận thay đổi DB NhanVien
                    db.SubmitChanges();

                    // Thông báo
                    MessageBox.Show("Sửa thông tin Nhân Viên thành công!", "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Mã Nhân Viên không hợp lệ, không thể sửa thông tin Nhân Viên", "Thông báo",
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
        public IQueryable LayDSNV_TheoMaNV(string nv)
        {
            // Lấy DSNV theo MaNV
            IQueryable temp = from n in db.NhanViens
                              where n.MaNV == nv
                              select new
                              {
                                  MaNV = n.MaNV,
                                  HoTenNV = n.TenNV,
                                  NgaySinh = n.NgaySinh,
                                  GioiTinh = n.GioiTinh,
                                  DiaChi = n.DiaChi,
                                  SDT = n.Sdt,
                                  TaiKhoan = n.TaiKhoan
                              };
            return temp;
        }

        // LayDSNV_TheoMaNV2()
        public int LayDSNV_TheoMaNV2(string nv)
        {
            // Lấy DSNV theo MaNV
            var temp = from n in db.NhanViens
                              where n.MaNV == nv
                              select new
                              {
                                  MaNV = n.MaNV,
                                  HoTenNV = n.TenNV,
                                  NgaySinh = n.NgaySinh,
                                  GioiTinh = n.GioiTinh,
                                  DiaChi = n.DiaChi,
                                  SDT = n.Sdt,
                                  TaiKhoan = n.TaiKhoan
                              };

            return temp.Count();
        }
    }
}
