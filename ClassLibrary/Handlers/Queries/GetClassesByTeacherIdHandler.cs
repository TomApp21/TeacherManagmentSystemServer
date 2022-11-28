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
    public class GetClassesByTeacherIdHandler : IRequestHandler<GetClassesByTeacherIdQuery, List<ClassModel>>
    {
        private readonly IMediator _mediator;
        public GetClassesByTeacherIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IMediator Mediator { get; }

        // add error handling
        public async Task<List<ClassModel>> Handle(GetClassesByTeacherIdQuery request, CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetClassListQuery());
            var output = (List<ClassModel>)results.Where(x => x.TeacherId == request.Id).ToList();

            return output;

        }
    }
}
