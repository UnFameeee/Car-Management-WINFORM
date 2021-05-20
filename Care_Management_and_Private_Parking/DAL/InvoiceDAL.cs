using System;
using System.Collections.Generic;
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

        public int MoneyHaveToPay(DateTime date1, DateTime date2, int index, string timeformat, string type, string service) //date2 bắt buộc phải là ngày sau date1
        {
            int x;                                                  //tiền gửi của mỗi loại xe (đơn vị là VNĐ)
            if (type == "Bicycle")
                x = 2;
            else if (type == "Bike")
                x = 5;
            else x = 20;


            int sv = 0;                                             //tiền rửa hoặc sửa (nếu có)
            if (service == "Washing")
            {
                if (type == "Bicycle")
                    sv = 20;
                else if (type == "Bike")
                    sv = 50;
                else sv = 200;
            }

            if (service == "Repairing")
            {
                if (type == "Bicycle")
                    sv = 50;
                else if (type == "Bike")
                    sv = 200;
                else sv = 800;
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

            return (total + sv) * 1000;                             //để ra tiền VNĐ
        }
    }
}
