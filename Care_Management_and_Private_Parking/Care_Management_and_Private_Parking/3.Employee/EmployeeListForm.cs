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
    public partial class EmployeeListForm : Form
    {
        public EmployeeListForm()
        {
            InitializeComponent();
        }

        Employee emp = new Employee();
        MY_DB db = new MY_DB();
        int pos;

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {

        }
    }
}
