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
    public class BUserRole
    {
    
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
            return DUserRole.GetAll();
        }
        public static DataTable Search(string Keyword,string roleID)
        {
            return DUserAccout.Search(Keyword,roleID);
        }
        
    }
}
