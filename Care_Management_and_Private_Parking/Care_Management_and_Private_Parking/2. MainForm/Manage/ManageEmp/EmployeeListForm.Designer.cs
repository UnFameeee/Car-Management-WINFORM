
namespace Care_Management_and_Private_Parking
{
    partial class EmployeeListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeListForm));
            this.btnHeader = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnData = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvEmp = new Guna.UI.WinForms.GunaDataGridView();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPrint = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDetail = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSearchByID = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchByName = new Guna.UI2.WinForms.Guna2Button();
            this.pnData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
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
            this.btnHeader.Location = new System.Drawing.Point(324, 10);
            this.btnHeader.Name = "btnHeader";
            this.btnHeader.ShadowDecoration.Parent = this.btnHeader;
            this.btnHeader.Size = new System.Drawing.Size(231, 38);
            this.btnHeader.TabIndex = 39;
            this.btnHeader.Text = "EMPLOYEE LIST";
            // 
            // pnData
            // 
            this.pnData.BorderRadius = 22;
            this.pnData.BorderThickness = 1;
            this.pnData.Controls.Add(this.dgvEmp);
            this.pnData.Controls.Add(this.tbSearch);
            this.pnData.Controls.Add(this.btnPrint);
            this.pnData.Controls.Add(this.btnAdd);
            this.pnData.Controls.Add(this.btnDetail);
            this.pnData.Controls.Add(this.btnSearchByID);
            this.pnData.Controls.Add(this.btnSearchByName);
            this.pnData.Controls.Add(this.btnHeader);
            this.pnData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnData.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.pnData.Location = new System.Drawing.Point(0, 0);
            this.pnData.Name = "pnData";
            this.pnData.ShadowDecoration.Parent = this.pnData;
            this.pnData.Size = new System.Drawing.Size(913, 712);
            this.pnData.TabIndex = 40;
            // 
            // dgvEmp
            // 
            this.dgvEmp.AllowUserToAddRows = false;
            this.dgvEmp.AllowUserToDeleteRows = false;
            this.dgvEmp.AllowUserToResizeColumns = false;
            this.dgvEmp.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvEmp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmp.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvEmp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmp.ColumnHeadersHeight = 25;
            this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmp.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmp.EnableHeadersVisualStyles = false;
            this.dgvEmp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvEmp.Location = new System.Drawing.Point(12, 153);
            this.dgvEmp.MultiSelect = false;
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.ReadOnly = true;
            this.dgvEmp.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvEmp.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmp.RowTemplate.ReadOnly = true;
            this.dgvEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvEmp.Size = new System.Drawing.Size(881, 515);
            this.dgvEmp.TabIndex = 197;
            this.dgvEmp.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Dark;
            this.dgvEmp.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvEmp.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEmp.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEmp.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEmp.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEmp.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvEmp.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvEmp.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvEmp.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvEmp.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvEmp.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.dgvEmp.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmp.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvEmp.ThemeStyle.ReadOnly = true;
            this.dgvEmp.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvEmp.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmp.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvEmp.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEmp.ThemeStyle.RowsStyle.Height = 22;
            this.dgvEmp.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.dgvEmp.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // tbSearch
            // 
            this.tbSearch.AutoRoundedCorners = true;
            this.tbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tbSearch.BorderColor = System.Drawing.SystemColors.Control;
            this.tbSearch.BorderRadius = 18;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.DefaultText = "";
            this.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.DisabledState.Parent = this.tbSearch;
            this.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.tbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.FocusedState.Parent = this.tbSearch;
            this.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.HoverState.Parent = this.tbSearch;
            this.tbSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("tbSearch.IconLeft")));
            this.tbSearch.IconLeftSize = new System.Drawing.Size(25, 25);
            this.tbSearch.Location = new System.Drawing.Point(137, 55);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PlaceholderText = "Type to search Name or ID";
            this.tbSearch.SelectedText = "";
            this.tbSearch.ShadowDecoration.Parent = this.tbSearch;
            this.tbSearch.Size = new System.Drawing.Size(611, 39);
            this.tbSearch.TabIndex = 51;
            // 
            // btnPrint
            // 
            this.btnPrint.CheckedState.Parent = this.btnPrint;
            this.btnPrint.CustomImages.Parent = this.btnPrint;
            this.btnPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(34)))), ((int)(((byte)(255)))));
            this.btnPrint.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.HoverState.Parent = this.btnPrint;
            this.btnPrint.Location = new System.Drawing.Point(804, 674);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ShadowDecoration.Parent = this.btnPrint;
            this.btnPrint.Size = new System.Drawing.Size(89, 24);
            this.btnPrint.TabIndex = 50;
            this.btnPrint.Text = "PRINT";
            // 
            // btnAdd
            // 
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(34)))), ((int)(((byte)(255)))));
            this.btnAdd.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(133, 674);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(89, 24);
            this.btnAdd.TabIndex = 49;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.CheckedState.Parent = this.btnDetail;
            this.btnDetail.CustomImages.Parent = this.btnDetail;
            this.btnDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(34)))), ((int)(((byte)(255)))));
            this.btnDetail.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.Color.White;
            this.btnDetail.HoverState.Parent = this.btnDetail;
            this.btnDetail.Location = new System.Drawing.Point(12, 674);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.ShadowDecoration.Parent = this.btnDetail;
            this.btnDetail.Size = new System.Drawing.Size(89, 24);
            this.btnDetail.TabIndex = 48;
            this.btnDetail.Text = "DETAIL";
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnSearchByID
            // 
            this.btnSearchByID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnSearchByID.BorderThickness = 1;
            this.btnSearchByID.CheckedState.Parent = this.btnSearchByID;
            this.btnSearchByID.CustomImages.Parent = this.btnSearchByID;
            this.btnSearchByID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.btnSearchByID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSearchByID.ForeColor = System.Drawing.Color.White;
            this.btnSearchByID.HoverState.Parent = this.btnSearchByID;
            this.btnSearchByID.Location = new System.Drawing.Point(816, 124);
            this.btnSearchByID.Name = "btnSearchByID";
            this.btnSearchByID.ShadowDecoration.Parent = this.btnSearchByID;
            this.btnSearchByID.Size = new System.Drawing.Size(77, 23);
            this.btnSearchByID.TabIndex = 45;
            this.btnSearchByID.Text = "By ID";
            this.btnSearchByID.Click += new System.EventHandler(this.btnSearchByID_Click);
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnSearchByName.BorderThickness = 1;
            this.btnSearchByName.CheckedState.Parent = this.btnSearchByName;
            this.btnSearchByName.CustomImages.Parent = this.btnSearchByName;
            this.btnSearchByName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.btnSearchByName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSearchByName.ForeColor = System.Drawing.Color.White;
            this.btnSearchByName.HoverState.Parent = this.btnSearchByName;
            this.btnSearchByName.Location = new System.Drawing.Point(736, 124);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.ShadowDecoration.Parent = this.btnSearchByName;
            this.btnSearchByName.Size = new System.Drawing.Size(77, 23);
            this.btnSearchByName.TabIndex = 44;
            this.btnSearchByName.Text = "By Name";
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // EmployeeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(913, 712);
            this.Controls.Add(this.pnData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmployeeListForm";
            this.Load += new System.EventHandler(this.EmployeeListForm_Load);
            this.pnData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpEmpList;
        private Guna.UI2.WinForms.Guna2GradientButton btnHeader;
        private Guna.UI2.WinForms.Guna2Panel pnData;
        private Guna.UI2.WinForms.Guna2Button btnSearchByName;
        private Guna.UI2.WinForms.Guna2Button btnSearchByID;
        private Guna.UI2.WinForms.Guna2GradientButton btnDetail;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
        private Guna.UI2.WinForms.Guna2GradientButton btnPrint;
        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private Guna.UI.WinForms.GunaDataGridView dgvEmp;
    }
}