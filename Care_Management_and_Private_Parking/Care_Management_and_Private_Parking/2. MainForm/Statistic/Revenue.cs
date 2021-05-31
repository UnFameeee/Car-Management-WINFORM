using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DAL;

namespace Care_Management_and_Private_Parking
{
    public partial class Revenue : Form
    {
        public Revenue()
        {
            InitializeComponent();
        }
        #region properties
        DataTable table1 = StatisticDAL.Instance.loadTableSalary(2021);
        DataTable table2 = StatisticDAL.Instance.loadTableIncome1(2021);
        DataTable table3 = StatisticDAL.Instance.loadTableIncome2(2021);
        string[] months = new string[12] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        #endregion

        #region
        private void Revenue_Load(object sender, EventArgs e)
        {
            loadChartOutcome1();
            loadChartOutcome2();
            loadChartIncome1();
            loadChartIncome2();
        }

        #endregion


        #region outcome chart1
        private void loadChartOutcome1()
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
            chart.Series["Series2"].Points.DataBindY(arraySingleRow);

            Axis axisX = chart.ChartAreas[0].AxisX;
            double axisLabelPos = 0.5;

            for (int i = 0; i < months.Length; ++i)
            {
                axisX.CustomLabels.Add(axisLabelPos, axisLabelPos + 1, months[i]);
                axisLabelPos = axisLabelPos + 1.0;
            }

            chart.ChartAreas[0].AxisX.LabelStyle.Angle = 45;
            chart.ChartAreas[0].AxisX.MajorGrid.Interval = 1;
        }
        #endregion

        #region outcome chart2
        private void loadChartOutcome2()
        {
            double[] arraySingleRow = new double[12];       //giá trị tiền tệ cột y của tháng đó

            for (int i = 0; i < 12; ++i)
            {
                for (int j = 0, length = table1.Rows.Count; j < length; ++j)
                {
                    if (Convert.ToInt32(table1.Rows[j]["MonthWork"]) == i + 1)
                    {
                        arraySingleRow[i] = Convert.ToDouble(Convert.ToInt32(table1.Rows[j]["Salary"]));      //arrayData[getRowNumber, i];
                        break;
                    }
                }
            }
            chartWorkHour.Series["Outcome"].Points.DataBindY(arraySingleRow);

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

        #region income chart1
        private void loadChartIncome1()
        {
            double[] arraySingleRow = new double[12];       //giá trị tiền tệ cột y của tháng đó

            for (int i = 0; i < 12; ++i)
            {
                for (int j = 0, length = table2.Rows.Count; j < length; ++j)
                {
                    if (Convert.ToInt32(table2.Rows[j]["MonthCPF"]) == i + 1)
                    {
                        arraySingleRow[i] = Convert.ToDouble(Convert.ToInt32(table2.Rows[j]["Salary"]));      //arrayData[getRowNumber, i];
                        break;
                    }
                }
            }

            for (int i = 0; i < 12; ++i)
            {
                for (int j = 0, length = table3.Rows.Count; j < length; ++j)
                {
                    if (Convert.ToInt32(table3.Rows[j]["MonthPPF"]) == i + 1)
                    {
                        arraySingleRow[i] += Convert.ToDouble(Convert.ToInt32(table3.Rows[j]["Salary"]));      //arrayData[getRowNumber, i];
                        break;
                    }
                }
            }
            chart.Series["Series1"].Points.DataBindY(arraySingleRow);

            Axis axisX = chart.ChartAreas[0].AxisX;
            double axisLabelPos = 0.5;

            for (int i = 0; i < months.Length; ++i)
            {
                axisX.CustomLabels.Add(axisLabelPos, axisLabelPos + 1, months[i]);
                axisLabelPos = axisLabelPos + 1.0;
            }

            chart.ChartAreas[0].AxisX.LabelStyle.Angle = 45;
            chart.ChartAreas[0].AxisX.MajorGrid.Interval = 1;
        }
        #endregion

        #region income chart2
        private void loadChartIncome2()
        {
            double[] arraySingleRow = new double[12];       //giá trị tiền tệ cột y của tháng đó

            for (int i = 0; i < 12; ++i)
            {
                for (int j = 0, length = table2.Rows.Count; j < length; ++j)
                {
                    if (Convert.ToInt32(table2.Rows[j]["MonthCPF"]) == i + 1)
                    {
                        arraySingleRow[i] = Convert.ToDouble(Convert.ToInt32(table2.Rows[j]["Salary"]));      //arrayData[getRowNumber, i];
                        break;
                    }
                }
            }

            for (int i = 0; i < 12; ++i)
            {
                for (int j = 0, length = table3.Rows.Count; j < length; ++j)
                {
                    if (Convert.ToInt32(table3.Rows[j]["MonthPPF"]) == i + 1)
                    {
                        arraySingleRow[i] += Convert.ToDouble(Convert.ToInt32(table3.Rows[j]["Salary"]));      //arrayData[getRowNumber, i];
                        break;
                    }
                }
            }
            chartWorkHour.Series["Income"].Points.DataBindY(arraySingleRow);

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
    }
}
