
namespace Care_Management_and_Private_Parking
{
    partial class ManageForm
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
            this.pnMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnEmpList = new Guna.UI2.WinForms.Guna2Button();
            this.pnData = new Guna.UI2.WinForms.Guna2Panel();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BorderRadius = 22;
            this.pnMenu.BorderThickness = 1;
            this.pnMenu.Controls.Add(this.btnEmpList);
            this.pnMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.pnMenu.Location = new System.Drawing.Point(12, 12);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.ShadowDecoration.Parent = this.pnMenu;
            this.pnMenu.Size = new System.Drawing.Size(131, 712);
            this.pnMenu.TabIndex = 0;
            // 
            // btnEmpList
            // 
            this.btnEmpList.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpList.BorderRadius = 22;
            this.btnEmpList.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnEmpList.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnEmpList.CheckedState.Parent = this.btnEmpList;
            this.btnEmpList.CustomImages.Parent = this.btnEmpList;
            this.btnEmpList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.btnEmpList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.btnEmpList.HoverState.Parent = this.btnEmpList;
            this.btnEmpList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmpList.Location = new System.Drawing.Point(10, 34);
            this.btnEmpList.Name = "btnEmpList";
            this.btnEmpList.ShadowDecoration.Parent = this.btnEmpList;
            this.btnEmpList.Size = new System.Drawing.Size(111, 35);
            this.btnEmpList.TabIndex = 1;
            this.btnEmpList.Text = "EmployeeList";
            this.btnEmpList.UseTransparentBackground = true;
            this.btnEmpList.Click += new System.EventHandler(this.btnEmpList_Click);
            // 
            // pnData
            // 
            this.pnData.BorderRadius = 22;
            this.pnData.BorderThickness = 1;
            this.pnData.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.pnData.Location = new System.Drawing.Point(149, 12);
            this.pnData.Name = "pnData";
            this.pnData.ShadowDecoration.Parent = this.pnData;
            this.pnData.Size = new System.Drawing.Size(933, 712);
            this.pnData.TabIndex = 1;
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1094, 736);
            this.Controls.Add(this.pnData);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnMenu;
        private Guna.UI2.WinForms.Guna2Panel pnData;
        private Guna.UI2.WinForms.Guna2Button btnEmpList;
    }
}