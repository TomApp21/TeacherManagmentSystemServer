using ClassLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Queries
{
    public class GetUserByLoginQuery : IRequest<UserModel>
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public GetUserByLoginQuery(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }


}
