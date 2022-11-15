using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLNhom01
{
    public partial class FormSanPham : Form
    {
        DBConfig dbConfig = new DBConfig();

        // Hàm này để đọc dữ liệu từ database vào Form
        public void LoadDB()
        {
            guna2DataGridView1.DataSource = dbConfig.GetTable("SELECT * FROM dbo.View_DanhSachHangHoa");
        }
        public FormSanPham()
        {
            InitializeComponent();
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            LoadDB();
            PanelTien.Visible = false;
        }

        private void cmbChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChoice.SelectedIndex == 3 || cmbChoice.SelectedIndex == 4)
            {
                PanelTien.Visible = true;
            }
            else
            {
                PanelTien.Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form them = new FormThemSanPham(this);
            them.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa viết cái này =))");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (cmbChoice.SelectedIndex)
            {
                case 0:
                    guna2DataGridView1.DataSource = dbConfig.GetTable($"EXEC dbo.SP_LietKeThongTinSP @TenCD = N'{txtSearch.Text}'");
                    break;
                case 1:
                    guna2DataGridView1.DataSource = dbConfig.GetTable($"EXEC dbo.SP_LietKeThongTinSP @TenLoaiMen = N'{txtSearch.Text}'");
                    break;
                case 2:
                    guna2DataGridView1.DataSource = dbConfig.GetTable($"EXEC dbo.SP_LietKeThongTinSP @TenLoaiHang = N'{txtSearch.Text}'");
                    break;
                case 3:
                    guna2DataGridView1.DataSource = dbConfig.GetTable($"EXEC dbo.SP_LietKeThongTinSP @TenCD = '{txtSearch.Text}'");
                    break;
                case 4:
                    guna2DataGridView1.DataSource = dbConfig.GetTable($"EXEC dbo.SP_LietKeSPTheoGiaNhap @GiaNhapDau = '{txtFrom.Text}', @GiaNhapCuoi = '{txtTo.Text}'");
                    break;
                case 5:
                    guna2DataGridView1.DataSource = dbConfig.GetTable($"EXEC dbo.SP_LietKeSPTheoGiaBan @GiaBanDau = '{txtFrom.Text}', @GiaBanCuoi = '{txtTo.Text}'");
                    break;
                default:
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá sản phẩm này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string id = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                try
                {
                    dbConfig.Excute($"DELETE FROM tHangHoa WHERE MaHang = '{id}'");
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
