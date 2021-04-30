
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
            this.pnCalendar = new Guna.UI2.WinForms.Guna2Panel();
            this.pnStatistic = new Guna.UI2.WinForms.Guna2Panel();
            this.chartWork = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnTask = new Guna.UI2.WinForms.Guna2Panel();
            this.progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.pnGoWorkDay = new Guna.UI2.WinForms.Guna2Panel();
            this.lb = new System.Windows.Forms.Label();
            this.pnNote = new Guna.UI2.WinForms.Guna2Panel();
            this.lbNote = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTask = new Guna.UI2.WinForms.Guna2Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fpn = new System.Windows.Forms.FlowLayoutPanel();
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
            this.pnCalendar.Location = new System.Drawing.Point(588, 12);
            this.pnCalendar.Name = "pnCalendar";
            this.pnCalendar.ShadowDecoration.Parent = this.pnCalendar;
            this.pnCalendar.Size = new System.Drawing.Size(296, 266);
            this.pnCalendar.TabIndex = 4;
            // 
            // pnStatistic
            // 
            this.pnStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.pnStatistic.BorderRadius = 22;
            this.pnStatistic.BorderThickness = 1;
            this.pnStatistic.Controls.Add(this.chartWork);
            this.pnStatistic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.pnStatistic.Location = new System.Drawing.Point(588, 350);
            this.pnStatistic.Name = "pnStatistic";
            this.pnStatistic.ShadowDecoration.Parent = this.pnStatistic;
            this.pnStatistic.Size = new System.Drawing.Size(296, 246);
            this.pnStatistic.TabIndex = 5;
            // 
            // chartWork
            // 
            this.chartWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            chartArea3.Name = "ChartArea1";
            this.chartWork.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartWork.Legends.Add(legend3);
            this.chartWork.Location = new System.Drawing.Point(18, 19);
            this.chartWork.Name = "chartWork";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartWork.Series.Add(series3);
            this.chartWork.Size = new System.Drawing.Size(259, 209);
            this.chartWork.TabIndex = 0;
            this.chartWork.Text = "chart1";
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
            this.pnTask.Size = new System.Drawing.Size(570, 397);
            this.pnTask.TabIndex = 6;
            // 
            // progressBar
            // 
            this.progressBar.FillColor = System.Drawing.Color.White;
            this.progressBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.progressBar.Location = new System.Drawing.Point(18, 12);
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.Solid;
            this.progressBar.ProgressColor = System.Drawing.Color.Empty;
            this.progressBar.ShadowDecoration.Parent = this.progressBar;
            this.progressBar.Size = new System.Drawing.Size(259, 15);
            this.progressBar.TabIndex = 0;
            this.progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // pnGoWorkDay
            // 
            this.pnGoWorkDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.pnGoWorkDay.BorderRadius = 22;
            this.pnGoWorkDay.BorderThickness = 1;
            this.pnGoWorkDay.Controls.Add(this.lb);
            this.pnGoWorkDay.Controls.Add(this.progressBar);
            this.pnGoWorkDay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.pnGoWorkDay.Location = new System.Drawing.Point(588, 284);
            this.pnGoWorkDay.Name = "pnGoWorkDay";
            this.pnGoWorkDay.ShadowDecoration.Parent = this.pnGoWorkDay;
            this.pnGoWorkDay.Size = new System.Drawing.Size(296, 60);
            this.pnGoWorkDay.TabIndex = 6;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.BackColor = System.Drawing.Color.Transparent;
            this.lb.ForeColor = System.Drawing.Color.White;
            this.lb.Location = new System.Drawing.Point(14, 30);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(45, 19);
            this.lb.TabIndex = 0;
            this.lb.Text = "label1";
            // 
            // pnNote
            // 
            this.pnNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.pnNote.BorderRadius = 22;
            this.pnNote.BorderThickness = 1;
            this.pnNote.Controls.Add(this.richTextBox1);
            this.pnNote.Controls.Add(this.lbNote);
            this.pnNote.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.pnNote.Location = new System.Drawing.Point(12, 415);
            this.pnNote.Name = "pnNote";
            this.pnNote.ShadowDecoration.Parent = this.pnNote;
            this.pnNote.Size = new System.Drawing.Size(570, 181);
            this.pnNote.TabIndex = 7;
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.BackColor = System.Drawing.Color.Transparent;
            this.lbNote.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNote.ForeColor = System.Drawing.Color.White;
            this.lbNote.Location = new System.Drawing.Point(15, 9);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(84, 23);
            this.lbNote.TabIndex = 1;
            this.lbNote.Text = "My notes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tasks:";
            // 
            // btnAddTask
            // 
            this.btnAddTask.CheckedState.Parent = this.btnAddTask;
            this.btnAddTask.CustomImages.Parent = this.btnAddTask;
            this.btnAddTask.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnAddTask.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.HoverState.Parent = this.btnAddTask;
            this.btnAddTask.Location = new System.Drawing.Point(443, 10);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.ShadowDecoration.Parent = this.btnAddTask;
            this.btnAddTask.Size = new System.Drawing.Size(108, 23);
            this.btnAddTask.TabIndex = 8;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(19, 35);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(532, 128);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // fpn
            // 
            this.fpn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.fpn.Location = new System.Drawing.Point(19, 51);
            this.fpn.Name = "fpn";
            this.fpn.Size = new System.Drawing.Size(532, 320);
            this.fpn.TabIndex = 0;
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(896, 608);
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
        private System.Windows.Forms.Label lb;
        private Guna.UI2.WinForms.Guna2Panel pnNote;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAddTask;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FlowLayoutPanel fpn;
    }
}