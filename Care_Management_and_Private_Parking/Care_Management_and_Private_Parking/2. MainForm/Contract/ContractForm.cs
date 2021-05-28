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
using Global;
using DAL;
using System.Data.SqlClient;

namespace Care_Management_and_Private_Parking
{
    public partial class ContractForm : Form
    {
        public ContractForm()
        {
            InitializeComponent();
        }

        Contract frm = new Contract() { TopLevel = false, TopMost = false };

        private void ContractForm_Load(object sender, EventArgs e)
        {
            pnContract.Controls.Add(frm);
            frm.Show();           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string contid;
            string purpose;

            //Phần khách
            string cusid;
            string name;
            string phone;
            string identity;
            string bdate;
            string address;
            MemoryStream cuspic;

            //Phần xe
            string vehid;
            string vehtype;
            string license;
            MemoryStream vehpic;

            //Phần nội dung
            int timevalue;                                                      //thời gian hết hạn
            DateTime end;            

            int price;                                                          //giá trị hợp đồng
            int factor;                                                         //hệ số phạt khi huỷ hợp đồng

            if (frm.cbboxPurpose.SelectedItem != null)
            {
                purpose = frm.cbboxPurpose.SelectedItem.ToString();

                if (purpose == "THUÊ")                                          //khách là người thuê
                {                                  
                    if (verif())
                    {
                        contid = frm.tbContractID.Text;                         //id hợp đồng

                        //thông tin khách 
                        cusid = Variable.Cus + ContractDAL.Instance.takeID(Variable.Cus);
                        name = frm.tbRentName.Text;
                        phone = frm.tbRentPhone.Text;
                        identity = frm.tbRentIdentity.Text;
                        bdate = frm.tbRentBdate.Text;
                        address = frm.tbForRentAddress.Text;
                        cuspic = new MemoryStream();            
                        frm.RentPic.Image.Save(cuspic, frm.RentPic.Image.RawFormat);

                        //thông tin xe cho thuê
                        vehid = Variable.Rental + ContractDAL.Instance.takeID(Variable.Rental);
                        license = frm.tbForRentVehLicense.Text;

                        if (frm.cbVehType.SelectedItem.ToString() == "Xe Đạp")
                            vehtype = "bicycle";
                        else if (frm.cbVehType.SelectedItem.ToString() == "Xe Máy")
                            vehtype = "bike";
                        else
                            vehtype = "car";

                        vehpic = new MemoryStream();
                        frm.VehPic.Image.Save(vehpic, frm.VehPic.Image.RawFormat);

                        //phần nội dung
                        timevalue = Convert.ToInt32(frm.tbTime.Text);
                        if (frm.cbboxTimeFormat.SelectedItem == "Ngày")
                            end = DateTime.Now.AddDays(timevalue);
                        else if (frm.cbboxTimeFormat.SelectedItem == "Tháng")
                            end = DateTime.Now.AddMonths(timevalue);
                        else
                            end = DateTime.Now.AddYears(timevalue);

                        price = Convert.ToInt32(frm.tbPrice.Text);
                        factor = Convert.ToInt32(frm.cbboxFee.SelectedItem);

                        if (ParkingLotDAL.Instance.addCustomer(cusid, name, Convert.ToDateTime(bdate), phone, address, identity, cuspic))
                        {
                            if (ContractDAL.Instance.insertContract(contid, cusid, UserID.GlobalUserID, purpose, vehid, DateTime.Now, end, price))
                            {
                                MessageBox.Show("Add Contract Successfully", "Add Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Cant't create contract", "Add Contract", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("ERROR!!!", "Customer's info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please fill all empty field!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else                    //Mình là người cho thuê
                {
                    vehpic = new MemoryStream();
                    frm.ForRentPic.Image.Save(vehpic, frm.ForRentPic.Image.RawFormat);
                }
            }
            else
            {
                MessageBox.Show("Please choose type of contract!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (frm.tbContractID.Text == "" || frm.cbboxFee.SelectedItem == null
                || frm.tbForRentName.Text == "" || frm.tbForRentPhone.Text == ""
                || frm.tbForRentJob.Text == "" || frm.tbForRentBdate.Text == ""
                || frm.tbForRentIdentity.Text == "" || frm.tbForRentAddress.Text == ""
                || frm.cbVehType.SelectedItem == null || frm.tbForRentVehLicense.Text == ""
                || frm.VehPic.Image == null || frm.ForRentPic.Image == null
                || frm.tbRentName.Text == "" || frm.tbRentPhone.Text == ""
                || frm.tbRentJob.Text == "" || frm.tbRentBdate.Text == ""
                || frm.tbRentIdentity.Text == "" || frm.tbRentAddress.Text == ""
                || frm.RentPic.Image == null || frm.tbTime.Text == ""
                || frm.cbboxTimeFormat.SelectedItem == null || frm.tbPrice.Text == "") 
                return false;
            else return true;
        }
    }
}
