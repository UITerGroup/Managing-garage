namespace QuanLyGaraGUI
{
    partial class CongViecGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CongViecGUI));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbTimKiemCongViec = new System.Windows.Forms.ComboBox();
            this.btnTimKiemCongViec = new System.Windows.Forms.Button();
            this.txtTimKiemCongViec = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaCongViecCapNhat = new System.Windows.Forms.TextBox();
            this.lbMaCongViecCapNhat = new System.Windows.Forms.Label();
            this.lbTienCong = new System.Windows.Forms.Label();
            this.txtNoiDungCongViec = new System.Windows.Forms.TextBox();
            this.lbNoiDungCongViec = new System.Windows.Forms.Label();
            this.txtMaCongViec = new System.Windows.Forms.TextBox();
            this.lbMaCongViec = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgvDanhSachCongViec = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnCapNhatCongViec = new System.Windows.Forms.Button();
            this.btnThemCongViec = new System.Windows.Forms.Button();
            this.btnXoaCongViec = new System.Windows.Forms.Button();
            this.btnLamMoiCongViec = new System.Windows.Forms.Button();
            this.ckCapNhatMaCongViec = new System.Windows.Forms.CheckBox();
            this.nudTienCong = new System.Windows.Forms.NumericUpDown();
            this.btnXemDanhSachCongViec = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachCongViec)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienCong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbTimKiemCongViec);
            this.groupBox1.Controls.Add(this.btnTimKiemCongViec);
            this.groupBox1.Controls.Add(this.txtTimKiemCongViec);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 53);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // cbbTimKiemCongViec
            // 
            this.cbbTimKiemCongViec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimKiemCongViec.FormattingEnabled = true;
            this.cbbTimKiemCongViec.Items.AddRange(new object[] {
            "Mã công việc",
            "Nội dung công việc"});
            this.cbbTimKiemCongViec.Location = new System.Drawing.Point(51, 18);
            this.cbbTimKiemCongViec.Name = "cbbTimKiemCongViec";
            this.cbbTimKiemCongViec.Size = new System.Drawing.Size(131, 21);
            this.cbbTimKiemCongViec.TabIndex = 15;
            // 
            // btnTimKiemCongViec
            // 
            this.btnTimKiemCongViec.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemCongViec.Image")));
            this.btnTimKiemCongViec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemCongViec.Location = new System.Drawing.Point(684, 14);
            this.btnTimKiemCongViec.Name = "btnTimKiemCongViec";
            this.btnTimKiemCongViec.Size = new System.Drawing.Size(80, 28);
            this.btnTimKiemCongViec.TabIndex = 14;
            this.btnTimKiemCongViec.Text = "Tìm kiếm";
            this.btnTimKiemCongViec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemCongViec.UseVisualStyleBackColor = true;
            this.btnTimKiemCongViec.Click += new System.EventHandler(this.btnTimKiemCongViec_Click);
            // 
            // txtTimKiemCongViec
            // 
            this.txtTimKiemCongViec.Location = new System.Drawing.Point(188, 19);
            this.txtTimKiemCongViec.Name = "txtTimKiemCongViec";
            this.txtTimKiemCongViec.Size = new System.Drawing.Size(490, 20);
            this.txtTimKiemCongViec.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudTienCong);
            this.groupBox2.Controls.Add(this.ckCapNhatMaCongViec);
            this.groupBox2.Controls.Add(this.txtMaCongViecCapNhat);
            this.groupBox2.Controls.Add(this.lbMaCongViecCapNhat);
            this.groupBox2.Controls.Add(this.lbTienCong);
            this.groupBox2.Controls.Add(this.txtNoiDungCongViec);
            this.groupBox2.Controls.Add(this.lbNoiDungCongViec);
            this.groupBox2.Controls.Add(this.txtMaCongViec);
            this.groupBox2.Controls.Add(this.lbMaCongViec);
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 178);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin công việc";
            // 
            // txtMaCongViecCapNhat
            // 
            this.txtMaCongViecCapNhat.Enabled = false;
            this.txtMaCongViecCapNhat.Location = new System.Drawing.Point(131, 59);
            this.txtMaCongViecCapNhat.Name = "txtMaCongViecCapNhat";
            this.txtMaCongViecCapNhat.Size = new System.Drawing.Size(100, 20);
            this.txtMaCongViecCapNhat.TabIndex = 17;
            // 
            // lbMaCongViecCapNhat
            // 
            this.lbMaCongViecCapNhat.AutoSize = true;
            this.lbMaCongViecCapNhat.Enabled = false;
            this.lbMaCongViecCapNhat.Location = new System.Drawing.Point(6, 62);
            this.lbMaCongViecCapNhat.Name = "lbMaCongViecCapNhat";
            this.lbMaCongViecCapNhat.Size = new System.Drawing.Size(120, 13);
            this.lbMaCongViecCapNhat.TabIndex = 16;
            this.lbMaCongViecCapNhat.Text = "Mã công việc cập nhật:";
            // 
            // lbTienCong
            // 
            this.lbTienCong.AutoSize = true;
            this.lbTienCong.Location = new System.Drawing.Point(6, 142);
            this.lbTienCong.Name = "lbTienCong";
            this.lbTienCong.Size = new System.Drawing.Size(58, 13);
            this.lbTienCong.TabIndex = 14;
            this.lbTienCong.Text = "Tiền công:";
            // 
            // txtNoiDungCongViec
            // 
            this.txtNoiDungCongViec.Location = new System.Drawing.Point(131, 85);
            this.txtNoiDungCongViec.Multiline = true;
            this.txtNoiDungCongViec.Name = "txtNoiDungCongViec";
            this.txtNoiDungCongViec.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNoiDungCongViec.Size = new System.Drawing.Size(243, 49);
            this.txtNoiDungCongViec.TabIndex = 13;
            // 
            // lbNoiDungCongViec
            // 
            this.lbNoiDungCongViec.AutoSize = true;
            this.lbNoiDungCongViec.Location = new System.Drawing.Point(6, 106);
            this.lbNoiDungCongViec.Name = "lbNoiDungCongViec";
            this.lbNoiDungCongViec.Size = new System.Drawing.Size(53, 13);
            this.lbNoiDungCongViec.TabIndex = 12;
            this.lbNoiDungCongViec.Text = "Nội dung:";
            // 
            // txtMaCongViec
            // 
            this.txtMaCongViec.Location = new System.Drawing.Point(131, 33);
            this.txtMaCongViec.Name = "txtMaCongViec";
            this.txtMaCongViec.Size = new System.Drawing.Size(101, 20);
            this.txtMaCongViec.TabIndex = 11;
            this.txtMaCongViec.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbMaCongViec
            // 
            this.lbMaCongViec.AutoSize = true;
            this.lbMaCongViec.Location = new System.Drawing.Point(6, 36);
            this.lbMaCongViec.Name = "lbMaCongViec";
            this.lbMaCongViec.Size = new System.Drawing.Size(75, 13);
            this.lbMaCongViec.TabIndex = 10;
            this.lbMaCongViec.Text = "Mã công việc:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgvDanhSachCongViec);
            this.groupBox4.Location = new System.Drawing.Point(405, 71);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(426, 297);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách công việc";
            // 
            // dtgvDanhSachCongViec
            // 
            this.dtgvDanhSachCongViec.AllowUserToAddRows = false;
            this.dtgvDanhSachCongViec.AllowUserToResizeColumns = false;
            this.dtgvDanhSachCongViec.AllowUserToResizeRows = false;
            this.dtgvDanhSachCongViec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDanhSachCongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachCongViec.Location = new System.Drawing.Point(6, 19);
            this.dtgvDanhSachCongViec.Name = "dtgvDanhSachCongViec";
            this.dtgvDanhSachCongViec.ReadOnly = true;
            this.dtgvDanhSachCongViec.RowHeadersVisible = false;
            this.dtgvDanhSachCongViec.Size = new System.Drawing.Size(414, 272);
            this.dtgvDanhSachCongViec.TabIndex = 0;
            this.dtgvDanhSachCongViec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSachCongViec_CellClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnCapNhatCongViec);
            this.groupBox6.Controls.Add(this.btnThemCongViec);
            this.groupBox6.Controls.Add(this.btnXoaCongViec);
            this.groupBox6.Controls.Add(this.btnLamMoiCongViec);
            this.groupBox6.Location = new System.Drawing.Point(12, 255);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(387, 62);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thao tác";
            // 
            // btnCapNhatCongViec
            // 
            this.btnCapNhatCongViec.AutoSize = true;
            this.btnCapNhatCongViec.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatCongViec.Image")));
            this.btnCapNhatCongViec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhatCongViec.Location = new System.Drawing.Point(107, 19);
            this.btnCapNhatCongViec.Name = "btnCapNhatCongViec";
            this.btnCapNhatCongViec.Size = new System.Drawing.Size(85, 31);
            this.btnCapNhatCongViec.TabIndex = 14;
            this.btnCapNhatCongViec.Text = "Cập nhật";
            this.btnCapNhatCongViec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhatCongViec.UseVisualStyleBackColor = true;
            this.btnCapNhatCongViec.Click += new System.EventHandler(this.btnCapNhatCongViec_Click);
            // 
            // btnThemCongViec
            // 
            this.btnThemCongViec.AutoSize = true;
            this.btnThemCongViec.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCongViec.Image")));
            this.btnThemCongViec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemCongViec.Location = new System.Drawing.Point(300, 19);
            this.btnThemCongViec.Name = "btnThemCongViec";
            this.btnThemCongViec.Size = new System.Drawing.Size(74, 32);
            this.btnThemCongViec.TabIndex = 12;
            this.btnThemCongViec.Text = "Thêm";
            this.btnThemCongViec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemCongViec.UseVisualStyleBackColor = true;
            this.btnThemCongViec.Click += new System.EventHandler(this.btnThemCongViec_Click);
            // 
            // btnXoaCongViec
            // 
            this.btnXoaCongViec.AutoSize = true;
            this.btnXoaCongViec.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaCongViec.Image")));
            this.btnXoaCongViec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaCongViec.Location = new System.Drawing.Point(210, 19);
            this.btnXoaCongViec.Name = "btnXoaCongViec";
            this.btnXoaCongViec.Size = new System.Drawing.Size(70, 31);
            this.btnXoaCongViec.TabIndex = 13;
            this.btnXoaCongViec.Text = "Xóa";
            this.btnXoaCongViec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaCongViec.UseVisualStyleBackColor = true;
            this.btnXoaCongViec.Click += new System.EventHandler(this.btnXoaCongViec_Click);
            // 
            // btnLamMoiCongViec
            // 
            this.btnLamMoiCongViec.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoiCongViec.Image")));
            this.btnLamMoiCongViec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoiCongViec.Location = new System.Drawing.Point(9, 19);
            this.btnLamMoiCongViec.Name = "btnLamMoiCongViec";
            this.btnLamMoiCongViec.Size = new System.Drawing.Size(79, 31);
            this.btnLamMoiCongViec.TabIndex = 11;
            this.btnLamMoiCongViec.Text = "Làm mới";
            this.btnLamMoiCongViec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoiCongViec.UseVisualStyleBackColor = true;
            this.btnLamMoiCongViec.Click += new System.EventHandler(this.btnLamMoiCongViec_Click);
            // 
            // ckCapNhatMaCongViec
            // 
            this.ckCapNhatMaCongViec.AutoSize = true;
            this.ckCapNhatMaCongViec.Location = new System.Drawing.Point(238, 61);
            this.ckCapNhatMaCongViec.Name = "ckCapNhatMaCongViec";
            this.ckCapNhatMaCongViec.Size = new System.Drawing.Size(136, 17);
            this.ckCapNhatMaCongViec.TabIndex = 18;
            this.ckCapNhatMaCongViec.Text = "Cập nhật mã công việc";
            this.ckCapNhatMaCongViec.UseVisualStyleBackColor = true;
            this.ckCapNhatMaCongViec.CheckedChanged += new System.EventHandler(this.ckCapNhatMaCongViec_CheckedChanged);
            // 
            // nudTienCong
            // 
            this.nudTienCong.Location = new System.Drawing.Point(131, 140);
            this.nudTienCong.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudTienCong.Name = "nudTienCong";
            this.nudTienCong.Size = new System.Drawing.Size(120, 20);
            this.nudTienCong.TabIndex = 19;
            this.nudTienCong.Validating += new System.ComponentModel.CancelEventHandler(this.nudTienCong_Validating);
            // 
            // btnXemDanhSachCongViec
            // 
            this.btnXemDanhSachCongViec.AutoSize = true;
            this.btnXemDanhSachCongViec.Image = ((System.Drawing.Image)(resources.GetObject("btnXemDanhSachCongViec.Image")));
            this.btnXemDanhSachCongViec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemDanhSachCongViec.Location = new System.Drawing.Point(117, 331);
            this.btnXemDanhSachCongViec.Name = "btnXemDanhSachCongViec";
            this.btnXemDanhSachCongViec.Size = new System.Drawing.Size(175, 30);
            this.btnXemDanhSachCongViec.TabIndex = 24;
            this.btnXemDanhSachCongViec.Text = "Xem danh sách công việc";
            this.btnXemDanhSachCongViec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemDanhSachCongViec.UseVisualStyleBackColor = true;
            this.btnXemDanhSachCongViec.Click += new System.EventHandler(this.btnXemDanhSachCongViec_Click);
            // 
            // CongViecGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 373);
            this.Controls.Add(this.btnXemDanhSachCongViec);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Name = "CongViecGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý công việc";
            this.Load += new System.EventHandler(this.CongViecGUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachCongViec)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimKiemCongViec;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbTienCong;
        private System.Windows.Forms.TextBox txtNoiDungCongViec;
        private System.Windows.Forms.Label lbNoiDungCongViec;
        private System.Windows.Forms.TextBox txtMaCongViec;
        private System.Windows.Forms.Label lbMaCongViec;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgvDanhSachCongViec;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnCapNhatCongViec;
        private System.Windows.Forms.Button btnThemCongViec;
        private System.Windows.Forms.Button btnXoaCongViec;
        private System.Windows.Forms.Button btnLamMoiCongViec;
        private System.Windows.Forms.Button btnTimKiemCongViec;
        private System.Windows.Forms.ComboBox cbbTimKiemCongViec;
        private System.Windows.Forms.TextBox txtMaCongViecCapNhat;
        private System.Windows.Forms.Label lbMaCongViecCapNhat;
        private System.Windows.Forms.CheckBox ckCapNhatMaCongViec;
        private System.Windows.Forms.NumericUpDown nudTienCong;
        private System.Windows.Forms.Button btnXemDanhSachCongViec;
    }
}