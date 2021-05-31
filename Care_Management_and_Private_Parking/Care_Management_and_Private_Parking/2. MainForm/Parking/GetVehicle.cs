using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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

        bool verif()
        {
            if (tbCusID.Text.Trim() == "" || tbIDcard.Text.Trim() == "")
                return false;
            else return true;
        }

        private void btnGetVeh_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                int IDcard = Convert.ToInt32(tbIDcard.Text);
                string CusID = tbCusID.Text;

                SqlCommand com = new SqlCommand("Select * from PARKING where IDParkcard = '" + IDcard + "'");
                DataTable tab = ParkingLotDAL.Instance.getDataWithPurpose(com);

                string VehID = "";

                if (tab.Rows.Count > 0)
                {
                    VehID = tab.Rows[0][2].ToString();
                    SqlCommand cmd = new SqlCommand("Select * from VEHICLE where VehID = '" + VehID + "'");
                    DataTable table = ParkingLotDAL.Instance.getDataWithPurpose(cmd);

                    string VehType = table.Rows[0][1].ToString();

                    DateTime register = Convert.ToDateTime(tab.Rows[0][3]);
                    DateTime leave = DateTime.Now;
                    int value = Convert.ToInt32(tab.Rows[0][4]);
                    string timeformat = tab.Rows[0][5].ToString();
                    string service = tab.Rows[0][6].ToString();


                    if (CusID == tab.Rows[0][1].ToString())
                    {
                        if (ParkingLotDAL.Instance.deleteCarAndCusfromParklot(IDcard))
                        {
                            if (ParkingLotDAL.Instance.deleteVehicle(VehID))
                            {
                                if (ParkingLotDAL.Instance.deleteCustomer(CusID))
                                {
                                    int money = InvoiceDAL.Instance.MoneyHaveToPay(register, leave, value, timeformat, VehType, service);
                                    if (InvoiceDAL.Instance.checkParkingDate(leave.Day, leave.Month, leave.Year))       //đã tồn tại (nghĩa là đã thu tiền 1 ai đó trước)
                                    {
                                        if (InvoiceDAL.Instance.updateParkingProfit(leave.Day, leave.Month, leave.Year, money))
                                        {
                                            MessageBox.Show("You have to pay " + string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", money) + "VNĐ", "Get Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.DialogResult = DialogResult.OK;
                                        }
                                    }
                                    else                            //không có gì (nghĩa là chưa thu tiền ai trong ngày)
                                    {
                                        if (InvoiceDAL.Instance.insertParkingProfit(leave.Day, leave.Month, leave.Year, money))
                                        {
                                            MessageBox.Show("You have to pay " + string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", money) + "VNĐ", "Get Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.DialogResult = DialogResult.OK;
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error", "Get Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("IDcard and CusID do not match!!!", "Get Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Can't find Vehicle with IDcard!!!", "Get Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill all information", "Get Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Extension
        private void tbIDcard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)/* && !char.IsLetter(e.KeyChar)*/)
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
