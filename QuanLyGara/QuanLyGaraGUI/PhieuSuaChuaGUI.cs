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
    public partial class PhieuSuaChuaGUI : Form
    {
        PhieuSuaChuaBUS phieusuaBUS = new PhieuSuaChuaBUS();

        public PhieuSuaChuaGUI()
        {
            InitializeComponent();
        }

        private void PhieuSuaChuaGUI_Load(object sender, EventArgs e)
        {
            txtTinhTrang.Text = "Chưa thanh toán";
            cbbTimKiemPhieuSuaChua.SelectedIndex = 0;
            dtgvDanhSachPhieuSuaChua.DataSource = phieusuaBUS.xemToanPhieuSuaChua();
            btnXoaPhieuSuaChua.Enabled = false;
        }

        private void lamMoiNoiDungPhieuSuaChua()
        {
            txtMaPhieuSuaChua.Text = "";
            txtBienSo.Text = "";
            txtTinhTrang.Text = "Chưa thanh toán";

            txtBienSo.ReadOnly = false;
            dtpkNgaySuaChua.Value = DateTime.Now;

            btnXoaPhieuSuaChua.Enabled = false;
            btnThemPhieuSuaChua.Enabled = true;
            btnXemChiTietPhieuSua.Enabled = false;
        }

        private void btnLamMoiPhieuSuaChua_Click(object sender, EventArgs e)
        {
            lamMoiNoiDungPhieuSuaChua();        
        }

        private void btnXemDanhSachPhieuSuaChua_Click(object sender, EventArgs e)
        {
            dtgvDanhSachPhieuSuaChua.DataSource = phieusuaBUS.xemToanPhieuSuaChua();
        }

        private void btnThemPhieuSuaChua_Click(object sender, EventArgs e)
        {
            if (txtBienSo.Text != "")
            {
                // Tạo DTo
                string NgaySua = dtpkNgaySuaChua.Value.ToString("yyyy/MM/dd");

                PhieuSuaChuaDTO phieusua = new PhieuSuaChuaDTO(0, txtBienSo.Text, NgaySua, txtTinhTrang.Text);

                // Them
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm phiếu sửa này không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (phieusuaBUS.themPhieuSuaChua(phieusua))
                    {
                        MessageBox.Show("Thêm thành công");
                        dtgvDanhSachPhieuSuaChua.DataSource = phieusuaBUS.xemToanPhieuSuaChua(); // refresh datagridview
                        lamMoiNoiDungPhieuSuaChua();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại vì không có biển số này trong hệ thống!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa có đủ thông tin để thêm !");
            }
        }

        private void btnXoaPhieuSuaChua_Click(object sender, EventArgs e)
        {
            if (txtMaPhieuSuaChua.Text != "")
            {
                string thongbao = "Bạn có chắc muốn xóa phiếu sửa chữa số " + txtMaPhieuSuaChua.Text + " ?";
                DialogResult dialogResult = MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (phieusuaBUS.xoaPhieuSuaChua(Convert.ToInt32(txtMaPhieuSuaChua.Text)))
                    {
                        MessageBox.Show("Xóa thành công");
                        dtgvDanhSachPhieuSuaChua.DataSource = phieusuaBUS.xemToanPhieuSuaChua();
                        lamMoiNoiDungPhieuSuaChua();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa phiếu đã thanh toán!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa có đủ thông tin để xóa");
            }
        }

        private void btnTimKiemPhieuSuaChua_Click(object sender, EventArgs e)
        {
            if (cbbTimKiemPhieuSuaChua.SelectedItem.ToString() != "Ngày sửa" && txtTimKiemPhieuSuaChua.Text != "")
            {
                if (cbbTimKiemPhieuSuaChua.SelectedItem.Equals("Mã phiếu sửa chữa"))
                {
                    CheckDigit ck = new CheckDigit();
                    if (ck.checkDigit(txtTimKiemPhieuSuaChua.Text))
                    {
                        dtgvDanhSachPhieuSuaChua.DataSource = phieusuaBUS.timKiemPhieuSuaBangID(txtTimKiemPhieuSuaChua.Text);
                        if (dtgvDanhSachPhieuSuaChua.Rows.Count <= 0)
                        {
                            dtgvDanhSachPhieuSuaChua.DataSource = null;
                            MessageBox.Show("Không tìm được nội dung phù hợp");
                        }
                    }
                    else
                    {
                        dtgvDanhSachPhieuSuaChua.DataSource = null;
                        MessageBox.Show("Không tìm được nội dung phù hợp !");
                    }
                }
                else if (cbbTimKiemPhieuSuaChua.SelectedItem.Equals("Biển số"))
                {
                    dtgvDanhSachPhieuSuaChua.DataSource = phieusuaBUS.timKiemPhieuSuaBangBienSo(txtTimKiemPhieuSuaChua.Text);
                    if (dtgvDanhSachPhieuSuaChua.Rows.Count <= 0)
                    {
                        dtgvDanhSachPhieuSuaChua.DataSource = null;
                        MessageBox.Show("Không tìm được nội dung phù hợp");
                    }
                }
            }
            else if (cbbTimKiemPhieuSuaChua.SelectedItem.Equals("Ngày sửa"))
            {
                string NgayBatDau = dtpkTuNgay.Value.ToString("yyyy/MM/dd");
                string NgayKetThuc = dtpkDenNgay.Value.ToString("yyyy/MM/dd");
                dtgvDanhSachPhieuSuaChua.DataSource = phieusuaBUS.timKiemPhieuSuaTheoNgay(NgayBatDau, NgayKetThuc);
                if (dtgvDanhSachPhieuSuaChua.Rows.Count <= 0)
                {
                    dtgvDanhSachPhieuSuaChua.DataSource = null;
                    MessageBox.Show("Không tìm được nội dung phù hợp");
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập thông tin tìm kiếm");
            }
        }

        private void cbbTimKiemPhieuSuaChua_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbTimKiemPhieuSuaChua.Text.Equals("Ngày sửa"))
            {
                txtTimKiemPhieuSuaChua.Text = "";
                txtTimKiemPhieuSuaChua.Enabled = false;
                lbTuNgay.Visible = true;
                lbDenNgay.Visible = true;
                dtpkTuNgay.Visible = true;
                dtpkDenNgay.Visible = true;
            }
            else
            {
                txtTimKiemPhieuSuaChua.Enabled = true;
                lbTuNgay.Visible = false;
                lbDenNgay.Visible = false;
                dtpkTuNgay.Visible = false;
                dtpkDenNgay.Visible = false;
            }
        }

        private void dtgvDanhSachPhieuSuaChua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaPhieuSuaChua.Text = dtgvDanhSachPhieuSuaChua.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtBienSo.Text = dtgvDanhSachPhieuSuaChua.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtpkNgaySuaChua.Text = dtgvDanhSachPhieuSuaChua.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTinhTrang.Text = dtgvDanhSachPhieuSuaChua.Rows[e.RowIndex].Cells[3].Value.ToString();   
                          
                btnThemPhieuSuaChua.Enabled = false;
                btnXoaPhieuSuaChua.Enabled = true;
                btnXemChiTietPhieuSua.Enabled = true;

                txtBienSo.ReadOnly = true;
            }
        } 

        private void btnXemChiTietPhieuSua_Click(object sender, EventArgs e)
        {
            ChiTietPhieuSuaChuaGUI f = new ChiTietPhieuSuaChuaGUI();
            f.loadThongTinPhieuSua(txtMaPhieuSuaChua.Text, txtBienSo.Text, dtpkNgaySuaChua.Text, txtTinhTrang.Text);
            this.Hide();
            f.ShowDialog();
            this.Show();
            dtgvDanhSachPhieuSuaChua.DataSource = phieusuaBUS.xemToanPhieuSuaChua();
        }

    }
}
