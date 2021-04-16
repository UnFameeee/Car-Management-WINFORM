
namespace Care_Management_and_Private_Parking
{
    partial class ForgotPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSendCode = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbGmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirmCode = new System.Windows.Forms.Button();
            this.tbVerifyCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbCancel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(60, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // btnSendCode
            // 
            this.btnSendCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSendCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCode.ForeColor = System.Drawing.Color.White;
            this.btnSendCode.Location = new System.Drawing.Point(35, 282);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(269, 35);
            this.btnSendCode.TabIndex = 1;
            this.btnSendCode.Text = "Send Verify Code To Gmail";
            this.btnSendCode.UseVisualStyleBackColor = false;
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(64, 191);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(207, 29);
            this.tbUsername.TabIndex = 2;
            // 
            // tbGmail
            // 
            this.tbGmail.Location = new System.Drawing.Point(64, 247);
            this.tbGmail.Name = "tbGmail";
            this.tbGmail.Size = new System.Drawing.Size(207, 29);
            this.tbGmail.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(60, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "Gmail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(28, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 37);
            this.label3.TabIndex = 29;
            this.label3.Text = "Get Back Your Account";
            // 
            // btnConfirmCode
            // 
            this.btnConfirmCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirmCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmCode.ForeColor = System.Drawing.Color.White;
            this.btnConfirmCode.Location = new System.Drawing.Point(35, 383);
            this.btnConfirmCode.Name = "btnConfirmCode";
            this.btnConfirmCode.Size = new System.Drawing.Size(269, 35);
            this.btnConfirmCode.TabIndex = 38;
            this.btnConfirmCode.Text = "Confirm Code";
            this.btnConfirmCode.UseVisualStyleBackColor = false;
            this.btnConfirmCode.Click += new System.EventHandler(this.btnConfirmCode_Click);
            // 
            // tbVerifyCode
            // 
            this.tbVerifyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVerifyCode.Location = new System.Drawing.Point(64, 348);
            this.tbVerifyCode.Name = "tbVerifyCode";
            this.tbVerifyCode.Size = new System.Drawing.Size(207, 26);
            this.tbVerifyCode.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(60, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 36;
            this.label4.Text = "Verify Code:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(125, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // lbCancel
            // 
            this.lbCancel.AutoSize = true;
            this.lbCancel.BackColor = System.Drawing.Color.Transparent;
            this.lbCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCancel.ForeColor = System.Drawing.Color.DimGray;
            this.lbCancel.Location = new System.Drawing.Point(137, 421);
            this.lbCancel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(56, 21);
            this.lbCancel.TabIndex = 39;
            this.lbCancel.Text = "Cancel";
            this.lbCancel.Click += new System.EventHandler(this.lbCancel_Click);
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(338, 451);
            this.Controls.Add(this.lbCancel);
            this.Controls.Add(this.btnConfirmCode);
            this.Controls.Add(this.tbVerifyCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbGmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.btnSendCode);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ForgotPasswordForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSendCode;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbGmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfirmCode;
        private System.Windows.Forms.TextBox tbVerifyCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCancel;
    }
}