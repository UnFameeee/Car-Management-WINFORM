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

        void reload()
        {
            cbbxPositionID.DataSource = AccountDAL.Instance.takeRole();
            cbbxPositionID.DisplayMember = "Description";
            cbbxPositionID.ValueMember = "PositionID";
            cbbxPositionID.SelectedItem = null;

            dgvAccount.DataSource = AccountDAL.Instance.getAllAccount();
            dgvAccount.RowTemplate.Height = 30;

            dgvAccount.Columns[0].Width = 135;
            dgvAccount.Columns[1].Width = 135;
            dgvAccount.Columns[2].Width = 89;
            dgvAccount.Columns[3].Width = 100;

            tbUsername.Text = null;
            tbPassword.Text = null;
        }

        bool verif()
        {
            if (tbUsername.Text.Trim() == ""
                    || tbPassword.Text.Trim() == ""
                        || cbbxPositionID.SelectedItem == null)
                return false;
            else return true;
        }

        private void ManageAccountForm_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbUsername.Text = dgvAccount.CurrentRow.Cells[0].Value.ToString();
            tbPassword.Text = dgvAccount.CurrentRow.Cells[1].Value.ToString();
            cbbxPositionID.SelectedValue = dgvAccount.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string pass = tbPassword.Text;
            string position = cbbxPositionID.SelectedValue.ToString();

            if (verif())
            {
                if (AccountDAL.Instance.updateAccount(username, pass, position))
                {
                    MessageBox.Show("Update Account " + username + " Successfully", "Update Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reload();
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
            if (verif())
            {
                if (AccountDAL.Instance.removeAccount(username))
                {
                    MessageBox.Show("Account " + username + " Has Been Deleted", "Delete Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reload();
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
    }
}
