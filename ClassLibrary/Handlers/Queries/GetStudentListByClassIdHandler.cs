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
    public class GetStudentListByClassIdHandler : IRequestHandler<GetStudentListByClassIdQuery, List<StudentModel>>
    {
        private readonly IMediator _mediator;
        public GetStudentListByClassIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IMediator Mediator { get; }

        // add error handling
        public async Task<List<StudentModel>> Handle(GetStudentListByClassIdQuery request, CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetStudentListQuery());
            var output = (List<StudentModel>)results.Where(x => x.ClassIds.Contains(request.Id)).ToList();

            return output;

        }
    }
}
