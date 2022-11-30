using ClassLibrary.Enum;
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
        public string ClassName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TeacherId { get; set; }
        public List<int> StudentId { get; set; }
        public Dictionary<int, double> Assignments { get; set; }

        public string ModuleCode { get; set; }

        public MessageTypeEnum messageType { get;set; }


        public int NumStudents
        {
            get { return StudentId.Count; }
        }
    }
}
