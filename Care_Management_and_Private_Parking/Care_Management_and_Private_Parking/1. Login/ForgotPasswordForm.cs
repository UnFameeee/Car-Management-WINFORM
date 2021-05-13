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
//3 layers
using DAL;

namespace Care_Management_and_Private_Parking
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }
        //AccountDAL acc = new AccountDAL();
        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            cbPosition.DataSource = AccountDAL.Instance.takeRole();               //Lấy thông tin của role
            cbPosition.DisplayMember = "Description";
            cbPosition.ValueMember = "PositionID";
        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
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

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (AccountDAL.Instance.checkAccount(tbUsername.Text, tbIdentityNumber.Text, cbPosition.SelectedValue.ToString()))
            {
                this.Size = new Size(354, 598);
                lbCancel.Location = new Point(149, 569);
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                MessageBox.Show("Wrong Username or EmployeeID or Position!!!", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbNewpass.Text != tbConfirmPass.Text)
            {
                MessageBox.Show("Confirm Password must be familiar with Password!", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (AccountDAL.Instance.replacePassword(tbUsername.Text, tbNewpass.Text) == 1)
            {
                MessageBox.Show("New Password must be different from Old Password!", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (AccountDAL.Instance.replacePassword(tbUsername.Text, tbNewpass.Text) == 2)
            {
                MessageBox.Show("Reset Password Not Successfully!", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Reset Password Successfully!", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
