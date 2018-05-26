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
    public class PhieuNhanBUS
    {
        PhieuNhanDAO pnDAO = new PhieuNhanDAO();

        public DataTable xemToanBoPhieuNhan()
        {
            return pnDAO.xemToanBoPhieuNhan();
        }

        public bool themPhieuNhan(PhieuNhanDTO pn)
        {
            return pnDAO.themPhieuNhan(pn);
        }

        public bool xoaPhieuNhan(int MaPhieuNhan)
        {
            return pnDAO.xoaPhieuNhan(MaPhieuNhan);
        }

        public DataTable timKiemPhieuNhanBangID(string keyword)
        {
            return pnDAO.timKiemPhieuNhanBangID(keyword);
        }

        public DataTable timKiemPhieuNhanBangBienSo(string keyword)
        {
            return pnDAO.timKiemPhieuNhanBangBienSo(keyword);
        }

        public DataTable timKiemPhieuNhanBangHieuXe(string keyword)
        {
            return pnDAO.timKiemPhieuNhanBangHieuXe(keyword);
        }

        public DataTable timKiemPhieuNhanBangTenChuXe(string keyword)
        {
            return pnDAO.timKiemPhieuNhanBangTenChuXe(keyword);
        }

        public DataTable timKiemPhieuNhanTheoNgay(string NgayBatDau, string NgayKetThuc)
        {
            return pnDAO.timKiemPhieuNhanTheoNgay(NgayBatDau,NgayKetThuc);
        }

    }
}
