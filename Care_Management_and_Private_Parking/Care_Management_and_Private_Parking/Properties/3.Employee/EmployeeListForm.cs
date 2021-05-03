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
    public partial class EmployeeListForm : Form
    {
        public EmployeeListForm()
        {
            InitializeComponent();
        }

        Employee emp = new Employee();
        MY_DB db = new MY_DB();

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            DataTable dt = emp.getAllEmp();

            for (int i = 0; i < dt.Rows.Count; i++) 
            {
                AnEmployee tmp = new AnEmployee();
                tmp.Dock = DockStyle.Top;

                tmp.lbEmpID.Text = dt.Rows[i][0].ToString();
                tmp.lbFullName.Text = dt.Rows[i][1].ToString();
                tmp.lbGender.Text = dt.Rows[i][2].ToString();
                tmp.lbPhone.Text = dt.Rows[i][3].ToString();
                tmp.lbIdentity.Text = dt.Rows[i][4].ToString();
                tmp.lbJobID.Text = dt.Rows[i][5].ToString();

                fpEmpList.Controls.Add(tmp);
            }
        }
    }
}
