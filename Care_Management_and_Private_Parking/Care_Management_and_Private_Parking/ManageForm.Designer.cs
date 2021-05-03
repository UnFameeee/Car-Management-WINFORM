
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEmp = new Guna.UI2.WinForms.Guna2Button();
            this.pnData = new Guna.UI2.WinForms.Guna2Panel();
            this.pnMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BorderRadius = 22;
            this.pnMenu.BorderThickness = 1;
            this.pnMenu.Controls.Add(this.panel1);
            this.pnMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.pnMenu.Location = new System.Drawing.Point(12, 12);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.ShadowDecoration.Parent = this.pnMenu;
            this.pnMenu.Size = new System.Drawing.Size(198, 712);
            this.pnMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEmp);
            this.panel1.Location = new System.Drawing.Point(19, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 60);
            this.panel1.TabIndex = 4;
            // 
            // btnEmp
            // 
            this.btnEmp.BackColor = System.Drawing.Color.Transparent;
            this.btnEmp.BorderRadius = 22;
            this.btnEmp.Checked = true;
            this.btnEmp.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnEmp.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnEmp.CheckedState.Parent = this.btnEmp;
            this.btnEmp.CustomImages.Parent = this.btnEmp;
            this.btnEmp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.btnEmp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.btnEmp.HoverState.Parent = this.btnEmp;
            this.btnEmp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmp.Location = new System.Drawing.Point(9, 9);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.ShadowDecoration.Parent = this.btnEmp;
            this.btnEmp.Size = new System.Drawing.Size(137, 43);
            this.btnEmp.TabIndex = 1;
            this.btnEmp.Text = "Employees";
            this.btnEmp.UseTransparentBackground = true;
            this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // pnData
            // 
            this.pnData.BorderRadius = 22;
            this.pnData.BorderThickness = 1;
            this.pnData.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.pnData.Location = new System.Drawing.Point(225, 12);
            this.pnData.Name = "pnData";
            this.pnData.ShadowDecoration.Parent = this.pnData;
            this.pnData.Size = new System.Drawing.Size(845, 712);
            this.pnData.TabIndex = 1;
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1082, 736);
            this.Controls.Add(this.pnData);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageForm";
            this.Text = "ManageForm";
            this.pnMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnMenu;
        private Guna.UI2.WinForms.Guna2Panel pnData;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnEmp;
    }
}