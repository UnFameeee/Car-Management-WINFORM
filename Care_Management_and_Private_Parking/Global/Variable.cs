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
        #region Calendar Form
        public static int DayOfWeeks = 7;               //Ngày trong tuần
        public static int DayOfColumn = 6;              //6 hàng
        public static int btnWidth = 31;                //Độ rộng của nút ngày
        public static int btnHeight = 31;               //Độ dài của nút ngày
        public static int margin = 5;                   //Khoảng cách giãn cách giữa các nút ngày
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
        public static int RentRows = 7;                  //Hàng xe
        public static int RentColumns = 14;              //Cột xe
        public static int RentalLength = 3;
        public static string Rental = "Veh";
        #endregion

        #region TimeKeeping
        public static int picSlot = 12;     
        #endregion
    }
}