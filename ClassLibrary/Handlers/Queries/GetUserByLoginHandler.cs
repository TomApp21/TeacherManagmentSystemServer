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
    public class GetUserByLoginHandler : IRequestHandler<GetUserByLoginQuery, UserModel>
    {
        private readonly IMediator _mediator;
        public GetUserByLoginHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IMediator Mediator { get; }

        // add error handling
        public async Task<UserModel> Handle(GetUserByLoginQuery request, CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetUserListQuery());
            var output = results.FirstOrDefault(x => x.UserName == request.Username && x.Password == x.Password);

            return output;

        }
    }
}
