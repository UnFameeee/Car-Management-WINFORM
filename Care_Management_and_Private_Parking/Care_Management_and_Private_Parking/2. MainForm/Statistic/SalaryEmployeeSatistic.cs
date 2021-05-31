using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;
//3layers
using DAL;


namespace Care_Management_and_Private_Parking
{
    public partial class SalaryEmployeeSatistic : Form
    {
        public SalaryEmployeeSatistic()
        {
            InitializeComponent();
        }

        //double[,] arrayData;

        #region properties
        DataTable table1 = new DataTable();
        DataTable table2 = new DataTable();
        string[] months = new string[12] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        #endregion

        private void SalaryEmployeeSatistic_Load(object sender, EventArgs e)
        {
            loadChartEmpSalary();
            loadChartWorkHours();
            loadPieChart();
            cbYear.SelectedItem = "2021";
            int year = Convert.ToInt32(cbYear.SelectedItem);
            load(year);
        }

        #region EmpSalary
        private void loadChartEmpSalary()
        {
            double[] arraySingleRow = new double[12];       //giá trị tiền tệ cột y của tháng đó

            for (int i = 0; i < 12; ++i)
            {
                for (int j = 0, length = table1.Rows.Count; j < length; ++j)
                {
                    if (Convert.ToInt32(table1.Rows[j]["MonthWork"]) == i + 1)
                    {
                        arraySingleRow[i] = Convert.ToDouble(table1.Rows[j]["Salary"]);      //arrayData[getRowNumber, i];
                        break;
                    }
                }
            }
            chartEmpSalary.Series["Series1"].Points.DataBindY(arraySingleRow);

            Axis axisX = chartEmpSalary.ChartAreas[0].AxisX;
            double axisLabelPos = 0.5;

            for (int i = 0; i < months.Length; ++i)
            {
                axisX.CustomLabels.Add(axisLabelPos, axisLabelPos + 1, months[i]);
                axisLabelPos = axisLabelPos + 1.0;
            }

            chartEmpSalary.ChartAreas[0].AxisX.LabelStyle.Angle = 45;
            chartEmpSalary.ChartAreas[0].AxisX.MajorGrid.Interval = 1;
        }
        #endregion

        #region WorkHour
        private void loadChartWorkHours()
        {
            double[] arraySingleRow = new double[12];       //giá trị giờ cột y của tháng đó

            for (int i = 0; i < 12; ++i)
            {
                for (int j = 0, length = table1.Rows.Count; j < length; ++j)
                {
                    if (Convert.ToInt32(table1.Rows[j]["MonthWork"]) == i + 1)
                    {
                        arraySingleRow[i] = Convert.ToDouble(table1.Rows[j]["WorkHour"]);      //arrayData[getRowNumber, i];
                        break;
                    }
                }
            }
            chartWorkHour.Series["Series1"].Points.DataBindY(arraySingleRow);

            Axis axisX = chartWorkHour.ChartAreas[0].AxisX;
            double axisLabelPos = 0.5;

            for (int i = 0; i < months.Length; ++i)
            {
                axisX.CustomLabels.Add(axisLabelPos, axisLabelPos + 1, months[i]);
                axisLabelPos = axisLabelPos + 1.0;
            }

            chartWorkHour.ChartAreas[0].AxisX.LabelStyle.Angle = 45;
            chartWorkHour.ChartAreas[0].AxisX.MajorGrid.Interval = 1;
        }
        #endregion

        private void loadPieChart()
        {
            int male = StatisticDAL.Instance.takeMale();
            int female = StatisticDAL.Instance.takeFemale();

            pieChart.Series["Series1"].Points.AddXY("Male", male);
            pieChart.Series["Series1"].Points.AddXY("Female", female);
        }

        private void load(int year)
        {
            table1 = StatisticDAL.Instance.loadTableSalary(year);
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(cbYear.SelectedItem);
            load(year);
            loadChartEmpSalary();
            loadChartWorkHours();
        }
    }
}
