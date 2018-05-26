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
    public class ChiTietPhieuSuaDAO : DBConnect
    {
        public DataTable xemChiTietPhieuSua(int MaPhieuSua)
        {
            string SQL = "select cv.Noidung as 'Công Việc', cv.TIENCONG as 'Tiền công', ";
            SQL += "pt.TENPHUTUNG as 'Tên phụ tùng', pt.DONGIA as 'Đơn giá phụ tùng', ";
            SQL += "ctps.SL_PHUTUNG as 'Số lượng phụ tùng', ";
            SQL += "cv.TIENCONG + pt.DONGIA * ctps.SL_PHUTUNG as 'Thành tiền' ";
            SQL += "FROM CONGVIEC cv, CT_PHIEUSUA ctps, PHUTUNG pt ";
            SQL += "WHERE cv.MACONGVIEC = ctps.MACONGVIEC AND ctps.MAPHUTUNG = pt.MAPHUTUNG ";
            SQL += "AND ctps.MAPHIEUSUA = " + MaPhieuSua;
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtChiTietPhieuSua = new DataTable();
            da.Fill(dtChiTietPhieuSua);
            return dtChiTietPhieuSua;
        }

        public bool xoaChiTiet(int MaPhieuSua, string MaCongViec, string MaPhuTung)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("delete from CT_PHIEUSUA where MAPHIEUSUA = {0} and MACONGVIEC = '{1}' and MAPHUTUNG = '{2}'", MaPhieuSua, MaCongViec, MaPhuTung);

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

        public bool themChiTiet(ChiTietPhieuSuaDTO ctps)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("insert into CT_PHIEUSUA(MAPHIEUSUA, MAPHUTUNG, MACONGVIEC, SL_PHUTUNG) values ({0}, '{1}', '{2}', {3}) ", ctps.MaPhieuSua, ctps.MaPhuTung, ctps.MaCongViec, ctps.SoLuongPhuTung);

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

    }
}
