namespace QuanLyGaraGUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnPhieuSuaChua = new System.Windows.Forms.Button();
            this.btnCongViec = new System.Windows.Forms.Button();
            this.btnXe = new System.Windows.Forms.Button();
            this.btnPhuTung = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXemDanhSachPhieuNhan = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpkDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lbDenNgay = new System.Windows.Forms.Label();
            this.lbTuNgay = new System.Windows.Forms.Label();
            this.cbbTimKiemPhieuNhan = new System.Windows.Forms.ComboBox();
            this.dtpkTuNgay = new System.Windows.Forms.DateTimePicker();
            this.btnTimKiemPhieuNhan = new System.Windows.Forms.Button();
            this.txtTimKiemPhieuNhan = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpkNgayTiepNhan = new System.Windows.Forms.DateTimePicker();
            this.txtMaPhieuNhan = new System.Windows.Forms.TextBox();
            this.lbMaPhieuNhan = new System.Windows.Forms.Label();
            this.btnKiemTraBienSo = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbNgayTiepNhan = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lbDienThoai = new System.Windows.Forms.Label();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.lbBienSo = new System.Windows.Forms.Label();
            this.txtHieuXe = new System.Windows.Forms.TextBox();
            this.lbHieuXe = new System.Windows.Forms.Label();
            this.txtTenChuXe = new System.Windows.Forms.TextBox();
            this.lbTenChuXe = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtgvDanhSachPhieuNhan = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnThemPhieuNhan = new System.Windows.Forms.Button();
            this.btnXoaPhieuNhan = new System.Windows.Forms.Button();
            this.btnLamMoiPhieuNhan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachPhieuNhan)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBaoCao);
            this.groupBox1.Controls.Add(this.btnPhieuSuaChua);
            this.groupBox1.Controls.Add(this.btnCongViec);
            this.groupBox1.Controls.Add(this.btnXe);
            this.groupBox1.Controls.Add(this.btnPhuTung);
            this.groupBox1.Controls.Add(this.btnKhachHang);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 373);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý";
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("btnBaoCao.Image")));
            this.btnBaoCao.Location = new System.Drawing.Point(112, 254);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(104, 104);
            this.btnBaoCao.TabIndex = 20;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBaoCao.UseVisualStyleBackColor = false;
            // 
            // btnPhieuSuaChua
            // 
            this.btnPhieuSuaChua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPhieuSuaChua.Image = ((System.Drawing.Image)(resources.GetObject("btnPhieuSuaChua.Image")));
            this.btnPhieuSuaChua.Location = new System.Drawing.Point(6, 254);
            this.btnPhieuSuaChua.Name = "btnPhieuSuaChua";
            this.btnPhieuSuaChua.Size = new System.Drawing.Size(100, 104);
            this.btnPhieuSuaChua.TabIndex = 19;
            this.btnPhieuSuaChua.Text = "Phiếu sửa chữa";
            this.btnPhieuSuaChua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPhieuSuaChua.UseVisualStyleBackColor = false;
            this.btnPhieuSuaChua.Click += new System.EventHandler(this.btnPhieuSuaChua_Click);
            // 
            // btnCongViec
            // 
            this.btnCongViec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCongViec.Image = ((System.Drawing.Image)(resources.GetObject("btnCongViec.Image")));
            this.btnCongViec.Location = new System.Drawing.Point(112, 139);
            this.btnCongViec.Name = "btnCongViec";
            this.btnCongViec.Size = new System.Drawing.Size(104, 109);
            this.btnCongViec.TabIndex = 18;
            this.btnCongViec.Text = "Công việc";
            this.btnCongViec.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCongViec.UseVisualStyleBackColor = false;
            this.btnCongViec.Click += new System.EventHandler(this.btnCongViec_Click);
            // 
            // btnXe
            // 
            this.btnXe.AutoSize = true;
            this.btnXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnXe.Image = ((System.Drawing.Image)(resources.GetObject("btnXe.Image")));
            this.btnXe.Location = new System.Drawing.Point(112, 19);
            this.btnXe.Name = "btnXe";
            this.btnXe.Size = new System.Drawing.Size(104, 114);
            this.btnXe.TabIndex = 16;
            this.btnXe.Text = "Xe";
            this.btnXe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXe.UseVisualStyleBackColor = false;
            this.btnXe.Click += new System.EventHandler(this.btnXe_Click);
            // 
            // btnPhuTung
            // 
            this.btnPhuTung.AutoSize = true;
            this.btnPhuTung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPhuTung.Image = ((System.Drawing.Image)(resources.GetObject("btnPhuTung.Image")));
            this.btnPhuTung.Location = new System.Drawing.Point(6, 139);
            this.btnPhuTung.Name = "btnPhuTung";
            this.btnPhuTung.Size = new System.Drawing.Size(100, 109);
            this.btnPhuTung.TabIndex = 17;
            this.btnPhuTung.Text = "Phụ tùng";
            this.btnPhuTung.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPhuTung.UseVisualStyleBackColor = false;
            this.btnPhuTung.Click += new System.EventHandler(this.btnPhuTung_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.Image")));
            this.btnKhachHang.Location = new System.Drawing.Point(6, 19);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(100, 114);
            this.btnKhachHang.TabIndex = 15;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(84, 419);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(73, 33);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXemDanhSachPhieuNhan);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Location = new System.Drawing.Point(242, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(927, 450);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiếp nhận sửa chữa";
            // 
            // btnXemDanhSachPhieuNhan
            // 
            this.btnXemDanhSachPhieuNhan.AutoSize = true;
            this.btnXemDanhSachPhieuNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnXemDanhSachPhieuNhan.Image")));
            this.btnXemDanhSachPhieuNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemDanhSachPhieuNhan.Location = new System.Drawing.Point(63, 413);
            this.btnXemDanhSachPhieuNhan.Name = "btnXemDanhSachPhieuNhan";
            this.btnXemDanhSachPhieuNhan.Size = new System.Drawing.Size(175, 30);
            this.btnXemDanhSachPhieuNhan.TabIndex = 24;
            this.btnXemDanhSachPhieuNhan.Text = "Xem danh sách phiếu nhận";
            this.btnXemDanhSachPhieuNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemDanhSachPhieuNhan.UseVisualStyleBackColor = true;
            this.btnXemDanhSachPhieuNhan.Click += new System.EventHandler(this.btnXemDanhSachPhieuNhan_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpkDenNgay);
            this.groupBox3.Controls.Add(this.lbDenNgay);
            this.groupBox3.Controls.Add(this.lbTuNgay);
            this.groupBox3.Controls.Add(this.cbbTimKiemPhieuNhan);
            this.groupBox3.Controls.Add(this.dtpkTuNgay);
            this.groupBox3.Controls.Add(this.btnTimKiemPhieuNhan);
            this.groupBox3.Controls.Add(this.txtTimKiemPhieuNhan);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(914, 78);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // dtpkDenNgay
            // 
            this.dtpkDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDenNgay.Location = new System.Drawing.Point(590, 46);
            this.dtpkDenNgay.Name = "dtpkDenNgay";
            this.dtpkDenNgay.Size = new System.Drawing.Size(102, 20);
            this.dtpkDenNgay.TabIndex = 27;
            this.dtpkDenNgay.Visible = false;
            // 
            // lbDenNgay
            // 
            this.lbDenNgay.AutoSize = true;
            this.lbDenNgay.Location = new System.Drawing.Point(528, 52);
            this.lbDenNgay.Name = "lbDenNgay";
            this.lbDenNgay.Size = new System.Drawing.Size(56, 13);
            this.lbDenNgay.TabIndex = 26;
            this.lbDenNgay.Text = "Đến ngày:";
            this.lbDenNgay.Visible = false;
            // 
            // lbTuNgay
            // 
            this.lbTuNgay.AutoSize = true;
            this.lbTuNgay.Location = new System.Drawing.Point(297, 52);
            this.lbTuNgay.Name = "lbTuNgay";
            this.lbTuNgay.Size = new System.Drawing.Size(49, 13);
            this.lbTuNgay.TabIndex = 25;
            this.lbTuNgay.Text = "Từ ngày:";
            this.lbTuNgay.Visible = false;
            // 
            // cbbTimKiemPhieuNhan
            // 
            this.cbbTimKiemPhieuNhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimKiemPhieuNhan.FormattingEnabled = true;
            this.cbbTimKiemPhieuNhan.Items.AddRange(new object[] {
            "Mã phiếu tiếp nhận",
            "Biển số",
            "Hiệu xe",
            "Tên chủ xe",
            "Ngày tiếp nhận"});
            this.cbbTimKiemPhieuNhan.Location = new System.Drawing.Point(78, 20);
            this.cbbTimKiemPhieuNhan.Name = "cbbTimKiemPhieuNhan";
            this.cbbTimKiemPhieuNhan.Size = new System.Drawing.Size(121, 21);
            this.cbbTimKiemPhieuNhan.TabIndex = 9;
            this.cbbTimKiemPhieuNhan.SelectedValueChanged += new System.EventHandler(this.cbbTimKiemPhieuNhan_SelectedValueChanged);
            // 
            // dtpkTuNgay
            // 
            this.dtpkTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkTuNgay.Location = new System.Drawing.Point(352, 46);
            this.dtpkTuNgay.Name = "dtpkTuNgay";
            this.dtpkTuNgay.Size = new System.Drawing.Size(104, 20);
            this.dtpkTuNgay.TabIndex = 8;
            this.dtpkTuNgay.Visible = false;
            // 
            // btnTimKiemPhieuNhan
            // 
            this.btnTimKiemPhieuNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemPhieuNhan.Image")));
            this.btnTimKiemPhieuNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemPhieuNhan.Location = new System.Drawing.Point(777, 15);
            this.btnTimKiemPhieuNhan.Name = "btnTimKiemPhieuNhan";
            this.btnTimKiemPhieuNhan.Size = new System.Drawing.Size(80, 28);
            this.btnTimKiemPhieuNhan.TabIndex = 7;
            this.btnTimKiemPhieuNhan.Text = "Tìm kiếm";
            this.btnTimKiemPhieuNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemPhieuNhan.UseVisualStyleBackColor = true;
            this.btnTimKiemPhieuNhan.Click += new System.EventHandler(this.btnTimKiemPhieuNhan_Click);
            // 
            // txtTimKiemPhieuNhan
            // 
            this.txtTimKiemPhieuNhan.Location = new System.Drawing.Point(205, 20);
            this.txtTimKiemPhieuNhan.Name = "txtTimKiemPhieuNhan";
            this.txtTimKiemPhieuNhan.Size = new System.Drawing.Size(566, 20);
            this.txtTimKiemPhieuNhan.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpkNgayTiepNhan);
            this.groupBox4.Controls.Add(this.txtMaPhieuNhan);
            this.groupBox4.Controls.Add(this.lbMaPhieuNhan);
            this.groupBox4.Controls.Add(this.btnKiemTraBienSo);
            this.groupBox4.Controls.Add(this.txtDiaChi);
            this.groupBox4.Controls.Add(this.lbDiaChi);
            this.groupBox4.Controls.Add(this.lbNgayTiepNhan);
            this.groupBox4.Controls.Add(this.txtDienThoai);
            this.groupBox4.Controls.Add(this.lbDienThoai);
            this.groupBox4.Controls.Add(this.txtBienSo);
            this.groupBox4.Controls.Add(this.lbBienSo);
            this.groupBox4.Controls.Add(this.txtHieuXe);
            this.groupBox4.Controls.Add(this.lbHieuXe);
            this.groupBox4.Controls.Add(this.txtTenChuXe);
            this.groupBox4.Controls.Add(this.lbTenChuXe);
            this.groupBox4.Location = new System.Drawing.Point(6, 103);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(278, 236);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin tiếp nhận";
            // 
            // dtpkNgayTiepNhan
            // 
            this.dtpkNgayTiepNhan.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpkNgayTiepNhan.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpkNgayTiepNhan.Enabled = false;
            this.dtpkNgayTiepNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgayTiepNhan.Location = new System.Drawing.Point(97, 205);
            this.dtpkNgayTiepNhan.Name = "dtpkNgayTiepNhan";
            this.dtpkNgayTiepNhan.Size = new System.Drawing.Size(95, 20);
            this.dtpkNgayTiepNhan.TabIndex = 25;
            // 
            // txtMaPhieuNhan
            // 
            this.txtMaPhieuNhan.Location = new System.Drawing.Point(97, 22);
            this.txtMaPhieuNhan.Name = "txtMaPhieuNhan";
            this.txtMaPhieuNhan.ReadOnly = true;
            this.txtMaPhieuNhan.Size = new System.Drawing.Size(95, 20);
            this.txtMaPhieuNhan.TabIndex = 23;
            // 
            // lbMaPhieuNhan
            // 
            this.lbMaPhieuNhan.AutoSize = true;
            this.lbMaPhieuNhan.Location = new System.Drawing.Point(6, 25);
            this.lbMaPhieuNhan.Name = "lbMaPhieuNhan";
            this.lbMaPhieuNhan.Size = new System.Drawing.Size(54, 13);
            this.lbMaPhieuNhan.TabIndex = 24;
            this.lbMaPhieuNhan.Text = "Mã phiếu:";
            // 
            // btnKiemTraBienSo
            // 
            this.btnKiemTraBienSo.Image = ((System.Drawing.Image)(resources.GetObject("btnKiemTraBienSo.Image")));
            this.btnKiemTraBienSo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKiemTraBienSo.Location = new System.Drawing.Point(198, 42);
            this.btnKiemTraBienSo.Name = "btnKiemTraBienSo";
            this.btnKiemTraBienSo.Size = new System.Drawing.Size(74, 30);
            this.btnKiemTraBienSo.TabIndex = 4;
            this.btnKiemTraBienSo.Text = "Kiểm tra";
            this.btnKiemTraBienSo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKiemTraBienSo.UseVisualStyleBackColor = true;
            this.btnKiemTraBienSo.Click += new System.EventHandler(this.btnKiemTraBienSo_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(97, 126);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDiaChi.Size = new System.Drawing.Size(175, 44);
            this.txtDiaChi.TabIndex = 7;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(6, 139);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(43, 13);
            this.lbDiaChi.TabIndex = 22;
            this.lbDiaChi.Text = "Địa chỉ:";
            // 
            // lbNgayTiepNhan
            // 
            this.lbNgayTiepNhan.AutoSize = true;
            this.lbNgayTiepNhan.Location = new System.Drawing.Point(6, 205);
            this.lbNgayTiepNhan.Name = "lbNgayTiepNhan";
            this.lbNgayTiepNhan.Size = new System.Drawing.Size(82, 13);
            this.lbNgayTiepNhan.TabIndex = 20;
            this.lbNgayTiepNhan.Text = "Ngày tiếp nhận:";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(97, 176);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.ReadOnly = true;
            this.txtDienThoai.Size = new System.Drawing.Size(95, 20);
            this.txtDienThoai.TabIndex = 8;
            // 
            // lbDienThoai
            // 
            this.lbDienThoai.AutoSize = true;
            this.lbDienThoai.Location = new System.Drawing.Point(6, 179);
            this.lbDienThoai.Name = "lbDienThoai";
            this.lbDienThoai.Size = new System.Drawing.Size(58, 13);
            this.lbDienThoai.TabIndex = 18;
            this.lbDienThoai.Text = "Điện thoại:";
            // 
            // txtBienSo
            // 
            this.txtBienSo.Location = new System.Drawing.Point(97, 48);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(95, 20);
            this.txtBienSo.TabIndex = 3;
            // 
            // lbBienSo
            // 
            this.lbBienSo.AutoSize = true;
            this.lbBienSo.Location = new System.Drawing.Point(6, 51);
            this.lbBienSo.Name = "lbBienSo";
            this.lbBienSo.Size = new System.Drawing.Size(45, 13);
            this.lbBienSo.TabIndex = 16;
            this.lbBienSo.Text = "Biển số:";
            // 
            // txtHieuXe
            // 
            this.txtHieuXe.Location = new System.Drawing.Point(97, 74);
            this.txtHieuXe.Name = "txtHieuXe";
            this.txtHieuXe.ReadOnly = true;
            this.txtHieuXe.Size = new System.Drawing.Size(95, 20);
            this.txtHieuXe.TabIndex = 5;
            // 
            // lbHieuXe
            // 
            this.lbHieuXe.AutoSize = true;
            this.lbHieuXe.Location = new System.Drawing.Point(6, 77);
            this.lbHieuXe.Name = "lbHieuXe";
            this.lbHieuXe.Size = new System.Drawing.Size(46, 13);
            this.lbHieuXe.TabIndex = 12;
            this.lbHieuXe.Text = "Hiệu xe:";
            // 
            // txtTenChuXe
            // 
            this.txtTenChuXe.Location = new System.Drawing.Point(97, 100);
            this.txtTenChuXe.Name = "txtTenChuXe";
            this.txtTenChuXe.ReadOnly = true;
            this.txtTenChuXe.Size = new System.Drawing.Size(175, 20);
            this.txtTenChuXe.TabIndex = 6;
            // 
            // lbTenChuXe
            // 
            this.lbTenChuXe.AutoSize = true;
            this.lbTenChuXe.Location = new System.Drawing.Point(6, 103);
            this.lbTenChuXe.Name = "lbTenChuXe";
            this.lbTenChuXe.Size = new System.Drawing.Size(64, 13);
            this.lbTenChuXe.TabIndex = 10;
            this.lbTenChuXe.Text = "Tên chủ xe:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtgvDanhSachPhieuNhan);
            this.groupBox5.Location = new System.Drawing.Point(290, 103);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(630, 340);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách phiếu tiếp nhận sửa chữa";
            // 
            // dtgvDanhSachPhieuNhan
            // 
            this.dtgvDanhSachPhieuNhan.AllowUserToAddRows = false;
            this.dtgvDanhSachPhieuNhan.AllowUserToResizeColumns = false;
            this.dtgvDanhSachPhieuNhan.AllowUserToResizeRows = false;
            this.dtgvDanhSachPhieuNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDanhSachPhieuNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachPhieuNhan.Location = new System.Drawing.Point(6, 19);
            this.dtgvDanhSachPhieuNhan.Name = "dtgvDanhSachPhieuNhan";
            this.dtgvDanhSachPhieuNhan.RowHeadersVisible = false;
            this.dtgvDanhSachPhieuNhan.Size = new System.Drawing.Size(613, 315);
            this.dtgvDanhSachPhieuNhan.TabIndex = 0;
            this.dtgvDanhSachPhieuNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSachPhieuNhan_CellClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnThemPhieuNhan);
            this.groupBox6.Controls.Add(this.btnXoaPhieuNhan);
            this.groupBox6.Controls.Add(this.btnLamMoiPhieuNhan);
            this.groupBox6.Location = new System.Drawing.Point(6, 345);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(278, 62);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thao tác";
            // 
            // btnThemPhieuNhan
            // 
            this.btnThemPhieuNhan.AutoSize = true;
            this.btnThemPhieuNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnThemPhieuNhan.Image")));
            this.btnThemPhieuNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemPhieuNhan.Location = new System.Drawing.Point(203, 20);
            this.btnThemPhieuNhan.Name = "btnThemPhieuNhan";
            this.btnThemPhieuNhan.Size = new System.Drawing.Size(69, 31);
            this.btnThemPhieuNhan.TabIndex = 12;
            this.btnThemPhieuNhan.Text = "Thêm";
            this.btnThemPhieuNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemPhieuNhan.UseVisualStyleBackColor = true;
            this.btnThemPhieuNhan.Click += new System.EventHandler(this.btnThemPhieuNhan_Click);
            // 
            // btnXoaPhieuNhan
            // 
            this.btnXoaPhieuNhan.AutoSize = true;
            this.btnXoaPhieuNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaPhieuNhan.Image")));
            this.btnXoaPhieuNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaPhieuNhan.Location = new System.Drawing.Point(114, 20);
            this.btnXoaPhieuNhan.Name = "btnXoaPhieuNhan";
            this.btnXoaPhieuNhan.Size = new System.Drawing.Size(63, 30);
            this.btnXoaPhieuNhan.TabIndex = 13;
            this.btnXoaPhieuNhan.Text = "Xóa";
            this.btnXoaPhieuNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaPhieuNhan.UseVisualStyleBackColor = true;
            this.btnXoaPhieuNhan.Click += new System.EventHandler(this.btnXoaPhieuNhan_Click);
            // 
            // btnLamMoiPhieuNhan
            // 
            this.btnLamMoiPhieuNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoiPhieuNhan.Image")));
            this.btnLamMoiPhieuNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoiPhieuNhan.Location = new System.Drawing.Point(9, 19);
            this.btnLamMoiPhieuNhan.Name = "btnLamMoiPhieuNhan";
            this.btnLamMoiPhieuNhan.Size = new System.Drawing.Size(79, 31);
            this.btnLamMoiPhieuNhan.TabIndex = 11;
            this.btnLamMoiPhieuNhan.Text = "Làm mới";
            this.btnLamMoiPhieuNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoiPhieuNhan.UseVisualStyleBackColor = true;
            this.btnLamMoiPhieuNhan.Click += new System.EventHandler(this.btnLamMoiPhieuNhan_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 471);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý gara ô tô";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachPhieuNhan)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPhieuSuaChua;
        private System.Windows.Forms.Button btnCongViec;
        private System.Windows.Forms.Button btnXe;
        private System.Windows.Forms.Button btnPhuTung;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTimKiemPhieuNhan;
        private System.Windows.Forms.TextBox txtTimKiemPhieuNhan;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtHieuXe;
        private System.Windows.Forms.Label lbHieuXe;
        private System.Windows.Forms.TextBox txtTenChuXe;
        private System.Windows.Forms.Label lbTenChuXe;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dtgvDanhSachPhieuNhan;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnThemPhieuNhan;
        private System.Windows.Forms.Button btnXoaPhieuNhan;
        private System.Windows.Forms.Button btnLamMoiPhieuNhan;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbNgayTiepNhan;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label lbDienThoai;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.Label lbBienSo;
        private System.Windows.Forms.Button btnKiemTraBienSo;
        private System.Windows.Forms.Button btnXemDanhSachPhieuNhan;
        private System.Windows.Forms.DateTimePicker dtpkTuNgay;
        private System.Windows.Forms.ComboBox cbbTimKiemPhieuNhan;
        private System.Windows.Forms.TextBox txtMaPhieuNhan;
        private System.Windows.Forms.Label lbMaPhieuNhan;
        private System.Windows.Forms.DateTimePicker dtpkNgayTiepNhan;
        private System.Windows.Forms.DateTimePicker dtpkDenNgay;
        private System.Windows.Forms.Label lbDenNgay;
        private System.Windows.Forms.Label lbTuNgay;
    }
}