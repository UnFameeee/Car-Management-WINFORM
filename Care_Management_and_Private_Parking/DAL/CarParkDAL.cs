using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class CarParkDAL
    {
        //Cấu trúc singleton
        private static CarParkDAL instance;
        public static CarParkDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CarParkDAL();
                }
                return CarParkDAL.instance;
            }
            private set { CarParkDAL.instance = value; }
        }
    }
}
