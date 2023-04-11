using DataAccessLayer;
using Entities;
using System.Data;

namespace BusinessLogicLayer
{
    public class BQuestion
    {


        public static void AddNewQuestion(Question newQuestion)
        {
            DQuestion.addNewQuestion(newQuestion);
        }
        public static void UpdateQuestion(Question editQuestion)
        {
            DQuestion.UpdateQuestion(editQuestion);
        }
        public static void DeleteQuestion(int QuestionID)
        {
            DQuestion.DeleteQuestion(QuestionID);
        }
        public static DataTable GetAll()
        {
            return DQuestion.GetAll();
        }
        public static DataTable Search(string Keyword)
        {
            return DQuestion.Search(Keyword);
        }

        public static DataTable GetQuestionForTest(string subjectID, int numberOfQuestion)
        {
            return DQuestion.GetQuestionForTest(subjectID, numberOfQuestion);
        }
        public static Question GetOne(int questionID)
        {
            return DQuestion.GetOne(questionID);
        }
    }
}
