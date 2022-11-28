using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class AssignmentModel
    {
        public int AssignmentId { get; set; }
        public int AssignmentName { get; set; }
        public string AssignmentTask { get; set; }
        public Double Mark { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }
    }
}
