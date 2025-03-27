namespace Final_GUI_Business_Application
{
    partial class HomePage
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
            this.components = new System.ComponentModel.Container();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SliderTimer = new System.Windows.Forms.Timer(this.components);
            this.menubtn = new System.Windows.Forms.PictureBox();
            this.Homebtn = new System.Windows.Forms.Button();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.Removebtn = new System.Windows.Forms.Button();
            this.Viewbtn = new System.Windows.Forms.Button();
            this.Clientbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addEmployeeUC1 = new Final_GUI_Business_Application.UserControls.AddEmployeeUC();
            this.clientsViewUC1 = new Final_GUI_Business_Application.UserControls.ClientsViewUC();
            this.removeEmployeeUC1 = new Final_GUI_Business_Application.UserControls.RemoveEmployeeUC();
            this.viewEmployeeUC1 = new Final_GUI_Business_Application.UserControls.ViewEmployeeUC();
            this.homeUserControl1 = new Final_GUI_Business_Application.UserControls.HomeUserControl();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menubtn)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.Homebtn);
            this.sidebar.Controls.Add(this.AddEmployee);
            this.sidebar.Controls.Add(this.Removebtn);
            this.sidebar.Controls.Add(this.Viewbtn);
            this.sidebar.Controls.Add(this.Clientbtn);
            this.sidebar.Controls.Add(this.button1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(209, 450);
            this.sidebar.MinimumSize = new System.Drawing.Size(67, 450);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(209, 450);
            this.sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menubtn);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(65, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // SliderTimer
            // 
            this.SliderTimer.Enabled = true;
            this.SliderTimer.Interval = 10;
            this.SliderTimer.Tick += new System.EventHandler(this.SliderTimer_Tick);
            // 
            // menubtn
            // 
            this.menubtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menubtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menubtn.Image = global::Final_GUI_Business_Application.Properties.Resources.Menu;
            this.menubtn.Location = new System.Drawing.Point(9, 26);
            this.menubtn.Name = "menubtn";
            this.menubtn.Size = new System.Drawing.Size(50, 41);
            this.menubtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menubtn.TabIndex = 0;
            this.menubtn.TabStop = false;
            this.menubtn.Click += new System.EventHandler(this.menubtn_Click);
            // 
            // Homebtn
            // 
            this.Homebtn.BackColor = System.Drawing.Color.Transparent;
            this.Homebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Homebtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Homebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Homebtn.Image = global::Final_GUI_Business_Application.Properties.Resources._1Home;
            this.Homebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Homebtn.Location = new System.Drawing.Point(3, 109);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(206, 49);
            this.Homebtn.TabIndex = 1;
            this.Homebtn.Text = "                Home";
            this.Homebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Homebtn.UseVisualStyleBackColor = false;
            this.Homebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddEmployee
            // 
            this.AddEmployee.BackColor = System.Drawing.Color.Transparent;
            this.AddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployee.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddEmployee.Image = global::Final_GUI_Business_Application.Properties.Resources.Add_Emp_Male;
            this.AddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddEmployee.Location = new System.Drawing.Point(3, 164);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(206, 49);
            this.AddEmployee.TabIndex = 2;
            this.AddEmployee.Text = "                AddEmployee";
            this.AddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddEmployee.UseVisualStyleBackColor = false;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // Removebtn
            // 
            this.Removebtn.BackColor = System.Drawing.Color.Transparent;
            this.Removebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Removebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Removebtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Removebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Removebtn.Image = global::Final_GUI_Business_Application.Properties.Resources.Denied_Emp;
            this.Removebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Removebtn.Location = new System.Drawing.Point(3, 219);
            this.Removebtn.Name = "Removebtn";
            this.Removebtn.Size = new System.Drawing.Size(206, 49);
            this.Removebtn.TabIndex = 3;
            this.Removebtn.Text = "               RemoveEmployee";
            this.Removebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Removebtn.UseVisualStyleBackColor = false;
            this.Removebtn.Click += new System.EventHandler(this.Removebtn_Click);
            // 
            // Viewbtn
            // 
            this.Viewbtn.BackColor = System.Drawing.Color.Transparent;
            this.Viewbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Viewbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Viewbtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Viewbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Viewbtn.Image = global::Final_GUI_Business_Application.Properties.Resources.allUsers;
            this.Viewbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Viewbtn.Location = new System.Drawing.Point(3, 274);
            this.Viewbtn.Name = "Viewbtn";
            this.Viewbtn.Size = new System.Drawing.Size(206, 49);
            this.Viewbtn.TabIndex = 4;
            this.Viewbtn.Text = "               View Employee";
            this.Viewbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Viewbtn.UseVisualStyleBackColor = false;
            this.Viewbtn.Click += new System.EventHandler(this.Viewbtn_Click);
            // 
            // Clientbtn
            // 
            this.Clientbtn.BackColor = System.Drawing.Color.Transparent;
            this.Clientbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clientbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clientbtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clientbtn.Image = global::Final_GUI_Business_Application.Properties.Resources.Permanent_Job1;
            this.Clientbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clientbtn.Location = new System.Drawing.Point(3, 329);
            this.Clientbtn.Name = "Clientbtn";
            this.Clientbtn.Size = new System.Drawing.Size(206, 49);
            this.Clientbtn.TabIndex = 5;
            this.Clientbtn.Text = "               Clients Deal";
            this.Clientbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clientbtn.UseVisualStyleBackColor = false;
            this.Clientbtn.Click += new System.EventHandler(this.Clientbtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::Final_GUI_Business_Application.Properties.Resources.Logout_Rounded_Left;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "               Logout";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // addEmployeeUC1
            // 
            this.addEmployeeUC1.Location = new System.Drawing.Point(219, 42);
            this.addEmployeeUC1.Name = "addEmployeeUC1";
            this.addEmployeeUC1.Size = new System.Drawing.Size(569, 393);
            this.addEmployeeUC1.TabIndex = 1;
            // 
            // clientsViewUC1
            // 
            this.clientsViewUC1.Location = new System.Drawing.Point(215, 12);
            this.clientsViewUC1.Name = "clientsViewUC1";
            this.clientsViewUC1.Size = new System.Drawing.Size(606, 426);
            this.clientsViewUC1.TabIndex = 2;
            // 
            // removeEmployeeUC1
            // 
            this.removeEmployeeUC1.Location = new System.Drawing.Point(215, 29);
            this.removeEmployeeUC1.Name = "removeEmployeeUC1";
            this.removeEmployeeUC1.Size = new System.Drawing.Size(585, 409);
            this.removeEmployeeUC1.TabIndex = 3;
            // 
            // viewEmployeeUC1
            // 
            this.viewEmployeeUC1.Location = new System.Drawing.Point(219, 42);
            this.viewEmployeeUC1.Name = "viewEmployeeUC1";
            this.viewEmployeeUC1.Size = new System.Drawing.Size(602, 391);
            this.viewEmployeeUC1.TabIndex = 4;
            // 
            // homeUserControl1
            // 
            this.homeUserControl1.Location = new System.Drawing.Point(219, 29);
            this.homeUserControl1.Name = "homeUserControl1";
            this.homeUserControl1.Size = new System.Drawing.Size(602, 409);
            this.homeUserControl1.TabIndex = 5;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.homeUserControl1);
            this.Controls.Add(this.viewEmployeeUC1);
            this.Controls.Add(this.removeEmployeeUC1);
            this.Controls.Add(this.clientsViewUC1);
            this.Controls.Add(this.addEmployeeUC1);
            this.Controls.Add(this.sidebar);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menubtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Homebtn;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.Button Removebtn;
        private System.Windows.Forms.Button Viewbtn;
        private System.Windows.Forms.Button Clientbtn;
        private System.Windows.Forms.PictureBox menubtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer SliderTimer;
        private System.Windows.Forms.Button button1;
        private UserControls.AddEmployeeUC addEmployeeUC1;
        private UserControls.ClientsViewUC clientsViewUC1;
        private UserControls.RemoveEmployeeUC removeEmployeeUC1;
        private UserControls.ViewEmployeeUC viewEmployeeUC1;
        private UserControls.HomeUserControl homeUserControl1;
    }
}