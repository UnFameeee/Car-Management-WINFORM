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

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            dgvEmp.DataSource = EmployeeDAL.Instance.getAllEmp();
            dgvEmp.RowTemplate.Height = 80;

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dgvEmp.Columns[6];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            //Custom cái độ rộng của các cột của datagridview
            dgvEmp.Columns[0].Width = 80;
            dgvEmp.Columns[1].Width = 200;
            dgvEmp.Columns[2].Width = 100;
            dgvEmp.Columns[3].Width = 120;
            dgvEmp.Columns[4].Width = 150;
            dgvEmp.Columns[5].Width = 100;
            dgvEmp.Columns[6].Width = 104;

            //DataTable tab = EmployeeDAL.Instance.getAllEmp();            

            //for (int i = 0; i < tab.Rows.Count; i++)
            //{
            //    AnEmployee tmp = new AnEmployee();
            //    tmp.Dock = DockStyle.Top;

            //    tmp.lbEmpID.Text = tab.Rows[i][0].ToString();
            //    tmp.lbFullName.Text = tab.Rows[i][1].ToString();
            //    tmp.lbGender.Text = tab.Rows[i][2].ToString();
            //    tmp.lbPhone.Text = tab.Rows[i][3].ToString();
            //    tmp.lbIdentity.Text = tab.Rows[i][4].ToString();
            //    tmp.lbJobID.Text = tab.Rows[i][5].ToString();
            //    fpnEmpList.Controls.Add(tmp);
            //}
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
                MessageBox.Show("Please Insert Name");
            else
            {
                DataTable tab = EmployeeDAL.Instance.searchByName(tbSearch.Text);

                if (tab.Rows.Count == 0)
                    MessageBox.Show("Can't Find Name Like: " + tbSearch.Text);

                dgvEmp.DataSource = tab;
            }            
        }

        private void btnSearchByID_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
                MessageBox.Show("Please Insert ID");
            else
            {
                DataTable tab = EmployeeDAL.Instance.getEmpByID(tbSearch.Text);

                if (tab.Rows.Count == 0)
                   MessageBox.Show("Can't Find ID: " + tbSearch.Text);

                dgvEmp.DataSource = tab;              
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            string id = dgvEmp.CurrentRow.Cells[0].Value.ToString();
            EmployeeDetailForm frm = new EmployeeDetailForm(id);
            frm.ShowDialog();
            reload();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployeeForm frm = new AddEmployeeForm();
            frm.ShowDialog();
            reload();
        }
        void reload()
        {
            dgvEmp.DataSource = EmployeeDAL.Instance.getAllEmp();
            tbSearch.Text = null;
        }
    }
}
