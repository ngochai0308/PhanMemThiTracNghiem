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
        private static string strCon = "Data Source=.;Initial Catalog=BaiTapCauHoi;Integrated Security=True";
        public static void addNewUser(UserAccout newUser)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "UserAccout_Insert", newUser.RoleID
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
                SqlHelper.ExecuteNonQuery(strCon, "UserAccout_Update", editUser.RoleID
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
                SqlHelper.ExecuteNonQuery(strCon, "UserID_delete", userID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static DataTable GetAll()
        {
            DataTable dtData = SqlHelper.ExecuteDataset(strCon, CommandType.StoredProcedure, "UserRole_SelectAll").Tables[0];
            return dtData;
        }
        public static DataTable Search(string Keyword)
        {
            DataTable dtData = SqlHelper.ExecuteDataset(strCon, CommandType.StoredProcedure, "UserAccout_Search", new SqlParameter("@Keyword", Keyword)).Tables[0];
            return dtData;
        }
       
    }
}
