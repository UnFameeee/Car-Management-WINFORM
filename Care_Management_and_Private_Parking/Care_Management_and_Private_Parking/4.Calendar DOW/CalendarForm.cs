using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Care_Management_and_Private_Parking
{
    public partial class CalendarForm : Form
    {
        public CalendarForm()
        {
            InitializeComponent();
            fillChart();
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {
            CalendarDOWForm frm = new CalendarDOWForm() { TopLevel = false, TopMost = true };
            frm.Location = new Point(pnCalendar.Size.Width / 2 - frm.ClientSize.Width / 2, pnCalendar.Size.Height / 2 - frm.ClientSize.Height / 2 + 10);
            this.pnCalendar.Controls.Add(frm);
            frm.Show();
        }


        //Load chart
        void fillChart()
        {
            //fpn.AutoScroll = false;
            //fpn.HorizontalScroll.Enabled = false;
            //fpn.HorizontalScroll.Visible = false;
            //fpn.HorizontalScroll.Maximum = 0;
            //fpn.AutoScroll = true;
            //Guna2VScrollBar sb = new Guna2VScrollBar();
            //sb.Dock = DockStyle.Right;
            //sb.FillColor = Color.FromArgb(43, 47, 51); 
            //sb.ThumbColor = Color.FromArgb(80, 84, 87);
            //sb.Scroll += (sender, e) => { fpn.VerticalScroll.Value = sb.Value; };
            //fpn.Controls.Add(sb);
            fpn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            fpn.TabIndex = 4;
            fpn.AutoScroll = true;
            fpn.VerticalScroll.Visible = true;
            //fpn.WrapContents = false;
            //fpn.Padding.Right = 10;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            Task t = new Task();
            fpn.Controls.Add(t);
        }
    }
}
