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

namespace Final_GUI_Business_Application.UserControls
{
    public partial class AddEmployeeUC : UserControl
    {
        public AddEmployeeUC()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Regbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employee Added!");
        }
    }
}
