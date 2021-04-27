using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care_Management_and_Private_Parking
{
    class Employee
    {
        MY_DB db = new MY_DB();
        public bool insertEmployee(string EmpID, string FullName, string Gender, string PhoneNumber, string IdentityCardNumber, string JobID)
        {
            SqlCommand command = new SqlCommand("Insert into EMPLOYEE (EmpID, FullName, Gender, PhoneNumber, IdentityCardNumber, JobID)" +
                "values (@EmpID, @FullName, @Gender, @Phone, @Identity, @JobID)", db.getConnection);
            command.Parameters.Add("@EmpID", SqlDbType.VarChar).Value = EmpID;
            command.Parameters.Add("@FullName", SqlDbType.VarChar).Value = FullName;
            command.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
            command.Parameters.Add("@Phone", SqlDbType.VarChar).Value = PhoneNumber;
            command.Parameters.Add("@Identity", SqlDbType.VarChar).Value = IdentityCardNumber;
            command.Parameters.Add("@JobID", SqlDbType.VarChar).Value = JobID;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        public bool removeEmployee (string EmpID)
        {
            SqlCommand cmd = new SqlCommand("Delete From EMPLOYEE Where EmpID = @EmpID", db.getConnection);
            cmd.Parameters.Add("@EmpID", SqlDbType.VarChar).Value = EmpID;
            db.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public bool updateEmployee(string EmpID, string FullName, string Gender, string PhoneNumber, string IdentityCardNumber, string JobID)
        {
            SqlCommand command = new SqlCommand("Update EMPLOYEE set FullName = @FullName, Gender = @Gender, PhoneNumber = @Phone, IdentityCardNumber = @Identity, JobID = @JobID where EmpID = @EmpID", db.getConnection);
            command.Parameters.Add("@EmpID", SqlDbType.VarChar).Value = EmpID;
            command.Parameters.Add("@FullName", SqlDbType.VarChar).Value = FullName;
            command.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
            command.Parameters.Add("@Phone", SqlDbType.VarChar).Value = PhoneNumber;
            command.Parameters.Add("@Identity", SqlDbType.VarChar).Value = IdentityCardNumber;
            command.Parameters.Add("@JobID", SqlDbType.VarChar).Value = JobID;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public bool checkEmp(string EmpID)
        {
            SqlCommand com = new SqlCommand("Select * from EMPLOYEE where EmpID = @EmpID", db.getConnection);
            com.Parameters.Add("@EmpID", SqlDbType.VarChar).Value = EmpID;

            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count == 0)
                return true;
            else return false;
        }

        public DataTable getEmployee(SqlCommand command)
        {
            command.Connection = db.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getAllEmp()
        {
            SqlCommand command = new SqlCommand("Select * from EMPLOYEE", db.getConnection);
            return getEmployee(command);
        }
    }
}
