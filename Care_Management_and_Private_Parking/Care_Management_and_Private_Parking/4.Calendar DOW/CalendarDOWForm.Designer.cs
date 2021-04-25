
namespace Care_Management_and_Private_Parking
{
    partial class CalendarDOWForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarDOWForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tmNotify = new System.Windows.Forms.Timer(this.components);
            this.cmpPreMonth = new System.Windows.Forms.Button();
            this.cmpNextMonth = new System.Windows.Forms.Button();
            this.btnThur = new System.Windows.Forms.Button();
            this.btnSun = new System.Windows.Forms.Button();
            this.btnSat = new System.Windows.Forms.Button();
            this.btnFri = new System.Windows.Forms.Button();
            this.btnWed = new System.Windows.Forms.Button();
            this.btnTue = new System.Windows.Forms.Button();
            this.cmdToDay = new System.Windows.Forms.Button();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.nmNotify = new System.Windows.Forms.NumericUpDown();
            this.ckbTB = new System.Windows.Forms.CheckBox();
            this.btnMon = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMatrixDay = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nmNotify)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Thông báo";
            this.notifyIcon1.Visible = true;
            // 
            // tmNotify
            // 
            this.tmNotify.Enabled = true;
            this.tmNotify.Interval = 5000;
            // 
            // cmpPreMonth
            // 
            this.cmpPreMonth.Location = new System.Drawing.Point(4, 4);
            this.cmpPreMonth.Margin = new System.Windows.Forms.Padding(4);
            this.cmpPreMonth.Name = "cmpPreMonth";
            this.cmpPreMonth.Size = new System.Drawing.Size(80, 53);
            this.cmpPreMonth.TabIndex = 10;
            this.cmpPreMonth.Text = "<";
            this.cmpPreMonth.UseVisualStyleBackColor = true;
            // 
            // cmpNextMonth
            // 
            this.cmpNextMonth.Location = new System.Drawing.Point(848, 4);
            this.cmpNextMonth.Margin = new System.Windows.Forms.Padding(4);
            this.cmpNextMonth.Name = "cmpNextMonth";
            this.cmpNextMonth.Size = new System.Drawing.Size(80, 53);
            this.cmpNextMonth.TabIndex = 9;
            this.cmpNextMonth.Text = ">";
            this.cmpNextMonth.UseVisualStyleBackColor = true;
            // 
            // btnThur
            // 
            this.btnThur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThur.Location = new System.Drawing.Point(416, 4);
            this.btnThur.Margin = new System.Windows.Forms.Padding(4);
            this.btnThur.Name = "btnThur";
            this.btnThur.Size = new System.Drawing.Size(100, 53);
            this.btnThur.TabIndex = 3;
            this.btnThur.Text = "Thứ 5";
            this.btnThur.UseVisualStyleBackColor = true;
            // 
            // btnSun
            // 
            this.btnSun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSun.Location = new System.Drawing.Point(740, 4);
            this.btnSun.Margin = new System.Windows.Forms.Padding(4);
            this.btnSun.Name = "btnSun";
            this.btnSun.Size = new System.Drawing.Size(100, 53);
            this.btnSun.TabIndex = 6;
            this.btnSun.Text = "Chủ nhật";
            this.btnSun.UseVisualStyleBackColor = true;
            // 
            // btnSat
            // 
            this.btnSat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSat.Location = new System.Drawing.Point(632, 4);
            this.btnSat.Margin = new System.Windows.Forms.Padding(4);
            this.btnSat.Name = "btnSat";
            this.btnSat.Size = new System.Drawing.Size(100, 53);
            this.btnSat.TabIndex = 5;
            this.btnSat.Text = "Thứ 7";
            this.btnSat.UseVisualStyleBackColor = true;
            // 
            // btnFri
            // 
            this.btnFri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFri.Location = new System.Drawing.Point(524, 4);
            this.btnFri.Margin = new System.Windows.Forms.Padding(4);
            this.btnFri.Name = "btnFri";
            this.btnFri.Size = new System.Drawing.Size(100, 53);
            this.btnFri.TabIndex = 4;
            this.btnFri.Text = "Thứ 6";
            this.btnFri.UseVisualStyleBackColor = true;
            // 
            // btnWed
            // 
            this.btnWed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWed.Location = new System.Drawing.Point(308, 4);
            this.btnWed.Margin = new System.Windows.Forms.Padding(4);
            this.btnWed.Name = "btnWed";
            this.btnWed.Size = new System.Drawing.Size(100, 53);
            this.btnWed.TabIndex = 2;
            this.btnWed.Text = "Thứ 4";
            this.btnWed.UseVisualStyleBackColor = true;
            // 
            // btnTue
            // 
            this.btnTue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTue.Location = new System.Drawing.Point(200, 4);
            this.btnTue.Margin = new System.Windows.Forms.Padding(4);
            this.btnTue.Name = "btnTue";
            this.btnTue.Size = new System.Drawing.Size(100, 53);
            this.btnTue.TabIndex = 1;
            this.btnTue.Text = "Thứ 3";
            this.btnTue.UseVisualStyleBackColor = true;
            // 
            // cmdToDay
            // 
            this.cmdToDay.Location = new System.Drawing.Point(828, 8);
            this.cmdToDay.Margin = new System.Windows.Forms.Padding(4);
            this.cmdToDay.Name = "cmdToDay";
            this.cmdToDay.Size = new System.Drawing.Size(100, 28);
            this.cmdToDay.TabIndex = 1;
            this.cmdToDay.Text = "Hôm nay";
            this.cmdToDay.UseVisualStyleBackColor = true;
            // 
            // dtpkDate
            // 
            this.dtpkDate.Location = new System.Drawing.Point(552, 13);
            this.dtpkDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(268, 22);
            this.dtpkDate.TabIndex = 0;
            // 
            // nmNotify
            // 
            this.nmNotify.Enabled = false;
            this.nmNotify.Location = new System.Drawing.Point(128, 14);
            this.nmNotify.Margin = new System.Windows.Forms.Padding(4);
            this.nmNotify.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmNotify.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmNotify.Name = "nmNotify";
            this.nmNotify.Size = new System.Drawing.Size(64, 22);
            this.nmNotify.TabIndex = 1;
            this.nmNotify.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ckbTB
            // 
            this.ckbTB.AutoSize = true;
            this.ckbTB.Location = new System.Drawing.Point(16, 14);
            this.ckbTB.Margin = new System.Windows.Forms.Padding(4);
            this.ckbTB.Name = "ckbTB";
            this.ckbTB.Size = new System.Drawing.Size(99, 21);
            this.ckbTB.TabIndex = 0;
            this.ckbTB.Text = "Thông báo";
            this.ckbTB.UseVisualStyleBackColor = true;
            // 
            // btnMon
            // 
            this.btnMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMon.Location = new System.Drawing.Point(92, 4);
            this.btnMon.Margin = new System.Windows.Forms.Padding(4);
            this.btnMon.Name = "btnMon";
            this.btnMon.Size = new System.Drawing.Size(100, 53);
            this.btnMon.TabIndex = 0;
            this.btnMon.Text = "Thứ 2";
            this.btnMon.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.nmNotify);
            this.panel5.Controls.Add(this.ckbTB);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(268, 46);
            this.panel5.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phút";
            // 
            // pnlMatrixDay
            // 
            this.pnlMatrixDay.Location = new System.Drawing.Point(96, 77);
            this.pnlMatrixDay.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMatrixDay.Name = "pnlMatrixDay";
            this.pnlMatrixDay.Size = new System.Drawing.Size(752, 374);
            this.pnlMatrixDay.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmpPreMonth);
            this.panel4.Controls.Add(this.cmpNextMonth);
            this.panel4.Controls.Add(this.btnThur);
            this.panel4.Controls.Add(this.btnSun);
            this.panel4.Controls.Add(this.btnSat);
            this.panel4.Controls.Add(this.btnFri);
            this.panel4.Controls.Add(this.btnWed);
            this.panel4.Controls.Add(this.btnTue);
            this.panel4.Controls.Add(this.btnMon);
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(939, 65);
            this.panel4.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.pnlMatrixDay);
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 483);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 518);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.cmdToDay);
            this.panel3.Controls.Add(this.dtpkDate);
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(939, 46);
            this.panel3.TabIndex = 1;
            // 
            // CalendarDOWForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 547);
            this.Controls.Add(this.panel1);
            this.Name = "CalendarDOWForm";
            ((System.ComponentModel.ISupportInitialize)(this.nmNotify)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer tmNotify;
        private System.Windows.Forms.Button cmpPreMonth;
        private System.Windows.Forms.Button cmpNextMonth;
        private System.Windows.Forms.Button btnThur;
        private System.Windows.Forms.Button btnSun;
        private System.Windows.Forms.Button btnSat;
        private System.Windows.Forms.Button btnFri;
        private System.Windows.Forms.Button btnWed;
        private System.Windows.Forms.Button btnTue;
        private System.Windows.Forms.Button cmdToDay;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.NumericUpDown nmNotify;
        private System.Windows.Forms.CheckBox ckbTB;
        private System.Windows.Forms.Button btnMon;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMatrixDay;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
    }
}