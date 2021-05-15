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
    public partial class Mainform : Form
    {
        CalendarForm frmCalendar = new CalendarForm() { TopLevel = false, TopMost = false };
        CarParkForm frmCarpark = new CarParkForm() { TopLevel = false, TopMost = false };
        ManageForm frmManage = new ManageForm() { TopLevel = false, TopMost = false };

        public Mainform()
        {
            InitializeComponent();
            loadForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void loadForm()
        {
            this.MainPanel.Controls.Add(frmCalendar);
            this.MainPanel.Controls.Add(frmCarpark);
            this.MainPanel.Controls.Add(frmManage);
            tick();
        }
        Cursor cur1 = Cursors.Hand;
        Cursor cur2 = Cursors.Default;
        private void tick()
        {        
            //Chỉnh Checked
            btnHome.Checked = false;
            btnUser.Checked = false;
            btnCalendar.Checked = false;
            btnManageJob.Checked = false;
            //Chỉnh Cursor
            btnHome.Cursor = cur1;
            btnUser.Cursor = cur1;
            btnCalendar.Cursor = cur1;
            btnManageJob.Cursor = cur1;
            //Tắt tất cả các form
            frmCalendar.Hide();
            frmCarpark.Hide();
            frmManage.Hide();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            tick();
            btnHome.Checked = true;
            btnHome.Cursor = cur2;
            frmCarpark.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            tick();
            btnUser.Checked = true;
            btnUser.Cursor = cur2;
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            tick();
            btnCalendar.Checked = true;
            btnCalendar.Cursor = cur2;
            frmCalendar.Show();
        }

        private void btnManageJob_Click(object sender, EventArgs e)
        {
            tick();
            btnManageJob.Checked = true;
            btnManageJob.Cursor = cur2;
            frmManage.Show();
        }
    }
}
