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

        public DataTable ShowSalaryOfEmp(int Year)
        {
            SqlCommand cmd = new SqlCommand("SELECT EmpID, YearWork, SUM(SalaryEmployee) as Salary, SUM(NumberofHourWork) as WorkHour FROM SALARY " +
                "WHERE YearWork = @Year  GROUP BY EmpID, YearWork ", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@Year", SqlDbType.Int).Value = Year;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        #region thanh search
        public DataTable SearchSalaryByYear(int year)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM SALARY WHERE YearWork = @year", DataProvider.Instance.getConnection);
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
        public DataTable SearchSalaryByMonthYear(int month, int year)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM SALARY WHERE MonthWork = @month and YearWork = @year", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@month", SqlDbType.Int).Value = month;
            cmd.Parameters.Add("@year", SqlDbType.Int).Value = year;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        #endregion
    }
}
