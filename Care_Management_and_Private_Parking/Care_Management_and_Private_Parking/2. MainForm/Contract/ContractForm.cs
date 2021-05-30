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
            string timeformat;            

            int price;                                                          //giá trị hợp đồng
            int feefactor;                                                         //hệ số phạt khi huỷ hợp đồng

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
                        address = frm.tbRentAddress.Text;
                        cuspic = new MemoryStream();            
                        frm.RentPic.Image.Save(cuspic, frm.RentPic.Image.RawFormat);

                        //thông tin xe cho thuê
                        license = frm.tbForRentVehLicense.Text;

                        if (frm.cbVehType.SelectedItem.ToString() == "Xe Đạp")
                            vehtype = "bicycle";
                        else if (frm.cbVehType.SelectedItem.ToString() == "Xe Máy")
                            vehtype = "bike";
                        else
                            vehtype = "car";

                        vehpic = new MemoryStream();
                        frm.VehPic.Image.Save(vehpic, frm.VehPic.Image.RawFormat);

                        SqlCommand com = new SqlCommand("select VehID from VEHICLE where VehType = '" + vehtype + "' and CusID is null and LicensePlate = '" + license + "'");
                        DataTable tab = ParkingLotDAL.Instance.getDataWithPurpose(com);
                        vehid = tab.Rows[0][0].ToString();

                        //phần nội dung
                        timevalue = Convert.ToInt32(frm.tbTime.Text);

                        if (frm.cbboxTimeFormat.SelectedItem.ToString() == "Ngày")
                            timeformat = "Day";
                        else if (frm.cbboxTimeFormat.SelectedItem.ToString() == "Tháng")
                            timeformat = "Month";
                        else 
                            timeformat = "Year";

                        price = Convert.ToInt32(frm.tbPrice.Text);
                        feefactor = Convert.ToInt32(frm.cbboxFee.SelectedItem);

                        if (ParkingLotDAL.Instance.addCustomer(cusid, name, Convert.ToDateTime(bdate), phone, address, identity, cuspic))
                        {
                            if (ContractDAL.Instance.checkContract("Cont" + contid))
                            {
                                if (ContractDAL.Instance.insertContract("Cont" + contid, cusid, UserID.GlobalUserID, purpose, vehid, DateTime.Now, timevalue, timeformat, price, feefactor))
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
                                MessageBox.Show("This ContractID Already Exist", "Add Contract", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("There's something wrong with Customer info", "Error Customer info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please fill all empty field!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else                                                            //Mình là người thuê
                {
                    if (verif())
                    {
                        contid = frm.tbContractID.Text;                         //id hợp đồng

                        //thông tin khách 
                        cusid = Variable.Cus + ContractDAL.Instance.takeID(Variable.Cus);
                        name = frm.tbForRentName.Text;
                        phone = frm.tbForRentPhone.Text;
                        identity = frm.tbForRentIdentity.Text;
                        bdate = frm.tbForRentBdate.Text;
                        address = frm.tbForRentAddress.Text;
                        cuspic = new MemoryStream();
                        frm.ForRentPic.Image.Save(cuspic, frm.ForRentPic.Image.RawFormat);

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

                        if (frm.cbboxTimeFormat.SelectedItem.ToString() == "Ngày")
                            timeformat = "Day";
                        else if (frm.cbboxTimeFormat.SelectedItem.ToString() == "Tháng")
                            timeformat = "Month";
                        else
                            timeformat = "Year";

                        price = Convert.ToInt32(frm.tbPrice.Text);
                        feefactor = Convert.ToInt32(frm.cbboxFee.SelectedItem);

                        if (ParkingLotDAL.Instance.addCustomer(cusid, name, Convert.ToDateTime(bdate), phone, address, identity, cuspic))
                        {
                            if (ParkingLotDAL.Instance.addVehicle(vehid, vehtype, license, vehpic, cusid))
                            {
                                if (ContractDAL.Instance.checkContract("cont" + contid))
                                {
                                    if (ContractDAL.Instance.insertContract("cont" + contid, cusid, UserID.GlobalUserID, purpose, vehid, DateTime.Now, timevalue, timeformat, price, feefactor))
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
                                    MessageBox.Show("This ContractID Already Exist", "Add Contract", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("There's something wrong with Vehicle info!", "Error Vehicle info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("There's something wrong with Customer info!", "Error Customer info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill all empty field!!!", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please choose type of contract!!!", "ContractType Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (frm.tbContractID != null)
            {
                if(ContractDAL.Instance.removeContract(frm.tbContractID.Text))
                {
                    MessageBox.Show("Remove Contract Successfully", "Remove Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRefresh.PerformClick();              //reload
                }
                else
                {
                    MessageBox.Show("Can't Remove Contract", "Remove Contract", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("Please insert ContractID!!!", "ContractID Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //thông tin hợp đồng
            frm.cbboxPurpose.SelectedItem = null;
            frm.tbContractID.Text = null;
            frm.tbDateStart.Text = null;

            //bên cho thuê
            frm.tbForRentName.Text = null;
            frm.tbForRentPhone.Text = null;
            frm.tbForRentAddress.Text = null;
            frm.tbForRentIdentity.Text = null;
            frm.tbForRentBdate.Text = null;
            frm.tbForRentJob.Text = null;
            frm.ForRentPic.Image = null;

            //xe
            frm.cbVehType.SelectedItem = null;
            frm.tbForRentVehLicense = null;
            frm.VehPic.Image = null;

            //thông tin bên thuê
            frm.tbRentName.Text = null;
            frm.tbRentPhone.Text = null;
            frm.tbRentAddress.Text = null;
            frm.tbRentIdentity.Text = null;
            frm.tbRentBdate.Text = null;
            frm.tbRentJob.Text = null;
            frm.RentPic.Image = null;

            //nội dung
            frm.tbTime.Text = null;
            frm.cbboxTimeFormat.SelectedItem = null;
            frm.tbPrice.Text = null;
            frm.cbboxFee.SelectedItem = null;
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (frm.tbContractID.Text != null)
            {
                DataTable tab = ContractDAL.Instance.getContractInfo("cont" + frm.tbContractID.Text);
                if (tab.Rows.Count > 0)
                {
                    //thông tin hợp đồng
                    string purpose = tab.Rows[0][1].ToString();
                    DateTime start = Convert.ToDateTime(tab.Rows[0][5]);
                    int value = Convert.ToInt32(tab.Rows[0][6]);
                    string timeformat;
                    if (tab.Rows[0][7].ToString() == "Day")
                        timeformat = "Ngày";
                    else if (tab.Rows[0][7].ToString() == "Month")
                        timeformat = "Tháng";
                    else timeformat = "Năm";

                    int price = Convert.ToInt32(tab.Rows[0][8]);
                    int feefactor = Convert.ToInt32(tab.Rows[0][9]);

                    frm.tbDateStart.Text = start.ToString("dd/MM/yyyy");
                    frm.tbTime.Text = value.ToString();
                    frm.cbboxTimeFormat.SelectedItem = timeformat;
                    frm.tbPrice.Text = price.ToString();
                    frm.cbboxFee.SelectedItem = feefactor.ToString();

                    //thông tin nhân viên
                    string empid = tab.Rows[0][2].ToString();
                    DataTable emp = EmployeeDAL.Instance.getEmpByID(empid);

                    string ename = emp.Rows[0][1].ToString();
                    string ebdate = formatTime(emp.Rows[0][3].ToString());
                    string ephone = emp.Rows[0][4].ToString();
                    string eaddress = "TPHCM";
                    string eidentity = emp.Rows[0][5].ToString();
                    string email = emp.Rows[0][6].ToString();
                    string ejob = emp.Rows[0][7].ToString();                    

                    //thông tin khách
                    string cusid = tab.Rows[0][3].ToString();
                    SqlCommand com = new SqlCommand("select * from CUSTOMER where CusID = '" + cusid + "'");
                    DataTable cus = ParkingLotDAL.Instance.getDataWithPurpose(com);

                    string cname = cus.Rows[0][1].ToString();
                    string cbdate = formatTime(cus.Rows[0][2].ToString());
                    string cphone = cus.Rows[0][3].ToString();
                    string caddress = cus.Rows[0][4].ToString();
                    string cidentity = cus.Rows[0][5].ToString();
                    
                    //thông tin xe
                    string vehid = tab.Rows[0][4].ToString();
                    SqlCommand cmd = new SqlCommand("select * from VEHICLE where VehID = '" + vehid + "'");
                    DataTable veh = ParkingLotDAL.Instance.getDataWithPurpose(cmd);

                    string type;
                    string license = veh.Rows[0][2].ToString();

                    if (veh.Rows[0][1].ToString() == "bicycle")
                        type = "Xe đạp";
                    else if (veh.Rows[0][1].ToString() == "bike")
                        type = "Xe máy";
                    else type = "Xe đạp";

                    frm.cbVehType.SelectedItem = type;
                    frm.tbForRentVehLicense.Text = license;

                    if (veh.Rows[0][3] != DBNull.Value)
                    {
                        byte[] pic;
                        pic = (byte[])veh.Rows[0][3];
                        MemoryStream picture = new MemoryStream(pic);
                        frm.VehPic.Image = Image.FromStream(picture);
                    }

                    if (purpose == "THUÊ")
                    {
                        frm.cbboxPurpose.SelectedItem = purpose;

                        //bên cho thuê
                        frm.tbForRentName.Text = ename;
                        frm.tbForRentJob.Text = ejob;
                        frm.tbForRentPhone.Text = ephone;
                        frm.tbForRentAddress.Text = eaddress;
                        frm.tbForRentBdate.Text = ebdate;
                        frm.tbForRentIdentity.Text = eidentity;

                        if (emp.Rows[0][8] != DBNull.Value)
                        {
                            byte[] pic;
                            pic = (byte[])emp.Rows[0][8];
                            MemoryStream picture = new MemoryStream(pic);
                            frm.ForRentPic.Image = Image.FromStream(picture);
                        }

                        //bên thuê
                        frm.tbRentName.Text = cname;
                        frm.tbRentJob.Text = "Khách hàng";
                        frm.tbRentPhone.Text = cphone;
                        frm.tbRentBdate.Text = cbdate;
                        frm.tbRentAddress.Text = caddress;
                        frm.tbRentIdentity.Text = cidentity;

                        if (cus.Rows[0][6] != DBNull.Value)
                        {
                            byte[] pic;
                            pic = (byte[])cus.Rows[0][6];
                            MemoryStream picture = new MemoryStream(pic);
                            frm.RentPic.Image = Image.FromStream(picture);
                        }
                    }
                    else
                    {
                        frm.cbboxPurpose.SelectedItem = purpose;

                        //bên thuê
                        frm.tbRentName.Text = ename;
                        frm.tbRentJob.Text = ejob;
                        frm.tbRentPhone.Text = ephone;
                        frm.tbRentAddress.Text = eaddress;
                        frm.tbRentBdate.Text = ebdate;
                        frm.tbRentIdentity.Text = eidentity;

                        if (emp.Rows[0][8] != DBNull.Value)
                        {
                            byte[] pic;
                            pic = (byte[])emp.Rows[0][8];
                            MemoryStream picture = new MemoryStream(pic);
                            frm.RentPic.Image = Image.FromStream(picture);
                        }

                        //bên thuê
                        frm.tbForRentName.Text = cname;
                        frm.tbForRentJob.Text = "Khách hàng";
                        frm.tbForRentPhone.Text = cphone;
                        frm.tbForRentBdate.Text = cbdate;
                        frm.tbForRentAddress.Text = caddress;
                        frm.tbForRentIdentity.Text = cidentity;

                        if (cus.Rows[0][6] != DBNull.Value)
                        {
                            byte[] pic;
                            pic = (byte[])cus.Rows[0][6];
                            MemoryStream picture = new MemoryStream(pic);
                            frm.ForRentPic.Image = Image.FromStream(picture);
                        }

                        //thông tin xe
                        frm.cbVehType.SelectedItem = type;
                        frm.tbForRentVehLicense.Text = license;

                        if (veh.Rows[0][3] != DBNull.Value)
                        {
                            byte[] pic;
                            pic = (byte[])veh.Rows[0][3];
                            MemoryStream picture = new MemoryStream(pic);
                            frm.VehPic.Image = Image.FromStream(picture);
                        }                        
                    }
                }
                else
                {
                    MessageBox.Show("Can't Find ContractID cont" + frm.tbContractID.Text, "ContractID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                frm.btnVehList.Hide();
            }
            else
            {
                MessageBox.Show("Please insert ContractID!!!", "ContractID Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string formatTime(string time)
        {
            string dateNonTime = "";
            for (int i = 0; ; ++i)
            {
                if (time[i] == ' ')
                    break;
                dateNonTime += time[i];
            }
            return dateNonTime;
        }
    }
}
