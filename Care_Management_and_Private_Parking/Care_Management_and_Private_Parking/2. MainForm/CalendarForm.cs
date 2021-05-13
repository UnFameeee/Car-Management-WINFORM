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

namespace Care_Management_and_Private_Parking
{
    public partial class CalendarForm : Form
    {
        //Load form
        public CalendarForm()
        {
            InitializeComponent();
            fillTaskFlowPanel();                                                        //Cấu hình cho Task
            fillProgressBar();                                                          //Cấu hình cho thanh ProgressBar
            fillChart();                                                                //Cấu hình cho chart
        }
        CalendarDOWForm frm = new CalendarDOWForm() { TopLevel = false, TopMost = true };
        private void CalendarForm_Load(object sender, EventArgs e)
        {
            //Set vị trí cho cái lịch ở giữa
            frm.Location = new Point(pnCalendar.Size.Width / 2 - frm.ClientSize.Width / 2, pnCalendar.Size.Height / 2 - frm.ClientSize.Height / 2 + 10);
            this.pnCalendar.Controls.Add(frm);
            frm.Show();
        }


        //Load chart
        void fillTaskFlowPanel()                                                        //Cấu hình cho flow panel  
        {
            //fpn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;           //Viền
            fpn.TabIndex = 4;                                                           
            fpn.AutoScroll = true;                                                      
            fpn.VerticalScroll.Visible = true;                                          //Hiện thanh cuộn dọc
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            Task t = new Task();
            fpn.Controls.Add(t);                                                        //Thêm task vào
        }   

        //Đổ dữ liêu vào progress bar
        public void fillProgressBar()
        {
            float dayworktillnow = 0;                                                   //Ngày làm việc đến này hôm nay
            DateTime dt = DateTime.Now;
            //DateTime dt = new DateTime(2021, 5, 30);
            DateTime useDate = new DateTime(dt.Year, dt.Month, 1);                      //Ngày đầu tiên trong tháng
            int today = dt.Day, line = 0;                                               //Lấy ra số ngày của ngày hôm nay. Line dùng để sử dụng trong Matrix
            for(int total = 1; total <= today;)                                         
            {
                int column = frm.dayOfWeek.IndexOf(useDate.DayOfWeek.ToString());       //Cột NGÀY ĐẦU TIÊN trong tháng
                Guna2Button btn = frm.Matrix[line][column];                             
                if(btn.ForeColor != Color.White)                                        //Nếu Text của ngày đó màu tráng thì  đi làm
                {
                    dayworktillnow++;                                                   //Ngày làm tính tới hiện tại++
                }
                total++;
                if (total >= today)                                                     //Khi xét tới ngày hôm nay thì dừng
                   break;
                useDate = useDate.AddDays(1);                                           //Thêm 1 ngày vào useDate
                if(column >= 6)
                    line++;
            }
            int percent = Convert.ToInt32((dayworktillnow / frm.totalDayOfWork) * 100); //Tính số %ngày đã đi làm gán nó vào progress bar
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

        //Đổ dữ liệu vào Chart
        public void fillChart()
        {
            chartWork.Series["Days"].Points.AddXY("Mor", frm.ShiftInMonth[0]);
            chartWork.Series["Days"].Points.AddXY("No", frm.ShiftInMonth[1]);
            chartWork.Series["Days"].Points.AddXY("Eve", frm.ShiftInMonth[2]);
            chartWork.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.White;
            chartWork.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.White;
        }
    }
}
