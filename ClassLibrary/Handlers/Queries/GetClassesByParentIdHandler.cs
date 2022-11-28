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
    public class GetClassesByParentIdHandler : IRequestHandler<GetClassesByParentIdQuery, List<ClassModel>>
    {
        private readonly IMediator _mediator;
        public GetClassesByParentIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IMediator Mediator { get; }

        // add error handling
        public async Task<List<ClassModel>> Handle(GetClassesByParentIdQuery request, CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetClassListQuery());
            var output = (List<ClassModel>)results.Where(x => x.Students.Where(y => y.ParentId == request.Id).Any());

            return output;

        }
    }
}
