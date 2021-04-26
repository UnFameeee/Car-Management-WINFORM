
namespace Care_Management_and_Private_Parking
{
    partial class ManangeForm
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
            this.tbShiftID = new System.Windows.Forms.TextBox();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.lbGender = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbIdentity = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.tbEmpID = new System.Windows.Forms.TextBox();
            this.lbShiftID = new System.Windows.Forms.Label();
            this.lbJobID = new System.Windows.Forms.Label();
            this.lbIdentityCardNumber = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.dgvEmp = new System.Windows.Forms.DataGridView();
            this.tpVehicles = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tpEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpEmployees);
            this.tabControl1.Controls.Add(this.tpVehicles);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tpEmployees.Controls.Add(this.tbShiftID);
            this.tpEmployees.Controls.Add(this.rdbtnFemale);
            this.tpEmployees.Controls.Add(this.rdbtnMale);
            this.tpEmployees.Controls.Add(this.lbGender);
            this.tpEmployees.Controls.Add(this.btnRefresh);
            this.tpEmployees.Controls.Add(this.btnRemove);
            this.tpEmployees.Controls.Add(this.btnUpdate);
            this.tpEmployees.Controls.Add(this.btnAdd);
            this.tpEmployees.Controls.Add(this.tbIdentity);
            this.tpEmployees.Controls.Add(this.tbPhone);
            this.tpEmployees.Controls.Add(this.tbFullName);
            this.tpEmployees.Controls.Add(this.tbEmpID);
            this.tpEmployees.Controls.Add(this.lbShiftID);
            this.tpEmployees.Controls.Add(this.lbJobID);
            this.tpEmployees.Controls.Add(this.lbIdentityCardNumber);
            this.tpEmployees.Controls.Add(this.lbPhone);
            this.tpEmployees.Controls.Add(this.lbFullName);
            this.tpEmployees.Controls.Add(this.lbID);
            this.tpEmployees.Controls.Add(this.dgvEmp);
            this.tpEmployees.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpEmployees.Location = new System.Drawing.Point(4, 27);
            this.tpEmployees.Name = "tpEmployees";
            this.tpEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmployees.Size = new System.Drawing.Size(792, 419);
            this.tpEmployees.TabIndex = 0;
            this.tpEmployees.Text = "Employees";
            this.tpEmployees.UseVisualStyleBackColor = true;
            // 
            // tbJobID
            // 
            this.tbJobID.Location = new System.Drawing.Point(582, 76);
            this.tbJobID.Name = "tbJobID";
            this.tbJobID.Size = new System.Drawing.Size(168, 26);
            this.tbJobID.TabIndex = 21;
            // 
            // tbShiftID
            // 
            this.tbShiftID.Location = new System.Drawing.Point(582, 122);
            this.tbShiftID.Name = "tbShiftID";
            this.tbShiftID.Size = new System.Drawing.Size(168, 26);
            this.tbShiftID.TabIndex = 20;
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Location = new System.Drawing.Point(245, 104);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(78, 22);
            this.rdbtnFemale.TabIndex = 19;
            this.rdbtnFemale.Text = "Female";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Checked = true;
            this.rdbtnMale.Location = new System.Drawing.Point(152, 104);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(61, 22);
            this.rdbtnMale.TabIndex = 18;
            this.rdbtnMale.TabStop = true;
            this.rdbtnMale.Text = "Male";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(33, 104);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(65, 18);
            this.lbGender.TabIndex = 17;
            this.lbGender.Text = "Gender:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(582, 371);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 33);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(423, 371);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 33);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(268, 371);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 33);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
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
            this.tbIdentity.Location = new System.Drawing.Point(582, 33);
            this.tbIdentity.Name = "tbIdentity";
            this.tbIdentity.Size = new System.Drawing.Size(168, 26);
            this.tbIdentity.TabIndex = 10;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(152, 141);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(162, 26);
            this.tbPhone.TabIndex = 9;
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(152, 59);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(162, 26);
            this.tbFullName.TabIndex = 8;
            // 
            // tbEmpID
            // 
            this.tbEmpID.Location = new System.Drawing.Point(152, 17);
            this.tbEmpID.Name = "tbEmpID";
            this.tbEmpID.Size = new System.Drawing.Size(162, 26);
            this.tbEmpID.TabIndex = 7;
            // 
            // lbShiftID
            // 
            this.lbShiftID.AutoSize = true;
            this.lbShiftID.Location = new System.Drawing.Point(388, 125);
            this.lbShiftID.Name = "lbShiftID";
            this.lbShiftID.Size = new System.Drawing.Size(64, 18);
            this.lbShiftID.TabIndex = 6;
            this.lbShiftID.Text = "ShiftID:";
            // 
            // lbJobID
            // 
            this.lbJobID.AutoSize = true;
            this.lbJobID.Location = new System.Drawing.Point(388, 79);
            this.lbJobID.Name = "lbJobID";
            this.lbJobID.Size = new System.Drawing.Size(54, 18);
            this.lbJobID.TabIndex = 5;
            this.lbJobID.Text = "JobID:";
            // 
            // lbIdentityCardNumber
            // 
            this.lbIdentityCardNumber.AutoSize = true;
            this.lbIdentityCardNumber.Location = new System.Drawing.Point(388, 36);
            this.lbIdentityCardNumber.Name = "lbIdentityCardNumber";
            this.lbIdentityCardNumber.Size = new System.Drawing.Size(169, 18);
            this.lbIdentityCardNumber.TabIndex = 4;
            this.lbIdentityCardNumber.Text = "Identity Card Number:";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(33, 144);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(56, 18);
            this.lbPhone.TabIndex = 3;
            this.lbPhone.Text = "Phone:";
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Location = new System.Drawing.Point(33, 62);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(86, 18);
            this.lbFullName.TabIndex = 2;
            this.lbFullName.Text = "Full Name:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(33, 20);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(100, 18);
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
            // 
            // tpVehicles
            // 
            this.tpVehicles.Location = new System.Drawing.Point(4, 27);
            this.tpVehicles.Name = "tpVehicles";
            this.tpVehicles.Padding = new System.Windows.Forms.Padding(3);
            this.tpVehicles.Size = new System.Drawing.Size(792, 419);
            this.tpVehicles.TabIndex = 1;
            this.tpVehicles.Text = "Vehicles";
            this.tpVehicles.UseVisualStyleBackColor = true;
            // 
            // ManangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "ManangeForm";
            this.Text = "ManageForm";
            this.tabControl1.ResumeLayout(false);
            this.tpEmployees.ResumeLayout(false);
            this.tpEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpEmployees;
        private System.Windows.Forms.TabPage tpVehicles;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.DataGridView dgvEmp;
        private System.Windows.Forms.Label lbShiftID;
        private System.Windows.Forms.Label lbJobID;
        private System.Windows.Forms.Label lbIdentityCardNumber;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Button btnRefresh;
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
        private System.Windows.Forms.TextBox tbShiftID;
    }
}