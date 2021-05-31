using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using DAL;
using System.Globalization;

namespace Care_Management_and_Private_Parking
{
    public partial class LostIDCard : Form
    {
        public LostIDCard()
        {
            InitializeComponent();
        }

        bool verif()
        {
            if (tbName.Text == "" || tbPhone.Text == "" || tbAddress.Text == "" || tbIdentity.Text == ""
                || cbVehType.SelectedIndex == -1 || tbLicense.Text == "")
                return true;
            else
                return false;
        }

        #region so sánh hình
        PictureBox piccus = new PictureBox();
        PictureBox picveh = new PictureBox();
        public bool CompareImages(PictureBox image1, PictureBox image2)
        {
            string img1_ref, img2_ref;
            bool flag = true;
            Bitmap bit1 = new Bitmap(image1.Image);
            Bitmap bit2 = new Bitmap(image2.Image);
            if (bit1.Width == bit2.Width && bit1.Height == bit2.Height)
            {
                for (int i = 0; i < bit1.Width; i++)
                {
                    for (int j = 0; j < bit1.Height; j++)
                    {
                        img1_ref = bit1.GetPixel(i, j).ToString();
                        img2_ref = bit2.GetPixel(i, j).ToString();
                        if (img1_ref != img2_ref)
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                if (flag == false)
                {
                    //MessageBox.Show("Sorry, Images are not same , wrong pixels found");
                    return false;
                }
                else
                {
                    //MessageBox.Show(" Images are same , same pixels found and wrong pixels found");
                    return true;
                }
                   
            }
            else
            {
                //MessageBox.Show("can not compare this images");
                return false;
            }
        }

        #endregion

        private void btnVerify_Click(object sender, EventArgs e)
        {
            DataTable tablepic = new DataTable();
            try
            {
                string name = tbName.Text;
                DateTime bdate = datetime.Value;
                string phone = tbPhone.Text;
                string addr = tbAddress.Text;
                string identity = tbIdentity.Text;

                tablepic = ParkingLotDAL.Instance.takePicCus(ParkingLotDAL.Instance.takeIDCus(name, bdate, phone, addr, identity));
                if (tablepic.Rows.Count > 0)
                {
                    byte[] pic = (byte[])tablepic.Rows[0]["Appearance"];
                    MemoryStream picture = new MemoryStream(pic);
                    piccus.Image = Image.FromStream(picture);
                    if (!CompareImages(piccus, CustomerPic))
                    {
                        MessageBox.Show("Two of customer pictures are not the same!!!", "Verify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string vehtype = cbVehType.SelectedItem.ToString();
                        string license = tbLicense.Text;

                        tablepic = ParkingLotDAL.Instance.takePicVeh(ParkingLotDAL.Instance.takeIDVeh(vehtype, license));
                        if (tablepic.Rows.Count > 0)
                        {
                            byte[] pic1 = (byte[])tablepic.Rows[0]["Picture"];
                            MemoryStream picture1 = new MemoryStream(pic1);
                            picveh.Image = Image.FromStream(picture1);
                            if (!CompareImages(picveh, VehiclePic))
                            {
                                MessageBox.Show("Two of vehicle pictures are not the same!!!", "Verify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                if (!verif())
                                {
                                    if (ParkingLotDAL.Instance.verifyVehicleAndCustomer(vehtype, license, name, bdate, phone, addr, identity))
                                    {
                                        string cusid = ParkingLotDAL.Instance.takeIDCus(name, bdate, phone, addr, identity);
                                        string vehid = ParkingLotDAL.Instance.takeIDVeh(vehtype, license);

                                        //Phần lấy ra tiền gửi xe và + thêm 100k tiền phạt
                                        SqlCommand cmd = new SqlCommand("Select * from PARKING where VehID = @VehID and CusID = @CusID", DataProvider.Instance.getConnection);
                                        cmd.Parameters.Add("@VehID", SqlDbType.NVarChar).Value = vehid;
                                        cmd.Parameters.Add("@CusID", SqlDbType.NVarChar).Value = cusid;
                                        DataTable table = ParkingLotDAL.Instance.getDataWithPurpose(cmd);

                                        DateTime register = Convert.ToDateTime(table.Rows[0][3]);
                                        int value = Convert.ToInt32(table.Rows[0][4]);
                                        string invoice = table.Rows[0][5].ToString();
                                        string service = table.Rows[0][6].ToString();

                                        if (ParkingLotDAL.Instance.deleteFromParklot(cusid, vehid))
                                            if (ParkingLotDAL.Instance.deleteVehicle(vehid))
                                                if (ParkingLotDAL.Instance.deleteCustomer(cusid))
                                                {
                                                    int money = InvoiceDAL.Instance.MoneyHaveToPay(register, DateTime.Now, value, invoice, vehtype, service);

                                                    if (InvoiceDAL.Instance.checkParkingDate(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year))
                                                    {
                                                        if (InvoiceDAL.Instance.updateParkingProfit(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year, money + 100000))
                                                        {
                                                            MessageBox.Show("Verify successfully!!!\r\nYou have to pay " + string.Format(new CultureInfo("vi-VN"), "{0:#.##0}", money + 100000) + "VNĐ", "Verify lost IDCard", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            this.DialogResult = DialogResult.OK;
                                                        }
                                                    }
                                                    else                           
                                                    {
                                                        if (InvoiceDAL.Instance.insertParkingProfit(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year, money + 100000)) 
                                                        {
                                                            MessageBox.Show("Verify successfully!!!\r\nYou have to pay " + string.Format(new CultureInfo("vi-VN"), "{0:#.##0}", money + 100000) + "VNĐ", "Verify lost IDCard", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            this.DialogResult = DialogResult.OK;
                                                        }
                                                    }
                                                }
                                    }
                                    else
                                    {
                                        MessageBox.Show("There are no CUSTOMER and VEHICLE with the information!!!", "Get Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please fill all information", "Get Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("There are no VEHICLE with the information!!!", "Get Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("There are no CUSTOMER with the information!!!", "Get Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        #region Phần hình
        private void CustomerPic_DoubleClick_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.png; *.jpg; *.gif) | *.png; *.jpg; *.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                CustomerPic.Image = Image.FromFile(opf.FileName);
            }
        }

        private void VehiclePic_DoubleClick_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.png; *.jpg; *.gif) | *.png; *.jpg; *.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                VehiclePic.Image = Image.FromFile(opf.FileName);
            }
        }
        #endregion
    }
}
