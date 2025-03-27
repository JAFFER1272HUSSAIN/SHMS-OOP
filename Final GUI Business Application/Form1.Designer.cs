namespace Final_GUI_Business_Application
{
    partial class Signup
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
            this.lblSignup = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Signupusername = new System.Windows.Forms.TextBox();
            this.Signuppassword = new System.Windows.Forms.TextBox();
            this.Regbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Signuprole = new System.Windows.Forms.TextBox();
            this.Alreadybtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSignup
            // 
            this.lblSignup.BackColor = System.Drawing.Color.RosyBrown;
            this.lblSignup.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignup.Location = new System.Drawing.Point(147, 76);
            this.lblSignup.Name = "lblSignup";
            this.lblSignup.Size = new System.Drawing.Size(169, 35);
            this.lblSignup.TabIndex = 0;
            this.lblSignup.Text = "Signup Page";
            this.lblSignup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // Signupusername
            // 
            this.Signupusername.ForeColor = System.Drawing.Color.Red;
            this.Signupusername.Location = new System.Drawing.Point(153, 177);
            this.Signupusername.Name = "Signupusername";
            this.Signupusername.Size = new System.Drawing.Size(276, 20);
            this.Signupusername.TabIndex = 3;
            // 
            // Signuppassword
            // 
            this.Signuppassword.ForeColor = System.Drawing.Color.Red;
            this.Signuppassword.Location = new System.Drawing.Point(153, 239);
            this.Signuppassword.Name = "Signuppassword";
            this.Signuppassword.Size = new System.Drawing.Size(276, 20);
            this.Signuppassword.TabIndex = 4;
            // 
            // Regbtn
            // 
            this.Regbtn.BackColor = System.Drawing.Color.RosyBrown;
            this.Regbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Regbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Regbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regbtn.Location = new System.Drawing.Point(102, 378);
            this.Regbtn.Name = "Regbtn";
            this.Regbtn.Size = new System.Drawing.Size(268, 41);
            this.Regbtn.TabIndex = 5;
            this.Regbtn.Text = "Register";
            this.Regbtn.UseVisualStyleBackColor = false;
            this.Regbtn.Click += new System.EventHandler(this.Regbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Role:";
            // 
            // Signuprole
            // 
            this.Signuprole.ForeColor = System.Drawing.Color.Red;
            this.Signuprole.Location = new System.Drawing.Point(153, 302);
            this.Signuprole.Name = "Signuprole";
            this.Signuprole.Size = new System.Drawing.Size(276, 20);
            this.Signuprole.TabIndex = 7;
            // 
            // Alreadybtn
            // 
            this.Alreadybtn.BackColor = System.Drawing.Color.White;
            this.Alreadybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Alreadybtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Alreadybtn.Location = new System.Drawing.Point(220, 349);
            this.Alreadybtn.Name = "Alreadybtn";
            this.Alreadybtn.Size = new System.Drawing.Size(150, 23);
            this.Alreadybtn.TabIndex = 8;
            this.Alreadybtn.Text = "Already have an account";
            this.Alreadybtn.UseVisualStyleBackColor = false;
            this.Alreadybtn.Click += new System.EventHandler(this.Alreadybtn_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 461);
            this.Controls.Add(this.Alreadybtn);
            this.Controls.Add(this.Signuprole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Regbtn);
            this.Controls.Add(this.Signuppassword);
            this.Controls.Add(this.Signupusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSignup);
            this.MaximizeBox = false;
            this.Name = "Signup";
            this.Text = "Signup Form";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSignup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Signupusername;
        private System.Windows.Forms.TextBox Signuppassword;
        private System.Windows.Forms.Button Regbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Signuprole;
        private System.Windows.Forms.Button Alreadybtn;
    }
}

