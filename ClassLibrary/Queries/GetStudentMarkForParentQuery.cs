using ClassLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Queries
{
    public class GetStudentMarkForParentQuery : IRequest<int>
    {
        public int ParentId { get; set; }
        public int ClassId { get; set; }
        public GetStudentMarkForParentQuery(int parentId, int classId )
        {
            ParentId = parentId;
            ClassId = classId;
        }
    }


}
