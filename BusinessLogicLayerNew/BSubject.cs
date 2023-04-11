using DataAccessLayer;
using Entities;
using System.Data;

namespace BusinessLogicLayer
{
    public class BSubject
    {

     
        public static void AddNewSubject(Subject newSubject)
        {
            DSubject.addNewSubject(newSubject);
        }
        public static void UpdateSubject(Subject editSubject)
        {
            DSubject.UpdateSubject(editSubject);
        }
        public static void DeleteSubject(string subjectID)
        {
            DSubject.DeleteSubject(subjectID);
        }
        public static DataTable GetAll()
        {
            return DSubject.GetAll();
        }
        public static DataTable Search(string Keyword)
        {
            return DSubject.Search(Keyword);
        }
    }
}
