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
            dgvData.RowTemplate.Height = 100;
            SqlCommand com = new SqlCommand("select VehID, VehType, LicensePlate, Picture from VEHICLE where VehType = '" + type + "' and VehID LIKE '%veh%'");
            dgvData.DataSource = ParkingLotDAL.Instance.getDataWithPurpose(com);

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dgvData.Columns[3];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            type = dgvData.CurrentRow.Cells[1].Value.ToString();
            this.DialogResult = DialogResult.OK;
        }
    }
}
