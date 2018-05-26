using QuanLyGaraBUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGaraGUI
{
    public partial class ThongTinLienHeGUI : Form
    {
        XeBUS xeBUS = new XeBUS();

        public ThongTinLienHeGUI()
        {
            InitializeComponent();
        }

        private void ThongTinLienHeGUI_Load(object sender, EventArgs e)
        {

        }

        public void loadForm(string BienSo)
        {
            DataTable dt = xeBUS.timKiemXeBangBienSo(BienSo);
            txtBienSo.Text = dt.Rows[0][0].ToString();
            txtHieuXe.Text = dt.Rows[0][1].ToString();
            txtTenChuXe.Text = dt.Rows[0][2].ToString();
            txtMaChuXe.Text = dt.Rows[0][3].ToString();
            txtDiaChi.Text = dt.Rows[0][4].ToString();
            txtDienThoai.Text = dt.Rows[0][5].ToString(); ;
            txtEmail.Text = dt.Rows[0][6].ToString();
        }
    }
}
