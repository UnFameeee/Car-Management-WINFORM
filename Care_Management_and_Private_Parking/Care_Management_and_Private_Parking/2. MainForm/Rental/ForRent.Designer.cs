
namespace Care_Management_and_Private_Parking
{
    partial class ForRent
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
            this.label16 = new System.Windows.Forms.Label();
            this.labelHeader = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbboxTypeVeh = new Guna.UI.WinForms.GunaComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVehicleID = new System.Windows.Forms.TextBox();
            this.tbLicense = new System.Windows.Forms.TextBox();
            this.VehiclePic = new System.Windows.Forms.PictureBox();
            this.btnAddVeh = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnCalendar = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlVeh = new System.Windows.Forms.Panel();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehiclePic)).BeginInit();
            this.pnCalendar.SuspendLayout();
            this.pnlVeh.SuspendLayout();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.label16.Location = new System.Drawing.Point(183, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 28);
            this.label16.TabIndex = 31;
            this.label16.Text = "Vehicle";
            // 
            // labelHeader
            // 
            this.labelHeader.CheckedState.Parent = this.labelHeader;
            this.labelHeader.CustomImages.Parent = this.labelHeader;
            this.labelHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(9)))), ((int)(((byte)(121)))));
            this.labelHeader.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.HoverState.Parent = this.labelHeader;
            this.labelHeader.Location = new System.Drawing.Point(113, 3);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.ShadowDecoration.Parent = this.labelHeader;
            this.labelHeader.Size = new System.Drawing.Size(259, 27);
            this.labelHeader.TabIndex = 41;
            this.labelHeader.Text = "ADD RENTAL VEHICLE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.cbboxTypeVeh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbVehicleID);
            this.panel1.Controls.Add(this.tbLicense);
            this.panel1.Location = new System.Drawing.Point(10, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 110);
            this.panel1.TabIndex = 67;
            // 
            // cbboxTypeVeh
            // 
            this.cbboxTypeVeh.BackColor = System.Drawing.Color.Transparent;
            this.cbboxTypeVeh.BaseColor = System.Drawing.Color.Transparent;
            this.cbboxTypeVeh.BorderColor = System.Drawing.Color.White;
            this.cbboxTypeVeh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbboxTypeVeh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxTypeVeh.FocusedColor = System.Drawing.Color.Empty;
            this.cbboxTypeVeh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbboxTypeVeh.ForeColor = System.Drawing.Color.Gray;
            this.cbboxTypeVeh.FormattingEnabled = true;
            this.cbboxTypeVeh.Items.AddRange(new object[] {
            "bicycle",
            "bike",
            "car"});
            this.cbboxTypeVeh.Location = new System.Drawing.Point(112, 41);
            this.cbboxTypeVeh.Name = "cbboxTypeVeh";
            this.cbboxTypeVeh.OnHoverItemBaseColor = System.Drawing.Color.Transparent;
            this.cbboxTypeVeh.OnHoverItemForeColor = System.Drawing.Color.Gray;
            this.cbboxTypeVeh.Size = new System.Drawing.Size(162, 26);
            this.cbboxTypeVeh.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "VehicleID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "License Plate:";
            // 
            // tbVehicleID
            // 
            this.tbVehicleID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tbVehicleID.Enabled = false;
            this.tbVehicleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVehicleID.ForeColor = System.Drawing.Color.White;
            this.tbVehicleID.Location = new System.Drawing.Point(112, 12);
            this.tbVehicleID.Name = "tbVehicleID";
            this.tbVehicleID.Size = new System.Drawing.Size(162, 23);
            this.tbVehicleID.TabIndex = 27;
            // 
            // tbLicense
            // 
            this.tbLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tbLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLicense.ForeColor = System.Drawing.Color.White;
            this.tbLicense.Location = new System.Drawing.Point(112, 73);
            this.tbLicense.Name = "tbLicense";
            this.tbLicense.Size = new System.Drawing.Size(162, 23);
            this.tbLicense.TabIndex = 29;
            // 
            // VehiclePic
            // 
            this.VehiclePic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.VehiclePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VehiclePic.Location = new System.Drawing.Point(307, 6);
            this.VehiclePic.Name = "VehiclePic";
            this.VehiclePic.Size = new System.Drawing.Size(150, 150);
            this.VehiclePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VehiclePic.TabIndex = 68;
            this.VehiclePic.TabStop = false;
            this.toolTip1.SetToolTip(this.VehiclePic, "Doubleclick to upload Vehicle Picture");
            this.VehiclePic.DoubleClick += new System.EventHandler(this.VehiclePic_DoubleClick);
            // 
            // btnAddVeh
            // 
            this.btnAddVeh.BackColor = System.Drawing.Color.Transparent;
            this.btnAddVeh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAddVeh.BorderRadius = 17;
            this.btnAddVeh.BorderThickness = 1;
            this.btnAddVeh.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnAddVeh.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnAddVeh.CheckedState.Parent = this.btnAddVeh;
            this.btnAddVeh.CustomImages.Parent = this.btnAddVeh;
            this.btnAddVeh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.btnAddVeh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVeh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAddVeh.HoverState.Parent = this.btnAddVeh;
            this.btnAddVeh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddVeh.Location = new System.Drawing.Point(191, 224);
            this.btnAddVeh.Name = "btnAddVeh";
            this.btnAddVeh.ShadowDecoration.Parent = this.btnAddVeh;
            this.btnAddVeh.Size = new System.Drawing.Size(106, 33);
            this.btnAddVeh.TabIndex = 71;
            this.btnAddVeh.Text = "Add";
            this.btnAddVeh.UseTransparentBackground = true;
            this.btnAddVeh.Click += new System.EventHandler(this.btnAddVeh_Click);
            // 
            // btnExit
            // 
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BaseColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderColor = System.Drawing.Color.Gray;
            this.btnExit.BorderSize = 3;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Image = null;
            this.btnExit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExit.Location = new System.Drawing.Point(473, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 66;
            this.btnExit.Text = "X";
            this.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnCalendar
            // 
            this.pnCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.pnCalendar.BorderRadius = 22;
            this.pnCalendar.BorderThickness = 1;
            this.pnCalendar.Controls.Add(this.btnRemove);
            this.pnCalendar.Controls.Add(this.btnEdit);
            this.pnCalendar.Controls.Add(this.pnlVeh);
            this.pnCalendar.Controls.Add(this.btnAddVeh);
            this.pnCalendar.Controls.Add(this.btnExit);
            this.pnCalendar.Controls.Add(this.labelHeader);
            this.pnCalendar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.pnCalendar.Location = new System.Drawing.Point(12, 13);
            this.pnCalendar.Name = "pnCalendar";
            this.pnCalendar.ShadowDecoration.Parent = this.pnCalendar;
            this.pnCalendar.Size = new System.Drawing.Size(501, 270);
            this.pnCalendar.TabIndex = 6;
            // 
            // pnlVeh
            // 
            this.pnlVeh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.pnlVeh.Controls.Add(this.label16);
            this.pnlVeh.Controls.Add(this.panel1);
            this.pnlVeh.Controls.Add(this.VehiclePic);
            this.pnlVeh.Location = new System.Drawing.Point(20, 44);
            this.pnlVeh.Name = "pnlVeh";
            this.pnlVeh.Size = new System.Drawing.Size(463, 164);
            this.pnlVeh.TabIndex = 71;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnEdit.BorderRadius = 17;
            this.btnEdit.BorderThickness = 1;
            this.btnEdit.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnEdit.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEdit.Location = new System.Drawing.Point(191, 224);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(106, 33);
            this.btnEdit.TabIndex = 72;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseTransparentBackground = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnRemove.BorderRadius = 17;
            this.btnRemove.BorderThickness = 1;
            this.btnRemove.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnRemove.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnRemove.CheckedState.Parent = this.btnRemove;
            this.btnRemove.CustomImages.Parent = this.btnRemove;
            this.btnRemove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnRemove.HoverState.Parent = this.btnRemove;
            this.btnRemove.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRemove.Location = new System.Drawing.Point(191, 224);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ShadowDecoration.Parent = this.btnRemove;
            this.btnRemove.Size = new System.Drawing.Size(106, 33);
            this.btnRemove.TabIndex = 73;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseTransparentBackground = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ForRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(525, 300);
            this.Controls.Add(this.pnCalendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForRent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForRent";
            this.Load += new System.EventHandler(this.ForRent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehiclePic)).EndInit();
            this.pnCalendar.ResumeLayout(false);
            this.pnlVeh.ResumeLayout(false);
            this.pnlVeh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label16;
        public Guna.UI2.WinForms.Guna2GradientButton labelHeader;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbVehicleID;
        public System.Windows.Forms.TextBox tbLicense;
        public System.Windows.Forms.PictureBox VehiclePic;
        public System.Windows.Forms.ToolTip toolTip1;
        public Guna.UI2.WinForms.Guna2Button btnAddVeh;
        public Guna.UI.WinForms.GunaButton btnExit;
        public Guna.UI2.WinForms.Guna2Panel pnCalendar;
        public System.Windows.Forms.Panel pnlVeh;
        public Guna.UI.WinForms.GunaComboBox cbboxTypeVeh;
        public Guna.UI2.WinForms.Guna2Button btnEdit;
        public Guna.UI2.WinForms.Guna2Button btnRemove;
    }
}