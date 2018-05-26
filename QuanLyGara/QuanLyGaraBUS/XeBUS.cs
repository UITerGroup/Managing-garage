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
    public class XeBUS
    {
        XeDAO xeDAO = new XeDAO();

        public DataTable xemToanBoXe()
        {
            return xeDAO.xemToanBoXe();
        }

        public bool themXe(XeDTO xe)
        {
            return xeDAO.themXe(xe);
        }

        public bool xoaXe(string BienSo)
        {
            return xeDAO.xoaXe(BienSo);
        }

        public bool capNhatThongTinXe(XeDTO xe)
        {
            return xeDAO.capNhatThongTinXe(xe);
        }

        public bool capNhatBienSo(string BienSoMoi, string BienSoCu)
        {
            return xeDAO.capNhatBienSo(BienSoMoi, BienSoCu);
        }

        public DataTable timKiemXeBangBienSo(string keyword)
        {
            return xeDAO.timKiemXeBangBienSo(keyword);
        }

        public DataTable timKiemXeBangHieuXe(string keyword)
        {
            return xeDAO.timKiemXeBangHieuXe(keyword);
        }

        public DataTable timKiemXeBangMaChuXe(string keyword)
        {
            return xeDAO.timKiemXeBangMaChuXe(keyword);
        }

        public DataTable timKiemXeBangTenChuXe(string keyword)
        {
            return xeDAO.timKiemXeBangTenChuXe(keyword);
        }

        public int layMaChuXe(string BienSo)
        {
            return xeDAO.layMaChuXe(BienSo);
        }
    }
}
