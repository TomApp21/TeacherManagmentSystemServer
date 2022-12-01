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
    public class GetStudentMarkForParentHandler : IRequestHandler<GetStudentMarkForParentQuery, int>
    {
        private readonly IMediator _mediator;
        public GetStudentMarkForParentHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IMediator Mediator { get; }

        // add error handling
        public async Task<int> Handle(GetStudentMarkForParentQuery request, CancellationToken cancellationToken)
        {
            //var results = await _mediator.Send(new GetClassListQuery());
            //var moreResults = results.Where(x => x.ClassId == request.ClassId).FirstOrDefault();
            
            //var output = (int)moreResults.Assignments[request.Id];   // Where (x => x.StudentId == request.Id).Select(x => x.mark);

            //return output;

            

            var results = await _mediator.Send(new GetStudentListQuery());
            var studentId = results.Where(x => x.ParentId == request.ParentId).Select(y => y.StudentId).SingleOrDefault();

            List<ClassModel> allClasses = await _mediator.Send(new GetClassListQuery());
            ClassModel thisClass = allClasses.Where(x => x.ClassId == request.ClassId).FirstOrDefault();

            var output = (int)thisClass.Assignments[studentId];
            return output;
        }
    }
}

// student can be in multiple classes
// class has list<studentid, mark>