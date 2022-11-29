using ClassLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class StudentModel
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public List<int> ClassIds { get; set; }
        public int ParentId { get; set; }
            public MessageTypeEnum messageType { get;set; }

    }
}
