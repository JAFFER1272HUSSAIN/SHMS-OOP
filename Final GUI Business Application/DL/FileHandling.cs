using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Final_GUI_Business_Application.BL;

namespace Final_GUI_Business_Application.DL
{
    internal class FileHandling
    {
        public static void WriteUsertoFile()
        {
            string path = "Users.txt";
            StreamWriter file = new StreamWriter(path);
            foreach (User TempUser in PersonDL.Persons1)
            {
                file.WriteLine(TempUser.Name + "," + TempUser.Password + "," + TempUser.Email);
            }
            file.Flush();
            file.Close();
        }
        public static void LoadUserFromFile()
        {
            string path = "Users.txt";
            StreamReader file = new StreamReader(path);
            string line;
            while (!(file.EndOfStream))
            {
                line = file.ReadLine();
                string[] word = line.Split(',');
                User GotUser = new User(word[0], word[1]);
                PersonDL.AddPerson(GotUser);
            }
            file.Close();
        }
        public static void LoadAdminFromFile()
        {
            string path = "Admins.txt";
            StreamReader file = new StreamReader(path);
            string line;
            while (!(file.EndOfStream))
            {
                line = file.ReadLine();
                string[] word = line.Split(',');
                Admin GotAdmin = new Admin(word[0], word[1]);
                AdminDL.AddAdmin(GotAdmin);
            }
            file.Close();
        }
        public static void WriteAdmintoFile()
        {
            string path = "Admins.txt";
            StreamWriter file = new StreamWriter(path);
            foreach (Admin TempAdmin in AdminDL.AdminList1)
            {
                file.WriteLine(TempAdmin.Name + "," + TempAdmin.Password);
            }
            file.Flush();
            file.Close();
        }
        public static void WriteEmpDatatoFile()
        {
            string path = "Employeedata.txt";
            StreamWriter file = new StreamWriter(path);
            foreach (Employee TempEmp in EmployeeDL.Employees)
            {
                file.WriteLine(TempEmp.CurrentUser.Name + "," + TempEmp.Age + "," + TempEmp.Contact);
            }
            file.Flush();
            file.Close();
        }

        public static void loadEmpData()
        {
            string path = "EmployeeData.txt";
            StreamReader file = new StreamReader(path);
            string line;
            while (!(file.EndOfStream))
            {
                line = file.ReadLine();
                string[] word = line.Split(',');
                float age;
                float.TryParse(word[1], out age);
                string contact = word[2];
                Person user = new Person(word[0]);
                if (user != null)
                {
                    Employee employee = new Employee(user, age,contact);
                }

            }
            file.Close();
        }
    }
}
