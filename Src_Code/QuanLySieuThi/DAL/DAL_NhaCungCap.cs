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
        public IQueryable LayDSNCC_TheoMaNCC(string maNCC) {
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
        public bool ThemNCC(DTO_NhaCungCap ncc) {
            try
            {
                // Check ncc.MaNCC có != null hay không?
                if (ncc.MaNCC != string.Empty)
                {
                    
                }
                else
                {
                    MessageBox.Show("Mã Nhà Cung Cấp không hợp lệ!","Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
