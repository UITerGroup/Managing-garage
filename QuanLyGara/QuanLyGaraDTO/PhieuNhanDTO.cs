using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGaraDTO
{
    public class PhieuNhanDTO
    {
        private int _MaPhieuNhan;
        private string _BienSo;
        private string _NgayNhan;

        public int MaPhieuNhan
        {
            get
            {
                return _MaPhieuNhan;
            }

            set
            {
                _MaPhieuNhan = value;
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

        public string NgayNhan
        {
            get
            {
                return _NgayNhan;
            }

            set
            {
                _NgayNhan = value;
            }
        }

        public PhieuNhanDTO(int _MaPhieuNhan, string _BienSo, string _NgayNhan)
        {
            this.MaPhieuNhan = _MaPhieuNhan;
            this.BienSo = _BienSo;
            this.NgayNhan = _NgayNhan;
        }
    }
}
