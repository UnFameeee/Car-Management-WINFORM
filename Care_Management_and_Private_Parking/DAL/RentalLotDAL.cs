using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
//3 layers
using DAL;
using Global;

namespace DAL
{
    public class RentalLotDAL
    {
        private static RentalLotDAL instance;
        public static RentalLotDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RentalLotDAL();
                }
                return RentalLotDAL.instance;
            }
            private set { RentalLotDAL.instance = value; }
        }

        #region Các hàm lấy thông tin
        //câu lệnh theo yêu cầu
        public DataTable getDataWithPurpose(SqlCommand cmd)
        {
            cmd.Connection = DataProvider.Instance.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        //lấy thông tin xe
        public DataTable getVehicleInfo(string id)
        {
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM VEHICLE WHERE VehID = @VehID", DataProvider.Instance.getConnection);
            cmd1.Parameters.Add("@VehID", SqlDbType.NVarChar).Value = id;
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
            DataTable table1 = new DataTable();
            adapter1.Fill(table1);
            if (table1.Rows[0]["CusID"] == DBNull.Value)
            {
                return table1;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("SELECT VehID, VehType, LicensePlate, Picture, VEHICLE.CusID, FullName, Bdate, PhoneNumber, Address, IdentityNumber, Appearance " +
                "FROM VEHICLE, CUSTOMER WHERE VEHICLE.CusID = CUSTOMER.CusID and VEHICLE.VehID = '" + id + "'", DataProvider.Instance.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
        #endregion

        #region Kiểm tra
        //Kiểm tra chỗ trống
        public bool checkSlot(string ID)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM VEHICLE WHERE VehID = @Id", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@Id", SqlDbType.NVarChar).Value = ID;
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
        #endregion

        #region Thêm xóa sửa
        public bool addRentalVehicle(string ID, string Type, string LicensePlate, MemoryStream VehPic)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO VEHICLE (VehID, VehType, LicensePlate, Picture, CusID)" +
                "values (@VehID, @Type, @License, @Pic, null)", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@VehID", SqlDbType.NVarChar).Value = ID;
            cmd.Parameters.Add("@Type", SqlDbType.NVarChar).Value = Type;
            cmd.Parameters.Add("@License", SqlDbType.NVarChar).Value = LicensePlate;
            cmd.Parameters.Add("@Pic", SqlDbType.Image).Value = VehPic.ToArray();

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


        public bool updateRentalVehicle(string ID, string Type, string LicensePlate, MemoryStream VehPic)
        {
            SqlCommand cmd = new SqlCommand("UPDATE VEHICLE SET VehType = @Type, LicensePlate = @License, Picture = @Pic, CusID = null WHERE VehID = @VehID", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@VehID", SqlDbType.NVarChar).Value = ID;
            cmd.Parameters.Add("@Type", SqlDbType.NVarChar).Value = Type;
            cmd.Parameters.Add("@License", SqlDbType.NVarChar).Value = LicensePlate;
            cmd.Parameters.Add("@Pic", SqlDbType.Image).Value = VehPic.ToArray();
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
        #endregion
    }
}
