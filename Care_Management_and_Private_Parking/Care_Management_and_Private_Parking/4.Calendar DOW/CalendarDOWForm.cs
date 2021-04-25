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
    public partial class CalendarDOWForm : Form
    {
        public CalendarDOWForm()
        {
            InitializeComponent();
            LoadMatrixDay();
        }
        void LoadMatrixDay()
        {
            Button oldbtn = new Button() { Width = 0, Height = 0, Location = new Point(-Variable.margin, 0) };
            for(int i = 0; i < Variable.DayOfColumn; ++i)
            {
                for(int j = 0; j < Variable.DayOfWeeks; ++j)
                {
                    Button btn = new Button() {Width = Variable.btnWidth, Height = Variable.btnHeight};
                    btn.Location = new Point(oldbtn.Location.X + oldbtn.Width + Variable.margin, oldbtn.Location.Y);
                    pnlMatrixDay.Controls.Add(btn);
                    oldbtn = btn;
                }
                oldbtn = new Button() { Width = 0, Height = 0, Location = new Point(-Variable.margin, oldbtn.Location.Y + Variable.btnHeight) };
            }
        }

    }
}
