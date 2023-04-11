using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DataAccessLayer
{
    
    public class DUserRole
    {
        
        public static void addNewUser(UserAccout newUser)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "UserAccout_Insert", newUser.RoleID
                    , newUser.UserName
                    , newUser.PassWord
                    , newUser.FullName
                    , newUser.Email
                    , newUser.PhoneNumber
                    , newUser.Address
                    , newUser.Birthday
                    , newUser.Note
                    , newUser.CreatedBy
                    , newUser.ModifiedBy
                   );
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static void UpdateUser(UserAccout editUser)
        {
            try

            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "UserAccout_Update", editUser.RoleID
                    , editUser.UserName
                    , editUser.PassWord
                    , editUser.FullName
                    , editUser.Email
                    , editUser.PhoneNumber
                    , editUser.Address
                    , editUser.Birthday
                    , editUser.Note
                    , editUser.ModifiedBy
                    , editUser.UserID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static void DeleteUser(int userID)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "UserID_delete", userID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static DataTable GetAll()
        {
            DataTable dtData = SqlHelper.ExecuteDataset(TestCore.ConnectionString.strCon, CommandType.StoredProcedure, "UserRole_SelectAll").Tables[0];
            return dtData;
        }
        public static DataTable Search(string Keyword)
        {
            DataTable dtData = SqlHelper.ExecuteDataset(TestCore.ConnectionString.strCon, CommandType.StoredProcedure, "UserAccout_Search", new SqlParameter("@Keyword", Keyword)).Tables[0];
            return dtData;
        }
       
    }
}
