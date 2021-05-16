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

        public int MoneyHaveToPay(DateTime date1, DateTime date2, string id, int index, int x) //date2 bắt buộc phải là ngày sau date1
        {
            int total = 0;                                          //tổng tiền
            TimeSpan datediff = date2.Subtract(date1);              //phép trừ 2 ngày 
            double hour = datediff.TotalHours;                      //đổi thành giờ (số giờ đã gửi)

            double late = hour - (int)hour;

            if (late > 0.25)                                        //trễ quá 15p thì tăng thêm 1h
                hour = (int)hour + 1;
            else                                                    //dưới 15p thì làm tròn xuống
                hour = (int)hour;

            int day = (int)hour / 24;                               //đổi giờ thành ngày
            int week = day / 7;                                     //đổi ngày thành tuần
            int month = day / 30;                                   //đổi tuần thánh tháng

            if (id == "H")                                          //theo  giờ
            {
                if (hour == index)                                  //giờ gửi bằng với giờ đã đặt
                    total = x * index;

                else if (hour > index)                              //giờ gửi lố với giờ đã đặt
                {
                    if (hour > 24)                                  //giờ gửi lố 24h (1ngày)                    
                        total = x * (12 + (int)hour);
                    else
                        total = x * (int)hour;
                }

                else                                                //giờ gửi sớm hơn giờ đã đặt
                    total = x * (int)hour;
            }

            else if (id == "D")                                     //theo ngày
            {
                if (day == index)
                    total = x * 8 * index;

                else if (day > index)
                {
                    if (day > 7)
                        total = 2 * x * 8 * (7 + day);
                    else
                        total = x * 8 * (3 + day);
                }

                else
                    total = x * 8 * day;
            }

            else if (id == "W")
            {
                if (week == index)
                    total = x * 24 * index;

                else if (week > index)
                {
                    if (week > 4)
                        total = x * 24 * (4 * week + index);
                    else
                        total = x * 24 * week * 2;
                }

                else
                    total = x * 24 * week;
            }

            else
            {
                if (month == index)
                    total = x * 48 * index;

                else if (month > index)
                {
                    if (month > 12)
                        total = x * 48 * (month + 4 + index);
                    else
                        total = x * 48 * (month + index);
                }

                else
                    total = x * 48 * month;
            }
            return total;
        }
    }
}
