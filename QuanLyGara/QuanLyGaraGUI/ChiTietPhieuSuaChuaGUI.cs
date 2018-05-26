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
    public partial class ChiTietPhieuSuaChuaGUI : Form
    {
        PhuTungBUS ptBUS = new PhuTungBUS();
        CongViecBUS cvBUS = new CongViecBUS();
        ChiTietPhieuSuaBUS ctpsBUS = new ChiTietPhieuSuaBUS();

        public ChiTietPhieuSuaChuaGUI()
        {
            InitializeComponent();
        }

        private void ChiTietPhieuSuaChuaGUI_Load(object sender, EventArgs e)
        {
            dtgvChiTietPhieuSua.DataSource = ctpsBUS.xemChiTietPhieuSua(Convert.ToInt32(txtMaPhieuSua.Text));
            btnXoaChiTiet.Enabled = false;
        }

        private void lamMoiChiTietPhieuSua()
        {
            cbbNoiDungCongViec.Text = "";
            cbbTenPhuTung.Text = "";
            txtMaCongViec.Text = "";
            txtTienCong.Text = "";
            txtMaPhuTung.Text = "";
            txtDonGia.Text = "";
            nudSoLuongPhuTung.Value = 0;
            txtThanhTien.Text = "";

            btnThemChiTiet.Enabled = true;
            btnXoaChiTiet.Enabled = false;
            nudSoLuongPhuTung.Enabled = true;

            cbbNoiDungCongViec.Enabled = true;
            cbbTenPhuTung.Enabled = true;
        }

        private void btnLamMoiChiTiet_Click(object sender, EventArgs e)
        {
            lamMoiChiTietPhieuSua();
           
        }

        public void loadThongTinPhieuSua(string MaPhieuSua, string BienSo, string NgaySua, string TinhTrang)
        {
            txtMaPhieuSua.Text = MaPhieuSua;
            txtBienSo.Text = BienSo;
            txtNgaySua.Text = NgaySua;
            txtTinhTrang.Text = TinhTrang;
        }
  
        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            if (txtMaPhuTung.Text != "" && txtMaCongViec.Text != "")
            {
                // Tạo DTo
                int MaPhieuSua = Convert.ToInt32(txtMaPhieuSua.Text);
                ChiTietPhieuSuaDTO ctps = new ChiTietPhieuSuaDTO(MaPhieuSua, txtMaPhuTung.Text, txtMaCongViec.Text, (int)nudSoLuongPhuTung.Value);

                if (txtMaPhuTung.Text != "-" && nudSoLuongPhuTung.Value == 0)
                {
                    MessageBox.Show("Hãy nhập số lượng phụ tùng !");
                }
                // Them
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm nội dung này không ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (ctpsBUS.themChiTiet(ctps))
                        {
                            MessageBox.Show("Thêm thành công");
                            dtgvChiTietPhieuSua.DataSource = ctpsBUS.xemChiTietPhieuSua(MaPhieuSua); // refresh datagridview
                            lamMoiChiTietPhieuSua();
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại vì đã có phụ tùng này trong hệ thống !");
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Chưa có đủ thông tin để thêm ");
            }
        }

        private void btnXoaChiTiet_Click(object sender, EventArgs e)
        {
            if (txtMaCongViec.Text != "" && txtMaPhuTung.Text != "")
            {
                string thongbao = "Bạn có chắc muốn xóa nội dung này không?";
                DialogResult dialogResult = MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (ctpsBUS.xoaChiTiet(Convert.ToInt32(txtMaPhieuSua.Text), txtMaCongViec.Text, txtMaPhuTung.Text))
                    {
                        MessageBox.Show("Xóa thành công");
                        dtgvChiTietPhieuSua.DataSource = ctpsBUS.xemChiTietPhieuSua(Convert.ToInt32(txtMaPhieuSua.Text));
                        lamMoiChiTietPhieuSua();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa có đủ thông tin để xóa");
            }
        }

        private void cbbNoiDungCongViec_Click(object sender, EventArgs e)
        {
            cbbNoiDungCongViec.DataSource = cvBUS.layDanhSachNoiDungCongViec();
            cbbNoiDungCongViec.DisplayMember = "NOIDUNGCV";
            cbbNoiDungCongViec.ValueMember = "NOIDUNGCV";
        }

        private void cbbNoiDungCongViec_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbNoiDungCongViec.SelectedIndex >= 0)
            {
                string s = "";
                for (int i = 0; i < cbbNoiDungCongViec.Text.Length; i++)
                {
                    if (char.IsWhiteSpace(cbbNoiDungCongViec.Text[i]) == false)
                        s += cbbNoiDungCongViec.Text[i];
                    else
                        break;
                }
                txtMaCongViec.Text = s;
                if (txtMaCongViec.Text != "" && txtMaCongViec.Text != "System.Data.DataRowView")
                {
                    int TienCong = cvBUS.layTienCong(txtMaCongViec.Text);
                    txtTienCong.Text = TienCong.ToString();
                }

            }
        }

        private void cbbTenPhuTung_Click(object sender, EventArgs e)
        {
            cbbTenPhuTung.DataSource = ptBUS.layDanhSachTenPhuTung();
            cbbTenPhuTung.DisplayMember = "TENPHUTUNG";
            cbbTenPhuTung.ValueMember = "TENPHUTUNG";
        }

        private void cbbTenPhuTung_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbTenPhuTung.SelectedIndex >= 0)
            {
                string s = "";
                for (int i = 0; i < cbbTenPhuTung.Text.Length; i++)
                {
                    if (char.IsWhiteSpace(cbbTenPhuTung.Text[i]) == false)
                        s += cbbTenPhuTung.Text[i];
                    else
                        break;
                }
                txtMaPhuTung.Text = s;
                if (txtMaPhuTung.Text != "" && txtMaPhuTung.Text != "System.Data.DataRowView")
                {
                    if (txtMaPhuTung.Text == "-")
                    {
                        int DonGia = ptBUS.layDonGia(txtMaPhuTung.Text);
                        txtDonGia.Text = DonGia.ToString();
                        nudSoLuongPhuTung.Value = 0;
                        nudSoLuongPhuTung.Enabled = false;              
                    }
                    else
                    {
                        int DonGia = ptBUS.layDonGia(txtMaPhuTung.Text);
                        txtDonGia.Text = DonGia.ToString();
                        nudSoLuongPhuTung.Enabled = true;
                    }       
                }

            }           
        }

        private void dtgvChiTietPhieuSua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string NoiDungCongViec = dtgvChiTietPhieuSua.Rows[e.RowIndex].Cells[0].Value.ToString();
                int TienCong = Convert.ToInt32(dtgvChiTietPhieuSua.Rows[e.RowIndex].Cells[1].Value.ToString());
                string MaCongViec = cvBUS.layMaCongViec(NoiDungCongViec,TienCong);

                cbbNoiDungCongViec.Text = MaCongViec + " - " + NoiDungCongViec;
                txtMaCongViec.Text = MaCongViec;
                txtTienCong.Text = TienCong.ToString();
                
                string TenPhuTung = dtgvChiTietPhieuSua.Rows[e.RowIndex].Cells[2].Value.ToString();
                int DonGia = Convert.ToInt32(dtgvChiTietPhieuSua.Rows[e.RowIndex].Cells[3].Value.ToString());
                string MaPhuTung = ptBUS.layMaPhuTung(TenPhuTung, DonGia);

                cbbTenPhuTung.Text = MaPhuTung + " - " + TenPhuTung;           
                txtMaPhuTung.Text = MaPhuTung;
                txtDonGia.Text = DonGia.ToString();

                nudSoLuongPhuTung.Value = Convert.ToInt32(dtgvChiTietPhieuSua.Rows[e.RowIndex].Cells[4].Value.ToString());
                txtThanhTien.Text = dtgvChiTietPhieuSua.Rows[e.RowIndex].Cells[5].Value.ToString();

                btnThemChiTiet.Enabled = false;
                btnXoaChiTiet.Enabled = true;
                cbbNoiDungCongViec.Enabled = false;
                cbbTenPhuTung.Enabled = false;
                nudSoLuongPhuTung.Enabled = false;
            }
        }

        private void btnXemThongTinChuXe_Click(object sender, EventArgs e)
        {
            ThongTinLienHeGUI f = new ThongTinLienHeGUI();
            f.loadForm(txtBienSo.Text);
            //this.Hide();
            f.Show();
            this.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
