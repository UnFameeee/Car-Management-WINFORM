using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
//3layers
using DAL;


namespace Care_Management_and_Private_Parking
{
    public partial class EditVehicle : Form
    {
        public EditVehicle()
        {
            InitializeComponent();
            
        }

        #region Properties
        public string VehID;
        public string CusID;
        public int Execute = 0;
        DataTable tableCUS;
        DateTime dayvehin;
        #endregion

        private void EditVehicle_Load(object sender, EventArgs e)
        {
            fillInfo();
            formatTime();
        }

        #region Điền giá trị
        private void fillInfo()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM CUSTOMER WHERE CusID = @CusID", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@CusID", SqlDbType.NVarChar).Value = CusID;
            DataTable table = ParkingLotDAL.Instance.getDataWithPurpose(cmd);

            tableCUS = table;

            tbCustomerID.Text = CusID;
            tbName.Text = table.Rows[0]["FullName"].ToString();
            datetime.Text = table.Rows[0]["Bdate"].ToString();
            tbPhone.Text = table.Rows[0]["PhoneNumber"].ToString();
            tbAddress.Text = table.Rows[0]["Address"].ToString();
            tbIdentity.Text = table.Rows[0]["IdentityNumber"].ToString();

            if(table.Rows[0]["Appearance"] != DBNull.Value)
            {
                byte[] picture = (byte[])table.Rows[0]["Appearance"];
                MemoryStream Picture = new MemoryStream(picture);
                CustomerPic.Image = Image.FromStream(Picture);
            }

            SqlCommand cmd1 = new SqlCommand("SELECT * FROM VEHICLE WHERE VehID = @VehID", DataProvider.Instance.getConnection);
            cmd1.Parameters.Add("@VehID", SqlDbType.NVarChar).Value = VehID;
            DataTable table1 = ParkingLotDAL.Instance.getDataWithPurpose(cmd1);

            tbVehicleID.Text = VehID;
            tbType.Text = table1.Rows[0]["VehType"].ToString();
            tbLicense.Text = table1.Rows[0]["LicensePlate"].ToString();

            if (table1.Rows[0]["Picture"] != DBNull.Value)
            {
                byte[] picture1 = (byte[])table1.Rows[0]["Picture"];
                MemoryStream Picture1 = new MemoryStream(picture1);
                VehiclePic.Image = Image.FromStream(Picture1);
            }

            SqlCommand cmd2 = new SqlCommand("SELECT * FROM PARKING WHERE VehID = @VehID and CusID = @CusID", DataProvider.Instance.getConnection);
            cmd2.Parameters.Add("@VehID", SqlDbType.NVarChar).Value = VehID;
            cmd2.Parameters.Add("@CusID", SqlDbType.NVarChar).Value = CusID;
            DataTable table2 = ParkingLotDAL.Instance.getDataWithPurpose(cmd2);
            dayvehin = (DateTime)table2.Rows[0]["DateRegister"];
            //cbboxTimeFormat.SelectedValue = table2.Rows[0]["InvoiceID"].ToString();
            numerudValue.Value = 0;//Convert.ToInt32(table2.Rows[0][""]);
        }

        void formatTime()
        {
            cbboxTimeFormat.DataSource = InvoiceDAL.Instance.getAllTimeFormat();
            cbboxTimeFormat.DisplayMember = "Description";
            cbboxTimeFormat.ValueMember = "ID";
            cbboxTimeFormat.SelectedItem = null;
        }
        #endregion

        #region Sửa khách
        bool verifCus()
        {
            if (tbName.Text.Trim() == "" || tbPhone.Text.Trim() == ""
                || tbAddress.Text.Trim() == "" || tbIdentity.Text.Trim() == "" || CustomerPic.Image == null)
                return false;
            else
                return true;
        }
        private void btnEditCus_Click(object sender, EventArgs e)
        {
            //Khách
            string FullName = tbName.Text;
            DateTime Birth = datetime.Value;
            string Phone = tbPhone.Text;
            string Address = tbAddress.Text;
            string Identity = tbIdentity.Text;

            int bornyear = datetime.Value.Year;
            int thisyear = DateTime.Now.Year;
            if ((thisyear - bornyear < 10) || (thisyear - bornyear > 100))
            {
                MessageBox.Show("The customer age must be between 10 and 100 year", "Invalid Birth date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    MemoryStream CusPic = new MemoryStream();
                    CustomerPic.Image.Save(CusPic, CustomerPic.Image.RawFormat);

                    if (verifCus())
                    {
                        if (ParkingLotDAL.Instance.checkIdentity(CusID, Identity, "edit"))
                        {
                            if (ParkingLotDAL.Instance.updateCustomer(CusID, FullName, Birth, Phone, Address, Identity, CusPic))
                            {
                                MessageBox.Show("Edit Customer successfully!", "Edit Customer");
                                Execute += 1;
                                showUpForm();
                            }
                            else
                            {
                                MessageBox.Show("Edit Customer fail!!!", "Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Identity " + Identity + " Already Exist!!!", "Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill all the information!!", "Edit Customer");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }   
        #endregion

        #region sửa xe
        public void showUpForm()
        {
            pnlCus.Enabled = false;
            pnlCus.Visible = false;
            btnEditCus.Enabled = false;
            btnEditCus.Visible = false;
        }

        public bool check()                         //kiểm tra xem có chọn service nào ko
        {
            if ((numerudValue.Text == "0" || cbboxTimeFormat.SelectedItem == null)
                && radiobtnRepair.Checked == false && radiobtnWash.Checked == false)
                return false;
            else return true;
        }

        bool verifVeh()
        {
            if (tbLicense.Text.Trim() == "" || VehiclePic.Image == null || cbboxTimeFormat.SelectedItem == null || numerudValue.Value == 0) 
                return false;
            else
                return true;
        }
        private void btnEditVeh_Click(object sender, EventArgs e)
        {
            //Xe
            string Type = tbType.Text;
            string License = tbLicense.Text;

            string CusID = tbCustomerID.Text;
            int value = Convert.ToInt32(numerudValue.Value);
            string timeformat = "null";

            string service = "";
            if (radiobtnRepair.Checked == true && radiobtnWash.Checked == true)
            {
                service = "Repairing and Washing";
            }
            else
            {
                if (radiobtnRepair.Checked == true)
                    service = "Repairing";
                if (radiobtnWash.Checked == true)
                    service = "Washing";
            }

            try
            {
                MemoryStream VehPic = new MemoryStream();
                VehiclePic.Image.Save(VehPic, VehiclePic.Image.RawFormat);

                if (verifVeh())
                {
                    if(ParkingLotDAL.Instance.checkLicense(VehID, License, "edit"))
                    {
                        if (check())
                        {
                          if (cbboxTimeFormat.SelectedItem != null)
                              timeformat = cbboxTimeFormat.SelectedValue.ToString();
                          else                                                            //khách không chọn timeformat -> mặc định là ko gửi xe
                          {
                              value = 0;
                          }
                          string Invoice = cbboxTimeFormat.SelectedValue.ToString();
                          if (ParkingLotDAL.Instance.updateVehicle(VehID, Type, License, VehPic, CusID))
                          {
                              ParkingLotDAL.Instance.editCarAndCusToParklot(CusID, VehID, dayvehin, value, Invoice, service);
                              MessageBox.Show("Edit vehicle successfully!", "Edit Vehicle");
                              this.DialogResult = DialogResult.OK;
                          }
                          else
                          {
                              MessageBox.Show("Edit vehicle fail!!!", "Edit Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                          }
                        }
                        else
                        {
                          MessageBox.Show("Please choose at least one service!", "Edit Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    else
                    {
                      MessageBox.Show("This License Plate has already existed!!!", "Add Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all the information!!", "Edit Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (Execute == 1)
            {
                //Khách
                string FullName = tableCUS.Rows[0]["FullName"].ToString();
                DateTime Birth = (DateTime)tableCUS.Rows[0]["Bdate"];
                string Phone = tableCUS.Rows[0]["PhoneNumber"].ToString();
                string Address = tableCUS.Rows[0]["Address"].ToString();
                string Identity = tableCUS.Rows[0]["IdentityNumber"].ToString();
                MemoryStream CusPic = null;
                if (tableCUS.Rows[0]["Appearance"] != DBNull.Value)
                {
                    byte[] picture = (byte[])tableCUS.Rows[0]["Appearance"];
                    CusPic = new MemoryStream(picture);
                }
                ParkingLotDAL.Instance.updateCustomer(CusID, FullName, Birth, Phone, Address, Identity, CusPic);
            }
            this.DialogResult = DialogResult.Cancel;
        }

        #region Extension
        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)/* && !char.IsLetter(e.KeyChar)*/)
            {
                e.Handled = true;
            }
        }

        private void numerudValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)/* && !char.IsLetter(e.KeyChar)*/)
            {
                e.Handled = true;
            }
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) /*&& !char.IsDigit(e.KeyChar)*/ && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }        

        static int i = 1;
        private void radiobtnRepair_Click(object sender, EventArgs e)
        {
            i++;
            if (i % 2 == 0)
            {
                radiobtnRepair.Checked = true;
            }
            else
            {
                radiobtnRepair.Checked = false;
            }
        }

        static int j = 1;
        private void radiobtnWash_Click(object sender, EventArgs e)
        {
            j++;
            if (j % 2 == 0)
            {
                radiobtnWash.Checked = true;
            }
            else
            {
                radiobtnWash.Checked = false;
            }
        }

        private void numerudValue_Validated(object sender, EventArgs e)
        {
            if (numerudValue.Text == "")
                numerudValue.Text = "0";
        }
        #endregion
    }
}
