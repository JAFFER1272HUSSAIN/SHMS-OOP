using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_GUI_Business_Application.BL;
using System.IO;

namespace Final_GUI_Business_Application.DL
{
    internal class MUserDL
    {
        private static List<MUser> list = new List<MUser>();
        
        public static void AddUserIntoList(MUser user)
        {
            list.Add(user);
        }

        public static MUser Login(MUser user)
        {
            foreach(MUser u in list)
            {
                if(u.getUserName() == user.getUserName() && u.getPassword() == user.getPassword())
                {
                    return u;
                }
            }
            return null;
        }

        public static string ParseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[i];
                }
            }
            return item;
        }
        public static bool ReadDataFromFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader streamReader = new StreamReader(path);
                string record;
                while ((record = streamReader.ReadLine()) != null)
                {
                    string userName = ParseData(record, 1);
                    string password = ParseData(record, 2);
                    string role = ParseData(record, 3);
                    MUser user = new MUser(userName, password, role);
                    AddUserIntoList(user);
                }
                streamReader.Close();
                return true;
            }
            else { return false; }
        }
        public static void StoreUserIntoFile(MUser user, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.getUserName() + "," + user.getPassword() + "," + user.getRole());
            file.Flush();
            file.Close();
        }

    }
}
