using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class ClassModel
    {
        public int ClassId { get; set; }
        public int ClassName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TeacherId { get; set; }
        public List<StudentModel> Students { get; set; }
        public Dictionary<int, double> Assignments { get; set; }

        public int ModuleCode { get; set; }
    }
}
