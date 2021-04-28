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

namespace Care_Management_and_Private_Parking
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tick()
        {
            btnHome.Checked = false;
            btnUser.Checked = false;
            btnCalendar.Checked = false;
            this.MainPanel.Controls.Clear();
        }
        private void checkClose()
        {

        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            tick();
            btnHome.Checked = true;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            tick();
            btnUser.Checked = true;
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            tick();
            btnCalendar.Checked = true;
            //Mở lịch
            CalendarDOWForm frm = new CalendarDOWForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            this.MainPanel.Controls.Add(frm);
            frm.Show();
        }
    }
}
