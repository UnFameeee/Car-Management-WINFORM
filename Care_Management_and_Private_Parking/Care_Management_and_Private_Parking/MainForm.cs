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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (Control item in flpMenuButton.Controls)
                item.Width = flpMenuButton.Width;
            btnMain.PerformClick();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnwide_Click(object sender, EventArgs e)
        {
            this.WindowState = (this.WindowState == FormWindowState.Normal) ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void btn__Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            pnMenuLeft.Width = (pnMenuLeft.Width == 265) ? 40 : 265;
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            lbTieuDe.Text = btn.Tag.ToString();

            foreach (Control item in flpMenuButton.Controls)
                item.BackColor = flpMenuButton.BackColor;

            if (btn.Name != btnHelp.Name)
                btnHelp.BackColor = flpMenuButton.BackColor;

            btn.BackColor = Color.CadetBlue;
        }
    }
}
