
namespace Care_Management_and_Private_Parking
{
    partial class ManageEmployeeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbJobID = new System.Windows.Forms.TextBox();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.lbGender = new System.Windows.Forms.Label();
            this.tbIdentity = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.tbEmpID = new System.Windows.Forms.TextBox();
            this.lbJobID = new System.Windows.Forms.Label();
            this.lbIdentityCardNumber = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.dgvData = new Guna.UI.WinForms.GunaDataGridView();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.btnRemove = new Guna.UI.WinForms.GunaButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            this.btnClear = new Guna.UI.WinForms.GunaButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbJobID
            // 
            this.tbJobID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbJobID.ForeColor = System.Drawing.Color.Black;
            this.tbJobID.Location = new System.Drawing.Point(450, 296);
            this.tbJobID.Name = "tbJobID";
            this.tbJobID.Size = new System.Drawing.Size(161, 23);
            this.tbJobID.TabIndex = 38;
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnFemale.ForeColor = System.Drawing.Color.White;
            this.rdbtnFemale.Location = new System.Drawing.Point(542, 141);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(75, 22);
            this.rdbtnFemale.TabIndex = 37;
            this.rdbtnFemale.Text = "Female";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Checked = true;
            this.rdbtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnMale.ForeColor = System.Drawing.Color.White;
            this.rdbtnMale.Location = new System.Drawing.Point(449, 141);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(58, 22);
            this.rdbtnMale.TabIndex = 36;
            this.rdbtnMale.TabStop = true;
            this.rdbtnMale.Text = "Male";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.ForeColor = System.Drawing.Color.White;
            this.lbGender.Location = new System.Drawing.Point(330, 141);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(60, 20);
            this.lbGender.TabIndex = 35;
            this.lbGender.Text = "Gender:";
            // 
            // tbIdentity
            // 
            this.tbIdentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdentity.ForeColor = System.Drawing.Color.Black;
            this.tbIdentity.Location = new System.Drawing.Point(450, 246);
            this.tbIdentity.Name = "tbIdentity";
            this.tbIdentity.Size = new System.Drawing.Size(161, 23);
            this.tbIdentity.TabIndex = 30;
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.ForeColor = System.Drawing.Color.Black;
            this.tbPhone.Location = new System.Drawing.Point(449, 198);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(162, 23);
            this.tbPhone.TabIndex = 29;
            // 
            // tbFullName
            // 
            this.tbFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFullName.ForeColor = System.Drawing.Color.Black;
            this.tbFullName.Location = new System.Drawing.Point(449, 84);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(162, 23);
            this.tbFullName.TabIndex = 28;
            // 
            // tbEmpID
            // 
            this.tbEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmpID.ForeColor = System.Drawing.Color.Black;
            this.tbEmpID.Location = new System.Drawing.Point(449, 36);
            this.tbEmpID.Name = "tbEmpID";
            this.tbEmpID.Size = new System.Drawing.Size(162, 23);
            this.tbEmpID.TabIndex = 27;
            this.tbEmpID.Text = "\r\n";
            // 
            // lbJobID
            // 
            this.lbJobID.AutoSize = true;
            this.lbJobID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJobID.ForeColor = System.Drawing.Color.White;
            this.lbJobID.Location = new System.Drawing.Point(330, 300);
            this.lbJobID.Name = "lbJobID";
            this.lbJobID.Size = new System.Drawing.Size(50, 20);
            this.lbJobID.TabIndex = 26;
            this.lbJobID.Text = "JobID:";
            // 
            // lbIdentityCardNumber
            // 
            this.lbIdentityCardNumber.AutoSize = true;
            this.lbIdentityCardNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdentityCardNumber.ForeColor = System.Drawing.Color.White;
            this.lbIdentityCardNumber.Location = new System.Drawing.Point(330, 253);
            this.lbIdentityCardNumber.Name = "lbIdentityCardNumber";
            this.lbIdentityCardNumber.Size = new System.Drawing.Size(62, 20);
            this.lbIdentityCardNumber.TabIndex = 25;
            this.lbIdentityCardNumber.Text = "Identity:";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.ForeColor = System.Drawing.Color.White;
            this.lbPhone.Location = new System.Drawing.Point(330, 205);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(53, 20);
            this.lbPhone.TabIndex = 24;
            this.lbPhone.Text = "Phone:";
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullName.ForeColor = System.Drawing.Color.White;
            this.lbFullName.Location = new System.Drawing.Point(330, 87);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(79, 20);
            this.lbFullName.TabIndex = 23;
            this.lbFullName.Text = "Full Name:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.White;
            this.lbID.Location = new System.Drawing.Point(330, 39);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(93, 20);
            this.lbID.TabIndex = 22;
            this.lbID.Text = "EmployeeID:";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeColumns = false;
            this.dgvData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvData.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.ColumnHeadersHeight = 35;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvData.Location = new System.Drawing.Point(3, 3);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidth = 30;
            this.dgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvData.RowTemplate.Height = 30;
            this.dgvData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(240, 444);
            this.dgvData.TabIndex = 39;
            this.dgvData.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Dark;
            this.dgvData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvData.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvData.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvData.ThemeStyle.ReadOnly = true;
            this.dgvData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvData.ThemeStyle.RowsStyle.Height = 30;
            this.dgvData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderColor = System.Drawing.Color.Gray;
            this.btnAdd.BorderSize = 3;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.btnAdd.ForeColor = System.Drawing.Color.Red;
            this.btnAdd.Image = null;
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.Location = new System.Drawing.Point(334, 367);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Size = new System.Drawing.Size(103, 38);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "ADD";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AnimationHoverSpeed = 0.07F;
            this.btnRemove.AnimationSpeed = 0.03F;
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.BaseColor = System.Drawing.Color.Transparent;
            this.btnRemove.BorderColor = System.Drawing.Color.Gray;
            this.btnRemove.BorderSize = 3;
            this.btnRemove.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRemove.FocusedColor = System.Drawing.Color.Empty;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.btnRemove.ForeColor = System.Drawing.Color.Red;
            this.btnRemove.Image = null;
            this.btnRemove.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRemove.Location = new System.Drawing.Point(334, 451);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnRemove.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRemove.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRemove.OnHoverImage = null;
            this.btnRemove.OnPressedColor = System.Drawing.Color.Black;
            this.btnRemove.Size = new System.Drawing.Size(103, 38);
            this.btnRemove.TabIndex = 41;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderColor = System.Drawing.Color.Gray;
            this.btnUpdate.BorderSize = 3;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.btnUpdate.ForeColor = System.Drawing.Color.Red;
            this.btnUpdate.Image = null;
            this.btnUpdate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdate.Location = new System.Drawing.Point(487, 367);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Size = new System.Drawing.Size(103, 38);
            this.btnUpdate.TabIndex = 42;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.AnimationHoverSpeed = 0.07F;
            this.btnClear.AnimationSpeed = 0.03F;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BaseColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderColor = System.Drawing.Color.Gray;
            this.btnClear.BorderSize = 3;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClear.FocusedColor = System.Drawing.Color.Empty;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Image = null;
            this.btnClear.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClear.Location = new System.Drawing.Point(487, 451);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnClear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClear.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClear.OnHoverImage = null;
            this.btnClear.OnPressedColor = System.Drawing.Color.Black;
            this.btnClear.Size = new System.Drawing.Size(103, 38);
            this.btnClear.TabIndex = 43;
            this.btnClear.Text = "CLEAR";
            this.btnClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvData);
            this.panel1.Location = new System.Drawing.Point(34, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 450);
            this.panel1.TabIndex = 44;
            // 
            // ManageEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(649, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbJobID);
            this.Controls.Add(this.rdbtnFemale);
            this.Controls.Add(this.rdbtnMale);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.tbIdentity);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.tbEmpID);
            this.Controls.Add(this.lbJobID);
            this.Controls.Add(this.lbIdentityCardNumber);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbFullName);
            this.Controls.Add(this.lbID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageEmployeeForm";
            this.Text = "ManageEmployeeForm";
            this.Load += new System.EventHandler(this.ManageEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbJobID;
        private System.Windows.Forms.RadioButton rdbtnFemale;
        private System.Windows.Forms.RadioButton rdbtnMale;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.TextBox tbIdentity;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.TextBox tbEmpID;
        private System.Windows.Forms.Label lbJobID;
        private System.Windows.Forms.Label lbIdentityCardNumber;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Label lbID;
        private Guna.UI.WinForms.GunaDataGridView dgvData;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private Guna.UI.WinForms.GunaButton btnRemove;
        private Guna.UI.WinForms.GunaButton btnUpdate;
        private Guna.UI.WinForms.GunaButton btnClear;
        private System.Windows.Forms.Panel panel1;
    }
}