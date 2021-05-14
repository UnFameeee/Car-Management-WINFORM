﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
//3 layers
using Global;

namespace Care_Management_and_Private_Parking
{
    public partial class CarParkForm : Form
    {
        #region Properties

        private List<List<Guna2Button>> matrixBicycle;
        public List<List<Guna2Button>> MatrixBicycle
        {
            get { return matrixBicycle; }
            set { matrixBicycle = value; }
        }

        private List<List<Guna2Button>> matrixBike;
        public  List<List<Guna2Button>> MatrixBike
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
        #endregion

        public CarParkForm()
        {
            InitializeComponent();
            loadMatrixBicycle();
            loadMatrixBike();
            loadMatrixCar();
        }

        //Tải ma trận cho 3 hàng xe
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

        //Event handler (to cast multi event -> single event)
        private void BTNbicycle_EnabledChanged(object sender, EventArgs e)
        {
            //string value = ((Guna2Button)sender).Text; //test
            fillStatuspnl(((Guna2Button)sender).Text, "bicycle");
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

                    pnCar.Controls.Add(btn);
                    MatrixCar[i].Add(btn);
                    oldbtn = btn;
                }
                oldbtn = new Guna2Button() { Width = 0, Height = 0, Location = new Point(Variable.CarMargin, oldbtn.Location.Y + Variable.btnCarHeight + Variable.CarMargin), FillColor = Color.FromArgb(43, 47, 51) };
            }
        }


        //Phần thông tin xe sẽ hiện ở dưới
        void fillStatuspnl(string text, string type)
        {
            if(type == "bicycle")
            {

            }
            else if(type == "bike")
            {

            }
            else if(type == "car")
            {

            }
        }


        //Phần các nút bấm
        private void btnOnDemandPark_Click(object sender, EventArgs e)
        {

        }
    }
}