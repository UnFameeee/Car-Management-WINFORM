
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
            this.pnCalendar = new Guna.UI2.WinForms.Guna2Panel();
            this.pnStatistic = new Guna.UI2.WinForms.Guna2Panel();
            this.pnMain = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // pnCalendar
            // 
            this.pnCalendar.BackColor = System.Drawing.Color.LightGray;
            this.pnCalendar.BorderRadius = 22;
            this.pnCalendar.BorderThickness = 1;
            this.pnCalendar.FillColor = System.Drawing.Color.White;
            this.pnCalendar.Location = new System.Drawing.Point(588, 12);
            this.pnCalendar.Name = "pnCalendar";
            this.pnCalendar.ShadowDecoration.Parent = this.pnCalendar;
            this.pnCalendar.Size = new System.Drawing.Size(296, 246);
            this.pnCalendar.TabIndex = 4;
            // 
            // pnStatistic
            // 
            this.pnStatistic.BackColor = System.Drawing.Color.LightGray;
            this.pnStatistic.BorderRadius = 22;
            this.pnStatistic.BorderThickness = 1;
            this.pnStatistic.FillColor = System.Drawing.Color.White;
            this.pnStatistic.Location = new System.Drawing.Point(588, 350);
            this.pnStatistic.Name = "pnStatistic";
            this.pnStatistic.ShadowDecoration.Parent = this.pnStatistic;
            this.pnStatistic.Size = new System.Drawing.Size(296, 246);
            this.pnStatistic.TabIndex = 5;
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.LightGray;
            this.pnMain.BorderRadius = 22;
            this.pnMain.BorderThickness = 1;
            this.pnMain.FillColor = System.Drawing.Color.White;
            this.pnMain.Location = new System.Drawing.Point(12, 12);
            this.pnMain.Name = "pnMain";
            this.pnMain.ShadowDecoration.Parent = this.pnMain;
            this.pnMain.Size = new System.Drawing.Size(570, 584);
            this.pnMain.TabIndex = 6;
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(896, 608);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnStatistic);
            this.Controls.Add(this.pnCalendar);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalendarForm";
            this.Text = "CalendarForm";
            this.Load += new System.EventHandler(this.CalendarForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnCalendar;
        private Guna.UI2.WinForms.Guna2Panel pnStatistic;
        private Guna.UI2.WinForms.Guna2Panel pnMain;
    }
}