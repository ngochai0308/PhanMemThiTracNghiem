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
    
    public class DUserAccout
    {
        
         public static bool IsExistsAccout(UserAccout user)
        {
            
            bool isExist = false;
            SqlConnection sqlCon = new SqlConnection(TestCore.ConnectionString.strCon);
            try
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("UserAccout_CheckExist", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", user.UserName);
                cmd.Parameters.AddWithValue("@PassWord", user.PassWord);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                    isExist = true;
                dataReader.Close();
                cmd.Dispose();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                sqlCon.Close();
            }
            return isExist;
        }
        public static void UpdatePassword(UserAccout user)
        {
            string strSql = "Data Source=.;Initial Catalog=BaiTapCauHoi;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(strSql);
            try
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("UserAccout_ChangePass", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", user.UserName);
                cmd.Parameters.AddWithValue("@NewPass", user.NewPass);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                sqlCon.Close();
            }

        }
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
            DataTable dtData = SqlHelper.ExecuteDataset(TestCore.ConnectionString.strCon, CommandType.StoredProcedure, "UserAccout_select").Tables[0];
            return dtData;
        }
        public static DataTable Search(string Keyword,string roleFilter)
        {
            DataTable dtData = SqlHelper.ExecuteDataset(TestCore.ConnectionString.strCon, CommandType.StoredProcedure, "UserAccout_Search", new SqlParameter("@Keyword", Keyword),new SqlParameter("@roleID", roleFilter)).Tables[0];
            return dtData;
        }
        //Get user infor by username
        public static UserAccout GetUserInfor(string username)
        {
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(TestCore.ConnectionString.strCon, CommandType.StoredProcedure, "UserAccout_GetUserInfor",
                                                                    new SqlParameter("@UserName", username));
                    UserAccout userAccout = new UserAccout();
                if(reader.Read())
                {
                    userAccout.RoleID = reader["RoleID"].ToString();
                    userAccout.UserName = reader["UserName"].ToString();
                    userAccout.FullName = reader["FullName"].ToString();
                    userAccout.Birthday =DateTime.Parse(reader["Birthday"].ToString());
                    userAccout.UserID = int.Parse(reader["UserID"].ToString());
                    userAccout.Address = reader["Address"].ToString();
                }
                reader.Close();
                return userAccout;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
       
    }
}
