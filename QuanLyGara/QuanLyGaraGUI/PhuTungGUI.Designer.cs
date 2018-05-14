namespace QuanLyGaraGUI
{
    partial class PhuTungGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhuTungGUI));
            this.dtgvDanhSachPhuTung = new System.Windows.Forms.DataGridView();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.txtTenPhuTung = new System.Windows.Forms.TextBox();
            this.lbTenPhuTung = new System.Windows.Forms.Label();
            this.lbMaPhuTung = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTimKiemPhuTung = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbTimKiemPhuTung = new System.Windows.Forms.ComboBox();
            this.btnTimKiemPhuTung = new System.Windows.Forms.Button();
            this.txtMaPhuTung = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudSoLuongTonKho = new System.Windows.Forms.NumericUpDown();
            this.nudDonGia = new System.Windows.Forms.NumericUpDown();
            this.txtMaPhuTungCapNhat = new System.Windows.Forms.TextBox();
            this.lbMaPhuTungCapNhat = new System.Windows.Forms.Label();
            this.ckCapNhatMaPhuTung = new System.Windows.Forms.CheckBox();
            this.lbSoLuongTon = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnCapNhatPhuTung = new System.Windows.Forms.Button();
            this.btnThemPhuTung = new System.Windows.Forms.Button();
            this.btnXoaPhuTung = new System.Windows.Forms.Button();
            this.btnLamMoiPhuTung = new System.Windows.Forms.Button();
            this.btnXemDanhSachKhachHang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachPhuTung)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTonKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvDanhSachPhuTung
            // 
            this.dtgvDanhSachPhuTung.AllowUserToAddRows = false;
            this.dtgvDanhSachPhuTung.AllowUserToResizeColumns = false;
            this.dtgvDanhSachPhuTung.AllowUserToResizeRows = false;
            this.dtgvDanhSachPhuTung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDanhSachPhuTung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachPhuTung.Location = new System.Drawing.Point(6, 19);
            this.dtgvDanhSachPhuTung.Name = "dtgvDanhSachPhuTung";
            this.dtgvDanhSachPhuTung.RowHeadersVisible = false;
            this.dtgvDanhSachPhuTung.Size = new System.Drawing.Size(450, 245);
            this.dtgvDanhSachPhuTung.TabIndex = 0;
            this.dtgvDanhSachPhuTung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSachPhuTung_CellClick);
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Location = new System.Drawing.Point(6, 107);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(47, 13);
            this.lbDonGia.TabIndex = 14;
            this.lbDonGia.Text = "Đơn giá:";
            // 
            // txtTenPhuTung
            // 
            this.txtTenPhuTung.Location = new System.Drawing.Point(127, 78);
            this.txtTenPhuTung.Name = "txtTenPhuTung";
            this.txtTenPhuTung.Size = new System.Drawing.Size(241, 20);
            this.txtTenPhuTung.TabIndex = 13;
            // 
            // lbTenPhuTung
            // 
            this.lbTenPhuTung.AutoSize = true;
            this.lbTenPhuTung.Location = new System.Drawing.Point(6, 81);
            this.lbTenPhuTung.Name = "lbTenPhuTung";
            this.lbTenPhuTung.Size = new System.Drawing.Size(74, 13);
            this.lbTenPhuTung.TabIndex = 12;
            this.lbTenPhuTung.Text = "Tên phụ tùng:";
            // 
            // lbMaPhuTung
            // 
            this.lbMaPhuTung.AutoSize = true;
            this.lbMaPhuTung.Location = new System.Drawing.Point(6, 26);
            this.lbMaPhuTung.Name = "lbMaPhuTung";
            this.lbMaPhuTung.Size = new System.Drawing.Size(70, 13);
            this.lbMaPhuTung.TabIndex = 10;
            this.lbMaPhuTung.Text = "Mã phụ tùng:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgvDanhSachPhuTung);
            this.groupBox4.Location = new System.Drawing.Point(399, 71);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(462, 270);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách phụ tùng";
            // 
            // txtTimKiemPhuTung
            // 
            this.txtTimKiemPhuTung.Location = new System.Drawing.Point(166, 19);
            this.txtTimKiemPhuTung.Name = "txtTimKiemPhuTung";
            this.txtTimKiemPhuTung.Size = new System.Drawing.Size(536, 20);
            this.txtTimKiemPhuTung.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbTimKiemPhuTung);
            this.groupBox1.Controls.Add(this.btnTimKiemPhuTung);
            this.groupBox1.Controls.Add(this.txtTimKiemPhuTung);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 53);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // cbbTimKiemPhuTung
            // 
            this.cbbTimKiemPhuTung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimKiemPhuTung.FormattingEnabled = true;
            this.cbbTimKiemPhuTung.Items.AddRange(new object[] {
            "Mã phụ tùng",
            "Tên phụ tùng"});
            this.cbbTimKiemPhuTung.Location = new System.Drawing.Point(63, 19);
            this.cbbTimKiemPhuTung.Name = "cbbTimKiemPhuTung";
            this.cbbTimKiemPhuTung.Size = new System.Drawing.Size(97, 21);
            this.cbbTimKiemPhuTung.TabIndex = 22;
            // 
            // btnTimKiemPhuTung
            // 
            this.btnTimKiemPhuTung.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemPhuTung.Image")));
            this.btnTimKiemPhuTung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemPhuTung.Location = new System.Drawing.Point(708, 14);
            this.btnTimKiemPhuTung.Name = "btnTimKiemPhuTung";
            this.btnTimKiemPhuTung.Size = new System.Drawing.Size(80, 28);
            this.btnTimKiemPhuTung.TabIndex = 15;
            this.btnTimKiemPhuTung.Text = "Tìm kiếm";
            this.btnTimKiemPhuTung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemPhuTung.UseVisualStyleBackColor = true;
            this.btnTimKiemPhuTung.Click += new System.EventHandler(this.btnTimKiemPhuTung_Click);
            // 
            // txtMaPhuTung
            // 
            this.txtMaPhuTung.Location = new System.Drawing.Point(127, 26);
            this.txtMaPhuTung.Name = "txtMaPhuTung";
            this.txtMaPhuTung.Size = new System.Drawing.Size(104, 20);
            this.txtMaPhuTung.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudSoLuongTonKho);
            this.groupBox2.Controls.Add(this.nudDonGia);
            this.groupBox2.Controls.Add(this.txtMaPhuTungCapNhat);
            this.groupBox2.Controls.Add(this.lbMaPhuTungCapNhat);
            this.groupBox2.Controls.Add(this.ckCapNhatMaPhuTung);
            this.groupBox2.Controls.Add(this.lbSoLuongTon);
            this.groupBox2.Controls.Add(this.lbDonGia);
            this.groupBox2.Controls.Add(this.txtTenPhuTung);
            this.groupBox2.Controls.Add(this.lbTenPhuTung);
            this.groupBox2.Controls.Add(this.txtMaPhuTung);
            this.groupBox2.Controls.Add(this.lbMaPhuTung);
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 166);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phụ tùng";
            // 
            // nudSoLuongTonKho
            // 
            this.nudSoLuongTonKho.Location = new System.Drawing.Point(127, 130);
            this.nudSoLuongTonKho.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudSoLuongTonKho.Name = "nudSoLuongTonKho";
            this.nudSoLuongTonKho.Size = new System.Drawing.Size(120, 20);
            this.nudSoLuongTonKho.TabIndex = 22;
            this.nudSoLuongTonKho.Validating += new System.ComponentModel.CancelEventHandler(this.nudSoLuongTonKho_Validating);
            // 
            // nudDonGia
            // 
            this.nudDonGia.Location = new System.Drawing.Point(127, 104);
            this.nudDonGia.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudDonGia.Name = "nudDonGia";
            this.nudDonGia.Size = new System.Drawing.Size(120, 20);
            this.nudDonGia.TabIndex = 21;
            this.nudDonGia.Validating += new System.ComponentModel.CancelEventHandler(this.nudDonGia_Validating);
            // 
            // txtMaPhuTungCapNhat
            // 
            this.txtMaPhuTungCapNhat.Enabled = false;
            this.txtMaPhuTungCapNhat.Location = new System.Drawing.Point(127, 52);
            this.txtMaPhuTungCapNhat.Name = "txtMaPhuTungCapNhat";
            this.txtMaPhuTungCapNhat.Size = new System.Drawing.Size(104, 20);
            this.txtMaPhuTungCapNhat.TabIndex = 20;
            // 
            // lbMaPhuTungCapNhat
            // 
            this.lbMaPhuTungCapNhat.AutoSize = true;
            this.lbMaPhuTungCapNhat.Enabled = false;
            this.lbMaPhuTungCapNhat.Location = new System.Drawing.Point(6, 54);
            this.lbMaPhuTungCapNhat.Name = "lbMaPhuTungCapNhat";
            this.lbMaPhuTungCapNhat.Size = new System.Drawing.Size(115, 13);
            this.lbMaPhuTungCapNhat.TabIndex = 19;
            this.lbMaPhuTungCapNhat.Text = "Mã phụ tùng cập nhật:";
            // 
            // ckCapNhatMaPhuTung
            // 
            this.ckCapNhatMaPhuTung.AutoSize = true;
            this.ckCapNhatMaPhuTung.Location = new System.Drawing.Point(237, 54);
            this.ckCapNhatMaPhuTung.Name = "ckCapNhatMaPhuTung";
            this.ckCapNhatMaPhuTung.Size = new System.Drawing.Size(131, 17);
            this.ckCapNhatMaPhuTung.TabIndex = 18;
            this.ckCapNhatMaPhuTung.Text = "Cập nhật mã phụ tùng";
            this.ckCapNhatMaPhuTung.UseVisualStyleBackColor = true;
            this.ckCapNhatMaPhuTung.CheckedChanged += new System.EventHandler(this.ckCapNhatMaPhuTung_CheckedChanged);
            // 
            // lbSoLuongTon
            // 
            this.lbSoLuongTon.AutoSize = true;
            this.lbSoLuongTon.Location = new System.Drawing.Point(6, 133);
            this.lbSoLuongTon.Name = "lbSoLuongTon";
            this.lbSoLuongTon.Size = new System.Drawing.Size(91, 13);
            this.lbSoLuongTon.TabIndex = 16;
            this.lbSoLuongTon.Text = "Số lượng tồn kho:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnCapNhatPhuTung);
            this.groupBox6.Controls.Add(this.btnThemPhuTung);
            this.groupBox6.Controls.Add(this.btnXoaPhuTung);
            this.groupBox6.Controls.Add(this.btnLamMoiPhuTung);
            this.groupBox6.Location = new System.Drawing.Point(12, 243);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(381, 62);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thao tác";
            // 
            // btnCapNhatPhuTung
            // 
            this.btnCapNhatPhuTung.AutoSize = true;
            this.btnCapNhatPhuTung.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatPhuTung.Image")));
            this.btnCapNhatPhuTung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhatPhuTung.Location = new System.Drawing.Point(99, 19);
            this.btnCapNhatPhuTung.Name = "btnCapNhatPhuTung";
            this.btnCapNhatPhuTung.Size = new System.Drawing.Size(85, 31);
            this.btnCapNhatPhuTung.TabIndex = 15;
            this.btnCapNhatPhuTung.Text = "Cập nhật";
            this.btnCapNhatPhuTung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhatPhuTung.UseVisualStyleBackColor = true;
            this.btnCapNhatPhuTung.Click += new System.EventHandler(this.btnCapNhatPhuTung_Click);
            // 
            // btnThemPhuTung
            // 
            this.btnThemPhuTung.AutoSize = true;
            this.btnThemPhuTung.Image = ((System.Drawing.Image)(resources.GetObject("btnThemPhuTung.Image")));
            this.btnThemPhuTung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemPhuTung.Location = new System.Drawing.Point(294, 18);
            this.btnThemPhuTung.Name = "btnThemPhuTung";
            this.btnThemPhuTung.Size = new System.Drawing.Size(74, 32);
            this.btnThemPhuTung.TabIndex = 12;
            this.btnThemPhuTung.Text = "Thêm";
            this.btnThemPhuTung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemPhuTung.UseVisualStyleBackColor = true;
            this.btnThemPhuTung.Click += new System.EventHandler(this.btnThemPhuTung_Click);
            // 
            // btnXoaPhuTung
            // 
            this.btnXoaPhuTung.AutoSize = true;
            this.btnXoaPhuTung.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaPhuTung.Image")));
            this.btnXoaPhuTung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaPhuTung.Location = new System.Drawing.Point(202, 19);
            this.btnXoaPhuTung.Name = "btnXoaPhuTung";
            this.btnXoaPhuTung.Size = new System.Drawing.Size(70, 31);
            this.btnXoaPhuTung.TabIndex = 13;
            this.btnXoaPhuTung.Text = "Xóa";
            this.btnXoaPhuTung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaPhuTung.UseVisualStyleBackColor = true;
            this.btnXoaPhuTung.Click += new System.EventHandler(this.btnXoaPhuTung_Click);
            // 
            // btnLamMoiPhuTung
            // 
            this.btnLamMoiPhuTung.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoiPhuTung.Image")));
            this.btnLamMoiPhuTung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoiPhuTung.Location = new System.Drawing.Point(9, 19);
            this.btnLamMoiPhuTung.Name = "btnLamMoiPhuTung";
            this.btnLamMoiPhuTung.Size = new System.Drawing.Size(79, 31);
            this.btnLamMoiPhuTung.TabIndex = 11;
            this.btnLamMoiPhuTung.Text = "Làm mới";
            this.btnLamMoiPhuTung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoiPhuTung.UseVisualStyleBackColor = true;
            this.btnLamMoiPhuTung.Click += new System.EventHandler(this.btnLamMoiPhuTung_Click);
            // 
            // btnXemDanhSachKhachHang
            // 
            this.btnXemDanhSachKhachHang.AutoSize = true;
            this.btnXemDanhSachKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnXemDanhSachKhachHang.Image")));
            this.btnXemDanhSachKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemDanhSachKhachHang.Location = new System.Drawing.Point(111, 311);
            this.btnXemDanhSachKhachHang.Name = "btnXemDanhSachKhachHang";
            this.btnXemDanhSachKhachHang.Size = new System.Drawing.Size(173, 30);
            this.btnXemDanhSachKhachHang.TabIndex = 24;
            this.btnXemDanhSachKhachHang.Text = "Xem danh sách phụ tùng";
            this.btnXemDanhSachKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemDanhSachKhachHang.UseVisualStyleBackColor = true;
            this.btnXemDanhSachKhachHang.Click += new System.EventHandler(this.btnXemDanhSachKhachHang_Click);
            // 
            // PhuTungGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 346);
            this.Controls.Add(this.btnXemDanhSachKhachHang);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "PhuTungGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phụ tùng";
            this.Load += new System.EventHandler(this.PhuTungGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachPhuTung)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTonKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDanhSachPhuTung;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.TextBox txtTenPhuTung;
        private System.Windows.Forms.Label lbTenPhuTung;
        private System.Windows.Forms.Label lbMaPhuTung;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtTimKiemPhuTung;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaPhuTung;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbSoLuongTon;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnCapNhatPhuTung;
        private System.Windows.Forms.Button btnThemPhuTung;
        private System.Windows.Forms.Button btnXoaPhuTung;
        private System.Windows.Forms.Button btnLamMoiPhuTung;
        private System.Windows.Forms.Button btnTimKiemPhuTung;
        private System.Windows.Forms.ComboBox cbbTimKiemPhuTung;
        private System.Windows.Forms.TextBox txtMaPhuTungCapNhat;
        private System.Windows.Forms.Label lbMaPhuTungCapNhat;
        private System.Windows.Forms.CheckBox ckCapNhatMaPhuTung;
        private System.Windows.Forms.Button btnXemDanhSachKhachHang;
        private System.Windows.Forms.NumericUpDown nudDonGia;
        private System.Windows.Forms.NumericUpDown nudSoLuongTonKho;
    }
}