using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
//3layer
using Global;

namespace DAL
{
    public class TimeKeepingDAL
    {
        #region Cấu trúc singleton
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
        #endregion

        //TimeKeeping
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

        public string checkInTimeWork(string EmpID)
        {
            DataTable table = CalendarDAL.Instance.tableShift();
            List<string> shift = new List<string>();
            //Lấy ra các ca làm của nhân viên trong ngày đó
            for (int i = 0, length = table.Rows.Count; i < length; ++i)
            {
                if(table.Rows[i][0].ToString() == EmpID)
                {
                    shift.Add(table.Rows[i][1].ToString());
                }
            }

            //Kiểm tra theo ca làm
            SqlCommand cmd = new SqlCommand("SELECT * FROM WORKSHIFT WHERE ShiftID = @ShiftID", DataProvider.Instance.getConnection);
            DataTable tbShift = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            TimeSpan timelate;                                                      //tgian trễ
            TimeSpan timenow = (TimeSpan)DateTime.Now.TimeOfDay;                    //tgian bây h
            TimeSpan timestart;                                                     //tgian bắt đầu ca làm
            for(int i = 0, length = shift.Count; i < length; ++i)
            {
                cmd.Parameters.Add("@ShiftID", SqlDbType.NVarChar).Value = shift[i];
                adapter.SelectCommand = cmd;
                adapter.Fill(tbShift);
                timestart = (TimeSpan)tbShift.Rows[0]["TimeBegin"];

                timelate = timenow - timestart;
                if (timelate > TimeSpan.Parse("00:00:00"))                          //Nếu mà nó âm => chưa tới ca làm
                {
                    if(timelate <= TimeSpan.Parse("01:00:00"))                      //Được quyền check in trễ 1 tiếng
                    {
                        return "1";
                    }
                    else
                    {
                        return "2";
                    }
                }
                cmd.Parameters.Clear();
            }
            return "3";
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

        //ManageShift

        #region Phần trên
        public DataTable getMiniID(string EmpID)
        {
            SqlCommand cmd = new SqlCommand("SELECT EmpID as EnployeeID, FullName FROM EMPLOYEE WHERE EmpID = @EmpID", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@EmpID", SqlDbType.NVarChar).Value = EmpID;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }
        #endregion

        #region Phần dưới
        public DataTable Find2(string ShiftID)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM WORKSHIFT WHERE ShiftID = @ShiftID", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@ShiftID", SqlDbType.NVarChar).Value = ShiftID;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool check2(string ShiftID)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM WORKSHIFT WHERE ShiftID = @ShiftID", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@ShiftID", SqlDbType.NVarChar).Value = ShiftID;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
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
        public bool AddDivideTimeShift(string ShiftID, TimeSpan TimeBegin, TimeSpan TimeEnd)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO WORKSHIFT (ShiftID, TimeBegin, TimeEnd) VALUES (@ShiftID, @TimeBegin, @TimeEnd)", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@ShiftID", SqlDbType.NVarChar).Value = ShiftID;
            cmd.Parameters.Add("@TimeBegin", SqlDbType.Time).Value = TimeBegin;
            cmd.Parameters.Add("@TimeEnd", SqlDbType.Time).Value = TimeEnd;
            DataProvider.Instance.openConnection();
            if ((cmd.ExecuteNonQuery() == 1))
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
        public bool UpdateDivideTimeShift(string ShiftID, TimeSpan TimeBegin, TimeSpan TimeEnd)
        {
            SqlCommand cmd = new SqlCommand("UPDATE WORKSHIFT SET ShiftID = @ShiftID, TimeBegin = @TimeBegin, TimeEnd = @TimeEnd WHERE ShiftID = @ShiftID", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@ShiftID", SqlDbType.NVarChar).Value = ShiftID;
            cmd.Parameters.Add("@TimeBegin", SqlDbType.Time).Value = TimeBegin;
            cmd.Parameters.Add("@TimeEnd", SqlDbType.Time).Value = TimeEnd;
            DataProvider.Instance.openConnection();
            if ((cmd.ExecuteNonQuery() == 1))
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
        public bool DeleteDivideTimeShift(string ShiftID)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM WORKSHIFT WHERE ShiftID = @ShiftID", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@ShiftID", SqlDbType.NVarChar).Value = ShiftID;
            DataProvider.Instance.openConnection();
            if ((cmd.ExecuteNonQuery() == 1))
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

        #region fill DGV
        public DataTable fillDGV3()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM WORKSHIFT", DataProvider.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable fillDGV2()
        {
            SqlCommand cmd = new SqlCommand("SELECT EmpID as EmployeeID, FullName FROM EMPLOYEE", DataProvider.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        #endregion

        #region Thêm giờ làm vào SALARY
        //Hàm check ktra xem nhân viên đã tồn tại vào tháng và năm đó trong SALARY chưa
        public bool checkSalaryExist(string EmpID, int month, int year)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM SALARY WHERE EmpID = @EmpID and MonthWork = @month and YearWork = @year", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@EmpID", SqlDbType.NVarChar).Value = EmpID;
            cmd.Parameters.Add("@month", SqlDbType.Int).Value = month;
            cmd.Parameters.Add("@year", SqlDbType.Int).Value = year;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Lấy ra thời gian bắt đầu làm việc của nhân viên đó
        public TimeSpan takeTimeStart(string EmpID)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TIMEKEEPING WHERE EmpID = @EmpID and CheckOut is null", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@EmpID", SqlDbType.NVarChar).Value = EmpID;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return TimeSpan.Parse(table.Rows[0]["CheckIn"].ToString());
        }



        //TH1: Chưa có thông tin về EmpID, Month, Year đó trong SALARY
        public bool insertEmpToSalary(string EmpID, int month, int year, TimeSpan hourwork, float salary)
        {
            SqlCommand command = new SqlCommand("Insert into EMPLOYEE (EmpID, MonthWork, YearWork, NumberofHourWork, SalaryEmployee)" +
                "values (@EmpID, @month, @year, @hourwork, @salary)", DataProvider.Instance.getConnection);
            command.Parameters.Add("@EmpID", SqlDbType.NVarChar).Value = EmpID;
            command.Parameters.Add("@month", SqlDbType.Int).Value = month;
            command.Parameters.Add("@year", SqlDbType.Int).Value = year;
            command.Parameters.Add("@hourwork", SqlDbType.Time).Value = hourwork;
            command.Parameters.Add("@salary", SqlDbType.Float).Value = salary;

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
    }
}
