using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Data.SqlClient;
using System.IO;

//3 layers
using DAL;
using Global;

namespace Care_Management_and_Private_Parking
{
    public partial class ParkingLot : Form
    {
        #region Properties

        private List<List<Guna2Button>> matrixBicycle;
        public List<List<Guna2Button>> MatrixBicycle
        {
            get { return matrixBicycle; }
            set { matrixBicycle = value; }
        }

        private List<List<Guna2Button>> matrixBike;
        public List<List<Guna2Button>> MatrixBike
        {
            get { return matrixBike; }
            set { matrixBike = value; }
        }
        private List<List<Guna2Button>> matrixCar;
        public List<List<Guna2Button>> MatrixCar
        {
            get { return matrixCar; }
            set { matrixCar = value; }
        }

        private string id;
        private string type;
        private string customer;
        #endregion

        public ParkingLot()
        {
            InitializeComponent();
            loadMatrixBicycle();
            loadMatrixBike();
            loadMatrixCar();
            changeColorLoad();
        }

        #region Tải ma trận cho 3 hàng xe
        public void loadMatrixBicycle()
        {
            int slot = 1;
            MatrixBicycle = new List<List<Guna2Button>>();
            Guna2Button oldbtn = new Guna2Button() { Width = 0, Height = 0, Location = new Point(Variable.CarMargin, Variable.CarMargin), FillColor = Color.FromArgb(43, 47, 51) };
            for (int i = 0; i < Variable.CarRows; ++i)
            {
                MatrixBicycle.Add(new List<Guna2Button>());
                for (int j = 0; j < Variable.CarColumns; ++j)
                {
                    Guna2Button btn = new Guna2Button() { Width = Variable.btnCarWidth, Height = Variable.btnCarHeight, FillColor = Color.FromArgb(43, 47, 51) };
                    btn.Location = new Point(oldbtn.Location.X + oldbtn.Width + Variable.CarMargin, oldbtn.Location.Y);

                    btn.Text = slot.ToString();                                                 //Thêm số vào cho nút
                    slot++;

                    //Thêm event
                    btn.Click += BTNbicycle_EnabledChanged;
                    //

                    pnBicycle.Controls.Add(btn);
                    MatrixBicycle[i].Add(btn);
                    oldbtn = btn;
                }
                oldbtn = new Guna2Button() { Width = 0, Height = 0, Location = new Point(Variable.CarMargin, oldbtn.Location.Y + Variable.btnCarHeight + Variable.CarMargin), FillColor = Color.FromArgb(43, 47, 51) };
            }
        }
        public void loadMatrixBike()
        {
            int slot = 1;
            MatrixBike = new List<List<Guna2Button>>();
            Guna2Button oldbtn = new Guna2Button() { Width = 0, Height = 0, Location = new Point(Variable.CarMargin, Variable.CarMargin), FillColor = Color.FromArgb(43, 47, 51) };
            for (int i = 0; i < Variable.CarRows; ++i)
            {
                MatrixBike.Add(new List<Guna2Button>());
                for (int j = 0; j < Variable.CarColumns; ++j)
                {
                    Guna2Button btn = new Guna2Button() { Width = Variable.btnCarWidth, Height = Variable.btnCarHeight, FillColor = Color.FromArgb(43, 47, 51) };
                    btn.Location = new Point(oldbtn.Location.X + oldbtn.Width + Variable.CarMargin, oldbtn.Location.Y);

                    btn.Text = slot.ToString();                                                 //Thêm số vào cho nút
                    slot++;

                    //Thêm event
                    btn.Click += BTNbike_EnabledChanged;
                    //

                    pnBike.Controls.Add(btn);
                    MatrixBike[i].Add(btn);
                    oldbtn = btn;
                }
                oldbtn = new Guna2Button() { Width = 0, Height = 0, Location = new Point(Variable.CarMargin, oldbtn.Location.Y + Variable.btnCarHeight + Variable.CarMargin), FillColor = Color.FromArgb(43, 47, 51) };
            }
        }
        public void loadMatrixCar()
        {
            int slot = 1;
            MatrixCar = new List<List<Guna2Button>>();
            Guna2Button oldbtn = new Guna2Button() { Width = 0, Height = 0, Location = new Point(Variable.CarMargin, Variable.CarMargin), FillColor = Color.FromArgb(43, 47, 51) };
            for (int i = 0; i < Variable.CarRows; ++i)
            {
                MatrixCar.Add(new List<Guna2Button>());
                for (int j = 0; j < Variable.CarColumns; ++j)
                {
                    Guna2Button btn = new Guna2Button() { Width = Variable.btnCarWidth, Height = Variable.btnCarHeight, FillColor = Color.FromArgb(43, 47, 51) };
                    btn.Location = new Point(oldbtn.Location.X + oldbtn.Width + Variable.CarMargin, oldbtn.Location.Y);

                    btn.Text = slot.ToString();                                                 //Thêm số vào cho nút
                    slot++;

                    //Thêm event
                    btn.Click += BTNcar_EnabledChanged;
                    //

                    pnCar.Controls.Add(btn);
                    MatrixCar[i].Add(btn);
                    oldbtn = btn;
                }
                oldbtn = new Guna2Button() { Width = 0, Height = 0, Location = new Point(Variable.CarMargin, oldbtn.Location.Y + Variable.btnCarHeight + Variable.CarMargin), FillColor = Color.FromArgb(43, 47, 51) };
            }
        }
        #endregion

        #region Event handler (to cast multi event -> single event)
        private void BTNbicycle_EnabledChanged(object sender, EventArgs e)
        {
            id = ((Guna2Button)sender).Text;
            type = "bicycle";
            fillStatuspnl();
        }

        private void BTNbike_EnabledChanged(object sender, EventArgs e)
        {
            id = ((Guna2Button)sender).Text;
            type = "bike";
            fillStatuspnl();
        }

        private void BTNcar_EnabledChanged(object sender, EventArgs e)
        {
            id = ((Guna2Button)sender).Text;
            type = "car";
            fillStatuspnl();
        }
        #endregion

        #region Phần thông tin xe sẽ hiện ở dưới
        void fillStatuspnl()
        {
            if (ParkingLotDAL.Instance.checkSlot((type + id), type) == true)
            {  
                DataTable table = ParkingLotDAL.Instance.getVehicleInfo(id, type);
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

            customer = table.Rows[0]["CusID"].ToString();
        }


        void fillEmpty()
        {
            //Set lại phần Vehicle
            lbVehicleID.Text =  "VehicleID: " + type + id;
            lbVehicleType.Text = "Vehicle Type: " + type;
            lbLicensePlate.Text = "License Plate: " + "null";
            VehiclePic.Image = null;
            //Set lại phần Customer
            lbCusID.Text = "CustomerID: " +"null";
            lbName.Text = "Name: " + "null";
            lbBirthday.Text = "Birthday: " + "null";
            lbPhone.Text = "Phone: " + "null";
            lbAddress.Text = "Address: " + "null";
            lbIdentityNumber.Text = "Identity Number: " + "null";
            CustomerPic.Image = null;
        }
        #endregion

        #region Thay đổi màu của ô xe có xe và không có xe
        void changAddColor(string operation)
        {
            int ID = Convert.ToInt32(id) - 1;
            int column;

            //chia cột
            if (ID > 14)
                ID = (ID % 14);
            //chia hàng
            if ((float.Parse(id) / 14f) <= 1)
                column = 0;
            else
                column = 1;
            if(operation == "add")
            {
                if (type == Variable.Bicycle)
                {
                    MatrixBicycle[column][ID].FillColor = Color.FromArgb(253, 65, 60);
                }
                else if (type == Variable.Bike)
                {
                    MatrixBike[column][ID].FillColor = Color.FromArgb(253, 65, 60);
                }
                else if (type == Variable.Car)
                {
                    MatrixCar[column][ID].FillColor = Color.FromArgb(253, 65, 60);
                }
            }
            else if (operation == "delete")
            {
                if (type == Variable.Bicycle)
                {
                    MatrixBicycle[column][ID].FillColor = Color.FromArgb(43, 47, 51);
                }
                else if (type == Variable.Bike)
                {
                    MatrixBike[column][ID].FillColor = Color.FromArgb(43, 47, 51);
                }
                else if (type == Variable.Car)
                {
                    MatrixCar[column][ID].FillColor = Color.FromArgb(43, 47, 51);
                }
            }
        }

        //Mỗi lần mở ctrình lại thì check xem ô nào có xe để bôi đỏ
        void changeColorLoad()
        {
            for(int i = 0; i < Variable.CarRows; ++i)
            {
                for(int j = 0; j < Variable.CarColumns; ++j)
                {
                    if(ParkingLotDAL.Instance.checkSlot((Variable.Bicycle + MatrixBicycle[i][j].Text.ToString()), Variable.Bicycle))
                    {
                        MatrixBicycle[i][j].FillColor = Color.FromArgb(253, 65, 60);
                    }

                    if(ParkingLotDAL.Instance.checkSlot((Variable.Bike + MatrixBicycle[i][j].Text.ToString()), Variable.Bike))
                    {
                        MatrixBike[i][j].FillColor = Color.FromArgb(253, 65, 60);
                    }

                    if(ParkingLotDAL.Instance.checkSlot((Variable.Car + MatrixBicycle[i][j].Text.ToString()), Variable.Car))
                    {
                        MatrixCar[i][j].FillColor = Color.FromArgb(253, 65, 60);
                    }
                }
            }
        }
        #endregion

        #region Thêm, xóa, sửa, Hóa đơn
        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            if(ParkingLotDAL.Instance.checkSlot((type +id), type) == false)
            {
                AddVehicle frm = new AddVehicle();
                frm.id = id;
                frm.type = type;
                frm.ShowDialog();
                if(frm.DialogResult == DialogResult.OK)
                {
                    changAddColor("add");
                }                    
            }
            else
            {
                MessageBox.Show("Please choose an empty slot!!!", "Add Vehicle");
            }
        }

        private void btnEditVehicle_Click(object sender, EventArgs e)
        {
            if (ParkingLotDAL.Instance.checkSlot((type + id), type) == true)
            {
                EditVehicle frm = new EditVehicle();
                frm.VehID = (type + id);
                frm.CusID = customer;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose a not empty slot!!!", "Edit Vehicle");
            }
        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            if (ParkingLotDAL.Instance.checkSlot((type + id), type) == true)
            {
                GetVehicle frm = new GetVehicle();
                //frm.VehID = (type + id);
                //frm.CusID = customer;
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    changAddColor("delete");
                }
            }
            else
            {
                MessageBox.Show("Please choose a not empty slot!!!", "Edit Vehicle");
            }

        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
