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
        public bool insertAccount(string username, string password, string IDnum)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO ACCOUNT (Username, Password, IdentityNumber) VALUES (@User, @Pass, @IDnum)", db.getConnection);
            cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = password;
            cmd.Parameters.Add("@IDnum", SqlDbType.VarChar).Value = IDnum;
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
        public int replacePassword(string username, string password)
        {
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM ACCOUNT WHERE Username = @User AND Password = @Pass", db.getConnection);
            cmd1.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            cmd1.Parameters.Add("@Pass", SqlDbType.VarChar).Value = password;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd1;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                return 1;                       //MK này là MK cũ, vui lòng nhập MK mới khác MK cũ
            }
            SqlCommand cmd2 = new SqlCommand("UPDATE ACCOUNT SET Password = @Pass WHERE Username = @User", db.getConnection);
            cmd2.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            cmd2.Parameters.Add("@Pass", SqlDbType.VarChar).Value = password;
            db.openConnection();
            if (cmd2.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return 2;                       //Không Thành công
            }
            else
            {
                db.closeConnection();
                return 3;                       //Thành công
            }
        }
        public bool checkAccount(string username, string IDnum)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ACCOUNT WHERE Username = @User AND IdentityNumber = @IDnum", db.getConnection);
            cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@IDnum", SqlDbType.VarChar).Value = IDnum;
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
