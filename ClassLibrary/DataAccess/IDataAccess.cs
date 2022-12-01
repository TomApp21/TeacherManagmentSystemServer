using ClassLibrary.Models;

namespace ClassLibrary.DataAccess
{
    public interface IDataAccess
    {
        List<TeacherModel> GetTeachers();
        TeacherModel InsertTeacher(string name, string userName, string password, List<int> classIds);

        List<UserModel> GetUsers();

        List<ClassModel> GetClassList();

        List<StudentModel> GetStudentList();
        ClassModel InsertClass(string className, DateTime startDate, DateTime endDate, int teacherId,  string moduleCode, List<int> studentIds, Dictionary<int, double> assignmentScores);

        void RemoveClass(int classId);

        void InsertStudentMark(int studentId, int classId, double studentMark);

        bool InsertStudentToClass(int studentId, string moduleCode);

    }
}