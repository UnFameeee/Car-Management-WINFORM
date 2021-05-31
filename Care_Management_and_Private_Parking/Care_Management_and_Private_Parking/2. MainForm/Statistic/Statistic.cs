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
    public partial class Statistic : Form
    {
        public Statistic()
        {
            InitializeComponent();
        }

        SalaryEmployeeSatistic frmSalaryEmpStatistic = new SalaryEmployeeSatistic() { TopLevel = false, TopMost = false };
        Revenue frmRevenue = new Revenue() { TopLevel = false, TopMost = false };
        Cursor cur1 = Cursors.Hand;
        Cursor cur2 = Cursors.Default;

        private void Statistic_Load(object sender, EventArgs e)
        {
            loadForm();
        }
        void loadForm()
        {
            this.pnlMain.Controls.Add(frmSalaryEmpStatistic);
            this.pnlMain.Controls.Add(frmRevenue);
            tick();
        }
        private void tick()
        {
            //Chỉnh Checked
            btnCustomerStatistic.Checked = false;
            btnSalaryEmp.Checked = false;
            btnRevenue.Checked = false;
            //Chỉnh Cursor
            btnCustomerStatistic.Cursor = cur1;
            btnSalaryEmp.Cursor = cur1;
            btnRevenue.Cursor = cur1;
            //Tắt tất cả các form
            frmSalaryEmpStatistic.Hide();
            frmRevenue.Hide();
        }

        private void btnCustomerStatistic_Click(object sender, EventArgs e)
        {
            tick();
            btnCustomerStatistic.Checked = true;
            btnCustomerStatistic.Cursor = cur2;

        }

        private void btnSalaryEmp_Click(object sender, EventArgs e)
        {
            tick();
            btnSalaryEmp.Checked = true;
            btnSalaryEmp.Cursor = cur2;
            frmSalaryEmpStatistic.Show();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            tick();
            btnRevenue.Checked = true;
            btnRevenue.Cursor = cur2;
            frmRevenue.Show();
        }
    }
}
