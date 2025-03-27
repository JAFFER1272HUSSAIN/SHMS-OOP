namespace Final_GUI_Business_Application.UserControls
{
    partial class RemoveEmployeeUC
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
            this.Regbtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Signupusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSignup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Regbtn
            // 
            this.Regbtn.BackColor = System.Drawing.Color.RosyBrown;
            this.Regbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Regbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Regbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regbtn.Location = new System.Drawing.Point(192, 283);
            this.Regbtn.Name = "Regbtn";
            this.Regbtn.Size = new System.Drawing.Size(255, 41);
            this.Regbtn.TabIndex = 16;
            this.Regbtn.Text = "REMOVE";
            this.Regbtn.UseVisualStyleBackColor = false;
            this.Regbtn.Click += new System.EventHandler(this.Regbtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(251, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 20);
            this.textBox1.TabIndex = 14;
            // 
            // Signupusername
            // 
            this.Signupusername.ForeColor = System.Drawing.Color.Red;
            this.Signupusername.Location = new System.Drawing.Point(251, 206);
            this.Signupusername.Name = "Signupusername";
            this.Signupusername.Size = new System.Drawing.Size(276, 20);
            this.Signupusername.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "UserName:";
            // 
            // lblSignup
            // 
            this.lblSignup.BackColor = System.Drawing.Color.RosyBrown;
            this.lblSignup.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignup.Location = new System.Drawing.Point(186, 36);
            this.lblSignup.Name = "lblSignup";
            this.lblSignup.Size = new System.Drawing.Size(280, 35);
            this.lblSignup.TabIndex = 9;
            this.lblSignup.Text = "Remove Employees";
            this.lblSignup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemoveEmployeeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Regbtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Signupusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSignup);
            this.Name = "RemoveEmployeeUC";
            this.Size = new System.Drawing.Size(657, 378);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Regbtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Signupusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSignup;
    }
}
