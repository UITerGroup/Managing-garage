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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            KhachHangGUI f = new KhachHangGUI();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnXe_Click(object sender, EventArgs e)
        {
            XeGUI f = new XeGUI();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnPhuTung_Click(object sender, EventArgs e)
        {
            PhuTungGUI f = new PhuTungGUI();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnCongViec_Click(object sender, EventArgs e)
        {
            CongViecGUI f = new CongViecGUI();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnPhieuSuaChua_Click(object sender, EventArgs e)
        {
            PhieuSuaChuaGUI f = new PhieuSuaChuaGUI();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
