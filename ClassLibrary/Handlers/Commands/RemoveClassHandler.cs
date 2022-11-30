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
    public class RemoveClassHandler : IRequestHandler<RemoveClassCommand>
    {
        private readonly IDataAccess _data;

        public RemoveClassHandler(IDataAccess data)
        {
            _data = data;
        }
        public Task<Unit> Handle(RemoveClassCommand request, CancellationToken cancellationToken)
        {
            _data.RemoveClass(request.ClassId);
            return Task.FromResult(Unit.Value);
        }
    }
}

