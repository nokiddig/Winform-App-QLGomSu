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

namespace BTLNhom01
{
    public partial class FormSuaNhaCungCap : Form
    {
        DBConfig dbConfig = new DBConfig();
        FormNhaCungCap frm;
        Guna2DataGridView dgv;
        string id;
        
        public FormSuaNhaCungCap(FormNhaCungCap frm, Guna2DataGridView dgv)
        {
            InitializeComponent();
            this.frm = frm;
            this.dgv = dgv;
        }

        void LoadDB()
        {
            id = dgv.SelectedRows[0].Cells[0].Value.ToString();
            txtTenNCC.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
            txtDiaChi.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
            txtDienThoai.Text = dgv.SelectedRows[0].Cells[3].Value.ToString();
        }    

        void Normalize()
        {
            txtTenNCC.Text = txtTenNCC.Text.Trim();
            txtDiaChi.Text = txtDiaChi.Text.Trim();
            txtDienThoai.Text = txtDienThoai.Text.Trim();
        }

        bool CheckValid()
        {
            Normalize();
            if (txtTenNCC.Text.Length == 0)
            {
                MessageBox.Show("Nhập tên nhà cung cấp !");
                txtTenNCC.Focus();
                return false;
            }
            if (txtDiaChi.Text.Length == 0)
            {
                MessageBox.Show("Nhập địa chỉ !");
                txtDiaChi.Focus();
                return false;
            }
            if (txtDienThoai.Text.Length == 0)
            {
                MessageBox.Show("Nhập số điện thoại !");
                txtDienThoai.Focus();
                return false;
            }
            if (!txtDienThoai.Text.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại sai định dạng !");
                txtDienThoai.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValid())
            {
                return;
            }

            if (MessageBox.Show("Xác nhận sửa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dbConfig.Excute($"UPDATE dbo.tNhaCungCap SET TenNCC = N'{txtTenNCC.Text}', DiaChi = N'{txtDiaChi.Text}', DienThoai = '{txtDienThoai.Text}' WHERE MaNCC = {id}");
                frm.LoadDB();
                this.Close();
                MessageBox.Show("Sửa thành công !");
            }
        }

        public void changeToUpdateForm()
        {
            guna2GroupBox1.Text = "SỬA NHÀ CUNG CẤP";
            btnSave.Text = "Lưu thay đổi";
        }

        private void FormSuaNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void FormSuaNhaCungCap_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm.Enabled = true;
        }
    }
}
