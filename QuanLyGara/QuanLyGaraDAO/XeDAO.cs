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
    public class XeDAO : DBConnect
    {
        public DataTable xemToanBoXe()
        {
            string SQL = "select x.BIENSO as 'Biển số', x.HIEUXE as 'Hiệu xe', ";
            SQL += "kh.TENKH as 'Tên chủ xe', kh.DIACHI as 'Địa chỉ', ";
            SQL += "kh.DIENTHOAI as 'Điện thoại', kh.EMAIL as 'Email' ";
            SQL += "from XE x, KHACHHANG kh ";
            SQL += "where x.MAKH = kh.MAKH ";
            SQL += "order by x.MAKH ASC";
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtXe = new DataTable();
            da.Fill(dtXe);
            return dtXe;
        }

        public bool themXe(XeDTO xe)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("insert into XE(BIENSO, HIEUXE, MAKH) VALUES (N'{0}', N'{1}', {2})", xe.BienSo, xe.HieuXe, xe.MaKhachHang);

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool xoaXe(string BienSo)
        {
            try
            {
                _conn.Open();

                string SQL = "delete from XE where BIENSO = '" + BienSo + "'";

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool capNhatThongTinXe(XeDTO xe)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("update XE set HIEUXE = N'{0}', MAKH = {1} where BIENSO = '{2}'", xe.HieuXe, xe.MaKhachHang, xe.BienSo);

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool capNhatBienSo(string BienSoMoi, string BienSoCu)
        {
            try
            {
                _conn.Open();

                string SQL = "update XE set BIENSO = '" + BienSoMoi + "'";
                SQL += " where BIENSO = '" + BienSoCu + "'";

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public DataTable timKiemXeBangBienSo(string keyword)
        {
            string SQL = "select x.BIENSO as 'Biển số', x.HIEUXE as 'Hiệu xe', ";
            SQL += "kh.TENKH as 'Tên chủ xe', kh.MAKH as 'Mã chủ xe', ";
            SQL += "kh.DIACHI as 'Địa chỉ', kh.DIENTHOAI as 'Điện thoại', kh.EMAIL as 'Email' ";
            SQL += "from XE x, KHACHHANG kh ";
            SQL += "where x.MAKH = kh.MAKH and x.BIENSO like '%" + keyword + "%' ";
            SQL += "order by x.MAKH ASC";
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtXeTimDuoc = new DataTable();
            da.Fill(dtXeTimDuoc);
            return dtXeTimDuoc;
        }

        public DataTable timKiemXeBangHieuXe(string keyword)
        {
            string SQL = "select x.BIENSO as 'Biển số', x.HIEUXE as 'Hiệu xe', ";
            SQL += "kh.TENKH as 'Tên chủ xe', kh.MAKH as 'Mã chủ xe', ";
            SQL += "kh.DIACHI as 'Địa chỉ', kh.DIENTHOAI as 'Điện thoại', kh.EMAIL as 'Email' ";
            SQL += "from XE x, KHACHHANG kh ";
            SQL += "where x.MAKH = kh.MAKH and x.HIEUXE like '%" + keyword + "%' ";
            SQL += "order by x.MAKH ASC";
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtXeTimDuoc = new DataTable();
            da.Fill(dtXeTimDuoc);
            return dtXeTimDuoc;
        }

        public DataTable timKiemXeBangMaChuXe(string keyword)
        {
            string SQL = "select x.BIENSO as 'Biển số', x.HIEUXE as 'Hiệu xe', ";
            SQL += "kh.TENKH as 'Tên chủ xe', kh.MAKH as 'Mã chủ xe', ";
            SQL += "kh.DIACHI as 'Địa chỉ', kh.DIENTHOAI as 'Điện thoại', kh.EMAIL as 'Email' ";
            SQL += "from XE x, KHACHHANG kh ";
            SQL += "where x.MAKH = kh.MAKH and x.MAKH = " + Convert.ToInt32(keyword);
            SQL += "order by x.MAKH ASC";
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtXeTimDuoc = new DataTable();
            da.Fill(dtXeTimDuoc);
            return dtXeTimDuoc;
        }

        public DataTable timKiemXeBangTenChuXe(string keyword)
        {
            string SQL = "select x.BIENSO as 'Biển số', x.HIEUXE as 'Hiệu xe', ";
            SQL += "kh.TENKH as 'Tên chủ xe', kh.MAKH as 'Mã chủ xe', ";
            SQL += "kh.DIACHI as 'Địa chỉ', kh.DIENTHOAI as 'Điện thoại', kh.EMAIL as 'Email' ";
            SQL += "from XE x, KHACHHANG kh ";
            SQL += "where x.MAKH = kh.MAKH and kh.TENKH like N'%" + keyword + "%' ";
            SQL += "order by x.MAKH ASC";
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtXeTimDuoc = new DataTable();
            da.Fill(dtXeTimDuoc);
            return dtXeTimDuoc;
        }

        public int layMaChuXe(string BienSo)
        {
            string SQL = "select MAKH from XE where BIENSO = '" + BienSo + "'";
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtMaChuXe = new DataTable();
            da.Fill(dtMaChuXe);
            int MaChuXe = Convert.ToInt32(dtMaChuXe.Rows[0][0]);
            return MaChuXe;
        }
    }
}
