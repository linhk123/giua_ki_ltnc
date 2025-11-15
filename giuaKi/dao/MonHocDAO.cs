using giuaKi.entity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giuaKi.dao
{
    internal class MonHocDAO
    {
        public List<MonHoc> GetAll()
        {
            var list = new List<MonHoc>();
            using (var cn = DatabaseHelper.GetConnection())
            {
                var cmd = new SqlCommand("SELECT MaMH, MaKhoa, TenMH, SoTinChi, HocKy FROM tblMonHoc", cn);
                cn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new MonHoc
                        {
                            MaMH = r["MaMH"].ToString(),
                            MaKhoa = r["MaKhoa"].ToString(),
                            TenMH = r["TenMH"].ToString(),
                            SoTinChi = Convert.ToInt32(r["SoTinChi"]),
                            HocKy = Convert.ToInt32(r["HocKy"])
                        });
                    }
                }
            }
            return list;
        }
    }
}
