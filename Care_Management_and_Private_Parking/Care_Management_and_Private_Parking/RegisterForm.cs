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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            //Dùng để quay lại form cũ (form login)
            this.DialogResult = DialogResult.OK;
        }

        private void btnRegistation_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Creating Account Successfully!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }
    }
}
