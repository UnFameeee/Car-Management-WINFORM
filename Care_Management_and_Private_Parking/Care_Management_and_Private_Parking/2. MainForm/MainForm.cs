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
        ManageForm frmManage = new ManageForm() { TopLevel = false, TopMost = false };
        Form1 frm1 = new Form1() { TopLevel = false, TopMost = false };
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
            this.MainPanel.Controls.Add(frm1);
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
            frm1.Show();

        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            tick();
            btnCalendar.Checked = true;
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
