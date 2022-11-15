using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLNhom01
{
    static class AccountInformation
    {
        static string userName, password, fullName, jobTitle, role, id;

        public static string UserName { get => userName; set => userName = value; }
        public static string Password { get => password; set => password = value; }
        public static string FullName { get => fullName; set => fullName = value; }
        public static string JobTitle { get => jobTitle; set => jobTitle = value; }
        public static string Role { get => role; set => role = value; }
        public static string ID { get => id; set => id = value; }

        public static bool CheckLogin()
        {
            DBConfig dbConfig = new DBConfig();
            int cnt = int.Parse(dbConfig.GetValue($"SELECT COUNT(*) FROM tTaiKhoan WHERE UserName = '{userName}' AND Password = '{password}'").ToString());
            bool check = (cnt == 1)?true : false;
            if (check)
            {
                id = dbConfig.GetValue($"SELECT MaNV FROM tTaiKhoan WHERE UserName = '{userName}' AND Password = '{password}'").ToString();
                string maCV = dbConfig.GetValue($"SELECT tCongViec.MaCV FROM dbo.tTaiKhoan JOIN dbo.tNhanVien ON tNhanVien.MaNV = tTaiKhoan.MaNV JOIN dbo.tCongViec ON tCongViec.MaCV = tNhanVien.MaCV WHERE UserName = '{userName}' AND Password = '{password}'").ToString();
                fullName = dbConfig.GetValue($"SELECT TenNV FROM dbo.tTaiKhoan JOIN dbo.tNhanVien ON tNhanVien.MaNV = tTaiKhoan.MaNV WHERE UserName = '{userName}' AND Password = '{password}'").ToString();
                jobTitle = dbConfig.GetValue($"SELECT TenCV FROM dbo.tCongViec WHERE MaCV = '{maCV}'").ToString();
                role = maCV.Equals("2")?"Admin":"Member";
            }
            return check;
        }
    }
}
