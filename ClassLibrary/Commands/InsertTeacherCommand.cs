using ClassLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Commands
{
    public class InsertTeacherCommand : IRequest<TeacherModel>
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<int> ClassIds { get; set; } = new List<int>();

        public InsertTeacherCommand(string name, string userName, string password, List<int> classIds)
        {
            Name = name;
            UserName = userName;
            Password = password;
            ClassIds = classIds;
        }

    }
}
