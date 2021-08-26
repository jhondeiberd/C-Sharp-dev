using Model;
using System.Collections.Generic;
using System.IO;

namespace DAL
{
    public static class Services
    {
        public static string filePath = "../../contacts.txt";
        public static string filePathRole = "../../roles.txt";
        public static string filePathUser = "../../users.txt";

        //Services Contacts
        public static bool AddContactToDataStorage(Contact contToAdd)
        {
            string str = string.Format("{0},{1},{2},{3}\n", contToAdd.Id, contToAdd.Name, contToAdd.Address,contToAdd.CellPhone);
            File.AppendAllText(filePath, str);
            return true;
        }
        public static List<Contact> GetAllContactsFromDataStorage()
        {
            List<Contact> contacts = new List<Contact>();
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] data = line.Split(',');
                    contacts.Add(new Contact
                    {
                        Id = int.Parse(data[0]),
                        Name = data[1].ToString(),
                        Address = data[2].ToString(),
                        CellPhone = long.Parse(data[3])
                    });
                }
            }
            catch (FileNotFoundException)
            { }
            return contacts;
        }
        public static Contact GetContactById(int ContactNumber)
        {
            Contact foundContact = null;
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                if (int.Parse(data[0]) == ContactNumber)
                {
                    foundContact = new Contact
                    {
                        Id = int.Parse(data[0]),
                        Name = data[1],
                        Address = data[2],
                        CellPhone = long.Parse(data[3])
                    };
                    break;
                }
            }
            return foundContact;
        }

        public static bool DeleteContactToDataStorage(int id)
        {
            bool validate = false;
            string[] lines = File.ReadAllLines(filePath);
            string[] newLines = new string[lines.Length-1];
            int j = 0;
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                if (int.Parse(data[0]) == id)
                {   validate = true;  }
                else
                {   newLines[j] = string.Format("{0},{1},{2},{3}", data[0], data[1], data[2], data[3]); j++; }             
                
            }
            File.WriteAllLines(filePath, newLines);
            return validate;
        }
        public static bool SetContactById(Contact co)
        {
            bool validate = false;
            string[] lines = File.ReadAllLines(filePath);
            string[] newLines = new string[lines.Length];
            int j = 0;
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                if (int.Parse(data[0]) == co.Id)
                {
                    newLines[j] = string.Format("{0},{1},{2},{3}", data[0], co.Name, co.Address, co.CellPhone);
                    validate = true;
                }
                else
                {   newLines[j] = string.Format("{0},{1},{2},{3}", data[0], data[1], data[2], data[3]);    }
                j++;
            }
            File.WriteAllLines(filePath, newLines);
            return validate;
        }
        ///Services User///
        public static bool AddUserToDataStorage(User userToAdd)
        {
            string str = string.Format("" +
                "\n{0},{1},{2},{3}", userToAdd.Id, userToAdd.Name, userToAdd.Password, userToAdd.RoleUser);
            File.AppendAllText(filePathUser, str);
            return true;
        }
        public static List<User> GetAllUserFromDataStorage()
        {
            List<User> user = new List<User>();
            try
            {
                string[] lines = File.ReadAllLines(filePathUser);
                foreach (string line in lines)
                {
                    string[] data = line.Split(',');
                    user.Add(new User
                    {
                        Id = int.Parse(data[0]),
                        Name = data[1].ToString(),
                        Password = data[2].ToString(),
                        RoleUser = data[3].ToString(),
                    });
                }
            }
            catch (FileNotFoundException)
            { }
            return user;
        }
        public static User GetUserById(int id)
        {
            User foundUser = null;
            string[] lines = File.ReadAllLines(filePathUser);
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                if (int.Parse(data[0]) == id)
                {
                    foundUser = new User
                    {
                        Id = int.Parse(data[0]),
                        Name = data[1],
                        Password = data[2],
                        RoleUser = data[3]
                    };
                    break;
                }
            }
            return foundUser;
        }
        public static bool SetUserById(User us)
        {
            bool validate = false;
            string[] lines = File.ReadAllLines(filePathUser);
            string[] newLines = new string[lines.Length];
            int j = 0;
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                if (int.Parse(data[0]) == us.Id)
                {
                    newLines[j] = string.Format("{0},{1},{2},{3}", data[0], us.Name, us.Password, us.RoleUser);
                    validate = true;
                }
                else
                { newLines[j] = string.Format("{0},{1},{2},{3}", data[0], data[1], data[2], data[3]); }
                j++;
            }
            File.WriteAllLines(filePathUser, newLines);
            return validate;
        }
        public static User GetValidateUserForLoginToDataStorage(string NameUser,string pwdUser)
        {
            User foundUser = null;
            string[] lines = File.ReadAllLines(filePathUser);
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                if ((data[1]) == NameUser && data[2]==pwdUser)
                {
                    foundUser = new User
                    {
                        Id = int.Parse(data[0]),
                        Name = data[1],
                        Password = data[2],
                        RoleUser = data[3]
                    };
                    break;
                }
            }
            return foundUser;
        }
        public static bool DeleteUserToDataStorage(int id)
        {
            bool validate = false;
            string[] lines = File.ReadAllLines(filePathUser);
            string[] newLines = new string[lines.Length - 1];
            int j = 0;
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                if (int.Parse(data[0]) == id)
                { validate = true; }
                else
                { newLines[j] = string.Format("{0},{1},{2},{3}", data[0], data[1], data[2], data[3]); j++; }

            }
            File.WriteAllLines(filePathUser, newLines);
            return validate;
        }
        public static List<User> GetAllUserDataStorage()
        {
            List<User> user = new List<User>();
            try
            {
                string[] lines = File.ReadAllLines(filePathUser);
                foreach (string line in lines)
                {
                    string[] data = line.Split(',');
                    user.Add(new User
                    {
                        Id = int.Parse(data[0]),
                        Name = data[1].ToString(),
                        Password = data[2].ToString(),
                        RoleUser = data[3].ToString(),
                    });
                }
            }
            catch (FileNotFoundException)
            { }
            return user;
        }



        //Services Roles
        public static List<Role> GetAllRolesFromDataStorage()
        {
            List<Role> roles = new List<Role>();
            try
            {
                string[] lines = File.ReadAllLines(filePathRole);
                foreach (string line in lines)
                {
                    string[] data = line.Split(',');
                    roles.Add(new Role
                    {
                        Id = int.Parse(data[0]),
                        Name = data[1].ToString(),
                    });
                }
            }
            catch (FileNotFoundException)
            { }
            return roles;
        }
        public static bool AddRoleToDataStorage(Role roToAdd)
        {
            string str = string.Format("{0},{1}\n", roToAdd.Id, roToAdd.Name);
            File.AppendAllText(filePathRole, str);
            return true;
        }
        public static Role GetRoleByIdDataStorage(int RoleNumber)
        {
            Role foundRole = null;
            string[] lines = File.ReadAllLines(filePathRole);
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                if (int.Parse(data[0]) == RoleNumber)
                {
                    foundRole = new Role
                    {
                        Id = int.Parse(data[0]),
                        Name = data[1],
                    };
                    break;
                }
            }
            return foundRole;
        }
        public static bool SetRoleByIdDataStorage(Role ro)
        {
            bool validate = false;
            string[] lines = File.ReadAllLines(filePathRole);
            string[] newLines = new string[lines.Length];
            int j = 0;
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                if (int.Parse(data[0]) == ro.Id)
                {
                    newLines[j] = string.Format("{0},{1}", data[0], ro.Name);
                    validate = true;
                }
                else
                { newLines[j] = string.Format("{0},{1}", data[0], data[1]); }
                j++;
            }
            File.WriteAllLines(filePathRole, newLines);
            return validate;
        }
        public static bool DeleteRoleToDataStorage(int id)
        {
            bool validate = false;
            string[] lines = File.ReadAllLines(filePathRole);
            string[] newLines = new string[lines.Length - 1];
            int j = 0;
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                if (int.Parse(data[0]) == id)
                { validate = true; }
                else
                { newLines[j] = string.Format("{0},{1}", data[0], data[1]); j++; }

            }
            File.WriteAllLines(filePathRole, newLines);
            return validate;
        }

    }
}
