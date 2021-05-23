﻿using System;
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
    public partial class GetVehicle : Form
    {
        public GetVehicle()
        {
            InitializeComponent();
        }

        private void btnGetVeh_Click(object sender, EventArgs e)
        {
            string IDcard = tbIDcard.Text;
            string CusID = tbCusID.Text;

            SqlCommand com = new SqlCommand("Select * from PARKING where IDParkcard = '" + IDcard + "'");
            DataTable tab = ParkingLotDAL.Instance.getDataWithPurpose(com);

            string VehID = tab.Rows[0][2].ToString();

            SqlCommand cmd = new SqlCommand("Select * from VEHICLE where VehID = '" + VehID + "'");
            DataTable table = ParkingLotDAL.Instance.getDataWithPurpose(cmd);

            string VehType = table.Rows[0][1].ToString();

            DateTime register = Convert.ToDateTime(tab.Rows[0][3]);
            int value = Convert.ToInt32(tab.Rows[0][4]);
            string invoice = tab.Rows[0][5].ToString();
            string service = tab.Rows[0][6].ToString();

            

            if (CusID == tab.Rows[0][1].ToString())
            {
                if (ParkingLotDAL.Instance.deleteCarAndCusfromParklot(IDcard))
                {
                    if (ParkingLotDAL.Instance.deleteVehicle(VehID))
                    {
                        if (ParkingLotDAL.Instance.deleteCustomer(CusID))
                        {
                            int money = InvoiceDAL.Instance.MoneyHaveToPay(register, DateTime.Now, value, invoice, VehType, service);
                            MessageBox.Show("You have to pay " + money.ToString());
                        }
                    }                  
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("IDcard and CusID do not match!!!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}