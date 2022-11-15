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
    public partial class FormThemNhanVien : Form
    {
        DBConfig dbConfig = new DBConfig();
        FormNhanVien frm;
        public FormThemNhanVien(FormNhanVien frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        void Normalize()
        {
            txtTenNV.Text = txtTenNV.Text.Trim();
            txtDienThoai.Text = txtDienThoai.Text.Trim();
            txtDiaChi.Text = txtDiaChi.Text.Trim();
        }

        bool CheckValid()
        {
            Normalize();
            if (txtTenNV.Text.Length == 0)
            {
                MessageBox.Show("Nhập tên nhân viên !");
                txtTenNV.Focus();
                return false;
            }
            if (cmbGioiTinh.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn giới tính !");
                cmbGioiTinh.Focus();
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
            if (dtpNgaySinh.Value.ToShortDateString().Equals(DateTime.Now.ToShortDateString()))
            {
                MessageBox.Show("Chọn ngày sinh !");
                dtpNgaySinh.Focus();
                return false;
            }
            if (txtDiaChi.Text.Length == 0)
            {
                MessageBox.Show("Nhập địa chỉ !");
                txtDiaChi.Focus();
                return false;
            }
            return true;
        }

        void Reset()
        {
            txtTenNV.Clear();
            cmbGioiTinh.SelectedIndex = -1;
            txtDienThoai.Clear();
            dtpNgaySinh.Value = DateTime.Parse("2002/09/23");
            txtDiaChi.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValid())
            {
                return;
            }
            dbConfig.Excute($"INSERT INTO dbo.tNhanVien (TenNV, GioiTinh, NgaySinh, DienThoai, DiaChi, MaCV) VALUES (N'{txtTenNV.Text}', {cmbGioiTinh.SelectedIndex}, '{dtpNgaySinh.Value}', '{txtDienThoai.Text}', N'{txtDiaChi.Text}', '1')");

            frm.LoadDB();
            Reset();
        }

        public void changeToUpdateForm()
        {
            guna2GroupBox1.Text = "SỬA NHÂN VIÊN";
            btnSave.Text = "Lưu thay đổi";
        }

        private void FormThemNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm.Enabled = true;
        }
    }
}
