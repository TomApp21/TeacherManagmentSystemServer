using ClassLibrary.Models;
using ClassLibrary.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Handlers
{
    public class GetTeacherByIdHandler : IRequestHandler<GetTeacherByIdQuery, TeacherModel>
    {
        private readonly IMediator _mediator;
        public GetTeacherByIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IMediator Mediator { get; }

        // add error handling
        public async Task<TeacherModel> Handle(GetTeacherByIdQuery request, CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetPersonListQuery());
            var output = results.FirstOrDefault(x => x.UserId == request.Id);

            return output;

        }
    }
}
