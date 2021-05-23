using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.IO;
//3 layers
using Global;
using DAL;


namespace Care_Management_and_Private_Parking
{
    public partial class CalendarForm : Form
    {
        //Load form
        public CalendarForm()
        {
            InitializeComponent(); 
        }

        CalendarDOWForm frm = new CalendarDOWForm() { TopLevel = false, TopMost = false };

        #region Lịch
        private void CalendarForm_Load(object sender, EventArgs e)
        {
            //Set vị trí cho cái lịch ở giữa
            frm.Location = new Point(pnCalendar.Size.Width / 2 - frm.ClientSize.Width / 2, pnCalendar.Size.Height / 2 - frm.ClientSize.Height / 2 + 10);
            this.pnCalendar.Controls.Add(frm);
            frm.Show();

            fillTaskFlowPanel();                                                        //Cấu hình cho Task
            fillProgressBar();                                                          //Cấu hình cho thanh ProgressBar
            fillChart();                                                                //Cấu hình cho chart
            loadInfo();
        }
        #endregion

        bool verif()
        {
            if (tbName.Text.Trim() == ""
                || tbPhone.Text.Trim() == ""
                || tbIdentity.Text.Trim() == "")
                return false;
            else return true;
        }

        #region Thông tin cá nhân

        void loadInfo()
        {
            DataTable table = MyInfoDAL.Instance.takeInfo(UserID.GlobalUserID);
            tbName.Text = table.Rows[0]["Fullname"].ToString();
            rbMale.Checked = true;
            if (table.Rows[0]["Gender"].ToString() == "Female")
            {
                rbFemale.Checked = true;
            }
            dateTime.Text = table.Rows[0]["Birthday"].ToString();
            tbPhone.Text = table.Rows[0]["PhoneNumber"].ToString();
            tbIdentity.Text = table.Rows[0]["IdentityNumber"].ToString();
            tbEmail.Text = table.Rows[0]["Email"].ToString();

            lbName.Text = table.Rows[0]["Fullname"].ToString();
            if (table.Rows[0]["JobID"].ToString() == "1")
            {
                lbPosition.Text = "Position: Manager";
            }
            else if (table.Rows[0]["JobID"].ToString() == "2")
            {
                lbPosition.Text = "Position: Employee";
            }
            else if (table.Rows[0]["JobID"].ToString() == "3")
            {
                lbPosition.Text = "Position: Officer";
            }
            if (table.Rows[0]["Appearance"] != DBNull.Value)
            {
                byte[] picture = (byte[])table.Rows[0]["Appearance"];
                MemoryStream Picture = new MemoryStream(picture);
                pic.Image = Image.FromStream(Picture);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string gender = "Male";
            if (rbFemale.Checked == true)
            {
                gender = "Female";
            }
            try
            {
                if (verif())
                {
                    if (MyInfoDAL.Instance.editMyInfo(UserID.GlobalUserID, tbName.Text, gender, dateTime.Value, tbPhone.Text, tbIdentity.Text, tbEmail.Text))
                    {
                        MessageBox.Show("Edit Information Successfully!!", "Edit Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Edit Information Unsuccessfully!!", "Edit Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all the information!!!", "Edit Infomation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadInfo();
        }
        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked == false)
            {
                rbFemale.Checked = true;
            }
            else
            {
                rbFemale.Checked = false;
            }
        }
        #endregion

        #region Lương

        #endregion

        #region Load chart - Task
        void fillTaskFlowPanel()                                                                            //Cấu hình cho flow panel  
        {
            //fpn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;                               //Viền
            fpn.TabIndex = 4;                                                           
            fpn.AutoScroll = true;                                                      
            fpn.VerticalScroll.Visible = true;                                                              //Hiện thanh cuộn dọc
        }
        //Đổ dữ liệu vào Chart
        public void fillChart()
        {
            chartWork.Series["Days"].Points.AddXY("Mor", frm.ShiftInMonth[0]);
            chartWork.Series["Days"].Points.AddXY("No", frm.ShiftInMonth[1]);
            chartWork.Series["Days"].Points.AddXY("Eve", frm.ShiftInMonth[2]);
            chartWork.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.White;
            chartWork.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.White;
        }
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            Task t = new Task();
            fpn.Controls.Add(t);                                                                            //Thêm task vào
        }
        #endregion

        #region Đổ dữ liêu vào progress bar
        public void fillProgressBar()
        {
            float dayworktillnow = 0;                                                                       //Ngày làm việc đến này hôm nay
            DateTime dt = DateTime.Now;
            //DateTime dt = new DateTime(2021, 5, 30);
            DateTime useDate = new DateTime(dt.Year, dt.Month, 1);                                          //Ngày đầu tiên trong tháng
            int today = dt.Day, line = 0;                                                                   //Lấy ra số ngày của ngày hôm nay. Line dùng để sử dụng trong Matrix
            for(int total = 1; total <= today;)                                         
            {
                int column = frm.dayOfWeek.IndexOf(useDate.DayOfWeek.ToString());                           //Cột NGÀY ĐẦU TIÊN trong tháng
                Guna2Button btn = frm.Matrix[line][column];                             
                if(btn.ForeColor != Color.White)                                                             //Nếu Text của ngày đó màu tráng thì  đi làm
                {
                    dayworktillnow++;                                                                        //Ngày làm tính tới hiện tại++
                }
                total++;
                if (total >= today)                                                                          //Khi xét tới ngày hôm nay thì dừng
                   break;
                useDate = useDate.AddDays(1);                                                                //Thêm 1 ngày vào useDate
                if(column >= 6)
                    line++;
            }
            int percent = Convert.ToInt32((dayworktillnow / frm.totalDayOfWork) * 100);                     //Tính số %ngày đã đi làm gán nó vào progress bar
            progressBar.Value = percent;
            if (percent == 0)
                lbProgressBar.Text = "You haven't worked any day till now!!!";
            else if (percent > 0 && percent <= 30)
                lbProgressBar.Text = "You need to work harder!!!";
            else if (percent > 30 && percent <= 50)
                lbProgressBar.Text = "You have worked fine this month, fighting!!!";
            else if (percent > 50 && percent <= 70)
                lbProgressBar.Text = "You have worked well this month, congrats!!!";
            else
                lbProgressBar.Text = "You have worked very hard this month, congrats!!!";
        }

        #endregion

        
    }
}
