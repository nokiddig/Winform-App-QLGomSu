using BTLNhom01.Forms.HoaDonBan;
using BTLNhom01.Forms.HoaDonNhap;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLNhom01
{
    public partial class FormHDN : Form
    {
        DBConfig dbConfig = new DBConfig();

        public void LoadDB()
        {
            guna2DataGridView1.DataSource = dbConfig.GetTable("SELECT * FROM dbo.View_DanhSachHoaDonNhap");
        }
        public FormHDN()
        {
            InitializeComponent();
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }

        private void cmbChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChoice.SelectedIndex == 2)
            {
                PanelDateTime.Visible = true;
                PanelTien.Visible = false;
            }
            else if (cmbChoice.SelectedIndex == 4)
            {
                PanelDateTime.Visible = true;
                PanelTien.Visible = true;
            }
            else
            {
                PanelDateTime.Visible = false;
                PanelTien.Visible = false;
            }
        }

        private void FormHDN_Load(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá hoá đơn này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string id = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                try
                {
                    dbConfig.Excute($"DELETE FROM tHoaDonNhap WHERE SoHDN = '{id}'");
                    LoadDB();
                    MessageBox.Show("Xoá thành công !");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormLapHDN formThem = new FormLapHDN(this);
            formThem.Visible = true;
            this.Enabled = false;
        }

        private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            FormThongTinHDN formThongTin = new FormThongTinHDN(this, guna2DataGridView1);
            formThongTin.Visible = true;
            this.Enabled = false;
        }
    }
}
