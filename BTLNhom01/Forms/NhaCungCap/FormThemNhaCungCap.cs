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
    public partial class FormThemNhaCungCap : Form
    {
        DBConfig dbConfig = new DBConfig();
        FormNhaCungCap frm;
        public FormThemNhaCungCap(FormNhaCungCap frm)
        {
            InitializeComponent();
            this.frm = frm;
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

        void Reset()
        {
            txtTenNCC.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValid())
            {
                return;
            }
            dbConfig.Excute($"INSERT INTO dbo.tNhaCungCap (TenNCC, DiaChi, DienThoai) VALUES (N'{txtTenNCC.Text}', N'{txtDiaChi.Text}', '{txtDienThoai.Text}')");

            frm.LoadDB();
            Reset();
        }

        public void changeToUpdateForm()
        {
            guna2GroupBox1.Text = "THÊM NHÀ CUNG CẤP";
            btnSave.Text = "Lưu thay đổi";
        }

        private void FormThemNhaCungCap_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm.Enabled = true;
        }

        private void FormThemNhaCungCap_Load(object sender, EventArgs e)
        {

        }
    }
}
