
namespace Care_Management_and_Private_Parking
{
    partial class Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.pnData = new Guna.UI2.WinForms.Guna2Panel();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.lbService = new System.Windows.Forms.Label();
            this.lbTimeRegister = new System.Windows.Forms.Label();
            this.lbDateRegister = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnData.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnData
            // 
            this.pnData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.pnData.BorderRadius = 22;
            this.pnData.BorderThickness = 1;
            this.pnData.Controls.Add(this.btnExit);
            this.pnData.Controls.Add(this.lbService);
            this.pnData.Controls.Add(this.lbTimeRegister);
            this.pnData.Controls.Add(this.lbDateRegister);
            this.pnData.Controls.Add(this.btnLogin);
            this.pnData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnData.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.pnData.Location = new System.Drawing.Point(0, 0);
            this.pnData.Name = "pnData";
            this.pnData.ShadowDecoration.Parent = this.pnData;
            this.pnData.Size = new System.Drawing.Size(367, 326);
            this.pnData.TabIndex = 2;
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
            this.btnExit.Location = new System.Drawing.Point(342, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 67;
            this.btnExit.Text = "X";
            this.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbService
            // 
            this.lbService.AutoSize = true;
            this.lbService.BackColor = System.Drawing.Color.Transparent;
            this.lbService.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbService.ForeColor = System.Drawing.Color.White;
            this.lbService.Location = new System.Drawing.Point(52, 233);
            this.lbService.Name = "lbService";
            this.lbService.Size = new System.Drawing.Size(52, 21);
            this.lbService.TabIndex = 42;
            this.lbService.Text = "label3";
            // 
            // lbTimeRegister
            // 
            this.lbTimeRegister.AutoSize = true;
            this.lbTimeRegister.BackColor = System.Drawing.Color.Transparent;
            this.lbTimeRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeRegister.ForeColor = System.Drawing.Color.White;
            this.lbTimeRegister.Location = new System.Drawing.Point(52, 167);
            this.lbTimeRegister.Name = "lbTimeRegister";
            this.lbTimeRegister.Size = new System.Drawing.Size(52, 21);
            this.lbTimeRegister.TabIndex = 41;
            this.lbTimeRegister.Text = "label2";
            // 
            // lbDateRegister
            // 
            this.lbDateRegister.AutoSize = true;
            this.lbDateRegister.BackColor = System.Drawing.Color.Transparent;
            this.lbDateRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateRegister.ForeColor = System.Drawing.Color.White;
            this.lbDateRegister.Location = new System.Drawing.Point(52, 107);
            this.lbDateRegister.Name = "lbDateRegister";
            this.lbDateRegister.Size = new System.Drawing.Size(52, 21);
            this.lbDateRegister.TabIndex = 40;
            this.lbDateRegister.Text = "label1";
            // 
            // btnLogin
            // 
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(9)))), ((int)(((byte)(121)))));
            this.btnLogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(98, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(156, 38);
            this.btnLogin.TabIndex = 39;
            this.btnLogin.Text = "INVOICE";
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 326);
            this.Controls.Add(this.pnData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            this.pnData.ResumeLayout(false);
            this.pnData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnData;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
        private System.Windows.Forms.Label lbService;
        private System.Windows.Forms.Label lbTimeRegister;
        private System.Windows.Forms.Label lbDateRegister;
        private Guna.UI.WinForms.GunaButton btnExit;
    }
}