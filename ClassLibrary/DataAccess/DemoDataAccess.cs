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

            classes.Add(new ClassModel { ClassId = 1, ClassName = "Maths", TeacherId = 1, StudentId = new List<int>() { 1, 2 } }); // efill whole model out
            classes.Add(new ClassModel { ClassId = 2, ClassName = "Geography", TeacherId = 1, StudentId = new List<int>() { 1 } });


            students.Add(new StudentModel { StudentId = 1, StudentName = "Ewan Giles", ClassIds = new List<int>() { 1, 2 }, });
            students.Add(new StudentModel { StudentId = 2, StudentName = "Tom Appleyard", ClassIds = new List<int>() { 1 }, });


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


        public ClassModel InsertClass(string className, DateTime startDate, DateTime endDate, int teacherId,  string moduleCode, List<int> studentIds, Dictionary<int, double> assignmentScores)
        {
            ClassModel c = new ClassModel() { ClassName = className, StartDate = startDate, EndDate = endDate, TeacherId = teacherId, ModuleCode = moduleCode, StudentId = studentIds, Assignments = assignmentScores };
            c.ClassId = classes.Max(x => x.ClassId) + 1;
            classes.Add(c);

            return c;
        }

        public void RemoveClass(int classId)
        {
            ClassModel c = (ClassModel)classes.Where(x => x.ClassId == classId).FirstOrDefault();
            classes.Remove(c);

            // remove CLASS FROM ALL STUDENTS?

        }


    }
}