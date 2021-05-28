
namespace Care_Management_and_Private_Parking
{
    partial class GetVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetVehicle));
            this.pnGet = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tbCusID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbIDcard = new System.Windows.Forms.TextBox();
            this.btnGetVeh = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnGet.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnGet
            // 
            this.pnGet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.pnGet.BorderRadius = 22;
            this.pnGet.BorderThickness = 1;
            this.pnGet.Controls.Add(this.btnCancel);
            this.pnGet.Controls.Add(this.guna2Panel1);
            this.pnGet.Controls.Add(this.btnGetVeh);
            this.pnGet.Controls.Add(this.guna2GradientButton2);
            this.pnGet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.pnGet.Location = new System.Drawing.Point(12, 12);
            this.pnGet.Name = "pnGet";
            this.pnGet.ShadowDecoration.Parent = this.pnGet;
            this.pnGet.Size = new System.Drawing.Size(377, 238);
            this.pnGet.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancel.BorderRadius = 17;
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnCancel.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancel.Location = new System.Drawing.Point(60, 186);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(106, 33);
            this.btnCancel.TabIndex = 75;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseTransparentBackground = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.guna2Panel1.Controls.Add(this.tbCusID);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.tbIDcard);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.guna2Panel1.Location = new System.Drawing.Point(21, 62);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(336, 104);
            this.guna2Panel1.TabIndex = 74;
            // 
            // tbCusID
            // 
            this.tbCusID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tbCusID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCusID.ForeColor = System.Drawing.Color.White;
            this.tbCusID.Location = new System.Drawing.Point(134, 56);
            this.tbCusID.Name = "tbCusID";
            this.tbCusID.Size = new System.Drawing.Size(162, 23);
            this.tbCusID.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "CustomerID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(35, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "IDcard:";
            // 
            // tbIDcard
            // 
            this.tbIDcard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tbIDcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDcard.ForeColor = System.Drawing.Color.White;
            this.tbIDcard.Location = new System.Drawing.Point(134, 25);
            this.tbIDcard.Name = "tbIDcard";
            this.tbIDcard.Size = new System.Drawing.Size(162, 23);
            this.tbIDcard.TabIndex = 29;
            this.tbIDcard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIDcard_KeyPress);
            // 
            // btnGetVeh
            // 
            this.btnGetVeh.BackColor = System.Drawing.Color.Transparent;
            this.btnGetVeh.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnGetVeh.BorderRadius = 17;
            this.btnGetVeh.BorderThickness = 1;
            this.btnGetVeh.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnGetVeh.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnGetVeh.CheckedState.Parent = this.btnGetVeh;
            this.btnGetVeh.CustomImages.Parent = this.btnGetVeh;
            this.btnGetVeh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.btnGetVeh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetVeh.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnGetVeh.HoverState.Parent = this.btnGetVeh;
            this.btnGetVeh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGetVeh.Location = new System.Drawing.Point(211, 186);
            this.btnGetVeh.Name = "btnGetVeh";
            this.btnGetVeh.ShadowDecoration.Parent = this.btnGetVeh;
            this.btnGetVeh.Size = new System.Drawing.Size(106, 33);
            this.btnGetVeh.TabIndex = 73;
            this.btnGetVeh.Text = "Get";
            this.btnGetVeh.UseTransparentBackground = true;
            this.btnGetVeh.Click += new System.EventHandler(this.btnGetVeh_Click);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(9)))), ((int)(((byte)(121)))));
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.HoverState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Location = new System.Drawing.Point(112, 7);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(152, 27);
            this.guna2GradientButton2.TabIndex = 41;
            this.guna2GradientButton2.Text = "GET VEHICLE";
            // 
            // GetVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(401, 262);
            this.Controls.Add(this.pnGet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GetVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetVehicle";
            this.pnGet.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnGet;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2Button btnGetVeh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbIDcard;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.TextBox tbCusID;
    }
}