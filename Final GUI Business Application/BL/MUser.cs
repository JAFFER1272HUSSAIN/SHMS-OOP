using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_GUI_Business_Application.BL
{
    internal class MUser
    {
        private string username;
        private string password;
        private string role;

        public MUser() { }

        public MUser(string username,string password,string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public MUser (string username,  string password)
        {
            this.username = username;
            this.password = password;
            this.role = "NA";
        }
        public string getUserName()
        {
            return username;
        }
        public string getPassword()
        {
            return password;
        }

        public string getRole()
        {
            return role;
        }
        public bool isAdmin()
        {
            if(role == "Admin" || role == "admin")
            {
                return true;
            }
            return false;
        }

    }
}
