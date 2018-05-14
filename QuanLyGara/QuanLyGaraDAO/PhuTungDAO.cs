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
    public class PhuTungDAO : DBConnect
    {
        public DataTable xemToanBoPhuTung()
        {
            string SQL = "select MAPHUTUNG as 'Mã phụ tùng', TENPHUTUNG as 'Tên phụ tùng', ";
            SQL += "DONGIA as 'Đơn giá', SLTON as 'Số lượng tồn' from PHUTUNG";
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtPhuTung = new DataTable();
            da.Fill(dtPhuTung);
            return dtPhuTung;
        }

        public bool themPhuTung(PhuTungDTO pt)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("insert into PHUTUNG(MAPHUTUNG, TENPHUTUNG, DONGIA, SLTON) VALUES (N'{0}', N'{1}', '{2}', '{3}')", pt.MaPhuTung, pt.TenPhuTung, pt.DonGia, pt.SoLuongTon);

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

        public bool xoaPhuTung(string MaPhuTung)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = "delete from PHUTUNG where MAPHUTUNG = '" + MaPhuTung + "'";

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

        public bool capNhatThongTinPhuTung(PhuTungDTO pt)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("update PHUTUNG set TENPHUTUNG = N'{0}', DONGIA = {1}, SLTON = {2} where MAPHUTUNG = '{3}'", pt.TenPhuTung, pt.DonGia, pt.SoLuongTon, pt.MaPhuTung);

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

        public bool capNhatMaPhuTung (string MaPhuTungCapNhat, string MaPhuTung)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = "update PHUTUNG set MAPHUTUNG = '" + MaPhuTungCapNhat + "'";
                SQL += " where MAPHUTUNG = '" + MaPhuTung + "'";

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

        public DataTable timKiemPhuTungBangID(string keyword)
        {
            string SQL = "select MAPHUTUNG as 'Mã phụ tùng', TENPHUTUNG as 'Tên phụ tùng', ";
            SQL += "DONGIA as 'Đơn giá', SLTON as 'Số lượng tồn' from PHUTUNG";
            SQL += " where MAPHUTUNG like N'%" + keyword + "%'";
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtPhuTungTimDuoc = new DataTable();
            da.Fill(dtPhuTungTimDuoc);
            return dtPhuTungTimDuoc;
        }

        public DataTable timKiemPhuTungBangTen(string keyword)
        {
            string SQL = "select MAPHUTUNG as 'Mã phụ tùng', TENPHUTUNG as 'Tên phụ tùng', ";
            SQL += "DONGIA as 'Đơn giá', SLTON as 'Số lượng tồn' from PHUTUNG";
            SQL += " where TENPHUTUNG like N'%" + keyword + "%'";
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtPhuTungTimDuoc = new DataTable();
            da.Fill(dtPhuTungTimDuoc);
            return dtPhuTungTimDuoc;
        }

    }
}
