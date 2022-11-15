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

namespace BTLNhom01.Forms.HoaDonBan
{
    public partial class FormThongTinHDB : Form
    {
        DBConfig dbConfig = new DBConfig();
        FormHDB frm;
        Guna2DataGridView dgvfrm;
        public FormThongTinHDB(FormHDB frm, Guna2DataGridView dgvfrm)
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

            string soHDB = dgvfrm.SelectedRows[0].Cells[0].Value.ToString();
            dgv.DataSource = dbConfig.GetTable($"EXEC dbo.SP_ChiTietHDB @SoHDB = {soHDB}");
        }

        private void FormThongTinHDB_Load(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void FormThongTinHDB_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm.Enabled = true;
        }
    }
}
