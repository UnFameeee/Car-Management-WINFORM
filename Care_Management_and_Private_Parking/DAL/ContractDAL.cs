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
    class ContractDAL
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


        public bool insertContract(string ContID, string CusID, string EmpID, string Purpose, string Description)
        {
            SqlCommand command = new SqlCommand("Insert into CONTRACT (ContID, CusID, EmpID, Purpose, Description)" +
                "values (@contid, @cusid, @empid, @pp, @des)", DataProvider.Instance.getConnection);
            command.Parameters.Add("@contid", SqlDbType.NVarChar).Value = ContID;
            command.Parameters.Add("@cusid", SqlDbType.NVarChar).Value = CusID;
            command.Parameters.Add("@empid", SqlDbType.NVarChar).Value = EmpID;
            command.Parameters.Add("@pp", SqlDbType.NVarChar).Value = Purpose;
            command.Parameters.Add("@des", SqlDbType.Text).Value = Description;


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

        public bool updateContract(string ContID, string CusID, string EmpID, string Purpose, string Description)
        {
            SqlCommand command = new SqlCommand("Update CONTRACT set CusID = @cusid, EmpID = @empid, Purpose = @pp, Description = @des " +
                "where ContID = @contid", DataProvider.Instance.getConnection);
            command.Parameters.Add("@contid", SqlDbType.NVarChar).Value = ContID;
            command.Parameters.Add("@cusid", SqlDbType.NVarChar).Value = CusID;
            command.Parameters.Add("@empid", SqlDbType.NVarChar).Value = EmpID;
            command.Parameters.Add("@pp", SqlDbType.NVarChar).Value = Purpose;
            command.Parameters.Add("@des", SqlDbType.Text).Value = Description;

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
    }
}
