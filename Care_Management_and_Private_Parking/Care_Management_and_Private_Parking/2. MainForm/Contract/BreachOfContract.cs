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
    public partial class BreachOfContract : Form
    {
        public BreachOfContract()
        {
            InitializeComponent();
        }

        public string side;

        private void btnRenter_Click(object sender, EventArgs e)
        {
            side = "Renter";
            this.DialogResult = DialogResult.OK;
        }

        private void btnLessor_Click(object sender, EventArgs e)
        {
            side = "Lessor";
            this.DialogResult = DialogResult.OK;
        }
    }
}
