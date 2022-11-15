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
    public partial class FormNhanVien : Form
    {

        DBConfig dbConfig = new DBConfig();

        public void LoadDB()
        {
            guna2DataGridView1.DataSource = dbConfig.GetTable("SELECT * FROM View_DanhSachNhanVien");
        }

        public FormNhanVien()
        {
            InitializeComponent();
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormThemNhanVien them = new FormThemNhanVien(this);
            them.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormSuaNhanVien them = new FormSuaNhanVien(this, guna2DataGridView1);
            them.Visible = true;
            them.changeToUpdateForm();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LoadDB();
            if (AccountInformation.Role.Equals("Member"))
            {
                guna2Panel1.Enabled = false;
            }    
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá nhân viên này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string id = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                if (id == AccountInformation.ID)
                {
                    MessageBox.Show("Bạn không thể xoá nhân viên này vì đây là bạn !");
                    return;
                }    
                try
                {
                    dbConfig.Excute($"DELETE FROM tNhanVien WHERE MaNV = '{id}'");
                    LoadDB();
                    MessageBox.Show("Xoá thành công !");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
