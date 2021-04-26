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

        //Thêm tài khoản
        public bool insertAccount(string username, string password, string EmpID, string position)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO ACCOUNT (Username, Password, EmpID, PositionID) VALUES (@User, @Pass, @EmpID, @PId)", db.getConnection);
            cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = password;
            cmd.Parameters.Add("@EmpID", SqlDbType.VarChar).Value = EmpID;
            cmd.Parameters.Add("@PId", SqlDbType.VarChar).Value = position;
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

        //Thay đổi password
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

        //Ktra tài khoản đó xem có tồn tại hay là không
        public bool checkAccount(string username, string EmpID, string position)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ACCOUNT WHERE Username = @User AND EmpID = @EmpID AND PositionID = @PId", db.getConnection);
            cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@EmpID", SqlDbType.VarChar).Value = EmpID;
            cmd.Parameters.Add("@PId", SqlDbType.VarChar).Value = position;
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

        //Lấy role từ bảng position
        public DataTable takeRole()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM POSITION", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }
    }
}
