using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Care_Management_and_Private_Parking
{
    public partial class TimeKeeping : Form
    {
        CheckWorkForm frmCheckWorkForm = new CheckWorkForm() { TopLevel = false, TopMost = false };
        ManageShiftForm frmManageShiftForm = new ManageShiftForm() { TopLevel = false, TopMost = false };
        Cursor cur1 = Cursors.Hand;
        Cursor cur2 = Cursors.Default;

        public TimeKeeping()
        {
            InitializeComponent();
        }

        private void TimeKeeping_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        void loadForm()
        {
            this.pnlMain.Controls.Add(frmCheckWorkForm);
            this.pnlMain.Controls.Add(frmManageShiftForm);
            tick();
        }
        private void tick()
        {
            //Chỉnh Checked
            btnTimeKeeping.Checked = false;
            btnStatistic.Checked = false;
            btnWorkShift.Checked = false;
            //Chỉnh Cursor
            btnTimeKeeping.Cursor = cur1;
            btnStatistic.Cursor = cur1;
            btnWorkShift.Cursor = cur1;
            //Tắt tất cả các form
            frmCheckWorkForm.Hide();
            frmManageShiftForm.Hide();
        }

        private void btnTimeKeeping_Click(object sender, EventArgs e)
        {
            tick();
            btnTimeKeeping.Checked = true;
            btnTimeKeeping.Cursor = cur2;
            frmCheckWorkForm.Show();
        }

        private void btnWorkShift_Click(object sender, EventArgs e)
        {
            tick();
            btnWorkShift.Checked = true;
            btnWorkShift.Cursor = cur2;
            frmManageShiftForm.Show();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {

        }
    }
}
