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
    public partial class MainForm : Form
    {
        PhieuNhanBUS pnBUS = new PhieuNhanBUS();
        KhachHangBUS khBUS = new KhachHangBUS();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbbTimKiemPhieuNhan.SelectedIndex = 0;
            dtgvDanhSachPhieuNhan.DataSource = pnBUS.xemToanBoPhieuNhan();
            btnXoaPhieuNhan.Enabled = false;
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

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            BaoCaoGUI f = new BaoCaoGUI();
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

        private void cbbTimKiemPhieuNhan_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbTimKiemPhieuNhan.Text.Equals("Ngày tiếp nhận"))
            {
                lbTuNgay.Visible = true;
                lbDenNgay.Visible = true;
                dtpkTuNgay.Visible = true;
                dtpkDenNgay.Visible = true;
                txtTimKiemPhieuNhan.Enabled = false;
                txtTimKiemPhieuNhan.Text = "";
            }
            else
            {
                lbTuNgay.Visible = false;
                lbDenNgay.Visible = false;
                dtpkTuNgay.Visible = false;
                dtpkDenNgay.Visible = false;
                txtTimKiemPhieuNhan.Enabled = true;
            }
        }

        private void btnXemDanhSachPhieuNhan_Click(object sender, EventArgs e)
        {
            dtgvDanhSachPhieuNhan.DataSource = pnBUS.xemToanBoPhieuNhan();
        }

        private void btnThemPhieuNhan_Click(object sender, EventArgs e)
        {
            if (txtBienSo.Text != "")
            {
                // Tạo DTo
                string NgayNhan = dtpkNgayTiepNhan.Value.ToString("yyyy/MM/dd");

                PhieuNhanDTO pn = new PhieuNhanDTO(0, txtBienSo.Text, NgayNhan);

                // Them
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm phiếu nhận này không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (pnBUS.themPhieuNhan(pn))
                    {
                        MessageBox.Show("Thêm thành công");
                        dtgvDanhSachPhieuNhan.DataSource = pnBUS.xemToanBoPhieuNhan(); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa có đủ thông tin để thêm !");
            }
        }

        private void btnXoaPhieuNhan_Click(object sender, EventArgs e)
        {
            if (txtMaPhieuNhan.Text != "")
            {
                string thongbao = "Bạn có chắc muốn xóa phiếu nhận số " + txtMaPhieuNhan.Text + " ?";
                DialogResult dialogResult = MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (pnBUS.xoaPhieuNhan(Convert.ToInt32(txtMaPhieuNhan.Text)))
                    {
                        MessageBox.Show("Xóa thành công");
                        dtgvDanhSachPhieuNhan.DataSource = pnBUS.xemToanBoPhieuNhan();
                        lamMoiNoiDungPhieuNhan();
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

        private void btnTimKiemPhieuNhan_Click(object sender, EventArgs e)
        {
            if (cbbTimKiemPhieuNhan.SelectedItem.ToString() != "Ngày tiếp nhận" && txtTimKiemPhieuNhan.Text != "")
            {
                if (cbbTimKiemPhieuNhan.SelectedItem.Equals("Mã phiếu tiếp nhận"))
                {
                    CheckDigit ck = new CheckDigit();
                    if (ck.checkDigit(txtTimKiemPhieuNhan.Text))
                    {
                        dtgvDanhSachPhieuNhan.DataSource = pnBUS.timKiemPhieuNhanBangID(txtTimKiemPhieuNhan.Text);
                        if (dtgvDanhSachPhieuNhan.Rows.Count <= 0)
                        {
                            dtgvDanhSachPhieuNhan.DataSource = null;
                            MessageBox.Show("Không tìm được nội dung phù hợp");
                        }
                    }
                    else
                    {
                        dtgvDanhSachPhieuNhan.DataSource = null;
                        MessageBox.Show("Không tìm được nội dung phù hợp !");
                    }
                }
                else if (cbbTimKiemPhieuNhan.SelectedItem.Equals("Biển số"))
                {
                    dtgvDanhSachPhieuNhan.DataSource = pnBUS.timKiemPhieuNhanBangBienSo(txtTimKiemPhieuNhan.Text);
                    if (dtgvDanhSachPhieuNhan.Rows.Count <= 0)
                    {
                        dtgvDanhSachPhieuNhan.DataSource = null;
                        MessageBox.Show("Không tìm được nội dung phù hợp");
                    }
                }
                else if (cbbTimKiemPhieuNhan.SelectedItem.Equals("Hiệu xe"))
                {
                    dtgvDanhSachPhieuNhan.DataSource = pnBUS.timKiemPhieuNhanBangHieuXe(txtTimKiemPhieuNhan.Text);
                    if (dtgvDanhSachPhieuNhan.Rows.Count <= 0)
                    {
                        dtgvDanhSachPhieuNhan.DataSource = null;
                        MessageBox.Show("Không tìm được nội dung phù hợp");
                    }
                }
                else
                {
                    dtgvDanhSachPhieuNhan.DataSource = pnBUS.timKiemPhieuNhanBangTenChuXe(txtTimKiemPhieuNhan.Text);
                    if (dtgvDanhSachPhieuNhan.Rows.Count <= 0)
                    {
                        dtgvDanhSachPhieuNhan.DataSource = null;
                        MessageBox.Show("Không tìm được nội dung phù hợp");
                    }
                }
            }
            else if (cbbTimKiemPhieuNhan.SelectedItem.Equals("Ngày tiếp nhận"))
            {
                string NgayBatDau = dtpkTuNgay.Value.ToString("yyyy/MM/dd");
                string NgayKetThuc = dtpkDenNgay.Value.ToString("yyyy/MM/dd");
                dtgvDanhSachPhieuNhan.DataSource = pnBUS.timKiemPhieuNhanTheoNgay(NgayBatDau, NgayKetThuc);
                if (dtgvDanhSachPhieuNhan.Rows.Count <= 0)
                {
                    dtgvDanhSachPhieuNhan.DataSource = null;
                    MessageBox.Show("Không tìm được nội dung phù hợp");
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập thông tin tìm kiếm");
            }
        }

        private void lamMoiNoiDungPhieuNhan()
        {
            txtMaPhieuNhan.Text = "";
            txtBienSo.Text = "";
            txtTenChuXe.Text = "";
            txtHieuXe.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            dtpkNgayTiepNhan.Value = DateTime.Now;

            btnThemPhieuNhan.Enabled = true;
            btnXoaPhieuNhan.Enabled = false;
            btnKiemTraBienSo.Enabled = true;
            txtBienSo.ReadOnly = false; 
        }

        private void btnLamMoiPhieuNhan_Click(object sender, EventArgs e)
        {
            lamMoiNoiDungPhieuNhan();
        }

        private void dtgvDanhSachPhieuNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaPhieuNhan.Text = dtgvDanhSachPhieuNhan.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtBienSo.Text = dtgvDanhSachPhieuNhan.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtHieuXe.Text = dtgvDanhSachPhieuNhan.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTenChuXe.Text = dtgvDanhSachPhieuNhan.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDiaChi.Text = dtgvDanhSachPhieuNhan.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDienThoai.Text = dtgvDanhSachPhieuNhan.Rows[e.RowIndex].Cells[5].Value.ToString();
                dtpkNgayTiepNhan.Text = dtgvDanhSachPhieuNhan.Rows[e.RowIndex].Cells[6].Value.ToString();

                btnThemPhieuNhan.Enabled = false;
                btnXoaPhieuNhan.Enabled = true;
                btnKiemTraBienSo.Enabled = false;
                txtBienSo.ReadOnly = true;
            }
        }

        private void btnKiemTraBienSo_Click(object sender, EventArgs e)
        {
            if (txtBienSo.Text != "")
            {
                DataTable dt = khBUS.layThongTinKhBangBienSo(txtBienSo.Text);          
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("Không có biển số này trong hệ thống");
                }
                else
                {
                    txtHieuXe.Text = dt.Rows[0][0].ToString();
                    txtTenChuXe.Text = dt.Rows[0][1].ToString();
                    txtDiaChi.Text = dt.Rows[0][2].ToString();
                    txtDienThoai.Text = dt.Rows[0][3].ToString();
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập biển số xe tiếp nhận!");
            }
          
        }

       
    }
}
