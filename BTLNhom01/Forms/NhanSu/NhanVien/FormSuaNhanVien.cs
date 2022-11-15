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
    public partial class FormSuaNhanVien : Form
    {
        DBConfig dbConfig = new DBConfig();
        FormNhanVien frm;
        Guna2DataGridView dgv;
        string id;
        public FormSuaNhanVien(FormNhanVien frm, Guna2DataGridView dgv)
        {
            InitializeComponent();
            this.frm = frm;
            this.dgv = dgv;
        }

        void Normalize()
        {
            txtTenNV.Text = txtTenNV.Text.Trim();
            txtDienThoai.Text = txtDienThoai.Text.Trim();
            txtDiaChi.Text = txtDiaChi.Text.Trim();
        }

        void LoadDB()
        {
            id = dgv.SelectedRows[0].Cells[0].Value.ToString();
            txtTenNV.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
            cmbGioiTinh.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
            txtDienThoai.Text = dgv.SelectedRows[0].Cells[5].Value.ToString();
            dtpNgaySinh.Value = DateTime.Parse(dgv.SelectedRows[0].Cells[3].Value.ToString());
            txtDiaChi.Text = dgv.SelectedRows[0].Cells[6].Value.ToString();
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
            if (MessageBox.Show("Xác nhận sửa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dbConfig.Excute($"UPDATE dbo.tNhanVien SET TenNV = N'{txtTenNV.Text}', GioiTinh = '{(cmbGioiTinh.SelectedIndex == 0?0:1)}', NgaySinh = '{dtpNgaySinh.Value}', DienThoai = '{txtDienThoai.Text}', DiaChi = N'{txtDiaChi.Text}' WHERE MaNV = {id}");
                frm.LoadDB();
                MessageBox.Show("Sửa thành công !");
                this.Close();
            }
        }

        public void changeToUpdateForm()
        {
            guna2GroupBox1.Text = "SỬA NHÂN VIÊN";
            btnSave.Text = "Lưu thay đổi";
        }

        private void FormSuaNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm.Enabled = true;
        }

        private void FormSuaNhanVien_Load(object sender, EventArgs e)
        {
            LoadDB();
        }
    }
}
