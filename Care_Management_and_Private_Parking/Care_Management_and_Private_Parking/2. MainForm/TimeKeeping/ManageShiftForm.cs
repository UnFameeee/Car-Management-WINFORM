using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//3 layers
using Global;
using DAL;

namespace Care_Management_and_Private_Parking
{
    public partial class ManageShiftForm : Form
    {
        public ManageShiftForm()
        {
            InitializeComponent();
        }

        private void ManageShiftForm_Load(object sender, EventArgs e)
        {
            fillAllDGV();
        }

        private void fillAllDGV()
        {
            //DGV1
            DataTable table = CalendarDAL.Instance.tableShift();
            dgvTodayShift.DataSource = table;
            dgvTodayShift.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTodayShift.AllowUserToAddRows = false;
            dgvTodayShift.AllowUserToResizeRows = false;
            dgvTodayShift.AllowUserToOrderColumns = false;
            dgvTodayShift.AllowUserToResizeColumns = false;

            // TEST DGV2
            dgvEmployeeWork.DataSource = TimeKeepingDAL.Instance.fillDGV2();
            dgvEmployeeWork.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployeeWork.AllowUserToAddRows = false;
            dgvEmployeeWork.AllowUserToResizeRows = false;
            dgvEmployeeWork.AllowUserToOrderColumns = false;
            dgvEmployeeWork.AllowUserToResizeColumns = false;

            //DGV3
            dgvInfoShift.DataSource = TimeKeepingDAL.Instance.fillDGV3();
            dgvInfoShift.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInfoShift.AllowUserToAddRows = false;
            dgvInfoShift.AllowUserToResizeRows = false;
            dgvInfoShift.AllowUserToOrderColumns = false;
            dgvInfoShift.AllowUserToResizeColumns = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            fillAllDGV();
            tbShiftID2.Text = "";
            timeStart.Text = "00:00:00";
            timeEnd.Text = "00:00:00";
        }

        private void btnFindEmpID_Click(object sender, EventArgs e)
        {
            DataTable table = TimeKeepingDAL.Instance.getMiniID(tbEmpID.Text);
            if (table.Rows.Count > 0)
            {
                dgvEmployeeWork.DataSource = table;
            }
            else
                MessageBox.Show("This ID ins't existing!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #region phần dưới
        private bool verif2()
        {
            if (tbShiftID2.Text == "")
                return false;
            return true;
        }

        private void btnAddTime_Click(object sender, EventArgs e)
        {
            string shiftid = tbShiftID2.Text;
            TimeSpan timestart = timeStart.Value.TimeOfDay;
            TimeSpan timeend = timeEnd.Value.TimeOfDay;
            try
            {
                if (verif2())
                {
                    if (TimeKeepingDAL.Instance.check2(shiftid))
                    {
                        MessageBox.Show("This shift is already existed!!!", "Add Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (TimeKeepingDAL.Instance.AddDivideTimeShift(shiftid, timestart, timeend))
                        {
                            MessageBox.Show("Add new shift successfully!!", "Add Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Add new shift unsuccessfully!!!", "Add Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all the information", "Add Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditTime_Click(object sender, EventArgs e)
        {
            string shiftid = tbShiftID2.Text;
            TimeSpan timestart = timeStart.Value.TimeOfDay;
            TimeSpan timeend = timeEnd.Value.TimeOfDay;
            try
            {
                if (verif2())
                {
                    if (!TimeKeepingDAL.Instance.check2(shiftid))
                    {
                        MessageBox.Show("This shift isn't existing!!!", "Edit Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (TimeKeepingDAL.Instance.UpdateDivideTimeShift(shiftid, timestart, timeend))
                        {
                            MessageBox.Show("Edit shift successfully!!!", "Edit Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Edit shift unsuccessfully!!!", "Edit Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all the information", "Edit Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteTime_Click(object sender, EventArgs e)
        {
            string shiftid = tbShiftID2.Text;
            try
            {
                if (verif2())
                {
                    if (!TimeKeepingDAL.Instance.check2(shiftid))
                    {
                        MessageBox.Show("This shift isn't existing!!!", "Delete Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (TimeKeepingDAL.Instance.DeleteDivideTimeShift(shiftid))
                        {
                            MessageBox.Show("Delete shift successfully!!!", "Delete Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Delete shift unsuccessfully!!!", "Delete Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all the information", "Delete Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            DataTable table = TimeKeepingDAL.Instance.Find2(tbShiftID2.Text);
            if (table.Rows.Count > 0)
            {
                dgvInfoShift.DataSource = table;
            }
            else
                MessageBox.Show("This ID ins't existing!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dgvInfoShift_DoubleClick(object sender, EventArgs e)
        {
            tbShiftID2.Text = dgvInfoShift.CurrentRow.Cells[0].Value.ToString();
            TimeSpan timestart = (TimeSpan)dgvInfoShift.CurrentRow.Cells[1].Value;
            TimeSpan timeend = (TimeSpan)dgvInfoShift.CurrentRow.Cells[2].Value;
            timeStart.Text = timestart.ToString();
            timeEnd.Text = timeend.ToString();
        }

        #endregion
    }
}
