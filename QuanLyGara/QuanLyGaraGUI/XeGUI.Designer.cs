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
            this.dtgvXe = new System.Windows.Forms.DataGridView();
            this.txtMaChuXe = new System.Windows.Forms.TextBox();
            this.lbTenChuXe = new System.Windows.Forms.Label();
            this.lbMaChuXe = new System.Windows.Forms.Label();
            this.txtHieuXe = new System.Windows.Forms.TextBox();
            this.lbHieuXe = new System.Windows.Forms.Label();
            this.lbBienSo = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTimKiemXe = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiemXe = new System.Windows.Forms.Button();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbTenChuXe = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnCapNhatXe = new System.Windows.Forms.Button();
            this.btnThemXe = new System.Windows.Forms.Button();
            this.btnXoaXe = new System.Windows.Forms.Button();
            this.btnLamMoiXe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvXe)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvXe
            // 
            this.dtgvXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvXe.Location = new System.Drawing.Point(6, 19);
            this.dtgvXe.Name = "dtgvXe";
            this.dtgvXe.Size = new System.Drawing.Size(419, 228);
            this.dtgvXe.TabIndex = 0;
            // 
            // txtMaChuXe
            // 
            this.txtMaChuXe.Location = new System.Drawing.Point(97, 148);
            this.txtMaChuXe.Name = "txtMaChuXe";
            this.txtMaChuXe.Size = new System.Drawing.Size(100, 20);
            this.txtMaChuXe.TabIndex = 18;
            // 
            // lbTenChuXe
            // 
            this.lbTenChuXe.AutoSize = true;
            this.lbTenChuXe.Location = new System.Drawing.Point(6, 112);
            this.lbTenChuXe.Name = "lbTenChuXe";
            this.lbTenChuXe.Size = new System.Drawing.Size(64, 13);
            this.lbTenChuXe.TabIndex = 16;
            this.lbTenChuXe.Text = "Tên chủ xe:";
            // 
            // lbMaChuXe
            // 
            this.lbMaChuXe.AutoSize = true;
            this.lbMaChuXe.Location = new System.Drawing.Point(6, 151);
            this.lbMaChuXe.Name = "lbMaChuXe";
            this.lbMaChuXe.Size = new System.Drawing.Size(60, 13);
            this.lbMaChuXe.TabIndex = 14;
            this.lbMaChuXe.Text = "Mã chủ xe:";
            // 
            // txtHieuXe
            // 
            this.txtHieuXe.Location = new System.Drawing.Point(97, 74);
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
            this.lbBienSo.Location = new System.Drawing.Point(6, 36);
            this.lbBienSo.Name = "lbBienSo";
            this.lbBienSo.Size = new System.Drawing.Size(45, 13);
            this.lbBienSo.TabIndex = 10;
            this.lbBienSo.Text = "Biển số:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgvXe);
            this.groupBox4.Location = new System.Drawing.Point(366, 71);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(431, 258);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách xe";
            // 
            // txtTimKiemXe
            // 
            this.txtTimKiemXe.Location = new System.Drawing.Point(62, 21);
            this.txtTimKiemXe.Name = "txtTimKiemXe";
            this.txtTimKiemXe.Size = new System.Drawing.Size(582, 20);
            this.txtTimKiemXe.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiemXe);
            this.groupBox1.Controls.Add(this.txtTimKiemXe);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 53);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btnTimKiemXe
            // 
            this.btnTimKiemXe.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemXe.Image")));
            this.btnTimKiemXe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemXe.Location = new System.Drawing.Point(650, 16);
            this.btnTimKiemXe.Name = "btnTimKiemXe";
            this.btnTimKiemXe.Size = new System.Drawing.Size(80, 28);
            this.btnTimKiemXe.TabIndex = 16;
            this.btnTimKiemXe.Text = "Tìm kiếm";
            this.btnTimKiemXe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemXe.UseVisualStyleBackColor = true;
            // 
            // txtBienSo
            // 
            this.txtBienSo.Location = new System.Drawing.Point(97, 36);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(100, 20);
            this.txtBienSo.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbTenChuXe);
            this.groupBox2.Controls.Add(this.txtMaChuXe);
            this.groupBox2.Controls.Add(this.lbTenChuXe);
            this.groupBox2.Controls.Add(this.lbMaChuXe);
            this.groupBox2.Controls.Add(this.txtHieuXe);
            this.groupBox2.Controls.Add(this.lbHieuXe);
            this.groupBox2.Controls.Add(this.txtBienSo);
            this.groupBox2.Controls.Add(this.lbBienSo);
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 190);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin xe";
            // 
            // cbbTenChuXe
            // 
            this.cbbTenChuXe.FormattingEnabled = true;
            this.cbbTenChuXe.Location = new System.Drawing.Point(97, 109);
            this.cbbTenChuXe.Name = "cbbTenChuXe";
            this.cbbTenChuXe.Size = new System.Drawing.Size(241, 21);
            this.cbbTenChuXe.TabIndex = 17;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnCapNhatXe);
            this.groupBox6.Controls.Add(this.btnThemXe);
            this.groupBox6.Controls.Add(this.btnXoaXe);
            this.groupBox6.Controls.Add(this.btnLamMoiXe);
            this.groupBox6.Location = new System.Drawing.Point(12, 267);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(348, 62);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thao tác";
            // 
            // btnCapNhatXe
            // 
            this.btnCapNhatXe.AutoSize = true;
            this.btnCapNhatXe.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatXe.Image")));
            this.btnCapNhatXe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhatXe.Location = new System.Drawing.Point(97, 19);
            this.btnCapNhatXe.Name = "btnCapNhatXe";
            this.btnCapNhatXe.Size = new System.Drawing.Size(85, 31);
            this.btnCapNhatXe.TabIndex = 15;
            this.btnCapNhatXe.Text = "Cập nhật";
            this.btnCapNhatXe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhatXe.UseVisualStyleBackColor = true;
            // 
            // btnThemXe
            // 
            this.btnThemXe.AutoSize = true;
            this.btnThemXe.Image = ((System.Drawing.Image)(resources.GetObject("btnThemXe.Image")));
            this.btnThemXe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemXe.Location = new System.Drawing.Point(264, 19);
            this.btnThemXe.Name = "btnThemXe";
            this.btnThemXe.Size = new System.Drawing.Size(74, 32);
            this.btnThemXe.TabIndex = 12;
            this.btnThemXe.Text = "Thêm";
            this.btnThemXe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemXe.UseVisualStyleBackColor = true;
            // 
            // btnXoaXe
            // 
            this.btnXoaXe.AutoSize = true;
            this.btnXoaXe.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaXe.Image")));
            this.btnXoaXe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaXe.Location = new System.Drawing.Point(188, 19);
            this.btnXoaXe.Name = "btnXoaXe";
            this.btnXoaXe.Size = new System.Drawing.Size(70, 31);
            this.btnXoaXe.TabIndex = 13;
            this.btnXoaXe.Text = "Xóa";
            this.btnXoaXe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaXe.UseVisualStyleBackColor = true;
            // 
            // btnLamMoiXe
            // 
            this.btnLamMoiXe.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoiXe.Image")));
            this.btnLamMoiXe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoiXe.Location = new System.Drawing.Point(9, 19);
            this.btnLamMoiXe.Name = "btnLamMoiXe";
            this.btnLamMoiXe.Size = new System.Drawing.Size(79, 31);
            this.btnLamMoiXe.TabIndex = 11;
            this.btnLamMoiXe.Text = "Làm mới";
            this.btnLamMoiXe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoiXe.UseVisualStyleBackColor = true;
            // 
            // XeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 338);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "XeGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý xe";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvXe)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvXe;
        private System.Windows.Forms.TextBox txtMaChuXe;
        private System.Windows.Forms.Label lbTenChuXe;
        private System.Windows.Forms.Label lbMaChuXe;
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
        private System.Windows.Forms.ComboBox cbbTenChuXe;
    }
}