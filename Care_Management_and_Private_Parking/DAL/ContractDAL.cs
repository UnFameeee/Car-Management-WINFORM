using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ContractDAL
    {
        private static ContractDAL instance;
        public static ContractDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ContractDAL();
                }
                return ContractDAL.instance;
            }
            private set { ContractDAL.instance = value; }
        }

        #region Thêm xóa sửa hợp đồng
        public bool insertContract(string ContID, string CusID, string EmpID, string Purpose, string VehID, DateTime DateStart, DateTime DateEnd, int Price)
        {
            SqlCommand command = new SqlCommand("Insert into CONTRACT (ContID, CusID, EmpID, Purpose, VehID, DateStart, DateEnd, Price)" +
                "values (@contid, @cusid, @empid, @pp, @vehid, @dstart, @dend, @price)", DataProvider.Instance.getConnection);
            command.Parameters.Add("@contid", SqlDbType.NVarChar).Value = ContID;
            command.Parameters.Add("@cusid", SqlDbType.NVarChar).Value = CusID;
            command.Parameters.Add("@empid", SqlDbType.NVarChar).Value = EmpID;
            command.Parameters.Add("@pp", SqlDbType.NVarChar).Value = Purpose;
            command.Parameters.Add("@vehid", SqlDbType.NVarChar).Value = VehID;
            command.Parameters.Add("@dstart", SqlDbType.Date).Value = DateStart;
            command.Parameters.Add("@dend", SqlDbType.Date).Value = DateEnd;
            command.Parameters.Add("@price", SqlDbType.Int).Value = Price;

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
        public bool removeContract(string ContID)
        {
            SqlCommand cmd = new SqlCommand("Delete From CONTRACT Where ContID = @contid", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@contid", SqlDbType.NVarChar).Value = ContID;

            DataProvider.Instance.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
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

        public bool updateContract(string ContID, string CusID, string EmpID, string Purpose, string VehID, DateTime DateStart, DateTime DateEnd, int Price)
        {
            SqlCommand command = new SqlCommand("Update CONTRACT set CusID = @cusid, EmpID = @empid, Purpose = @pp, VehID = @vehid " +
                "DateStart = @dstart, DateEnd = @dend, Price = @price where ContID = @contid", DataProvider.Instance.getConnection);
            command.Parameters.Add("@contid", SqlDbType.NVarChar).Value = ContID;
            command.Parameters.Add("@cusid", SqlDbType.NVarChar).Value = CusID;
            command.Parameters.Add("@empid", SqlDbType.NVarChar).Value = EmpID;
            command.Parameters.Add("@pp", SqlDbType.NVarChar).Value = Purpose;
            command.Parameters.Add("@vehid", SqlDbType.NVarChar).Value = VehID;
            command.Parameters.Add("@dstart", SqlDbType.DateTime).Value = DateStart;
            command.Parameters.Add("@dend", SqlDbType.DateTime).Value = DateEnd;
            command.Parameters.Add("@price", SqlDbType.Int).Value = Price;

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
        public bool checkContract(string ContID)
        {
            SqlCommand com = new SqlCommand("Select * from CONTRACT where ContID = @contid", DataProvider.Instance.getConnection);
            com.Parameters.Add("@contid", SqlDbType.NVarChar).Value = ContID;

            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count == 0)
                return true;
            else return false;
        }

        #region Phần ContractList
        public DataTable ShowContract()
        {
            SqlCommand com = new SqlCommand("SELECT ContID as ContractID, EmpID as EmployeeID, Purpose, CusID as CustomerID, A.VehID as VehicleID, VehType as VehicleType, DateStart, DateEnd, Price " +
                " FROM(SELECT VehID, VehType FROM VEHICLE) as A, CONTRACT" +
                " WHERE A.VehID = CONTRACT.VehID", DataProvider.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        #region combobox
        public DataTable ShowEmpID()
        {
            SqlCommand com = new SqlCommand("SELECT EmpID FROM EMPLOYEE", DataProvider.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable ShowCusID()
        {
            SqlCommand com = new SqlCommand("SELECT CusID FROM CONTRACT", DataProvider.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable ShowVehID()
        {
            SqlCommand com = new SqlCommand("SELECT VehID FROM CONTRACT", DataProvider.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        #endregion

        #region nút find
        //1 giá trị
        public DataTable ShowCusIDContract(string CusID)
        {
            SqlCommand com = new SqlCommand("SELECT ContID as ContractID, EmpID as EmployeeID, Purpose, CusID as CustomerID, A.VehID as VehicleID, VehType as VehicleType, DateStart, DateEnd, Price " +
                " FROM(SELECT VehID, VehType FROM VEHICLE) as A, CONTRACT" +
                " WHERE A.VehID = CONTRACT.VehID and CusID = @CusID", DataProvider.Instance.getConnection);
            com.Parameters.Add("@CusID", SqlDbType.NVarChar).Value = CusID;
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable ShowVehIDContract(string VehID)
        {
            SqlCommand com = new SqlCommand("SELECT ContID as ContractID, EmpID as EmployeeID, Purpose, CusID as CustomerID, A.VehID as VehicleID, VehType as VehicleType, DateStart, DateEnd, Price " +
                " FROM(SELECT VehID, VehType FROM VEHICLE) as A, CONTRACT" +
                " WHERE A.VehID = CONTRACT.VehID and VehID = @VehID", DataProvider.Instance.getConnection);
            com.Parameters.Add("@VehID", SqlDbType.NVarChar).Value = VehID;
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable ShowEmpIDContract(string EmpID)
        {
            SqlCommand com = new SqlCommand("SELECT ContID as ContractID, EmpID as EmployeeID, Purpose, CusID as CustomerID, A.VehID as VehicleID, VehType as VehicleType, DateStart, DateEnd, Price " +
                " FROM(SELECT VehID, VehType FROM VEHICLE) as A, CONTRACT" +
                " WHERE A.VehID = CONTRACT.VehID and EmpID = @EmpID", DataProvider.Instance.getConnection);
            com.Parameters.Add("@EmpID", SqlDbType.NVarChar).Value = EmpID;
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //2 giá trị
        public DataTable ShowCusIDVehIDContract(string CusID,string VehID)
        {
            SqlCommand com = new SqlCommand("SELECT ContID as ContractID, EmpID as EmployeeID, Purpose, CusID as CustomerID, A.VehID as VehicleID, VehType as VehicleType, DateStart, DateEnd, Price " +
                " FROM(SELECT VehID, VehType FROM VEHICLE) as A, CONTRACT" +
                " WHERE A.VehID = CONTRACT.VehID and CusID = @CusID and VehID = @VehID", DataProvider.Instance.getConnection);
            com.Parameters.Add("@CusID", SqlDbType.NVarChar).Value = CusID;
            com.Parameters.Add("@VehID", SqlDbType.NVarChar).Value = VehID;
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable ShowVehIDEmpIDContract(string VehID, string EmpID)
        {
            SqlCommand com = new SqlCommand("SELECT ContID as ContractID, EmpID as EmployeeID, Purpose, CusID as CustomerID, A.VehID as VehicleID, VehType as VehicleType, DateStart, DateEnd, Price " +
                " FROM(SELECT VehID, VehType FROM VEHICLE) as A, CONTRACT" +
                " WHERE A.VehID = CONTRACT.VehID and VehID = @VehID and EmpID = @EmpID", DataProvider.Instance.getConnection);
            com.Parameters.Add("@VehID", SqlDbType.NVarChar).Value = VehID;
            com.Parameters.Add("@EmpID", SqlDbType.NVarChar).Value = EmpID;
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable ShowEmpIDCusIDContract(string EmpID, string CusID)
        {
            SqlCommand com = new SqlCommand("SELECT ContID as ContractID, EmpID as EmployeeID, Purpose, CusID as CustomerID, A.VehID as VehicleID, VehType as VehicleType, DateStart, DateEnd, Price " +
                " FROM(SELECT VehID, VehType FROM VEHICLE) as A, CONTRACT" +
                " WHERE A.VehID = CONTRACT.VehID and EmpID = @EmpID and CusID = @CusID", DataProvider.Instance.getConnection);
            com.Parameters.Add("@EmpID", SqlDbType.NVarChar).Value = EmpID;
            com.Parameters.Add("@CusID", SqlDbType.NVarChar).Value = CusID;
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //cả 3 giá trị
        public DataTable ShowAllFindContract(string EmpID, string VehID, string CusID)
        {
            SqlCommand com = new SqlCommand("SELECT ContID as ContractID, EmpID as EmployeeID, Purpose, CusID as CustomerID, A.VehID as VehicleID, VehType as VehicleType, DateStart, DateEnd, Price " +
                " FROM(SELECT VehID, VehType FROM VEHICLE) as A, CONTRACT" +
                " WHERE A.VehID = CONTRACT.VehID and EmpID = @EmpID and CusID = @CusID and VehID = @VehID", DataProvider.Instance.getConnection);
            com.Parameters.Add("@EmpID", SqlDbType.NVarChar).Value = EmpID;
            com.Parameters.Add("@CusID", SqlDbType.NVarChar).Value = CusID;
            com.Parameters.Add("@VehID", SqlDbType.NVarChar).Value = VehID;
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        #endregion

        #endregion

    }
}
