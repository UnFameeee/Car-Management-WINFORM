using DAL;
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
    public partial class ManageAccountForm : Form
    {
        public ManageAccountForm()
        {
            InitializeComponent();
        }

        void reloadAcc()
        {
            cbbxPosition.DataSource = AccountDAL.Instance.takeRole();
            cbbxPosition.DisplayMember = "Description";
            cbbxPosition.ValueMember = "PositionID";
            cbbxPosition.SelectedItem = null;

            dgvAccount.DataSource = AccountDAL.Instance.getAllAccount();
            dgvAccount.RowTemplate.Height = 30;

            dgvAccount.Columns[0].Width = 135;
            dgvAccount.Columns[1].Width = 135;
            dgvAccount.Columns[2].Width = 135;

            tbUsername.Text = null;
            tbPassword.Text = null;
        }

        void reloadEmp()
        {
            SqlCommand com = new SqlCommand("Select EmpID as ID, FullName, AccUserName from EMPLOYEE");
            dgvEmployeeWork.DataSource = EmployeeDAL.Instance.getEmployee(com);
            dgvEmployeeWork.RowTemplate.Height = 30;

            dgvEmployeeWork.Columns[0].Width = 60;
            dgvEmployeeWork.Columns[1].Width = 180;
            dgvEmployeeWork.Columns[2].Width = 100;
        }

        bool verif()
        {
            if (tbUsername.Text.Trim() == ""
                    || tbPassword.Text.Trim() == ""
                        || cbbxPosition.SelectedItem == null)
                return false;
            else return true;
        }

        private void ManageAccountForm_Load(object sender, EventArgs e)
        {
            reloadAcc();
            reloadEmp();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string pass = tbPassword.Text;

            if (verif())
            {
                string position = cbbxPosition.SelectedValue.ToString();

                if (AccountDAL.Instance.updateAccount(username, pass, position))
                {
                    MessageBox.Show("Update Account " + username + " Successfully", "Update Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadAcc();
                }
                else
                {
                    MessageBox.Show("Can't update Account " + username, "Update Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Fill All Information", "Update Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            if (verif())
            {
                string position = cbbxPosition.SelectedValue.ToString();

                if (AccountDAL.Instance.removeAccount(username, password, position))
                {
                    MessageBox.Show("Account " + username + " Has Been Deleted", "Delete Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadAcc();
                }
                else
                {
                    MessageBox.Show("Can't Delete Account " + username, "Delete Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Fill All Information", "Delete Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFindEmpID_Click(object sender, EventArgs e)
        {
            string ID = tbEmpID.Text;
            if (ID == "")
            {
                MessageBox.Show("Please insert ID!!!", "Search EmpID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                reloadAcc();
            }
            else
            {
                SqlCommand com = new SqlCommand("Select EmpID, FullName, AccUserName from EMPLOYEE where convert(varbinary, EmpID) = convert(varbinary, @EmpID)");
                com.Parameters.Add("@EmpID", SqlDbType.NVarChar).Value = ID;

                DataTable tab = EmployeeDAL.Instance.getEmployee(com);

                if (tab.Rows.Count == 0)
                {
                    MessageBox.Show("Can't Find ID: " + ID, "Search EmpID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    reloadAcc();
                }
                else
                {
                    dgvEmployeeWork.DataSource = tab;
                    tbEmpID.Text = "";
                }
            }           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            try
            {
                if (verif())
                {
                    string position = cbbxPosition.SelectedValue.ToString();

                    if (AccountDAL.Instance.insertAccount(username, password, position))
                    {
                        DialogResult dialogResult = MessageBox.Show("Creating Account Successfully", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reloadAcc();
                    }
                    else
                    {
                        MessageBox.Show("Can't Create Account", "Register account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill All Information!!!", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Username has already exist!!!", "Register account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGrantPer_Click(object sender, EventArgs e)
        {
            string accusername = dgvAccount.CurrentRow.Cells[0].Value.ToString();
            string id = dgvEmployeeWork.CurrentRow.Cells[0].Value.ToString();

            if (EmployeeDAL.Instance.checkAcc(accusername))
            {
                SqlCommand com = new SqlCommand("update EMPLOYEE set AccUserName = @AccUserName where EmpID = @EmpID", DataProvider.Instance.getConnection);
                com.Parameters.Add("@EmpID", SqlDbType.NVarChar).Value = id;
                com.Parameters.Add("@AccUserName", SqlDbType.NVarChar).Value = accusername;

                DataProvider.Instance.openConnection();
                if (com.ExecuteNonQuery() == 1)
                {
                    DataProvider.Instance.closeConnection();
                    MessageBox.Show(id + " Has Granted Account " + accusername, "Grant Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadEmp();
                }
                else
                {
                    DataProvider.Instance.closeConnection();
                    MessageBox.Show("Can't Grant Account", "Grant Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Account " + accusername + " Has Been Granted!!!", "Granted Permission", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemovePer_Click(object sender, EventArgs e)
        {
            string accusername = dgvAccount.CurrentRow.Cells[0].Value.ToString();
            string id = dgvEmployeeWork.CurrentRow.Cells[0].Value.ToString();

            SqlCommand com = new SqlCommand("update EMPLOYEE set AccUserName = null where EmpID = @EmpID", DataProvider.Instance.getConnection);
            com.Parameters.Add("@EmpID", SqlDbType.NVarChar).Value = id;

            DataProvider.Instance.openConnection();
            if (com.ExecuteNonQuery() == 1)
            {
                DataProvider.Instance.closeConnection();
                MessageBox.Show(id + " Has Removed Account " + accusername, "Remove Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reloadEmp();
            }
            else
            {
                DataProvider.Instance.closeConnection();
                MessageBox.Show("Can't Remove Account", "Remove Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbUsername.Text = dgvAccount.CurrentRow.Cells[0].Value.ToString();
            tbPassword.Text = dgvAccount.CurrentRow.Cells[1].Value.ToString();

            SqlCommand com = new SqlCommand("select * from ACCOUNT where Username = '" + tbUsername.Text + "' and Password = '" + tbPassword.Text + "'");
            DataTable tab = AccountDAL.Instance.getAccount(com);

            cbbxPosition.SelectedValue = tab.Rows[0][2].ToString();
        }
    }
}
