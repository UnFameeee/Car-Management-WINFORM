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
using DAL;

namespace Care_Management_and_Private_Parking
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }
 
        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("Select * from POSITION");
            cbbxJobID.DataSource = EmployeeDAL.Instance.getEmployee(com);
            cbbxJobID.DisplayMember = "Description";
            cbbxJobID.ValueMember = "PositionID";
            cbbxJobID.SelectedItem = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string EmpID = tbEmpID.Text;
            string FName = tbFullName.Text;
            string Phone = tbPhone.Text;
            string Identity = tbIdentity.Text;
            string JobID = cbbxJobID.SelectedValue.ToString();
            string Gender = "Male";

            if (rdbtnFemale.Checked)
                Gender = "Female";

            if (verif())
            {
                MemoryStream pic = new MemoryStream();
                ptbEmp.Image.Save(pic, ptbEmp.Image.RawFormat);

                if (EmployeeDAL.Instance.checkEmp(EmpID))
                {
                    if (EmployeeDAL.Instance.insertEmployee(EmpID, FName, Gender, Phone, Identity, JobID, pic))
                    {
                        MessageBox.Show("New Employee Inserted", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reload();
                    }
                    else
                    {
                        MessageBox.Show("Can't Insert This Employee", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        bool verif()
        {
            if (tbEmpID.Text.Trim() == ""
                || tbFullName.Text.Trim() == ""
                || tbPhone.Text.Trim() == ""
                || tbIdentity.Text.Trim() == ""
                || cbbxJobID.SelectedItem == null
                || ptbEmp.Image == null)
                return false;

            else return true;
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                ptbEmp.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
