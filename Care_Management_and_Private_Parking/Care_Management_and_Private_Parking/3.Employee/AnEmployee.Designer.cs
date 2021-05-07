
namespace Care_Management_and_Private_Parking
{
    partial class AnEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.lbJobID = new Guna.UI.WinForms.GunaLabel();
            this.lbIdentity = new Guna.UI.WinForms.GunaLabel();
            this.lbPhone = new Guna.UI.WinForms.GunaLabel();
            this.lbGender = new Guna.UI.WinForms.GunaLabel();
            this.lbFullName = new Guna.UI.WinForms.GunaLabel();
            this.lbEmpID = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.lbJobID);
            this.gunaLinePanel1.Controls.Add(this.lbIdentity);
            this.gunaLinePanel1.Controls.Add(this.lbPhone);
            this.gunaLinePanel1.Controls.Add(this.lbGender);
            this.gunaLinePanel1.Controls.Add(this.lbFullName);
            this.gunaLinePanel1.Controls.Add(this.lbEmpID);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(697, 44);
            this.gunaLinePanel1.TabIndex = 1;
            // 
            // lbJobID
            // 
            this.lbJobID.AutoSize = true;
            this.lbJobID.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lbJobID.ForeColor = System.Drawing.Color.Gray;
            this.lbJobID.Location = new System.Drawing.Point(562, 13);
            this.lbJobID.Name = "lbJobID";
            this.lbJobID.Size = new System.Drawing.Size(39, 15);
            this.lbJobID.TabIndex = 11;
            this.lbJobID.Text = "JobID";
            // 
            // lbIdentity
            // 
            this.lbIdentity.AutoSize = true;
            this.lbIdentity.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lbIdentity.ForeColor = System.Drawing.Color.Gray;
            this.lbIdentity.Location = new System.Drawing.Point(421, 13);
            this.lbIdentity.Name = "lbIdentity";
            this.lbIdentity.Size = new System.Drawing.Size(48, 15);
            this.lbIdentity.TabIndex = 10;
            this.lbIdentity.Text = "Identity";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lbPhone.ForeColor = System.Drawing.Color.Gray;
            this.lbPhone.Location = new System.Drawing.Point(314, 13);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(41, 15);
            this.lbPhone.TabIndex = 9;
            this.lbPhone.Text = "Phone";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lbGender.ForeColor = System.Drawing.Color.Gray;
            this.lbGender.Location = new System.Drawing.Point(226, 13);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(45, 15);
            this.lbGender.TabIndex = 8;
            this.lbGender.Text = "Gender";
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.BackColor = System.Drawing.Color.Transparent;
            this.lbFullName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lbFullName.ForeColor = System.Drawing.Color.Gray;
            this.lbFullName.Location = new System.Drawing.Point(94, 13);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(58, 15);
            this.lbFullName.TabIndex = 7;
            this.lbFullName.Text = "FullName";
            // 
            // lbEmpID
            // 
            this.lbEmpID.AutoSize = true;
            this.lbEmpID.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lbEmpID.ForeColor = System.Drawing.Color.Gray;
            this.lbEmpID.Location = new System.Drawing.Point(18, 13);
            this.lbEmpID.Name = "lbEmpID";
            this.lbEmpID.Size = new System.Drawing.Size(44, 15);
            this.lbEmpID.TabIndex = 6;
            this.lbEmpID.Text = "EmpID";
            // 
            // AnEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gunaLinePanel1);
            this.Name = "AnEmployee";
            this.Size = new System.Drawing.Size(697, 44);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        public Guna.UI.WinForms.GunaLabel lbJobID;
        public Guna.UI.WinForms.GunaLabel lbIdentity;
        public Guna.UI.WinForms.GunaLabel lbPhone;
        public Guna.UI.WinForms.GunaLabel lbGender;
        public Guna.UI.WinForms.GunaLabel lbFullName;
        public Guna.UI.WinForms.GunaLabel lbEmpID;
    }
}
