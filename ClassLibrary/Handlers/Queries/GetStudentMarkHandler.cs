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
    public class GetStudentMarkHandler : IRequestHandler<GetStudentMarkQuery, int>
    {
        private readonly IMediator _mediator;
        public GetStudentMarkHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IMediator Mediator { get; }

        // add error handling
        public async Task<int> Handle(GetStudentMarkQuery request, CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetClassListQuery());
            var moreResults = results.Where(x => x.ClassId == request.ClassId).FirstOrDefault();
            
            var output = (int)moreResults.Assignments[request.Id];   // Where (x => x.StudentId == request.Id).Select(x => x.mark);

            return output;

        }
    }
}

// student can be in multiple classes
// class has list<studentid, mark>