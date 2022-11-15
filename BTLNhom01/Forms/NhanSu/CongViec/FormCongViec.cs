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
    public partial class FormCongViec : Form
    {
        DBConfig dbConfig = new DBConfig();

        public void LoadDB()
        {
            guna2DataGridView1.DataSource = dbConfig.GetTable("SELECT * FROM dbo.View_DanhSachCongViec");
        }
        public FormCongViec()
        {
            InitializeComponent();
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void FormCongViec_Load(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
