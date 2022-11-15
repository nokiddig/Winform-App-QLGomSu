using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLNhom01.Forms.HoaDonNhap
{
    public partial class FormLapHDN : Form
    {
        DBConfig dbConfig = new DBConfig();
        FormHDN frm;
        List<string> LstMaHang = new List<string>();
        double tongTien = 0;

        public FormLapHDN(FormHDN frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        void ReadDataIntoComboBox(string tableName, ComboBox cmbName)
        {
            DataTable dt = dbConfig.GetTable("SELECT * " + " FROM " + tableName);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (tableName == "tHangHoa")
                {
                    LstMaHang.Add(dt.Rows[i][0].ToString());
                }
                cmbName.Items.Add(dt.Rows[i][1].ToString());

            }
        }

        void LoadDB()
        {
            List<string> lstTable = new List<string>() { "tNhaCungCap", "tHangHoa" };
            List<ComboBox> lstCombobox = new List<ComboBox>() { cmbNhaCungCap, cmbHangHoa };
            for (int i = 0; i < lstCombobox.Count; i++)
            {
                ReadDataIntoComboBox(lstTable[i], lstCombobox[i]);

            }
        }

        void Normalize()
        {
            txtGiamGia.Text = txtGiamGia.Text.Trim();
            txtSoLuong.Text = txtSoLuong.Text.Trim();
        }

        bool CheckValid()
        {
            Normalize();
            if (cmbNhaCungCap.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn nhà cung cấp !");
                cmbNhaCungCap.Focus();
                return false;
            }
            if (cmbHangHoa.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn sản phẩm !");
                cmbHangHoa.Focus();
                return false;
            }
            if (txtSoLuong.Text.Length == 0)
            {
                MessageBox.Show("Nhập số lượng sản phẩm !");
                txtSoLuong.Focus();
                return false;
            }
            if (!txtSoLuong.Text.All(char.IsDigit))
            {
                MessageBox.Show("Số lượng sản phẩm sai định dạng !");
                txtSoLuong.Focus();
                return false;
            }
            if (txtDonGia.Text.Length == 0)
            {
                MessageBox.Show("Nhập đơn giá sản phẩm !");
                txtDonGia.Focus();
                return false;
            }
            if (txtDonGia.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Đơn giá sai định dạng !");
                txtDonGia.Focus();
                return false;
            }
            if (txtGiamGia.Text.Length == 0)
            {
                MessageBox.Show("Nhập % giảm giá !");
                txtGiamGia.Focus();
                return false;
            }
            if (txtGiamGia.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Số % giảm giá sai định dạng !");
                txtSoLuong.Focus();
                return false;
            }
            int num = int.Parse(txtGiamGia.Text);
            if (num < 0 || num > 100)
            {
                MessageBox.Show("% giảm giá phải từ 0% đến 100%");
                txtGiamGia.Focus();
                return false;
            }
            return true;
        }

        private void FormLapHDN_Load(object sender, EventArgs e)
        {
            LoadDB();
            lblNguoiLap.Text += AccountInformation.FullName;
            lblNgayLap.Text += DateTime.Now.ToShortDateString();
            lblTongTien.Text += tongTien;
        }

        void MoveItemFromComboBoxToTable()
        {
            // Thêm vào table
            int index = dgv.Rows.Add();
            string maHang = LstMaHang[cmbHangHoa.SelectedIndex];
            double donGia = double.Parse(txtDonGia.Text);
            int soLuong = int.Parse(txtSoLuong.Text);
            double giamGia = double.Parse(txtGiamGia.Text) / 100;
            double thanhTien = (donGia * (1 - giamGia))*soLuong;
            tongTien += thanhTien;

            dgv.Rows[index].Cells[0].Value = maHang;    
            dgv.Rows[index].Cells[1].Value = cmbHangHoa.Text;
            dgv.Rows[index].Cells[2].Value = soLuong;
            dgv.Rows[index].Cells[3].Value = donGia;
            dgv.Rows[index].Cells[4].Value = giamGia;
            dgv.Rows[index].Cells[5].Value = thanhTien;

            // Xoá item ở combobox
            LstMaHang.RemoveAt(cmbHangHoa.SelectedIndex);
            cmbHangHoa.Items.RemoveAt(cmbHangHoa.SelectedIndex);
        }

        void ResetInformation()
        {
            // Ẩn combobox chọn nhà cung cấp
            cmbNhaCungCap.Enabled = false;
            // Reset để thêm item mới
            cmbHangHoa.SelectedIndex = -1;
            txtSoLuong.Clear();
            txtGiamGia.Clear();
        }



        private void btnThemVaoDS_Click(object sender, EventArgs e)
        {
            if (!CheckValid())
            {
                return;
            }

            MoveItemFromComboBoxToTable();
            ResetInformation();
            lblTongTien.Text = $"Tổng tiền: {tongTien} VNĐ";
        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng bổ sung danh sách sản phẩm !");
                return;
            }
            // Thêm hoá đơn mới vào CSDL
            string tenNV, tenNCC;
            tenNV = AccountInformation.FullName;
            tenNCC = cmbNhaCungCap.Text;

            dbConfig.Excute($"EXEC dbo.SP_ThemHoaDonNhap @TenNV = N'{tenNV}', @TenNCC = N'{tenNCC}'");
            // Thêm các chi tiết hoá đơn vào hoá đơn trên
            string soHDN = dbConfig.GetValue("SELECT MAX(SoHDN) FROM dbo.tHoaDonNhap").ToString();
            string maHang, soLuong, donGia, giamGia;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                maHang = dgv.Rows[i].Cells[0].Value.ToString();
                soLuong = dgv.Rows[i].Cells[2].Value.ToString();
                donGia = dgv.Rows[i].Cells[3].Value.ToString();
                giamGia = dgv.Rows[i].Cells[4].Value.ToString();
                dbConfig.Excute($"INSERT INTO dbo.tChiTietHDN (SoHDN, MaHang, SoLuong, DonGia, GiamGia) VALUES ('{soHDN}', '{maHang}', '{soLuong}', '{donGia}', '{giamGia}')");
            }
            frm.LoadDB();
            MessageBox.Show("Thêm hoá đơn thành công !");
            this.Close();
        }

        private void FormLapHDN_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm.Enabled = true;
        }
    }
}
