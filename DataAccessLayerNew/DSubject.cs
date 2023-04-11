using Entities;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{

    public class DSubject
    {
        
       
        public static void addNewSubject(Subject newSubject)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "Subject_insert"
                    , newSubject.SubjectID
                    , newSubject.SubjectName
                    , newSubject.Description
                    , newSubject.CreatedBy
                    ,newSubject.ModifiedBy);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static void UpdateSubject(Subject editSubject)
        {
            try

            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "Subject_Update"
                    , editSubject.SubjectID
                    , editSubject.SubjectName
                    , editSubject.Description
                    , editSubject.ModifiedBy);
                    
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static void DeleteSubject(string subjectID)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "Subject_Delete", subjectID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static DataTable GetAll()
        {
            DataTable dtData = SqlHelper.ExecuteDataset(TestCore.ConnectionString.strCon, CommandType.StoredProcedure, "Subject_SelectAll").Tables[0];
            return dtData;
        }
        public static DataTable Search(string Keyword)
        {
            DataTable dtData = SqlHelper.ExecuteDataset(TestCore.ConnectionString.strCon, CommandType.StoredProcedure, "Subject_search", new SqlParameter("@Keyword", Keyword)).Tables[0];
            return dtData;
        }
       
    }
}
