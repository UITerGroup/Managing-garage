using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGaraDTO
{
    public class XeDTO
    {
        private string _BienSo;
        private string _HieuXe;
        private string _TenKhachHang;
        private int _MaKhachHang;
        private string _DiaChi;
        private string _DienThoai;
        private string _Email;

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

        public string HieuXe
        {
            get
            {
                return _HieuXe;
            }

            set
            {
                _HieuXe = value;
            }
        }

        public string TenKhachHang
        {
            get
            {
                return _TenKhachHang;
            }

            set
            {
                _TenKhachHang = value;
            }
        }

        public int MaKhachHang
        {
            get
            {
                return _MaKhachHang;
            }

            set
            {
                _MaKhachHang = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return _DiaChi;
            }

            set
            {
                _DiaChi = value;
            }
        }

        public string DienThoai
        {
            get
            {
                return _DienThoai;
            }

            set
            {
                _DienThoai = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }

        public XeDTO(string _BienSo, string _HieuXe, string _TenKhachHang, int _MaKhachHang, string _DiaChi, string _DienThoai, string _Email)
        {
            this.BienSo = _BienSo;
            this.HieuXe = _HieuXe;
            this.TenKhachHang = _TenKhachHang;
            this.MaKhachHang = _MaKhachHang;
            this.DiaChi = _DiaChi;
            this.DienThoai = _DienThoai;
            this.Email = _Email;
        }
    }
}
