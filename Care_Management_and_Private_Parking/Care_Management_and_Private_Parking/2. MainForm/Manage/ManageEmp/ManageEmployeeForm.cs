using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//3layers
using DAL;

namespace Care_Management_and_Private_Parking
{
    public partial class ManageEmployeeForm : Form
    {

        public ManageEmployeeForm()
        {
            InitializeComponent();
        }

        string EmpID = "";

        public ManageEmployeeForm(string id) : this()
        {
            EmpID = id;
        }

        private void ManageEmployeeForm_Load(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("Select * from POSITION");
            cbbxJobID.DataSource = EmployeeDAL.Instance.getEmployee(com);
            cbbxJobID.DisplayMember = "Description";
            cbbxJobID.ValueMember = "PositionID";
            cbbxJobID.SelectedItem = null;


            if (EmpID != "")
            {
                SqlCommand cmd = new SqlCommand("Select * from EMPLOYEE where EmpID = '" + EmpID + "'");
                DataTable tab = EmployeeDAL.Instance.getEmployee(cmd);

                tbEmpID.Text = tab.Rows[0][0].ToString();
                tbFullName.Text = tab.Rows[0][1].ToString();

                if (tab.Rows[0][2].ToString() == "Female")
                    rdbtnFemale.Checked = true;
                else rdbtnMale.Checked = true;

                dateTime.Value = Convert.ToDateTime(tab.Rows[0][3]);
                tbPhone.Text = tab.Rows[0][4].ToString();
                tbIdentity.Text = tab.Rows[0][5].ToString();
                tbMail.Text = tab.Rows[0][6].ToString();
                cbbxJobID.SelectedValue = tab.Rows[0][7].ToString();

                if (tab.Rows[0][8] != DBNull.Value)
                {
                    byte[] pic;
                    pic = (byte[])tab.Rows[0][8];
                    MemoryStream picture = new MemoryStream(pic);
                    ptbEmp.Image = Image.FromStream(picture);
                }

                btnAdd.Visible = false;
            }
            else
            {
                btnUpdate.Visible = false;
                btnRemove.Visible = false;
            }
        }    
                
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string EmpID = tbEmpID.Text;
            string FName = tbFullName.Text;
            string Phone = tbPhone.Text;
            string Identity = tbIdentity.Text;
            string Email = tbMail.Text;
            DateTime Bday = dateTime.Value;

            string JobID = cbbxJobID.SelectedValue.ToString();
            string Gender = "Male";

            if (rdbtnFemale.Checked)
                Gender = "Female";

            if (verif())
            {
                MemoryStream pic = new MemoryStream();
                ptbEmp.Image.Save(pic, ptbEmp.Image.RawFormat);
                if (EmployeeDAL.Instance.checkIdentity(EmpID, Identity, "edit"))
                {
                    if (EmployeeDAL.Instance.updateEmployee(EmpID, FName, Gender, Bday, Phone, Identity, Email, JobID, pic))
                    {
                        MessageBox.Show(EmpID + " Has Been Updated", "Update Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reload();
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Can't Update " + EmpID, "Update Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Identity " + Identity + " Already Exist!!!", "Update Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please Add Enough Employee's Information!!!", "Update Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure You Want To Remove " + tbFullName.Text, "Remove Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (EmployeeDAL.Instance.removeEmployee(EmpID))
                    {
                        MessageBox.Show(tbFullName.Text + " Has Been Removed", "Remove Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reload();
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Can't Remove " + tbFullName.Text, "Remove Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Remove Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void reload()
        {
            tbEmpID.Text = null;
            tbFullName.Text = null;
            rdbtnMale.Checked = true;
            tbPhone.Text = null;
            tbIdentity.Text = null;
            cbbxJobID.SelectedItem = null;
            ptbEmp.Image = null;
        }

        bool verif()
        {
            if (tbEmpID.Text.Trim() == ""
                || tbFullName.Text.Trim() == ""
                || tbPhone.Text.Trim() == ""
                || tbIdentity.Text.Trim() == ""
                || tbMail.Text.Trim() == ""
                || cbbxJobID.SelectedItem == null
                || ptbEmp.Image == null)
                return false;

            else return true;
        }

        private void ptbEmp_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                ptbEmp.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string EmpID = tbEmpID.Text;
            string FName = tbFullName.Text;
            string Phone = tbPhone.Text;
            string Identity = tbIdentity.Text;
            string Email = tbMail.Text;
            DateTime Bday = dateTime.Value;

            string Gender = "Male";
            if (rdbtnFemale.Checked)
                Gender = "Female";

            if (verif())
            {
                string JobID = cbbxJobID.SelectedValue.ToString();

                MemoryStream pic = new MemoryStream();
                ptbEmp.Image.Save(pic, ptbEmp.Image.RawFormat);

                if (EmployeeDAL.Instance.checkEmp(EmpID))
                {
                    if (EmployeeDAL.Instance.checkIdentity("", Identity, "add"))
                    {
                        if (EmployeeDAL.Instance.insertEmployee(EmpID, FName, Gender, Bday, Phone, Identity, Email, JobID, pic))
                        {
                            MessageBox.Show("New Employee Inserted", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            reload();
                            //this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("Can't Insert This Employee", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Identity " + Identity + " Already Exist!!!", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("This " + EmpID + " Already Exist!!!", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please Add Enough Employee's Information!!!", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
