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
        public CarParkForm()
        {
            InitializeComponent();
            loadForm();
        }
        
        ParkingLot frmCalendar = new ParkingLot() { TopLevel = false, TopMost = false };

        void loadForm()
        {
            this.pnlMain.Controls.Add(frmCalendar);
            frmCalendar.Show();
        }
    }
}
