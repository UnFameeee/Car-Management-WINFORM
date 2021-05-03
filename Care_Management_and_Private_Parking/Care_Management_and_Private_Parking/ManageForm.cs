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

        EmployeeListForm frmEmpList = new EmployeeListForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        private void btnEmp_Click(object sender, EventArgs e)
        {
            this.pnData.Controls.Add(frmEmpList);
            frmEmpList.Show();
        }
    }
}
