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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AccountInformation.UserName = txtUserName.Text;
            AccountInformation.Password = txtPassword.Text;
            if (AccountInformation.CheckLogin())
            {
                this.Hide();
                FormMainMenu formMain = new FormMainMenu();
                formMain.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc tài khoản không đúng, vui lòng thử lại !");
                txtUserName.Clear();
                txtPassword.Clear();
            }
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
