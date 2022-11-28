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
    public class GetClassListHandler : IRequestHandler<GetClassListQuery, List<ClassModel>>
    {
        private readonly IDataAccess _data;
        public GetClassListHandler(IDataAccess data)
        {
            _data = data;
        }

        public Task<List<ClassModel>> Handle(GetClassListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetClassList());
        }
    }
}
