using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLNhom01.Forms.HoaDonNhap
{
    public partial class FormThongTinHDN : Form
    {
        DBConfig dbConfig = new DBConfig();
        FormHDN frm;
        Guna2DataGridView dgvfrm;
        public FormThongTinHDN(FormHDN frm, Guna2DataGridView dgvfrm)
        {
            InitializeComponent();
            this.frm = frm;
            this.dgvfrm = dgvfrm;
        }

        void LoadDB()
        {
            lblSoHoaDon.Text += dgvfrm.SelectedRows[0].Cells[0].Value.ToString();
            lblNguoiLap.Text += dgvfrm.SelectedRows[0].Cells[1].Value.ToString();
            lblNgayLap.Text += DateTime.Parse(dgvfrm.SelectedRows[0].Cells[2].Value.ToString()).ToShortDateString();
            lblNguoiMua.Text += dgvfrm.SelectedRows[0].Cells[3].Value.ToString();
            lblTongTien.Text += dgvfrm.SelectedRows[0].Cells[4].Value.ToString();

            string soHDN = dgvfrm.SelectedRows[0].Cells[0].Value.ToString();
            dgv.DataSource = dbConfig.GetTable($"EXEC dbo.SP_ChiTietHDN @SoHDN = {soHDN}");
        }

        private void FormThongTinHDN_Load(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void FormThongTinHDN_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm.Enabled = true;
        }
    }
}
