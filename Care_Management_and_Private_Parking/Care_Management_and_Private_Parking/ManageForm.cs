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
        public ManageForm()
        {
            InitializeComponent();
        }

        void solve()
        {
            frmEmpList.Hide();
            frmManageEmp.Hide();
        }

        EmployeeListForm frmEmpList = new EmployeeListForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };          
        private void btnEmpList_Click(object sender, EventArgs e)
        {
            this.pnData.Controls.Add(frmEmpList);
            solve();
            frmEmpList.Show();
        }

        ManageEmployeeForm frmManageEmp = new ManageEmployeeForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        private void btnManageEmp_Click(object sender, EventArgs e)
        {
            this.pnData.Controls.Add(frmManageEmp);
            solve();
            frmManageEmp.Show();
        }
    }
}
