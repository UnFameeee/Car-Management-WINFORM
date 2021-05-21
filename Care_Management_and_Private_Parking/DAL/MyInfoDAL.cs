using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class MyInfoDAL
    {
        private static MyInfoDAL instance;
        public static MyInfoDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MyInfoDAL();
                }
                return MyInfoDAL.instance;
            }
            private set { MyInfoDAL.instance = value; }
        }

        public DataTable takeInfo(string EmpID)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM EMPLOYEE WHERE EmpID = @EmpID", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@EmpID", SqlDbType.NVarChar).Value = EmpID;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool editMyInfo(string ID, string name, string gender, DateTime birth, string phone, string identity, string email)
        {
            SqlCommand command = new SqlCommand("UPDATE EMPLOYEE SET FullName = @name, Gender = @gender, Birthday = @birth, PhoneNumber = @phone, IdentityNumber = @Identity, Email = @email WHERE EmpID = @EmpID", DataProvider.Instance.getConnection);
            command.Parameters.Add("@EmpID", SqlDbType.NVarChar).Value = ID;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender;
            command.Parameters.Add("@birth", SqlDbType.Date).Value = birth;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@Identity", SqlDbType.NVarChar).Value = identity;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;

            DataProvider.Instance.openConnection();

            if ((command.ExecuteNonQuery() == 1))
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
    }
}
