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
    public partial class ManageForm : Form
    {
        EmployeeListForm frmEmpList = new EmployeeListForm() { TopLevel = false, TopMost = true };
        ManageAccountForm frmAccount = new ManageAccountForm() { TopLevel = false, TopMost = true };
        Cursor cur1 = Cursors.Hand;
        Cursor cur2 = Cursors.Default;
        public ManageForm()
        {
            InitializeComponent();
            loadForm();
        }

        void loadForm()
        {
            pnData.Controls.Add(frmEmpList);
            pnData.Controls.Add(frmAccount);
            tick();
        }

        void tick()
        {
            //Chỉnh Checked
            btnStaffList.Checked = false;
            btnAccountList.Checked = false;
            //Chỉnh Cursor
            btnStaffList.Cursor = cur1;
            btnAccountList.Cursor = cur1;
            //Tắt tất cả các form
            frmEmpList.Hide();
            frmAccount.Hide();
        }  

        private void btnStaffList_Click(object sender, EventArgs e)
        {
            tick();
            btnStaffList.Checked = true;
            btnStaffList.Cursor = cur2;
            frmEmpList.Show();
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            tick();
            btnAccountList.Checked = true;
            btnAccountList.Cursor = cur2;
            frmAccount.Show();
        }
    }
}
