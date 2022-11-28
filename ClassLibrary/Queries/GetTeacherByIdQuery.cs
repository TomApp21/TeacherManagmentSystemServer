using ClassLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Queries
{
    public class GetTeacherByIdQuery : IRequest<TeacherModel>
    {
        public int Id { get; set; }
        public GetTeacherByIdQuery(int id)
        {
            Id = id;
        }
    }


}
