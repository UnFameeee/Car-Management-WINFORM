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
            cbboxTimeFormat.DataSource = InvoiceDAL.Instance.getAllInvoice();
            cbboxTimeFormat.DisplayMember = "Description";
            cbboxTimeFormat.ValueMember = "InvoiceID";
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
            MemoryStream CusPic = new MemoryStream();
            CustomerPic.Image.Save(CusPic, CustomerPic.Image.RawFormat);

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
                    if (verifCus())
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

        bool verifVeh()
        {
            if (tbLicense.Text.Trim() == "" || VehiclePic.Image == null)
                return false;
            else
                return true;
        }
        private void btnEditVeh_Click(object sender, EventArgs e)
        {
            //Xe
            string Type = tbType.Text;
            string License = tbLicense.Text;
            MemoryStream VehPic = new MemoryStream();
            VehiclePic.Image.Save(VehPic, VehiclePic.Image.RawFormat);

            string CusID = tbCustomerID.Text;

            string Invoice = cbboxTimeFormat.SelectedValue.ToString();
            DateTime leave;                                                                 //thời gian tối đa trong bãi giữ xe(do khách chọn)

            if (Invoice == "H")
                leave = dayvehin.AddHours(Convert.ToDouble(numerudValue.Value));
            else if (Invoice == "D")
                leave = dayvehin.AddDays(Convert.ToDouble(numerudValue.Value));
            else if (Invoice == "W")
                leave = dayvehin.AddDays(Convert.ToDouble(numerudValue.Value) * 7);
            else
                leave = dayvehin.AddMonths(Convert.ToInt32(numerudValue.Value));

            try
            {
                if (verifVeh())
                {
                    if (ParkingLotDAL.Instance.updateVehicle(VehID, Type, License, VehPic, CusID))
                    {
                        ParkingLotDAL.Instance.editCarAndCusToParklot(CusID, VehID, dayvehin, leave, Invoice);
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
                    MessageBox.Show("Please fill all the information!!", "Edit Vehicle");
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
    }
}
