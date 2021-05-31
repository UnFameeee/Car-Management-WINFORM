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
    public partial class Service : Form
    {
        public Service()
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

            DateTime dateregister = Convert.ToDateTime(tab.Rows[0][3]);
            string service = "Parking";

            SqlCommand cmd = new SqlCommand("select * from TIMEFORMAT where ID = @ID");
            cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = tab.Rows[0][5].ToString();
            DataTable table = ParkingLotDAL.Instance.getDataWithPurpose(cmd);

            string time;
            if (tab.Rows[0][4].ToString() != "0" && table.Rows[0][0].ToString() != "null")          //có Parking
                time = tab.Rows[0][4].ToString() + " " + table.Rows[0][1].ToString();
            else time = "In " + dateregister.ToString("dd/MM/yyyy");                                //không Parking

            if (tab.Rows[0][6].ToString() != "")                                        //có dịch vụ khác ngoài Parking               
            {
                if (time == "In " + dateregister.ToString("dd/MM/yyyy"))                //chỉ sửa hoặc rửa hoặc cả sửa lẫn rửa
                {
                    service = tab.Rows[0][6].ToString();
                }
                else                                                                    //cả 3
                {
                    service = "Parking and " + tab.Rows[0][6].ToString();
                }
            }             

            lbDateRegister.Text = "DateRegister: " + dateregister.ToString("dd/MM/yyyy hh:mm:ss tt");
            lbTimeRegister.Text = "TimeRegister: " + time;
            lbService.Text = "Service: " + service;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
