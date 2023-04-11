using Entities;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerNew
{
    public class DTestHistory
    {
        
        public static void SaveResult(TestHistory testHistory)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "TestHistory_Insert"
                    , testHistory.UserID
                    , testHistory.SubjectID
                    , testHistory.TestDate
                    , testHistory.CorrectAnswer
                    , testHistory.TotalQuestion
                    , testHistory.Mark
                    , testHistory.CreatedBy);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static DataTable GetLeaderBoard(TestHistory testHistory)
        {
            try
            {
               DataTable dtData = SqlHelper.ExecuteDataset(TestCore.ConnectionString.strCon, "TestHistory_LeaderBoard"
                    ,new SqlParameter("@SubjectID",testHistory.SubjectID)).Tables[0];
                return dtData;
                   
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static DataTable GetReportBySubject(string SubjectID)
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteDataset(TestCore.ConnectionString.strCon, "TestHistory_ReportBySubject"
                     , new SqlParameter("@SubjectID", SubjectID)).Tables[0];
                return dtData;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static DataTable GetReportByTime(DateTime startDate,DateTime endDate)
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteDataset(TestCore.ConnectionString.strCon, "TestHistory_ReportByTime"
                     , new SqlParameter("@StartDate", startDate),new SqlParameter("@EndDate",endDate)).Tables[0];
                return dtData;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
