using QuanLyGaraBUS;
using QuanLyGaraDTO;
using System;
using System.Windows.Forms;

namespace QuanLyGaraGUI
{
    public partial class KhachHangGUI : Form
    {
        KhachHangBUS khBUS = new KhachHangBUS();
        public KhachHangGUI()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void KhachHangGUI_Load(object sender, EventArgs e)
        {
            cbbTimKiemKhachHang.SelectedIndex = 0; //Xóa bỏ Item trống đầu tiên trong cbb
            dtgvDanhSachKhachHang.DataSource = khBUS.xemToanBoKhachHang(); // Danh sách khách hàng
            btnCapNhatKhachHang.Enabled = false;
        }

        private void btnXemDanhSachKhachHang_Click(object sender, EventArgs e)
        {
            dtgvDanhSachKhachHang.DataSource = khBUS.xemToanBoKhachHang();
        }

        private void lamMoiNoiDungKhachHang()
        {
            txtMaKhachHang.Text = "";
            txtTenKhachHang.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            btnThemKhachHang.Enabled = true;
            btnCapNhatKhachHang.Enabled = false;
        }

        private void btnLamMoiKhachHang_Click(object sender, EventArgs e)
        {
            lamMoiNoiDungKhachHang();
            
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text != "")
            {
                MessageBox.Show("Không thể thêm vì đã có khách hàng này trong hệ thống !");
            }
            else if (txtTenKhachHang.Text != "" && txtDiaChi.Text != "" && txtDienThoai.Text != "" && txtEmail.Text != "")
            {
                // Tạo DTo
                KhachHangDTO kh = new KhachHangDTO(0, txtTenKhachHang.Text, txtDiaChi.Text, txtDienThoai.Text, txtEmail.Text); // Vì ID tự tăng nên để ID số gì cũng dc

                // Them

                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm khách hàng này không ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (khBUS.themKhachHang(kh))
                        {
                            MessageBox.Show("Thêm thành công");
                            dtgvDanhSachKhachHang.DataSource = khBUS.xemToanBoKhachHang(); // refresh datagridview
                            lamMoiNoiDungKhachHang();
                        }
                        else
                        {
                            MessageBox.Show("Thêm ko thành công");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }

        }

        private void btnCapNhatKhachHang_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text == "")
            {
                MessageBox.Show("Hãy chọn khách hàng muốn cập nhật !");
            }
            else if (txtTenKhachHang.Text != "" && txtDiaChi.Text != "" && txtDienThoai.Text != "" && txtEmail.Text != "")
            {
                int ID = Convert.ToInt16(txtMaKhachHang.Text);

                // Tạo DTo
                KhachHangDTO kh = new KhachHangDTO(ID, txtTenKhachHang.Text, txtDiaChi.Text, txtDienThoai.Text, txtEmail.Text); // Vì ID tự tăng nên để ID số gì cũng dc

                // Sửa
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn cập nhật khách hàng này không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (khBUS.capNhatKhachHang(kh))
                    {
                        MessageBox.Show("Cập nhật thành công");
                        dtgvDanhSachKhachHang.DataSource = khBUS.xemToanBoKhachHang(); // refresh datagridview
                        lamMoiNoiDungKhachHang();
                    }
                    else
                    {
                        MessageBox.Show("Sửa ko thành công");
                    }
                }              
            }
            else
            {
                MessageBox.Show("Chưa có đủ thông tin để cập nhật");
            }
        }

        private void btnTimKiemKhachHang_Click(object sender, EventArgs e)
        {
            if (txtTimKiemKhachHang.Text != "")
            {
                if (cbbTimKiemKhachHang.SelectedItem.Equals("Mã khách hàng"))
                {
                    CheckDigit ck = new CheckDigit();
                    if (ck.checkDigit(txtTimKiemKhachHang.Text))
                    {
                        dtgvDanhSachKhachHang.DataSource = khBUS.timKiemKhachHangBangID(txtTimKiemKhachHang.Text);
                        if (dtgvDanhSachKhachHang.Rows.Count <= 0)
                        {
                            dtgvDanhSachKhachHang.DataSource = null;
                            MessageBox.Show("Không tìm được nội dung phù hợp");

                        }
                    }
                    else
                    {
                        dtgvDanhSachKhachHang.DataSource = null;
                        MessageBox.Show("Không tìm được nội dung phù hợp !");
                        
                    }
                }
                if (cbbTimKiemKhachHang.SelectedItem.Equals("Tên khách hàng"))
                {
                    dtgvDanhSachKhachHang.DataSource = khBUS.timKiemKhachHangBangTen(txtTimKiemKhachHang.Text);
                    if (dtgvDanhSachKhachHang.Rows.Count <= 0)
                    {
                        dtgvDanhSachKhachHang.DataSource = null;
                        MessageBox.Show("Không tìm được nội dung phù hợp !");
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập thông tin tìm kiếm");
            }    
        }

        private void dtgvDanhSachKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaKhachHang.Text = dtgvDanhSachKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenKhachHang.Text = dtgvDanhSachKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDiaChi.Text = dtgvDanhSachKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDienThoai.Text = dtgvDanhSachKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEmail.Text = dtgvDanhSachKhachHang.Rows[e.RowIndex].Cells[4].Value.ToString();

                btnThemKhachHang.Enabled = false;
                btnCapNhatKhachHang.Enabled = true;
            }
        }

  
    }
}
