using ClassLibrary.Models;

namespace ClassLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<TeacherModel> teachers = new List<TeacherModel>();

        public DemoDataAccess()
        {
            teachers.Add(new TeacherModel { UserId = 1, Name = "Stephen Wales", UserName = "stephenWales", Password = "P4ssw0rd.!", ClassIds = new List<int> { 1, 2 } });
            teachers.Add(new TeacherModel { UserId = 2, Name = "Ian Giles", UserName = "ianGiles", Password = "P4ssw0rd.!", ClassIds = new List<int> { 3, 4 } });

        }

        public List<TeacherModel> GetTeachers()
        {
            return teachers;
        }

        public TeacherModel InsertTeacher(string name, string userName, string password, List<int> classIds)
        {
            TeacherModel t = new TeacherModel() { Name = name, UserName = userName, Password = password, ClassIds = classIds };
            t.UserId = teachers.Max(x => x.UserId) + 1;
            teachers.Add(t);

            return t;
        }

    }
}