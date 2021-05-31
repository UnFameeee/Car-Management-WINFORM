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

using DAL;
namespace Care_Management_and_Private_Parking
{
    public partial class CustomerAndVehicleList : Form
    {
        public CustomerAndVehicleList()
        {
            InitializeComponent();
        }

        private void CustomerList_Load(object sender, EventArgs e)
        {
            filldgvCus();
            filldgvVeh();
        }

        #region Khách
        void filldgvCus()
        {
            SqlCommand com = new SqlCommand("select CusID as ID, FullName, IdentityNumber, Appearance from CUSTOMER");
            dgvCus.RowTemplate.Height = 80;
            dgvCus.DataSource = ParkingLotDAL.Instance.getDataWithPurpose(com);
        }

        private void btnSearchCusByName_Click(object sender, EventArgs e)
        {
            if (tbCusSearch.Text == "")
            {
                MessageBox.Show("Please insert Name!!!", "Search Customer By Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnReloadCus.PerformClick();
            }
            else
            {
                SqlCommand com = new SqlCommand("select CusID as ID, FullName, IdentityNumber, Appearance from CUSTOMER " +
                    " where FullName Like '%" + tbCusSearch.Text + "%'");
                DataTable tab = ParkingLotDAL.Instance.getDataWithPurpose(com);

                if (tab.Rows.Count == 0)
                {
                    MessageBox.Show("Can't Find Customer has Name Like: " + tbCusSearch.Text);
                    btnReloadCus.PerformClick();
                }
                else
                {
                    dgvCus.DataSource = tab;
                    tbCusSearch.Text = "";
                }
            }
        }

        private void btnSearchCusByID_Click(object sender, EventArgs e)
        {
            if (tbCusSearch.Text == "")
            {
                MessageBox.Show("Please insert ID!!!", "Search Customer By ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnReloadCus.PerformClick();
            }
            else
            {
                SqlCommand com = new SqlCommand("select CusID as ID, FullName, IdentityNumber, Appearance from CUSTOMER " +
                    " where convert(varbinary, CusID) = convert(varbinary, '" + tbCusSearch.Text + "')");
                DataTable tab = ParkingLotDAL.Instance.getDataWithPurpose(com);

                if (tab.Rows.Count == 0)
                {
                    MessageBox.Show("Can't Find Customer has ID: " + tbCusSearch.Text);
                    btnReloadCus.PerformClick();
                }
                else
                {
                    dgvCus.DataSource = tab;
                    tbCusSearch.Text = "";
                }
            }
        }

        private void btnReloadCus_Click(object sender, EventArgs e)
        {
            filldgvCus();
            tbCusSearch.Text = "";
        }
        #endregion

        #region Xe
        void filldgvVeh()
        {
            SqlCommand com = new SqlCommand("select VehID as ID, VehType as Type, LicensePlate, Picture, CusID as Owner from VEHICLE");
            dgvVeh.RowTemplate.Height = 80;
            dgvVeh.DataSource = ParkingLotDAL.Instance.getDataWithPurpose(com);
        }

        private void btnSearchVehByID_Click(object sender, EventArgs e)
        {
            if (tbVehSearch.Text == "")
            {
                MessageBox.Show("Please insert ID!!!", "Search Vehicle By ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnReloadVeh.PerformClick();
            }
            else
            {
                SqlCommand com = new SqlCommand("select VehID as ID, VehType as Type, LicensePlate, Picture, CusID as Owner from VEHICLE " +
                    " where convert(varbinary, VehID) = convert(varbinary, '" + tbVehSearch.Text + "')");
                DataTable tab = ParkingLotDAL.Instance.getDataWithPurpose(com);

                if (tab.Rows.Count == 0)
                {
                    MessageBox.Show("Can't Find Vehicle has ID: " + tbVehSearch.Text);
                    btnReloadVeh.PerformClick();
                }
                else
                {
                    dgvVeh.DataSource = tab;
                    tbVehSearch.Text = "";
                }
            }
        }

        private void btnSearchVehByType_Click(object sender, EventArgs e)
        {
            if (tbVehSearch.Text == "")
            {
                MessageBox.Show("Please insert Type!!!", "Search Vehicle By Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnReloadVeh.PerformClick();
            }
            else
            {
                SqlCommand com = new SqlCommand("select VehID as ID, VehType as Type, LicensePlate, Picture, CusID as Owner from VEHICLE " +
                    " where VehType = '" + tbVehSearch.Text + "'");
                DataTable tab = ParkingLotDAL.Instance.getDataWithPurpose(com);

                if (tab.Rows.Count == 0)
                {
                    MessageBox.Show("Can't Find Vehicle Has Type: " + tbVehSearch.Text);
                    btnReloadVeh.PerformClick();
                }
                else
                {
                    dgvVeh.DataSource = tab;
                    tbVehSearch.Text = "";
                }
            }
        }

        private void btnReloadVeh_Click(object sender, EventArgs e)
        {
            filldgvVeh();
            tbVehSearch.Text = "";
        }
        #endregion
    }
}
