using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BTLNhom01
{
    public partial class FormThemSanPham : Form
    {
        DBConfig dBConfig = new DBConfig();
        FormSanPham parentForm;
        public FormThemSanPham(FormSanPham parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
        }

        void ReadDataIntoComboBox(string tableName, ComboBox cmbName)
        {
            DataTable dt = dBConfig.GetTable("SELECT * " + " FROM " + tableName);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbName.Items.Add(dt.Rows[i][1].ToString());
            }
        }

        void LoadDB()
        {
            List<string> lstTable = new List<string>() { "tLoai", "tKichThuoc", "tCongDung", "tMen", "tHinhKhoi", "tHoaVan", "tMauSac", "tNuocSanXuat" };
            List<ComboBox> lstCombobox = new List<ComboBox>() { cmbLoai, cmbKichThuoc, cmbCongDung, cmbLoaiMen, cmbHinhKhoi, cmbHoaVan, cmbMauSac, cmbNuocSX };
            for (int i = 0; i < lstCombobox.Count; i++)
            {
                ReadDataIntoComboBox(lstTable[i], lstCombobox[i]);

            }
        }

        private void FormThemSanPham_Load(object sender, EventArgs e)
        {
            cmbKichThuoc.Items.Add("Khác");
            LoadDB();
            txtKichThuoc.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string kichThuoc = (cmbKichThuoc.SelectedIndex == 0) ? txtKichThuoc.Text : cmbKichThuoc.Text;
            dBConfig.Excute($"EXEC dbo.SP_ThemSanPham @TenHang = N'{txtTenSP.Text}', @TenLoai = N'{cmbLoai.Text}', @TenKT = N'{kichThuoc}', @TenCD = N'{cmbCongDung.Text}', @TenLoaiMen = N'{cmbLoaiMen.Text}', @TenHK = N'{cmbHinhKhoi.Text}', @TenHV = N'{cmbHoaVan.Text}', @TenMau = N'{cmbMauSac.Text}', @TenNuoc = N'{cmbNuocSX.Text}', @TGBH = '{txtBaoHanh.Text}', @Anh = N'{ptbAnh.ImageLocation}', @GhiChu = N'{txtGhiChu.Text}'");
            parentForm.LoadDB();
        }

        private void ptbAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                ptbAnh.ImageLocation = openFile.FileName;
            }
        }

        private void cmbKichThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKichThuoc.SelectedIndex == 0)
            {
                txtKichThuoc.Visible = true;
            }    
            else
            {
                txtKichThuoc.Hide();
            }    
        }
    }
}
