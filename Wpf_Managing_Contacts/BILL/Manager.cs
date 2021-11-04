using DAL;
using Model;
using System;
using System.Collections.Generic;
namespace BLL
{
    public class Manager
    {
        //Manager Contact
        public static bool AddContact(Contact newContact)
        {
            return Services.AddContactToDataStorage(newContact);
        }

        public static List<Contact> GetAllContacts()
        {
            return Services.GetAllContactsFromDataStorage();
        }

        public static Contact GetContactById(int idContact)
        {
            return Services.GetContactById(idContact);
        }

        public static bool DeleteContactById(int id)
        {
           return Services.DeleteContactToDataStorage(id);
        }

        public static bool SetContactById(Contact co)
        {
            return Services.SetContactById(co);
        }
        //Manager User
        public static bool AddUser(User newUser)
        {
            return Services.AddUserToDataStorage(newUser);
        }
        public static User GetUserById(int idUser)
        {
            return Services.GetUserById(idUser);
        }
        public static User GetValidateUserForLogin(string nameUser, string pwdUser)
        {
            return Services.GetValidateUserForLoginToDataStorage(nameUser,pwdUser);
        }
        public static bool DeleteUserById(int id)
        {
            return Services.DeleteUserToDataStorage(id);
        }
        public static bool SetUserById(User us)
        {
            return Services.SetUserById(us);
        }
        public static List<User> GetAllUser()
        {
            return Services.GetAllUserDataStorage();
        }
        //Manager Roles
        public static bool AddRole(Role newRole)
        {
            return Services.AddRoleToDataStorage(newRole);
        }
        public static Role GetRoleById(int idRole)
        {
            return Services.GetRoleByIdDataStorage(idRole);
        }
        public static List<Role> GetAllRoles()
        {
            return Services.GetAllRolesFromDataStorage();
        }
        public static bool SetRoleById(Role co)
        {
            return Services.SetRoleByIdDataStorage(co);
        }
        public static bool DeleteRoleById(int id)
        {
            return Services.DeleteRoleToDataStorage(id);
        }
    }
}
