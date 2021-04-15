
namespace Care_Management_and_Private_Parking
{
    partial class LoginForm
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.pwdLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSignIn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbForgotPassword = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(339, 288);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(160, 46);
            this.btnRegister.TabIndex = 18;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Transparent;
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(128, 287);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(159, 46);
            this.btnlogin.TabIndex = 17;
            this.btnlogin.Text = "LOGIN";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(176, 110);
            this.tbPwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(207, 43);
            this.tbPwd.TabIndex = 15;
            this.tbPwd.UseSystemPasswordChar = true;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(176, 31);
            this.tbUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(207, 43);
            this.tbUser.TabIndex = 14;
            // 
            // pwdLabel
            // 
            this.pwdLabel.AutoSize = true;
            this.pwdLabel.BackColor = System.Drawing.Color.Transparent;
            this.pwdLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdLabel.ForeColor = System.Drawing.Color.Cyan;
            this.pwdLabel.Location = new System.Drawing.Point(36, 98);
            this.pwdLabel.Name = "pwdLabel";
            this.pwdLabel.Size = new System.Drawing.Size(117, 32);
            this.pwdLabel.TabIndex = 13;
            this.pwdLabel.Text = "Password:";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.BackColor = System.Drawing.Color.Transparent;
            this.userLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.Color.White;
            this.userLabel.Location = new System.Drawing.Point(36, 31);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(127, 32);
            this.userLabel.TabIndex = 12;
            this.userLabel.Text = "Username:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbPwd);
            this.panel1.Controls.Add(this.userLabel);
            this.panel1.Controls.Add(this.pwdLabel);
            this.panel1.Controls.Add(this.tbUser);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(93, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 196);
            this.panel1.TabIndex = 20;
            // 
            // lbSignIn
            // 
            this.lbSignIn.AutoSize = true;
            this.lbSignIn.BackColor = System.Drawing.Color.Transparent;
            this.lbSignIn.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignIn.ForeColor = System.Drawing.Color.White;
            this.lbSignIn.Location = new System.Drawing.Point(245, 9);
            this.lbSignIn.Name = "lbSignIn";
            this.lbSignIn.Size = new System.Drawing.Size(121, 45);
            this.lbSignIn.TabIndex = 21;
            this.lbSignIn.Text = "Sign In";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(293, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "OR";
            // 
            // lbForgotPassword
            // 
            this.lbForgotPassword.AutoSize = true;
            this.lbForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbForgotPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForgotPassword.ForeColor = System.Drawing.Color.White;
            this.lbForgotPassword.Location = new System.Drawing.Point(231, 359);
            this.lbForgotPassword.Name = "lbForgotPassword";
            this.lbForgotPassword.Size = new System.Drawing.Size(158, 28);
            this.lbForgotPassword.TabIndex = 23;
            this.lbForgotPassword.Text = "Forgot Password";
            this.lbForgotPassword.Click += new System.EventHandler(this.lbForgotPassword_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(620, 421);
            this.Controls.Add(this.lbForgotPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSignIn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnlogin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label pwdLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbSignIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbForgotPassword;
    }
}

