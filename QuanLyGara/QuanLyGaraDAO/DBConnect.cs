using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGaraDAO
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = QuanLyGara; Integrated Security = True");
    }     
}
