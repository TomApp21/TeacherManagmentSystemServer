using ClassLibrary.Models;

namespace ClassLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<TeacherModel> teachers = new List<TeacherModel>();

        private List<UserModel> users = new List<UserModel>();

        private List<ClassModel> classes = new List<ClassModel>();

        private List<StudentModel> students = new List<StudentModel>();

        public DemoDataAccess()
        {
            users.Add(new UserModel { UserId = 1, Name = "Stephen Wales", UserName = "stephenWales", Password = "P4ssw0rd.!", IsTeacher = true }); 
            users.Add(new UserModel { UserId = 2, Name = "Ian Giles", UserName = "ianGiles", Password = "P4ssw0rd.!", IsTeacher = true }) ;
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

        public List<UserModel> GetUsers()
        {
            return users;
        }

        public List<ClassModel> GetClassList()
        {
            return classes;
        }

        public List<ClassModel> InsertStudentToClass(string moduleCode, int classId, StudentModel student )
        {
            // WRONG***
            return classes;

        }



    }
}