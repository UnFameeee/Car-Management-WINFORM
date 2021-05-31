
namespace Care_Management_and_Private_Parking
{
    partial class Statistic
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRevenue = new Guna.UI2.WinForms.Guna2Button();
            this.btnSalaryEmp = new Guna.UI2.WinForms.Guna2Button();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(157, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(913, 712);
            this.pnlMain.TabIndex = 12;
            // 
            // pnMenu
            // 
            this.pnMenu.BorderRadius = 22;
            this.pnMenu.BorderThickness = 1;
            this.pnMenu.Controls.Add(this.btnRevenue);
            this.pnMenu.Controls.Add(this.btnSalaryEmp);
            this.pnMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.pnMenu.Location = new System.Drawing.Point(13, 116);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.ShadowDecoration.Parent = this.pnMenu;
            this.pnMenu.Size = new System.Drawing.Size(131, 493);
            this.pnMenu.TabIndex = 11;
            // 
            // btnRevenue
            // 
            this.btnRevenue.BackColor = System.Drawing.Color.Transparent;
            this.btnRevenue.BorderRadius = 22;
            this.btnRevenue.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnRevenue.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnRevenue.CheckedState.Parent = this.btnRevenue;
            this.btnRevenue.CustomImages.Parent = this.btnRevenue;
            this.btnRevenue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnRevenue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.btnRevenue.HoverState.Parent = this.btnRevenue;
            this.btnRevenue.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRevenue.Location = new System.Drawing.Point(7, 302);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.ShadowDecoration.Parent = this.btnRevenue;
            this.btnRevenue.Size = new System.Drawing.Size(113, 43);
            this.btnRevenue.TabIndex = 6;
            this.btnRevenue.Text = "Revenue";
            this.btnRevenue.UseTransparentBackground = true;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // btnSalaryEmp
            // 
            this.btnSalaryEmp.BackColor = System.Drawing.Color.Transparent;
            this.btnSalaryEmp.BorderRadius = 22;
            this.btnSalaryEmp.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnSalaryEmp.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnSalaryEmp.CheckedState.Parent = this.btnSalaryEmp;
            this.btnSalaryEmp.CustomImages.Parent = this.btnSalaryEmp;
            this.btnSalaryEmp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnSalaryEmp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalaryEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.btnSalaryEmp.HoverState.Parent = this.btnSalaryEmp;
            this.btnSalaryEmp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSalaryEmp.Location = new System.Drawing.Point(7, 158);
            this.btnSalaryEmp.Name = "btnSalaryEmp";
            this.btnSalaryEmp.ShadowDecoration.Parent = this.btnSalaryEmp;
            this.btnSalaryEmp.Size = new System.Drawing.Size(113, 43);
            this.btnSalaryEmp.TabIndex = 7;
            this.btnSalaryEmp.Text = "Salary Employee";
            this.btnSalaryEmp.UseTransparentBackground = true;
            this.btnSalaryEmp.Click += new System.EventHandler(this.btnSalaryEmp_Click);
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1082, 736);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Statistic";
            this.Text = "Statistic";
            this.Load += new System.EventHandler(this.Statistic_Load);
            this.pnMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private Guna.UI2.WinForms.Guna2Panel pnMenu;
        private Guna.UI2.WinForms.Guna2Button btnRevenue;
        private Guna.UI2.WinForms.Guna2Button btnSalaryEmp;
    }
}