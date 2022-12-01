using ClassLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Queries
{

    public class GetClassesByTeacherIdQuery : IRequest<List<ClassModel>>
    {
        public int Id { get; set; }
        public GetClassesByTeacherIdQuery(int id)
        {
            Id = id;
        }
    }


}
