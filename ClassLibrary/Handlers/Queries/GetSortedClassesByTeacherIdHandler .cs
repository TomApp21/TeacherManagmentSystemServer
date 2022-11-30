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
    public class GetSortedClassesByTeacherIdHandler : IRequestHandler<GetSortedClassesByTeacherIdQuery, List<ClassModel>>
    {
        private readonly IMediator _mediator;
        public GetSortedClassesByTeacherIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IMediator Mediator { get; }

        // add error handling
        public async Task<List<ClassModel>> Handle(GetSortedClassesByTeacherIdQuery request, CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetClassListQuery());
            var output = new List<ClassModel>();

            if (request.Ascending)
            {
                output = (List<ClassModel>)results.Where(x => x.TeacherId == request.Id).OrderBy(x => x.NumStudents).ToList();

            }
            else { 
                output = (List<ClassModel>)results.Where(x => x.TeacherId == request.Id).OrderByDescending(x => x.NumStudents).ToList();
            }

           
            return output;

        }
    }
}
