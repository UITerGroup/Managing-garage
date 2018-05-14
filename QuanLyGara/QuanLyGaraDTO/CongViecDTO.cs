using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGaraDTO
{
    public class CongViecDTO
    {
        private string _MaCongViec;
        private string _NoiDungCongViec;
        private int _TienCong;

        public CongViecDTO(string _MaCongViec, string _NoiDungCongViec, int _TienCong)
        {
            this.MaCongViec = _MaCongViec;
            this.NoiDungCongViec = _NoiDungCongViec;
            this.TienCong = _TienCong;
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

        public string NoiDungCongViec
        {
            get
            {
                return _NoiDungCongViec;
            }

            set
            {
                _NoiDungCongViec = value;
            }
        }

        public int TienCong
        {
            get
            {
                return _TienCong;
            }

            set
            {
                _TienCong = value;
            }
        }
    }
}
