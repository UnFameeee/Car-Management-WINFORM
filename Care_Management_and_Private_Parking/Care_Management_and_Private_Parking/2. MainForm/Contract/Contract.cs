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
    public partial class Contract : Form
    {
        public Contract()
        {
            InitializeComponent();
        }

        string info;

        private void tbContractInfo_Click(object sender, EventArgs e)
        {
            info = tbContractInfo.Text;
            tbContractInfo.Text = null;
        }

        private void tbContractInfo_Leave(object sender, EventArgs e)
        {
            tbContractInfo.Text = info;
        }
    }
}
