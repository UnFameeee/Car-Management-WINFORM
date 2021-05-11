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
//3layers
using DAL;
using Global;

namespace Care_Management_and_Private_Parking
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        Account acc = new Account();
        //Load form
        private void LoginForm_Load(object sender, EventArgs e)
        {
            cbPosition.DataSource = acc.takeRole();               //Lấy thông tin của role
            cbPosition.DisplayMember = "Description";
            cbPosition.ValueMember = "PositionID";
        }
        //Đăng nhập vào form chính
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (acc.checkLogin(tbUser.Text, tbPwd.Text, cbPosition.SelectedValue.ToString()))
                {
                    MessageBox.Show("Login successfully");
                    //Lấy EmpID từ chỗ này
                    try
                    {
                        UserID.SetGlobalUserID(acc.takeEmpID(tbUser.Text, tbPwd.Text, cbPosition.SelectedValue.ToString()));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Mở form đăng kí tài khoản
        private void lbRegister_Click(object sender, EventArgs e)
        {                                                           //cái này từ stackoverflow
            this.Hide();                                            //Tạm ẩn đi form login (chứ không tắt hẳn nó)
            RegisterForm frm = new RegisterForm();
            frm.ShowDialog();                                       //Vào form register
            this.Show();                                            //Hiện lại form login sau khi đã nhận phản hồi từ showdialog của register
        }

        //Mở form khôi phục tài khoản
        private void lbForgotPassword_Click(object sender, EventArgs e)
        {
            //tương tự giải thích bên dưới
            this.Hide();
            ForgotPasswordForm frm = new ForgotPasswordForm();
            frm.ShowDialog();
            this.Show();
        }

        //Thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)                   //Dùng để confirm là người sử dụng có muốn thoát ra hay không
                Close();
        }

        //Nút show mật khẩu
        int click = 1;
        private void lbShow_Click(object sender, EventArgs e)
        {
            click++;
            if (click % 2 == 0)
            {
                tbPwd.UseSystemPasswordChar = false;
            }
            else
            {
                tbPwd.UseSystemPasswordChar = true;
            }
        }
    }
}
