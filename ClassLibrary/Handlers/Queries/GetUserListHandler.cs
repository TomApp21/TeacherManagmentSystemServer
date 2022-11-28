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
    public class GetUserListHandler : IRequestHandler<GetUserListQuery, List<UserModel>>
    {
        private readonly IDataAccess _data;
        public GetUserListHandler(IDataAccess data)
        {
            _data = data;
        }

        public Task<List<UserModel>> Handle(GetUserListHandler request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.ge());
        }
    }
}
