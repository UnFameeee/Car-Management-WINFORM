using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class StatisticDAL
    {
        private static StatisticDAL instance;
        public static StatisticDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StatisticDAL();
                }
                return StatisticDAL.instance;
            }
            private set { StatisticDAL.instance = value; }
        }

        #region SalaryEmployee
        public DataTable loadTableSalary(int year)
        {
            SqlCommand cmd = new SqlCommand("SELECT MonthWork, YearWork, SUM(SalaryEmployee) as Salary, SUM(NumberofHourWork) as WorkHour FROM SALARY " +
                " WHERE YearWork = @Year GROUP BY MonthWork, YearWork ", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@Year", SqlDbType.Int).Value = year;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public int takeMale()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM EMPLOYEE WHERE Gender = 'Male' ", DataProvider.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table.Rows.Count;
        }

        public int takeFemale()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM EMPLOYEE WHERE Gender = 'Female' ", DataProvider.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table.Rows.Count;
        }
        #endregion


    }
}
