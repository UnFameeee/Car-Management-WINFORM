using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ManageSalaryDAL
    {
        #region Singleton
        private static ManageSalaryDAL instance;
        public static ManageSalaryDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ManageSalaryDAL();
                }
                return ManageSalaryDAL.instance;
            }
            private set { ManageSalaryDAL.instance = value; }
        }
        #endregion

        public DataTable ShowSalary()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM SALARY", DataProvider.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        #region thanh search
        public DataTable SearchSalaryByYear(int year)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM SALARY WHERE YearMonth = @year", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@year", SqlDbType.Int).Value = year;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable SearchSalaryByMonth(int month)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM SALARY WHERE MonthWork = @month", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@month", SqlDbType.Int).Value = month;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable SearchSalaryByMonthYear(int year, int month)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM SALARY WHERE MonthWork = @month and YearMonth = @year", DataProvider.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        #endregion
    }
}
