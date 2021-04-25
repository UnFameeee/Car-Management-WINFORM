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
    public partial class ManangeForm : Form
    {
        public ManangeForm()
        {
            InitializeComponent();
        }

        Employee emp = new Employee();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string EmpID = tbEmpID.Text;
            string FName = tbFullName.Text;
            string Gender = "Male";
            string Phone = tbPhone.Text;
            string Identity = tbIdentity.Text;
            int JobID = Convert.ToInt32(tbJobID.Text);
            int ShiftID = Convert.ToInt32(tbShiftID.Text);

            if (EmpID.Trim() == "")
            {
                MessageBox.Show("Add an EmpID", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (emp.checkEmp(EmpID))
            {
                if (emp.insertEmployee(EmpID, FName, Gender, Phone, Identity, JobID, ShiftID))
                {
                    MessageBox.Show("New Employee Inserted", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("This EmpID Already Exists", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Employee Not Inserted", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void tpEmployees_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
