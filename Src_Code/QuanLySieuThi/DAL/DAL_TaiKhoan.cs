/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 01/04/2024
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
        //Fields
        private QLSTDataContext db = new QLSTDataContext();

        //Methods
        //LayDSTK
        public IQueryable LayDSTK() {
            IQueryable temp = from t in db.TaiKhoans
                              select t;
            return temp;
        }

        //ThemTK
        public bool ThemTK(DTO_TaiKhoan tk) {
            try
            {
                TaiKhoan t_insert = new TaiKhoan { 
                TaiKhoan1 = tk.TaiKhoan,
                MatKhau = tk.MatKhau,
                HoTen = tk.HoTen,
                NgayTao = DateTime.Parse(tk.NgayTao),
                ChucVu = tk.ChucVu
                };

                if (t_insert.TaiKhoan1 != string.Empty)
                {
                    db.TaiKhoans.InsertOnSubmit(t_insert);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm thành công!", "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Tài khoản không hợp lệ!", "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        //XoaTK
        public bool XoaTK(string tk) {
            try
            {
                if (tk != string.Empty)
                {
                    var t_delete = from t in db.TaiKhoans
                                   where t.TaiKhoan1 == tk
                                   select t;

                    foreach (var item in t_delete)
                    {
                        db.TaiKhoans.DeleteOnSubmit(item);
                        db.SubmitChanges();
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
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        //SuaTK
        public bool SuaTK(DTO_TaiKhoan tk) {
            try
            {
                TaiKhoan t_update = db.TaiKhoans.Single(t => t.TaiKhoan1 == tk.TaiKhoan);
                if (t_update.TaiKhoan1 != string.Empty)
                {
                    t_update.MatKhau = tk.MatKhau;
                    t_update.HoTen = tk.HoTen;
                    t_update.NgayTao = DateTime.Parse(tk.NgayTao);
                    t_update.ChucVu = tk.ChucVu;

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
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        //LayDSTK_TheoTK
        public IQueryable LayDSTK_TheoTK(string tk) {
            IQueryable temp = from t in db.TaiKhoans
                              where t.TaiKhoan1 == tk
                              select t;
            return temp;
        }
    }
}
