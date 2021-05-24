using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3 layers
using DAL;
using Global;

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

        //Kiểm tra xem ở đó xe có được gửi chưa


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
        public DataTable getVehicleInfo(string id, string type)
        {
            SqlCommand cmd = new SqlCommand("SELECT VehID, VehType, LicensePlate, Picture, VEHICLE.CusID, FullName, Bdate, PhoneNumber, Address, IdentityNumber, Appearance " +
            "FROM VEHICLE, CUSTOMER WHERE VEHICLE.CusID = CUSTOMER.CusID and VEHICLE.VehID = '" + type + id + "'", DataProvider.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //câu lệnh theo yêu cầu
        public DataTable getDataWithPurpose(SqlCommand cmd)
        {
            cmd.Connection = DataProvider.Instance.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        #region Xe
        //Thêm xe
        public bool addVehicle(string ID, string Type, string LicensePlate, MemoryStream VehPic, string CusID)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO VEHICLE (VehID, VehType, LicensePlate, Picture, CusID)" +
                "values (@VehID, @Type, @License, @Pic, @CusID)", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@VehID", SqlDbType.NVarChar).Value = ID;
            cmd.Parameters.Add("@Type", SqlDbType.NVarChar).Value = Type;
            cmd.Parameters.Add("@License", SqlDbType.NVarChar).Value = LicensePlate;
            cmd.Parameters.Add("@Pic", SqlDbType.Image).Value = VehPic.ToArray();
            cmd.Parameters.Add("@CusID", SqlDbType.NVarChar).Value = CusID;
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

        //Cập nhật xe
        public bool updateVehicle(string ID, string Type, string LicensePlate, MemoryStream VehPic, string CusID)
        {
            SqlCommand cmd = new SqlCommand("UPDATE VEHICLE SET VehType = @Type, LicensePlate = @License, Picture = @Pic, CusID = @CusID WHERE VehID = @VehID", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@VehID", SqlDbType.NVarChar).Value = ID;
            cmd.Parameters.Add("@Type", SqlDbType.NVarChar).Value = Type;
            cmd.Parameters.Add("@License", SqlDbType.NVarChar).Value = LicensePlate;
            cmd.Parameters.Add("@Pic", SqlDbType.Image).Value = VehPic.ToArray();
            cmd.Parameters.Add("@CusID", SqlDbType.NVarChar).Value = CusID;
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

        //Xóa xe
        public bool deleteVehicle(string ID)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM VEHICLE WHERE VehID = @VehID", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@VehID", SqlDbType.NVarChar).Value = ID;
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

        #region Khách
        public bool addCustomer(string CusID, string Name, DateTime Bdate, string Phone, string Address, string IdentityCardNumber, MemoryStream CusPic)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO CUSTOMER (CusID, FullName, Bdate, PhoneNumber, Address,IdentityNumber, Appearance)" +
                "values (@CusID, @Name, @Bdate, @Phone, @Addr, @Identity, @Appear)", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@CusID", SqlDbType.NVarChar).Value = CusID;
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name;
            cmd.Parameters.Add("@Bdate", SqlDbType.Date).Value = Bdate;
            cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone;
            cmd.Parameters.Add("@Addr", SqlDbType.NVarChar).Value = Address;
            cmd.Parameters.Add("@Identity", SqlDbType.NVarChar).Value = IdentityCardNumber;
            cmd.Parameters.Add("@Appear", SqlDbType.Image).Value = CusPic.ToArray();
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

        public bool updateCustomer(string CusID, string Name, DateTime Bdate, string Phone, string Address, string IdentityCardNumber, MemoryStream CusPic)
        {
            SqlCommand cmd = new SqlCommand("UPDATE CUSTOMER SET FullName = @Name, Bdate = @Bdate, PhoneNumber = @Phone, Address = @Addr" +
                ", IdentityNumber = @Identity, Appearance = @Appear WHERE CusID = @CusID", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@CusID", SqlDbType.NVarChar).Value = CusID;
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name;
            cmd.Parameters.Add("@Bdate", SqlDbType.Date).Value = Bdate;
            cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone;
            cmd.Parameters.Add("@Addr", SqlDbType.NVarChar).Value = Address;
            cmd.Parameters.Add("@Identity", SqlDbType.NVarChar).Value = IdentityCardNumber;
            cmd.Parameters.Add("@Appear", SqlDbType.Image).Value = CusPic.ToArray();
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

        public bool deleteCustomer(string CusID)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM CUSTOMER WHERE CusID = @CusID", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@CusID", SqlDbType.NVarChar).Value = CusID;
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

        #region Thêm, xóa, sửa xe và khách đã nhập thành công vào bãi gửi xe
        public void addCarAndCusToParklot(int IDParkCard, string CusID, string VehID, DateTime dayin, int value, string invoice, string service)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO PARKING (IDParkcard, CusID, VehID, DateRegister, TimeValue, InvoiceID, Service) VALUES " +
                "(@IDParkcard, @CusID, @VehID, @Dayin, @value, @Invoice, @Service)", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@IDParkcard", SqlDbType.Int).Value = IDParkCard;
            cmd.Parameters.Add("@CusID", SqlDbType.NVarChar).Value = CusID;
            cmd.Parameters.Add("@VehID", SqlDbType.NVarChar).Value = VehID;
            cmd.Parameters.Add("@Dayin", SqlDbType.DateTime).Value = dayin;
            cmd.Parameters.Add("@value", SqlDbType.Int).Value = value;
            cmd.Parameters.Add("@Invoice", SqlDbType.NVarChar).Value = invoice;
            cmd.Parameters.Add("@Service", SqlDbType.NVarChar).Value = service;

            DataProvider.Instance.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                DataProvider.Instance.closeConnection();
                return;
            }
            else
            {
                DataProvider.Instance.closeConnection();
                return;
            }
        }

        public void editCarAndCusToParklot(string CusID, string VehID, DateTime dayin, int value, string invoice, string service)
        {
            SqlCommand cmd = new SqlCommand("UPDATE PARKING SET DateRegister = @Dayin, TimeValue = @value, InvoiceID = @Invoice, Service = @Service WHERE CusID = @CusID and VehID = @VehID", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@CusID", SqlDbType.NVarChar).Value = CusID;
            cmd.Parameters.Add("@VehID", SqlDbType.NVarChar).Value = VehID;
            cmd.Parameters.Add("@Dayin", SqlDbType.DateTime).Value = dayin;
            cmd.Parameters.Add("@value", SqlDbType.Int).Value = value;
            cmd.Parameters.Add("@Invoice", SqlDbType.NVarChar).Value = invoice;
            cmd.Parameters.Add("@Service", SqlDbType.NVarChar).Value = service;

            DataProvider.Instance.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                DataProvider.Instance.closeConnection();
                return;
            }
            else
            {
                DataProvider.Instance.closeConnection();
                return;
            }
        }

        public bool deleteCarAndCusfromParklot(int ID)
        { 
            SqlCommand cmd = new SqlCommand("DELETE FROM PARKING WHERE IDParkcard = @IDParkcard", DataProvider.Instance.getConnection);
            cmd.Parameters.Add("@IDParkcard", SqlDbType.Int).Value = ID;
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

        #region Phát thẻ xe
        List<int> listIDCardPark = new List<int>(1000000) { 0 };
        public void loadListIDCard()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PARKING", DataProvider.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            for(int i = 0, length = table.Rows.Count; i < length; ++i)
            {
                listIDCardPark.Add(Convert.ToInt32(table.Rows[i]["IDParkcard"]));
            }
        }
        public int createIDParkCard()
        {
            int n = 0;
            bool isExists = true;
            Random _r = new Random();
            while (isExists == true)
            {
                n = _r.Next() % 1000000;
                isExists = listIDCardPark.Contains(n);
            }
            listIDCardPark.Add(n);
            return n;
        }
        #endregion

        #region Hàm lấy ID của cái cũ sau đó + thêm 1 vào ( ví dụ User1 là ID cuối cùng của bảng => trả về "2")
        public string takeID(string operation)
        {
            SqlCommand cmd = new SqlCommand();
            int stringID;
            if (operation == "cus")
            {
                cmd = new SqlCommand("SELECT * FROM CUSTOMER", DataProvider.Instance.getConnection);
                stringID = Variable.CusLength;
            }
            else
            {
                cmd = new SqlCommand("SELECT * FROM VEHICLE", DataProvider.Instance.getConnection);
                if(operation == Variable.Bicycle)
                {
                    stringID = Variable.BicycleLength;
                }
                else if(operation == Variable.Bike)
                {
                    stringID = Variable.BikeLength;
                }
                else
                {
                    stringID = Variable.CarLength;
                }
            }
                    
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            int row = table.Rows.Count;
            //Nếu không có bất cứ giá trị nào trong database
            if (row <= 0)
            {
                return "1";
            }
            //Nếu chỉ có đúng 1 giá trị trong database
            else if (row == 1)
            {
                string id = table.Rows[0][0].ToString();
                return (Convert.ToInt32(id.Remove(0, stringID)) + 1).ToString();
            }
            //Kiểm tra xem table có dữ liệu không
            else if (row > 0)
            {
                //Nếu ID đầu không phải là 1 (tức nghĩa là có thể đã có database là {1, 2, 3} nhưng bị xóa đi 1 và còn lại {2, 3}
                if (Convert.ToInt32((table.Rows[0][0].ToString()).Remove(0, stringID)) != 1)
                {
                    return "1";
                }
                else
                {
                    //Nếu bị xóa đi 1 ID nào đó giữa chừng (tức nghĩa là có thể đã có database là {1, 2, 3} nhưng bị xóa đi 2 và còn lại {1, 3}
                    for (int i = 0; i < row - 1; ++i)
                    {
                        if (Convert.ToInt32(table.Rows[i][0].ToString().Remove(0, stringID)) + 1 != Convert.ToInt32(table.Rows[i + 1][0].ToString().Remove(0, stringID)))
                            return (Convert.ToInt32(table.Rows[i][0].ToString().Remove(0, stringID)) + 1).ToString();
                    }
                }
            }
            return (Convert.ToInt32(table.Rows[row - 1][0].ToString().Remove(0, stringID)) + 1).ToString();
        }
        #endregion
    }
}
