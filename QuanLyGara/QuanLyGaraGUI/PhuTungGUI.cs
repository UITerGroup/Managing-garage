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
    public partial class PhuTungGUI : Form
    {
        PhuTungBUS ptBUS = new PhuTungBUS();

        public PhuTungGUI()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PhuTungGUI_Load(object sender, EventArgs e)
        {
            cbbTimKiemPhuTung.SelectedIndex = 0; //Xóa bỏ Item trống đầu tiên trong cbb
            //dtgvDanhSachPhuTung.DataSource = ptBUS.xemToanBoPhuTung(); // Danh sách khách hàng
        }

        private void btnXemDanhSachKhachHang_Click(object sender, EventArgs e)
        {
            dtgvDanhSachPhuTung.DataSource = ptBUS.xemToanBoPhuTung();
        }

        private void btnThemPhuTung_Click(object sender, EventArgs e)
        {
            if (txtMaPhuTung.Text != "" && txtTenPhuTung.Text != "" && nudDonGia.Value > 0 && nudSoLuongTonKho.Value > 0)
            {
                // Tạo DTo
                PhuTungDTO pt = new PhuTungDTO(txtMaPhuTung.Text, txtTenPhuTung.Text, (int)nudDonGia.Value, (int)nudSoLuongTonKho.Value);

                // Them
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm phụ tùng này không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (ptBUS.themPhuTung(pt))
                    {
                        MessageBox.Show("Thêm thành công");
                        dtgvDanhSachPhuTung.DataSource = ptBUS.xemToanBoPhuTung(); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại vì đã có phụ tùng này trong hệ thống !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa có đủ thông tin để thêm ");
            }
        }

        private void btnTimKiemPhuTung_Click(object sender, EventArgs e)
        {
            if (txtTimKiemPhuTung.Text != "")
            {
                if (cbbTimKiemPhuTung.SelectedItem.Equals("Mã phụ tùng"))
                {
                    dtgvDanhSachPhuTung.DataSource = ptBUS.timKiemPhuTungBangID(txtTimKiemPhuTung.Text);
                    if (dtgvDanhSachPhuTung.Rows.Count <= 0)
                    {
                        dtgvDanhSachPhuTung.DataSource = null;
                        MessageBox.Show("Không tìm được nội dung phù hợp");
                       
                    }
                }

                if (cbbTimKiemPhuTung.SelectedItem.Equals("Tên phụ tùng"))
                {
                    dtgvDanhSachPhuTung.DataSource = ptBUS.timKiemPhuTungBangTen(txtTimKiemPhuTung.Text);
                    if (dtgvDanhSachPhuTung.Rows.Count <= 0)
                    {
                        dtgvDanhSachPhuTung.DataSource = null;
                        MessageBox.Show("Không tìm được nội dung phù hợp");
                       
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập thông tin tìm kiếm");
            }
        }

        private void dtgvDanhSachPhuTung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaPhuTung.Text = dtgvDanhSachPhuTung.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMaPhuTungCapNhat.Text = txtMaPhuTung.Text;
                txtTenPhuTung.Text = dtgvDanhSachPhuTung.Rows[e.RowIndex].Cells[1].Value.ToString();
                nudDonGia.Value = Convert.ToInt32(dtgvDanhSachPhuTung.Rows[e.RowIndex].Cells[2].Value.ToString()) ;
                nudSoLuongTonKho.Value = Convert.ToInt32(dtgvDanhSachPhuTung.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
        }

        private void btnLamMoiPhuTung_Click(object sender, EventArgs e)
        {
            lamMoiNoiDungPhuTung();
        }

        private void btnXoaPhuTung_Click(object sender, EventArgs e)
        {
            if (txtMaPhuTungCapNhat.Text != "")
            {
                string thongbao = "Bạn có chắc muốn xóa phụ tùng " + txtMaPhuTungCapNhat.Text + " ?";
                DialogResult dialogResult = MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (ptBUS.xoaPhuTung(txtMaPhuTungCapNhat.Text))
                    {
                        MessageBox.Show("Xóa thành công");
                        dtgvDanhSachPhuTung.DataSource = ptBUS.xemToanBoPhuTung();
                        lamMoiNoiDungPhuTung();
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

        private void btnCapNhatPhuTung_Click(object sender, EventArgs e)
        {
            if (ckCapNhatMaPhuTung.Checked)
            {
                if (txtMaPhuTung.Text != "" && txtMaPhuTungCapNhat.Text != "")
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn cập nhật mã phụ tùng này không ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (ptBUS.capNhatMaPhuTung(txtMaPhuTungCapNhat.Text, txtMaPhuTung.Text))
                        {
                            MessageBox.Show("Cập nhật mã phụ tùng thành công");
                            dtgvDanhSachPhuTung.DataSource = ptBUS.xemToanBoPhuTung();
                            lamMoiNoiDungPhuTung();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại vì đã có mã phụ tùng này trong hệ thống");
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
                if (txtMaPhuTungCapNhat.Text != "" && txtTenPhuTung.Text != "" && nudDonGia.Value > 0 && nudSoLuongTonKho.Value > 0)
                {
                    // Tạo DTo
                    PhuTungDTO pt = new PhuTungDTO(txtMaPhuTungCapNhat.Text, txtTenPhuTung.Text, (int)nudDonGia.Value, (int)nudSoLuongTonKho.Value);

                    // Sửa
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn cập nhật thông tin phụ tùng này không ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (ptBUS.capNhatThongTinPhuTung(pt))
                        {
                            MessageBox.Show("Cập nhật thành công");
                            dtgvDanhSachPhuTung.DataSource = ptBUS.xemToanBoPhuTung(); // refresh datagridview
                            lamMoiNoiDungPhuTung();
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

        private void nudDonGia_Validating(object sender, CancelEventArgs e)
        {
            if (nudDonGia.Text == "")
            {
                nudDonGia.Value = 0;
            }
        }

        private void nudSoLuongTonKho_Validating(object sender, CancelEventArgs e)
        {
            if (nudSoLuongTonKho.Text == "")
            {
                nudSoLuongTonKho.Value = 0;
            }
        }

        private void lamMoiNoiDungPhuTung()
        {
            txtMaPhuTung.Text = "";
            txtMaPhuTungCapNhat.Text = "";
            txtTenPhuTung.Text = "";
            nudDonGia.Value = 0;
            nudSoLuongTonKho.Value = 0;
        }

        private void ckCapNhatMaPhuTung_CheckedChanged(object sender, EventArgs e)
        {
            if (ckCapNhatMaPhuTung.Checked)
            {
                txtMaPhuTung.Enabled = false;
                lbMaPhuTungCapNhat.Enabled = true;
                txtMaPhuTungCapNhat.Enabled = true;
                txtTenPhuTung.Enabled = false;
                nudDonGia.Enabled = false;
                nudSoLuongTonKho.Enabled = false;
                btnXoaPhuTung.Enabled = false;
                btnThemPhuTung.Enabled = false;
            }
            else
            {
                txtMaPhuTung.Enabled = true;
                lbMaPhuTungCapNhat.Enabled = false;
                txtMaPhuTungCapNhat.Enabled = false;
                txtTenPhuTung.Enabled = true;
                nudDonGia.Enabled = true;
                nudSoLuongTonKho.Enabled = true;
                btnXoaPhuTung.Enabled = true;
                btnThemPhuTung.Enabled = true;
                txtMaPhuTungCapNhat.Text = txtMaPhuTung.Text;
            }
        }
    }
}
