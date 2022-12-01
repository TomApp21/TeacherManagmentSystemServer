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

            users.Add(new UserModel { UserId = 3, Name = "Sherrie Morris", UserName = "sherrieMorris", Password = "P4ssw0rd.!", IsTeacher = false }) ;
            users.Add(new UserModel { UserId = 4, Name = "Clare Shelton", UserName = "clareShelton", Password = "P4ssw0rd.!", IsTeacher = false }) ;
            users.Add(new UserModel { UserId = 5, Name = "Tracy Giles", UserName = "tracyGiles", Password = "P4ssw0rd.!", IsTeacher = false }) ;




            classes.Add(new ClassModel { ClassId = 1, ModuleCode = "1234", ClassName = "Maths", TeacherId = 1, StudentId = new List<int>() { 1, 2, 3 }, Assignments = new Dictionary<int, double> { { 1, 2 }, { 2, 3 }, { 3, 5 } }               }); // efill whole model out
            classes.Add(new ClassModel { ClassId = 2, ModuleCode = "2345", ClassName = "Geography", TeacherId = 1, StudentId = new List<int>() { 1, 2, 3 }, Assignments = new Dictionary<int, double> { { 1, 4 }, { 2, 0 }, {3,2 } } });
            classes.Add(new ClassModel { ClassId = 3, ModuleCode = "3456", ClassName = "English", TeacherId = 2, StudentId = new List<int>() { 1 }, Assignments = new Dictionary<int, double> { {  2, 0 } } });



            students.Add(new StudentModel { StudentId = 1, StudentName = "Ewan Giles", ClassIds = new List<int>() { 1, 2 }, ParentId = 5 });
            students.Add(new StudentModel { StudentId = 2, StudentName = "Tom Appleyard", ClassIds = new List<int>() { 1, 2 }, ParentId = 3 });
            students.Add(new StudentModel { StudentId = 3, StudentName = "Saz Shelton", ClassIds = new List<int>() { 1 }, ParentId = 4 });



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

        public List<StudentModel> GetStudentList()
        {
            return students;
        }




        public ClassModel InsertClass(string className, DateTime startDate, DateTime endDate, int teacherId,  string moduleCode, List<int> studentIds, Dictionary<int, double> assignmentScores)
        {
            ClassModel c = new ClassModel() { ClassName = className, StartDate = startDate, EndDate = endDate, TeacherId = teacherId, ModuleCode = moduleCode, StudentId = studentIds, Assignments = assignmentScores };
            
            if (classes.Count == 0)
            {
                c.ClassId = 1;
            }
            else
            {
                c.ClassId = classes.Max(x => x.ClassId) + 1;
            }
            
            classes.Add(c);

            return c;
        }

        public void InsertStudentMark(int studentId, int classId, double studentMark)
        {
            var x = classes.Where(x => x.ClassId == classId).FirstOrDefault();
            if (x.Assignments.ContainsKey(studentId))
            {
                 x.Assignments[studentId] = studentMark;
            }           
            else
            {
                x.Assignments.Add(studentId, studentMark);
            }

            
            //Select(x => x.Assignments).FirstOrDefault();
            // x[studentId] = studentMark;
        }

        public bool InsertStudentToClass(int parentId, string moduleCode)
        {
            bool blnSuccess = false;

            var c = classes.Where(x => x.ModuleCode == moduleCode).FirstOrDefault();

            if (c != null)
            {
                var s = students.Where(x => x.ParentId == parentId).FirstOrDefault();
                c.StudentId.Add(s.StudentId);
                c.Assignments.Add(s.StudentId, 0);
                s.ClassIds.Add(c.ClassId);
                blnSuccess = true;
            }

            return blnSuccess;


            
        }


        public void RemoveClass(int classId)
        {
            ClassModel c = (ClassModel)classes.Where(x => x.ClassId == classId).FirstOrDefault();
            classes.Remove(c);

            foreach (var student in students)
            {
                if (student.ClassIds.Contains(classId))
                {
                    student.ClassIds.Remove(classId);
                }
            }



            // remove CLASS FROM ALL STUDENTS?

        }


    }
}