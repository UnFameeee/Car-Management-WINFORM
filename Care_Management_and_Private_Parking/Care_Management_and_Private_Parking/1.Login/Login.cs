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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        MY_DB db = new MY_DB();
        Account acc = new Account();
        //Load form
        private void LoginForm_Load(object sender, EventArgs e)
        {
            cbPosition.DataSource = acc.takeRole();               //Lấy thông tin của role
            cbPosition.DisplayMember = "Description";
            cbPosition.ValueMember = "PositionID";
        }

        //Đăng nhập vào form chính
        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ACCOUNT WHERE Username = @User AND Password = @Pass AND PositionID = @PId", db.getConnection);
            cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = tbUser.Text;
            cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = tbPwd.Text;
            cmd.Parameters.Add("@PId", SqlDbType.VarChar).Value = cbPosition.SelectedValue.ToString();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if((table.Rows.Count > 0))
            {
                MessageBox.Show("Login successfully");
                MainForm frm = new MainForm();
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                                                    //Dùng để confirm là người sử dụng có muốn thoát ra hay không
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
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
