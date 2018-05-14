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
    public class CongViecDAO : DBConnect
    {
        public DataTable xemToanBoCongViec()
        {
            string SQL = "select MACONGVIEC as 'Mã công việc', NOIDUNG as 'Nội dung', ";
            SQL += "TIENCONG as 'Tiền công' from CONGVIEC";
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtTienCong = new DataTable();
            da.Fill(dtTienCong);
            return dtTienCong;
        }

        public bool themCongViec(CongViecDTO cv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("insert into CONGVIEC(MACONGVIEC, NOIDUNG, TIENCONG) VALUES (N'{0}', N'{1}', {2})", cv.MaCongViec, cv.NoiDungCongViec, cv.TienCong);

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

        public bool xoaCongViec(string MaCongViec)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = "delete from CONGVIEC where MACONGVIEC = '" + MaCongViec + "'";

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

        public bool capNhatThongTinCongViec(CongViecDTO cv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("update CONGVIEC set NOIDUNG = N'{0}', TIENCONG = {1} where MACONGVIEC = '{2}'", cv.NoiDungCongViec, cv.TienCong, cv.MaCongViec);

                // Command (mặc định command type = text nên).
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

        public bool capNhatMaCongViec(string MaCongViecCapNhat, string MaCongVIec)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = "update CONGVIEC set MACONGVIEC = '" + MaCongViecCapNhat + "'";
                SQL += " where MACONGVIEC = '" + MaCongVIec + "'";

                // Command (mặc định command type = text nên).
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

        public DataTable timKiemCongViecBangID(string keyword)
        {
            string SQL = "select MACONGVIEC as 'Mã công việc', NOIDUNG as 'Nội dung', ";
            SQL += "TIENCONG as 'Tiền công' from CONGVIEC";
            SQL += " where MACONGVIEC like N'%" + keyword + "%'";
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtPhuTungTimDuoc = new DataTable();
            da.Fill(dtPhuTungTimDuoc);
            return dtPhuTungTimDuoc;
        }

        public DataTable timKiemPhuTungBangTen(string keyword)
        {
            string SQL = "select MACONGVIEC as 'Mã công việc', NOIDUNG as 'Nội dung', ";
            SQL += "TIENCONG as 'Tiền công' from CONGVIEC";
            SQL += " where NOIDUNG like N'%" + keyword + "%'";
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtPhuTungTimDuoc = new DataTable();
            da.Fill(dtPhuTungTimDuoc);
            return dtPhuTungTimDuoc;
        }

    }
}
