using QuanLyGaraBUS;
using QuanLyGaraDTO;
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
    public partial class PhieuThuTienGUI : Form
    {
        XeBUS xeBUS = new XeBUS();
        PhieuThuTienBUS pttBUS = new PhieuThuTienBUS();
        PhieuSuaChuaBUS psBUS = new PhieuSuaChuaBUS();

        public PhieuThuTienGUI()
        {
            InitializeComponent();
        }

        public void loadThongTinPhieuThu(string TinhTrang, string MaPhieu, string BienSo, string SoTienThu)
        {
            if (TinhTrang.Equals("Đã thanh toán"))
            {
                lbTinhTrang.Visible = true;
                btnLuuPhieu.Visible = false;

                DataTable dt = pttBUS.loadPhieuDaThu(Convert.ToInt32(MaPhieu));

                txtMaPhieuThu.Text = dt.Rows[0][0].ToString();
                txtTenChuXe.Text = dt.Rows[0][1].ToString();
                txtBienSo.Text = dt.Rows[0][2].ToString();
                txtDienThoai.Text = dt.Rows[0][3].ToString();
                txtEmail.Text = dt.Rows[0][4].ToString();
                dtpkNgayThu.Text = dt.Rows[0][5].ToString();
                txtSoTienThu.Text = dt.Rows[0][6].ToString();
            }
            else
            {
                lbTinhTrang.Visible = false;
                btnLuuPhieu.Visible = true;

                txtMaPhieuThu.Text = MaPhieu;

                DataTable dt = xeBUS.timKiemXeBangBienSo(BienSo);
                txtBienSo.Text = dt.Rows[0][0].ToString();
                txtTenChuXe.Text = dt.Rows[0][2].ToString();
                txtDienThoai.Text = dt.Rows[0][5].ToString(); ;
                txtEmail.Text = dt.Rows[0][6].ToString();

                txtSoTienThu.Text = SoTienThu;
            }          
        }

        private void btnLuuPhieu_Click(object sender, EventArgs e)
        {
            // Tạo DTo
            
            int MaPhieuSua = Convert.ToInt32(txtMaPhieuThu.Text);
            int MaPhieuThu = MaPhieuSua;
            string NgayThu = dtpkNgayThu.Value.ToString("yyyy/MM/dd");
            int SoTienThu = Convert.ToInt32(txtSoTienThu.Text);

            PhieuThuTienDTO ptt = new PhieuThuTienDTO(MaPhieuSua, MaPhieuThu, NgayThu, SoTienThu);

            // Them
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn lưu phiếu này ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (pttBUS.themPhieuThu(ptt))
                {
                    MessageBox.Show("Lưu thành công");
                    psBUS.setTinhTrangPhieu(MaPhieuSua);
                    btnLuuPhieu.Visible = false;
                    lbTinhTrang.Visible = true;
                    
                }
            }
            
        }

        private void PhieuThuTienGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm main = new MainForm();
            ChiTietPhieuSuaChuaGUI ctpsGUI = new ChiTietPhieuSuaChuaGUI();
            PhieuSuaChuaGUI psGUI = new PhieuSuaChuaGUI();
            this.Close();       
        }

        private void PhieuThuTienGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Trở về giao diện Quản lý phiếu sửa chữa?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
