using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGaraDTO
{
    public class PhieuSuaChuaDTO
    {
        private int _MaPhieuSua;
        private string _BienSo;
        private string _NgaySua;
        private string _TinhTrang;

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

        public string BienSo
        {
            get
            {
                return _BienSo;
            }

            set
            {
                _BienSo = value;
            }
        }

        public string NgaySua
        {
            get
            {
                return _NgaySua;
            }

            set
            {
                _NgaySua = value;
            }
        }

        public string TinhTrang
        {
            get
            {
                return _TinhTrang;
            }

            set
            {
                _TinhTrang = value;
            }
        }

        public PhieuSuaChuaDTO(int _MaPhieuSua, string _BienSo, string _NgaySua, string _TinhTrang)
        {
            this.MaPhieuSua = _MaPhieuSua;
            this.BienSo = _BienSo;
            this.NgaySua = _NgaySua;
            this.TinhTrang = _TinhTrang;
        }
    }
}
