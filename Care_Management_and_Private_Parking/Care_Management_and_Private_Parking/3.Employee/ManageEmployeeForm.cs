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
    public partial class ManageEmployeeForm : Form
    {

        public ManageEmployeeForm()
        {
            InitializeComponent();
        }

        Employee emp = new Employee();

        private void ManageEmployeeForm_Load(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("Select EmpID, FullName from EMPLOYEE");
            dgvData.DataSource = emp.getEmployee(com);
            resizeDGV();

            //dgvData.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells);
            //dgvData.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }       

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = tbEmpID.Text = dgvData.CurrentRow.Cells[0].Value.ToString();

            SqlCommand com = new SqlCommand("Select * from EMPLOYEE where EmpID = " + "'" + id + "'");
            DataTable tab = emp.getEmployee(com);

            tbEmpID.Text = tab.Rows[0][0].ToString();
            tbFullName.Text = tab.Rows[0][1].ToString();
            tbPhone.Text = tab.Rows[0][3].ToString();
            tbIdentity.Text = tab.Rows[0][4].ToString();
            tbJobID.Text = tab.Rows[0][5].ToString();

            if (tab.Rows[0][2].ToString() == "Female")
                rdbtnFemale.Checked = true;
            else rdbtnMale.Checked = true;
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
                MessageBox.Show("Please Add Enough Employee's Information", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (verif())
            {
                if (emp.updateEmployee(EmpID, FName, Gender, Phone, Identity, JobID))
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
                MessageBox.Show("Please Add Enough Employee's Information", "Update Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string EmpID = dgvData.CurrentRow.Cells[0].Value.ToString();

            try
            {
                if (MessageBox.Show("Are You Sure You Want To Remove " + EmpID, "Remove Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (emp.removeEmployee(EmpID))
                    {
                        MessageBox.Show(EmpID + " Has Been Removed", "Remove Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnClear.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Can't Remove " + EmpID, "Remove Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
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

        void reloadDatagridview()
        {
            SqlCommand com = new SqlCommand("Select EmpID, FullName from EMPLOYEE");
            dgvData.DataSource = emp.getEmployee(com);
            resizeDGV();
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
        void resizeDGV()
        {
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.Dock = DockStyle.Fill;
        }
    }
}
