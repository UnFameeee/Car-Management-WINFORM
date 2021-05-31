
namespace Care_Management_and_Private_Parking
{
    partial class BreachOfContract
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
            this.btnHeader = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnRenter = new Guna.UI2.WinForms.Guna2Button();
            this.btnLessor = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnHeader
            // 
            this.btnHeader.CheckedState.Parent = this.btnHeader;
            this.btnHeader.CustomImages.Parent = this.btnHeader;
            this.btnHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(9)))), ((int)(((byte)(121)))));
            this.btnHeader.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnHeader.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeader.ForeColor = System.Drawing.Color.White;
            this.btnHeader.HoverState.Parent = this.btnHeader;
            this.btnHeader.Location = new System.Drawing.Point(33, 12);
            this.btnHeader.Name = "btnHeader";
            this.btnHeader.ShadowDecoration.Parent = this.btnHeader;
            this.btnHeader.Size = new System.Drawing.Size(262, 38);
            this.btnHeader.TabIndex = 49;
            this.btnHeader.Text = "BREACH OF CONTRACT";
            // 
            // btnRenter
            // 
            this.btnRenter.BackColor = System.Drawing.Color.Transparent;
            this.btnRenter.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnRenter.BorderRadius = 17;
            this.btnRenter.BorderThickness = 1;
            this.btnRenter.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnRenter.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnRenter.CheckedState.Parent = this.btnRenter;
            this.btnRenter.CustomImages.Parent = this.btnRenter;
            this.btnRenter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.btnRenter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenter.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnRenter.HoverState.Parent = this.btnRenter;
            this.btnRenter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRenter.Location = new System.Drawing.Point(33, 93);
            this.btnRenter.Name = "btnRenter";
            this.btnRenter.ShadowDecoration.Parent = this.btnRenter;
            this.btnRenter.Size = new System.Drawing.Size(106, 33);
            this.btnRenter.TabIndex = 77;
            this.btnRenter.Text = "Renter";
            this.btnRenter.UseTransparentBackground = true;
            this.btnRenter.Click += new System.EventHandler(this.btnRenter_Click);
            // 
            // btnLessor
            // 
            this.btnLessor.BackColor = System.Drawing.Color.Transparent;
            this.btnLessor.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnLessor.BorderRadius = 17;
            this.btnLessor.BorderThickness = 1;
            this.btnLessor.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnLessor.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnLessor.CheckedState.Parent = this.btnLessor;
            this.btnLessor.CustomImages.Parent = this.btnLessor;
            this.btnLessor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.btnLessor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLessor.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnLessor.HoverState.Parent = this.btnLessor;
            this.btnLessor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLessor.Location = new System.Drawing.Point(189, 93);
            this.btnLessor.Name = "btnLessor";
            this.btnLessor.ShadowDecoration.Parent = this.btnLessor;
            this.btnLessor.Size = new System.Drawing.Size(106, 33);
            this.btnLessor.TabIndex = 76;
            this.btnLessor.Text = "Lessor";
            this.btnLessor.UseTransparentBackground = true;
            this.btnLessor.Click += new System.EventHandler(this.btnLessor_Click);
            // 
            // BreachOfContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(330, 146);
            this.Controls.Add(this.btnRenter);
            this.Controls.Add(this.btnLessor);
            this.Controls.Add(this.btnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BreachOfContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BreachOfContract";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnHeader;
        private Guna.UI2.WinForms.Guna2Button btnRenter;
        private Guna.UI2.WinForms.Guna2Button btnLessor;
    }
}