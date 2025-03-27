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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
            string path = "data.txt";
            if(MUserDL.ReadDataFromFile(path))
            {
                MessageBox.Show("Data Loaded From the File");
            }
            else
            {
                MessageBox.Show("Data not Loaded");
            }
        }
        private void ClearDataFromForm()
        {
            Signupusername.Text = String.Empty;
            Signuppassword.Text = String.Empty;
            Signuprole.Text = String.Empty;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void Regbtn_Click(object sender, EventArgs e)
        {
            string username = Signupusername.Text;
            string pass = Signuppassword.Text;
            string r = Signuprole.Text;
            string path = "data.txt";
            MUser user = new MUser(username, pass, r);
            MUserDL.AddUserIntoList(user);
            MUserDL.StoreUserIntoFile(user, path);
            MessageBox.Show("User Added Successfully");
            ClearDataFromForm();
        }

        private void Alreadybtn_Click(object sender, EventArgs e)
        {
            login_Form login_Form = new login_Form();
            login_Form.Show();
        }
    }
}
