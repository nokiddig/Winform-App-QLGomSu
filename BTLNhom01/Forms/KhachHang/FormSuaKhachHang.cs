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
    public partial class FormSuaKhachHang : Form
    {
        DBConfig dbConfig = new DBConfig();
        FormKhachHang frm;
        Guna2DataGridView dgv;
        string id;

        public FormSuaKhachHang(FormKhachHang frm, Guna2DataGridView dgv)
        {
            InitializeComponent();
            this.frm = frm;
            this.dgv = dgv;
        }

        void LoadDB()
        {
            id = dgv.SelectedRows[0].Cells[0].Value.ToString();
            txtTenKH.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
            txtDiaChi.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
            txtDienThoai.Text = dgv.SelectedRows[0].Cells[3].Value.ToString();
        }

        void Normalize()
        {
            txtTenKH.Text = txtTenKH.Text.Trim();
            txtDiaChi.Text = txtDiaChi.Text.Trim();
            txtDienThoai.Text = txtDienThoai.Text.Trim();
        }

        bool CheckValid()
        {
            Normalize();
            if (txtTenKH.Text.Length == 0)
            {
                MessageBox.Show("Nhập tên khách hàng !");
                txtTenKH.Focus();
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
                dbConfig.Excute($"UPDATE dbo.tKhachHang SET TenKhach = N'{txtTenKH.Text}', DiaChi = N'{txtDiaChi.Text}', DienThoai = '{txtDienThoai.Text}' WHERE MaKhach = {id}");
                frm.LoadDB();
                MessageBox.Show("Sửa thành công !");
                this.Close();
            }

        }

        public void changeToUpdateForm()
        {
            guna2GroupBox1.Text = "SỬA KHÁCH HÀNG";
            btnSave.Text = "Lưu thay đổi";
        }

        private void FormSuaKhachHang_Load(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void FormSuaKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm.Enabled = true;
        }
    }
}
