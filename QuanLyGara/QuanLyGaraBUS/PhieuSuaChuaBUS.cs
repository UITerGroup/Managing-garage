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
    public class PhieuSuaChuaBUS
    {
        PhieuSuaChuaDAO phieusuaDAO = new PhieuSuaChuaDAO();

        public DataTable xemToanPhieuSuaChua()
        {
            return phieusuaDAO.xemToanBoPhieuSuaChua();
        }

        public bool themPhieuSuaChua(PhieuSuaChuaDTO phieusua)
        {
            return phieusuaDAO.themPhieuSuaChua(phieusua);
        }

        public bool xoaPhieuSuaChua(int MaPhieuSuaChua)
        {
            return phieusuaDAO.xoaPhieuSuaChua(MaPhieuSuaChua);
        }

        public DataTable timKiemPhieuSuaBangID(string keyword)
        {
            return phieusuaDAO.timKiemPhieuSuaBangID(keyword);
        }

        public DataTable timKiemPhieuSuaBangBienSo(string keyword)
        {
            return phieusuaDAO.timKiemPhieuSuaBangBienSo(keyword);
        }
       
        public DataTable timKiemPhieuSuaTheoNgay(string NgayBatDau, string NgayKetThuc)
        {
            return phieusuaDAO.timKiemPhieuSuaTheoNgay(NgayBatDau, NgayKetThuc);
        }
    }
}
