using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
//3layers
using Global;

namespace DAL
{
    public class CalendarDAL
    {
        #region singleton
        private static CalendarDAL instance;
        public static CalendarDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CalendarDAL();
                }
                return CalendarDAL.instance;
            }
            private set { CalendarDAL.instance = value; }
        }
        #endregion

        #region Properties
        public int NV;                                                      //x nhân viên
        public int CL = getTotalShift();                                    //y ca làm
        #endregion

        #region Hàm để lấy ra số lượng ca làm và nhân viên
        //Nhân viên - Nhân viên văn phòng
        public int getTotalEmp()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM EMPLOYEE WHERE JobID != 1", DataProvider.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table.Rows.Count;
        }
        public DataTable getTableTotalEmp()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM EMPLOYEE WHERE JobID != 1", DataProvider.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool checkTableTotalEmp(string EmpID)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM EMPLOYEE WHERE JobID != 1 and EmpID = @EmpID", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("EmpID", SqlDbType.NVarChar).Value = EmpID;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        //Quản lý
        public int getTotalManager()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM EMPLOYEE WHERE JobID = 1", DataProvider.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table.Rows.Count;
        }
        public DataTable getTableTotalManager()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM EMPLOYEE WHERE JobID = 1", DataProvider.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool checkTableTotalManager(string EmpID)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM EMPLOYEE WHERE JobID = 1 and EmpID = @EmpID", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("EmpID", SqlDbType.NVarChar).Value = EmpID;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }


        //Ca làm
        public static int getTotalShift()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM WORKSHIFT", DataProvider.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table.Rows.Count;
        }
        #endregion

        #region Hàm để lấy ra table ca làm trong ngày (Private)
        public DataTable tableShift(string operation)
        {
            if(operation == "NV")
            {
                NV = getTotalEmp();
            }
            else
            {
                NV = getTotalManager();
            }
            CL = getTotalShift();
            DataTable table;
            if (operation == "NV")
            {
                table = getTableTotalEmp();
            }
            else
            {
                table = getTableTotalManager();
            }

            DivideShift dv = new DivideShift();
            List<List<int>> DOW;                                                                                          //Tạo mảng 2 chiều
            DataTable res = new DataTable();
            res.Columns.Add("EmployeeID", typeof(string));                                                                //Thêm vào table cột EmpID
            res.Columns.Add("ShiftID", typeof(string));                                                                   //Thêm vào table cột ShiftID
            DataRow toInsert;                                                                                             //Tạo DataRow
            DOW = dv.SetTheBaseDOW(NV, CL, Convert.ToInt32(DateTime.Now.ToString("dd")) + (DateTime.Now.Month % 2));      //Lấy mảng 2 chiều chia ca
            for (int i = 0; i < NV; ++i)
            {
                for (int j = 0; j < CL; ++j)
                {
                    if (DOW[j][i] == 1)
                    {
                        toInsert = res.NewRow();                                                                          //Thêm dòng mới vào datarow
                        toInsert["EmployeeID"] = table.Rows[i][0].ToString();
                        toInsert["ShiftID"] = (j + 1).ToString();
                        res.Rows.Add(toInsert);                                                                           //thêm dòng datarow vào datatable
                    }
                }
            }
            return res;
        }
        #endregion

        #region Hàm tính tiền lương của nhân viên đó
        public int getSalary(string EmpID)
        {
            SqlCommand cmd = new SqlCommand("SELECT MonthWork, YearWork, SUM(SalaryEmployee) as Salary FROM SALARY " +
                "WHERE YearWork = @Year and MonthWork = @Month and EmpID = @EmpID GROUP BY MonthWork, YearWork", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@EmpID", SqlDbType.NVarChar).Value = EmpID;
            cmd.Parameters.Add("@Year", SqlDbType.NVarChar).Value = DateTime.Now.Year;
            cmd.Parameters.Add("@Month", SqlDbType.NVarChar).Value = DateTime.Now.Month;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                return Convert.ToInt32(table.Rows[0]["Salary"]);
            else
                return 0;
        }
        public int getWorkHours(string EmpID)
        {
            SqlCommand cmd = new SqlCommand("SELECT MonthWork, YearWork, SUM(NumberofHourWork) as WorkHour FROM SALARY  " +
                "WHERE YearWork = @Year and MonthWork = @Month and EmpID = @EmpID  GROUP BY MonthWork, YearWork ", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@EmpID", SqlDbType.NVarChar).Value = EmpID;
            cmd.Parameters.Add("@Year", SqlDbType.NVarChar).Value = DateTime.Now.Year;
            cmd.Parameters.Add("@Month", SqlDbType.NVarChar).Value = DateTime.Now.Month;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                return Convert.ToInt32(table.Rows[0]["WorkHour"]);
            else
                return 0;
        }
        #endregion
    }
}
