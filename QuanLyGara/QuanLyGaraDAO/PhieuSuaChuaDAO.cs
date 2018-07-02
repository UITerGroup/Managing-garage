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
    public class PhieuSuaChuaDAO : DBConnect
    {
        public DataTable xemToanBoPhieuSuaChua()
        {
            string SQL = "select MAPHIEUSUA as 'Mã phiếu', BIENSO as 'Biển số', ";
            SQL += "NGAYSUA as 'Ngày sửa', TINHTRANG as 'Tình trạng' ";
            SQL += "from PHIEUSUACHUA";
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtDanhSachPhieuSuaChua = new DataTable();
            da.Fill(dtDanhSachPhieuSuaChua);
            return dtDanhSachPhieuSuaChua;
        }

        public bool themPhieuSuaChua(PhieuSuaChuaDTO phieusua)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string 
                string SQL = string.Format("insert into PHIEUSUACHUA(BIENSO, NGAYSUA, TINHTRANG) values (N'{0}', N'{1}', N'{2}')", phieusua.BienSo, phieusua.NgaySua, phieusua.TinhTrang);

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

        public bool xoaPhieuSuaChua(int MaPhieuSuaChua)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = "delete from PHIEUSUACHUA where MAPHIEUSUA = '" + MaPhieuSuaChua + "'";

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

        public DataTable timKiemPhieuSuaBangID(string keyword)
        {
            string SQL = "select MAPHIEUSUA as 'Mã phiếu', BIENSO as 'Biển số', ";
            SQL += "NGAYSUA as 'Ngày sửa', TINHTRANG as 'Tình trạng' ";
            SQL += "from PHIEUSUACHUA ";
            SQL += "where MAPHIEUSUA = " + Convert.ToInt32(keyword);
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtPhieuSuaTimDuoc = new DataTable();
            da.Fill(dtPhieuSuaTimDuoc);
            return dtPhieuSuaTimDuoc;
        }

        public DataTable timKiemPhieuSuaBangBienSo(string keyword)
        {
            string SQL = "select MAPHIEUSUA as 'Mã phiếu', BIENSO as 'Biển số', ";
            SQL += "NGAYSUA as 'Ngày sửa', TINHTRANG as 'Tình trạng' ";
            SQL += "from PHIEUSUACHUA ";
            SQL += "where BIENSO like N'%" + keyword + "%'";
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtPhieuSuaTimDuoc = new DataTable();
            da.Fill(dtPhieuSuaTimDuoc);
            return dtPhieuSuaTimDuoc;
        }

        public DataTable timKiemPhieuSuaTheoNgay(string NgayBatDau, string NgayKetThuc)
        {
            string SQL = "select MAPHIEUSUA as 'Mã phiếu', BIENSO as 'Biển số', ";
            SQL += "NGAYSUA as 'Ngày sửa', TINHTRANG as 'Tình trạng' ";
            SQL += "from PHIEUSUACHUA ";
            SQL += "where NGAYSUA between '" + NgayBatDau + "' and '" + NgayKetThuc + "'";
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtPhieuSuaTimDuoc = new DataTable();
            da.Fill(dtPhieuSuaTimDuoc);
            return dtPhieuSuaTimDuoc;
        }

        public void setTinhTrangPhieu(int MaPhieuSua)
        {
            _conn.Open();

            string SQL = "update PHIEUSUACHUA set TINHTRANG = N'Đã thanh toán' ";
            SQL += "where MAPHIEUSUA = " + MaPhieuSua;

            SqlCommand cmd = new SqlCommand(SQL, _conn);
            cmd.ExecuteNonQuery();

            _conn.Close();
        }
    }
}
