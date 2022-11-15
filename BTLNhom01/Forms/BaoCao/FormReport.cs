using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace BTLNhom01.Forms.BaoCao
{
    public partial class FormReport : Form
    {

        DBConfig dbConfig = new DBConfig();
        public FormReport(string reportViewerLocal, string reportDataSourceValue)
        {
            InitializeComponent();
            try
            {
                this.reportViewer1.LocalReport.ReportEmbeddedResource = reportViewerLocal;
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name =  "DataSet1";
                reportDataSource.Value = dbConfig.GetTable(reportDataSourceValue);
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*private void FormReport_Load(object sender, EventArgs e)
        {
            try
            {
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "BTLNhom01.Forms.BaoCao.ReportHTK.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1";
                reportDataSource.Value = dbConfig.GetTable("select * from [dbo].[View_DanhSachCongDung]");
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/
    }
}
