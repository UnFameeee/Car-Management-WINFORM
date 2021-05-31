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
    public partial class Contract : Form
    {
        public Contract()
        {
            InitializeComponent();
        }

        private void RentCusPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                RentPic.Image = Image.FromFile(opf.FileName);
            }
        }

        private void VehPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                VehPic.Image = Image.FromFile(opf.FileName);
            }
        }

        private void ForRentCusPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                ForRentPic.Image = Image.FromFile(opf.FileName);
            }
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {       
            tbPrice2.Text = tbPrice.Text;
        }

        private void cbboxPurpose_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbDateStart.Text = DateTime.Now.ToString("dd/MM/yyyy");
            if(cbboxPurpose.SelectedIndex != -1)
            {
                DataTable tab = EmployeeDAL.Instance.getEmpByID(UserID.GlobalUserID);
                string empname = tab.Rows[0][1].ToString();

                string empbdate = "";
                for (int i = 0; ; ++i)      //format lại thành dd/MM/yy (bỏ time)
                {
                    if (tab.Rows[0][3].ToString()[i] == ' ')
                        break;
                    empbdate += tab.Rows[0][3].ToString()[i];
                }

                string empphone = tab.Rows[0][4].ToString();
                string empidentity = tab.Rows[0][5].ToString();

                string empjob;
                if (tab.Rows[0][7].ToString() == "Manager")
                    empjob = "Quản lý";
                else empjob = "Nhân viên văn phòng";

                cbVehType.SelectedItem = null;
                tbForRentVehLicense.Text = "";
                VehPic.Image = null;

                if (cbboxPurpose.SelectedItem.ToString() == "CHO THUÊ")
                {
                    btnVehList.Show();

                    tbForRentName.Text = empname;
                    tbForRentPhone.Text = empphone;
                    tbForRentAddress.Text = "TPHCM";
                    tbForRentIdentity.Text = empidentity;
                    tbForRentBdate.Text = empbdate;
                    tbForRentJob.Text = empjob;
                    if (tab.Rows[0][8] != DBNull.Value)
                    {
                        byte[] pic;
                        pic = (byte[])tab.Rows[0][8];
                        MemoryStream picture = new MemoryStream(pic);
                        ForRentPic.Image = Image.FromStream(picture);
                    }

                    tbForRentName.ReadOnly = true;
                    tbForRentPhone.ReadOnly = true;
                    tbForRentAddress.ReadOnly = true;
                    tbForRentIdentity.ReadOnly = true;
                    tbForRentBdate.ReadOnly = true;
                    tbForRentJob.ReadOnly = true;
                    ForRentPic.Enabled = false;

                    tbRentName.ReadOnly = false;
                    tbRentPhone.ReadOnly = false;
                    tbRentAddress.ReadOnly = false;
                    tbRentIdentity.ReadOnly = false;
                    tbRentBdate.ReadOnly = false;
                    tbRentJob.ReadOnly = false;
                    RentPic.Enabled = true;

                    tbRentName.Text = null;
                    tbRentPhone.Text = null;
                    tbRentAddress.Text = null;
                    tbRentIdentity.Text = null;
                    tbRentBdate.Text = null;
                    tbRentJob.Text = "Khách hàng";
                    RentPic.Image = null;
                }
                else
                {
                    btnVehList.Hide();

                    tbRentName.Text = empname;
                    tbRentPhone.Text = empphone;
                    tbRentAddress.Text = "TPHCM";
                    tbRentIdentity.Text = empidentity;
                    tbRentBdate.Text = empbdate;
                    tbRentJob.Text = empjob;
                    if (tab.Rows[0][8] != DBNull.Value)
                    {
                        byte[] pic;
                        pic = (byte[])tab.Rows[0][8];
                        MemoryStream picture = new MemoryStream(pic);
                        RentPic.Image = Image.FromStream(picture);
                    }

                    tbRentName.ReadOnly = true;
                    tbRentPhone.ReadOnly = true;
                    tbRentAddress.ReadOnly = true;
                    tbRentIdentity.ReadOnly = true;
                    tbRentBdate.ReadOnly = true;
                    tbRentJob.ReadOnly = true;
                    RentPic.Enabled = false;

                    tbForRentName.ReadOnly = false;
                    tbForRentPhone.ReadOnly = false;
                    tbForRentAddress.ReadOnly = false;
                    tbForRentIdentity.ReadOnly = false;
                    tbForRentBdate.ReadOnly = false;
                    tbForRentJob.ReadOnly = false;
                    ForRentPic.Enabled = true;

                    tbForRentName.Text = null;
                    tbForRentPhone.Text = null;
                    tbForRentAddress.Text = null;
                    tbForRentIdentity.Text = null;
                    tbForRentBdate.Text = null;
                    tbForRentJob.Text = "Khách hàng";
                    ForRentPic.Image = null;
                }
            }
        }

        private void Contract_Load(object sender, EventArgs e)
        {
            tbDateStart.Text = DateTime.Now.ToString("dd/MM/yyyy");
            btnVehList.Hide();
        }

        private void btnVehList_Click(object sender, EventArgs e)
        {
            if (cbVehType.SelectedItem == null)
            {
                MessageBox.Show("Please choose Type of Vehicle!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string vehtype;
                if (cbVehType.SelectedItem.ToString() == "Xe đạp")
                    vehtype = "bicycle";
                else if (cbVehType.SelectedItem.ToString() == "Xe máy")
                    vehtype = "bike";
                else
                    vehtype = "car";

                SqlCommand cmd = new SqlCommand("select * from VEHICLE where VehType = '" + vehtype + "' and VehID LIKE '%veh%'");
                DataTable table = ParkingLotDAL.Instance.getDataWithPurpose(cmd);

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("There are no vehicle for rent!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    VehList frm = new VehList();
                    frm.type = vehtype;
                    frm.ShowDialog();

                    SqlCommand com = new SqlCommand("select VehID, VehType, LicensePlate, Picture from VEHICLE where VehType = '" + frm.type + "' and VehID LIKE '%veh%'");
                    DataTable tab = ParkingLotDAL.Instance.getDataWithPurpose(com);

                    tbForRentVehLicense.Text = tab.Rows[0][2].ToString();

                    if (tab.Rows[0][3] != DBNull.Value)
                    {
                        byte[] pic;
                        pic = (byte[])tab.Rows[0][3];
                        MemoryStream picture = new MemoryStream(pic);
                        VehPic.Image = Image.FromStream(picture);
                    }
                    btnVehList.Hide();
                }               
            }
        }
    }
}
