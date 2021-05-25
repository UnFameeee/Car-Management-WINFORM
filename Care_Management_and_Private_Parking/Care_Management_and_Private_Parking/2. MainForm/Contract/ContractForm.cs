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

namespace Care_Management_and_Private_Parking
{
    public partial class ContractForm : Form
    {
        public ContractForm()
        {
            InitializeComponent();
        }

        #region Properties
        private bool success = false;
        #endregion

        Contract frm = new Contract() { TopLevel = false, TopMost = false };

        private void ContractForm_Load(object sender, EventArgs e)
        {
            pnContract.Controls.Add(frm);
            frm.Show();
        }

        //private bool verif()
        //{
        //    if (frm.tbRentName.Text == "" || )
        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string contid = frm.tbContractInfo.Text;
            string purpose = frm.cbboxPurpose.SelectedIndex.ToString();
            //Phần khách
            string name;
            string phone;
            string identity;
            string address;
            string email;
            MemoryStream cuspic;

            //phần nhân viên
            //Phần này thì chỉ cần truy vấn từ GlobalID

            //Phần xe
            string vehtype;
            string license;
            MemoryStream vehpic;

            if (purpose == "THUÊ")  //mình là người thuê
            {
                name = frm.tbRentName.Text;
                phone = frm.tbRentPhone.Text;
                identity = frm.tbRentIdentity.Text;
                address = frm.tbRentAddress.Text;
                email = frm.tbRentMail.Text;
                //ảnh cus
                if(frm.ForRentCusPic.Image != null)
                {
                    cuspic = new MemoryStream();
                    frm.ForRentCusPic.Image.Save(cuspic, frm.ForRentCusPic.Image.RawFormat);
                    success = true;
                }
                else
                {
                    success = false;
                    MessageBox.Show("Please add the human forrent's picture!!!", "Add contract", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //thông tin xe
                if (frm.cbVehType.SelectedValue.ToString() == "Xe Đạp")
                    vehtype = "bicycle";
                else if (frm.cbVehType.SelectedValue.ToString() == "Xe Máy")
                    vehtype = "bike";
                else
                    vehtype = "car";
                license = frm.tbForRentVehLicense.Text;

                //ảnh xe
                if (frm.VehPic.Image != null)
                {
                    vehpic = new MemoryStream();
                    frm.VehPic.Image.Save(vehpic, frm.VehPic.Image.RawFormat);
                    success = true;
                }
                else
                {
                    success = false;
                    MessageBox.Show("Please add the human forrent's picture!!!", "Add contract", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else                    //Mình là người cho thuê
            {
                //Chưa làm xong
                if (frm.RentCusPic.Image != null)
                {
                    vehpic = new MemoryStream();
                    frm.ForRentCusPic.Image.Save(vehpic, frm.ForRentCusPic.Image.RawFormat);
                    success = true;
                }
                else
                {
                    MessageBox.Show("Please add the human rent's picture!!!", "Add contract", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if(success)
            {
                //chạy add khách trước -> add xe --> add contract
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
