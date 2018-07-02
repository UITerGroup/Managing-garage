using QuanLyGaraDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGaraDAO
{
    public class PhieuThuTienDAO : DBConnect
    {
        public bool themPhieuThu(PhieuThuTienDTO ptt)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("insert into PHIEUTHU(MAPHIEUTHU,MAPHIEUSUA,NGAYTHU,TIENTHU) VALUES ({0},{1},'{2}',{3})", ptt.MaPhieuThu, ptt.MaPhieuSua, ptt.NgayThu, ptt.TienThu);

                // Command (mặc định command type = text).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)                             
                    return true;                    
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
            return false;
        }

        public DataTable loadPhieuDaThu(int MaPhieu)
        {
            string SQL = "select ptt.MAPHIEUTHU, kh.TENKH, ps.BIENSO, kh.DIENTHOAI, ";
            SQL += "kh.EMAIL, ptt.NGAYTHU, ptt.TIENTHU ";
            SQL += "from PHIEUTHU ptt, PHIEUSUACHUA ps, XE x, KHACHHANG kh ";
            SQL += "WHERE ptt.MAPHIEUSUA = ps.MAPHIEUSUA and ps.BIENSO = x.BIENSO and x.MAKH = kh.MAKH ";
            SQL += "and ptt.MAPHIEUTHU = " + MaPhieu;

            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
