using ClassLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Queries
{
    public class GetStudentMarkQuery : IRequest<int>
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public GetStudentMarkQuery(int studentId, int classId)
        {
            Id = studentId;
            ClassId = classId;
        }
    }


}
