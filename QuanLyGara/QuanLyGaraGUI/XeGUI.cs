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
    public partial class XeGUI : Form
    {
        XeBUS xeBUS = new XeBUS();
        KhachHangBUS khBUS = new KhachHangBUS();

        public XeGUI()
        {
            InitializeComponent();
        }

        private void XeGUI_Load(object sender, EventArgs e)
        {
            cbbTimKiemXe.SelectedIndex = 0; 
            dtgvDanhSachXe.DataSource = xeBUS.xemToanBoXe();
            btnCapNhatXe.Enabled = false;
            btnXoaXe.Enabled = false; 
        }

        private void btnXemDanhSachXe_Click(object sender, EventArgs e)
        {
            dtgvDanhSachXe.DataSource = xeBUS.xemToanBoXe();
        }

        private void lamMoiNoiDungXe()
        {
            txtBienSo.Text = "";
            txtBienSoCapNhat.Text = "";
            txtHieuXe.Text = "";
            cbbTenChuXe.Text = "";
            txtMaChuXe.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            btnThemXe.Enabled = true;
            btnCapNhatXe.Enabled = false;
            btnXoaXe.Enabled = false;
        }

        private void btnLamMoiXe_Click(object sender, EventArgs e)
        {
            lamMoiNoiDungXe();       
        }

        private void btnThemXe_Click(object sender, EventArgs e)
        {
            if (txtBienSo.Text != "" && txtHieuXe.Text != "" && txtMaChuXe.Text != "")
            {
                // Tạo DTo
                XeDTO xe = new XeDTO(txtBienSo.Text, txtHieuXe.Text, cbbTenChuXe.Text, Convert.ToInt32(txtMaChuXe.Text), txtDiaChi.Text, txtDienThoai.Text, txtEmail.Text);

                // Them
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm xe này không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (xeBUS.themXe(xe))
                    {
                        MessageBox.Show("Thêm thành công");
                        dtgvDanhSachXe.DataSource = xeBUS.xemToanBoXe(); // refresh datagridview
                        lamMoiNoiDungXe();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại vì đã biển số này trong hệ thống !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa có đủ thông tin để thêm ");
            }
        }

        private void btnXoaXe_Click(object sender, EventArgs e)
        {
            if (txtBienSoCapNhat.Text != "")
            {
                string thongbao = "Bạn có chắc muốn xóa xe có biển số " + txtBienSoCapNhat.Text + " ?";
                DialogResult dialogResult = MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (xeBUS.xoaXe(txtBienSoCapNhat.Text))
                    {
                        MessageBox.Show("Xóa thành công");
                        dtgvDanhSachXe.DataSource = xeBUS.xemToanBoXe();
                        lamMoiNoiDungXe();
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

        private void btnCapNhatXe_Click(object sender, EventArgs e)
        {
            if (ckCapNhatBienSo.Checked)
            {
                if (txtBienSo.Text != "" && txtBienSoCapNhat.Text != "")
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn cập nhật biển số xe này không ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (xeBUS.capNhatBienSo(txtBienSoCapNhat.Text, txtBienSo.Text))
                        {
                            MessageBox.Show("Cập nhật biển số thành công");
                            dtgvDanhSachXe.DataSource = xeBUS.xemToanBoXe();
                            lamMoiNoiDungXe();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại !");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Chưa có đủ thông tin cập nhật");
                }
            }
            else
            {
                if (txtBienSoCapNhat.Text != "" && txtHieuXe.Text != "" && txtMaChuXe.Text != "")
                {
                    // Tạo DTo
                    XeDTO xe = new XeDTO(txtBienSoCapNhat.Text, txtHieuXe.Text, cbbTenChuXe.Text, Convert.ToInt32(txtMaChuXe.Text), txtDiaChi.Text, txtDienThoai.Text, txtEmail.Text);

                    // Sửa
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn cập nhật thông tin xe này không ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (xeBUS.capNhatThongTinXe(xe))
                        {
                            MessageBox.Show("Cập nhật thành công");
                            dtgvDanhSachXe.DataSource = xeBUS.xemToanBoXe(); // refresh datagridview
                            lamMoiNoiDungXe();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại !");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Chưa có đủ thông tin cập nhật");
                }
            }
        }

        private void btnTimKiemXe_Click(object sender, EventArgs e)
        {
            if (txtTimKiemXe.Text != "")
            {
                if (cbbTimKiemXe.SelectedItem.Equals("Biển số"))
                {
                    dtgvDanhSachXe.DataSource = xeBUS.timKiemXeBangBienSo(txtTimKiemXe.Text);
                    if (dtgvDanhSachXe.Rows.Count <= 0)
                    {
                        dtgvDanhSachXe.DataSource = null;
                        MessageBox.Show("Không tìm được nội dung phù hợp");

                    }
                }

                else if (cbbTimKiemXe.SelectedItem.Equals("Hiệu xe"))
                {
                    dtgvDanhSachXe.DataSource = xeBUS.timKiemXeBangHieuXe(txtTimKiemXe.Text);
                    if (dtgvDanhSachXe.Rows.Count <= 0)
                    {
                        dtgvDanhSachXe.DataSource = null;
                        MessageBox.Show("Không tìm được nội dung phù hợp");

                    }
                }

                else if (cbbTimKiemXe.SelectedItem.Equals("Mã chủ xe"))
                {
                    CheckDigit ck = new CheckDigit();
                    if (ck.checkDigit(txtTimKiemXe.Text))
                    {
                        dtgvDanhSachXe.DataSource = xeBUS.timKiemXeBangMaChuXe(txtTimKiemXe.Text);
                        if (dtgvDanhSachXe.Rows.Count <= 0)
                        {
                            dtgvDanhSachXe.DataSource = null;
                            MessageBox.Show("Không tìm được nội dung phù hợp");

                        }
                    }
                    else
                    {
                        dtgvDanhSachXe.DataSource = null;
                        MessageBox.Show("Không tìm được nội dung phù hợp !");
                    }
                }

                else
                {
                    dtgvDanhSachXe.DataSource = xeBUS.timKiemXeBangTenChuXe(txtTimKiemXe.Text);
                    if (dtgvDanhSachXe.Rows.Count <= 0)
                    {
                        dtgvDanhSachXe.DataSource = null;
                        MessageBox.Show("Không tìm được nội dung phù hợp");

                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập thông tin tìm kiếm");
            }
        }

        private void dtgvDanhSachXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtBienSo.Text = dtgvDanhSachXe.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtBienSoCapNhat.Text = txtBienSo.Text;
                txtHieuXe.Text = dtgvDanhSachXe.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbbTenChuXe.Text = xeBUS.layMaChuXe(txtBienSo.Text).ToString() + " - " + dtgvDanhSachXe.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtMaChuXe.Text = xeBUS.layMaChuXe(txtBienSo.Text).ToString();
                txtDiaChi.Text = dtgvDanhSachXe.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDienThoai.Text = dtgvDanhSachXe.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtEmail.Text = dtgvDanhSachXe.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (ckCapNhatBienSo.Checked)
                {
                    btnThemXe.Enabled = false;
                    btnXoaXe.Enabled = false;
                    btnCapNhatXe.Enabled = true;
                   
                }
                else
                {
                    btnThemXe.Enabled = false;
                    btnXoaXe.Enabled = true;
                    btnCapNhatXe.Enabled = true;                  
                }
              
            }
        }

        private void ckCapNhatBienSo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckCapNhatBienSo.Checked)
            {
                lbBienSoCapNhat.Enabled = true;
                txtBienSoCapNhat.Enabled = true;
                txtBienSo.Enabled = false;
                txtHieuXe.Enabled = false;
                txtMaChuXe.Enabled = false;
                txtDiaChi.Enabled = false;
                txtDienThoai.Enabled = false;
                txtEmail.Enabled = false;
                cbbTenChuXe.Enabled = false;

                btnThemXe.Enabled = false;
                btnXoaXe.Enabled = false;
                btnCapNhatXe.Enabled = true;
            }
            else
            {
                lbBienSoCapNhat.Enabled = false;
                txtBienSoCapNhat.Enabled = false;
                txtBienSo.Enabled = true;
                txtHieuXe.Enabled = true;
                txtMaChuXe.Enabled = true;
                txtDiaChi.Enabled = true;
                txtDienThoai.Enabled = true;
                txtEmail.Enabled = true;
                cbbTenChuXe.Enabled = true;

                btnThemXe.Enabled = false;
                btnXoaXe.Enabled = true;
                btnCapNhatXe.Enabled = true;
            }
        }

        private void cbbTenChuXe_Click(object sender, EventArgs e)
        {
            cbbTenChuXe.DataSource = khBUS.layMaVaTenKH();
            cbbTenChuXe.DisplayMember = "Khách hàng";
            cbbTenChuXe.ValueMember = "Khách hàng";
        }

        private void cbbTenChuXe_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbTenChuXe.SelectedIndex >= 0)
            {
                string s = "";
                for (int i = 0; i < cbbTenChuXe.Text.Length; i++)
                {
                    if (char.IsDigit(cbbTenChuXe.Text[i]) == true)
                        s += cbbTenChuXe.Text[i];                  
                    else
                        break;
                }
                txtMaChuXe.Text = s;
                if (txtMaChuXe.Text != "")
                {
                    DataTable dt = khBUS.timKiemKhachHangBangID(txtMaChuXe.Text);
                    txtDiaChi.Text = dt.Rows[0][2].ToString();
                    txtDienThoai.Text = dt.Rows[0][3].ToString();
                    txtEmail.Text = dt.Rows[0][4].ToString();
                }
            }

            
        }
  
    }
}
