using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class ProfitDAL
    {
        private static ProfitDAL instance;
        public static ProfitDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProfitDAL();
                }
                return ProfitDAL.instance;
            }
            private set { ProfitDAL.instance = value; }
        }
        
    }
}
