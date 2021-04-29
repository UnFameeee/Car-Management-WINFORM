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
    public partial class CalendarForm : Form
    {
        public CalendarForm()
        {
            InitializeComponent();
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {
            CalendarDOWForm frm = new CalendarDOWForm() { TopLevel = false, TopMost = true };
            frm.Location = new Point(pnCalendar.Size.Width / 2 - frm.ClientSize.Width / 2, pnCalendar.Size.Height / 2 - frm.ClientSize.Height / 2 + 10);
            this.pnCalendar.Controls.Add(frm);
            frm.Show();
        }
    }
}
