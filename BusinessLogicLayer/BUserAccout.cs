using Entities;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BusinessLogicLayer
{
    public class BUserAccout
    {
        public static bool IsExistsAccout(UserAccout user)
        {
            return DUserAccout.IsExistsAccout(user);
        }
        public static void UpdatePassword(UserAccout user)
        {
            DUserAccout.UpdatePassword(user);
        }
        public static void AddNewUser(UserAccout newUser)
        {
            DUserAccout.addNewUser(newUser);
        }
        public static void UpdateUser(UserAccout editUser)
        {
            DUserAccout.UpdateUser(editUser);
        }
        public static void DeleteUser(int userID)
        {
            DUserAccout.DeleteUser(userID);
        }
        public static DataTable GetAll()
        {
            return DUserAccout.GetAll();
        }
        public static DataTable Search(string Keyword,string roleFilter)
        {
            return DUserAccout.Search(Keyword,roleFilter);
        }
        public static UserAccout GetUserInfor(string username)
        {
            return DUserAccout.GetUserInfor(username);
        }
    }
}
