using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace Care_Management_and_Private_Parking
{
    public partial class ForgotPasswordForm : Form
    {
        public string randomCode;
        Account acc = new Account();
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }
        private void btnSendCode_Click(object sender, EventArgs e)
        {
            if(acc.checkAccount(tbUsername.Text.ToString(), tbGmail.Text.ToString()))
            {
                Random rand = new Random();                                 //Tạo 1 số random gồm 6 số (như các
                randomCode = (rand.Next(999999)).ToString();

                MailMessage message = new MailMessage();                    //Cấu hình mail
                message.To.Add(tbGmail.Text);                               //lấy gmail từ cái tbGmail
                message.From = new MailAddress("ProjectWF@gmail.com");
                message.Subject = "Password reseting code";                 //Tựa đề
                message.Body = "Your reset code is " + randomCode;

                SmtpClient smtp = new SmtpClient();         //cấu hình gmail cho smtp
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(tbGmail.Text, "password");
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Code send successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Username or Gmail doesn't exist!", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmCode_Click(object sender, EventArgs e)
        {
            if(randomCode == (tbVerifyCode.Text).ToString())
            {
                ResetPassword frm = new ResetPassword();
                frm.Show();
                this.Close();
            }
        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
