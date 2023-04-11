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
    
    public class DQuestion
    {
       
       
        public static void addNewQuestion(Question newQuestion)
        {
           

            try
            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "Question_insert"
                    , newQuestion.SubjectID
                    , newQuestion.Qcontent
                    , newQuestion.OptionA
                    , newQuestion.OptionB
                    , newQuestion.OptionC
                    , newQuestion.OptionD
                    , newQuestion.Answer
                    , newQuestion.CreatedBy);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static void UpdateQuestion(Question editQuestion)
        {
            try

            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "Question_Update"
                    , editQuestion.QuestionID
                    , editQuestion.SubjectID
                    , editQuestion.Qcontent
                    , editQuestion.OptionA
                    , editQuestion.OptionB
                    , editQuestion.OptionC
                    , editQuestion.OptionD
                    , editQuestion.Answer
                    , editQuestion.CreatedBy);


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static void DeleteQuestion(int QuestionID)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "Question_Delete", QuestionID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static DataTable GetAll()
        {
            DataTable dtData = SqlHelper.ExecuteDataset(TestCore.ConnectionString.strCon, CommandType.StoredProcedure, "Question_SelectAll").Tables[0];
            return dtData;
        }
        public static DataTable Search(string Keyword)
        {
            DataTable dtData = SqlHelper.ExecuteDataset(TestCore.ConnectionString.strCon, CommandType.StoredProcedure, "Question_search", new SqlParameter("@Keyword", Keyword)).Tables[0];
            return dtData;
        }
        public static DataTable GetQuestionForTest(string subjectID,int numberOfQuestion)
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteDataset(TestCore.ConnectionString.strCon, CommandType.StoredProcedure, "Question_GetQuestionForTest",
                new SqlParameter("@SubjectID", subjectID),
                new SqlParameter("@NumberOfQuestion", numberOfQuestion)).Tables[0];
                return dtData;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static Question GetOne(int questionID)
        {
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(TestCore.ConnectionString.strCon, CommandType.StoredProcedure, "Question_GetByID",
               new SqlParameter("@QuestionID", questionID));
               Question question = new Question();
                if(reader.Read())
                {
                    question.QuestionID = questionID;
                    question.Qcontent = reader["Qcontent"].ToString();
                    question.OptionA = reader["OptionA"].ToString();
                    question.OptionB = reader["OptionB"].ToString();
                    question.OptionC = reader["OptionC"].ToString();
                    question.OptionD = reader["OptionD"].ToString();
                    question.Answer = reader["Answer"].ToString();
                }
                reader.Close();
                return question;
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
    }
}
