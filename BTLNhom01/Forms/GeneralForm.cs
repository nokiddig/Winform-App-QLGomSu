using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using BTLNhom01.Forms.BaoCao;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;
using Panel = System.Windows.Forms.Panel;

namespace BTLNhom01
{
    public partial class FormMainMenu : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm = null;
        // private Form activeForm = null;
        public FormMainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 65);
            panelSideMenu.Controls.Add(leftBorderBtn);
            //Form
            //this.Text = String.Empty;
            //this.ControlBox = false;


            //this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            customizeDesing();
        }

        private void customizeDesing()
        {
            panelBaoCaoSubmenu.Visible = false;
            panelNhanSuSubmenu.Visible = false;
            //..

        }

        private void hideSubmenu()
        {
            if (panelBaoCaoSubmenu.Visible == true)
                panelBaoCaoSubmenu.Visible = false;
            if (panelNhanSuSubmenu.Visible == true)
                panelNhanSuSubmenu.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else submenu.Visible = false; //?
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }

        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(11, 7, 17);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            ActivateButton(sender, RGBColors.color1);
            //OpenChildForm(new Form()); // new 1 form gì gì đó
            openChildForm(new FormSanPham());
        }

        private void btnNhanSu_Click(object sender, EventArgs e)
        {
            lblTitleChildForm.Text = "Nhân sự";
            showSubmenu(panelNhanSuSubmenu);
            ActivateButton(sender, RGBColors.color2);
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

        }

        private void btnHoaDonBan_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            ActivateButton(sender, RGBColors.color3);
            openChildForm(new FormHDB());
        }

        private void btnHoaDonNhap_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            ActivateButton(sender, RGBColors.color4);
            openChildForm(new FormHDN());
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            ActivateButton(sender, RGBColors.color5);
            openChildForm(new FormNhaCungCap());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            ActivateButton(sender, RGBColors.color6);
            openChildForm(new FormKhachHang());
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            showSubmenu(panelBaoCaoSubmenu);
            ActivateButton(sender, RGBColors.color1);
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }

        #region NhanSuSubmenu

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhanVien());
        }

        private void btnCongViec_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCongViec());
        }


        #endregion

        #region BaoCaoSubmenu
        private void btnBaoCao1_Click(object sender, EventArgs e)
        {
            string reportViewerLocal = "BTLNhom01.Forms.BaoCao.ReportHTK.rdlc";
            string reportDataSourceValue = "select * from [dbo].[View_DanhSachCongDung]";
            openChildForm(new FormReport(reportViewerLocal, reportDataSourceValue));
        }

        private void btnBaoCao2_Click(object sender, EventArgs e)
        {
            string reportViewerLocal = "BTLNhom01.Forms.BaoCao.ReportTopHDN.rdlc";
            string reportDataSourceValue = "select * from [dbo].[View_Top5HoaDonNhap2022]";
            openChildForm(new FormReport(reportViewerLocal, reportDataSourceValue));
        }

        private void btnBaoCao3_Click(object sender, EventArgs e)
        {
            string reportViewerLocal = "BTLNhom01.Forms.BaoCao.ReportTopNV.rdlc";
            string reportDataSourceValue = "select * from View_DanhSachNhanVien";
            openChildForm(new FormReport(reportViewerLocal, reportDataSourceValue));
        }

        private void btnBaoCao4_Click(object sender, EventArgs e)
        {
            string reportViewerLocal = "BTLNhom01.Forms.BaoCao.ReportDSHD.rdlc";
            string reportDataSourceValue = "select * from View_DanhSachHoaDonBan";
            openChildForm(new FormReport(reportViewerLocal, reportDataSourceValue));
        }
        #endregion

        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
                currentChildForm.Close();
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;

            lblTitleChildForm.Text = childForm.Text;

            childForm.BringToFront();
            childForm.Show();
        }

        private void FormMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            lblFullName.Text = AccountInformation.FullName;
            lblJobTitle.Text = AccountInformation.JobTitle;
        }

        private void iconLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }
    }
}
