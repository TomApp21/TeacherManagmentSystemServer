using ClassLibrary.Commands;
using ClassLibrary.DataAccess;
using ClassLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Handlers
{
    public class InsertTeacherHandler : IRequestHandler<InsertTeacherCommand, TeacherModel>
    {
        private readonly IDataAccess _data;

        public InsertTeacherHandler(IDataAccess data)
        {
            _data = data;
        }
        public Task<TeacherModel> Handle(InsertTeacherCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.InsertTeacher(request.Name, request.UserName, request.Password, request.ClassIds));
        }
    }
}
