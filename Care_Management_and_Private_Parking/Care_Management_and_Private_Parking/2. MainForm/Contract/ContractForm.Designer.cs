
namespace Care_Management_and_Private_Parking
{
    partial class ContractForm
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
            this.pnContract = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContract
            // 
            this.pnContract.BackColor = System.Drawing.Color.White;
            this.pnContract.Location = new System.Drawing.Point(0, 0);
            this.pnContract.Name = "pnContract";
            this.pnContract.Size = new System.Drawing.Size(786, 714);
            this.pnContract.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnAdd.Location = new System.Drawing.Point(14, 46);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 28);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 22;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnAdd);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.guna2Panel1.Location = new System.Drawing.Point(792, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(117, 688);
            this.guna2Panel1.TabIndex = 11;
            // 
            // ContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(913, 712);
            this.Controls.Add(this.pnContract);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContractForm";
            this.Text = "ContractForm";
            this.Load += new System.EventHandler(this.ContractForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContract;
        private System.Windows.Forms.Button btnAdd;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}