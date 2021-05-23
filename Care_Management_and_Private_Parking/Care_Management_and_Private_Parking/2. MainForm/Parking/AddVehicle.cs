using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
//3 layers
using DAL;
using Global;

namespace Care_Management_and_Private_Parking
{
    public partial class AddVehicle : Form
    {
        public AddVehicle()
        {
            InitializeComponent();
        }

        #region Properties
        public string id;
        public string type;
        public int Execute = 0;
        #endregion
        private void AddVehicle_Load(object sender, EventArgs e)
        {
            fillTB();
            ParkingLotDAL.Instance.loadListIDCard();    //Load thẻ xe
            formatTime();
        }

        void formatTime()
        {
            cbboxTimeFormat.DataSource = InvoiceDAL.Instance.getAllInvoice();
            cbboxTimeFormat.DisplayMember = "Description";
            cbboxTimeFormat.ValueMember = "InvoiceID";
            cbboxTimeFormat.SelectedItem = null;
        }

        void fillTB()
        {
            tbType.Text = type;
            tbVehicleID.Text = tbType.Text.ToString() + id;
            tbCustomerID.Text = Variable.Cus + ParkingLotDAL.Instance.takeID(Variable.Cus);
        }

        #region thêm khách
        bool verifCus()
        {
            if (tbName.Text.Trim() == "" || tbPhone.Text.Trim() == "" 
                || tbAddress.Text.Trim() == "" || tbIdentity.Text.Trim() == "" || CustomerPic.Image == null)
                return false;
            else
                return true;
        }

        private void btnAddCus_Click(object sender, EventArgs e)
        {
            //Khách
            string CusID = Variable.Cus + ParkingLotDAL.Instance.takeID(Variable.Cus);
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
                        if (ParkingLotDAL.Instance.addCustomer(CusID, FullName, Birth, Phone, Address, Identity, CusPic))
                        {
                            MessageBox.Show("Add new Customer successfully!", "Add Customer");
                            Execute += 1;
                            showUpForm();
                        }
                        else
                        {
                            MessageBox.Show("Add new Customer fail!!!", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill all the information!!", "Add Customer");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region thêm xe
        public void showUpForm()
        {
            pnlCus.Enabled = false;
            pnlCus.Visible = false;
            btnAddCus.Enabled = false;
            btnAddCus.Visible = false;
        }

        bool verifVeh()
        {
            if (tbLicense.Text.Trim() == "" || VehiclePic.Image == null)
                return false;
            else
                return true;
        }
        private void btnAddVeh_Click(object sender, EventArgs e)
        {
            //Xe
            string VehID = tbType.Text.ToString() + id;
            string Type = tbType.Text;
            string License = tbLicense.Text;
         
            string CusID = tbCustomerID.Text;
            string Invoice = cbboxTimeFormat.SelectedValue.ToString();
            int value = Convert.ToInt32(numerudValue.Value);                    //thời gian mà khách muốn gửi

            try
            {
                MemoryStream VehPic = new MemoryStream();
                VehiclePic.Image.Save(VehPic, VehiclePic.Image.RawFormat);

                if (verifVeh())
                {
                    if (ParkingLotDAL.Instance.addVehicle(VehID, Type, License, VehPic, CusID))
                    {
                        int idcard = ParkingLotDAL.Instance.createIDParkCard();
                        ParkingLotDAL.Instance.addCarAndCusToParklot(idcard, Variable.Cus + (Convert.ToInt32(ParkingLotDAL.Instance.takeID(Variable.Cus)) - 1).ToString(), (type + id), DateTime.Now, value, Invoice);
                        MessageBox.Show("Add new vehicle successfully! \r\nYour ID card is " + idcard, "Add Vehicle");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Add new vehicle fail!!!", "Add Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all the information!!", "Add Vehicle");
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
            if(Execute == 1)
            {
                ParkingLotDAL.Instance.deleteCustomer(Variable.Cus + (Convert.ToInt32(ParkingLotDAL.Instance.takeID(Variable.Cus)) - 1).ToString());
            }
            this.DialogResult = DialogResult.Cancel;
        }

        #region Tải hình
        private void VehiclePic_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.png; *.jpg; *.gif) | *.png; *.jpg; *.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                VehiclePic.Image = Image.FromFile(opf.FileName);
            }
        }
        private void CustomerPic_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.png; *.jpg; *.gif) | *.png; *.jpg; *.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                CustomerPic.Image = Image.FromFile(opf.FileName);
            }
        }
        #endregion

    }
}
