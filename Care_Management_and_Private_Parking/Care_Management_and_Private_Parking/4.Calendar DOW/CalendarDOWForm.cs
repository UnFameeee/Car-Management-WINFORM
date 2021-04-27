using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Care_Management_and_Private_Parking
{
    public partial class CalendarDOWForm : Form
    {
        #region Properties
        private List<List<Button>> matrix;                                          //Khởi tạo mảng 2 chiều mang giá trị là các nút

        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        private List<string> dayOfWeek = new List<string>{ "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        private List<string> Month = new List<string> { "January", "February", "March", "April", "May", "June", "July", "August", "September", 
            "October", "November", "December" };
        public List<List<int>> dow;
        public List<List<int>> DOW
        {
            get { return dow; }
            set { dow = value; }
        }
        #endregion

        public CalendarDOWForm()
        {
            InitializeComponent();
            LoadMatrixDay();
        }
        void SetDefaultDay()
        {
            dateTime.Value = DateTime.Now;                                           //Set giá trị ngày tháng của datetimepicker thành ngày hôm nay
        }
        //Tạo ra ma trận nút 7x6 (chưa hiển thị ngày)
        void LoadMatrixDay()
        {
            Matrix = new List<List<Button>>();
            Button oldbtn = new Button() { Width = 0, Height = 0, Location = new Point(-Variable.margin, 0) };
            for(int i = 0; i < Variable.DayOfColumn; ++i)
            {
                Matrix.Add(new List<Button>());
                for(int j = 0; j < Variable.DayOfWeeks; ++j)
                {
                    Button btn = new Button() {Width = Variable.btnWidth, Height = Variable.btnHeight};
                    btn.Location = new Point(oldbtn.Location.X + oldbtn.Width + Variable.margin, oldbtn.Location.Y);
                    pnlMatrixDay.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    oldbtn = btn;
                }
                oldbtn = new Button() { Width = 0, Height = 0, Location = new Point(-Variable.margin, oldbtn.Location.Y + Variable.btnHeight) };
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
        }                                             //Trả về số ngày tương ứng với tháng
        bool IsEqualDay(DateTime dateA, DateTime dateB)
        {
            return dateA.Day == dateB.Day && dateA.Month == dateB.Month && dateA.Year == dateB.Year;
        }
        //Thêm ngày vào nút
        void AddNumberIntoMatrixDay(DateTime date)                                   //Thêm ngày vào ma trận các nút (ngày)
        {
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);               //Trả về ngày đầu tiên của tháng được nhập vào (ở dây là tháng hiện tại do datetimepicker)
            int line = 0;
            lbMonthYear.Text = Month[date.Month-1] + ", " + date.Year.ToString();    //Label hiện tháng - năm
            for(int i = 1; i <= DayOfMonth(date); ++i)
            {
                int column = dayOfWeek.IndexOf(useDate.DayOfWeek.ToString());        //ví dụ: trả về Thursday -> index = 4
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();
                fillDay(ref btn, i, date.Month);
                if(IsEqualDay(useDate, DateTime.Now))                                //Ngày hôm nay sẽ được bôi vàng
                {
                    btn.BackColor = Color.Yellow;
                }

                if (IsEqualDay(useDate, date))                                       //Ngày được chọn trên datetimepicker sẽ được bôi màu
                {
                    btn.BackColor = Color.LightGreen;
                }

                if (column >= 6)                                                     //Cuối tuần ( 0 1 2 3 4 5 6 )
                    line++;

                useDate = useDate.AddDays(1);                                        //+ thêm 1 ngày vào ngày đầu tiên -> trở thành ngày tiếp theo
            }
        }

        void ClearMatrix()                                                          //Hàm xóa đi các giá trị trong mảng nút
        {
            for(int i = 0; i < Matrix.Count; ++i)
            {
                for(int j = 0; j < Matrix[i].Count; ++j)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = DefaultBackColor;
                    btn.ForeColor = Color.Black;
                }
            }
        }
        
        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoMatrixDay((sender as DateTimePicker).Value);
        }
        //--------------------------------------------------------------------------------------------------------------------------------//
        //Các nút khác
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
        //---------------------------------------------------------------------------------------------------------------------------------//
        //Chia ca làm việc cho nhân viên
        //Trước hết cần phải lấy mã của nhân viên đó

        DivideShift dv = new DivideShift();
        string takeNumberID(string EmpID)                                                   //EmpID được quy định là 2 chữ cái đầu + mã số NV ở sau
        {
            string res = EmpID.Remove(0, 2);
            return res;
        }
        void fillDay(ref Button btn, int rotateDay, int month)
        {
            DOW = new List<List<int>>();                                                    //Mảng 2 chiều chia ca ( day of work )
            int EmpID = Convert.ToInt32(takeNumberID(LoginForm.EmpID)) - 1;                 //Mã số nhân viên tương đương với (Index of Columns - 1)
            DOW = dv.SetTheBaseDOW(Variable.NV, Variable.CL, rotateDay + (month % 2));      //Nếu tháng lẻ // tháng chẵn
            for (int j = 0; j < 3; ++j)
            {
                if(DOW[j][EmpID] == 1)                                                      //Nếu thoả if => ngày đó đi làm
                {
                    btn.ForeColor = Color.Red;
                    //Bonus: tạo thêm 1 bảng khi bấm vào sẽ hiện ra ca làm việc của ngày đó
                }
            }
        }
    }
}
