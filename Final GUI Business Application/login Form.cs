using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_GUI_Business_Application.BL;
using Final_GUI_Business_Application.DL;

namespace Final_GUI_Business_Application
{
    public partial class login_Form : Form
    {
        public login_Form()
        {
            InitializeComponent();
        }
        private void ClearDataFromForm()
        {
            loginusername.Text = String.Empty;
            loginpassword.Text = String.Empty;
        }
        private void login_Form_Load(object sender, EventArgs e)
        {
                     
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string username = loginusername.Text;
            string password = loginpassword.Text;
            MUser user = new MUser(username, password);
            MUser validUser = MUserDL.Login(user);
            if(validUser.getUserName() == loginusername.Text && validUser.getPassword() == loginpassword.Text)
            {
                HomePage homePage = new HomePage();
                homePage.Show();
            }
            else
            {
                MessageBox.Show("User is Invalid");
            }
            ClearDataFromForm();
        }
    }
}
