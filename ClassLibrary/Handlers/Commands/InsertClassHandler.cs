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
    public class InsertClassHandler : IRequestHandler<InsertClassCommand, ClassModel>
    {
        private readonly IDataAccess _data;

        public InsertClassHandler(IDataAccess data)
        {
            _data = data;
        }
        public Task<ClassModel> Handle(InsertClassCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.InsertClass(request.ClassName, request.StartDate, request.EndDate, request.TeacherId, request.ModuleCode, request.StudentId, request.Assignments));
        }
    }
}

