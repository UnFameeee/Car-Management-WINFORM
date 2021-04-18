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
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }
        Account acc = new Account();
        private void btnVerify_Click(object sender, EventArgs e)
        {
            //if(acc.checkAccount(tbUsername.Text.ToString(), tbIdentityNumber.Text.ToString()))
            //{
            //    Random rand = new Random();                                 //Tạo 1 số random gồm 6 số (như các
            //    randomCode = (rand.Next(999999)).ToString();

            //    MailMessage message = new MailMessage();                    //Cấu hình mail
            //    message.To.Add(tbIdentityNumber.Text);                               //lấy gmail từ cái tbGmail
            //    message.From = new MailAddress("ProjectWF@gmail.com");
            //    message.Subject = "Password reseting code";                 //Tựa đề
            //    message.Body = "Your reset code is " + randomCode;

            //    SmtpClient smtp = new SmtpClient();         //cấu hình gmail cho smtp
            //    smtp.EnableSsl = true;
            //    smtp.UseDefaultCredentials = false;
            //    smtp.Credentials = new NetworkCredential(tbIdentityNumber.Text, "password");
            //    smtp.Host = "smtp.gmail.com";
            //    smtp.Port = 587;
            //    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            //    try
            //    {
            //        smtp.Send(message);
            //        MessageBox.Show("Code send successfully");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Username or Gmail doesn't exist!", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            if (acc.checkAccount(tbUsername.Text, tbIdentityNumber.Text))
            {
                this.Size = new Size(336, 527);
                lbCancel.Location = new Point(139, 496);
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                MessageBox.Show("Username or IdentityNumber doesn't exist!", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lbCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(tbNewpass.Text != tbConfirmPass.Text)
            {
                MessageBox.Show("Confirm Password must be familiar with Password!", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(acc.replacePassword(tbUsername.Text, tbNewpass.Text) == 1)
            {
                MessageBox.Show("New Password must be different from Old Password!", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(acc.replacePassword(tbUsername.Text, tbNewpass.Text) == 2)
            {
                MessageBox.Show("Reset Password Not Successfully!", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Reset Password Successfully!", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        int click = 1;
        private void lbShow_Click(object sender, EventArgs e)
        {
            click++;
            if (click % 2 == 0)
            {
                tbIdentityNumber.UseSystemPasswordChar = false;
            }
            else
            {
                tbIdentityNumber.UseSystemPasswordChar = true;
            }
        }
    }
}
