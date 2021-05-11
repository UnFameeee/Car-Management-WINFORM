
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbNote = new System.Windows.Forms.Label();
            this.pnStatistic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWork)).BeginInit();
            this.pnTask.SuspendLayout();
            this.pnGoWorkDay.SuspendLayout();
            this.pnNote.SuspendLayout();
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
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(9)))), ((int)(((byte)(121)))));
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.Title = "Shift";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.Title = "This Month\'s Shift";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            chartArea1.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.White;
            this.chartWork.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            legend1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            legend1.Name = "Legend1";
            this.chartWork.Legends.Add(legend1);
            this.chartWork.Location = new System.Drawing.Point(18, 19);
            this.chartWork.Name = "chartWork";
            this.chartWork.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartWork.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))))};
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(9)))), ((int)(((byte)(121)))));
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            series1.EmptyPointStyle.LabelForeColor = System.Drawing.Color.Empty;
            series1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelBorderWidth = 0;
            series1.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.Name = "Days";
            series1.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Transparent;
            this.chartWork.Series.Add(series1);
            this.chartWork.Size = new System.Drawing.Size(340, 274);
            this.chartWork.TabIndex = 0;
            this.chartWork.Text = "Day Worked in This Month";
            title1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            title1.Name = "Title1";
            title1.Text = "Day Worked In This Month";
            this.chartWork.Titles.Add(title1);
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
            this.pnTask.Location = new System.Drawing.Point(12, 12);
            this.pnTask.Name = "pnTask";
            this.pnTask.ShadowDecoration.Parent = this.pnTask;
            this.pnTask.Size = new System.Drawing.Size(660, 512);
            this.pnTask.TabIndex = 6;
            // 
            // fpn
            // 
            this.fpn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.fpn.Location = new System.Drawing.Point(19, 63);
            this.fpn.Name = "fpn";
            this.fpn.Size = new System.Drawing.Size(617, 424);
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
            this.btnAddTask.Location = new System.Drawing.Point(528, 22);
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
            this.label1.Location = new System.Drawing.Point(19, 15);
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
            this.pnNote.Controls.Add(this.richTextBox1);
            this.pnNote.Controls.Add(this.lbNote);
            this.pnNote.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.pnNote.Location = new System.Drawing.Point(12, 543);
            this.pnNote.Name = "pnNote";
            this.pnNote.ShadowDecoration.Parent = this.pnNote;
            this.pnNote.Size = new System.Drawing.Size(660, 181);
            this.pnNote.TabIndex = 7;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(19, 35);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(617, 128);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.BackColor = System.Drawing.Color.Transparent;
            this.lbNote.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNote.ForeColor = System.Drawing.Color.White;
            this.lbNote.Location = new System.Drawing.Point(15, 9);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(70, 19);
            this.lbNote.TabIndex = 1;
            this.lbNote.Text = "My notes:";
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
            this.pnNote.PerformLayout();
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
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAddTask;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FlowLayoutPanel fpn;
    }
}