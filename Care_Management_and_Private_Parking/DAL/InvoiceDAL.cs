using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InvoiceDAL
    {
        private static InvoiceDAL instance;
        public static InvoiceDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InvoiceDAL();
                }
                return InvoiceDAL.instance;
            }
            private set { InvoiceDAL.instance = value; }
        }

        #region Lấy thông tin
        public DataTable getData(SqlCommand command)
        {
            command.Connection = DataProvider.Instance.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getAllTimeFormat()
        {
            SqlCommand com = new SqlCommand("select * from TIMEFORMAT where ID != 'null'");
            return getData(com);
        }
        #endregion

        #region Tiền thu nhập từ gửi xe, sửa xe, rửa xe
        
        //Tính tiền gửi xe
        public int MoneyHaveToPay(DateTime date1, DateTime date2, int index, string timeformat, string type, string service) //date2 bắt buộc phải là ngày sau date1
        {
            int x;                                                  //tiền gửi của mỗi loại xe (đơn vị là VNĐ)
            if (type == "bicycle")
                x = 2;
            else if (type == "bike")
                x = 5;
            else x = 20;

            int sv = 0;                                             //tiền rửa hoặc sửa (nếu có)
            if (service != "")
            {
                if (service == "Repairing and Washing")
                {
                    if (type == "bicycle")
                        sv = 70;
                    else if (type == "bike")
                        sv = 250;
                    else sv = 1000;

                    if (timeformat == "H")
                        index += 2;
                }
                else
                {
                    if (service == "Washing")
                    {
                        if (type == "bicycle")
                            sv = 20;
                        else if (type == "bike")
                            sv = 50;
                        else sv = 200;
                    }
                    else
                    {
                        if (type == "bicycle")
                            sv = 50;
                        else if (type == "bike")
                            sv = 200;
                        else sv = 800;
                    }

                    if (timeformat == "H")
                        index += 1;
                }
            }

            int total = 0;                                          //tổng tiền
            TimeSpan datediff = date2.Subtract(date1);              //phép trừ 2 ngày 
            double ddhour = datediff.TotalHours;                    //đổi thành giờ (số giờ đã gửi)              

            double late = ddhour - (int)ddhour;                     //số dư của giờ  

            int hour;                                               //giờ

            if (late > 0.25)                                        //trễ quá 15p thì tăng thêm 1h
                hour = (int)ddhour + 1;
            else                                                    //dưới 15p thì làm tròn xuống
                hour = (int)ddhour;

            int day = hour / 24;                                    //đổi giờ thành ngày
            int week = day / 7;                                     //đổi ngày thành tuần
            int month = day / 30;                                   //đổi tuần thánh tháng

            if (index == 0 || timeformat == "null")                 //ko gửi xe chỉ có service (dược lấy trong ngày)               
            {
                if (day > 0)                                        //lấy lố ngày 
                    total = x * (day + 1);
                else total = 0;                                     //lấy trong ngày
            }
            else
            {
                if (timeformat == "H")                                  //theo  giờ
                {
                    if (hour == index)                                  //giờ gửi bằng với giờ đã đặt
                        total = x * index;

                    else if (hour > index)                              //giờ gửi lố với giờ đã đặt
                    {
                        if (hour > 24)                                  //giờ gửi lố 24h (1ngày)                    
                            total = x * (hour / 3 + hour);
                        else                                            //VD: đặt 3h nhưng lại trễ 2h (5h mới lấy)
                            total = x * (1 + hour);
                    }

                    else                                                //giờ gửi sớm hơn giờ đã đặt
                        total = x * (int)hour;
                }

                else if (timeformat == "D")                             //theo ngày
                {
                    if (day == index)
                        total = x * 8 * index;

                    else if (day > index)
                    {
                        if (day > 7)
                            total = x * 8 * (day / 2 + day);
                        else
                            total = x * 8 * (1 + day);
                    }

                    else
                        total = x * 8 * day;
                }

                else if (timeformat == "W")                             //theo tuần
                {
                    if (week == index)
                        total = x * 24 * index;

                    else if (week > index)
                    {
                        if (week > 4)
                            total = x * 24 * (week / 2 * week);
                        else
                            total = x * 24 * (1 + week);
                    }

                    else
                        total = x * 24 * week;
                }

                else                                                    //theo tháng
                {
                    if (month == index)
                        total = x * 48 * index;

                    else if (month > index)
                    {
                        if (month > 12)
                            total = x * 48 * (month / 6 + month);
                        else
                            total = x * 48 * (1 + month);
                    }

                    else
                        total = x * 48 * month;
                }
            }
            return (total + sv) * 1000;                             //để ra tiền VNĐ
        }

        //Kiểm tra xem ngày tháng năm trong db đã có hay chưa (có rồi thì update chưa thì insert)
        public bool checkParkingDate(int day, int month, int year)
        {
            SqlCommand com = new SqlCommand("Select * from PARKINGPROFIT where DayPPF = @day and MonthPPF = @month and YearPPF = @year", DataProvider.Instance.getConnection);
            com.Parameters.Add("@day", SqlDbType.Int).Value = day;
            com.Parameters.Add("@month", SqlDbType.Int).Value = month;
            com.Parameters.Add("@year", SqlDbType.Int).Value = year;

            SqlDataAdapter adapter = new SqlDataAdapter(com);
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

        public bool insertParkingProfit(int day, int month, int year, int money)
        {
            SqlCommand com = new SqlCommand("insert into PARKINGPROFIT (DayPPF, MonthPPF, YearPPF, MoneyP) " +
                "values (@day, @month, @year, @money)", DataProvider.Instance.getConnection);
            com.Parameters.Add("@day", SqlDbType.Int).Value = day;
            com.Parameters.Add("@month", SqlDbType.Int).Value = month;
            com.Parameters.Add("@year", SqlDbType.Int).Value = year;
            com.Parameters.Add("@money", SqlDbType.Int).Value = money;

            DataProvider.Instance.openConnection();
            if (com.ExecuteNonQuery() == 1)
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

        public bool updateParkingProfit(int day, int month, int year, int money)
        {
            SqlCommand com = new SqlCommand("update PARKINGPROFIT set MoneyP = @money " +
                "where DayPPF = @day and MonthPPF = @month and YearPPF = @year", DataProvider.Instance.getConnection);
            com.Parameters.Add("@day", SqlDbType.Int).Value = day;
            com.Parameters.Add("@month", SqlDbType.Int).Value = month;
            com.Parameters.Add("@year", SqlDbType.Int).Value = year;
            com.Parameters.Add("@money", SqlDbType.Int).Value = money;

            DataProvider.Instance.openConnection();
            if (com.ExecuteNonQuery() == 1)
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

        #region Tiền từ hợp đồng
        //Kiểm tra xem ngày tháng năm trong db đã có hay chưa (có rồi thì update chưa thì insert)
        public bool checkContractDate(int day, int month, int year)
        {
            SqlCommand com = new SqlCommand("Select * from CONTRACTPROFIT where DayCPF = @day and MonthCPF = @month and YearCPF = @year", DataProvider.Instance.getConnection);
            com.Parameters.Add("@day", SqlDbType.Int).Value = day;
            com.Parameters.Add("@month", SqlDbType.Int).Value = month;
            com.Parameters.Add("@year", SqlDbType.Int).Value = year;

            SqlDataAdapter adapter = new SqlDataAdapter(com);
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

        public bool insertContractProfit(int day, int month, int year, int money)
        {
            SqlCommand com = new SqlCommand("insert into CONTRACTPROFIT (DayCPF, MonthCPF, YearCPF, MoneyC) " +
                "values (@day, @month, @year, @money)", DataProvider.Instance.getConnection);
            com.Parameters.Add("@day", SqlDbType.Int).Value = day;
            com.Parameters.Add("@month", SqlDbType.Int).Value = month;
            com.Parameters.Add("@year", SqlDbType.Int).Value = year;
            com.Parameters.Add("@money", SqlDbType.Int).Value = money;

            DataProvider.Instance.openConnection();
            if (com.ExecuteNonQuery() == 1)
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

        public bool updateContractProfit(int day, int month, int year, int money)
        {
            SqlCommand com = new SqlCommand("update PARKINGPROFIT set MoneyC = @money " +
                "where DayCPF = @day and MonthCPF = @month and YearCPF = @year", DataProvider.Instance.getConnection);
            com.Parameters.Add("@day", SqlDbType.Int).Value = day;
            com.Parameters.Add("@month", SqlDbType.Int).Value = month;
            com.Parameters.Add("@year", SqlDbType.Int).Value = year;
            com.Parameters.Add("@money", SqlDbType.Int).Value = money;

            DataProvider.Instance.openConnection();
            if (com.ExecuteNonQuery() == 1)
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
