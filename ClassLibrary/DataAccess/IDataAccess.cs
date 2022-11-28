using ClassLibrary.Models;

namespace ClassLibrary.DataAccess
{
    public interface IDataAccess
    {
        List<TeacherModel> GetTeachers();
        TeacherModel InsertTeacher(string name, string userName, string password, List<int> classIds);
    }
}