
namespace Care_Management_and_Private_Parking
{
    partial class ManageAccountForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnData = new Guna.UI2.WinForms.Guna2Panel();
            this.btnHeader = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbxPositionID = new System.Windows.Forms.ComboBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.lbJobID = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.pnData.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // pnData
            // 
            this.pnData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.pnData.BorderRadius = 22;
            this.pnData.BorderThickness = 1;
            this.pnData.Controls.Add(this.btnAdd);
            this.pnData.Controls.Add(this.btnRemove);
            this.pnData.Controls.Add(this.btnUpdate);
            this.pnData.Controls.Add(this.btnHeader);
            this.pnData.Controls.Add(this.panel1);
            this.pnData.Controls.Add(this.dgvAccount);
            this.pnData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnData.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.pnData.Location = new System.Drawing.Point(0, 0);
            this.pnData.Name = "pnData";
            this.pnData.ShadowDecoration.Parent = this.pnData;
            this.pnData.Size = new System.Drawing.Size(913, 712);
            this.pnData.TabIndex = 2;
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
            this.btnHeader.Location = new System.Drawing.Point(306, 12);
            this.btnHeader.Name = "btnHeader";
            this.btnHeader.ShadowDecoration.Parent = this.btnHeader;
            this.btnHeader.Size = new System.Drawing.Size(231, 38);
            this.btnHeader.TabIndex = 48;
            this.btnHeader.Text = "MANAGE ACCOUNT";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbxPositionID);
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Controls.Add(this.lbFullName);
            this.panel1.Controls.Add(this.lbJobID);
            this.panel1.Controls.Add(this.tbUsername);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Location = new System.Drawing.Point(566, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 172);
            this.panel1.TabIndex = 48;
            // 
            // cbbxPositionID
            // 
            this.cbbxPositionID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.cbbxPositionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbxPositionID.ForeColor = System.Drawing.Color.White;
            this.cbbxPositionID.FormattingEnabled = true;
            this.cbbxPositionID.Location = new System.Drawing.Point(132, 112);
            this.cbbxPositionID.Name = "cbbxPositionID";
            this.cbbxPositionID.Size = new System.Drawing.Size(162, 24);
            this.cbbxPositionID.TabIndex = 45;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.White;
            this.lbID.Location = new System.Drawing.Point(13, 23);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(78, 20);
            this.lbID.TabIndex = 22;
            this.lbID.Text = "Username:";
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullName.ForeColor = System.Drawing.Color.White;
            this.lbFullName.Location = new System.Drawing.Point(13, 66);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(73, 20);
            this.lbFullName.TabIndex = 23;
            this.lbFullName.Text = "Password:";
            // 
            // lbJobID
            // 
            this.lbJobID.AutoSize = true;
            this.lbJobID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJobID.ForeColor = System.Drawing.Color.White;
            this.lbJobID.Location = new System.Drawing.Point(13, 116);
            this.lbJobID.Name = "lbJobID";
            this.lbJobID.Size = new System.Drawing.Size(79, 20);
            this.lbJobID.TabIndex = 26;
            this.lbJobID.Text = "PositionID:";
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.Color.White;
            this.tbUsername.Location = new System.Drawing.Point(132, 20);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(162, 23);
            this.tbUsername.TabIndex = 27;
            this.tbUsername.Text = "\r\n";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.White;
            this.tbPassword.Location = new System.Drawing.Point(132, 63);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(162, 23);
            this.tbPassword.TabIndex = 28;
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AllowUserToDeleteRows = false;
            this.dgvAccount.AllowUserToResizeColumns = false;
            this.dgvAccount.AllowUserToResizeRows = false;
            this.dgvAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccount.ColumnHeadersHeight = 40;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAccount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.dgvAccount.Location = new System.Drawing.Point(35, 109);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.RowHeadersWidth = 25;
            this.dgvAccount.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvAccount.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAccount.Size = new System.Drawing.Size(486, 549);
            this.dgvAccount.TabIndex = 47;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnUpdate.BorderRadius = 22;
            this.btnUpdate.BorderThickness = 1;
            this.btnUpdate.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnUpdate.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdate.Location = new System.Drawing.Point(545, 500);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(120, 43);
            this.btnUpdate.TabIndex = 64;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseTransparentBackground = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnRemove.BorderRadius = 22;
            this.btnRemove.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
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
            this.btnRemove.Location = new System.Drawing.Point(781, 500);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ShadowDecoration.Parent = this.btnRemove;
            this.btnRemove.Size = new System.Drawing.Size(120, 43);
            this.btnRemove.TabIndex = 65;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseTransparentBackground = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAdd.BorderRadius = 22;
            this.btnAdd.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnAdd.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdd.Location = new System.Drawing.Point(655, 451);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(120, 43);
            this.btnAdd.TabIndex = 66;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseTransparentBackground = true;
            // 
            // ManageAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 712);
            this.Controls.Add(this.pnData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageAccountForm";
            this.Text = "ManageAccountForm";
            this.Load += new System.EventHandler(this.ManageAccountForm_Load);
            this.pnData.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnData;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbxPositionID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Label lbJobID;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private Guna.UI2.WinForms.Guna2GradientButton btnHeader;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
    }
}