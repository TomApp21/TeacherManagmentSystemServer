using ClassLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Commands
{
    public class InsertClassCommand : IRequest<ClassModel>
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TeacherId { get; set; }
        public List<int> StudentId { get; set; }
        public Dictionary<int, double> Assignments { get; set; }
        public string ModuleCode { get; set; }



        public InsertClassCommand(string className, string startDate, string endDate, string teacherId, string moduleCode)
        {
            ClassName = className;
            StartDate = Convert.ToDateTime(startDate);
            EndDate = Convert.ToDateTime(endDate);
                        TeacherId = Convert.ToInt32(teacherId);
            ModuleCode = moduleCode;

            StudentId = new List<int>();
            Assignments = new Dictionary<int, double>();
        }

    }
}
