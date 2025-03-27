using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_GUI_Business_Application.BL
{
    internal class Admin
    {
        public Admin(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }


        private string name;
        private string password;
    }
}
