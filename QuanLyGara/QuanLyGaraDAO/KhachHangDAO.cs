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
    public class KhachHangDAO : DBConnect
    {
        public DataTable xemToanBoKhachHang()
        {
            string SQL = "select MAKH as 'Mã khách hàng', TENKH as 'Tên khách hàng', DIACHI as 'Địa chỉ', ";
            SQL += "DIENTHOAI as 'Số điện thoại',EMAIL as 'Email' from KHACHHANG";
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtKhachHang = new DataTable();
            da.Fill(dtKhachHang);
            return dtKhachHang;
        }

        public bool themKhachHang(KhachHangDTO kh)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string 
                string SQL = string.Format("insert into KHACHHANG(TENKH, DIACHI, DIENTHOAI, EMAIL) values (N'{0}', N'{1}', '{2}', '{3}')", kh.TenKH, kh.DiaChi, kh.DienThoai, kh.Email);

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

        public bool capNhatKhachHang(KhachHangDTO kh)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("update KHACHHANG set TENKH = N'{0}', DIACHI = N'{1}', DIENTHOAI = '{2}', EMAIL = '{3}' WHERE MAKH = {4}", kh.TenKH, kh.DiaChi, kh.DienThoai, kh.Email, kh.MaKH);

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

        public DataTable timKiemKhachHangBangID(string keyword)
        {
            string SQL = "select MAKH as 'Mã khách hàng', TENKH as 'Tên khách hàng', DIACHI as 'Địa chỉ', ";
            SQL += "DIENTHOAI as 'Số điện thoại',EMAIL as 'Email' from KHACHHANG";
            SQL += " where MAKH = " + Convert.ToInt64(keyword);
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtKhachHangTimDuoc = new DataTable();
            da.Fill(dtKhachHangTimDuoc);
            return dtKhachHangTimDuoc;
        }

        public DataTable timKiemKhachHangBangTen(string keyword)
        {
            string SQL = "select MAKH as 'Mã khách hàng', TENKH as 'Tên khách hàng', DIACHI as 'Địa chỉ', ";
            SQL += "DIENTHOAI as 'Số điện thoại',EMAIL as 'Email' from KHACHHANG";
            SQL += " where TENKH like N'%" + keyword + "%'";
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtKhachHangTimDuoc = new DataTable();
            da.Fill(dtKhachHangTimDuoc);
            return dtKhachHangTimDuoc;
        }

        public DataTable layMaVaTenKH()
        {
            string SQL = "select CONCAT(MAKH,' - ',TENKH) AS 'Khách hàng' FROM KHACHHANG ";
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtMaVaTenKH = new DataTable();
            da.Fill(dtMaVaTenKH);
            return dtMaVaTenKH;
        }

        public DataTable layThongTinKhBangBienSo(string BienSo)
        {
            string SQL = "select x.HIEUXE, kh.TENKH, kh.DIACHI, kh.DIENTHOAI ";
            SQL += "FROM XE x, KHACHHANG kh ";
            SQL += "WHERE x.MAKH = kh.MAKH AND x.BIENSO = '" + BienSo + "'";
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtKhachHang = new DataTable();
            da.Fill(dtKhachHang);
            return dtKhachHang;
        }

    }
}
