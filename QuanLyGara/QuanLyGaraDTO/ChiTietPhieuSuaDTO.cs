using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGaraDTO
{
    public class ChiTietPhieuSuaDTO
    {
        private int _MaPhieuSua;
        private string _MaPhuTung;
        private string _MaCongViec;
        private int _SoLuongPhuTung;

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

        public string MaCongViec
        {
            get
            {
                return _MaCongViec;
            }

            set
            {
                _MaCongViec = value;
            }
        }

        public int SoLuongPhuTung
        {
            get
            {
                return _SoLuongPhuTung;
            }

            set
            {
                _SoLuongPhuTung = value;
            }
        }

        public ChiTietPhieuSuaDTO(int _MaPhieuSua, string _MaPhuTung, string _MaCongViec, int _SoLuongPhuTung)
        {
            this.MaPhieuSua = _MaPhieuSua;
            this.MaPhuTung = _MaPhuTung;
            this.MaCongViec = _MaCongViec;
            this.SoLuongPhuTung = _SoLuongPhuTung;
        }
    }
}
