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
    public class ParkingLotDAL
    {
        private static ParkingLotDAL instance;
        public static ParkingLotDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ParkingLotDAL();
                }
                return ParkingLotDAL.instance;
            }
            private set { ParkingLotDAL.instance = value; }
        }

        //Kiểm tra chỗ trống
        public bool checkSlot(string ID, string Type)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM VEHICLE WHERE VehID = @Id and VehType = @Type", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@Id", SqlDbType.NVarChar).Value = ID;
            cmd.Parameters.Add("@Type", SqlDbType.NVarChar).Value = Type;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //lấy thông tin xe
        public DataTable getVehicleInfo(string ID, string Type)
        {
            SqlCommand cmd = new SqlCommand("", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@Id", SqlDbType.NVarChar).Value = ID;
            cmd.Parameters.Add("@Type", SqlDbType.NVarChar).Value = Type;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getDataWithPurpose(SqlCommand cmd)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //Thêm xe
        public bool addVehicle(string ID, string Type, string LicensePlate, MemoryStream VehPic, string CusID, string Name, DateTime Bdate, string Phone, string Address, string IdentityCardNumber, MemoryStream CusPic)
        {
            SqlCommand cmd1 = new SqlCommand("INSERT INTO CUSTOMER (CusID, FullName, Bdate, PhoneNumber, Address,IdentityNumber, Appearance)" +
                "values (@CusID, @Name, @Bdate, @Phone, @Addr, @Identity, @Appear)", DataProvider.Instance.getConnection);
            cmd1.Parameters.Add("@CusID", SqlDbType.NVarChar).Value = CusID;
            cmd1.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name;
            cmd1.Parameters.Add("@Bdate", SqlDbType.Date).Value = Bdate;
            cmd1.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone;
            cmd1.Parameters.Add("@Addr", SqlDbType.NVarChar).Value = Address;
            cmd1.Parameters.Add("@Identity", SqlDbType.NVarChar).Value = IdentityCardNumber;
            cmd1.Parameters.Add("@Appear", SqlDbType.Image).Value = CusPic;
            DataProvider.Instance.openConnection();
            if (cmd1.ExecuteNonQuery() != 1)
            {
                DataProvider.Instance.closeConnection();
                return false;
            }
            DataProvider.Instance.closeConnection();

            SqlCommand cmd2 = new SqlCommand("INSERT INTO VEHICLE (VehID, VehType, LicensePlate, Picture, CusID)" +
                "values (@VehID, @Type, @License, @Pic, @CusID)", DataProvider.Instance.getConnection);
            cmd2.Parameters.Add("@VehID", SqlDbType.NVarChar).Value = ID;
            cmd2.Parameters.Add("@Type", SqlDbType.NVarChar).Value = Type;
            cmd2.Parameters.Add("@License", SqlDbType.NVarChar).Value = LicensePlate;
            cmd2.Parameters.Add("@Pic", SqlDbType.Image).Value = VehPic;
            cmd2.Parameters.Add("@CusID", SqlDbType.NVarChar).Value = CusID;
            DataProvider.Instance.openConnection();
            if (cmd2.ExecuteNonQuery() == 1)
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

        //Cập nhật xe
        public bool updateVehicle(string ID, string Type, string LicensePlate, MemoryStream VehPic, string CusID, string Name, string Bdate, string Phone, string Address, string IdentityCardNumber, MemoryStream CusPic)
        {
            SqlCommand cmd1 = new SqlCommand("UPDATE CUSTOMER SET FullName = @Name, Bdate = @Bdate, PhoneNumber = @Phone, Address = @Addr" +
                ", IdentityNumber = @Identity, Appearance = @Appear WHERE CusID = @CusID)", DataProvider.Instance.getConnection);
            cmd1.Parameters.Add("@CusID", SqlDbType.NVarChar).Value = CusID;
            cmd1.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name;
            cmd1.Parameters.Add("@Bdate", SqlDbType.Date).Value = Bdate;
            cmd1.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone;
            cmd1.Parameters.Add("@Addr", SqlDbType.NVarChar).Value = Address;
            cmd1.Parameters.Add("@Identity", SqlDbType.NVarChar).Value = IdentityCardNumber;
            cmd1.Parameters.Add("@Appear", SqlDbType.Image).Value = CusPic;
            DataProvider.Instance.openConnection();
            if (cmd1.ExecuteNonQuery() != 1)
            {
                DataProvider.Instance.closeConnection();
                return false;
            }
            DataProvider.Instance.closeConnection();

            SqlCommand cmd2 = new SqlCommand("UPDATE VEHICLE SET VehType = @Type, LicensePlate = @License, Picture = @Pic, CusID = @CusID WHERE VehID = @VehID", DataProvider.Instance.getConnection);
            cmd2.Parameters.Add("@VehID", SqlDbType.NVarChar).Value = ID;
            cmd2.Parameters.Add("@Type", SqlDbType.NVarChar).Value = Type;
            cmd2.Parameters.Add("@License", SqlDbType.Date).Value = LicensePlate;
            cmd2.Parameters.Add("@Pic", SqlDbType.NVarChar).Value = VehPic;
            cmd2.Parameters.Add("@CusID", SqlDbType.NVarChar).Value = CusID;
            DataProvider.Instance.openConnection();
            if (cmd2.ExecuteNonQuery() == 1)
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

        //Xóa xe
        public bool updateVehicle(string ID, string CusID)
        {
            SqlCommand cmd1 = new SqlCommand("DELETE * FROM VEHICLE WHERE VehID = @VehID", DataProvider.Instance.getConnection);
            cmd1.Parameters.Add("@VehID", SqlDbType.NVarChar).Value = ID;
            DataProvider.Instance.openConnection();
            if (cmd1.ExecuteNonQuery() != 1)
            {
                DataProvider.Instance.closeConnection();
                return false;
            }
            DataProvider.Instance.closeConnection();

            SqlCommand cmd2 = new SqlCommand("DELETE * FROM CUSTOMER WHERE CusID = @CusID", DataProvider.Instance.getConnection);
            cmd2.Parameters.Add("@CusID", SqlDbType.NVarChar).Value = ID;
            DataProvider.Instance.openConnection();
            if (cmd2.ExecuteNonQuery() == 1)
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
    }
}
