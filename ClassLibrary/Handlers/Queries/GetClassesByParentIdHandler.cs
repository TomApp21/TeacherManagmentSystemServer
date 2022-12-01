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
            var results = await _mediator.Send(new GetStudentListQuery());
            var output = (List<int>)results.Where(x => x.ParentId == request.Id).Select(y => y.ClassIds).SingleOrDefault();

            List<ClassModel> allClasses = await _mediator.Send(new GetClassListQuery());
            List<ClassModel> thisStudentsClasses = new List<ClassModel>();

            foreach (var item in output)
            {
                thisStudentsClasses.Add(allClasses.Where(x => x.ClassId == item).SingleOrDefault());
            }

            return thisStudentsClasses;

        }
    }
}
