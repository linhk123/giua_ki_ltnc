using giuaKi.entity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giuaKi.dao
{
    public class KhoaDAO
    {
        internal List<Khoa> GetAll()
        {
            var list = new List<Khoa>();
            using (var cn = DatabaseHelper.GetConnection())
            {
                try
                {
                    cn.Open(); // mở connection đúng cách
                    using (var cmd = new SqlCommand("SELECT MaKhoa, TenKhoa FROM tblKhoa", cn))
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            list.Add(new Khoa
                            {
                                MaKhoa = r["MaKhoa"]?.ToString() ?? string.Empty,
                                TenKhoa = r["TenKhoa"]?.ToString() ?? string.Empty
                            });
                        }
                    }
                }
                catch (Exception e)
                {
                    // hiển thị lỗi hoặc log
                    throw new Exception(e.Message);
                }
            }
            return list;
        }
    }
    }
