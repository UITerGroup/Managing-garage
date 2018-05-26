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
    public class KhachHangBUS
    {
        KhachHangDAO khDAO = new KhachHangDAO();

        public DataTable xemToanBoKhachHang()
        {
            return khDAO.xemToanBoKhachHang();
        }

        public bool themKhachHang(KhachHangDTO kh)
        {
            return khDAO.themKhachHang(kh);
        }

        public bool capNhatKhachHang(KhachHangDTO kh)
        {
            return khDAO.capNhatKhachHang(kh);
        }

        public DataTable timKiemKhachHangBangID(string keyword)
        {
            return khDAO.timKiemKhachHangBangID(keyword);
        }

        public DataTable timKiemKhachHangBangTen(string keyword)
        {
            return khDAO.timKiemKhachHangBangTen(keyword);
        }

        public DataTable layMaVaTenKH()
        {
            return khDAO.layMaVaTenKH();
        }

        public DataTable layThongTinKhBangBienSo(string BienSo)
        {
            return khDAO.layThongTinKhBangBienSo(BienSo);
        }
    }
}
