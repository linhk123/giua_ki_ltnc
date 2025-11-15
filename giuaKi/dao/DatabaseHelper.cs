using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using System.Data;
namespace giuaKi.dao
{
    
    public class DatabaseHelper

    {
        private static readonly string ConnectionString =
                @"Data Source=localhost;Initial Catalog=QLMONHOC;Integrated Security=True;TrustServerCertificate=True;";


        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
