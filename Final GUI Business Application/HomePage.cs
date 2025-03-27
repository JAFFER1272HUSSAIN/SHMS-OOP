using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_GUI_Business_Application
{
    public partial class HomePage : Form
    {
        bool sidebarExpand = true;
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addEmployeeUC1.Hide();
            clientsViewUC1.Hide();
            removeEmployeeUC1.Hide();
            viewEmployeeUC1.Hide();

            homeUserControl1.Show();
            homeUserControl1.BringToFront();
        }

        private void SliderTimer_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                sidebar.Width -= 10;
                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    SliderTimer.Stop(); 
                }
            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    SliderTimer.Stop();
                }
            }

        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            SliderTimer.Start();
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            homeUserControl1.Hide();
            clientsViewUC1.Hide();
            removeEmployeeUC1.Hide();
            viewEmployeeUC1.Hide();

            addEmployeeUC1.Show();
            addEmployeeUC1.BringToFront();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Removebtn_Click(object sender, EventArgs e)
        {
            addEmployeeUC1.Hide();
            clientsViewUC1.Hide();
            homeUserControl1.Hide();
            viewEmployeeUC1.Hide();

            removeEmployeeUC1.Show();
            removeEmployeeUC1.BringToFront();
        }

        private void Viewbtn_Click(object sender, EventArgs e)
        {
            addEmployeeUC1.Hide();
            clientsViewUC1.Hide();
            removeEmployeeUC1.Hide();
            homeUserControl1.Hide();

            viewEmployeeUC1.Show();
            viewEmployeeUC1.BringToFront();
        }

        private void Clientbtn_Click(object sender, EventArgs e)
        {
            addEmployeeUC1.Hide();
            homeUserControl1.Hide();
            removeEmployeeUC1.Hide();
            viewEmployeeUC1.Hide();

            clientsViewUC1.Show();
            clientsViewUC1.BringToFront();
        }
    }
}
