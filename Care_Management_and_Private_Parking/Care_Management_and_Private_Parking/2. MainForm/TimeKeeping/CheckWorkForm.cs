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
//3 layers
using Global;
using DAL;

namespace Care_Management_and_Private_Parking
{
    public partial class CheckWorkForm : Form
    {
        public CheckWorkForm()
        {
            InitializeComponent();
        }

        #region Properties
        private List<PictureBox> matrixPic;
        public List<PictureBox> MatrixPic
        {
            get { return matrixPic; }
            set { matrixPic = value; }
        }

        private List<Label> matrixName;
        public List<Label> MatrixName
        {
            get { return matrixName; }
            set { matrixName = value; }
        }
        public int count = 0; //Số nhân viên đang trong ca
        List<string> MatrixEmpID = new List<string>();
        #endregion

        private void CheckWorkForm_Load(object sender, EventArgs e)
        {
            MatrixPic = new List<PictureBox>();      //Hình 
            MatrixName = new List<Label>();          //Tên

            MatrixPic.Add(pic1); MatrixPic.Add(pic2); MatrixPic.Add(pic3); MatrixPic.Add(pic4); MatrixPic.Add(pic5); MatrixPic.Add(pic6);
            MatrixPic.Add(pic7); MatrixPic.Add(pic8); MatrixPic.Add(pic9); MatrixPic.Add(pic10); MatrixPic.Add(pic11); MatrixPic.Add(pic11);

            MatrixName.Add(lb1); MatrixName.Add(lb2); MatrixName.Add(lb3); MatrixName.Add(lb4); MatrixName.Add(lb5); MatrixName.Add(lb6);
            MatrixName.Add(lb7); MatrixName.Add(lb8); MatrixName.Add(lb9); MatrixName.Add(lb10); MatrixName.Add(lb11); MatrixName.Add(lb12);


            for (int i = 0; i < Variable.picSlot; ++i)
                MatrixName[i].Visible = false;
            for (int j = 0; j < Variable.picSlot; ++j)
                MatrixEmpID.Add("");
            loadPicEmpWorking();

            dgv.DataSource = TimeKeepingDAL.Instance.ShowTimeKeeping();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToResizeColumns = false;
        }

        #region Phần báo cáo điểm danh
        void changeLBcheckin(string operation)
        {
            if (operation == "Checkin")
            {
                lbCheckin.Text = "You have just checkin. Have a nice day at work!!!";
            }
            else if (operation == "Checkout")
            {
                lbCheckin.Text = "You have just checkout. Have a nice day at home!!!";
            }
        }
        #endregion

        #region Phần hình ảnh đang làm trong ca
        void takePicture(string EmpID)
        {
            if (count >= 0 && count <= Variable.picSlot)
            {
                DataTable table = TimeKeepingDAL.Instance.takePic(EmpID);
                //Phần hình
                if(table.Rows[0]["Appearance"] != DBNull.Value)
                {
                    byte[] pic = (byte[])table.Rows[0][0];
                    MemoryStream Picture = new MemoryStream(pic);
                    MatrixPic[count].Image = Image.FromStream(Picture);
                }
                //Phần tên
                MatrixName[count].Text = table.Rows[0][1].ToString();
                MatrixName[count].Visible = true;
                //Phần mã nhân viên
                MatrixEmpID[count] = EmpID;
                count++;
            }
        }

        void deletePicture(string EmpID)
        {
            for (int i = 0; i < 7; ++i)
            {
                if (EmpID == MatrixEmpID[i])
                {
                    MatrixPic[i].Image = null;
                    MatrixName[i].Text = "";
                    MatrixName[i].Visible = false;
                    MatrixEmpID[i] = "";
                    count--;
                    break;
                }
            }
            if (count != 0)
            {
                rearrange();
            }
        }

        void rearrange()
        {
            for (int i = 0; i < count; ++i)
            {
                if (MatrixEmpID[i] == "")
                {
                    //Chức năng giống hàm swap
                    MatrixPic[i].Image = MatrixPic[i + 1].Image;
                    MatrixName[i].Text = MatrixName[i + 1].Text;
                    MatrixEmpID[i] = MatrixEmpID[i + 1];

                    MatrixPic[i + 1].Image = null;
                    MatrixName[i + 1].Text = "";
                    MatrixEmpID[i + 1] = "";


                    MatrixName[i].Visible = true;
                    MatrixName[i + 1].Visible = false;
                }
            }
        }

        void loadPicEmpWorking()
        {
            DataTable table = TimeKeepingDAL.Instance.takeEmpWorking();
            DataTable tableInfo = new DataTable();
            for (int i = 0, length = table.Rows.Count; i < length; ++i)
            {
                if (count >= 0 && count <= Variable.picSlot)
                {
                    tableInfo = TimeKeepingDAL.Instance.takePic(table.Rows[i][0].ToString());
                    if(tableInfo.Rows[0][0] != DBNull.Value)
                    {
                        byte[] pic = (byte[])tableInfo.Rows[0][0];
                        MemoryStream Picture = new MemoryStream(pic);
                        MatrixPic[count].Image = Image.FromStream(Picture);
                    }
                    //Phần tên
                    MatrixName[count].Text = tableInfo.Rows[0][1].ToString();
                    MatrixName[count].Visible = true;
                    //Phần mã nhân viên
                    MatrixEmpID[count] = table.Rows[i][0].ToString();
                    count++;
                }
            }
        }
        #endregion

        #region Phần tải thông tin nhân viên
        void loadInfo(string EmpID, string operation)
        {
            if (operation == "Load")
            {
                DataTable table = TimeKeepingDAL.Instance.takeInfoForCalendar(EmpID);
                tbInfo.Text = "Employee ID: " + table.Rows[0][0].ToString()
                            + "\r\nFull Name: " + table.Rows[0][1].ToString()
                            + "\r\nGender: " + table.Rows[0][2].ToString()
                            + "\r\nPhone: " + table.Rows[0][3].ToString()
                            + "\r\nIdentity Number: " + table.Rows[0][4].ToString();
            }
            else if (operation == "Unload")
            {
                tbInfo.Text = "Employee ID: "
                            + "\r\nFull Name: "
                            + "\r\nGender: "
                            + "\r\nPhone: "
                            + "\r\nIdentity Number: ";
            }
        }
        #endregion


        #region Điểm danh vào, ra
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (TimeKeepingDAL.Instance.CheckIDEmployee(tbID.Text))
            {
                if (!TimeKeepingDAL.Instance.CheckIDWork(tbID.Text))
                {
                    //if (DateTime.Now.TimeOfDay <= )
                    //{
                    //    
                    //}
                    //else
                    //{

                    //}
                    TimeKeepingDAL.Instance.AddCheckIn(tbID.Text, DateTime.Now);
                    dgv.DataSource = TimeKeepingDAL.Instance.ShowTimeKeeping();

                    takePicture(tbID.Text);
                    changeLBcheckin("Checkin");
                    loadInfo(tbID.Text, "Load");
                }
                else
                    MessageBox.Show("ID is working. Can't check in");
            }
            else
                MessageBox.Show("Can't find the ID");
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (TimeKeepingDAL.Instance.CheckIDWork(tbID.Text))
            {
                TimeKeepingDAL.Instance.AddCheckOut(tbID.Text, DateTime.Now);
                dgv.DataSource = TimeKeepingDAL.Instance.ShowTimeKeeping();

                deletePicture(tbID.Text);
                changeLBcheckin("Checkout");
                loadInfo(tbID.Text, "Unload");
            }
            else
                MessageBox.Show("Can't find the ID");
        }
        #endregion
    }
}
