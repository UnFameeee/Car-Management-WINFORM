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
    public partial class Task : UserControl
    {
        public Task()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void cbTick_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTick.Checked == true)
                tbJob.Font = new Font("Segoe UI", 10, FontStyle.Strikeout);
            else
                tbJob.Font = new Font("Segoe UI", 10, FontStyle.Regular);
        }
    }
}
