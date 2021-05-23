using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Global
{
    public class Variable
    {
        #region dbconnection
        static SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=WINFORM;Integrated Security=True");
        private SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }
        // open the connection
        private void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }
        }
        // close the connection
        private void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }
        }
        #endregion

        #region Calendar Form
        public static int DayOfWeeks = 7;               //Ngày trong tuần
        public static int DayOfColumn = 6;              //6 hàng
        public static int btnWidth = 31;                //Độ rộng của nút ngày
        public static int btnHeight = 31;               //Độ dài của nút ngày
        public static int margin = 5;                   //Khoảng cách giãn cách giữa các nút ngày
        public static int NV = getTotalEmp();                       //6 nhân viên
        public static int CL = getTotalShift();                       //3 ca làm
        public static int borderRadius = 14;
        #endregion

        #region ParkingLot Form
        public static int btnCarWidth = 40;             //Độ rộng của nút xe
        public static int btnCarHeight = 40;            //Độ dài của nút xe 
        public static int CarRows = 2;                  //Hàng xe
        public static int CarColumns = 14;              //Cột xe
        public static int CarMargin = 10;

        //ID các loại xe
        public static int BicycleLength = 7;               
        public static int BikeLength = 4;              
        public static int CarLength = 3;
        public static string Bicycle = "bicycle";
        public static string Bike = "bike";
        public static string Car = "car";

        //ID khách
        public static int CusLength = 3;
        public static string Cus = "cus";
        #endregion

        #region RentalLot Form
        public static int RentRows = 3;                  //Hàng xe
        public static int RentColumns = 14;              //Cột xe
        #endregion

        #region TimeKeeping
        public static int picSlot = 12;
        public static DataTable tableShift = fillDay(Convert.ToInt32(DateTime.Now.ToString("dd")), DateTime.Now.Month);
        #endregion

        #region Hàm để lấy ra table ca làm trong ngày (Private)
        
        private static string convertToEmpID(int EmpID)                                                   //EmpID được quy định là 2 chữ cái đầu + mã số NV ở sau
        {
            string res = "NV" + EmpID.ToString();
            return res;
        }
        private static DataTable fillDay(int rotateDay, int month)
        {
            DivideShift dv = new DivideShift();
            List<List<int>> DOW;                                                            //Tạo mảng 2 chiều
            DataTable res = new DataTable();
            res.Columns.Add("EmployeeID", typeof(string));                                  //Thêm vào table cột EmpID
            res.Columns.Add("ShiftID", typeof(string));                                     //Thêm vào table cột ShiftID
            DataRow toInsert;                                                               //Tạo DataRow
            DOW = dv.SetTheBaseDOW(Variable.NV, Variable.CL, rotateDay + (month % 2));      //Lấy mảng 2 chiều chia ca
            for(int i = 0; i < NV; ++i)
            {
                for (int j = 0; j < CL; ++j)
                {
                    if (DOW[j][i] == 1)
                    {
                        toInsert = res.NewRow();                                            //Thêm dòng mới vào datarow
                        toInsert["EmployeeID"] = convertToEmpID(i+1);
                        toInsert["ShiftID"] = (j+1).ToString();
                        res.Rows.Add(toInsert);                                             //thêm dòng datarow vào datatable
                    }
                }
            }

            return res;
        }
        #endregion

        #region Hàm để lấy ra số lượng ca làm và nhân viên
        static protected int getTotalEmp()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM EMPLOYEE", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table.Rows.Count;
        }
        static protected int getTotalShift()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM WORKSHIFT", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table.Rows.Count;
        }
        #endregion
    }
}