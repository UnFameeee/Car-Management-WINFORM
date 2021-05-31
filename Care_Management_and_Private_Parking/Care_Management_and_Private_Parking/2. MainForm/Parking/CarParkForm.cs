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
//3 layers
using Global;

namespace Care_Management_and_Private_Parking
{
    public partial class CarParkForm : Form
    {
        ParkingLot frmParkingLot = new ParkingLot() { TopLevel = false, TopMost = false };
        RentalLot frmRentalLot = new RentalLot() { TopLevel = false, TopMost = false };
        CustomerAndVehicleList frmList = new CustomerAndVehicleList() { TopLevel = false, TopMost = false };

        Cursor cur1 = Cursors.Hand;
        Cursor cur2 = Cursors.Default;
        public CarParkForm()
        {
            InitializeComponent();
            loadForm();
        }

        void loadForm()
        {
            this.pnlMain.Controls.Add(frmParkingLot);
            this.pnlMain.Controls.Add(frmRentalLot);
            this.pnlMain.Controls.Add(frmList);
            tick();
        }
        private void tick()
        {
            //Chỉnh Checked
            btnParkingLot.Checked = false;
            btnList.Checked = false;
            btnRentalLot.Checked = false;
            //Chỉnh Cursor
            btnParkingLot.Cursor = cur1;
            btnList.Cursor = cur1;
            btnRentalLot.Cursor = cur1;
            //Tắt tất cả các form
            frmParkingLot.Hide();
            frmRentalLot.Hide();
            frmList.Hide();
        }

        private void btnParkingLot_Click(object sender, EventArgs e)
        {
            tick();
            btnParkingLot.Checked = true;
            btnParkingLot.Cursor = cur2;
            frmParkingLot.Show();
        }
        private void btnRentalLot_Click(object sender, EventArgs e)
        {
            tick();
            btnRentalLot.Checked = true;
            btnRentalLot.Cursor = cur2;
            frmRentalLot.Show();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            tick();
            btnList.Checked = true;
            btnList.Cursor = cur2;
            frmList.Show();
        }

        
    }
}
