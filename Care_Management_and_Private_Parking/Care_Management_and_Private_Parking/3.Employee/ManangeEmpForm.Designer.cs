
namespace Care_Management_and_Private_Parking
{
    partial class ManangeEmpForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpEmployees = new System.Windows.Forms.TabPage();
            this.tbJobID = new System.Windows.Forms.TextBox();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.lbGender = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbIdentity = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.tbEmpID = new System.Windows.Forms.TextBox();
            this.lbJobID = new System.Windows.Forms.Label();
            this.lbIdentityCardNumber = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.dgvEmp = new System.Windows.Forms.DataGridView();
            this.tpWorkSchedule = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tpEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpEmployees);
            this.tabControl1.Controls.Add(this.tpWorkSchedule);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tpEmployees
            // 
            this.tpEmployees.Controls.Add(this.tbJobID);
            this.tpEmployees.Controls.Add(this.rdbtnFemale);
            this.tpEmployees.Controls.Add(this.rdbtnMale);
            this.tpEmployees.Controls.Add(this.lbGender);
            this.tpEmployees.Controls.Add(this.btnClear);
            this.tpEmployees.Controls.Add(this.btnRemove);
            this.tpEmployees.Controls.Add(this.btnUpdate);
            this.tpEmployees.Controls.Add(this.btnAdd);
            this.tpEmployees.Controls.Add(this.tbIdentity);
            this.tpEmployees.Controls.Add(this.tbPhone);
            this.tpEmployees.Controls.Add(this.tbFullName);
            this.tpEmployees.Controls.Add(this.tbEmpID);
            this.tpEmployees.Controls.Add(this.lbJobID);
            this.tpEmployees.Controls.Add(this.lbIdentityCardNumber);
            this.tpEmployees.Controls.Add(this.lbPhone);
            this.tpEmployees.Controls.Add(this.lbFullName);
            this.tpEmployees.Controls.Add(this.lbID);
            this.tpEmployees.Controls.Add(this.dgvEmp);
            this.tpEmployees.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpEmployees.Location = new System.Drawing.Point(4, 29);
            this.tpEmployees.Name = "tpEmployees";
            this.tpEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmployees.Size = new System.Drawing.Size(792, 417);
            this.tpEmployees.TabIndex = 0;
            this.tpEmployees.Text = "Employees";
            this.tpEmployees.UseVisualStyleBackColor = true;
            this.tpEmployees.Enter += new System.EventHandler(this.tpEmployees_Enter);
            // 
            // tbJobID
            // 
            this.tbJobID.Location = new System.Drawing.Point(581, 125);
            this.tbJobID.Name = "tbJobID";
            this.tbJobID.Size = new System.Drawing.Size(168, 27);
            this.tbJobID.TabIndex = 21;
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Location = new System.Drawing.Point(245, 131);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(75, 24);
            this.rdbtnFemale.TabIndex = 19;
            this.rdbtnFemale.Text = "Female";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Checked = true;
            this.rdbtnMale.Location = new System.Drawing.Point(152, 131);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(60, 24);
            this.rdbtnMale.TabIndex = 18;
            this.rdbtnMale.TabStop = true;
            this.rdbtnMale.Text = "Male";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(33, 131);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(60, 20);
            this.lbGender.TabIndex = 17;
            this.lbGender.Text = "Gender:";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(582, 371);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 33);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(423, 371);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 33);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(268, 371);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 33);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(107, 371);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 33);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbIdentity
            // 
            this.tbIdentity.Location = new System.Drawing.Point(581, 75);
            this.tbIdentity.Name = "tbIdentity";
            this.tbIdentity.Size = new System.Drawing.Size(168, 27);
            this.tbIdentity.TabIndex = 10;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(580, 27);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(169, 27);
            this.tbPhone.TabIndex = 9;
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(152, 74);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(162, 27);
            this.tbFullName.TabIndex = 8;
            // 
            // tbEmpID
            // 
            this.tbEmpID.Location = new System.Drawing.Point(152, 26);
            this.tbEmpID.Name = "tbEmpID";
            this.tbEmpID.Size = new System.Drawing.Size(162, 27);
            this.tbEmpID.TabIndex = 7;
            // 
            // lbJobID
            // 
            this.lbJobID.AutoSize = true;
            this.lbJobID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJobID.Location = new System.Drawing.Point(387, 128);
            this.lbJobID.Name = "lbJobID";
            this.lbJobID.Size = new System.Drawing.Size(50, 20);
            this.lbJobID.TabIndex = 5;
            this.lbJobID.Text = "JobID:";
            // 
            // lbIdentityCardNumber
            // 
            this.lbIdentityCardNumber.AutoSize = true;
            this.lbIdentityCardNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdentityCardNumber.Location = new System.Drawing.Point(387, 81);
            this.lbIdentityCardNumber.Name = "lbIdentityCardNumber";
            this.lbIdentityCardNumber.Size = new System.Drawing.Size(155, 20);
            this.lbIdentityCardNumber.TabIndex = 4;
            this.lbIdentityCardNumber.Text = "Identity Card Number:";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(387, 33);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(53, 20);
            this.lbPhone.TabIndex = 3;
            this.lbPhone.Text = "Phone:";
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullName.Location = new System.Drawing.Point(33, 77);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(79, 20);
            this.lbFullName.TabIndex = 2;
            this.lbFullName.Text = "Full Name:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(33, 29);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(93, 20);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "EmployeeID:";
            // 
            // dgvEmp
            // 
            this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmp.Location = new System.Drawing.Point(52, 192);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.Size = new System.Drawing.Size(685, 150);
            this.dgvEmp.TabIndex = 0;
            this.dgvEmp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmp_CellClick);
            // 
            // tpWorkSchedule
            // 
            this.tpWorkSchedule.Location = new System.Drawing.Point(4, 29);
            this.tpWorkSchedule.Name = "tpWorkSchedule";
            this.tpWorkSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tpWorkSchedule.Size = new System.Drawing.Size(792, 417);
            this.tpWorkSchedule.TabIndex = 1;
            this.tpWorkSchedule.Text = "Work Schedule";
            this.tpWorkSchedule.UseVisualStyleBackColor = true;
            // 
            // ManangeEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "ManangeEmpForm";
            this.Text = "ManageEmpForm";
            this.tabControl1.ResumeLayout(false);
            this.tpEmployees.ResumeLayout(false);
            this.tpEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpEmployees;
        private System.Windows.Forms.TabPage tpWorkSchedule;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.DataGridView dgvEmp;
        private System.Windows.Forms.Label lbJobID;
        private System.Windows.Forms.Label lbIdentityCardNumber;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbIdentity;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.TextBox tbEmpID;
        private System.Windows.Forms.RadioButton rdbtnFemale;
        private System.Windows.Forms.RadioButton rdbtnMale;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.TextBox tbJobID;
    }
}