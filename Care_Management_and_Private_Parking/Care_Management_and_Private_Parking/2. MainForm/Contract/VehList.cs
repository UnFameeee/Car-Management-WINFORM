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
    public partial class VehList : Form
    {
        public VehList()
        {
            InitializeComponent();
        }

        public string type;

        private void VehList_Load(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("select VehID, VehType, LicensePlate, Picture from VEHICLE where VehType = '" + type + "' and CusID = null");
            dgvData.DataSource = ParkingLotDAL.Instance.getDataWithPurpose(com);
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
