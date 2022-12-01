using ClassLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Commands
{
    public class SubmitStudentMarkCommand : IRequest
    {
        public int ClassId { get; set; }
        public int StudentId { get; set; }
        public double StudentMark { get; set; }




        public SubmitStudentMarkCommand(int studentId, int classId, double studentMark)
        {
            ClassId = classId;
            StudentId = studentId;
            StudentMark = studentMark;
        }

    }
}
