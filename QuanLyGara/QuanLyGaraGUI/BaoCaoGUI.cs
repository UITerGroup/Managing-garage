using Microsoft.Reporting.WinForms;
using QuanLyGaraBUS;
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
    public partial class BaoCaoGUI : Form
    {
        BaoCaoBUS bcBUS = new BaoCaoBUS();

        public BaoCaoGUI()
        {
            InitializeComponent();
        }

        private void BaoCaoGUI_Load(object sender, EventArgs e)
        {
            rbtnThang.Checked = true;

            cbbThang.SelectedIndex = 0;
            cbbQuy.SelectedIndex = 0;

            int Nam = DateTime.Now.Year;

            nmudNam_Thang.Value = Nam;
            nmudNam_Quy.Value = Nam;
            nmudNam.Value = Nam;
            
        }

        private void rbtnThang_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnThang.Checked)
            {
                cbbThang.Visible = true;
                lbNam_Thang.Visible = true;
                nmudNam_Thang.Visible = true;
            }
            else
            {
                cbbThang.Visible = false;
                lbNam_Thang.Visible = false;
                nmudNam_Thang.Visible = false;
            }
        }

        private void rbtnQuy_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnQuy.Checked)
            {
                cbbQuy.Visible = true;
                lbNam_Quy.Visible = true;
                nmudNam_Quy.Visible = true;
            }
            else
            {
                cbbQuy.Visible = false;
                lbNam_Quy.Visible = false;
                nmudNam_Quy.Visible = false;
            }
        }

        private void rbtnNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNam.Checked)
            {
                nmudNam.Visible = true;
            }
            else
            {
                nmudNam.Visible = false;
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (rbtnThang.Checked && cbbThang.Text != "" && nmudNam_Thang.Text != "")
            {

                string Thang = cbbThang.Text;
                string Nam = nmudNam_Thang.Text;

                dataSetQuanLyGaraTableAdapters.BaoCaoDoanhThuThang bcDoanhThuThang = new dataSetQuanLyGaraTableAdapters.BaoCaoDoanhThuThang();
                dataSetQuanLyGara.BaoCaoDoanhThuThangDataTable ds = bcDoanhThuThang.GetData(Convert.ToInt32(Thang), Convert.ToInt32(Nam));
                if (ds.Rows.Count > 0)
                {
                    ReportDataSource rpds = new ReportDataSource("BaoCaoDoanhThuThang", ds.AsEnumerable().CopyToDataTable());
                    rpvBaoCaoDoanhThu.LocalReport.DataSources.Clear();
                    rpvBaoCaoDoanhThu.LocalReport.ReportPath = "BaoCaoDoanhThuThang.rdlc";
                    rpvBaoCaoDoanhThu.LocalReport.DataSources.Add(rpds);

                    ReportParameter[] listPara = new ReportParameter[2];
                    listPara[0] = new ReportParameter("Thang");
                    listPara[0].Values.Add(Thang);
                    listPara[1] = new ReportParameter("Nam");
                    listPara[1].Values.Add(Nam);
                    rpvBaoCaoDoanhThu.LocalReport.SetParameters(listPara);

                    rpvBaoCaoDoanhThu.RefreshReport();
                }
                else
                {
                    rpvBaoCaoDoanhThu.Reset();
                    MessageBox.Show("Không có dữ liệu !");
                }
            }

            else if (rbtnQuy.Checked && cbbQuy.Text != "" && nmudNam_Quy.Text != "")
            {
                string Quy = cbbQuy.Text;
                string Nam = nmudNam_Quy.Text;

                string ThangBatDau = "";
                string ThangKetThuc = "";
                switch (Quy)
                {
                    case "1":
                        ThangBatDau = "1";
                        ThangKetThuc = "3";
                        break;
                    case "2":
                        ThangBatDau = "4";
                        ThangKetThuc = "6";
                        break;
                    case "3":
                        ThangBatDau = "7";
                        ThangKetThuc = "9";
                        break;
                    case "4":
                        ThangBatDau = "10";
                        ThangKetThuc = "12";
                        break;
                }
                dataSetQuanLyGaraTableAdapters.BaoCaoDoanhThuQuy bcDoanhThuQuy = new dataSetQuanLyGaraTableAdapters.BaoCaoDoanhThuQuy();
                dataSetQuanLyGara.BaoCaoDoanhThuQuyDataTable ds = bcDoanhThuQuy.GetData(Convert.ToInt32(ThangBatDau), Convert.ToInt32(ThangKetThuc), Convert.ToInt32(Nam));
                if (ds.Rows.Count > 0)
                {
                    ReportDataSource rpds = new ReportDataSource("BaoCaoDoanhThuQuy", ds.AsEnumerable().CopyToDataTable());
                    rpvBaoCaoDoanhThu.LocalReport.DataSources.Clear();
                    rpvBaoCaoDoanhThu.LocalReport.ReportPath = "BaoCaoDoanhThuQuy.rdlc";
                    rpvBaoCaoDoanhThu.LocalReport.DataSources.Add(rpds);

                    ReportParameter[] listPara = new ReportParameter[2];
                    listPara[0] = new ReportParameter("Quy");
                    listPara[0].Values.Add(Quy);
                    listPara[1] = new ReportParameter("Nam");
                    listPara[1].Values.Add(Nam);
                    rpvBaoCaoDoanhThu.LocalReport.SetParameters(listPara);

                    rpvBaoCaoDoanhThu.RefreshReport();
                }
                else
                {
                    rpvBaoCaoDoanhThu.Reset();
                    MessageBox.Show("Không có dữ liệu !");
                }


            }

            else if (rbtnNam.Checked && nmudNam.Text != "")
            {
                string Nam = nmudNam.Text;

                dataSetQuanLyGaraTableAdapters.BaoCaoDoanhThuNam bcDoanhThuNam = new dataSetQuanLyGaraTableAdapters.BaoCaoDoanhThuNam();
                dataSetQuanLyGara.BaoCaoDoanhThuNamDataTable ds = bcDoanhThuNam.GetData(Convert.ToInt32(Nam));
                if (ds.Rows.Count > 0)
                {
                    ReportDataSource rpds = new ReportDataSource("BaoCaoDoanhThuNam", ds.AsEnumerable().CopyToDataTable());
                    rpvBaoCaoDoanhThu.LocalReport.DataSources.Clear();
                    rpvBaoCaoDoanhThu.LocalReport.ReportPath = "BaoCaoDoanhThuNam.rdlc";
                    rpvBaoCaoDoanhThu.LocalReport.DataSources.Add(rpds);

                    ReportParameter[] listPara = new ReportParameter[1];
                    listPara[0] = new ReportParameter("Nam");
                    listPara[0].Values.Add(Nam);
                    rpvBaoCaoDoanhThu.LocalReport.SetParameters(listPara);

                    rpvBaoCaoDoanhThu.RefreshReport();
                }
                else
                {
                    rpvBaoCaoDoanhThu.Reset();
                    MessageBox.Show("Không có dữ liệu !");
                }

            }

            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin !");
            }

        }

        private void load_datagridview()
        {
            //if (rbtnThang.Checked && cbbThang.Text != "" && nmudNam_Thang.Text != "")
            //{
            //    int Thang = Convert.ToInt32(cbbThang.Text);
            //    int Nam = Convert.ToInt32(nmudNam_Thang.Text);
            //    dtgvBaoCaoDoanhThu.DataSource = bcBUS.baoCaoDoanhThu_TheoThang(Thang, Nam);

            //    int DoanhThu = 0;
            //    if (dtgvBaoCaoDoanhThu.RowCount > 0)
            //    {
            //        for (int i = 0; i < dtgvBaoCaoDoanhThu.RowCount; i++)
            //        {
            //            DoanhThu += Convert.ToInt32(dtgvBaoCaoDoanhThu.Rows[i].Cells[4].Value);
            //        }

            //        txtTongDoanhThu.Text = DoanhThu.ToString();
            //    }

            //    else
            //    {
            //        dtgvBaoCaoDoanhThu.DataSource = null;
            //        txtTongDoanhThu.Text = "";
            //        MessageBox.Show("Không tìm thấy!");
            //    }
            //}
            //else if (rbtnQuy.Checked && cbbQuy.Text != "" && nmudNam_Quy.Text != "")
            //{
            //    int Quy = Convert.ToInt32(cbbQuy.Text);
            //    int Nam = Convert.ToInt32(nmudNam_Thang.Text);

            //    int ThangBatDau = 0;
            //    int ThangKetThuc = 0;
            //    switch (Quy)
            //    {
            //        case 1:
            //            ThangBatDau = 1;
            //            ThangKetThuc = 3;
            //            break;
            //        case 2:
            //            ThangBatDau = 4;
            //            ThangKetThuc = 6;
            //            break;
            //        case 3:
            //            ThangBatDau = 7;
            //            ThangKetThuc = 9;
            //            break;
            //        case 4:
            //            ThangBatDau = 10;
            //            ThangKetThuc = 12;
            //            break;
            //    }

            //    dtgvBaoCaoDoanhThu.DataSource = bcBUS.baoCaoDoanhThu_TheoQuy(ThangBatDau, ThangKetThuc, Nam);

            //    int DoanhThu = 0;
            //    if (dtgvBaoCaoDoanhThu.RowCount > 0)
            //    {
            //        for (int i = 0; i < dtgvBaoCaoDoanhThu.RowCount; i++)
            //        {
            //            DoanhThu += Convert.ToInt32(dtgvBaoCaoDoanhThu.Rows[i].Cells[4].Value);
            //        }

            //        txtTongDoanhThu.Text = DoanhThu.ToString();
            //    }

            //    else
            //    {
            //        dtgvBaoCaoDoanhThu.DataSource = null;
            //        txtTongDoanhThu.Text = "";
            //        MessageBox.Show("Không tìm thấy!");
            //    }
            //}

            //else if (rbtnNam.Checked && nmudNam.Text != "")
            //{
            //    int Nam = Convert.ToInt32(nmudNam.Text);
            //    dtgvBaoCaoDoanhThu.DataSource = bcBUS.baoCaoDoanhThu_TheoNam(Nam);

            //    int DoanhThu = 0;
            //    if (dtgvBaoCaoDoanhThu.RowCount > 0)
            //    {
            //        for (int i = 0; i < dtgvBaoCaoDoanhThu.RowCount; i++)
            //        {
            //            DoanhThu += Convert.ToInt32(dtgvBaoCaoDoanhThu.Rows[i].Cells[4].Value);
            //        }

            //        txtTongDoanhThu.Text = DoanhThu.ToString();
            //    }

            //    else
            //    {
            //        dtgvBaoCaoDoanhThu.DataSource = null;
            //        txtTongDoanhThu.Text = "";
            //        MessageBox.Show("Không tìm thấy!");
            //    }
            //}

            //else
            //{
            //    MessageBox.Show("Hãy nhập đầy đủ thông tin !");
            //}
        }
    }
}
