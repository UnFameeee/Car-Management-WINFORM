using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class TimeKeepingDAL
    {
        //Cấu trúc singleton
        private static TimeKeepingDAL instance;
        public static TimeKeepingDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TimeKeepingDAL();
                };
                return TimeKeepingDAL.instance;
            }
            private set { TimeKeepingDAL.instance = value; }
        }

        public DataTable ShowTimeKeeping()
        {
            SqlCommand cmd = new SqlCommand("SELECT EmpID, CheckIn, CheckOut FROM TIMEKEEPING", DataProvider.Instance.getConnection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }

        #region Phần điểm danh
        public bool CheckIDWork(string EmpID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM TIMEKEEPING WHERE EmpID = @EmpID AND CheckOut IS NULL", DataProvider.Instance.getConnection);
            command.Parameters.Add("@EmpID",SqlDbType.NVarChar).Value = EmpID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data.Rows.Count > 0;
        }

        public bool CheckIDEmployee(string EmpID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM EMPLOYEE WHERE EmpID = @EmpID", DataProvider.Instance.getConnection);
            command.Parameters.Add("@EmpID", SqlDbType.NVarChar).Value = EmpID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data.Rows.Count > 0;
        }

        public bool AddCheckIn(string EmpID, DateTime timein)
        {
            SqlCommand command = new SqlCommand("INSERT INTO dbo.TIMEKEEPING (EmpID, CheckIn) VALUES (@EmpID, @timein)", DataProvider.Instance.getConnection);
            command.Parameters.Add("@EmpID", SqlDbType.NVarChar).Value = EmpID;
            command.Parameters.Add("@timein", SqlDbType.NVarChar).Value = timein;
            DataProvider.Instance.openConnection();
            if (command.ExecuteNonQuery() == 1)
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

        public bool AddCheckOut(string EmpID, DateTime timeout)
        {
            SqlCommand command = new SqlCommand("UPDATE TIMEKEEPING SET CheckOut = @timeout WHERE EmpID = @EmpID AND CheckOut IS NULL", DataProvider.Instance.getConnection);
            command.Parameters.Add("@EmpID", SqlDbType.NVarChar).Value = EmpID;
            command.Parameters.Add("@timeout", SqlDbType.NVarChar).Value = timeout;
            DataProvider.Instance.openConnection();
            if (command.ExecuteNonQuery() == 1)
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
        #endregion

        #region Phần hình
        public DataTable takeInfoForCalendar(string EmpID)
        {
            SqlCommand cmd = new SqlCommand("SELECT EmpID, FullName, Gender, PhoneNumber, IdentityNumber FROM EMPLOYEE WHERE EmpID = @EmpID", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@EmpID", SqlDbType.NVarChar).Value = EmpID;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }

        public DataTable takePic(string EmpID)
        {
            SqlCommand cmd = new SqlCommand("SELECT Appearance, FullName FROM EMPLOYEE WHERE EmpID = @EmpID", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@EmpID", SqlDbType.NVarChar).Value = EmpID;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }

        public DataTable takeEmpWorking()
        {
            SqlCommand cmd = new SqlCommand("SELECT EmpID FROM TIMEKEEPING WHERE CheckOut is null", DataProvider.Instance.getConnection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }
        #endregion
    }
}
