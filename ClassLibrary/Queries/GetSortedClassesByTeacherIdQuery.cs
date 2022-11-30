using ClassLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Queries
{
    public class GetSortedClassesByTeacherIdQuery : IRequest<List<ClassModel>>
    {
        public int Id { get; set; }
        public bool Ascending { get; set; }
        public GetSortedClassesByTeacherIdQuery(int id, bool ascending)
        {
            Id = id;
            Ascending = ascending;
        }
    }


}
