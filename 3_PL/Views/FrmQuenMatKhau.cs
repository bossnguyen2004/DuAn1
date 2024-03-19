using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3_PL.Views
{
    public partial class FrmQuenMatKhau : Form
    {

        public FrmQuenMatKhau()
        {
            InitializeComponent();
        }
        public static string to;

        private string GenerateRandomOTP(int iOTPLength, string[] saAllowedCharacters)

        {

            string sOTP = String.Empty;

            string sTempChars = String.Empty;

            Random rand = new Random();

            for (int i = 0; i < iOTPLength; i++)

            {

                int p = rand.Next(0, saAllowedCharacters.Length);

                sTempChars = saAllowedCharacters[rand.Next(0, saAllowedCharacters.Length)];

                sOTP += sTempChars;

            }

            return sOTP;

        }

        Random random = new Random();
        string otp = "";

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string[] saAllowedCharacters = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

                string sRandomOTP = GenerateRandomOTP(8, saAllowedCharacters);
                otp = sRandomOTP;
                var formAddress = new MailAddress("trannguyen2004ns@gmail.com");
                var toAddress = new MailAddress(txtEmail.ToString());
                const string passMail = "wvhtdbwxgtencjsp";
                const string subject = "OTP Code";
                string body = sRandomOTP.ToString();
                var smtp = new SmtpClient()
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true, //smtp.EnableSsl có nghĩa là gửi có bảo mật 
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,  // sử dụng thông tin đăng nhập mặc định
                    Credentials = new NetworkCredential(formAddress.Address, passMail),
                    Timeout = 20000
                };
                using (var mess = new MailMessage(formAddress, toAddress)
                {
                    Subject = subject,
                    Body = body,
                })
                {
                    smtp.Send(mess);
                }
                MessageBox.Show("OTP đã được gửi qua mail của bạn \n Vui Lòng Kiểm Tra Mail của bạn ");

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (otp.ToString().Equals(txtNhapMa.Text))
            {
                to = txtEmail.Text;
                MessageBox.Show("Xác Thực Thành Công");
                this.Hide();
                FrmLayLaiMatKhau frmLayLaiMatKhau = new FrmLayLaiMatKhau();
                frmLayLaiMatKhau.ShowDialog();
            }
            else MessageBox.Show("Mã OTP không chính xác");
        }
    }
}
