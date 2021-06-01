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
        TimeKeeping frmTimeKeeping = new TimeKeeping() { TopLevel = false, TopMost = false };
        Statistic frmStatistic = new Statistic() { TopLevel = false, TopMost = false };

        public Mainform()
        {
            InitializeComponent();
            loadForm();
            loadFormWithJobID();
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
            this.MainPanel.Controls.Add(frmTimeKeeping);
            this.MainPanel.Controls.Add(frmStatistic);
            tick();
            panelLayout.Visible = true;
        }
        Cursor cur1 = Cursors.Hand;
        Cursor cur2 = Cursors.Default;
        private void tick()
        {
            panelLayout.Visible = false;
            //Chỉnh Checked
            btnHome.Checked = false;
            btnUser.Checked = false;
            btnTimeKeeping.Checked = false;
            btnManageJob.Checked = false;
            btnStatistic.Checked = false;
            //Chỉnh Cursor
            btnHome.Cursor = cur1;
            btnUser.Cursor = cur1;
            btnTimeKeeping.Cursor = cur1;
            btnManageJob.Cursor = cur1;
            btnStatistic.Cursor = cur1;
            //Tắt tất cả các form
            frmCalendar.Hide();
            frmCarpark.Hide();
            frmManage.Hide();
            frmTimeKeeping.Hide();
            frmStatistic.Hide();
        }

        private void loadFormWithJobID()
        {
            if(Global.UserID.GlobalJobID == "2")
            {
                //nút manage job
                btnManageJob.Enabled = false;
                btnManageJob.Visible = false;
                //nút statistic
                btnStatistic.Enabled = false;
                btnStatistic.Visible = false;

                //Căn lại các nút
                pnlHome.Location = new Point(7, 234+66);
                pnlUser.Location = new Point(7, 309+66);
                pnlTimeKeeping.Location = new Point(7, 385+66);
                pnlManage.Location = new Point(7, 460 + 76);
            }
            else if(Global.UserID.GlobalJobID == "3")
            {
                //nút statistic
                btnStatistic.Enabled = false;
                btnStatistic.Visible = false;

                //Căn lại các nút
                pnlHome.Location = new Point(7, 234 + 66);
                pnlUser.Location = new Point(7, 309 + 66);
                pnlTimeKeeping.Location = new Point(7, 385 + 66);
                pnlManage.Location = new Point(7, 460 + 66);
                pnlStatistic.Location = new Point(7, 460 + 66 + 66);
            }
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
            frmCalendar.Show();
        }

        private void btnTimeKeeping_Click(object sender, EventArgs e)
        {
            tick();
            btnTimeKeeping.Checked = true;
            btnTimeKeeping.Cursor = cur2;
            frmTimeKeeping.Show();
        }

        private void btnManageJob_Click(object sender, EventArgs e)
        {
            tick();
            btnManageJob.Checked = true;
            btnManageJob.Cursor = cur2;
            frmManage.Show();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            tick();
            btnStatistic.Checked = true;
            btnStatistic.Cursor = cur2;
            frmStatistic.Show();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
