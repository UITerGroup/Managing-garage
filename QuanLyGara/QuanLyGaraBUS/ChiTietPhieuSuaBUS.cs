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
    public class ChiTietPhieuSuaBUS
    {
        ChiTietPhieuSuaDAO ctpsDAO = new ChiTietPhieuSuaDAO();

        public DataTable xemChiTietPhieuSua(int MaPhieuSua)
        {
            return ctpsDAO.xemChiTietPhieuSua(MaPhieuSua);
        }

        public bool xoaChiTiet(int MaPhieuSua, string MaCongViec, string MaPhuTung)
        {
            return ctpsDAO.xoaChiTiet(MaPhieuSua, MaCongViec, MaPhuTung);
        }

        public bool themChiTiet(ChiTietPhieuSuaDTO ctps)
        {
            return ctpsDAO.themChiTiet(ctps);
        }
    }
}
