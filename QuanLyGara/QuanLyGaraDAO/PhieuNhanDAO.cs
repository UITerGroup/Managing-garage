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
    public class PhieuNhanDAO : DBConnect
    {
        public DataTable xemToanBoPhieuNhan()
        {
            string SQL = "select pn.MAPHIEUNHAN as 'Mã phiếu', ";
            SQL += "pn.BIENSO as 'Biển số', x.HIEUXE as 'Hiệu xe', ";
            SQL += "kh.TENKH as 'Tên khách hàng', kh.DIACHI as 'Địa chỉ', kh.DIENTHOAI as 'Điện thoại',";
            SQL += "convert(nvarchar(10), pn.NGAYNHAN, 103) as 'Ngày nhận' ";
            SQL += "from XE x, KHACHHANG kh, PHIEUNHAN pn ";
            SQL += "where pn.BIENSO = x.BIENSO AND x.MAKH = kh.MAKH";
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtPhieuNhan = new DataTable();
            da.Fill(dtPhieuNhan);
            return dtPhieuNhan;
        }

        public bool themPhieuNhan(PhieuNhanDTO pn)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("insert into PHIEUNHAN(BIENSO, NGAYNHAN) VALUES (N'{0}', N'{1}')", pn.BienSo, pn.NgayNhan);

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

        public bool xoaPhieuNhan(int MaPhieuNhan)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = "delete from PHIEUNHAN where MAPHIEUNHAN = '" + MaPhieuNhan + "'";

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

        public DataTable timKiemPhieuNhanBangID(string keyword)
        {
            string SQL = "select pn.MAPHIEUNHAN as 'Mã phiếu', ";
            SQL += "pn.BIENSO as 'Biển số', x.HIEUXE as 'Hiệu xe', ";
            SQL += "kh.TENKH as 'Tên khách hàng', kh.DIACHI as 'Địa chỉ', kh.DIENTHOAI as 'Điện thoại',";
            SQL += "convert(nvarchar(10), pn.NGAYNHAN, 103) as 'Ngày nhận' ";
            SQL += "from XE x, KHACHHANG kh, PHIEUNHAN pn ";
            SQL += "where pn.BIENSO = x.BIENSO AND x.MAKH = kh.MAKH ";
            SQL += "and pn.MAPHIEUNHAN = " + Convert.ToInt32(keyword);
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtPhieuNhan = new DataTable();
            da.Fill(dtPhieuNhan);
            return dtPhieuNhan;
        }

        public DataTable timKiemPhieuNhanBangBienSo(string keyword)
        {
            string SQL = "select pn.MAPHIEUNHAN as 'Mã phiếu', ";
            SQL += "pn.BIENSO as 'Biển số', x.HIEUXE as 'Hiệu xe', ";
            SQL += "kh.TENKH as 'Tên khách hàng', kh.DIACHI as 'Địa chỉ', kh.DIENTHOAI as 'Điện thoại',";
            SQL += "convert(nvarchar(10), pn.NGAYNHAN, 103) as 'Ngày nhận' ";
            SQL += "from XE x, KHACHHANG kh, PHIEUNHAN pn ";
            SQL += "where pn.BIENSO = x.BIENSO AND x.MAKH = kh.MAKH ";
            SQL += "and pn.BIENSO like N'%" + keyword + "%'";
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtPhieuNhan = new DataTable();
            da.Fill(dtPhieuNhan);
            return dtPhieuNhan;
        }

        public DataTable timKiemPhieuNhanBangHieuXe(string keyword)
        {
            string SQL = "select pn.MAPHIEUNHAN as 'Mã phiếu', ";
            SQL += "pn.BIENSO as 'Biển số', x.HIEUXE as 'Hiệu xe', ";
            SQL += "kh.TENKH as 'Tên khách hàng', kh.DIACHI as 'Địa chỉ', kh.DIENTHOAI as 'Điện thoại',";
            SQL += "convert(nvarchar(10), pn.NGAYNHAN, 103) as 'Ngày nhận' ";
            SQL += "from XE x, KHACHHANG kh, PHIEUNHAN pn ";
            SQL += "where pn.BIENSO = x.BIENSO AND x.MAKH = kh.MAKH ";
            SQL += "and x.HIEUXE like N'%" + keyword + "%'";
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtPhieuNhan = new DataTable();
            da.Fill(dtPhieuNhan);
            return dtPhieuNhan;
        }

        public DataTable timKiemPhieuNhanBangTenChuXe(string keyword)
        {
            string SQL = "select pn.MAPHIEUNHAN as 'Mã phiếu', ";
            SQL += "pn.BIENSO as 'Biển số', x.HIEUXE as 'Hiệu xe', ";
            SQL += "kh.TENKH as 'Tên khách hàng', kh.DIACHI as 'Địa chỉ', kh.DIENTHOAI as 'Điện thoại',";
            SQL += "convert(nvarchar(10), pn.NGAYNHAN, 103) as 'Ngày nhận' ";
            SQL += "from XE x, KHACHHANG kh, PHIEUNHAN pn ";
            SQL += "where pn.BIENSO = x.BIENSO AND x.MAKH = kh.MAKH ";
            SQL += "and kh.TENKH like N'%" + keyword + "%'";
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtPhieuNhan = new DataTable();
            da.Fill(dtPhieuNhan);
            return dtPhieuNhan;
        }

        public DataTable timKiemPhieuNhanTheoNgay(string NgayBatDau, string NgayKetThuc)
        {
            string SQL = "select pn.MAPHIEUNHAN as 'Mã phiếu', ";
            SQL += "pn.BIENSO as 'Biển số', x.HIEUXE as 'Hiệu xe', ";
            SQL += "kh.TENKH as 'Tên khách hàng', kh.DIACHI as 'Địa chỉ', kh.DIENTHOAI as 'Điện thoại',";
            SQL += "convert(nvarchar(10), pn.NGAYNHAN, 103) as 'Ngày nhận' ";
            SQL += "from XE x, KHACHHANG kh, PHIEUNHAN pn ";
            SQL += "where pn.BIENSO = x.BIENSO AND x.MAKH = kh.MAKH ";
            SQL += "and pn.NGAYNHAN between '" + NgayBatDau + "' and '" + NgayKetThuc + "'";
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtPhieuNhan = new DataTable();
            da.Fill(dtPhieuNhan);
            return dtPhieuNhan;
        }
       
    }
}
