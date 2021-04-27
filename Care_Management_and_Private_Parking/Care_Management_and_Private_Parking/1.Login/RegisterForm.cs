using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Care_Management_and_Private_Parking
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        //MY_DB db = new MY_DB();
        Account acc = new Account();

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            cbPosition.DataSource = acc.takeRole();               //Lấy thông tin của role
            cbPosition.DisplayMember = "Description";
            cbPosition.ValueMember = "PositionID";
        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            //Dùng để quay lại form cũ (form login)
            this.DialogResult = DialogResult.OK;
        }

        //Check xem có nhập trống ô nào hay không
        bool verif()
        {
            if ((tbUsername.Text.Trim() == "") ||
                (tbPassword.Text.Trim() == "") ||
                (tbEmployeeID.Text.Trim() == "") ||
                (tbConfirmPassword.Text.Trim() == ""))
            {
                return false;
            }
            else
                return true;
        }

        private void btnRegistation_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string employeeID = tbEmployeeID.Text;
            string position = cbPosition.SelectedValue.ToString();
            try
            {
                if(verif())
                {
                    if(password != tbConfirmPassword.Text)
                    {
                        MessageBox.Show("Confirm Password must be familiar with Password!", "Register account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if(acc.insertAccount(username,password, employeeID, position))
                    {
                        DialogResult dialogResult = MessageBox.Show("Creating Account Successfully!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Error!", "Register account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Username has already exist!", "Register account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int click = 1;
        private void lbShow_Click(object sender, EventArgs e)
        {
            click++;
            if(click % 2 == 0)
            {
                tbPassword.UseSystemPasswordChar = false;
                tbConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
                tbConfirmPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
