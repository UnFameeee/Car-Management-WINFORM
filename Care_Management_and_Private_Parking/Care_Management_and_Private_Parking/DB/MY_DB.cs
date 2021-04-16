using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Care_Management_and_Private_Parking
{
    class MY_DB
    {
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3E7V855;Initial Catalog=WINFORM;Integrated Security=True"); //QT-laptop
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OQLFA92;Initial Catalog=WINFORM;Integrated Security=True"); //QT-PC
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }

        // open the connection
        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }
        }
        // close the connection
        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }
        }
    }
}
