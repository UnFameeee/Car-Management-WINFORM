using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Care_Management_and_Private_Parking
{
    class Account
    {
        MY_DB db = new MY_DB();
        public bool insertAccount(string username, string password, string email)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO ACCOUNT (Username, Password, Gmail) VALUES (@User, @Pass, @Gmail)", db.getConnection);
            cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = password;
            cmd.Parameters.Add("@Gmail", SqlDbType.VarChar).Value = email;
            db.openConnection();
            if(cmd.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        public bool checkAccount(string username, string email)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ACCOUNT WHERE Username = @User AND Gmail = @Gmail", db.getConnection);
            cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@Gmail", SqlDbType.VarChar).Value = email;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if(table.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
