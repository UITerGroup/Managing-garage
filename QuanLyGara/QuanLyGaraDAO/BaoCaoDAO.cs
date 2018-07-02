using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGaraDAO
{
    public class BaoCaoDAO : DBConnect
    {
        public DataTable baoCaoDoanhThu_TheoThang(int Thang, int Nam)
        {
            string SQL = "select ptt.MAPHIEUTHU as 'Mã phiếu thu', convert(nvarchar(10), ptt.NGAYTHU, 103) as 'Ngày thu', ";
            SQL += " kh.TENKH as 'Tên khách hàng', ps.BIENSO as 'Biển số', ptt.TIENTHU as 'Tiền thu' ";
            SQL += "from PHIEUTHU ptt, PHIEUSUACHUA ps, XE x, KHACHHANG kh ";
            SQL += "WHERE ptt.MAPHIEUSUA = ps.MAPHIEUSUA and ps.BIENSO = x.BIENSO and x.MAKH = kh.MAKH ";
            SQL += "and MONTH(ptt.NGAYTHU) = " + Thang;
            SQL += " and YEAR(ptt.NGAYTHU) = " + Nam;

            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable baoCaoDoanhThu_TheoQuy(int ThangBatDau, int ThangKetThuc, int Nam)
        {
            string SQL = "select ptt.MAPHIEUTHU as 'Mã phiếu thu', convert(nvarchar(10), ptt.NGAYTHU, 103) as 'Ngày thu', ";
            SQL += " kh.TENKH as 'Tên khách hàng', ps.BIENSO as 'Biển số', ptt.TIENTHU as 'Tiền thu' ";
            SQL += "from PHIEUTHU ptt, PHIEUSUACHUA ps, XE x, KHACHHANG kh ";
            SQL += "WHERE ptt.MAPHIEUSUA = ps.MAPHIEUSUA and ps.BIENSO = x.BIENSO and x.MAKH = kh.MAKH ";
            SQL += "and MONTH(ptt.NGAYTHU) between " + ThangBatDau + " and " + ThangKetThuc;
            SQL += " and YEAR(ptt.NGAYTHU) = " + Nam;

            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable baoCaoDoanhThu_TheoNam(int Nam)
        {
            string SQL = "select ptt.MAPHIEUTHU as 'Mã phiếu thu', convert(nvarchar(10), ptt.NGAYTHU, 103) as 'Ngày thu', ";
            SQL += " kh.TENKH as 'Tên khách hàng', ps.BIENSO as 'Biển số', ptt.TIENTHU as 'Tiền thu' ";
            SQL += "from PHIEUTHU ptt, PHIEUSUACHUA ps, XE x, KHACHHANG kh ";
            SQL += "WHERE ptt.MAPHIEUSUA = ps.MAPHIEUSUA and ps.BIENSO = x.BIENSO and x.MAKH = kh.MAKH ";
            SQL += " and YEAR(ptt.NGAYTHU) = " + Nam;

            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
