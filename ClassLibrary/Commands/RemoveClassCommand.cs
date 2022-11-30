using ClassLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Commands
{
    public class RemoveClassCommand : IRequest
    {
        public int ClassId { get; set; }

        public RemoveClassCommand(int id)
        {
            ClassId = id;
        }

    }
}
