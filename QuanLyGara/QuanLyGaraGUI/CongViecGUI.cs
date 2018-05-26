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
    public partial class CongViecGUI : Form
    {
        CongViecBUS cvBUS = new CongViecBUS();

        public CongViecGUI()
        {
            InitializeComponent();
        }

        private void CongViecGUI_Load(object sender, EventArgs e)
        {
            cbbTimKiemCongViec.SelectedIndex = 0; 
            dtgvDanhSachCongViec.DataSource = cvBUS.xemToanBoCongViec();

            btnThemCongViec.Enabled = true;
            btnXoaCongViec.Enabled = false;
            btnCapNhatCongViec.Enabled = false;
        }

        private void lamMoiNoiDungCongViec()
        {
            txtMaCongViec.Text = "";
            txtMaCongViecCapNhat.Text = "";
            txtNoiDungCongViec.Text = "";
            nudTienCong.Value = 0;

            btnThemCongViec.Enabled = true;
            btnXoaCongViec.Enabled = false;
            btnCapNhatCongViec.Enabled = false;
        }

        private void btnLamMoiCongViec_Click(object sender, EventArgs e)
        {
            lamMoiNoiDungCongViec();
        }

        private void btnXemDanhSachCongViec_Click(object sender, EventArgs e)
        {
            dtgvDanhSachCongViec.DataSource = cvBUS.xemToanBoCongViec();
        }

        private void btnThemCongViec_Click(object sender, EventArgs e)
        {
            if (txtMaCongViec.Text != "" && txtNoiDungCongViec.Text != "" && nudTienCong.Value > 0)
            {
                // Tạo DTo
                CongViecDTO cv = new CongViecDTO(txtMaCongViec.Text, txtNoiDungCongViec.Text, (int)nudTienCong.Value);

                // Them
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm công việc này không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (cvBUS.themCongViec(cv))
                    {
                        MessageBox.Show("Thêm thành công");
                        dtgvDanhSachCongViec.DataSource = cvBUS.xemToanBoCongViec(); // refresh datagridview
                        lamMoiNoiDungCongViec();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại vì đã có công việc này trong hệ thống !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa có đủ thông tin để thêm !");
            }
        }

        private void btnXoaCongViec_Click(object sender, EventArgs e)
        {
            if (txtMaCongViecCapNhat.Text != "")
            {
                string thongbao = "Bạn có chắc muốn xóa công việc " + txtMaCongViecCapNhat.Text + " ?";
                DialogResult dialogResult = MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (cvBUS.xoaCongViec(txtMaCongViecCapNhat.Text))
                    {
                        MessageBox.Show("Xóa thành công");
                        dtgvDanhSachCongViec.DataSource = cvBUS.xemToanBoCongViec();
                        lamMoiNoiDungCongViec();
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

        private void btnCapNhatCongViec_Click(object sender, EventArgs e)
        {
            if (ckCapNhatMaCongViec.Checked)
            {
                if (txtMaCongViec.Text != "" && txtMaCongViecCapNhat.Text != "")
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn cập nhật mã công việc này không ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (cvBUS.capNhatMaCongViec(txtMaCongViecCapNhat.Text, txtMaCongViec.Text))
                        {
                            MessageBox.Show("Cập nhật mã phụ tùng thành công");
                            dtgvDanhSachCongViec.DataSource = cvBUS.xemToanBoCongViec();
                            lamMoiNoiDungCongViec();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại vì đã có  mã công việc này trong hệ thống !!");
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
                if (txtMaCongViec.Text != "" && txtNoiDungCongViec.Text != "" && nudTienCong.Value > 0)
                {
                    // Tạo DTo
                    CongViecDTO cv = new CongViecDTO(txtMaCongViec.Text, txtNoiDungCongViec.Text, (int)nudTienCong.Value);

                    // Sửa
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn cập nhật thông tin công việc này không ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (cvBUS.capNhatThongTinCongViec(cv))
                        {
                            MessageBox.Show("Cập nhật thành công");
                            dtgvDanhSachCongViec.DataSource = cvBUS.xemToanBoCongViec(); // refresh datagridview
                            lamMoiNoiDungCongViec();
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

        private void btnTimKiemCongViec_Click(object sender, EventArgs e)
        {
            if (txtTimKiemCongViec.Text != "")
            {
                if (cbbTimKiemCongViec.SelectedItem.Equals("Mã công việc"))
                {
                    dtgvDanhSachCongViec.DataSource = cvBUS.timKiemCongViecBangID(txtTimKiemCongViec.Text);
                    if (dtgvDanhSachCongViec.Rows.Count <= 0)
                    {
                        dtgvDanhSachCongViec.DataSource = null;
                        MessageBox.Show("Không tìm được nội dung phù hợp");
                    }
                }

                if (cbbTimKiemCongViec.SelectedItem.Equals("Nội dung công việc"))
                {
                    dtgvDanhSachCongViec.DataSource = cvBUS.timKiemCongViecBangTen(txtTimKiemCongViec.Text);
                    if (dtgvDanhSachCongViec.Rows.Count <= 0)
                    {
                        dtgvDanhSachCongViec.DataSource = null;
                        MessageBox.Show("Không tìm được nội dung phù hợp");

                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập thông tin tìm kiếm");
            }
        }

        private void dtgvDanhSachCongViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaCongViec.Text = dtgvDanhSachCongViec.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMaCongViecCapNhat.Text = txtMaCongViec.Text;
                txtNoiDungCongViec.Text = dtgvDanhSachCongViec.Rows[e.RowIndex].Cells[1].Value.ToString();
                nudTienCong.Value = Convert.ToInt32(dtgvDanhSachCongViec.Rows[e.RowIndex].Cells[2].Value.ToString());
                if (ckCapNhatMaCongViec.Checked)
                {
                    btnThemCongViec.Enabled = false;
                    btnXoaCongViec.Enabled = false;
                    btnCapNhatCongViec.Enabled = true;
                }
                else
                {
                    btnThemCongViec.Enabled = false;
                    btnXoaCongViec.Enabled = true;
                    btnCapNhatCongViec.Enabled = true;
                }
            }
        }

        private void ckCapNhatMaCongViec_CheckedChanged(object sender, EventArgs e)
        {
            if (ckCapNhatMaCongViec.Checked)
            {
                txtMaCongViec.Enabled = false;
                lbMaCongViecCapNhat.Enabled = true;
                txtMaCongViecCapNhat.Enabled = true;
                txtNoiDungCongViec.Enabled = false;
                nudTienCong.Enabled = false;

                btnThemCongViec.Enabled = false;
                btnXoaCongViec.Enabled = false;
                btnCapNhatCongViec.Enabled = true;
            }
            else
            {
                txtMaCongViec.Enabled = true;
                lbMaCongViecCapNhat.Enabled = false;
                txtMaCongViecCapNhat.Enabled = false;
                txtNoiDungCongViec.Enabled = true;
                nudTienCong.Enabled = true;

                btnThemCongViec.Enabled = false;
                btnXoaCongViec.Enabled = true;
                btnCapNhatCongViec.Enabled = true;

                txtMaCongViecCapNhat.Text = txtMaCongViec.Text;
            }
        }

        private void nudTienCong_Validating(object sender, CancelEventArgs e)
        {
            if (nudTienCong.Text == "")
            {
                nudTienCong.Value = 0;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
