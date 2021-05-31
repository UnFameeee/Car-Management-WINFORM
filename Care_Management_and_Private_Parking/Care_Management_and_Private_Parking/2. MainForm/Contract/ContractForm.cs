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
//Word
using Word = Microsoft.Office.Interop.Word;


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

                if (purpose == "CHO THUÊ")                                          //khách là người thuê
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

                        if (frm.cbVehType.SelectedItem.ToString() == "Xe đạp")
                            vehtype = "bicycle";
                        else if (frm.cbVehType.SelectedItem.ToString() == "Xe máy")
                            vehtype = "bike";
                        else
                            vehtype = "car";

                        vehpic = new MemoryStream();
                        frm.VehPic.Image.Save(vehpic, frm.VehPic.Image.RawFormat);

                        SqlCommand com = new SqlCommand("select VehID from VEHICLE where VehType = '" + vehtype.ToString() + "' and VehID LIKE '%veh%' and LicensePlate = '" + license.ToString() + "'");
                        DataTable tab = ParkingLotDAL.Instance.getDataWithPurpose(com);
                        vehid = tab.Rows[0][0].ToString();

                        //phần nội dung
                        DateTime register = DateTime.Now;
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
                            if (ContractDAL.Instance.checkContract("cont" + contid))
                            {
                                if (ContractDAL.Instance.insertContract("cont" + contid, cusid, UserID.GlobalUserID, purpose, vehid, register, timevalue, timeformat, price, feefactor))
                                {
                                    if (InvoiceDAL.Instance.checkContractDate(register.Day, register.Month, register.Year))
                                    {
                                        if (InvoiceDAL.Instance.updateContractProfit(register.Day, register.Month, register.Year, price))
                                        {
                                            MessageBox.Show("Add Contract Successfully", "Add Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            btnRefresh.PerformClick();
                                        }
                                    }
                                    else
                                    {
                                        if (InvoiceDAL.Instance.insertContractProfit(register.Day, register.Month, register.Year, price))
                                        {
                                            MessageBox.Show("Add Contract Successfully", "Add Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            btnRefresh.PerformClick();
                                        }
                                    }
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

                        if (frm.cbVehType.SelectedItem.ToString() == "Xe đạp")
                            vehtype = "bicycle";
                        else if (frm.cbVehType.SelectedItem.ToString() == "Xe máy")
                            vehtype = "bike";
                        else
                            vehtype = "car";

                        vehpic = new MemoryStream();
                        frm.VehPic.Image.Save(vehpic, frm.VehPic.Image.RawFormat);

                        //phần nội dung
                        DateTime register = DateTime.Now;
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
                                    if (ContractDAL.Instance.insertContract("cont" + contid, cusid, UserID.GlobalUserID, purpose, vehid, register, timevalue, timeformat, price, feefactor))
                                    {
                                        if (InvoiceDAL.Instance.checkContractDate(register.Day, register.Month, register.Year))
                                        {
                                            if (InvoiceDAL.Instance.updateContractProfit(register.Day, register.Month, register.Year, -price))
                                            {
                                                MessageBox.Show("Add Contract Successfully", "Add Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                btnRefresh.PerformClick();
                                            }
                                        }
                                        else
                                        {
                                            if (InvoiceDAL.Instance.insertContractProfit(register.Day, register.Month, register.Year, -price))
                                            {
                                                MessageBox.Show("Add Contract Successfully", "Add Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                btnRefresh.PerformClick();
                                            }
                                        }
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
            DateTime today = DateTime.Now;
            string contid = frm.tbContractID.Text;

            DataTable tab;
            string vehid;
            string cusid;
            string purpose;
            int price;
            int factor;                                             //hệ số phạt

            if (contid != "")
            {
                tab = ContractDAL.Instance.getContractInfo("cont" + contid);
                cusid = tab.Rows[0][3].ToString();
                purpose = tab.Rows[0][1].ToString();
                vehid = tab.Rows[0][4].ToString();
                price = Convert.ToInt32(tab.Rows[0][8].ToString());
                factor = Convert.ToInt32(tab.Rows[0][9].ToString());

                if (ContractDAL.Instance.checkContract(contid))
                {
                    if (purpose == "THUÊ")                                              //mình là người thuê
                    {
                        if (!checkLate(contid, today))                          //huỷ đúng thời hạn
                        {
                            if (ContractDAL.Instance.removeContract("cont" + contid))
                            {
                                if (ContractDAL.Instance.deleteVehicle(vehid))
                                {
                                    if (ContractDAL.Instance.deleteCustomer(cusid))
                                    {
                                        MessageBox.Show("Remove Contract Successfully", "Remove Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        btnRefresh.PerformClick();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Can't remove Customer!", "Remove Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Can't remove Vehicle!", "Remove Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Can't remove Contract!", "Remove Contract", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else                                                    //vi phạm hợp đồng
                        {
                            MessageBox.Show("Breach of Contract!!!", "Remove Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BreachOfContract frm = new BreachOfContract();
                            frm.ShowDialog();
                            string side = frm.side;

                            int money;

                            if (side == "Lessor")                               //bên cho thuê (khách) vi phạm hợp đồng
                            {
                                money = price * factor;
                                if (ContractDAL.Instance.removeContract("cont" + contid))
                                {
                                    if (ContractDAL.Instance.deleteVehicle(vehid))
                                    {
                                        if (ContractDAL.Instance.deleteCustomer(cusid))
                                        {
                                            if (InvoiceDAL.Instance.checkContractDate(today.Day, today.Month, today.Year))
                                            {
                                                if (InvoiceDAL.Instance.updateContractProfit(today.Day, today.Month, today.Year, money))
                                                {
                                                    MessageBox.Show("Lessor have to pay fee " + money, "Remove Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    btnRefresh.PerformClick();                          //reload
                                                }
                                            }
                                            else
                                            {
                                                if (InvoiceDAL.Instance.insertContractProfit(today.Day, today.Month, today.Year, money))
                                                {
                                                    MessageBox.Show("Lessor have to pay fee " + money, "Remove Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    btnRefresh.PerformClick();                          //reload
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Can't remove Customer!", "Remove Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Can't remove Vehicle!", "Remove Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Can't remove Contract!", "Remove Contract", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else                                                //bên thuê (mình) vi phạm
                            {
                                money = -price * factor;
                                if (ContractDAL.Instance.removeContract("cont" + contid))
                                {
                                    if (ContractDAL.Instance.deleteVehicle(vehid))
                                    {
                                        if (ContractDAL.Instance.deleteCustomer(cusid))
                                        {
                                            if (InvoiceDAL.Instance.checkContractDate(today.Day, today.Month, today.Year))
                                            {
                                                if (InvoiceDAL.Instance.updateContractProfit(today.Day, today.Month, today.Year, money))
                                                {
                                                    MessageBox.Show("Renter have to pay fee " + -money, "Remove Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    btnRefresh.PerformClick();                          //reload
                                                }
                                            }
                                            else
                                            {
                                                if (InvoiceDAL.Instance.insertContractProfit(today.Day, today.Month, today.Year, money))
                                                {
                                                    MessageBox.Show("Renter have to pay fee " + -money, "Remove Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    btnRefresh.PerformClick();                          //reload
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Can't remove Customer!", "Remove Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Can't remove Vehicle!", "Remove Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Can't remove Contract!", "Remove Contract", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }                                              
                    }

                    else                                                                //mình là người cho thuê
                    {
                        if (!checkLate(contid, today))                       //đúng thời hạn
                        {
                            if (ContractDAL.Instance.removeContract("cont" + contid))
                            {
                                if (ContractDAL.Instance.deleteCustomer(cusid))
                                {
                                    MessageBox.Show("Remove Contract Successfully", "Remove Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    btnRefresh.PerformClick();                              //reload
                                }
                                else
                                {
                                    MessageBox.Show("Can't remove Customer!", "Remove Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Can't remove Contract!", "Remove Contract", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else                                                            //vi phạm thời hạn
                        {
                            MessageBox.Show("Breach of contract!!!", "Remove Contract", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            BreachOfContract frm = new BreachOfContract();
                            frm.ShowDialog();
                            string side = frm.side;

                            int money;

                            if (side == "Renter")                                       //bên thuê (khách) vi phạm hợp đồng
                            {
                                money = price * factor;
                                if (ContractDAL.Instance.removeContract("cont" + contid))
                                {
                                    if (ContractDAL.Instance.deleteCustomer(cusid))
                                    {
                                        if (InvoiceDAL.Instance.checkContractDate(today.Day, today.Month, today.Year))
                                        {
                                            if (InvoiceDAL.Instance.updateContractProfit(today.Day, today.Month, today.Year, money))
                                            {
                                                MessageBox.Show("Renter have to pay fee " + money, "Remove Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                btnRefresh.PerformClick();                          //reload
                                            }
                                        }
                                        else
                                        {
                                            if (InvoiceDAL.Instance.insertContractProfit(today.Day, today.Month, today.Year, money))
                                            {
                                                MessageBox.Show("Renter have to pay fee " + money, "Remove Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                btnRefresh.PerformClick();                          //reload
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Can't remove Customer!", "Remove Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Can't remove Contract!", "Remove Contract", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else                                                //bên thuê (mình) vi phạm
                            {
                                money = -price * factor;
                                if (ContractDAL.Instance.removeContract("cont" + contid))
                                {
                                    if (ContractDAL.Instance.deleteCustomer(cusid))
                                    {
                                        if (InvoiceDAL.Instance.checkContractDate(today.Day, today.Month, today.Year))
                                        {
                                            if (InvoiceDAL.Instance.updateContractProfit(today.Day, today.Month, today.Year, money))
                                            {
                                                MessageBox.Show("Lessor have to pay fee " + -money, "Remove Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                btnRefresh.PerformClick();                          //reload
                                            }
                                        }
                                        else
                                        {
                                            if (InvoiceDAL.Instance.insertContractProfit(today.Day, today.Month, today.Year, money))
                                            {
                                                MessageBox.Show("Lessor have to pay fee " + -money, "Remove Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                btnRefresh.PerformClick();                          //reload
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Can't remove Customer!", "Remove Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Can't remove Contract!", "Remove Contract", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }                        
                    }
                }
                else
                {
                    MessageBox.Show("Can't Find ContractID cont" + contid, "Remove Contract", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            frm.cbboxPurpose.SelectedIndex = -1;
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
            frm.cbVehType.SelectedIndex = -1;
            frm.tbForRentVehLicense.Text = null;
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
            frm.cbboxTimeFormat.SelectedIndex = -1;
            frm.tbPrice.Text = null;
            frm.cbboxFee.SelectedIndex = -1;
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
                    else type = "Xe hơi";

                    if (purpose == "CHO THUÊ")
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

                        //bên cho thuê
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

        bool checkLate(string contid, DateTime left)
        {
            DataTable tab = ContractDAL.Instance.getContractInfo("cont" + contid);

            DateTime register = Convert.ToDateTime(tab.Rows[0][5]);
            int value = Convert.ToInt32(tab.Rows[0][6]);
            string timeformat = tab.Rows[0][7].ToString();

            DateTime leave;                                                         //thời gian dự kiến kết thúc hợp đồng

            if (timeformat == "Day")
                leave = register.AddDays(value);
            else if (timeformat == "Month")
                leave = register.AddMonths(value);
            else leave = register.AddYears(value);

            int check = DateTime.Compare(left, leave);                              //kiểm tra so sánh ngày

            if (check == 0)                                                         //ngày ra cùng vói ngày dự kiến -> đúng thời hạn
                return false;
            else return true;                                                       //trễ hoặc trước thời hạn
        }

        #region in file word
        private void btnExportToWord_Click(object sender, EventArgs e)
        {
            if(verif())
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Word Documents (*.docx)|*.docx";
                sfd.FileName = "SalaryEmployee.docx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (Export_Data_To_Word(sfd.FileName))
                    {
                        MessageBox.Show("Successful!!!", "Save to file word", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessful!!!", "Save to file word", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all the information!!!", "Export to word", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #region Di chuyển con trỏ xuống cuối cùng
        private void moveCursor(ref Word.Document oDoc)
        {
            object StartPos = 0;
            object Endpos = 1;
            Microsoft.Office.Interop.Word.Range rng = oDoc.Range(ref StartPos, ref Endpos);
            object NewEndPos = rng.StoryLength - 1;
            rng = oDoc.Range(ref NewEndPos, ref NewEndPos);
            rng.Select();
        }
        #endregion
        public bool Export_Data_To_Word(string filename)
        {
            #region Variable
            Word.Document oDoc = new Word.Document();
            oDoc.Application.Visible = true;
            object missing = System.Reflection.Missing.Value;
            object oCollapseEnd = Word.WdCollapseDirection.wdCollapseEnd;
            #endregion

            #region Auto Pagenumber
            oDoc.ActiveWindow.View.Type = Word.WdViewType.wdPrintView;
            object nullobject = System.Reflection.Missing.Value;
            oDoc.ActiveWindow.ActivePane.View.SeekView = Word.WdSeekView.wdSeekPrimaryFooter;
            oDoc.ActiveWindow.Selection.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
            oDoc.ActiveWindow.Selection.Font.Name = "Arial";
            oDoc.ActiveWindow.Selection.Font.Bold = 1;
            oDoc.ActiveWindow.Selection.Font.Size = 14;
            oDoc.ActiveWindow.Selection.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;
            Object CurrentPage = Word.WdFieldType.wdFieldPage;
            oDoc.ActiveWindow.Selection.Fields.Add(oDoc.ActiveWindow.Selection.Range, ref CurrentPage, ref nullobject, ref nullobject);
            #endregion

            #region Set cấu hình font chữ của toàn word
            oDoc.Content.Font.Size = 12;
            oDoc.Content.Font.Bold = 0;
            oDoc.Content.Font.Name = "Times new roman";
            oDoc.Content.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
            oDoc.Content.InsertParagraphAfter();
            #endregion

            #region Cài đặt chữ phần trên
            moveCursor(ref oDoc);
            Microsoft.Office.Interop.Word.Paragraph paraHead = oDoc.Content.Paragraphs.Add(ref missing);
            object styleHeadingHead = "Heading 1";
            paraHead.Range.set_Style(ref styleHeadingHead);
            paraHead.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;
            paraHead.Range.Font.Bold = 1;
            paraHead.Range.Font.Size = 14;
            paraHead.Range.Font.Name = "Times new roman";
            paraHead.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
            paraHead.Range.Text = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM\r\nĐỘC LẬP-TỰ DO-HẠNH PHÚC\r\nHợp Đồng\r\n" + frm.cbboxPurpose.SelectedItem.ToString() + "\r\nSố: " + frm.tbContractID.Text;
            paraHead.Range.InsertParagraphAfter();
            moveCursor(ref oDoc);

            Microsoft.Office.Interop.Word.Paragraph para1 = oDoc.Content.Paragraphs.Add(ref missing);
            object styleHeading1 = "Heading 1";
            para1.Range.set_Style(ref styleHeading1);
            para1.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;
            para1.Range.Font.Size = 10;
            para1.Range.Font.Name = "Times new roman";
            para1.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
            para1.Range.Text = "Theo văn bản (quyết định, phê duyệt, đề nghị) hoặc sự thỏa thuận của đôi bên\r\nHôm nay, " + frm.tbDateStart.Text + " tại TPHCM, Chúng tôi gồm các bên dưới đây: \r\n";
            para1.Range.InsertParagraphAfter();
            moveCursor(ref oDoc);

            //Cho thuê
            Microsoft.Office.Interop.Word.Paragraph para2 = oDoc.Content.Paragraphs.Add(ref missing);
            object styleHeading2 = "Heading 1";
            para2.Range.set_Style(ref styleHeading2);
            para2.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;
            para2.Range.Font.Bold = 1;
            para2.Range.Font.Size = 13;
            para2.Range.Font.Name = "Times new roman";
            para2.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
            para2.Range.Text = "1. Bên cho thuê" + "\r\n";
            para2.Range.InsertParagraphAfter();

            moveCursor(ref oDoc);

            Microsoft.Office.Interop.Word.Paragraph para3 = oDoc.Content.Paragraphs.Add(ref missing);
            object styleHeading3 = "Heading 1";
            para3.Range.set_Style(ref styleHeading3);
            para3.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;
            para3.Range.Font.Size = 10;
            para3.Range.Font.Name = "Times new roman";
            para3.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
            para3.Range.Text = "Người đại diện: " + frm.tbForRentName.Text + "                                                  Chức vụ: " + frm.tbForRentJob.Text + "\r\n"
                             + "Điện thoại: " + frm.tbForRentPhone.Text + "                                                         Ngày sinh: " + frm.tbForRentBdate.Text + "\r\n"
                             + "CMND: " + frm.tbForRentIdentity.Text + "                                                                Ký tên:                     \r\n"
                             + "Địa chỉ: " + frm.tbForRentAddress.Text + "\r\n"
                             + "Loại xe: " + frm.cbVehType.Text + "\r\n"
                             + "Biển số xe" + frm.tbForRentVehLicense.Text + "\r\n" + "\r\n";
            para3.Range.InsertParagraphAfter();
            moveCursor(ref oDoc);

            //Thuê
            Microsoft.Office.Interop.Word.Paragraph para4 = oDoc.Content.Paragraphs.Add(ref missing);
            object styleHeading4 = "Heading 1";
            para4.Range.set_Style(ref styleHeading4);
            para4.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;
            para4.Range.Font.Bold = 1;
            para4.Range.Font.Size = 13;
            para4.Range.Font.Name = "Times new roman";
            para4.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
            para4.Range.Text = "2. Bên thuê" + "\r\n";
            para4.Range.InsertParagraphAfter();

            moveCursor(ref oDoc);

            Microsoft.Office.Interop.Word.Paragraph para5 = oDoc.Content.Paragraphs.Add(ref missing);
            object styleHeading5 = "Heading 1";
            para5.Range.set_Style(ref styleHeading5);
            para5.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;
            para5.Range.Font.Size = 10;
            para5.Range.Font.Name = "Times new roman";
            para5.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
            para5.Range.Text = "Người đại diện: " + frm.tbRentName.Text + "                                                  Chức vụ: " + frm.tbRentJob.Text + "\r\n"
                             + "Điện thoại: " + frm.tbRentPhone.Text + "                                                        Ngày sinh: " + frm.tbRentBdate.Text + "\r\n"
                             + "CMND: " + frm.tbRentIdentity.Text + "                                                           Ký tên:                     \r\n"
                             + "Địa chỉ: " + frm.tbRentAddress.Text + "\r\n";
            para5.Range.InsertParagraphAfter();
            moveCursor(ref oDoc);

            //Nội dung
            Microsoft.Office.Interop.Word.Paragraph para6 = oDoc.Content.Paragraphs.Add(ref missing);
            object styleHeading6 = "Heading 1";
            para6.Range.set_Style(ref styleHeading6);
            para6.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;
            para6.Range.Font.Bold = 1;
            para6.Range.Font.Size = 13;
            para6.Range.Font.Name = "Times new roman";
            para6.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
            para6.Range.Text = "Nội dụng hợp đồng:" + "\r\n";
            para6.Range.InsertParagraphAfter();

            moveCursor(ref oDoc);

            Microsoft.Office.Interop.Word.Paragraph para7 = oDoc.Content.Paragraphs.Add(ref missing);
            object styleHeading7 = "Heading 1";
            para7.Range.set_Style(ref styleHeading7);
            para7.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;
            para7.Range.Font.Size = 10;
            para7.Range.Font.Name = "Times new roman";
            para7.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
            para7.Range.Text = "Thời hạn: " + frm.tbTime.Text + "\r\n"                                           
                             + "Giá cả thương lượng: " + frm.tbPrice.Text + " VNĐ\r\n"
                             + "Đền bù (Hủy hợp đồng trước và sau thời hạn): " + frm.tbRentIdentity.Text + "x" + frm.cbboxFee.SelectedItem.ToString() + " VNĐ\r\n" + "\r\n" + "\r\n";
            para7.Range.InsertParagraphAfter();
            moveCursor(ref oDoc);



            #endregion

            //Page orinatation
            oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
            dynamic oRange = oDoc.Content.Application.Selection.Range;

            #region Phần nội dung phía dưới Table (Đã add bên trên)
            moveCursor(ref oDoc);
            Microsoft.Office.Interop.Word.Paragraph para10 = oDoc.Content.Paragraphs.Add(ref missing);
            object styleHeading10 = "Heading 2";
            para10.Range.set_Style(ref styleHeading2);
            para10.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;
            para10.Range.Font.Name = "Times new roman";
            para10.Range.Font.Size = 12;
            para10.Range.Text = "\nNgày....Tháng....Năm....";
            para10.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
            para10.Range.InsertParagraphAfter();

            moveCursor(ref oDoc);
            Microsoft.Office.Interop.Word.Paragraph para11 = oDoc.Content.Paragraphs.Add(ref missing);
            object styleHeading11 = "Heading 3";
            para11.Range.set_Style(ref styleHeading11);
            para11.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;
            para11.Range.Font.Name = "Times new roman";
            para11.Range.Font.Size = 12;
            para11.Range.Text = "\n\n        Người lập                       Quản lý trực tiếp               Giám đốc bộ phận                Giám đốc nhân sự                Giám đốc điều hành";
            para11.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
            para11.Range.InsertParagraphAfter();
            #endregion

            moveCursor(ref oDoc);

            //Save the file
            oDoc.SaveAs(filename);
            return true;
            #endregion
        
        }
    }
}
