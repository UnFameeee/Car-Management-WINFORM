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
        #endregion
        private void AddVehicle_Load(object sender, EventArgs e)
        {
            fillTB();
        }

        void fillTB()
        {
            //SqlCommand cmd = new SqlCommand("");

            tbVehicleID.Text = id;
            tbType.Text = type;
        }

        bool verif()
        {
            if (tbLicense.Text.Trim() == "" || tbName.Text.Trim() == ""
                || tbPhone.Text.Trim() == "" || tbAddress.Text.Trim() == "" || tbIdentity.Text.Trim() == ""
                || VehiclePic.Image == null || CustomerPic.Image == null)
                return false;
            else return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Xe
            string VehID = tbVehicleID.Text;
            string Type = tbType.Text;
            string License = tbLicense.Text;
            MemoryStream VehPic = new MemoryStream();
            VehiclePic.Image.Save(VehPic, VehiclePic.Image.RawFormat);

            //Khách
            string CusID = tbCustomerID.Text;
            string FullName = tbName.Text;
            DateTime Birth = datetime.Value;
            string Phone = tbPhone.Text;
            string Address = tbAddress.Text;
            string Identity = tbIdentity.Text;
            MemoryStream CusPic = new MemoryStream();
            CustomerPic.Image.Save(CusPic, VehiclePic.Image.RawFormat);

            int bornyear = datetime.Value.Year;
            int thisyear = DateTime.Now.Year;
            if ((thisyear - bornyear < 10) || (thisyear - bornyear > 100))
            {
                MessageBox.Show("The student age must be between 10 and 100 year", "Invalid Birth date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (verif())
                    {
                        if (ParkingLotDAL.Instance.addVehicle(VehID, Type, License, VehPic, CusID, FullName, Birth, Phone, Address, Identity, CusPic))
                        {
                            MessageBox.Show("Add new vehicle successfully!", "Add Vehicle");
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
        }

        private void btnExit_Click(object sender, EventArgs e)
        { 
            this.DialogResult = DialogResult.Cancel;
        }

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
    }
}
