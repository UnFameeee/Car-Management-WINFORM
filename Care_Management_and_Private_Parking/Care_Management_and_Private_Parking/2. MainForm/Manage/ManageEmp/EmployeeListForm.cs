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
            picCol = (DataGridViewImageColumn)dgvEmp.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            //Custom cái độ rộng của các cột của datagridview
            dgvEmp.Columns[0].Width = 50;
            dgvEmp.Columns[1].Width = 150;
            dgvEmp.Columns[2].Width = 60;
            dgvEmp.Columns[3].Width = 80;
            dgvEmp.Columns[4].Width = 95;
            dgvEmp.Columns[5].Width = 119;
            dgvEmp.Columns[6].Width = 140;
            dgvEmp.Columns[7].Width = 80;
            dgvEmp.Columns[8].Width = 100;
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                MessageBox.Show("Please Insert Name!!!", "Search By Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                reload();
            }
            else
            {
                DataTable tab = EmployeeDAL.Instance.searchByName(tbSearch.Text);

                if (tab.Rows.Count == 0)
                {
                    MessageBox.Show("Can't Find Name Like: " + tbSearch.Text, "Search By Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    reload();
                }
                else
                {
                    dgvEmp.DataSource = tab;
                    tbSearch.Text = "";
                }
            }            
        }

        private void btnSearchByID_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                MessageBox.Show("Please Insert ID!!!", "Search By ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                reload();
            }
            else
            {
                DataTable tab = EmployeeDAL.Instance.getEmpByID(tbSearch.Text);

                if (tab.Rows.Count == 0)
                {
                    MessageBox.Show("Can't Find ID: " + tbSearch.Text, "Search By ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    reload();
                }
                else
                {
                    dgvEmp.DataSource = tab;
                    tbSearch.Text = "";
                }
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            string id = dgvEmp.CurrentRow.Cells[0].Value.ToString();
            ManageEmployeeForm frm = new ManageEmployeeForm(id);
            frm.ShowDialog();
            reload();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ManageEmployeeForm frm = new ManageEmployeeForm();
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
