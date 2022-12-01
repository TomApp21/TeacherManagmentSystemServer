using ClassLibrary.DataAccess;
using ClassLibrary.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Mocks
{
    public static class MockRepository
    {
        public static Mock<IDataAccess> GetRepository()
        {
            var classes = new List<ClassModel>
            {
                new ClassModel { ClassId = 1, ModuleCode = "1234", ClassName = "Maths", TeacherId = 1, StudentId = new List<int>() { 1, 2, 3 }, Assignments = new Dictionary<int, double> { { 1, 2 }, { 2, 3 }, { 3, 5 } } },         // efill whole model out
                new ClassModel { ClassId = 2, ModuleCode = "2345", ClassName = "Geography", TeacherId = 1, StudentId = new List<int>() { 1, 2, 3 }, Assignments = new Dictionary<int, double> { { 1, 4 }, { 2, 0 }, { 3, 2 } } },
                new ClassModel { ClassId = 3, ModuleCode = "3456", ClassName = "English", TeacherId = 2, StudentId = new List<int>() { 1 }, Assignments = new Dictionary<int, double> { { 2, 0 } } }
            };

            var mockRepo = new Mock<IDataAccess>();

            mockRepo.Setup(r => r.GetClassList()).Returns(classes);

            mockRepo.Setup(r => r.InsertClass()

        }
    }
}
