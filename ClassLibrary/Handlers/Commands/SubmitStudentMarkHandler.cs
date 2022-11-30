using ClassLibrary.Commands;
using ClassLibrary.DataAccess;
using ClassLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Handlers.Commands
{
    public class SubmitStudentMarkHandler : IRequestHandler<SubmitStudentMarkCommand>
    {
        private readonly IDataAccess _data;

        public SubmitStudentMarkHandler(IDataAccess data)
        {
            _data = data;
        }
        public Task<Unit> Handle(SubmitStudentMarkCommand request, CancellationToken cancellationToken)
        {
            _data.InsertStudentMark(request.StudentId, request.ClassId, request.StudentMark);
            return Task.FromResult(Unit.Value);

        }
    }
}

