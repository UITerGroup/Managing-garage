namespace QuanLyGaraGUI
{
    partial class XeGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XeGUI));
            this.dtgvDanhSachXe = new System.Windows.Forms.DataGridView();
            this.txtHieuXe = new System.Windows.Forms.TextBox();
            this.lbHieuXe = new System.Windows.Forms.Label();
            this.lbBienSo = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTimKiemXe = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbTimKiemXe = new System.Windows.Forms.ComboBox();
            this.btnTimKiemXe = new System.Windows.Forms.Button();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckCapNhatBienSo = new System.Windows.Forms.CheckBox();
            this.txtBienSoCapNhat = new System.Windows.Forms.TextBox();
            this.lbBienSoCapNhat = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnCapNhatXe = new System.Windows.Forms.Button();
            this.btnThemXe = new System.Windows.Forms.Button();
            this.btnXoaXe = new System.Windows.Forms.Button();
            this.btnLamMoiXe = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbbTenChuXe = new System.Windows.Forms.ComboBox();
            this.lbTenChuXe = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lbDienThoai = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.txtMaChuXe = new System.Windows.Forms.TextBox();
            this.lbMaChuXe = new System.Windows.Forms.Label();
            this.btnXemDanhSachXe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachXe)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvDanhSachXe
            // 
            this.dtgvDanhSachXe.AllowUserToAddRows = false;
            this.dtgvDanhSachXe.AllowUserToResizeColumns = false;
            this.dtgvDanhSachXe.AllowUserToResizeRows = false;
            this.dtgvDanhSachXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgvDanhSachXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachXe.Location = new System.Drawing.Point(6, 19);
            this.dtgvDanhSachXe.Name = "dtgvDanhSachXe";
            this.dtgvDanhSachXe.RowHeadersVisible = false;
            this.dtgvDanhSachXe.Size = new System.Drawing.Size(619, 368);
            this.dtgvDanhSachXe.TabIndex = 0;
            this.dtgvDanhSachXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSachXe_CellClick);
            // 
            // txtHieuXe
            // 
            this.txtHieuXe.Location = new System.Drawing.Point(97, 71);
            this.txtHieuXe.Name = "txtHieuXe";
            this.txtHieuXe.Size = new System.Drawing.Size(100, 20);
            this.txtHieuXe.TabIndex = 13;
            // 
            // lbHieuXe
            // 
            this.lbHieuXe.AutoSize = true;
            this.lbHieuXe.Location = new System.Drawing.Point(6, 74);
            this.lbHieuXe.Name = "lbHieuXe";
            this.lbHieuXe.Size = new System.Drawing.Size(46, 13);
            this.lbHieuXe.TabIndex = 12;
            this.lbHieuXe.Text = "Hiệu xe:";
            // 
            // lbBienSo
            // 
            this.lbBienSo.AutoSize = true;
            this.lbBienSo.Location = new System.Drawing.Point(6, 19);
            this.lbBienSo.Name = "lbBienSo";
            this.lbBienSo.Size = new System.Drawing.Size(45, 13);
            this.lbBienSo.TabIndex = 10;
            this.lbBienSo.Text = "Biển số:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgvDanhSachXe);
            this.groupBox4.Location = new System.Drawing.Point(357, 71);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(633, 396);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách xe";
            // 
            // txtTimKiemXe
            // 
            this.txtTimKiemXe.Location = new System.Drawing.Point(153, 19);
            this.txtTimKiemXe.Name = "txtTimKiemXe";
            this.txtTimKiemXe.Size = new System.Drawing.Size(662, 20);
            this.txtTimKiemXe.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbTimKiemXe);
            this.groupBox1.Controls.Add(this.btnTimKiemXe);
            this.groupBox1.Controls.Add(this.txtTimKiemXe);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(978, 53);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // cbbTimKiemXe
            // 
            this.cbbTimKiemXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimKiemXe.FormattingEnabled = true;
            this.cbbTimKiemXe.Items.AddRange(new object[] {
            "Biển số",
            "Hiệu xe",
            "Mã chủ xe",
            "Tên chủ xe"});
            this.cbbTimKiemXe.Location = new System.Drawing.Point(58, 18);
            this.cbbTimKiemXe.Name = "cbbTimKiemXe";
            this.cbbTimKiemXe.Size = new System.Drawing.Size(89, 21);
            this.cbbTimKiemXe.TabIndex = 17;
            // 
            // btnTimKiemXe
            // 
            this.btnTimKiemXe.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemXe.Image")));
            this.btnTimKiemXe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemXe.Location = new System.Drawing.Point(821, 14);
            this.btnTimKiemXe.Name = "btnTimKiemXe";
            this.btnTimKiemXe.Size = new System.Drawing.Size(80, 28);
            this.btnTimKiemXe.TabIndex = 16;
            this.btnTimKiemXe.Text = "Tìm kiếm";
            this.btnTimKiemXe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemXe.UseVisualStyleBackColor = true;
            this.btnTimKiemXe.Click += new System.EventHandler(this.btnTimKiemXe_Click);
            // 
            // txtBienSo
            // 
            this.txtBienSo.Location = new System.Drawing.Point(97, 19);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(100, 20);
            this.txtBienSo.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckCapNhatBienSo);
            this.groupBox2.Controls.Add(this.txtBienSoCapNhat);
            this.groupBox2.Controls.Add(this.lbBienSoCapNhat);
            this.groupBox2.Controls.Add(this.txtHieuXe);
            this.groupBox2.Controls.Add(this.lbHieuXe);
            this.groupBox2.Controls.Add(this.txtBienSo);
            this.groupBox2.Controls.Add(this.lbBienSo);
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 103);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin xe";
            // 
            // ckCapNhatBienSo
            // 
            this.ckCapNhatBienSo.AutoSize = true;
            this.ckCapNhatBienSo.Location = new System.Drawing.Point(203, 47);
            this.ckCapNhatBienSo.Name = "ckCapNhatBienSo";
            this.ckCapNhatBienSo.Size = new System.Drawing.Size(106, 17);
            this.ckCapNhatBienSo.TabIndex = 16;
            this.ckCapNhatBienSo.Text = "Cập nhật biển số";
            this.ckCapNhatBienSo.UseVisualStyleBackColor = true;
            this.ckCapNhatBienSo.CheckedChanged += new System.EventHandler(this.ckCapNhatBienSo_CheckedChanged);
            // 
            // txtBienSoCapNhat
            // 
            this.txtBienSoCapNhat.Enabled = false;
            this.txtBienSoCapNhat.Location = new System.Drawing.Point(97, 45);
            this.txtBienSoCapNhat.Name = "txtBienSoCapNhat";
            this.txtBienSoCapNhat.Size = new System.Drawing.Size(100, 20);
            this.txtBienSoCapNhat.TabIndex = 15;
            // 
            // lbBienSoCapNhat
            // 
            this.lbBienSoCapNhat.AutoSize = true;
            this.lbBienSoCapNhat.Enabled = false;
            this.lbBienSoCapNhat.Location = new System.Drawing.Point(6, 48);
            this.lbBienSoCapNhat.Name = "lbBienSoCapNhat";
            this.lbBienSoCapNhat.Size = new System.Drawing.Size(90, 13);
            this.lbBienSoCapNhat.TabIndex = 14;
            this.lbBienSoCapNhat.Text = "Biển số cập nhật:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnCapNhatXe);
            this.groupBox6.Controls.Add(this.btnThemXe);
            this.groupBox6.Controls.Add(this.btnXoaXe);
            this.groupBox6.Controls.Add(this.btnLamMoiXe);
            this.groupBox6.Location = new System.Drawing.Point(12, 361);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(339, 62);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thao tác";
            // 
            // btnCapNhatXe
            // 
            this.btnCapNhatXe.AutoSize = true;
            this.btnCapNhatXe.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatXe.Image")));
            this.btnCapNhatXe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhatXe.Location = new System.Drawing.Point(91, 19);
            this.btnCapNhatXe.Name = "btnCapNhatXe";
            this.btnCapNhatXe.Size = new System.Drawing.Size(85, 31);
            this.btnCapNhatXe.TabIndex = 15;
            this.btnCapNhatXe.Text = "Cập nhật";
            this.btnCapNhatXe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhatXe.UseVisualStyleBackColor = true;
            this.btnCapNhatXe.Click += new System.EventHandler(this.btnCapNhatXe_Click);
            // 
            // btnThemXe
            // 
            this.btnThemXe.AutoSize = true;
            this.btnThemXe.Image = ((System.Drawing.Image)(resources.GetObject("btnThemXe.Image")));
            this.btnThemXe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemXe.Location = new System.Drawing.Point(258, 19);
            this.btnThemXe.Name = "btnThemXe";
            this.btnThemXe.Size = new System.Drawing.Size(74, 32);
            this.btnThemXe.TabIndex = 12;
            this.btnThemXe.Text = "Thêm";
            this.btnThemXe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemXe.UseVisualStyleBackColor = true;
            this.btnThemXe.Click += new System.EventHandler(this.btnThemXe_Click);
            // 
            // btnXoaXe
            // 
            this.btnXoaXe.AutoSize = true;
            this.btnXoaXe.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaXe.Image")));
            this.btnXoaXe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaXe.Location = new System.Drawing.Point(182, 19);
            this.btnXoaXe.Name = "btnXoaXe";
            this.btnXoaXe.Size = new System.Drawing.Size(70, 31);
            this.btnXoaXe.TabIndex = 13;
            this.btnXoaXe.Text = "Xóa";
            this.btnXoaXe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaXe.UseVisualStyleBackColor = true;
            this.btnXoaXe.Click += new System.EventHandler(this.btnXoaXe_Click);
            // 
            // btnLamMoiXe
            // 
            this.btnLamMoiXe.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoiXe.Image")));
            this.btnLamMoiXe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoiXe.Location = new System.Drawing.Point(6, 20);
            this.btnLamMoiXe.Name = "btnLamMoiXe";
            this.btnLamMoiXe.Size = new System.Drawing.Size(79, 31);
            this.btnLamMoiXe.TabIndex = 11;
            this.btnLamMoiXe.Text = "Làm mới";
            this.btnLamMoiXe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoiXe.UseVisualStyleBackColor = true;
            this.btnLamMoiXe.Click += new System.EventHandler(this.btnLamMoiXe_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbbTenChuXe);
            this.groupBox3.Controls.Add(this.lbTenChuXe);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.lbEmail);
            this.groupBox3.Controls.Add(this.txtDienThoai);
            this.groupBox3.Controls.Add(this.lbDienThoai);
            this.groupBox3.Controls.Add(this.txtDiaChi);
            this.groupBox3.Controls.Add(this.lbDiaChi);
            this.groupBox3.Controls.Add(this.txtMaChuXe);
            this.groupBox3.Controls.Add(this.lbMaChuXe);
            this.groupBox3.Location = new System.Drawing.Point(12, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 175);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chủ xe";
            // 
            // cbbTenChuXe
            // 
            this.cbbTenChuXe.DropDownHeight = 130;
            this.cbbTenChuXe.IntegralHeight = false;
            this.cbbTenChuXe.Location = new System.Drawing.Point(97, 18);
            this.cbbTenChuXe.Name = "cbbTenChuXe";
            this.cbbTenChuXe.Size = new System.Drawing.Size(212, 21);
            this.cbbTenChuXe.TabIndex = 21;
            this.cbbTenChuXe.SelectedValueChanged += new System.EventHandler(this.cbbTenChuXe_SelectedValueChanged);
            this.cbbTenChuXe.Click += new System.EventHandler(this.cbbTenChuXe_Click);
            // 
            // lbTenChuXe
            // 
            this.lbTenChuXe.AutoSize = true;
            this.lbTenChuXe.Location = new System.Drawing.Point(6, 21);
            this.lbTenChuXe.Name = "lbTenChuXe";
            this.lbTenChuXe.Size = new System.Drawing.Size(64, 13);
            this.lbTenChuXe.TabIndex = 20;
            this.lbTenChuXe.Text = "Tên chủ xe:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(97, 147);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
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
            this.txtDienThoai.ReadOnly = true;
            this.txtDienThoai.Size = new System.Drawing.Size(100, 20);
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
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDiaChi.Size = new System.Drawing.Size(212, 44);
            this.txtDiaChi.TabIndex = 15;
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
            // txtMaChuXe
            // 
            this.txtMaChuXe.Location = new System.Drawing.Point(97, 45);
            this.txtMaChuXe.Name = "txtMaChuXe";
            this.txtMaChuXe.ReadOnly = true;
            this.txtMaChuXe.Size = new System.Drawing.Size(100, 20);
            this.txtMaChuXe.TabIndex = 11;
            // 
            // lbMaChuXe
            // 
            this.lbMaChuXe.AutoSize = true;
            this.lbMaChuXe.Location = new System.Drawing.Point(6, 45);
            this.lbMaChuXe.Name = "lbMaChuXe";
            this.lbMaChuXe.Size = new System.Drawing.Size(60, 13);
            this.lbMaChuXe.TabIndex = 10;
            this.lbMaChuXe.Text = "Mã chủ xe:";
            // 
            // btnXemDanhSachXe
            // 
            this.btnXemDanhSachXe.AutoSize = true;
            this.btnXemDanhSachXe.Image = ((System.Drawing.Image)(resources.GetObject("btnXemDanhSachXe.Image")));
            this.btnXemDanhSachXe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemDanhSachXe.Location = new System.Drawing.Point(99, 431);
            this.btnXemDanhSachXe.Name = "btnXemDanhSachXe";
            this.btnXemDanhSachXe.Size = new System.Drawing.Size(175, 30);
            this.btnXemDanhSachXe.TabIndex = 25;
            this.btnXemDanhSachXe.Text = "Xem danh sách khách hàng";
            this.btnXemDanhSachXe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemDanhSachXe.UseVisualStyleBackColor = true;
            this.btnXemDanhSachXe.Click += new System.EventHandler(this.btnXemDanhSachXe_Click);
            // 
            // XeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 473);
            this.Controls.Add(this.btnXemDanhSachXe);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "XeGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý xe";
            this.Load += new System.EventHandler(this.XeGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachXe)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDanhSachXe;
        private System.Windows.Forms.TextBox txtHieuXe;
        private System.Windows.Forms.Label lbHieuXe;
        private System.Windows.Forms.Label lbBienSo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtTimKiemXe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnCapNhatXe;
        private System.Windows.Forms.Button btnThemXe;
        private System.Windows.Forms.Button btnXoaXe;
        private System.Windows.Forms.Button btnLamMoiXe;
        private System.Windows.Forms.Button btnTimKiemXe;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbTenChuXe;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label lbDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.TextBox txtMaChuXe;
        private System.Windows.Forms.Label lbMaChuXe;
        private System.Windows.Forms.ComboBox cbbTenChuXe;
        private System.Windows.Forms.ComboBox cbbTimKiemXe;
        private System.Windows.Forms.CheckBox ckCapNhatBienSo;
        private System.Windows.Forms.TextBox txtBienSoCapNhat;
        private System.Windows.Forms.Label lbBienSoCapNhat;
        private System.Windows.Forms.Button btnXemDanhSachXe;
    }
}