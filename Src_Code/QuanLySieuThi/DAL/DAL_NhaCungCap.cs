/*
* Châu Nhật Tài, Lê Văn Toàn
* Project CN.NET
* Quản Lý Siêu Thị
* 29/04/2024
* DAL_NhaCungCap.cs
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
    public class DAL_NhaCungCap
    {
        // Fields
        private QLSTDataContext db;
        private string serverName = ".\\SQLEXPRESS";
        private string dbName = "QLST";

        // Constructors
        public DAL_NhaCungCap(QLSTDataContext db, string serverName, string dbName)
        {
            this.db = db;
            this.serverName = serverName;
            this.dbName = dbName;
        }

        public DAL_NhaCungCap()
        {
            string sql = "Data Source=" + ServerName + ";Initial Catalog=" + DbName + ";Integrated Security=True;";
            db = new QLSTDataContext(sql);
        }

        // Properties
        public QLSTDataContext Db { get => db; set => db = value; }
        public string ServerName { get => serverName; set => serverName = value; }
        public string DbName { get => dbName; set => dbName = value; }

        // Methods
        // LayDSNCC()
        public IQueryable LayDSNCC()
        {
            IQueryable temp = from nc in db.NhaCungCaps
                              select new
                              {
                                  MaNCC = nc.MaNCC,
                                  TenNCC = nc.TenNCC,
                                  DiaChiNCC = nc.DiaChiNCC,
                                  SdtNCC = nc.SdtNCC
                              };
            return temp;
        }

        // LayDSNCC_TheoMaNCC()
        public IQueryable LayDSNCC_TheoMaNCC(string maNCC)
        {
            IQueryable temp = from nc in db.NhaCungCaps
                              where nc.MaNCC == maNCC
                              select new
                              {
                                  MaNCC = nc.MaNCC,
                                  TenNCC = nc.TenNCC,
                              };
            return temp;
        }

        // ThemNCC()
        public bool ThemNCC(DTO_NhaCungCap ncc)
        {
            try
            {
                // Check ncc.MaNCC có != null hay không?
                if (ncc.MaNCC != string.Empty)
                {
                    // Check có NCC trong DB NCC hay chưa?
                    var temp = from nc in db.NhaCungCaps
                               where nc.MaNCC == ncc.MaNCC
                               select nc;

                    if (temp.Count() != 1)
                    {
                        // Tạo đối tượng NCC
                        NhaCungCap ncc_insert = new NhaCungCap
                        {
                            MaNCC = ncc.MaNCC,
                            TenNCC = ncc.TenNCC,
                            DiaChiNCC = ncc.DiaChiNCC,
                            SdtNCC = ncc.SdtNCC
                        };

                        db.NhaCungCaps.InsertOnSubmit(ncc_insert); // Them NCC mới vào DB NCC
                        db.SubmitChanges(); // Xác nhận thay đổi DB NCC

                        // Thông báo
                        MessageBox.Show($"Thêm nhà cung cấp +{ncc.MaNCC}+ thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        // Thông báo
                        MessageBox.Show($"Nhà cung cấp +{ncc.MaNCC}+ đã có trong danh sách nhà cung cấp!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Mã nhà cung cấp không hợp lệ!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Throw Exception
                MessageBox.Show(ex.Message);
                throw;
            }
            return false;
        }

        // XoaNCC()
        public bool XoaNCC(string maNCC) {
            try
            {
                // Check ncc.MaNCC có != null hay không?
                if (maNCC != string.Empty)
                {
                    // Tìm NCC muốn xóa = maNCC
                    var ncc_delete = from nc in db.NhaCungCaps
                                     where nc.MaNCC == maNCC
                                     select nc;

                    foreach (var item in ncc_delete)
                    {
                        db.NhaCungCaps.DeleteOnSubmit(item); // Xóa NCC 
                        db.SubmitChanges(); // Xác nhận xóa NCC khỏi DB NCC
                    }

                    // Thông báo
                    MessageBox.Show($"Xóa nhà cung cấp +{maNCC}+ thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Mã nhà cung cấp không hợp lệ!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Throw Exception
                MessageBox.Show(ex.Message);
                throw;
            }
            return false;
        }

        // SuaNCC()
        public bool SuaNCC(DTO_NhaCungCap ncc) {
            try
            {
                // Check ncc.MaNCC có != null hay không?
                if (ncc.MaNCC != string.Empty)
                {
                    // Tìm NCC muốn sửa thông tin = ncc.MaNCC
                    var ncc_update = db.NhaCungCaps.Single(nc => nc.MaNCC == ncc.MaNCC);

                    // Cập nhật thông tin NCC
                    ncc_update.TenNCC = ncc.TenNCC;
                    ncc_update.DiaChiNCC = ncc.DiaChiNCC;
                    ncc_update.SdtNCC = ncc.SdtNCC;

                    // Xác nhận thay đổi DB NCC
                    db.SubmitChanges();

                    // Thông báo
                    MessageBox.Show($"Sửa thông tin nhà cung cấp +{ncc.MaNCC}+ thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Mã nhà cung cấp không hợp lệ!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Throw Exception
                MessageBox.Show(ex.Message);
                throw;
            }
            return false;
        }
    }
}
