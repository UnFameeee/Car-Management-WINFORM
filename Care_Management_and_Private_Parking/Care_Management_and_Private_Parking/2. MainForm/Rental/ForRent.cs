using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Global;

namespace Care_Management_and_Private_Parking
{
    public partial class ForRent : Form
    {
        public ForRent()
        {
            InitializeComponent();
        }

        public string id;
        public string type;
        public string purpose;

        private void VehiclePic_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.png; *.jpg; *.gif) | *.png; *.jpg; *.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                VehiclePic.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnAddVeh_Click(object sender, EventArgs e)
        {
            string VehID = tbVehicleID.Text;
            string Type;
            string License = tbLicense.Text;
            MemoryStream VehPic;

            try
            {
                if (verif())
                {
                    Type = cbboxTypeVeh.SelectedItem.ToString();
                    VehPic = new MemoryStream();
                    VehiclePic.Image.Save(VehPic, VehiclePic.Image.RawFormat);

                    if (ParkingLotDAL.Instance.addRentalVehicle(VehID, Type, License, VehPic))
                    {
                        MessageBox.Show("Add Rental Vehicle Successfully", "Add Rental Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Can't Add Rental Vehicle", "Add Rental Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all Vehicle info!!!", "Add Rental Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ForRent_Load(object sender, EventArgs e)
        {
            tbVehicleID.Text = type + id;
            cbboxTypeVeh.SelectedItem = null;

            if (purpose == "add")
            {
                btnEdit.Hide();
                btnRemove.Hide();
            }
            else if (purpose == "edit")
            {
                btnAddVeh.Hide();
                btnRemove.Hide();
                labelHeader.Text = "EDIT RENTAL VEHICLE";

                SqlCommand com = new SqlCommand("select * from VEHICLE where VehID = '" + type + id + "'");
                DataTable tab = ParkingLotDAL.Instance.getDataWithPurpose(com);
                cbboxTypeVeh.SelectedItem = tab.Rows[0][1].ToString();
                tbLicense.Text = tab.Rows[0][2].ToString();

                if (tab.Rows[0][3] != DBNull.Value)
                {
                    byte[] pic;
                    pic = (byte[])tab.Rows[0][3];
                    MemoryStream picture = new MemoryStream(pic);
                    VehiclePic.Image = Image.FromStream(picture);
                }
            }
            else
            {
                btnAddVeh.Hide();
                btnEdit.Hide();
                labelHeader.Text = "REMOVE RENTAL VEHICLE";

                SqlCommand com = new SqlCommand("select * from VEHICLE where VehID = '" + type + id + "'");
                DataTable tab = ParkingLotDAL.Instance.getDataWithPurpose(com);
                cbboxTypeVeh.SelectedItem = tab.Rows[0][1].ToString();
                tbLicense.Text = tab.Rows[0][2].ToString();

                if (tab.Rows[0][3] != DBNull.Value)
                {
                    byte[] pic;
                    pic = (byte[])tab.Rows[0][3];
                    MemoryStream picture = new MemoryStream(pic);
                    VehiclePic.Image = Image.FromStream(picture);
                }

                cbboxTypeVeh.Enabled = false;
                tbLicense.Enabled = false;
                VehiclePic.Enabled = false;
            }
        }

        bool verif()
        {
            if (cbboxTypeVeh.SelectedItem == null || tbLicense.Text.Trim() == "" || VehiclePic.Image == null)
                return false;
            else return true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string VehID = tbVehicleID.Text;
            string Type;
            string License = tbLicense.Text;
            MemoryStream VehPic;

            try
            {
                if (verif())
                {
                    Type = cbboxTypeVeh.SelectedItem.ToString();
                    VehPic = new MemoryStream();
                    VehiclePic.Image.Save(VehPic, VehiclePic.Image.RawFormat);

                    if (ParkingLotDAL.Instance.updateRentalVehicle(VehID, Type, License, VehPic))
                    {
                        MessageBox.Show("Edit Rental Vehicle Successfully", "Edit Rental Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Can't Edit Rental Vehicle", "Edit Rental Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all Vehicle info!!!", "Edit Rental Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string VehID = tbVehicleID.Text;
            try
            {
                if (ParkingLotDAL.Instance.deleteVehicle(VehID))
                {
                    MessageBox.Show("Remove Rental Vehicle Successfully", "Remove Rental Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Can't Remove Rental Vehicle", "Remove Rental Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
