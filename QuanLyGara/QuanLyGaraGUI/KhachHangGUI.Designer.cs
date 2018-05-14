namespace QuanLyGaraGUI
{
    partial class KhachHangGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHangGUI));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbTimKiemKhachHang = new System.Windows.Forms.ComboBox();
            this.btnTimKiemKhachHang = new System.Windows.Forms.Button();
            this.txtTimKiemKhachHang = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lbDienThoai = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.lbTenKhachHang = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.lbMaKhachHang = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgvDanhSachKhachHang = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnCapNhatKhachHang = new System.Windows.Forms.Button();
            this.btnThemKhachHang = new System.Windows.Forms.Button();
            this.btnLamMoiKhachHang = new System.Windows.Forms.Button();
            this.btnXemDanhSachKhachHang = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachKhachHang)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbTimKiemKhachHang);
            this.groupBox1.Controls.Add(this.btnTimKiemKhachHang);
            this.groupBox1.Controls.Add(this.txtTimKiemKhachHang);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 53);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // cbbTimKiemKhachHang
            // 
            this.cbbTimKiemKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimKiemKhachHang.FormattingEnabled = true;
            this.cbbTimKiemKhachHang.Items.AddRange(new object[] {
            "Mã khách hàng",
            "Tên khách hàng"});
            this.cbbTimKiemKhachHang.Location = new System.Drawing.Point(69, 19);
            this.cbbTimKiemKhachHang.Name = "cbbTimKiemKhachHang";
            this.cbbTimKiemKhachHang.Size = new System.Drawing.Size(103, 21);
            this.cbbTimKiemKhachHang.TabIndex = 15;
            // 
            // btnTimKiemKhachHang
            // 
            this.btnTimKiemKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemKhachHang.Image")));
            this.btnTimKiemKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemKhachHang.Location = new System.Drawing.Point(731, 14);
            this.btnTimKiemKhachHang.Name = "btnTimKiemKhachHang";
            this.btnTimKiemKhachHang.Size = new System.Drawing.Size(80, 28);
            this.btnTimKiemKhachHang.TabIndex = 14;
            this.btnTimKiemKhachHang.Text = "Tìm kiếm";
            this.btnTimKiemKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemKhachHang.UseVisualStyleBackColor = true;
            this.btnTimKiemKhachHang.Click += new System.EventHandler(this.btnTimKiemKhachHang_Click);
            // 
            // txtTimKiemKhachHang
            // 
            this.txtTimKiemKhachHang.Location = new System.Drawing.Point(178, 19);
            this.txtTimKiemKhachHang.Name = "txtTimKiemKhachHang";
            this.txtTimKiemKhachHang.Size = new System.Drawing.Size(547, 20);
            this.txtTimKiemKhachHang.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.lbEmail);
            this.groupBox2.Controls.Add(this.txtDienThoai);
            this.groupBox2.Controls.Add(this.lbDienThoai);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.lbDiaChi);
            this.groupBox2.Controls.Add(this.txtTenKhachHang);
            this.groupBox2.Controls.Add(this.lbTenKhachHang);
            this.groupBox2.Controls.Add(this.txtMaKhachHang);
            this.groupBox2.Controls.Add(this.lbMaKhachHang);
            this.groupBox2.Location = new System.Drawing.Point(15, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 175);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(97, 147);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(165, 20);
            this.txtEmail.TabIndex = 19;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(6, 150);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 18;
            this.lbEmail.Text = "Email:";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(97, 121);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(165, 20);
            this.txtDienThoai.TabIndex = 17;
            // 
            // lbDienThoai
            // 
            this.lbDienThoai.AutoSize = true;
            this.lbDienThoai.Location = new System.Drawing.Point(6, 124);
            this.lbDienThoai.Name = "lbDienThoai";
            this.lbDienThoai.Size = new System.Drawing.Size(73, 13);
            this.lbDienThoai.TabIndex = 16;
            this.lbDienThoai.Text = "Số điện thoại:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(97, 71);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDiaChi.Size = new System.Drawing.Size(196, 44);
            this.txtDiaChi.TabIndex = 15;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(6, 83);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(43, 13);
            this.lbDiaChi.TabIndex = 14;
            this.lbDiaChi.Text = "Địa chỉ:";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(97, 45);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(196, 20);
            this.txtTenKhachHang.TabIndex = 13;
            // 
            // lbTenKhachHang
            // 
            this.lbTenKhachHang.AutoSize = true;
            this.lbTenKhachHang.Location = new System.Drawing.Point(6, 48);
            this.lbTenKhachHang.Name = "lbTenKhachHang";
            this.lbTenKhachHang.Size = new System.Drawing.Size(89, 13);
            this.lbTenKhachHang.TabIndex = 12;
            this.lbTenKhachHang.Text = "Tên khách hàng:";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(97, 19);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.ReadOnly = true;
            this.txtMaKhachHang.Size = new System.Drawing.Size(100, 20);
            this.txtMaKhachHang.TabIndex = 11;
            // 
            // lbMaKhachHang
            // 
            this.lbMaKhachHang.AutoSize = true;
            this.lbMaKhachHang.Location = new System.Drawing.Point(6, 19);
            this.lbMaKhachHang.Name = "lbMaKhachHang";
            this.lbMaKhachHang.Size = new System.Drawing.Size(85, 13);
            this.lbMaKhachHang.TabIndex = 10;
            this.lbMaKhachHang.Text = "Mã khách hàng:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgvDanhSachKhachHang);
            this.groupBox4.Location = new System.Drawing.Point(329, 71);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(574, 279);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách khách hàng";
            // 
            // dtgvDanhSachKhachHang
            // 
            this.dtgvDanhSachKhachHang.AllowUserToAddRows = false;
            this.dtgvDanhSachKhachHang.AllowUserToResizeColumns = false;
            this.dtgvDanhSachKhachHang.AllowUserToResizeRows = false;
            this.dtgvDanhSachKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDanhSachKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachKhachHang.Location = new System.Drawing.Point(6, 19);
            this.dtgvDanhSachKhachHang.Name = "dtgvDanhSachKhachHang";
            this.dtgvDanhSachKhachHang.ReadOnly = true;
            this.dtgvDanhSachKhachHang.RowHeadersVisible = false;
            this.dtgvDanhSachKhachHang.Size = new System.Drawing.Size(562, 254);
            this.dtgvDanhSachKhachHang.TabIndex = 0;
            this.dtgvDanhSachKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSachKhachHang_CellClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnCapNhatKhachHang);
            this.groupBox6.Controls.Add(this.btnThemKhachHang);
            this.groupBox6.Controls.Add(this.btnLamMoiKhachHang);
            this.groupBox6.Location = new System.Drawing.Point(15, 252);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(304, 62);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thao tác";
            // 
            // btnCapNhatKhachHang
            // 
            this.btnCapNhatKhachHang.AutoSize = true;
            this.btnCapNhatKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatKhachHang.Image")));
            this.btnCapNhatKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhatKhachHang.Location = new System.Drawing.Point(112, 19);
            this.btnCapNhatKhachHang.Name = "btnCapNhatKhachHang";
            this.btnCapNhatKhachHang.Size = new System.Drawing.Size(85, 31);
            this.btnCapNhatKhachHang.TabIndex = 15;
            this.btnCapNhatKhachHang.Text = "Cập nhật";
            this.btnCapNhatKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhatKhachHang.UseVisualStyleBackColor = true;
            this.btnCapNhatKhachHang.Click += new System.EventHandler(this.btnCapNhatKhachHang_Click);
            // 
            // btnThemKhachHang
            // 
            this.btnThemKhachHang.AutoSize = true;
            this.btnThemKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnThemKhachHang.Image")));
            this.btnThemKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemKhachHang.Location = new System.Drawing.Point(219, 18);
            this.btnThemKhachHang.Name = "btnThemKhachHang";
            this.btnThemKhachHang.Size = new System.Drawing.Size(74, 32);
            this.btnThemKhachHang.TabIndex = 14;
            this.btnThemKhachHang.Text = "Thêm";
            this.btnThemKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemKhachHang.UseVisualStyleBackColor = true;
            this.btnThemKhachHang.Click += new System.EventHandler(this.btnThemKhachHang_Click);
            // 
            // btnLamMoiKhachHang
            // 
            this.btnLamMoiKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoiKhachHang.Image")));
            this.btnLamMoiKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoiKhachHang.Location = new System.Drawing.Point(9, 19);
            this.btnLamMoiKhachHang.Name = "btnLamMoiKhachHang";
            this.btnLamMoiKhachHang.Size = new System.Drawing.Size(79, 31);
            this.btnLamMoiKhachHang.TabIndex = 11;
            this.btnLamMoiKhachHang.Text = "Làm mới";
            this.btnLamMoiKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoiKhachHang.UseVisualStyleBackColor = true;
            this.btnLamMoiKhachHang.Click += new System.EventHandler(this.btnLamMoiKhachHang_Click);
            // 
            // btnXemDanhSachKhachHang
            // 
            this.btnXemDanhSachKhachHang.AutoSize = true;
            this.btnXemDanhSachKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnXemDanhSachKhachHang.Image")));
            this.btnXemDanhSachKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemDanhSachKhachHang.Location = new System.Drawing.Point(84, 320);
            this.btnXemDanhSachKhachHang.Name = "btnXemDanhSachKhachHang";
            this.btnXemDanhSachKhachHang.Size = new System.Drawing.Size(175, 30);
            this.btnXemDanhSachKhachHang.TabIndex = 23;
            this.btnXemDanhSachKhachHang.Text = "Xem danh sách khách hàng";
            this.btnXemDanhSachKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemDanhSachKhachHang.UseVisualStyleBackColor = true;
            this.btnXemDanhSachKhachHang.Click += new System.EventHandler(this.btnXemDanhSachKhachHang_Click);
            // 
            // KhachHangGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 356);
            this.Controls.Add(this.btnXemDanhSachKhachHang);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "KhachHangGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.KhachHangGUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachKhachHang)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimKiemKhachHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label lbDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label lbTenKhachHang;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label lbMaKhachHang;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgvDanhSachKhachHang;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnCapNhatKhachHang;
        private System.Windows.Forms.Button btnThemKhachHang;
        private System.Windows.Forms.Button btnLamMoiKhachHang;
        private System.Windows.Forms.Button btnTimKiemKhachHang;
        private System.Windows.Forms.ComboBox cbbTimKiemKhachHang;
        private System.Windows.Forms.Button btnXemDanhSachKhachHang;
    }
}