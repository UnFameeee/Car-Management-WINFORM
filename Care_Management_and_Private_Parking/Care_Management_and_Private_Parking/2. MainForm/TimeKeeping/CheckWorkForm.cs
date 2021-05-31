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

        private void CheckWorkForm_Load(object sender, EventArgs e)
        {
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

        #region Phần hình ảnh nhân viên đang làm trong ca
        void loadPicEmpWorking()
        {
            DataTable table = TimeKeepingDAL.Instance.takeEmpWorking();
            DataTable tableInfo = new DataTable();
            Employee us = new Employee();

            for (int i = 0, length = table.Rows.Count; i < length; ++i)
            {
                tableInfo = TimeKeepingDAL.Instance.takePic(table.Rows[i][0].ToString());
                if(tableInfo.Rows[0][0] != DBNull.Value)
                {
                    byte[] pic = (byte[])tableInfo.Rows[0][0];
                    MemoryStream Picture = new MemoryStream(pic);
                    us.pic.Image = Image.FromStream(Picture);
                }
                us.lb.Text = tableInfo.Rows[0][1].ToString();
                fpnlMain.Controls.Add(us);
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
                    //1 là checkin thành công, 2 là đã trễ giờ đi làm, 3 là chưa tới giờ đi làm
                    if(TimeKeepingDAL.Instance.checkInTimeWork(tbID.Text) == "1")
                    {
                        MessageBox.Show("Checkin successfully!!!");

                        TimeKeepingDAL.Instance.AddCheckIn(tbID.Text, DateTime.Now);
                        dgv.DataSource = TimeKeepingDAL.Instance.ShowTimeKeeping();

                        //Phần hình ảnh
                        DataTable table = TimeKeepingDAL.Instance.takePic(tbID.Text);
                        Employee us = new Employee();

                        us.lb.Text = table.Rows[0][1].ToString();
                        us.ID = tbID.Text;
                        if (table.Rows[0]["Appearance"] != DBNull.Value)
                        {
                            byte[] picture = (byte[])table.Rows[0][0];
                            MemoryStream Picture = new MemoryStream(picture);
                            us.pic.Image = Image.FromStream(Picture);
                        }
                        fpnlMain.Controls.Add(us);

                        changeLBcheckin("Checkin");
                        loadInfo(tbID.Text, "Load");
                    }
                    else if(TimeKeepingDAL.Instance.checkInTimeWork(tbID.Text) == "2")
                    {
                        MessageBox.Show("Your shift hasn't started yet!!!");
                    }
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
                #region Tính lương
                //Phần thời gian làm việc của ca đó
                TimeSpan hourwork = (TimeSpan)DateTime.Now.TimeOfDay - TimeKeepingDAL.Instance.takeTimeStart(tbID.Text);
                if (hourwork < TimeSpan.Parse("00:00:00"))              //nếu trừ ra tgian bị âm
                    hourwork += TimeSpan.Parse("23:59:59");
                float worktime = (float)hourwork.TotalHours;            //Đổi ra thành float
                //Phần tính lương (lương của đúng ca làm việc đó)
                float salary = (float)(hourwork.TotalHours * TimeKeepingDAL.Instance.takeCoefficient(tbID.Text));
                //Tính lương
                if (!TimeKeepingDAL.Instance.checkSalaryExist(tbID.Text, DateTime.Now.Month, DateTime.Now.Year))                        //Nếu chưa có trong SALARY
                {
                    TimeKeepingDAL.Instance.insertEmpToSalary(tbID.Text, DateTime.Now.Month, DateTime.Now.Year, worktime, salary);      //Insert thẳng vào SALARY
                }
                else                                                                                                                    //Nếu đã có trong SALARY
                {
                    TimeKeepingDAL.Instance.editEmpToSalary(tbID.Text, DateTime.Now.Month, DateTime.Now.Year, worktime, salary);
                }
                #endregion

                DateTime now = DateTime.Now;

                TimeKeepingDAL.Instance.AddCheckOut(tbID.Text, now);
                dgv.DataSource = TimeKeepingDAL.Instance.ShowTimeKeeping();
                MessageBox.Show("Checkout successfully!!!");


                foreach(Employee c in fpnlMain.Controls)
                { 
                    if(c.ID == (tbID.Text))
                    {
                        fpnlMain.Controls.Remove(c);
                    }
                }

                changeLBcheckin("Checkout");
                loadInfo(tbID.Text, "Unload");
            }
            else
                MessageBox.Show("Can't find the ID");
        }
        #endregion
    }
}
