using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGaraDTO
{
    public class PhieuThuTienDTO
    {
        private int _MaPhieuSua;
        private int _MaPhieuThu;
        private string _NgayThu;
        private int _TienThu;

        public PhieuThuTienDTO(int _MaPhieuSua, int _MaPhieuThu, string _NgayThu, int _TienThu)
        {
            this.MaPhieuSua = _MaPhieuSua;
            this.MaPhieuThu = _MaPhieuThu;
            this.NgayThu = _NgayThu;
            this.TienThu = _TienThu;
        }

        public int MaPhieuSua
        {
            get
            {
                return _MaPhieuSua;
            }

            set
            {
                _MaPhieuSua = value;
            }
        }

        public int MaPhieuThu
        {
            get
            {
                return _MaPhieuThu;
            }

            set
            {
                _MaPhieuThu = value;
            }
        }

        public string NgayThu
        {
            get
            {
                return _NgayThu;
            }

            set
            {
                _NgayThu = value;
            }
        }

        public int TienThu
        {
            get
            {
                return _TienThu;
            }

            set
            {
                _TienThu = value;
            }
        }
    }
}
