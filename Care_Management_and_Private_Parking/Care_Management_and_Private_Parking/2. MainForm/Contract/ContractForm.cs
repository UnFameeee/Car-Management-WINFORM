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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string contid = frm.tbContractID.Text;
            string purpose = frm.cbboxPurpose.SelectedItem.ToString();
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

                if (verif())
                {
                    cuspic = new MemoryStream();
                    frm.ForRentPic.Image.Save(cuspic, frm.ForRentPic.Image.RawFormat);
                    success = true;

                    //thông tin xe
                    if (frm.cbVehType.SelectedValue.ToString() == "Xe Đạp")
                        vehtype = "bicycle";
                    else if (frm.cbVehType.SelectedValue.ToString() == "Xe Máy")
                        vehtype = "bike";
                    else
                        vehtype = "car";
                    license = frm.tbForRentVehLicense.Text;
                    vehpic = new MemoryStream();
                    frm.VehPic.Image.Save(vehpic, frm.VehPic.Image.RawFormat);
                    success = true;


                }
                
            }
            else                    //Mình là người cho thuê
            {
                vehpic = new MemoryStream();
                frm.ForRentPic.Image.Save(vehpic, frm.ForRentPic.Image.RawFormat);
                success = true;
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

        bool verif()
        {
            if (frm.cbboxPurpose.SelectedItem == null || frm.tbContractID.Text == ""
                || frm.tbForRentName.Text == "" || frm.tbForRentPhone.Text == ""
                || frm.tbForRentJob.Text == "" || frm.tbForRentAddress.Text == ""
                || frm.tbForRentIdentity.Text == "" || frm.tbForRentMail.Text == ""
                || frm.cbVehType.SelectedItem == null || frm.tbForRentVehLicense.Text == ""
                || frm.VehPic.Image == null || frm.ForRentPic.Image == null
                || frm.tbRentName.Text == "" || frm.tbRentPhone.Text == ""
                || frm.tbRentJob.Text == "" || frm.tbRentAddress.Text == ""
                || frm.tbRentIdentity.Text == "" || frm.tbRentMail.Text == ""
                || frm.RentPic.Image == null || frm.tbTime.Text == ""
                || frm.cbboxTimeFormat.SelectedItem == null || frm.tbPrice.Text == ""
                || frm.cbboxFee.SelectedItem == null) 
                return false;
            else return true;
        }
    }
}
