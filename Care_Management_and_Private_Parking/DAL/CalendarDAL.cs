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
        public int NV = getTotalEmp();                                      //x nhân viên
        public int CL = getTotalShift();                                    //y ca làm
        #endregion

        #region Hàm để lấy ra số lượng ca làm và nhân viên
        public static int getTotalEmp()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM EMPLOYEE", DataProvider.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table.Rows.Count;
        }
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

        public string convertToEmpID(int EmpID)                                                   //EmpID được quy định là 2 chữ cái đầu + mã số NV ở sau
        {
            string res = "NV" + EmpID.ToString();
            return res;
        }
        public DataTable tableShift()
        {
            NV = getTotalEmp();
            CL = getTotalShift();
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
                        toInsert["EmployeeID"] = convertToEmpID(i + 1);
                        toInsert["ShiftID"] = (j + 1).ToString();
                        res.Rows.Add(toInsert);                                                                           //thêm dòng datarow vào datatable
                    }
                }
            }
            return res;
        }
        #endregion
    }
}
