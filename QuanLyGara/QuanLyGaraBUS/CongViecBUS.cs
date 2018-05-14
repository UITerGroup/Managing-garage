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
    public class CongViecBUS
    {
        CongViecDAO cvDAO = new CongViecDAO();

        public DataTable xemToanBoCongViec()
        {
            return cvDAO.xemToanBoCongViec();
        }

        public bool themCongViec(CongViecDTO cv)
        {
            return cvDAO.themCongViec(cv);
        }

        public bool xoaCongViec(string MaCongViec)
        {
            return cvDAO.xoaCongViec(MaCongViec);
        }

        public bool capNhatThongTinCongViec(CongViecDTO cv)
        {
            return cvDAO.capNhatThongTinCongViec(cv);
        }

        public bool capNhatMaCongViec(string MaCongViecCapNhat, string MaCongViec)
        {
            return cvDAO.capNhatMaCongViec(MaCongViecCapNhat, MaCongViec);
        }

        public DataTable timKiemCongViecBangID(string keyword)
        {
            return cvDAO.timKiemCongViecBangID(keyword);
        }

        public DataTable timKiemCongViecBangTen(string keyword)
        {
            return cvDAO.timKiemPhuTungBangTen(keyword);
        }
    }
}
