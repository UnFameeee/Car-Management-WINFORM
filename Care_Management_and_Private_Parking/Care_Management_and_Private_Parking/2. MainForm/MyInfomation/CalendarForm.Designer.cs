
namespace Care_Management_and_Private_Parking
{
    partial class CalendarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.pnCalendar = new Guna.UI2.WinForms.Guna2Panel();
            this.pnStatistic = new Guna.UI2.WinForms.Guna2Panel();
            this.chartWork = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnTask = new Guna.UI2.WinForms.Guna2Panel();
            this.fpn = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddTask = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.pnGoWorkDay = new Guna.UI2.WinForms.Guna2Panel();
            this.lbProgressBar = new System.Windows.Forms.Label();
            this.pnNote = new Guna.UI2.WinForms.Guna2Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.lbPosition = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbMale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbFemale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbIdentity = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.dateTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbDayOfWork = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.pnStatistic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWork)).BeginInit();
            this.pnTask.SuspendLayout();
            this.pnGoWorkDay.SuspendLayout();
            this.pnNote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCalendar
            // 
            this.pnCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.pnCalendar.BorderRadius = 22;
            this.pnCalendar.BorderThickness = 1;
            this.pnCalendar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.pnCalendar.Location = new System.Drawing.Point(687, 12);
            this.pnCalendar.Name = "pnCalendar";
            this.pnCalendar.ShadowDecoration.Parent = this.pnCalendar;
            this.pnCalendar.Size = new System.Drawing.Size(377, 329);
            this.pnCalendar.TabIndex = 4;
            // 
            // pnStatistic
            // 
            this.pnStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.pnStatistic.BorderRadius = 22;
            this.pnStatistic.BorderThickness = 1;
            this.pnStatistic.Controls.Add(this.chartWork);
            this.pnStatistic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.pnStatistic.Location = new System.Drawing.Point(687, 413);
            this.pnStatistic.Name = "pnStatistic";
            this.pnStatistic.ShadowDecoration.Parent = this.pnStatistic;
            this.pnStatistic.Size = new System.Drawing.Size(377, 311);
            this.pnStatistic.TabIndex = 5;
            // 
            // chartWork
            // 
            this.chartWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            chartArea3.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(9)))), ((int)(((byte)(121)))));
            chartArea3.AxisX.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.Title = "Shift";
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea3.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.InterlacedColor = System.Drawing.Color.White;
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            chartArea3.AxisY.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.Title = "This Month\'s Shift";
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea3.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            chartArea3.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea3.BorderWidth = 0;
            chartArea3.Name = "ChartArea1";
            chartArea3.ShadowColor = System.Drawing.Color.White;
            this.chartWork.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            legend3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            legend3.Name = "Legend1";
            this.chartWork.Legends.Add(legend3);
            this.chartWork.Location = new System.Drawing.Point(18, 19);
            this.chartWork.Name = "chartWork";
            this.chartWork.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartWork.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))))};
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series3.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(9)))), ((int)(((byte)(121)))));
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            series3.EmptyPointStyle.LabelForeColor = System.Drawing.Color.Empty;
            series3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.LabelBackColor = System.Drawing.Color.White;
            series3.LabelBorderWidth = 0;
            series3.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            series3.Legend = "Legend1";
            series3.MarkerBorderColor = System.Drawing.Color.White;
            series3.Name = "Days";
            series3.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Transparent;
            this.chartWork.Series.Add(series3);
            this.chartWork.Size = new System.Drawing.Size(340, 274);
            this.chartWork.TabIndex = 0;
            this.chartWork.Text = "Day Worked in This Month";
            title3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            title3.Name = "Title1";
            title3.Text = "Day Worked In This Month";
            this.chartWork.Titles.Add(title3);
            // 
            // pnTask
            // 
            this.pnTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.pnTask.BorderRadius = 22;
            this.pnTask.BorderThickness = 1;
            this.pnTask.Controls.Add(this.fpn);
            this.pnTask.Controls.Add(this.btnAddTask);
            this.pnTask.Controls.Add(this.label1);
            this.pnTask.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.pnTask.Location = new System.Drawing.Point(12, 460);
            this.pnTask.Name = "pnTask";
            this.pnTask.ShadowDecoration.Parent = this.pnTask;
            this.pnTask.Size = new System.Drawing.Size(660, 264);
            this.pnTask.TabIndex = 6;
            // 
            // fpn
            // 
            this.fpn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.fpn.Location = new System.Drawing.Point(20, 46);
            this.fpn.Name = "fpn";
            this.fpn.Size = new System.Drawing.Size(623, 203);
            this.fpn.TabIndex = 0;
            // 
            // btnAddTask
            // 
            this.btnAddTask.CheckedState.Parent = this.btnAddTask;
            this.btnAddTask.CustomImages.Parent = this.btnAddTask;
            this.btnAddTask.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnAddTask.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.HoverState.Parent = this.btnAddTask;
            this.btnAddTask.Location = new System.Drawing.Point(535, 17);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.ShadowDecoration.Parent = this.btnAddTask;
            this.btnAddTask.Size = new System.Drawing.Size(108, 23);
            this.btnAddTask.TabIndex = 8;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tasks:";
            // 
            // progressBar
            // 
            this.progressBar.BorderRadius = 6;
            this.progressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.progressBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.progressBar.Location = new System.Drawing.Point(18, 12);
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(9)))), ((int)(((byte)(121)))));
            this.progressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.progressBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar.ShadowDecoration.Parent = this.progressBar;
            this.progressBar.Size = new System.Drawing.Size(340, 19);
            this.progressBar.TabIndex = 0;
            this.progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.progressBar.Value = 80;
            // 
            // pnGoWorkDay
            // 
            this.pnGoWorkDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.pnGoWorkDay.BorderRadius = 22;
            this.pnGoWorkDay.BorderThickness = 1;
            this.pnGoWorkDay.Controls.Add(this.lbProgressBar);
            this.pnGoWorkDay.Controls.Add(this.progressBar);
            this.pnGoWorkDay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.pnGoWorkDay.Location = new System.Drawing.Point(687, 347);
            this.pnGoWorkDay.Name = "pnGoWorkDay";
            this.pnGoWorkDay.ShadowDecoration.Parent = this.pnGoWorkDay;
            this.pnGoWorkDay.Size = new System.Drawing.Size(377, 60);
            this.pnGoWorkDay.TabIndex = 6;
            // 
            // lbProgressBar
            // 
            this.lbProgressBar.AutoSize = true;
            this.lbProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.lbProgressBar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProgressBar.ForeColor = System.Drawing.Color.White;
            this.lbProgressBar.Location = new System.Drawing.Point(78, 34);
            this.lbProgressBar.Name = "lbProgressBar";
            this.lbProgressBar.Size = new System.Drawing.Size(210, 15);
            this.lbProgressBar.TabIndex = 0;
            this.lbProgressBar.Text = "You have worked very hard this month";
            // 
            // pnNote
            // 
            this.pnNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.pnNote.BorderRadius = 22;
            this.pnNote.BorderThickness = 1;
            this.pnNote.Controls.Add(this.panel2);
            this.pnNote.Controls.Add(this.guna2GradientButton2);
            this.pnNote.Controls.Add(this.lbName);
            this.pnNote.Controls.Add(this.panel1);
            this.pnNote.Controls.Add(this.btnRefresh);
            this.pnNote.Controls.Add(this.pic);
            this.pnNote.Controls.Add(this.lbPosition);
            this.pnNote.Controls.Add(this.lb1);
            this.pnNote.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.pnNote.Location = new System.Drawing.Point(12, 12);
            this.pnNote.Name = "pnNote";
            this.pnNote.ShadowDecoration.Parent = this.pnNote;
            this.pnNote.Size = new System.Drawing.Size(660, 442);
            this.pnNote.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.label7.Location = new System.Drawing.Point(6, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(318, 34);
            this.label7.TabIndex = 178;
            this.label7.Text = "Edit My Information";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(9)))), ((int)(((byte)(121)))));
            this.btnRefresh.Location = new System.Drawing.Point(21, 140);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 29);
            this.btnRefresh.TabIndex = 177;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(447, 49);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(120, 120);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 176;
            this.pic.TabStop = false;
            // 
            // lbPosition
            // 
            this.lbPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.lbPosition.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPosition.ForeColor = System.Drawing.Color.White;
            this.lbPosition.Location = new System.Drawing.Point(21, 89);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(250, 34);
            this.lbPosition.TabIndex = 175;
            this.lbPosition.Text = "Position:";
            this.lbPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb1
            // 
            this.lb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.lb1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.lb1.Location = new System.Drawing.Point(21, 55);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(64, 34);
            this.lb1.TabIndex = 174;
            this.lb1.Text = "Name:";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 161;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 162;
            this.label3.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 21);
            this.label4.TabIndex = 163;
            this.label4.Text = "Birthday:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 164;
            this.label5.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 21);
            this.label6.TabIndex = 165;
            this.label6.Text = "Identity Num:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dateTime);
            this.panel1.Controls.Add(this.tbIdentity);
            this.panel1.Controls.Add(this.tbPhone);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.rbFemale);
            this.panel1.Controls.Add(this.rbMale);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(20, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 252);
            this.panel1.TabIndex = 179;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.rbMale.Checked = true;
            this.rbMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.rbMale.CheckedState.BorderThickness = 0;
            this.rbMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.rbMale.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.rbMale.CheckedState.InnerOffset = -4;
            this.rbMale.ForeColor = System.Drawing.Color.White;
            this.rbMale.Location = new System.Drawing.Point(114, 86);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(50, 17);
            this.rbMale.TabIndex = 180;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbMale.UncheckedState.BorderThickness = 2;
            this.rbMale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbMale.UseVisualStyleBackColor = false;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.rbFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbFemale.CheckedState.BorderThickness = 0;
            this.rbFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.rbFemale.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.rbFemale.CheckedState.InnerOffset = -4;
            this.rbFemale.ForeColor = System.Drawing.Color.White;
            this.rbFemale.Location = new System.Drawing.Point(192, 85);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(61, 17);
            this.rbFemale.TabIndex = 181;
            this.rbFemale.Text = "Female";
            this.rbFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbFemale.UncheckedState.BorderThickness = 2;
            this.rbFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbFemale.UseVisualStyleBackColor = false;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.White;
            this.tbName.Location = new System.Drawing.Point(114, 51);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(203, 23);
            this.tbName.TabIndex = 180;
            this.tbName.Text = "\r\n";
            // 
            // tbPhone
            // 
            this.tbPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.ForeColor = System.Drawing.Color.White;
            this.tbPhone.Location = new System.Drawing.Point(114, 137);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(203, 23);
            this.tbPhone.TabIndex = 182;
            this.tbPhone.Text = "\r\n";
            // 
            // tbIdentity
            // 
            this.tbIdentity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tbIdentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdentity.ForeColor = System.Drawing.Color.White;
            this.tbIdentity.Location = new System.Drawing.Point(114, 164);
            this.tbIdentity.Name = "tbIdentity";
            this.tbIdentity.Size = new System.Drawing.Size(203, 23);
            this.tbIdentity.TabIndex = 183;
            this.tbIdentity.Text = "\r\n";
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.lbName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.lbName.Location = new System.Drawing.Point(77, 55);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(207, 34);
            this.lbName.TabIndex = 180;
            this.lbName.Text = "...";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTime
            // 
            this.dateTime.CheckedState.Parent = this.dateTime;
            this.dateTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.dateTime.ForeColor = System.Drawing.Color.White;
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime.HoverState.Parent = this.dateTime;
            this.dateTime.Location = new System.Drawing.Point(114, 112);
            this.dateTime.Margin = new System.Windows.Forms.Padding(2);
            this.dateTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTime.Name = "dateTime";
            this.dateTime.ShadowDecoration.Parent = this.dateTime;
            this.dateTime.Size = new System.Drawing.Size(146, 20);
            this.dateTime.TabIndex = 181;
            this.dateTime.Value = new System.DateTime(2021, 4, 30, 11, 28, 43, 523);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(9)))), ((int)(((byte)(121)))));
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.HoverState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Location = new System.Drawing.Point(155, 8);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(354, 35);
            this.guna2GradientButton2.TabIndex = 181;
            this.guna2GradientButton2.Text = "MY INFORMATION";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.tbSalary);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.tbDayOfWork);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(358, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 252);
            this.panel2.TabIndex = 182;
            // 
            // tbDayOfWork
            // 
            this.tbDayOfWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tbDayOfWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDayOfWork.ForeColor = System.Drawing.Color.White;
            this.tbDayOfWork.Location = new System.Drawing.Point(19, 74);
            this.tbDayOfWork.Name = "tbDayOfWork";
            this.tbDayOfWork.ReadOnly = true;
            this.tbDayOfWork.Size = new System.Drawing.Size(211, 23);
            this.tbDayOfWork.TabIndex = 183;
            this.tbDayOfWork.Text = "\r\n";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.label8.Location = new System.Drawing.Point(10, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 34);
            this.label8.TabIndex = 178;
            this.label8.Text = "My Salary";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(15, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 21);
            this.label9.TabIndex = 165;
            this.label9.Text = "Number Day of Work in Month";
            // 
            // tbSalary
            // 
            this.tbSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tbSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalary.ForeColor = System.Drawing.Color.White;
            this.tbSalary.Location = new System.Drawing.Point(19, 163);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.ReadOnly = true;
            this.tbSalary.Size = new System.Drawing.Size(211, 23);
            this.tbSalary.TabIndex = 185;
            this.tbSalary.Text = "\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(15, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 21);
            this.label10.TabIndex = 184;
            this.label10.Text = "Salary in Month";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.White;
            this.tbEmail.Location = new System.Drawing.Point(114, 193);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(203, 23);
            this.tbEmail.TabIndex = 185;
            this.tbEmail.Text = "\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(6, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 21);
            this.label11.TabIndex = 184;
            this.label11.Text = "Email:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(114, 222);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(108, 23);
            this.btnUpdate.TabIndex = 186;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1082, 736);
            this.Controls.Add(this.pnNote);
            this.Controls.Add(this.pnGoWorkDay);
            this.Controls.Add(this.pnTask);
            this.Controls.Add(this.pnStatistic);
            this.Controls.Add(this.pnCalendar);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalendarForm";
            this.Text = "CalendarForm";
            this.Load += new System.EventHandler(this.CalendarForm_Load);
            this.pnStatistic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartWork)).EndInit();
            this.pnTask.ResumeLayout(false);
            this.pnTask.PerformLayout();
            this.pnGoWorkDay.ResumeLayout(false);
            this.pnGoWorkDay.PerformLayout();
            this.pnNote.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnCalendar;
        private Guna.UI2.WinForms.Guna2Panel pnStatistic;
        private Guna.UI2.WinForms.Guna2Panel pnTask;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWork;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
        private Guna.UI2.WinForms.Guna2Panel pnGoWorkDay;
        private System.Windows.Forms.Label lbProgressBar;
        private Guna.UI2.WinForms.Guna2Panel pnNote;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAddTask;
        private System.Windows.Forms.FlowLayoutPanel fpn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2RadioButton rbFemale;
        private Guna.UI2.WinForms.Guna2RadioButton rbMale;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbIdentity;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lbName;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTime;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbDayOfWork;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
    }
}