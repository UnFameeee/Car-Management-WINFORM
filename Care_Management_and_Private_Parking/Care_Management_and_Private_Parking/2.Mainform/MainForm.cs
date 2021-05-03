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

namespace Care_Management_and_Private_Parking
{
    public partial class Mainform : Form
    {
        CalendarForm frmCalendar = new CalendarForm() { TopLevel = false, TopMost = false };
        CarParkForm frmCarpark = new CarParkForm() { TopLevel = false, TopMost = false };
        ManageForm frmManage = new ManageForm() { Dock = DockStyle.Fill,  TopLevel = false, TopMost = false };

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
            frmCarpark.Show();
        }
        private void tick()
        {
            btnHome.Checked = false;
            btnUser.Checked = false;
            btnCalendar.Checked = false;
            btnManageJob.Checked = false;
            frmCalendar.Hide();
            frmCarpark.Hide();
            frmManage.Hide();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            tick();
            btnHome.Checked = true;
            frmCarpark.Show();
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
            //Mở CalendarForm
            //CalendarDOWForm frm = new CalendarDOWForm() { /*Dock = DockStyle.Fill, */ TopLevel = false, TopMost = true, Location = new Point(423, 0)};
            //this.MainPanel.Controls.Add(frm);
            //frm.Show();
            //CalendarForm frm = new CalendarForm() { TopLevel = false, TopMost = false };
            //this.MainPanel.Controls.Add(frm);
            frmCalendar.Show();
        }

        private void btnManageJob_Click(object sender, EventArgs e)
        {
            tick();
            btnManageJob.Checked = true;
            frmManage.Show();
        }
    }
}
