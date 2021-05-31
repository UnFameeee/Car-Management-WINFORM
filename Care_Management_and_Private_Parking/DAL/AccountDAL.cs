using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Data.SqlClient;


namespace DAL
{
    public class AccountDAL
    {
        //Cấu trúc singleton
        private static AccountDAL instance;
        public static AccountDAL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new AccountDAL();
                }
                return AccountDAL.instance;
            }
            private set { AccountDAL.instance = value; }
        }

        //Thêm tài khoản
        public bool insertAccount(string username, string password, string position)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO ACCOUNT (Username, Password, PositionID) VALUES (@User, @Pass, @PId)", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = password;
            cmd.Parameters.Add("@PId", SqlDbType.VarChar).Value = position;
            DataProvider.Instance.openConnection();
            if(cmd.ExecuteNonQuery() == 1)
            {
                DataProvider.Instance.closeConnection();
                return true;
            }
            else
            {
                DataProvider.Instance.closeConnection();
                return false;
            }
        }

        //Thay đổi password
        public int replacePassword(string username, string password)
        {
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM ACCOUNT WHERE Username = @User AND Password = @Pass", DataProvider.Instance.getConnection);
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
            SqlCommand cmd2 = new SqlCommand("UPDATE ACCOUNT SET Password = @Pass WHERE Username = @User", DataProvider.Instance.getConnection);
            cmd2.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            cmd2.Parameters.Add("@Pass", SqlDbType.VarChar).Value = password;
            DataProvider.Instance.openConnection();
            if (cmd2.ExecuteNonQuery() == 1)
            {
                DataProvider.Instance.closeConnection();
                return 2;                       //Không Thành công
            }
            else
            {
                DataProvider.Instance.closeConnection();
                return 3;                       //Thành công
            }
        }

        //Ktra tài khoản đó xem có tồn tại hay là không
        public bool checkAccount(string username, string EmpID, string position)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ACCOUNT, EMPLOYEE WHERE ACCOUNT.Username = EMPLOYEE.AccUsername and" +
                " Username = @User AND EmpID = @EmpID AND PositionID = @PId", DataProvider.Instance.getConnection);
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM POSITION", DataProvider.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }

        //Check login
        public bool checkLogin(string username, string password, string position)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ACCOUNT WHERE Username = @User AND Password = @Pass AND PositionID = @PId", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = password;
            cmd.Parameters.Add("@PId", SqlDbType.VarChar).Value = position;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Lấy EmpID
        public string takeEmpID(string username, string password, string position)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ACCOUNT, EMPLOYEE WHERE ACCOUNT.Username = EMPLOYEE.AccUsername and" +
                " Username = @User and Password = @Pass and PositionID = @PId", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = password;
            cmd.Parameters.Add("@PId", SqlDbType.VarChar).Value = position;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DataTable table = new DataTable();
            adapter.Fill(ds, "EmpID");
            table = ds.Tables["EmpID"];
            string res = table.Rows[0]["EmpID"].ToString();
            return res;

            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //string res = table.Rows[0][4].ToString();
            //return res;
        }

        public bool updateAccount(string username, string password, string position)
        {
            SqlCommand cmd = new SqlCommand("UPDATE ACCOUNT SET Password = @Pass, PositionID = @PId WHERE Username = @User", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = password;
            cmd.Parameters.Add("@PId", SqlDbType.VarChar).Value = position;

            DataProvider.Instance.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                DataProvider.Instance.closeConnection();
                return true;
            }
            else
            {
                DataProvider.Instance.closeConnection();
                return false;
            }
        }

        public bool removeAccount(string username, string password, string position)
        {
            SqlCommand cmd = new SqlCommand("DELETE from ACCOUNT where Username = @User and PositionID = @PId and Password = @Pass", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = password;
            cmd.Parameters.Add("@PId", SqlDbType.VarChar).Value = position;

            DataProvider.Instance.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                DataProvider.Instance.closeConnection();
                return true;
            }
            else
            {
                DataProvider.Instance.closeConnection();
                return false;
            }
        }

        public DataTable getAccount(SqlCommand com)
        {
            com.Connection = DataProvider.Instance.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getAllAccount()
        {
            SqlCommand cmd = new SqlCommand("SELECT Username, Password, Description as Position FROM ACCOUNT, POSITION where ACCOUNT.PositionID = POSITION.PositionID");
            return getAccount(cmd);
        }
    }
}
