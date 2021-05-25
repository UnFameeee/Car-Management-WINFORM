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
            loadMatrixRent();
            loadMatrixForRent();
        }

        #region Properties

        private List<List<Guna2Button>> matrixRent;
        public List<List<Guna2Button>> MatrixRent
        {
            get { return matrixRent; }
            set { matrixRent = value; }
        }

        private List<List<Guna2Button>> matrixForRent;
        public List<List<Guna2Button>> MatrixForRent
        {
            get { return matrixForRent; }
            set { matrixForRent = value; }
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
        public void loadMatrixForRent()
        {
            int slot = 1;
            MatrixForRent = new List<List<Guna2Button>>();
            Guna2Button oldbtn = new Guna2Button() { Width = 0, Height = 0, Location = new Point(Variable.CarMargin, Variable.CarMargin), FillColor = Color.FromArgb(43, 47, 51) };
            for (int i = 0; i < Variable.RentRows; ++i)
            {
                MatrixForRent.Add(new List<Guna2Button>());
                for (int j = 0; j < Variable.RentColumns; ++j)
                {
                    Guna2Button btn = new Guna2Button() { Width = Variable.btnCarWidth, Height = Variable.btnCarHeight, FillColor = Color.FromArgb(43, 47, 51) };
                    btn.Location = new Point(oldbtn.Location.X + oldbtn.Width + Variable.CarMargin, oldbtn.Location.Y);

                    btn.Text = slot.ToString();                                                 //Thêm số vào cho nút
                    slot++;

                    //Thêm event
                    btn.Click += BTNForRent_EnabledChanged;
                    //

                    pnForRent.Controls.Add(btn);
                    MatrixForRent[i].Add(btn);
                    oldbtn = btn;
                }
                oldbtn = new Guna2Button() { Width = 0, Height = 0, Location = new Point(Variable.CarMargin, oldbtn.Location.Y + Variable.btnCarHeight + Variable.CarMargin), FillColor = Color.FromArgb(43, 47, 51) };
            }
        }
        #endregion

        #region Event handler (to cast multi event -> single event)
        private void BTNRent_EnabledChanged(object sender, EventArgs e)
        {
            id = ((Guna2Button)sender).Text;
            type = "rent";
            lbCus.Text = "CUSTOMER FOR RENT";
            fillStatuspnl();
        }

        private void BTNForRent_EnabledChanged(object sender, EventArgs e)
        {
            id = ((Guna2Button)sender).Text;
            type = "forrent";
            lbCus.Text = "CUSTOMER RENT";
            fillStatuspnl();
        }
        #endregion

        #region Phần thông tin xe sẽ hiện ở dưới
        void fillStatuspnl()
        {
            if (ParkingLotDAL.Instance.checkSlot((type + id), type) == true)
            {
                //DataTable table = ParkingLotDAL.Instance.getVehicleInfo(id, type);
                //fillInfo(table);
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
            byte[] picture = (byte[])table.Rows[0]["Picture"];
            MemoryStream Picture = new MemoryStream(picture);
            VehiclePic.Image = Image.FromStream(Picture);

            //Set lại phần Customer
            lbCusID.Text = "CustomerID: " + table.Rows[0]["CusID"].ToString();
            lbName.Text = "Name: " + table.Rows[0]["FullName"].ToString();
            lbBirthday.Text = "Birthday: " + table.Rows[0]["Bdate"].ToString();
            lbPhone.Text = "Phone: " + table.Rows[0]["PhoneNumber"].ToString();
            lbAddress.Text = "Address: " + table.Rows[0]["Address"].ToString();
            lbIdentityNumber.Text = "Identity Number: " + table.Rows[0]["IdentityNumber"].ToString();
            byte[] pic2 = (byte[])table.Rows[0]["Appearance"];
            MemoryStream Picture2 = new MemoryStream(pic2);
            CustomerPic.Image = Image.FromStream(Picture2);
        }
        void fillEmpty()
        {
            //Set lại phần Vehicle
            lbVehicleID.Text = "VehicleID: " + type + id;
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadMatrixRent();
            loadMatrixForRent();
        }


        #region Nút nhấn theo chức năng
        private void btnDetailRentVeh_Click(object sender, EventArgs e)
        {

        }

        private void btnDetailVehForRent_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnFind_Click(object sender, EventArgs e)
        {

        }
    }
}
