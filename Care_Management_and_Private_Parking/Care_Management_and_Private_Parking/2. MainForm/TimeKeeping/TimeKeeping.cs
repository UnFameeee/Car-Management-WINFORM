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
        ManageSalary frmSalary = new ManageSalary() { TopLevel = false, TopMost = false };
        Cursor cur1 = Cursors.Hand;
        Cursor cur2 = Cursors.Default;

        public TimeKeeping()
        {
            InitializeComponent();
        }

        private void TimeKeeping_Load(object sender, EventArgs e)
        {
            loadForm();
            loadFormWithJobID();
        }

        private void loadFormWithJobID()
        {
            if (Global.UserID.GlobalJobID != "1")
            {
                //nút manage job
                btnWorkShift.Enabled = false;
                btnWorkShift.Visible = false;
                //nút statistic
                btnSalary.Enabled = false;
                btnSalary.Visible = false;

                //Căn lại các nút
                btnTimeKeeping.Location = new Point(9, 493/2 - 43/2);
                btnWorkShift.Location = new Point(9, 224 + 66);
            }
        }

        void loadForm()
        {
            this.pnlMain.Controls.Add(frmCheckWorkForm);
            this.pnlMain.Controls.Add(frmManageShiftForm);
            this.pnlMain.Controls.Add(frmSalary);
            tick();
        }
        private void tick()
        {
            //Chỉnh Checked
            btnTimeKeeping.Checked = false;
            btnWorkShift.Checked = false;
            btnSalary.Checked = false;
            //Chỉnh Cursor
            btnTimeKeeping.Cursor = cur1;
            btnWorkShift.Cursor = cur1;
            btnSalary.Cursor = cur1;
            //Tắt tất cả các form
            frmCheckWorkForm.Hide();
            frmManageShiftForm.Hide();
            frmSalary.Hide();
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

        private void btnSalary_Click(object sender, EventArgs e)
        {
            tick();
            btnSalary.Checked = true;
            btnSalary.Cursor = cur2;
            frmSalary.Show();
        }
    }
}
