using giuaKi.dao;
using giuaKi.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giuaKi.bus
{
    internal class KhoaBUS
    {
        private KhoaDAO dao = new KhoaDAO();
        public List<Khoa> GetAll() => dao.GetAll();
    }
}
