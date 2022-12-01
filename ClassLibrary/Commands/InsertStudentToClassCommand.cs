using ClassLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Commands
{
    public class InsertStudentToClassCommand : IRequest<bool>
    {
        public int ParentId { get; set; }
        public string ModuleCode { get; set; }




        public InsertStudentToClassCommand(int parentId, string moduleCode)
        {
            ParentId = parentId;
            ModuleCode = moduleCode;
        }

    }
}
