using giuaKi.dao;
using giuaKi.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giuaKi.bus
{
    internal class MonHocBUS
    {
        private MonHocDAO dal = new MonHocDAO();
        private List<MonHoc> listCache = new List<MonHoc>();

        public void LoadAll()
        {
            listCache = dal.GetAll();
        }

        public List<MonHoc> GetAll()
        {
            return listCache.ToList();
        }

        public List<MonHoc> GetByKhoa(string maKhoa)
        {
            return listCache.Where(x => x.MaKhoa == maKhoa).ToList();
        }
    }
}
