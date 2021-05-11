using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//3 layers
using DAL;

namespace Care_Management_and_Private_Parking
{
    public partial class EmployeeListForm : Form
    {
        public EmployeeListForm()
        {
            InitializeComponent();
        }

        Employee emp = new Employee();

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            DataTable tab = emp.getAllEmp();            

            for (int i = 0; i < tab.Rows.Count; i++)
            {
                AnEmployee tmp = new AnEmployee();
                tmp.Dock = DockStyle.Top;

                tmp.lbEmpID.Text = tab.Rows[i][0].ToString();
                tmp.lbFullName.Text = tab.Rows[i][1].ToString();
                tmp.lbGender.Text = tab.Rows[i][2].ToString();
                tmp.lbPhone.Text = tab.Rows[i][3].ToString();
                tmp.lbIdentity.Text = tab.Rows[i][4].ToString();
                tmp.lbJobID.Text = tab.Rows[i][5].ToString();
                fpnEmpList.Controls.Add(tmp);
            }
        }
    }
}
