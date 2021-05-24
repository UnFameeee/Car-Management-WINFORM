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
    public partial class ContractForm : Form
    {
        public ContractForm()
        {
            InitializeComponent();
        }

        Contract frm = new Contract() { TopLevel = false, TopMost = false };

        private void ContractForm_Load(object sender, EventArgs e)
        {
            pnContract.Controls.Add(frm);
            frm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string contid = frm.tbContractInfo.Text;
            string purpose = frm.cbboxPurpose.SelectedIndex.ToString();
        }
    }
}
