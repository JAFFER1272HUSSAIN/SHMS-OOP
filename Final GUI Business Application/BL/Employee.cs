using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_GUI_Business_Application.BL
{
    internal class Employee
    {
        public Employee(Person user, float age, string contact)
        {
            CurrentUser = user;
            this.Age = age;
            this.Contact = contact;
            
        }

        public string Contact { get => contact; set => contact = value; }
        public float Age { get => age; set => age = value; }
        public Person CurrentUser { get => currentUser; set => currentUser = value; }
        private string contact;
        private float age;
        private Person currentUser;
    }
}
