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
    public class InsertStudentToClassHandler : IRequestHandler<InsertStudentToClassCommand, StudentModel>
    {
        private readonly IDataAccess _data;

        public InsertStudentToClassHandler(IDataAccess data)
        {
            _data = data;
        }
        public Task<StudentModel> Handle(InsertStudentToClassCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.inse InsertTeacher(request.Name, request.UserName, request.Password, request.ClassIds));
        }
    }
}
