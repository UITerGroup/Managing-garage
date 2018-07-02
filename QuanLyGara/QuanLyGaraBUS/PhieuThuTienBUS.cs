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
    public class PhieuThuTienBUS
    {
        PhieuThuTienDAO pttDAO = new PhieuThuTienDAO();

        public bool themPhieuThu(PhieuThuTienDTO ptt)
        {
            return pttDAO.themPhieuThu(ptt);
        }

        public DataTable loadPhieuDaThu(int MaPhieu)
        {
            return pttDAO.loadPhieuDaThu(MaPhieu);
        }

    }
}
