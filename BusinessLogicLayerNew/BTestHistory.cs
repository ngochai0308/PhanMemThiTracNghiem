using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayerNew;
using System.Data;

namespace BusinessLogicLayerNew
{
     public class BTestHistory
    {

        public static void SaveResult(TestHistory testHistory)
        {
            DTestHistory.SaveResult(testHistory);
        }
        public static DataTable GetLeaderBoard(TestHistory testHistory)
        {
            return DTestHistory.GetLeaderBoard(testHistory);
        }    
        public static DataTable GetReportBySubject(string subjectID)
        {
            return DTestHistory.GetReportBySubject(subjectID);
        }
        public static DataTable GetReportByTime(DateTime startDate, DateTime endDate)
        {
            return DTestHistory.GetReportByTime(startDate, endDate);

        }
    }
}
