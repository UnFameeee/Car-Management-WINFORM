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
using System.IO;
using DAL;

namespace Care_Management_and_Private_Parking
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        public string CusID;
        public string VehID;

        private void Invoice_Load(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("select * from PARKING where CusID = @CusID and VehID = @VehID");
            com.Parameters.Add("@CusID", SqlDbType.NVarChar).Value = CusID;
            com.Parameters.Add("@VehID", SqlDbType.NVarChar).Value = VehID;

            DataTable tab = ParkingLotDAL.Instance.getDataWithPurpose(com);

            SqlCommand cmd = new SqlCommand("select * from INVOICE where InvoiceID = @InvoiceID");
            cmd.Parameters.Add("@InvoiceID", SqlDbType.NVarChar).Value = tab.Rows[0][5].ToString();
            DataTable table = ParkingLotDAL.Instance.getDataWithPurpose(cmd);

            string time = tab.Rows[0][4].ToString() + " " + table.Rows[0][1].ToString();

            lbDateRegister.Text = "DateRegister: " + tab.Rows[0][3].ToString();
            lbTimeRegister.Text = "TimeRegister: " + time;
            lbService.Text = "Service: " + tab.Rows[0][6].ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
