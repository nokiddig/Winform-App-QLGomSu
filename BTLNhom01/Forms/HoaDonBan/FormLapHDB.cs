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

namespace BTLNhom01.Forms.HoaDonBan
{
    public partial class FormLapHDB : Form
    {
        DBConfig dbConfig = new DBConfig();
        FormHDB frm;
        List<string> LstMaHang = new List<string>();
        double tongTien = 0;

        public FormLapHDB(FormHDB frm)
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
            List<string> lstTable = new List<string>() { "tKhachHang", "tHangHoa" };
            List<ComboBox> lstCombobox = new List<ComboBox>() { cmbKhachHang, cmbHangHoa };
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
            if (cmbKhachHang.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn khách hàng !");
                cmbKhachHang.Focus();
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

        private void FormLapHDB_Load(object sender, EventArgs e)
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
            double donGia = double.Parse(dbConfig.GetValue($"SELECT ISNULL(DonGiaBan, 0) FROM dbo.tHangHoa WHERE MaHang = '{maHang}'").ToString());
            int soLuong = int.Parse(txtSoLuong.Text);
            double giamGia = double.Parse(txtGiamGia.Text) / 100;
            double thanhTien = (donGia * (1 - giamGia))*soLuong;
            tongTien += thanhTien;

            dgv.Rows[index].Cells[0].Value = maHang;    
            dgv.Rows[index].Cells[1].Value = cmbHangHoa.Text;
            dgv.Rows[index].Cells[2].Value = soLuong;
            dgv.Rows[index].Cells[3].Value = giamGia;
            dgv.Rows[index].Cells[4].Value = thanhTien;

            // Xoá item ở combobox
            LstMaHang.RemoveAt(cmbHangHoa.SelectedIndex);
            cmbHangHoa.Items.RemoveAt(cmbHangHoa.SelectedIndex);
        }

        void ResetInformation()
        {
            // Ẩn combobox chọn khách hàng
            cmbKhachHang.Enabled = false;
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
            string tenNV, tenKH;
            tenNV = AccountInformation.FullName;
            tenKH = cmbKhachHang.Text;

            dbConfig.Excute($"EXEC dbo.SP_ThemHoaDonBan @TenNV = N'{tenNV}', @TenKhach = N'{tenKH}'");
            // Thêm các chi tiết hoá đơn vào hoá đơn trên
            string soHDB = dbConfig.GetValue("SELECT MAX(SoHDB) FROM dbo.tHoaDonBan").ToString();
            string maHang, soLuong, giamGia;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                maHang = dgv.Rows[i].Cells[0].Value.ToString();
                soLuong = dgv.Rows[i].Cells[2].Value.ToString();
                giamGia = dgv.Rows[i].Cells[3].Value.ToString();
                dbConfig.Excute($"INSERT INTO dbo.tChiTietHDB (SoHDB, MaHang, SoLuong, GiamGia) VALUES ('{soHDB}', '{maHang}', '{soLuong}', '{giamGia}')");
            }
            frm.LoadDB();
            MessageBox.Show("Thêm hoá đơn thành công !");
            this.Close();
        }

        private void FormLapHDB_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm.Enabled = true;
        }
    }
}
