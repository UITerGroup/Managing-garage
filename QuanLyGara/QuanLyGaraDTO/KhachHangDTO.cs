using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGaraDTO
{
    public class KhachHangDTO
    {
        private int _MaKH;
        private String _TenKH;
        private String _DiaChi;
        private String _DienThoai;
        private String _Email;

        //Constructor
        public KhachHangDTO(int _MaKH, string _TenKH, string _DiaChi, string _DienThoai, string _Email)
        {
            this._MaKH = _MaKH;
            this._TenKH = _TenKH;
            this._DiaChi = _DiaChi;
            this._DienThoai = _DienThoai;
            this._Email = _Email;
        }

        //Getter-Setter
        public int MaKH
        {
            get
            {
                return _MaKH;
            }

            set
            {
                _MaKH = value;
            }
        }

        public string TenKH
        {
            get
            {
                return _TenKH;
            }

            set
            {
                _TenKH = value;
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
    }
}
