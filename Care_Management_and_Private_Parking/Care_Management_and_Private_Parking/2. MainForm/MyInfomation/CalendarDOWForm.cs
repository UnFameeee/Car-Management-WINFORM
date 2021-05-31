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
//Thêm tính chất 3 lớp
using Global;
using DAL;

namespace Care_Management_and_Private_Parking
{
    public partial class CalendarDOWForm : Form
    {
        #region Properties
        private List<List<Guna2Button>> matrix;                                          //Khởi tạo mảng 2 chiều mang giá trị là các nút

        public List<List<Guna2Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        public List<string> dayOfWeek = new List<string>{ "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        private List<string> Month = new List<string> { "January", "February", "March", "April", "May", "June", "July", "August", "September", 
            "October", "November", "December" };
        public List<List<int>> dow;
        public List<List<int>> DOW                                                       //Day of Work -> mảng 2 chiều để lưu dữ liệu chia ca từ DivideShift
        {
            get { return dow; }
            set { dow = value; }
        }

        public List<int> ShiftInMonth = new List<int> {0,0,0};

        //Biến dùng để cho hàm CalendarForm sử dụng
        public float totalDayOfWork = 0;

        #endregion

        public CalendarDOWForm()
        {
            InitializeComponent();
            
        }
        private void CalendarDOWForm_Load(object sender, EventArgs e)
        {
            LoadMatrixDay();
            //Gắn giá trị cho biến cho form khác sử dụng
            totalDayOfWork = ShiftInMonth[0] + ShiftInMonth[1] + ShiftInMonth[2];
        }

        #region Tạo ma trận => hoàn thành lịch
        void SetDefaultDay()
        {                                       
            dateTime.Value = DateTime.Now;              //Set giá trị ngày tháng của datetimepicker thành ngày hôm nay
        }
        //Tạo ra ma trận nút 7x6 (chưa hiển thị ngày)
        void LoadMatrixDay()
        {
            Matrix = new List<List<Guna2Button>>();
            Guna2Button oldbtn = new Guna2Button() { Width = 0, Height = 0, Location = new Point(-Variable.margin, 0), FillColor = Color.FromArgb(43, 47, 51), BorderRadius = Variable.borderRadius };
            for(int i = 0; i < Variable.DayOfColumn; ++i)
            {
                Matrix.Add(new List<Guna2Button>());
                for(int j = 0; j < Variable.DayOfWeeks; ++j)
                {
                    Guna2Button btn = new Guna2Button() {Width = Variable.btnWidth, Height = Variable.btnHeight, FillColor = Color.FromArgb(43, 47, 51), BorderRadius = Variable.borderRadius };
                    btn.Location = new Point(oldbtn.Location.X + oldbtn.Width + Variable.margin, oldbtn.Location.Y);
                    pnlMatrixDay.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    oldbtn = btn;
                }
                oldbtn = new Guna2Button() { Width = 0, Height = 0, Location = new Point(-Variable.margin, oldbtn.Location.Y + Variable.btnHeight + Variable.margin), FillColor = Color.FromArgb(43, 47, 51), BorderRadius = Variable.borderRadius };
            }
            SetDefaultDay();
        }

        int DayOfMonth(DateTime date)
        {
            switch(date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30;
            }
        }                                                                                   //Trả về số ngày tương ứng với tháng
        bool IsEqualDay(DateTime dateA, DateTime dateB)
        {
            return dateA.Day == dateB.Day && dateA.Month == dateB.Month && dateA.Year == dateB.Year;
        }
        //Thêm ngày vào nút
        void AddNumberIntoMatrixDay(DateTime date)                                          //Thêm ngày vào ma trận các nút (ngày)
        {
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);                      //Trả về ngày đầu tiên của tháng được nhập vào (ở dây là tháng hiện tại do datetimepicker)
            int line = 0;
            lbMonthYear.Text = Month[date.Month-1] + ", " + date.Year.ToString();           //Label hiện tháng - năm
            for(int i = 1; i <= DayOfMonth(date); ++i)
            {
                int column = dayOfWeek.IndexOf(useDate.DayOfWeek.ToString());               //ví dụ: trả về Thursday -> index = 4
                Guna2Button btn = Matrix[line][column];
                btn.Text = i.ToString();
                btn.ForeColor = Color.White;
                fillDay(ref btn, i, date.Month);
                fillStatistic();
                if(IsEqualDay(useDate, DateTime.Now))                                       //Ngày hôm nay sẽ được bôi vàng
                {
                    btn.BorderThickness = 1;
                    btn.BorderColor = Color.Green;
                }

                if (IsEqualDay(useDate, date))                                              //Ngày được chọn trên datetimepicker sẽ được bôi màu
                {
                    btn.FillColor = Color.FromArgb(80, 84, 87);
                }

                if (column >= 6)                                                            //Cuối tuần ( 0 1 2 3 4 5 6 )
                    line++;

                useDate = useDate.AddDays(1);                                               //+ thêm 1 ngày vào ngày đầu tiên -> trở thành ngày tiếp theo
            }
        }

        void ClearMatrix()                                                                  //Hàm xóa đi các giá trị trong mảng nút
        {
            for(int i = 0; i < Matrix.Count; ++i)
            {
                for(int j = 0; j < Matrix[i].Count; ++j)
                {
                    Guna2Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.FillColor = Color.FromArgb(43, 47, 51);
                    btn.ForeColor = Color.White;
                    btn.BorderThickness = 0;
                }
            }
            ShiftInMonth[0] = 0;
            ShiftInMonth[1] = 0;
            ShiftInMonth[2] = 0;
        }
        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoMatrixDay((sender as Guna2DateTimePicker).Value);
        }
        #endregion

        #region Các nút khác
        private void btnToday_Click(object sender, EventArgs e)
        {
            SetDefaultDay();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }   

        private void btnPreviousMonth_Click(object sender, EventArgs e)
        {
            dateTime.Value = dateTime.Value.AddMonths(-1);
        }
        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            dateTime.Value = dateTime.Value.AddMonths(1);
        }
        #endregion

        #region Chia ca làm việc cho nhân viên
        //Trước hết cần phải lấy mã của nhân viên đó
        DivideShift dv = new DivideShift();
        string takeNumberID(string EmpID)                                                   //EmpID được quy định là 2 chữ cái đầu + mã số NV ở sau
        {
            string res = EmpID.Remove(0, 2);
            return res;
        }

        void fillDay(ref Guna2Button btn, int rotateDay, int month)
        {
            DOW = new List<List<int>>();                                                    //Mảng 2 chiều chia ca ( day of work )
            int EmpID = Convert.ToInt32(takeNumberID(UserID.GlobalUserID)) - 1;             //Mã số nhân viên tương đương với (Index of Columns - 1)
            DOW = dv.SetTheBaseDOW(CalendarDAL.Instance.NV, CalendarDAL.Instance.CL, rotateDay + (month % 2));      //Nếu tháng lẻ // tháng chẵn
            for (int j = 0; j < 3; ++j)
            {
                if(DOW[j][EmpID] == 1)                                                      //Nếu thoả if => ngày đó đi làm
                {
                    if (j == 0)
                        btn.ForeColor = Color.FromArgb(255, 128, 0);
                    //Note lại ca làm vào List ShiftInMonth
                    ShiftInMonth[j] += 1;
                }
            }
        }

        //Phần thống kê số ca làm trong tháng của nhân viên
        void fillStatistic()
        {
            lbMorning.Text = "Morning:" + ShiftInMonth[0].ToString();
            lbNoon.Text = "Noon:" + ShiftInMonth[1].ToString();
            lbEvening.Text = "Evening:" + ShiftInMonth[2].ToString();
            lbTotal.Text = "Total:" + (ShiftInMonth[0] + ShiftInMonth[1] + ShiftInMonth[2]).ToString();
        }
        #endregion
    }
}
