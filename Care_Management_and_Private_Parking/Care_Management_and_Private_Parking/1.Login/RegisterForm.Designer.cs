
namespace Care_Management_and_Private_Parking
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.lbSignIn = new System.Windows.Forms.Label();
            this.btnRegistation = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.tbIdentityNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCancel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbShow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSignIn
            // 
            this.lbSignIn.AutoSize = true;
            this.lbSignIn.BackColor = System.Drawing.Color.Transparent;
            this.lbSignIn.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignIn.ForeColor = System.Drawing.Color.DimGray;
            this.lbSignIn.Location = new System.Drawing.Point(54, 120);
            this.lbSignIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSignIn.Name = "lbSignIn";
            this.lbSignIn.Size = new System.Drawing.Size(257, 37);
            this.lbSignIn.TabIndex = 24;
            this.lbSignIn.Text = "Create Your Account";
            // 
            // btnRegistation
            // 
            this.btnRegistation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRegistation.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistation.ForeColor = System.Drawing.Color.White;
            this.btnRegistation.Location = new System.Drawing.Point(95, 395);
            this.btnRegistation.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistation.Name = "btnRegistation";
            this.btnRegistation.Size = new System.Drawing.Size(163, 37);
            this.btnRegistation.TabIndex = 22;
            this.btnRegistation.Text = "REGISTATION";
            this.btnRegistation.UseVisualStyleBackColor = false;
            this.btnRegistation.Click += new System.EventHandler(this.btnRegistation_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(38, 239);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(278, 27);
            this.tbPassword.TabIndex = 28;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(38, 183);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(278, 27);
            this.tbUsername.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(34, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(34, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(34, 277);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Confirm Password:";
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmPassword.Location = new System.Drawing.Point(38, 299);
            this.tbConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(278, 27);
            this.tbConfirmPassword.TabIndex = 30;
            this.tbConfirmPassword.UseSystemPasswordChar = true;
            // 
            // tbIdentityNumber
            // 
            this.tbIdentityNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdentityNumber.Location = new System.Drawing.Point(38, 360);
            this.tbIdentityNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbIdentityNumber.Name = "tbIdentityNumber";
            this.tbIdentityNumber.Size = new System.Drawing.Size(278, 27);
            this.tbIdentityNumber.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(34, 338);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Identity Number:";
            // 
            // lbCancel
            // 
            this.lbCancel.AutoSize = true;
            this.lbCancel.BackColor = System.Drawing.Color.Transparent;
            this.lbCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCancel.ForeColor = System.Drawing.Color.DimGray;
            this.lbCancel.Location = new System.Drawing.Point(149, 434);
            this.lbCancel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(56, 21);
            this.lbCancel.TabIndex = 27;
            this.lbCancel.Text = "Cancel";
            this.lbCancel.Click += new System.EventHandler(this.lbCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(134, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lbShow
            // 
            this.lbShow.AutoSize = true;
            this.lbShow.BackColor = System.Drawing.Color.Transparent;
            this.lbShow.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShow.ForeColor = System.Drawing.Color.DimGray;
            this.lbShow.Location = new System.Drawing.Point(271, 217);
            this.lbShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbShow.Name = "lbShow";
            this.lbShow.Size = new System.Drawing.Size(45, 20);
            this.lbShow.TabIndex = 33;
            this.lbShow.Text = "Show";
            this.lbShow.Click += new System.EventHandler(this.lbShow_Click);
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.btnRegistation;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(356, 463);
            this.Controls.Add(this.lbShow);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbCancel);
            this.Controls.Add(this.tbIdentityNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbSignIn);
            this.Controls.Add(this.btnRegistation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSignIn;
        private System.Windows.Forms.Button btnRegistation;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.TextBox tbIdentityNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbShow;
    }
}