using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        MY_DB db = new MY_DB();
        void reloadDatagridview()
        {
            SqlCommand command = new SqlCommand("Select * from EMPLOYEE", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvEmp.DataSource = table;
            dgvEmp.AllowUserToAddRows = false;
            dgvEmp.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }

        bool verif()
        {
            if (tbEmpID.Text.Trim() == ""
                || tbFullName.Text.Trim() == ""
                || tbPhone.Text.Trim() == ""
                || tbIdentity.Text.Trim() == ""
                || tbJobID.Text.Trim() == ""
                || tbShiftID.Text.Trim() == "")
                return false;

            else return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string EmpID = tbEmpID.Text;
            string FName = tbFullName.Text;            
            string Phone = tbPhone.Text;
            string Identity = tbIdentity.Text;
            int JobID = Convert.ToInt32(tbJobID.Text);
            int ShiftID = Convert.ToInt32(tbShiftID.Text);
            string Gender = "Male";

            if (rdbtnFemale.Checked)
                Gender = "Female";

            if (verif())
            {
                if (emp.checkEmp(EmpID))
                {
                    if (emp.insertEmployee(EmpID, FName, Gender, Phone, Identity, JobID, ShiftID))
                    {
                        MessageBox.Show("New Employee Inserted", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reloadDatagridview();
                    }
                    else
                    {
                        MessageBox.Show("Employee Not Inserted", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("This EmpID Already Exists", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Add Employee's Information", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }        

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            reloadDatagridview();
        }
    }
}
