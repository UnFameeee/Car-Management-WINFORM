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
    public partial class ManangeEmpForm : Form
    {
        public ManangeEmpForm()
        {
            InitializeComponent();
        }

        Employee emp = new Employee();
        MY_DB db = new MY_DB();
        int pos;

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
                || tbJobID.Text.Trim() == "")
                return false;

            else return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string EmpID = tbEmpID.Text;
            string FName = tbFullName.Text;            
            string Phone = tbPhone.Text;
            string Identity = tbIdentity.Text;
            string JobID = tbJobID.Text;
            string Gender = "Male";

            if (rdbtnFemale.Checked)
                Gender = "Female";

            if (verif())
            {
                if (emp.checkEmp(EmpID))
                {
                    if (emp.insertEmployee(EmpID, FName, Gender, Phone, Identity, JobID))
                    {
                        MessageBox.Show("New Employee Inserted", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnClear.PerformClick(); 
                    }
                    else
                    {
                        MessageBox.Show("Can't Insert This Employee", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("This " + EmpID + " Already Exists", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please Add More Employee's Information", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string EmpID = tbEmpID.Text;
            string FName = tbFullName.Text;
            string Phone = tbPhone.Text;
            string Identity = tbIdentity.Text;
            string JobID = tbJobID.Text;
            string Gender = "Male";

            if (rdbtnFemale.Checked)
                Gender = "Female";

            if(verif())
            {
                if(emp.updateEmployee(EmpID, FName, Gender, Phone, Identity, JobID))
                {
                    MessageBox.Show(EmpID + " Has Been Updated", "Update Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClear.PerformClick();
                }
                else
                {
                    MessageBox.Show("Can't Update " + EmpID, "Update Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Add More Employee's Information", "Update Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string EmpID = dgvEmp.CurrentRow.Cells[0].Value.ToString();

            try
            {
                if (MessageBox.Show("Are You Sure You Want To Remove " + EmpID, "Remove Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(emp.removeEmployee(EmpID))
                    {
                        MessageBox.Show(EmpID + "Has Been Removed", "Remove Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnClear.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Can't Remove " + EmpID, "Remove Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Remove Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            reloadDatagridview();
            tbEmpID.Text = null;
            tbFullName.Text = null;
            tbPhone.Text = null;
            tbIdentity.Text = null;
            tbJobID.Text = null;
        }

        private void tpEmployees_Enter(object sender, EventArgs e)
        {
            dgvEmp.ReadOnly = true;

            dgvEmp.DataSource = emp.getAllEmp();
            dgvEmp.AllowUserToAddRows = false;

            dgvEmp.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }

        private void dgvEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbEmpID.Text = dgvEmp.CurrentRow.Cells[0].Value.ToString();
            tbFullName.Text = dgvEmp.CurrentRow.Cells[1].Value.ToString();
            tbPhone.Text = dgvEmp.CurrentRow.Cells[3].Value.ToString();
            tbIdentity.Text = dgvEmp.CurrentRow.Cells[4].Value.ToString();
            tbJobID.Text = dgvEmp.CurrentRow.Cells[5].Value.ToString();

            if (dgvEmp.CurrentRow.Cells[2].Value.ToString() == "Female")
                rdbtnFemale.Checked = true;
            else rdbtnMale.Checked = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string EmpID = tbEmpID.Text;

            if (EmpID == "")
                MessageBox.Show("Please Add EmployeeID", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                SqlCommand com = new SqlCommand("Select * from EMPLOYEE where convert(varbinary,EmpID) = " + "convert(varbinary,'" + EmpID + "')");
                DataTable tab = emp.getEmployee(com);

                if (tab.Rows.Count > 0)
                {
                    tbFullName.Text = tab.Rows[0]["FullName"].ToString();
                    tbPhone.Text = tab.Rows[0]["PhoneNumber"].ToString();
                    tbIdentity.Text = tab.Rows[0]["IdentityCardNumber"].ToString();
                    tbJobID.Text = tab.Rows[0]["JobID"].ToString();

                    if (tab.Rows[0]["Gender"].ToString() == "Female")
                        rdbtnFemale.Checked = true;
                    else rdbtnMale.Checked = true;
                }
                else
                {
                    MessageBox.Show("Can't Find EmpID: " + EmpID, "Find Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }


        
    }
}
