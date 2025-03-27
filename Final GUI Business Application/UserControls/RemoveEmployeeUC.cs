using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_GUI_Business_Application.UserControls
{
    public partial class RemoveEmployeeUC : UserControl
    {
        public RemoveEmployeeUC()
        {
            InitializeComponent();
        }

        private void Regbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employee has been Removed Successfully!");
        }
    }
}
