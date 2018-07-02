namespace QuanLyGaraGUI
{
    partial class PhieuSuaChuaGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuSuaChuaGUI));
            this.btnXemDanhSachPhieuSuaChua = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpkDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lbDenNgay = new System.Windows.Forms.Label();
            this.lbTuNgay = new System.Windows.Forms.Label();
            this.cbbTimKiemPhieuSuaChua = new System.Windows.Forms.ComboBox();
            this.dtpkTuNgay = new System.Windows.Forms.DateTimePicker();
            this.btnTimKiemPhieuSuaChua = new System.Windows.Forms.Button();
            this.txtTimKiemPhieuSuaChua = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpkNgaySuaChua = new System.Windows.Forms.DateTimePicker();
            this.txtMaPhieuSuaChua = new System.Windows.Forms.TextBox();
            this.lbMaPhieuSuaChua = new System.Windows.Forms.Label();
            this.lbNgaySuaChua = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.lbTinhTrang = new System.Windows.Forms.Label();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.lbBienSo = new System.Windows.Forms.Label();
            this.btnXemChiTietPhieuSua = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtgvDanhSachPhieuSuaChua = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnThemPhieuSuaChua = new System.Windows.Forms.Button();
            this.btnXoaPhieuSuaChua = new System.Windows.Forms.Button();
            this.btnLamMoiPhieuSuaChua = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachPhieuSuaChua)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXemDanhSachPhieuSuaChua
            // 
            this.btnXemDanhSachPhieuSuaChua.AutoSize = true;
            this.btnXemDanhSachPhieuSuaChua.Image = ((System.Drawing.Image)(resources.GetObject("btnXemDanhSachPhieuSuaChua.Image")));
            this.btnXemDanhSachPhieuSuaChua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemDanhSachPhieuSuaChua.Location = new System.Drawing.Point(33, 346);
            this.btnXemDanhSachPhieuSuaChua.Name = "btnXemDanhSachPhieuSuaChua";
            this.btnXemDanhSachPhieuSuaChua.Size = new System.Drawing.Size(200, 36);
            this.btnXemDanhSachPhieuSuaChua.TabIndex = 29;
            this.btnXemDanhSachPhieuSuaChua.Text = "Xem danh sách phiếu sửa chữa";
            this.btnXemDanhSachPhieuSuaChua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemDanhSachPhieuSuaChua.UseVisualStyleBackColor = true;
            this.btnXemDanhSachPhieuSuaChua.Click += new System.EventHandler(this.btnXemDanhSachPhieuSuaChua_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpkDenNgay);
            this.groupBox3.Controls.Add(this.lbDenNgay);
            this.groupBox3.Controls.Add(this.lbTuNgay);
            this.groupBox3.Controls.Add(this.cbbTimKiemPhieuSuaChua);
            this.groupBox3.Controls.Add(this.dtpkTuNgay);
            this.groupBox3.Controls.Add(this.btnTimKiemPhieuSuaChua);
            this.groupBox3.Controls.Add(this.txtTimKiemPhieuSuaChua);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(701, 78);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // dtpkDenNgay
            // 
            this.dtpkDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpkDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkDenNgay.Location = new System.Drawing.Point(450, 46);
            this.dtpkDenNgay.Name = "dtpkDenNgay";
            this.dtpkDenNgay.Size = new System.Drawing.Size(102, 20);
            this.dtpkDenNgay.TabIndex = 27;
            this.dtpkDenNgay.Visible = false;
            // 
            // lbDenNgay
            // 
            this.lbDenNgay.AutoSize = true;
            this.lbDenNgay.Location = new System.Drawing.Point(388, 52);
            this.lbDenNgay.Name = "lbDenNgay";
            this.lbDenNgay.Size = new System.Drawing.Size(56, 13);
            this.lbDenNgay.TabIndex = 26;
            this.lbDenNgay.Text = "Đến ngày:";
            this.lbDenNgay.Visible = false;
            // 
            // lbTuNgay
            // 
            this.lbTuNgay.AutoSize = true;
            this.lbTuNgay.Location = new System.Drawing.Point(183, 52);
            this.lbTuNgay.Name = "lbTuNgay";
            this.lbTuNgay.Size = new System.Drawing.Size(49, 13);
            this.lbTuNgay.TabIndex = 25;
            this.lbTuNgay.Text = "Từ ngày:";
            this.lbTuNgay.Visible = false;
            // 
            // cbbTimKiemPhieuSuaChua
            // 
            this.cbbTimKiemPhieuSuaChua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimKiemPhieuSuaChua.FormattingEnabled = true;
            this.cbbTimKiemPhieuSuaChua.Items.AddRange(new object[] {
            "Mã phiếu sửa chữa",
            "Biển số",
            "Ngày sửa"});
            this.cbbTimKiemPhieuSuaChua.Location = new System.Drawing.Point(32, 19);
            this.cbbTimKiemPhieuSuaChua.Name = "cbbTimKiemPhieuSuaChua";
            this.cbbTimKiemPhieuSuaChua.Size = new System.Drawing.Size(121, 21);
            this.cbbTimKiemPhieuSuaChua.TabIndex = 9;
            this.cbbTimKiemPhieuSuaChua.SelectedValueChanged += new System.EventHandler(this.cbbTimKiemPhieuSuaChua_SelectedValueChanged);
            // 
            // dtpkTuNgay
            // 
            this.dtpkTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpkTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkTuNgay.Location = new System.Drawing.Point(238, 46);
            this.dtpkTuNgay.Name = "dtpkTuNgay";
            this.dtpkTuNgay.Size = new System.Drawing.Size(104, 20);
            this.dtpkTuNgay.TabIndex = 8;
            this.dtpkTuNgay.Visible = false;
            // 
            // btnTimKiemPhieuSuaChua
            // 
            this.btnTimKiemPhieuSuaChua.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemPhieuSuaChua.Image")));
            this.btnTimKiemPhieuSuaChua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemPhieuSuaChua.Location = new System.Drawing.Point(576, 15);
            this.btnTimKiemPhieuSuaChua.Name = "btnTimKiemPhieuSuaChua";
            this.btnTimKiemPhieuSuaChua.Size = new System.Drawing.Size(80, 28);
            this.btnTimKiemPhieuSuaChua.TabIndex = 7;
            this.btnTimKiemPhieuSuaChua.Text = "Tìm kiếm";
            this.btnTimKiemPhieuSuaChua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemPhieuSuaChua.UseVisualStyleBackColor = true;
            this.btnTimKiemPhieuSuaChua.Click += new System.EventHandler(this.btnTimKiemPhieuSuaChua_Click);
            // 
            // txtTimKiemPhieuSuaChua
            // 
            this.txtTimKiemPhieuSuaChua.Location = new System.Drawing.Point(159, 20);
            this.txtTimKiemPhieuSuaChua.Name = "txtTimKiemPhieuSuaChua";
            this.txtTimKiemPhieuSuaChua.Size = new System.Drawing.Size(411, 20);
            this.txtTimKiemPhieuSuaChua.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpkNgaySuaChua);
            this.groupBox4.Controls.Add(this.txtMaPhieuSuaChua);
            this.groupBox4.Controls.Add(this.lbMaPhieuSuaChua);
            this.groupBox4.Controls.Add(this.lbNgaySuaChua);
            this.groupBox4.Controls.Add(this.txtTinhTrang);
            this.groupBox4.Controls.Add(this.lbTinhTrang);
            this.groupBox4.Controls.Add(this.txtBienSo);
            this.groupBox4.Controls.Add(this.lbBienSo);
            this.groupBox4.Location = new System.Drawing.Point(12, 96);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(239, 133);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin phiếu sửa chữa";
            // 
            // dtpkNgaySuaChua
            // 
            this.dtpkNgaySuaChua.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpkNgaySuaChua.CustomFormat = "dd/MM/yyyy";
            this.dtpkNgaySuaChua.Enabled = false;
            this.dtpkNgaySuaChua.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgaySuaChua.Location = new System.Drawing.Point(66, 77);
            this.dtpkNgaySuaChua.Name = "dtpkNgaySuaChua";
            this.dtpkNgaySuaChua.Size = new System.Drawing.Size(95, 20);
            this.dtpkNgaySuaChua.TabIndex = 25;
            // 
            // txtMaPhieuSuaChua
            // 
            this.txtMaPhieuSuaChua.Location = new System.Drawing.Point(66, 25);
            this.txtMaPhieuSuaChua.Name = "txtMaPhieuSuaChua";
            this.txtMaPhieuSuaChua.ReadOnly = true;
            this.txtMaPhieuSuaChua.Size = new System.Drawing.Size(95, 20);
            this.txtMaPhieuSuaChua.TabIndex = 23;
            // 
            // lbMaPhieuSuaChua
            // 
            this.lbMaPhieuSuaChua.AutoSize = true;
            this.lbMaPhieuSuaChua.Location = new System.Drawing.Point(6, 25);
            this.lbMaPhieuSuaChua.Name = "lbMaPhieuSuaChua";
            this.lbMaPhieuSuaChua.Size = new System.Drawing.Size(54, 13);
            this.lbMaPhieuSuaChua.TabIndex = 24;
            this.lbMaPhieuSuaChua.Text = "Mã phiếu:";
            // 
            // lbNgaySuaChua
            // 
            this.lbNgaySuaChua.AutoSize = true;
            this.lbNgaySuaChua.Location = new System.Drawing.Point(6, 80);
            this.lbNgaySuaChua.Name = "lbNgaySuaChua";
            this.lbNgaySuaChua.Size = new System.Drawing.Size(55, 13);
            this.lbNgaySuaChua.TabIndex = 20;
            this.lbNgaySuaChua.Text = "Ngày sửa:";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(66, 103);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.ReadOnly = true;
            this.txtTinhTrang.Size = new System.Drawing.Size(95, 20);
            this.txtTinhTrang.TabIndex = 8;
            // 
            // lbTinhTrang
            // 
            this.lbTinhTrang.AutoSize = true;
            this.lbTinhTrang.Location = new System.Drawing.Point(6, 106);
            this.lbTinhTrang.Name = "lbTinhTrang";
            this.lbTinhTrang.Size = new System.Drawing.Size(58, 13);
            this.lbTinhTrang.TabIndex = 18;
            this.lbTinhTrang.Text = "Tình trạng:";
            // 
            // txtBienSo
            // 
            this.txtBienSo.Location = new System.Drawing.Point(66, 51);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(95, 20);
            this.txtBienSo.TabIndex = 3;
            // 
            // lbBienSo
            // 
            this.lbBienSo.AutoSize = true;
            this.lbBienSo.Location = new System.Drawing.Point(6, 54);
            this.lbBienSo.Name = "lbBienSo";
            this.lbBienSo.Size = new System.Drawing.Size(45, 13);
            this.lbBienSo.TabIndex = 16;
            this.lbBienSo.Text = "Biển số:";
            // 
            // btnXemChiTietPhieuSua
            // 
            this.btnXemChiTietPhieuSua.Enabled = false;
            this.btnXemChiTietPhieuSua.Image = ((System.Drawing.Image)(resources.GetObject("btnXemChiTietPhieuSua.Image")));
            this.btnXemChiTietPhieuSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemChiTietPhieuSua.Location = new System.Drawing.Point(32, 57);
            this.btnXemChiTietPhieuSua.Name = "btnXemChiTietPhieuSua";
            this.btnXemChiTietPhieuSua.Size = new System.Drawing.Size(180, 37);
            this.btnXemChiTietPhieuSua.TabIndex = 4;
            this.btnXemChiTietPhieuSua.Text = "Xem chi tiết phiếu sửa chữa";
            this.btnXemChiTietPhieuSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemChiTietPhieuSua.UseVisualStyleBackColor = true;
            this.btnXemChiTietPhieuSua.Click += new System.EventHandler(this.btnXemChiTietPhieuSua_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtgvDanhSachPhieuSuaChua);
            this.groupBox5.Location = new System.Drawing.Point(257, 96);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(456, 286);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách phiếu tiếp nhận sửa chữa";
            // 
            // dtgvDanhSachPhieuSuaChua
            // 
            this.dtgvDanhSachPhieuSuaChua.AllowUserToAddRows = false;
            this.dtgvDanhSachPhieuSuaChua.AllowUserToResizeColumns = false;
            this.dtgvDanhSachPhieuSuaChua.AllowUserToResizeRows = false;
            this.dtgvDanhSachPhieuSuaChua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDanhSachPhieuSuaChua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachPhieuSuaChua.Location = new System.Drawing.Point(6, 19);
            this.dtgvDanhSachPhieuSuaChua.Name = "dtgvDanhSachPhieuSuaChua";
            this.dtgvDanhSachPhieuSuaChua.RowHeadersVisible = false;
            this.dtgvDanhSachPhieuSuaChua.Size = new System.Drawing.Size(441, 261);
            this.dtgvDanhSachPhieuSuaChua.TabIndex = 0;
            this.dtgvDanhSachPhieuSuaChua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSachPhieuSuaChua_CellClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnThemPhieuSuaChua);
            this.groupBox6.Controls.Add(this.btnXoaPhieuSuaChua);
            this.groupBox6.Controls.Add(this.btnLamMoiPhieuSuaChua);
            this.groupBox6.Controls.Add(this.btnXemChiTietPhieuSua);
            this.groupBox6.Location = new System.Drawing.Point(12, 235);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(239, 105);
            this.groupBox6.TabIndex = 27;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thao tác";
            // 
            // btnThemPhieuSuaChua
            // 
            this.btnThemPhieuSuaChua.AutoSize = true;
            this.btnThemPhieuSuaChua.Image = ((System.Drawing.Image)(resources.GetObject("btnThemPhieuSuaChua.Image")));
            this.btnThemPhieuSuaChua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemPhieuSuaChua.Location = new System.Drawing.Point(163, 19);
            this.btnThemPhieuSuaChua.Name = "btnThemPhieuSuaChua";
            this.btnThemPhieuSuaChua.Size = new System.Drawing.Size(69, 32);
            this.btnThemPhieuSuaChua.TabIndex = 12;
            this.btnThemPhieuSuaChua.Text = "Thêm";
            this.btnThemPhieuSuaChua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemPhieuSuaChua.UseVisualStyleBackColor = true;
            this.btnThemPhieuSuaChua.Click += new System.EventHandler(this.btnThemPhieuSuaChua_Click);
            // 
            // btnXoaPhieuSuaChua
            // 
            this.btnXoaPhieuSuaChua.AutoSize = true;
            this.btnXoaPhieuSuaChua.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaPhieuSuaChua.Image")));
            this.btnXoaPhieuSuaChua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaPhieuSuaChua.Location = new System.Drawing.Point(94, 19);
            this.btnXoaPhieuSuaChua.Name = "btnXoaPhieuSuaChua";
            this.btnXoaPhieuSuaChua.Size = new System.Drawing.Size(63, 32);
            this.btnXoaPhieuSuaChua.TabIndex = 13;
            this.btnXoaPhieuSuaChua.Text = "Xóa";
            this.btnXoaPhieuSuaChua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaPhieuSuaChua.UseVisualStyleBackColor = true;
            this.btnXoaPhieuSuaChua.Click += new System.EventHandler(this.btnXoaPhieuSuaChua_Click);
            // 
            // btnLamMoiPhieuSuaChua
            // 
            this.btnLamMoiPhieuSuaChua.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoiPhieuSuaChua.Image")));
            this.btnLamMoiPhieuSuaChua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoiPhieuSuaChua.Location = new System.Drawing.Point(9, 19);
            this.btnLamMoiPhieuSuaChua.Name = "btnLamMoiPhieuSuaChua";
            this.btnLamMoiPhieuSuaChua.Size = new System.Drawing.Size(79, 31);
            this.btnLamMoiPhieuSuaChua.TabIndex = 11;
            this.btnLamMoiPhieuSuaChua.Text = "Làm mới";
            this.btnLamMoiPhieuSuaChua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoiPhieuSuaChua.UseVisualStyleBackColor = true;
            this.btnLamMoiPhieuSuaChua.Click += new System.EventHandler(this.btnLamMoiPhieuSuaChua_Click);
            // 
            // PhieuSuaChuaGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 391);
            this.Controls.Add(this.btnXemDanhSachPhieuSuaChua);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Name = "PhieuSuaChuaGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phiếu sửa chữa";
            this.Load += new System.EventHandler(this.PhieuSuaChuaGUI_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachPhieuSuaChua)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXemDanhSachPhieuSuaChua;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpkDenNgay;
        private System.Windows.Forms.Label lbDenNgay;
        private System.Windows.Forms.Label lbTuNgay;
        private System.Windows.Forms.ComboBox cbbTimKiemPhieuSuaChua;
        private System.Windows.Forms.DateTimePicker dtpkTuNgay;
        private System.Windows.Forms.Button btnTimKiemPhieuSuaChua;
        private System.Windows.Forms.TextBox txtTimKiemPhieuSuaChua;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpkNgaySuaChua;
        private System.Windows.Forms.TextBox txtMaPhieuSuaChua;
        private System.Windows.Forms.Label lbMaPhieuSuaChua;
        private System.Windows.Forms.Button btnXemChiTietPhieuSua;
        private System.Windows.Forms.Label lbNgaySuaChua;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label lbTinhTrang;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.Label lbBienSo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dtgvDanhSachPhieuSuaChua;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnThemPhieuSuaChua;
        private System.Windows.Forms.Button btnXoaPhieuSuaChua;
        private System.Windows.Forms.Button btnLamMoiPhieuSuaChua;
    }
}