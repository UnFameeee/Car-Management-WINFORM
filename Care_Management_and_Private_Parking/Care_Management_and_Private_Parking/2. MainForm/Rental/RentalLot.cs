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
using Guna.UI2.WinForms;

//3 layers
using DAL;
using Global;

namespace Care_Management_and_Private_Parking
{
    public partial class RentalLot : Form
    {
        public RentalLot()
        {
            InitializeComponent();
            
        }

        private void RentalLot_Load(object sender, EventArgs e)
        {
            loadMatrixRent();
            fillSlot();
            changeColorLoad();   
        }

        #region Properties
        private List<List<Guna2Button>> matrixRent;
        public List<List<Guna2Button>> MatrixRent
        {
            get { return matrixRent; }
            set { matrixRent = value; }
        }
        private string id;
        private string type;
        #endregion

        #region Tải ma trận cho 2 hàng xe
        public void loadMatrixRent()
        {
            int slot = 1;
            MatrixRent = new List<List<Guna2Button>>();
            Guna2Button oldbtn = new Guna2Button() { Width = 0, Height = 0, Location = new Point(Variable.CarMargin, Variable.CarMargin), FillColor = Color.FromArgb(43, 47, 51) };
            for (int i = 0; i < Variable.RentRows; ++i)
            {
                MatrixRent.Add(new List<Guna2Button>());
                for (int j = 0; j < Variable.RentColumns; ++j)
                {
                    Guna2Button btn = new Guna2Button() { Width = Variable.btnCarWidth, Height = Variable.btnCarHeight, FillColor = Color.FromArgb(43, 47, 51) };
                    btn.Location = new Point(oldbtn.Location.X + oldbtn.Width + Variable.CarMargin, oldbtn.Location.Y);

                    btn.Text = slot.ToString();                                                 //Thêm số vào cho nút
                    slot++;

                    //Thêm event
                    btn.Click += BTNRent_EnabledChanged;
                    //

                    pnRent.Controls.Add(btn);
                    MatrixRent[i].Add(btn);
                    oldbtn = btn;
                }
                oldbtn = new Guna2Button() { Width = 0, Height = 0, Location = new Point(Variable.CarMargin, oldbtn.Location.Y + Variable.btnCarHeight + Variable.CarMargin), FillColor = Color.FromArgb(43, 47, 51) };
            }
        }
        #endregion

        #region Event handler (to cast multi event -> single event)
        private void BTNRent_EnabledChanged(object sender, EventArgs e)
        {
            id = "veh" + ((Guna2Button)sender).Text;
            //type = "veh";
            fillStatuspnl();
        }
        #endregion

        #region Phần thông tin xe sẽ hiện ở dưới
        void fillStatuspnl()
        {
            if (RentalLotDAL.Instance.checkSlot(id) == true)
            {
                DataTable table = RentalLotDAL.Instance.getVehicleInfo(id);
                fillInfo(table);
            }
            else
            {
                fillEmpty();
            }
        }
        void fillInfo(DataTable table)
        {
            //Set lại phần Vehicle
            lbVehicleID.Text = "VehicleID: " + table.Rows[0]["VehID"].ToString();
            lbVehicleType.Text = "Vehicle Type: " + table.Rows[0]["VehType"].ToString();
            lbLicensePlate.Text = "License Plate: \r\n" + table.Rows[0]["LicensePlate"].ToString();
            if(table.Rows[0]["Picture"] != DBNull.Value)
            {
                byte[] picture = (byte[])table.Rows[0]["Picture"];
                MemoryStream Picture = new MemoryStream(picture);
                VehiclePic.Image = Image.FromStream(Picture);
            }           

            if(table.Columns.Count > 5)
            {
                //Set lại phần Customer
                lbCusID.Text = "CustomerID: " + table.Rows[0]["CusID"].ToString();
                lbName.Text = "Name: " + table.Rows[0]["FullName"].ToString();
                #region Ngày sinh
                string Bdate = table.Rows[0]["Bdate"].ToString();
                string dateNonTime = "";
                for (int i = 0; ; ++i)
                {
                    if (Bdate[i] == ' ')
                        break;
                    dateNonTime += Bdate[i];
                }
                #endregion
                lbBirthday.Text = "Birthday: " + dateNonTime;// table.Rows[0]["Bdate"].ToString();
                lbPhone.Text = "Phone: " + table.Rows[0]["PhoneNumber"].ToString();
                lbAddress.Text = "Address: " + table.Rows[0]["Address"].ToString();
                lbIdentityNumber.Text = "Identity Number: " + table.Rows[0]["IdentityNumber"].ToString();
                if (table.Rows[0]["Appearance"] != DBNull.Value)
                {
                    byte[] pic2 = (byte[])table.Rows[0]["Appearance"];
                    MemoryStream Picture2 = new MemoryStream(pic2);
                    CustomerPic.Image = Image.FromStream(Picture2);
                }
            }
            else
            {
                //Set lại phần Customer
                lbCusID.Text = "CustomerID: " + "null";
                lbName.Text = "Name: " + "null";
                lbBirthday.Text = "Birthday: " + "null";
                lbPhone.Text = "Phone: " + "null";
                lbAddress.Text = "Address: " + "null";
                lbIdentityNumber.Text = "Identity Number: " + "null";
                CustomerPic.Image = null;
            }
        }
        void fillEmpty()
        {
            //Set lại phần Vehicle
            lbVehicleID.Text = "VehicleID: " + id;
            lbVehicleType.Text = "Vehicle Type: " + "null";
            lbLicensePlate.Text = "License Plate: " + "null";
            VehiclePic.Image = null;
            //Set lại phần Customer
            lbCusID.Text = "CustomerID: " + "null";
            lbName.Text = "Name: " + "null";
            lbBirthday.Text = "Birthday: " + "null";
            lbPhone.Text = "Phone: " + "null";
            lbAddress.Text = "Address: " + "null";
            lbIdentityNumber.Text = "Identity Number: " + "null";
            CustomerPic.Image = null;
        }
        #endregion

        #region Phần thông báo slot
        private void fillSlot()
        {
            int totalvehicle = Variable.RentColumns * Variable.RentRows;
            //Phần bicycle
            lbAvailibleRent.Text = "Availible Slot: " + (totalvehicle - ContractDAL.Instance.getAvailibleSlotRental()).ToString();
            lbUsedRent.Text = "Used Slot: " + ContractDAL.Instance.getAvailibleSlotRental().ToString();
        }
        #endregion

        #region Thay đổi màu của ô xe có xe và không có xe
        void changAddColor(string operation)
        {
            int ID = Convert.ToInt32(id.Remove(0,3)) - 1;
            int column = 0;

            //chia cột
            if (ID > 14)
                ID = (ID % 14);
            //chia hàng
            string idrow = id.Remove(0, 3);
            if ((float.Parse(idrow) / 14f) <= 1)
                column = 0;
            else if ((float.Parse(idrow) / 14f) <= 2)
                column = 1;
            else if ((float.Parse(idrow) / 14f) <= 3)
                column = 2;
            else if ((float.Parse(idrow) / 14f) <= 4)
                column = 3;
            else if ((float.Parse(idrow) / 14f) <= 5)
                column = 4;
            else if ((float.Parse(idrow) / 14f) <= 6)
                column = 5;
            else if ((float.Parse(idrow) / 14f) <= 7)
                column = 6;

            if (operation == "add")
            {
                MatrixRent[column][ID].FillColor = Color.FromArgb(253, 65, 60);
            }
            else if (operation == "delete")
            {
                MatrixRent[column][ID].FillColor = Color.FromArgb(43, 47, 51);
            }
        }

        //Mỗi lần mở ctrình lại thì check xem ô nào có xe để bôi đỏ
        void changeColorLoad()
        {
            for (int i = 0; i < Variable.RentRows; ++i)
            {
                for (int j = 0; j < Variable.RentColumns; ++j)
                {
                    if (RentalLotDAL.Instance.checkSlot("veh" + MatrixRent[i][j].Text.ToString()))
                    {
                        MatrixRent[i][j].FillColor = Color.FromArgb(253, 65, 60);
                    }
                }
            }
        }
        #endregion

        #region Nút nhấn theo chức năng
        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            if (type != null || id != null)
            {
                if (RentalLotDAL.Instance.checkSlot(id) == false)
                {
                    ForRent frm = new ForRent();
                    frm.type = type;
                    frm.id = id;
                    frm.purpose = "add";
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        changAddColor("add");
                    }
                    fillSlot();
                }
                else
                {
                    MessageBox.Show("Please choose an empty slot!!!", "Add Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please choose an empty slot!!!", "Add Rental Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditVehicle_Click(object sender, EventArgs e)
        {
            if (type != null || id != null)
            {
                if (RentalLotDAL.Instance.checkSlot(id) == true)
                {
                    ForRent frm = new ForRent();
                    frm.type = type;
                    frm.id = id;
                    frm.purpose = "edit";
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please choose a not empty slot!!!", "Edit Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please choose an empty slot!!!", "Add Rental Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bthDeleteVehicle_Click(object sender, EventArgs e)
        {
            if (type != null || id != null)
            {
                if (RentalLotDAL.Instance.checkSlot(id) == true)
                {
                    ForRent frm = new ForRent();
                    frm.type = type;
                    frm.id = id;
                    frm.purpose = "remove";
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        changAddColor("delete");
                    }
                    fillSlot();
                }
                else
                {
                    MessageBox.Show("Please choose an empty slot!!!", "Add Rental Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please choose an empty slot!!!", "Add Rental Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDetailRentVeh_Click(object sender, EventArgs e)
        {


        }

        private void btnFind_Click(object sender, EventArgs e)
        {


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadMatrixRent();
        }
        #endregion
    }
}
