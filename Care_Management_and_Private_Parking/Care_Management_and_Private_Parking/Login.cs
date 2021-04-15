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
                                                                    //tương tự giải thích bên dưới
            this.Hide();
            ForgotPasswordForm frm = new ForgotPasswordForm();
            frm.ShowDialog();
            this.Show();
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {

        }

        private void lbRegister_Click(object sender, EventArgs e)
        {                                                           //cái này từ stackoverflow
            this.Hide();                                            //Tạm ẩn đi form login (chứ không tắt hẳn nó)
            RegisterForm frm = new RegisterForm();
            frm.ShowDialog();                                       //Vào form register
            this.Show();                                            //Hiện lại form login sau khi đã nhận phản hồi từ showdialog của register
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
                                                                    //Dùng để confirm là người sử dụng có muốn thoát ra hay không
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
                Close();
        }
    }
}
