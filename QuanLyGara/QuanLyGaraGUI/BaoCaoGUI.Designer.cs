namespace QuanLyGaraGUI
{
    partial class BaoCaoGUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoCaoGUI));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BaoCaoDoanhThuQuyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetQuanLyGara = new QuanLyGaraGUI.dataSetQuanLyGara();
            this.BaoCaoDoanhThuThangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rbtnThang = new System.Windows.Forms.RadioButton();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.lbNam_Thang = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nmudNam = new System.Windows.Forms.NumericUpDown();
            this.nmudNam_Quy = new System.Windows.Forms.NumericUpDown();
            this.lbNam_Quy = new System.Windows.Forms.Label();
            this.nmudNam_Thang = new System.Windows.Forms.NumericUpDown();
            this.cbbQuy = new System.Windows.Forms.ComboBox();
            this.rbtnQuy = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rpvBaoCaoDoanhThu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BaoCaoDoanhThuNamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BaoCaoDoanhThuNam = new QuanLyGaraGUI.dataSetQuanLyGaraTableAdapters.BaoCaoDoanhThuNam();
            this.BaoCaoDoanhThuThang = new QuanLyGaraGUI.dataSetQuanLyGaraTableAdapters.BaoCaoDoanhThuThang();
            this.BaoCaoDoanhThuQuy = new QuanLyGaraGUI.dataSetQuanLyGaraTableAdapters.BaoCaoDoanhThuQuy();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoDoanhThuQuyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuanLyGara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoDoanhThuThangBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudNam_Quy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudNam_Thang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoDoanhThuNamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BaoCaoDoanhThuQuyBindingSource
            // 
            this.BaoCaoDoanhThuQuyBindingSource.DataMember = "BaoCaoDoanhThuQuy";
            this.BaoCaoDoanhThuQuyBindingSource.DataSource = this.dataSetQuanLyGara;
            // 
            // dataSetQuanLyGara
            // 
            this.dataSetQuanLyGara.DataSetName = "dataSetQuanLyGara";
            this.dataSetQuanLyGara.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BaoCaoDoanhThuThangBindingSource
            // 
            this.BaoCaoDoanhThuThangBindingSource.DataMember = "BaoCaoDoanhThuThang";
            this.BaoCaoDoanhThuThangBindingSource.DataSource = this.dataSetQuanLyGara;
            // 
            // rbtnThang
            // 
            this.rbtnThang.AutoSize = true;
            this.rbtnThang.Location = new System.Drawing.Point(21, 27);
            this.rbtnThang.Name = "rbtnThang";
            this.rbtnThang.Size = new System.Drawing.Size(59, 17);
            this.rbtnThang.TabIndex = 0;
            this.rbtnThang.TabStop = true;
            this.rbtnThang.Text = "Tháng:";
            this.rbtnThang.UseVisualStyleBackColor = true;
            this.rbtnThang.CheckedChanged += new System.EventHandler(this.rbtnThang_CheckedChanged);
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Location = new System.Drawing.Point(21, 81);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(50, 17);
            this.rbtnNam.TabIndex = 2;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Năm:";
            this.rbtnNam.UseVisualStyleBackColor = true;
            this.rbtnNam.CheckedChanged += new System.EventHandler(this.rbtnNam_CheckedChanged);
            // 
            // cbbThang
            // 
            this.cbbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbbThang.Location = new System.Drawing.Point(83, 27);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(44, 21);
            this.cbbThang.TabIndex = 7;
            this.cbbThang.Visible = false;
            // 
            // lbNam_Thang
            // 
            this.lbNam_Thang.AutoSize = true;
            this.lbNam_Thang.Location = new System.Drawing.Point(133, 29);
            this.lbNam_Thang.Name = "lbNam_Thang";
            this.lbNam_Thang.Size = new System.Drawing.Size(32, 13);
            this.lbNam_Thang.TabIndex = 6;
            this.lbNam_Thang.Text = "Năm:";
            this.lbNam_Thang.Visible = false;
            // 
            // btnXem
            // 
            this.btnXem.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.Image")));
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.Location = new System.Drawing.Point(297, 104);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(107, 31);
            this.btnXem.TabIndex = 23;
            this.btnXem.Text = "Xem báo cáo";
            this.btnXem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnThang);
            this.groupBox1.Controls.Add(this.nmudNam);
            this.groupBox1.Controls.Add(this.cbbThang);
            this.groupBox1.Controls.Add(this.nmudNam_Quy);
            this.groupBox1.Controls.Add(this.lbNam_Thang);
            this.groupBox1.Controls.Add(this.lbNam_Quy);
            this.groupBox1.Controls.Add(this.rbtnNam);
            this.groupBox1.Controls.Add(this.nmudNam_Thang);
            this.groupBox1.Controls.Add(this.cbbQuy);
            this.groupBox1.Controls.Add(this.rbtnQuy);
            this.groupBox1.Location = new System.Drawing.Point(45, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 109);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn thời gian";
            // 
            // nmudNam
            // 
            this.nmudNam.Location = new System.Drawing.Point(83, 81);
            this.nmudNam.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nmudNam.Name = "nmudNam";
            this.nmudNam.Size = new System.Drawing.Size(64, 20);
            this.nmudNam.TabIndex = 13;
            this.nmudNam.Visible = false;
            // 
            // nmudNam_Quy
            // 
            this.nmudNam_Quy.Location = new System.Drawing.Point(168, 54);
            this.nmudNam_Quy.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nmudNam_Quy.Name = "nmudNam_Quy";
            this.nmudNam_Quy.Size = new System.Drawing.Size(60, 20);
            this.nmudNam_Quy.TabIndex = 12;
            this.nmudNam_Quy.Visible = false;
            // 
            // lbNam_Quy
            // 
            this.lbNam_Quy.AutoSize = true;
            this.lbNam_Quy.Location = new System.Drawing.Point(133, 57);
            this.lbNam_Quy.Name = "lbNam_Quy";
            this.lbNam_Quy.Size = new System.Drawing.Size(32, 13);
            this.lbNam_Quy.TabIndex = 11;
            this.lbNam_Quy.Text = "Năm:";
            this.lbNam_Quy.Visible = false;
            // 
            // nmudNam_Thang
            // 
            this.nmudNam_Thang.Location = new System.Drawing.Point(168, 28);
            this.nmudNam_Thang.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nmudNam_Thang.Name = "nmudNam_Thang";
            this.nmudNam_Thang.Size = new System.Drawing.Size(60, 20);
            this.nmudNam_Thang.TabIndex = 10;
            this.nmudNam_Thang.Visible = false;
            // 
            // cbbQuy
            // 
            this.cbbQuy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbQuy.FormattingEnabled = true;
            this.cbbQuy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbbQuy.Location = new System.Drawing.Point(83, 54);
            this.cbbQuy.Name = "cbbQuy";
            this.cbbQuy.Size = new System.Drawing.Size(44, 21);
            this.cbbQuy.TabIndex = 8;
            this.cbbQuy.Visible = false;
            // 
            // rbtnQuy
            // 
            this.rbtnQuy.AutoSize = true;
            this.rbtnQuy.Location = new System.Drawing.Point(21, 55);
            this.rbtnQuy.Name = "rbtnQuy";
            this.rbtnQuy.Size = new System.Drawing.Size(47, 17);
            this.rbtnQuy.TabIndex = 1;
            this.rbtnQuy.TabStop = true;
            this.rbtnQuy.Text = "Qúy:";
            this.rbtnQuy.UseVisualStyleBackColor = true;
            this.rbtnQuy.CheckedChanged += new System.EventHandler(this.rbtnQuy_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(263, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "BÁO CÁO DOANH THU";
            // 
            // rpvBaoCaoDoanhThu
            // 
            reportDataSource1.Name = "BaoCaoDoanhThuQuy";
            reportDataSource1.Value = this.BaoCaoDoanhThuQuyBindingSource;
            this.rpvBaoCaoDoanhThu.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvBaoCaoDoanhThu.LocalReport.ReportEmbeddedResource = "QuanLyGaraGUI.BaoCaoDoanhThuQuy.rdlc";
            this.rpvBaoCaoDoanhThu.Location = new System.Drawing.Point(12, 152);
            this.rpvBaoCaoDoanhThu.Name = "rpvBaoCaoDoanhThu";
            this.rpvBaoCaoDoanhThu.Size = new System.Drawing.Size(703, 360);
            this.rpvBaoCaoDoanhThu.TabIndex = 27;
            // 
            // BaoCaoDoanhThuNamBindingSource
            // 
            this.BaoCaoDoanhThuNamBindingSource.DataMember = "BaoCaoDoanhThuNam";
            this.BaoCaoDoanhThuNamBindingSource.DataSource = this.dataSetQuanLyGara;
            // 
            // BaoCaoDoanhThuNam
            // 
            this.BaoCaoDoanhThuNam.ClearBeforeFill = true;
            // 
            // BaoCaoDoanhThuThang
            // 
            this.BaoCaoDoanhThuThang.ClearBeforeFill = true;
            // 
            // BaoCaoDoanhThuQuy
            // 
            this.BaoCaoDoanhThuQuy.ClearBeforeFill = true;
            // 
            // BaoCaoGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 524);
            this.Controls.Add(this.rpvBaoCaoDoanhThu);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "BaoCaoGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.BaoCaoGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoDoanhThuQuyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuanLyGara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoDoanhThuThangBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudNam_Quy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudNam_Thang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoDoanhThuNamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnThang;
        private System.Windows.Forms.RadioButton rbtnNam;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.Label lbNam_Thang;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nmudNam;
        private System.Windows.Forms.NumericUpDown nmudNam_Quy;
        private System.Windows.Forms.Label lbNam_Quy;
        private System.Windows.Forms.NumericUpDown nmudNam_Thang;
        private System.Windows.Forms.ComboBox cbbQuy;
        private System.Windows.Forms.RadioButton rbtnQuy;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvBaoCaoDoanhThu;
        private System.Windows.Forms.BindingSource BaoCaoDoanhThuNamBindingSource;
        private dataSetQuanLyGara dataSetQuanLyGara;
        private dataSetQuanLyGaraTableAdapters.BaoCaoDoanhThuNam BaoCaoDoanhThuNam;
        private System.Windows.Forms.BindingSource BaoCaoDoanhThuThangBindingSource;
        private dataSetQuanLyGaraTableAdapters.BaoCaoDoanhThuThang BaoCaoDoanhThuThang;
        private System.Windows.Forms.BindingSource BaoCaoDoanhThuQuyBindingSource;
        private dataSetQuanLyGaraTableAdapters.BaoCaoDoanhThuQuy BaoCaoDoanhThuQuy;
    }
}