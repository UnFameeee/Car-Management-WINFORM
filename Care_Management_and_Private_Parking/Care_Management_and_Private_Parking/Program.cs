using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Care_Management_and_Private_Parking
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());
            //LoginForm frm = new LoginForm();
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    Application.Run(new CalendarDOWForm());
            //}

            //Application.Run(new MainForm());
            //Application.Run(new CalendarDOWForm());
            Application.Run(new ManangeEmpForm());
        }
    }
}
