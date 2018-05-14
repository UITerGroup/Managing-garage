using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGaraDTO
{
    public class PhuTungDTO
    {
        private string _MaPhuTung;
        private string _TenPhuTung;
        private int _DonGia;
        private int _SoLuongTon;

        public string MaPhuTung
        {
            get
            {
                return _MaPhuTung;
            }

            set
            {
                _MaPhuTung = value;
            }
        }

        public string TenPhuTung
        {
            get
            {
                return _TenPhuTung;
            }

            set
            {
                _TenPhuTung = value;
            }
        }

        public int DonGia
        {
            get
            {
                return _DonGia;
            }

            set
            {
                _DonGia = value;
            }
        }

        public int SoLuongTon
        {
            get
            {
                return _SoLuongTon;
            }

            set
            {
                _SoLuongTon = value;
            }
        }

        public PhuTungDTO(string _MaPhuTung, string _TenPhuTung, int _DonGia, int _SoLuongTon)
        {
            this.MaPhuTung = _MaPhuTung;
            this.TenPhuTung = _TenPhuTung;
            this.DonGia = _DonGia;
            this.SoLuongTon = _SoLuongTon;
        }
    }
}
