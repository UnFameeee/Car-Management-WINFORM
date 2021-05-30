
namespace Care_Management_and_Private_Parking
{
    partial class CarParkForm
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
            this.btnParkingLot = new Guna.UI2.WinForms.Guna2Button();
            this.btnRentalLot = new Guna.UI2.WinForms.Guna2Button();
            this.pnMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnList = new Guna.UI2.WinForms.Guna2Button();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(157, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(913, 712);
            this.pnlMain.TabIndex = 10;
            // 
            // btnParkingLot
            // 
            this.btnParkingLot.BackColor = System.Drawing.Color.Transparent;
            this.btnParkingLot.BorderRadius = 22;
            this.btnParkingLot.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnParkingLot.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnParkingLot.CheckedState.Parent = this.btnParkingLot;
            this.btnParkingLot.CustomImages.Parent = this.btnParkingLot;
            this.btnParkingLot.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnParkingLot.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParkingLot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.btnParkingLot.HoverState.Parent = this.btnParkingLot;
            this.btnParkingLot.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnParkingLot.Location = new System.Drawing.Point(9, 143);
            this.btnParkingLot.Name = "btnParkingLot";
            this.btnParkingLot.ShadowDecoration.Parent = this.btnParkingLot;
            this.btnParkingLot.Size = new System.Drawing.Size(113, 43);
            this.btnParkingLot.TabIndex = 5;
            this.btnParkingLot.Text = "Parking Lot";
            this.btnParkingLot.UseTransparentBackground = true;
            this.btnParkingLot.Click += new System.EventHandler(this.btnParkingLot_Click);
            // 
            // btnRentalLot
            // 
            this.btnRentalLot.BackColor = System.Drawing.Color.Transparent;
            this.btnRentalLot.BorderRadius = 22;
            this.btnRentalLot.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnRentalLot.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnRentalLot.CheckedState.Parent = this.btnRentalLot;
            this.btnRentalLot.CustomImages.Parent = this.btnRentalLot;
            this.btnRentalLot.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnRentalLot.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentalLot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.btnRentalLot.HoverState.Parent = this.btnRentalLot;
            this.btnRentalLot.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRentalLot.Location = new System.Drawing.Point(9, 233);
            this.btnRentalLot.Name = "btnRentalLot";
            this.btnRentalLot.ShadowDecoration.Parent = this.btnRentalLot;
            this.btnRentalLot.Size = new System.Drawing.Size(113, 43);
            this.btnRentalLot.TabIndex = 7;
            this.btnRentalLot.Text = "Rental lot";
            this.btnRentalLot.UseTransparentBackground = true;
            this.btnRentalLot.Click += new System.EventHandler(this.btnRentalLot_Click);
            // 
            // pnMenu
            // 
            this.pnMenu.BorderRadius = 22;
            this.pnMenu.BorderThickness = 1;
            this.pnMenu.Controls.Add(this.btnList);
            this.pnMenu.Controls.Add(this.btnRentalLot);
            this.pnMenu.Controls.Add(this.btnParkingLot);
            this.pnMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.pnMenu.Location = new System.Drawing.Point(13, 116);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.ShadowDecoration.Parent = this.pnMenu;
            this.pnMenu.Size = new System.Drawing.Size(131, 493);
            this.pnMenu.TabIndex = 9;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Transparent;
            this.btnList.BorderRadius = 22;
            this.btnList.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnList.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnList.CheckedState.Parent = this.btnList;
            this.btnList.CustomImages.Parent = this.btnList;
            this.btnList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.btnList.HoverState.Parent = this.btnList;
            this.btnList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnList.Location = new System.Drawing.Point(9, 322);
            this.btnList.Name = "btnList";
            this.btnList.ShadowDecoration.Parent = this.btnList;
            this.btnList.Size = new System.Drawing.Size(113, 43);
            this.btnList.TabIndex = 6;
            this.btnList.Text = "List";
            this.btnList.UseTransparentBackground = true;
            this.btnList.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // CarParkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1082, 736);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CarParkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CarParkForm";
            this.pnMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private Guna.UI2.WinForms.Guna2Button btnParkingLot;
        private Guna.UI2.WinForms.Guna2Button btnRentalLot;
        private Guna.UI2.WinForms.Guna2Panel pnMenu;
        private Guna.UI2.WinForms.Guna2Button btnList;
    }
}