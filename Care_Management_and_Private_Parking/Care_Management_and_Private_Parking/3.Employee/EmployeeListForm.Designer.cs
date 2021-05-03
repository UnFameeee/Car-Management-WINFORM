
namespace Care_Management_and_Private_Parking
{
    partial class EmployeeListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeListForm));
            this.pnSearch = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.pnEmp = new Guna.UI.WinForms.GunaShadowPanel();
            this.fpnEmpList = new System.Windows.Forms.FlowLayoutPanel();
            this.pnHeader = new Guna.UI.WinForms.GunaLinePanel();
            this.lbJobID = new Guna.UI.WinForms.GunaLabel();
            this.lbIdentity = new Guna.UI.WinForms.GunaLabel();
            this.lbPhone = new Guna.UI.WinForms.GunaLabel();
            this.lbGender = new Guna.UI.WinForms.GunaLabel();
            this.lbFullName = new Guna.UI.WinForms.GunaLabel();
            this.lbEmpID = new Guna.UI.WinForms.GunaLabel();
            this.pnSearch.SuspendLayout();
            this.pnEmp.SuspendLayout();
            this.fpnEmpList.SuspendLayout();
            this.pnHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSearch
            // 
            this.pnSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnSearch.BaseColor = System.Drawing.Color.Transparent;
            this.pnSearch.Controls.Add(this.gunaCircleButton1);
            this.pnSearch.Location = new System.Drawing.Point(12, 27);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Padding = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.pnSearch.Radius = 16;
            this.pnSearch.ShadowColor = System.Drawing.Color.Black;
            this.pnSearch.ShadowDepth = 40;
            this.pnSearch.ShadowShift = 3;
            this.pnSearch.Size = new System.Drawing.Size(625, 39);
            this.pnSearch.TabIndex = 0;
            // 
            // gunaCircleButton1
            // 
            this.gunaCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton1.AnimationSpeed = 0.03F;
            this.gunaCircleButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton1.BaseColor = System.Drawing.Color.Silver;
            this.gunaCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton1.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCircleButton1.Image")));
            this.gunaCircleButton1.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaCircleButton1.Location = new System.Drawing.Point(3, 1);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.OnHoverImage = null;
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Size = new System.Drawing.Size(37, 36);
            this.gunaCircleButton1.TabIndex = 1;
            // 
            // pnEmp
            // 
            this.pnEmp.BackColor = System.Drawing.Color.Transparent;
            this.pnEmp.BaseColor = System.Drawing.Color.Transparent;
            this.pnEmp.Controls.Add(this.fpnEmpList);
            this.pnEmp.Location = new System.Drawing.Point(12, 119);
            this.pnEmp.Name = "pnEmp";
            this.pnEmp.Padding = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.pnEmp.Radius = 16;
            this.pnEmp.ShadowColor = System.Drawing.Color.Black;
            this.pnEmp.ShadowDepth = 40;
            this.pnEmp.ShadowShift = 3;
            this.pnEmp.Size = new System.Drawing.Size(625, 397);
            this.pnEmp.TabIndex = 1;
            // 
            // fpnEmpList
            // 
            this.fpnEmpList.Controls.Add(this.pnHeader);
            this.fpnEmpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnEmpList.Location = new System.Drawing.Point(3, 1);
            this.fpnEmpList.Name = "fpnEmpList";
            this.fpnEmpList.Size = new System.Drawing.Size(619, 394);
            this.fpnEmpList.TabIndex = 0;
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.pnHeader.Controls.Add(this.lbJobID);
            this.pnHeader.Controls.Add(this.lbIdentity);
            this.pnHeader.Controls.Add(this.lbPhone);
            this.pnHeader.Controls.Add(this.lbGender);
            this.pnHeader.Controls.Add(this.lbFullName);
            this.pnHeader.Controls.Add(this.lbEmpID);
            this.pnHeader.ForeColor = System.Drawing.Color.Black;
            this.pnHeader.LineColor = System.Drawing.Color.Black;
            this.pnHeader.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.pnHeader.Location = new System.Drawing.Point(3, 3);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(616, 44);
            this.pnHeader.TabIndex = 0;
            // 
            // lbJobID
            // 
            this.lbJobID.AutoSize = true;
            this.lbJobID.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbJobID.ForeColor = System.Drawing.Color.Black;
            this.lbJobID.Location = new System.Drawing.Point(553, 12);
            this.lbJobID.Name = "lbJobID";
            this.lbJobID.Size = new System.Drawing.Size(45, 19);
            this.lbJobID.TabIndex = 17;
            this.lbJobID.Text = "JobID";
            // 
            // lbIdentity
            // 
            this.lbIdentity.AutoSize = true;
            this.lbIdentity.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lbIdentity.ForeColor = System.Drawing.Color.Black;
            this.lbIdentity.Location = new System.Drawing.Point(442, 12);
            this.lbIdentity.Name = "lbIdentity";
            this.lbIdentity.Size = new System.Drawing.Size(57, 19);
            this.lbIdentity.TabIndex = 16;
            this.lbIdentity.Text = "Identity";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbPhone.ForeColor = System.Drawing.Color.Black;
            this.lbPhone.Location = new System.Drawing.Point(328, 12);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(48, 19);
            this.lbPhone.TabIndex = 15;
            this.lbPhone.Text = "Phone";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbGender.ForeColor = System.Drawing.Color.Black;
            this.lbGender.Location = new System.Drawing.Point(222, 12);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(54, 19);
            this.lbGender.TabIndex = 14;
            this.lbGender.Text = "Gender";
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbFullName.ForeColor = System.Drawing.Color.Black;
            this.lbFullName.Location = new System.Drawing.Point(103, 12);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(69, 19);
            this.lbFullName.TabIndex = 13;
            this.lbFullName.Text = "FullName";
            // 
            // lbEmpID
            // 
            this.lbEmpID.AutoSize = true;
            this.lbEmpID.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbEmpID.ForeColor = System.Drawing.Color.Black;
            this.lbEmpID.Location = new System.Drawing.Point(13, 12);
            this.lbEmpID.Name = "lbEmpID";
            this.lbEmpID.Size = new System.Drawing.Size(50, 19);
            this.lbEmpID.TabIndex = 12;
            this.lbEmpID.Text = "EmpID";
            // 
            // EmployeeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(649, 535);
            this.Controls.Add(this.pnEmp);
            this.Controls.Add(this.pnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmployeeListForm";
            this.Load += new System.EventHandler(this.EmployeeListForm_Load);
            this.pnSearch.ResumeLayout(false);
            this.pnEmp.ResumeLayout(false);
            this.fpnEmpList.ResumeLayout(false);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel pnSearch;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
        private Guna.UI.WinForms.GunaShadowPanel pnEmp;
        public Guna.UI.WinForms.GunaLabel lbJobID;
        public Guna.UI.WinForms.GunaLabel lbIdentity;
        public Guna.UI.WinForms.GunaLabel lbPhone;
        public Guna.UI.WinForms.GunaLabel lbGender;
        public Guna.UI.WinForms.GunaLabel lbFullName;
        public Guna.UI.WinForms.GunaLabel lbEmpID;
        private System.Windows.Forms.FlowLayoutPanel flpEmpList;
        private Guna.UI.WinForms.GunaLinePanel pnHeader;
        private System.Windows.Forms.FlowLayoutPanel fpnEmpList;
    }
}