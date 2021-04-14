using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Care_Management_and_Private_Parking
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lbForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm frm = new ForgotPasswordForm();
            frm.Show();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.Show();
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {

        }
    }
}
