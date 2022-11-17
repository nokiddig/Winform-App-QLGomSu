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
    public partial class FormKhachHang : Form
    {
        DBConfig dbConfig = new DBConfig();

        public void LoadDB()
        {
            guna2DataGridView1.DataSource = dbConfig.GetTable("SELECT * FROM tKhachHang");
            if (guna2DataGridView1.Rows.Count == 0)
            {
                btnUpdate.Enabled = btnDelete.Enabled = false;
            }
            else
            {
                btnUpdate.Enabled = btnDelete.Enabled = true;
            }
        }
        public FormKhachHang()
        {
            InitializeComponent();
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormThemKhachHang formThem = new FormThemKhachHang(this);
            formThem.Visible = true;
            this.Enabled = false;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormSuaKhachHang formSua = new FormSuaKhachHang(this, guna2DataGridView1);
            formSua.Visible = true;
            formSua.changeToUpdateForm();
            this.Enabled = false;
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá khách hàng này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string id = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                try
                {
                    dbConfig.Excute($"DELETE FROM tKhachHang WHERE MaKhach = '{id}'");
                    LoadDB();
                    MessageBox.Show("Xoá thành công !");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }

        private Boolean ValidateSearch()
        {
            int choice = cmbChoice.SelectedIndex;
            string input = txtSearch.Text;
            Boolean isNumber = true;
            foreach (Char c in input)
            {
                if (!Char.IsDigit(c))
                {
                    isNumber = false;
                }
            }
            if (choice == 0 && !isNumber)
            {
                MessageBox.Show("Hãy nhập mã khách hàng là một số nguyên!", "Thông báo!");
                return false;
            }
            return true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!ValidateSearch())
            {
                return;
            }
            switch (cmbChoice.SelectedIndex)
            {
                case 0:
                    guna2DataGridView1.DataSource = dbConfig.GetTable($"exec dbo.SP_LietKeThongTinKH @makh = {txtSearch.Text}");
                    break;
                case 1:
                    guna2DataGridView1.DataSource = dbConfig.GetTable($"exec dbo.SP_LietKeThongTinKH @tenkhach = N'{txtSearch.Text}'");
                    break;
                case 2:
                    guna2DataGridView1.DataSource = dbConfig.GetTable($"exec dbo.SP_LietKeThongTinKH @diachi = N'{txtSearch.Text}'");
                    break;
                case 3:
                    guna2DataGridView1.DataSource = dbConfig.GetTable($"exec dbo.SP_LietKeThongTinKH @dienthoai = N'{txtSearch.Text}'");
                    break;
                default:
                    break;
            }

            MessageBox.Show("Đã tìm kiếm được " + guna2DataGridView1.RowCount + " kết quả.", "Thông báo!");
        }
    }
}
