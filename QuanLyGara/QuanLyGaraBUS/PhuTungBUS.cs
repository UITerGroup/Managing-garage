using QuanLyGaraDAO;
using QuanLyGaraDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGaraBUS
{
    public class PhuTungBUS
    {
        PhuTungDAO ptDAO = new PhuTungDAO();

        public DataTable xemToanBoPhuTung()
        {
            return ptDAO.xemToanBoPhuTung();
        }

        public bool themPhuTung(PhuTungDTO pt)
        {
            return ptDAO.themPhuTung(pt);
        }

        public bool xoaPhuTung(string MaPhuTung)
        {
            return ptDAO.xoaPhuTung(MaPhuTung);
        }

        public bool capNhatThongTinPhuTung(PhuTungDTO pt)
        {
            return ptDAO.capNhatThongTinPhuTung(pt);
        }

        public bool capNhatMaPhuTung(string MaPhuTungCapNhat, string MaPhuTung)
        {
            return ptDAO.capNhatMaPhuTung(MaPhuTungCapNhat, MaPhuTung);
        }

        public bool giamSoLuongPhuTung(int SoLuongGiam, string MaPhuTung)
        {
            return ptDAO.giamSoLuongPhuTung (SoLuongGiam, MaPhuTung);
        }

        public bool tangSoLuongPhuTung(int SoLuongTang, string MaPhuTung)
        {
            return ptDAO.tangSoLuongPhuTung(SoLuongTang, MaPhuTung);
        }

        public bool kiemTraTonKho(string MaPhuTung, int SoLuong)
        {
            return ptDAO.kiemTraTonKho(MaPhuTung, SoLuong);
        }

        public DataTable timKiemPhuTungBangID(string keyword)
        {
            return ptDAO.timKiemPhuTungBangID(keyword);
        }

        public DataTable timKiemPhuTungBangTen(string keyword)
        {
            return ptDAO.timKiemPhuTungBangTen(keyword);
        }

        public DataTable layDanhSachTenPhuTung()
        {
            return ptDAO.layDanhSachTenPhuTung();
        }

        public string layMaPhuTung(string TenPhuTung, int DonGia)
        {
            return ptDAO.layMaPhuTung(TenPhuTung, DonGia);
        }

        public int layDonGia(string MaPhuTung)
        {
            return ptDAO.layDonGia(MaPhuTung);             
        }
    }
}
