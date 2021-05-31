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
            cbboxTimeFormat.DataSource = InvoiceDAL.Instance.getAllTimeFormat();
            cbboxTimeFormat.DisplayMember = "Description";
            cbboxTimeFormat.ValueMember = "ID";
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
                        if (ParkingLotDAL.Instance.checkIdentity("", Identity, "add"))
                        {
                            if (ParkingLotDAL.Instance.addCustomer(CusID, FullName, Birth, Phone, Address, Identity, CusPic))
                            {
                                MessageBox.Show("Add new Customer successfully!", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            MessageBox.Show("Identity " + Identity + " Already Exist!!!", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        public bool check()                         //kiểm tra xem có chọn service nào ko
        {
            if ((numerudValue.Text == "0" || cbboxTimeFormat.SelectedItem == null)
                && radiobtnRepair.Checked == false && radiobtnWash.Checked == false)
                return false;
            else return true;
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
            int value = Convert.ToInt32(numerudValue.Value);                                      //thời gian mà khách muốn gửi
            string Invoice = "null";
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
                    if (ParkingLotDAL.Instance.checkLicense(VehID, License, "add"))
                    {
                        if (check())
                        {
                            if (cbboxTimeFormat.SelectedItem != null)
                                Invoice = cbboxTimeFormat.SelectedValue.ToString();
                        else                                                            //khách không chọn timeformat -> mặc định là ko gửi xe
                        {
                            value = 0;
                        }
                            if (ParkingLotDAL.Instance.addVehicle(VehID, Type, License, VehPic, CusID))
                            {
                                int idcard = ParkingLotDAL.Instance.createIDParkCard();
                                ParkingLotDAL.Instance.addCarAndCusToParklot(idcard, Variable.Cus + (Convert.ToInt32(ParkingLotDAL.Instance.takeID(Variable.Cus)) - 1).ToString(), (type + id), DateTime.Now, value, Invoice, service);
                                MessageBox.Show("Add new vehicle successfully! \r\nYour ID card is " + idcard, "Add Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                MessageBox.Show("Add new vehicle fail!!!", "Add Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please choose at least one service!!!", "Add Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This License Plate has already existed!!!", "Add Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all vehicle information!!", "Add Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        #region Extension
        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) /*&& !char.IsDigit(e.KeyChar)*/ && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

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
