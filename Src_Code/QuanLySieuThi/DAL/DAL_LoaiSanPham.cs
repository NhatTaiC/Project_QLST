/*
* Châu Nhật Tài, Lê Văn Toàn
* Project CN.NET
* Quản Lý Siêu Thị
* 29/04/2024
* DAL_LoaiSanPham.cs
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
    public class DAL_LoaiSanPham
    {
        // Fields
        private QLSTDataContext db;
        private string serverName = ".\\SQLEXPRESS";
        private string dbName = "QLST";

        // Constructors
        public DAL_LoaiSanPham(QLSTDataContext db, string serverName, string dbName)
        {
            this.Db = db;
            this.ServerName = serverName;
            this.DbName = dbName;
        }

        public DAL_LoaiSanPham()
        {
            string sql = "Data Source=" + ServerName + ";Initial Catalog=" + DbName + ";Integrated Security=True;";
            db = new QLSTDataContext(sql);
        }

        // Properties
        public QLSTDataContext Db { get => db; set => db = value; }
        public string ServerName { get => serverName; set => serverName = value; }
        public string DbName { get => dbName; set => dbName = value; }

        // Methods
        // LayDSLSP()
        public IQueryable LayDSLSP()
        {
            IQueryable temp = from lsp in db.LoaiSanPhams
                              select new
                              {
                                  MaLoaiSP = lsp.MaLoaiSP,
                                  TenLoaiSP = lsp.TenLoaiSP,
                                  MoTa = lsp.MoTa
                              };
            return temp;
        }

        // LayDSLSP_TheoMaLSP()
        public IQueryable LayDSLSP_TheoMaLSP(string maLSP)
        {
            IQueryable temp = from lsp in db.LoaiSanPhams
                              where lsp.MaLoaiSP == maLSP
                              select new
                              {
                                  MaLoaiSP = lsp.MaLoaiSP,
                                  TenLoaiSP = lsp.TenLoaiSP,
                                  MoTa = lsp.MoTa
                              };
            return temp;
        }

        // ThemLSP()
        public bool ThemLSP(DTO_LoaiSanPham lsp)
        {
            try
            {
                // Check lsp.MaLoaiSP có != null không?
                if (lsp.MaLoaiSP != string.Empty)
                {
                    // Check LoaiSP đã có trong DB LoaiSanPham hay chưa?
                    var temp = from l in db.LoaiSanPhams
                               where l.MaLoaiSP == lsp.MaLoaiSP
                               select l;

                    if (temp.Count() != 1)
                    {
                        // Tạo đối tượng LoaiSanPham
                        LoaiSanPham lsp_insert = new LoaiSanPham
                        {
                            MaLoaiSP = lsp.MaLoaiSP,
                            TenLoaiSP = lsp.TenLoaiSP,
                            MoTa = lsp.MoTa
                        };

                        db.LoaiSanPhams.InsertOnSubmit(lsp_insert); // Thêm LoaiSanPham mới vào DB LoaiSanPham
                        db.SubmitChanges(); // Xác nhận thay đổi DB LoaiSanPham

                        // Thông báo
                        MessageBox.Show($"Thêm loại sản phẩm +{lsp.MaLoaiSP}+ thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return true;
                    }
                    else
                    {
                        // Thông báo
                        MessageBox.Show($"Loại sản phẩm +{lsp.MaLoaiSP}+ đã có trong danh sách loại sản phẩm!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Mã loại sản phẩm không hợp lệ!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Throw Exception
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        // XoaLSP()
        public bool XoaLSP(string maLSP)
        {
            try
            {
                // Check lsp.MaLoaiSP có != null không?
                if (maLSP != string.Empty)
                {
                    // Tìm LoaiSanPham cần xóa = maLSP
                    var lsp_delete = from l in db.LoaiSanPhams
                               where l.MaLoaiSP == maLSP
                               select l;

                    foreach (var item in lsp_delete)
                    {
                        db.LoaiSanPhams.DeleteOnSubmit(item); // Xóa LoaiSanPham trong DB LoaiSanPham
                        db.SubmitChanges(); // Xác nhận thay đổi DB LoaiSanPham
                    }

                    // Thông báo
                    MessageBox.Show($"Xóa loại sản phẩm +{maLSP}+ thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Mã loại sản phẩm không hợp lệ!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Throw Exception
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        // SuaLSP()
        public bool SuaLSP(DTO_LoaiSanPham lsp) {
            try
            {
                // Check lsp.MaLoaiSP có != null không?
                if (lsp.MaLoaiSP != string.Empty)
                {
                    // Tìm LoaiSanPham cần sửa = lsp.maLSP
                    var lsp_update = db.LoaiSanPhams.Single(l => l.MaLoaiSP == lsp.MaLoaiSP);

                    // Cập nhật thông tin LoaiSanPham
                    lsp_update.TenLoaiSP = lsp.TenLoaiSP;
                    lsp_update.MoTa = lsp.MoTa;

                    // Xác nhận thay đổi DB LoaiSanPham
                    db.SubmitChanges();

                    // Thông báo
                    MessageBox.Show($"Sửa thông tin loại sản phẩm +{lsp.MaLoaiSP}+ thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Mã loại sản phẩm không hợp lệ!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
