using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGaraDAO
{
    public class Data

    {

        public SqlConnection getConnect() //Nhận chuỗi kết nối

        {

            return new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = QuanLyGara; Integrated Security = True");

        }

        //Lệnh trả về một bảng

        public DataTable GetTable(string sql)

        {

            SqlConnection con = getConnect();

            SqlDataAdapter ad = new SqlDataAdapter(sql, con);

            DataTable dt = new DataTable();

            ad.Fill(dt);

            return (dt);

        }

        //Lệnh thực hiện 1 hành động, không trả về một bảng

        public void ExecuteNonQuery(string sql)

        {

            SqlConnection con = getConnect();

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Connection.Open();

            cmd.ExecuteNonQuery();

            cmd.Dispose();

        }

        //Xong lớp thứ nhất, làm xong build để thu được file DataAccess.dll
    }
}
