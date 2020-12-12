using QuanLyNhanSu_Master.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyNhanSu_Master.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            try
            {
                byte[] temp = ASCIIEncoding.ASCII.GetBytes(passWord);
                byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
                string hasPass = "";
                foreach (byte item in hasData)
                {
                    hasPass += item;
                }
                string query = "SP_Login @userName , @passWord";
                hasPass = EnCrypt(hasPass, "%4oPNbxNwO3Z15CoNCbi");
                DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, hasPass /*list*/});
                return result.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                return false;
            } 
        }

        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from NguoiDung where UserName = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }

        public int ResetPassAccount(string userName)
        {
            string email;
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_GetUserFromUserName @userName", new object[] { userName });
            if (data.Rows.Count == 0)
            {
                return 0;
            }
            DataRow firstRow = data.Rows[0];
            email = firstRow["Email"].ToString();
            Random rnd = new Random();
            int code = rnd.Next(100000, 999999);
            DataProvider.Instance.ExecuteQuery("update NguoiDung set CodeXacThuc = '" + code + "' where UserName = '" + userName + "'");
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("tranthai2258@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Mail xác thực";
                mail.Body = "Mã xác thực để reset pass là " + code;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("tranthai2258@gmail.com", "beakbrwobscypcjl");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
            
        }
        public bool IsAdmin(string userName)
        {
            try
            {
                DataTable data = DataProvider.Instance.ExecuteQuery("SP_CheckUserAdmin @userName", new object[] { userName });
                DataRow firstRow = data.Rows[0];
                string Role = firstRow["Role"].ToString();
                if (Role == "Admin")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void AllowChagePassword(string userName, string passWord)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(passWord);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            string query = "SP_ChangePassFromUserName @userName , @passWord";

            hasPass = EnCrypt(hasPass, "%4oPNbxNwO3Z15CoNCbi");

            DataProvider.Instance.ExecuteQuery(query, new object[] { userName, hasPass });
        }

        public bool IsVerify(string userName, string InputCodeVerify)
        {
            try
            {
                string CodeVerify;
                DataTable data = DataProvider.Instance.ExecuteQuery("SP_GetUserFromUserName @userName", new object[] { userName });
                DataRow firstRow = data.Rows[0];
                CodeVerify = firstRow["CodeXacThuc"].ToString();

                if (InputCodeVerify == CodeVerify)
                {

                    Random rnd = new Random();
                    int code = rnd.Next(100000, 999999);
                    DataProvider.Instance.ExecuteQuery("update NguoiDung set CodeXacThuc = '" + code + "' where UserName = '" + userName + "'");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
           
          
        }

        public string EnCrypt(string strEnCrypt, string key)
        {
            try
            {
                byte[] keyArr;
                byte[] EnCryptArr = UTF8Encoding.UTF8.GetBytes(strEnCrypt);
                MD5CryptoServiceProvider MD5Hash = new MD5CryptoServiceProvider();
                keyArr = MD5Hash.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider();
                tripDes.Key = keyArr;
                tripDes.Mode = CipherMode.ECB;
                tripDes.Padding = PaddingMode.PKCS7;
                ICryptoTransform transform = tripDes.CreateEncryptor();
                byte[] arrResult = transform.TransformFinalBlock(EnCryptArr, 0, EnCryptArr.Length);
                return Convert.ToBase64String(arrResult, 0, arrResult.Length);
            }
            catch (Exception ex) { }
            return "";
        }

        public string DeCrypt(string strDecypt, string key)
        {
            try
            {
                byte[] keyArr;
                byte[] DeCryptArr = Convert.FromBase64String(strDecypt);
                MD5CryptoServiceProvider MD5Hash = new MD5CryptoServiceProvider();
                keyArr = MD5Hash.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider();
                tripDes.Key = keyArr;
                tripDes.Mode = CipherMode.ECB;
                tripDes.Padding = PaddingMode.PKCS7;
                ICryptoTransform transform = tripDes.CreateDecryptor();
                byte[] arrResult = transform.TransformFinalBlock(DeCryptArr, 0, DeCryptArr.Length);
                return UTF8Encoding.UTF8.GetString(arrResult);
            }
            catch (Exception ex) { }
            return "";
        }

        public bool AddNewImployee(string txtTenNhanVien, string txtNgaySinh, string txtGioiTinh,string txtDiaChi,string txtEmail, string txtSdt, string txtCmnd,string txtNgayCap, string txtTenTinhThanh, string txtDanToc,string txtPhongBan,string txtTenChucVu,float txtMaBacLuong,string txtTinhTrangLamViec,string txtSoBHXH,string txtSoBHYT,string txtTaiKhoanNH)
        {
            string query = string.Empty;
            try
            {

                query = "INSERT INTO NhanVien(MaNV, TenNV, NgaySinh, GioiTinh, DiaChi, Email, Sdt, Cmnd, NgayCap, MaTinhThanh, DanToc, MaPhongBan, MaChucVu, MaBacLuong, TinhTrangLamViec, SoBHXH, SoBHYT, TaiKhoanNH) ";
                query += " VALUES((select max(MaNV) + 1 from NhanVien),N'" +txtTenNhanVien+"', N'"+ txtNgaySinh + "' , N'"+ txtGioiTinh + "', N'"+ txtDiaChi + "', N'"+ txtEmail + "', N'"+ txtSdt + "', N'"+ txtCmnd + "', N'"+ txtNgayCap + "', (select MaTinhThanh from TinhThanh where TenTinhThanh like CONCAT(N'"+ txtTenTinhThanh + "', '%')) ,N'"+ txtDanToc + "', (select MaPhongBan from PhongBan where TenPhongBan like CONCAT( N'"+ txtPhongBan + "', '%')), (select MaChucVu from ChucVu where TenChucVu like CONCAT(N'"+ txtTenChucVu + "', '%')) , N'"+ txtMaBacLuong + "', N'"+ txtTinhTrangLamViec + "', N'"+ txtSoBHXH + "', N'"+ txtSoBHYT+"', N'"+txtTaiKhoanNH +"')";
                //string query = " exec SP_AddNewImployee @TenNV , @NgaySinh , @GioiTinh , @DiaChi , @Email , @Sdt , @Cmnd , @NgayCap , @TenTinhThanh , @DanToc , @TenPhongBan , @TenChucVu , @MaBacLuong , @TinhTrangLamViec , @SoBHXH , @SoBHYT , @TaiKhoanNH";
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;

            }
            catch (Exception ex)
            {
               return false;
            }
        }

        public bool IsAddNewUser(string userName, string passWord, string email, string hoTen)
        {
            try
            {
                Random rnd = new Random();
                int code = rnd.Next(100000, 999999);
                byte[] temp = ASCIIEncoding.ASCII.GetBytes(passWord);
                byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

                string hasPass = "";

                foreach (byte item in hasData)
                {
                    hasPass += item;
                }
                 hasPass = EnCrypt(hasPass, "%4oPNbxNwO3Z15CoNCbi");
                string query = string.Format("INSERT dbo.NguoiDung ( UserName, PassWord, Email, ID, CodeXacThuc, Role, AllowResetPass, HoTen) VALUES  ( '{0}', '{1}', N'{2}', (select MAX(ID)+ 1 from NguoiDung),{3}, 'User', 0)", userName, hasPass, email , code);

                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
