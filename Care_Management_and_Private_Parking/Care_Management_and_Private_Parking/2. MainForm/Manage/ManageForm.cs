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
        ContractForm frmContract = new ContractForm() { TopLevel = false, TopMost = true };
        ManageContractForm frmContractlist = new ManageContractForm() { TopLevel = false, TopMost = true };
        Cursor cur1 = Cursors.Hand;
        Cursor cur2 = Cursors.Default;
        public ManageForm()
        {
            InitializeComponent();
            loadForm();
            loadFormWithJobID();
        }

        private void loadFormWithJobID()
        {
            if (Global.UserID.GlobalJobID != "1")
            {
                //nút manage job
                btnStaffList.Enabled = false;
                btnStaffList.Visible = false;
                //nút statistic
                btnAccountList.Enabled = false;
                btnAccountList.Visible = false;

                //Căn lại các nút
                btnStaffList.Location = new Point(0, 0);
                btnAccountList.Location = new Point(0, 0);
                btnContract.Location = new Point(9, 188);
                btnContractList.Location = new Point(9, 276);
            }
        }

        void loadForm()
        {
            pnData.Controls.Add(frmEmpList);
            pnData.Controls.Add(frmAccount);
            pnData.Controls.Add(frmContract);
            pnData.Controls.Add(frmContractlist);
            tick();
        }

        void tick()
        {
            //Chỉnh Checked
            btnStaffList.Checked = false;
            btnAccountList.Checked = false;
            btnContract.Checked = false;
            btnContractList.Checked = false;
            //Chỉnh Cursor
            btnStaffList.Cursor = cur1;
            btnAccountList.Cursor = cur1;
            btnContract.Cursor = cur1;
            btnContractList.Cursor = cur1;
            //Tắt tất cả các form
            frmEmpList.Hide();
            frmAccount.Hide();
            frmContract.Hide();
            frmContractlist.Hide();
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

        private void btnContract_Click(object sender, EventArgs e)
        {
            tick();
            btnContract.Checked = true;
            btnContract.Cursor = cur2;
            frmContract.Show();
        }

        private void btnContractList_Click(object sender, EventArgs e)
        {
            tick();
            btnContractList.Checked = true;
            btnContractList.Cursor = cur2;
            frmContractlist.Show();
        }
    }
}
