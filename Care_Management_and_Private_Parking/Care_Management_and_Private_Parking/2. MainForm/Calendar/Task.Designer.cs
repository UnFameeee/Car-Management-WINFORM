
namespace Care_Management_and_Private_Parking
{
    partial class Task
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.cbTick = new System.Windows.Forms.CheckBox();
            this.tbJob = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.guna2ProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.guna2ProgressBar1.Location = new System.Drawing.Point(4, 22);
            this.guna2ProgressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.ShadowDecoration.Parent = this.guna2ProgressBar1;
            this.guna2ProgressBar1.Size = new System.Drawing.Size(573, 8);
            this.guna2ProgressBar1.TabIndex = 9;
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // cbTick
            // 
            this.cbTick.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbTick.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTick.Location = new System.Drawing.Point(4, 1);
            this.cbTick.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbTick.Name = "cbTick";
            this.cbTick.Size = new System.Drawing.Size(27, 24);
            this.cbTick.TabIndex = 6;
            this.cbTick.UseVisualStyleBackColor = true;
            this.cbTick.CheckedChanged += new System.EventHandler(this.cbTick_CheckedChanged);
            // 
            // tbJob
            // 
            this.tbJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tbJob.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbJob.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbJob.ForeColor = System.Drawing.Color.White;
            this.tbJob.Location = new System.Drawing.Point(37, 5);
            this.tbJob.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbJob.Name = "tbJob";
            this.tbJob.Size = new System.Drawing.Size(515, 18);
            this.tbJob.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(558, 5);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(19, 18);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.guna2ProgressBar1);
            this.Controls.Add(this.cbTick);
            this.Controls.Add(this.tbJob);
            this.Controls.Add(this.btnDelete);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Task";
            this.Size = new System.Drawing.Size(580, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private System.Windows.Forms.CheckBox cbTick;
        private System.Windows.Forms.TextBox tbJob;
        private System.Windows.Forms.Button btnDelete;
    }
}
