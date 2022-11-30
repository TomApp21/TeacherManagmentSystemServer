using ClassLibrary.DataAccess;
using ClassLibrary.Models;
using ClassLibrary.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Handlers.Queries
{
    public class GetStudentListHandler : IRequestHandler<GetStudentListQuery, List<StudentModel>>
    {
        private readonly IDataAccess _data;
        public GetStudentListHandler(IDataAccess data)
        {
            _data = data;
        }

        public Task<List<StudentModel>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetStudentList());
        }
    }
}
