using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global
{
    public class UserID
    {
        public static string GlobalUserID { get; private set; }
        public static void SetGlobalUserID(string userID)
        {
            GlobalUserID = userID;
        }
    }
}
