using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            if (cbboxPurpose.SelectedItem == "THUÊ")
            {
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
}
