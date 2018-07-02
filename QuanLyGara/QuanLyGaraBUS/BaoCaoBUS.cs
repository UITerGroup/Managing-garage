using QuanLyGaraDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGaraBUS
{
    public class BaoCaoBUS
    {
        BaoCaoDAO bcDAO = new BaoCaoDAO();

        public DataTable baoCaoDoanhThu_TheoThang(int Thang, int Nam)
        {
            return bcDAO.baoCaoDoanhThu_TheoThang(Thang, Nam);
        }

        public DataTable baoCaoDoanhThu_TheoQuy(int ThangBatDau, int ThangKetThuc, int Nam)
        {
            return bcDAO.baoCaoDoanhThu_TheoQuy(ThangBatDau, ThangKetThuc, Nam);
        }

        public DataTable baoCaoDoanhThu_TheoNam(int Nam)
        {
            return bcDAO.baoCaoDoanhThu_TheoNam(Nam);
        }
    }
}
