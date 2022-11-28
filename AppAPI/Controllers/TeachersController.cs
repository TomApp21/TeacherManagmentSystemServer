using ClassLibrary.Commands;
using ClassLibrary.Models;
using ClassLibrary.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppAPI.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {

        private readonly IMediator _mediatr;

        public TeachersController(IMediator mediator)
        {
            _mediatr = mediator;
        }

        // GET: api/<TeachersController>
        [HttpGet]
        public async Task<List<TeacherModel>> Get()
        {
            return await _mediatr.Send(new GetPersonListQuery());
        }

        // GET api/<TeachersController>/5
        [HttpGet("{id}")] 
        public async Task<TeacherModel> Get(int id)
        {
            return await _mediatr.Send(new GetTeacherByIdQuery(id));
        }

        // POST api/<TeachersController>
        [HttpPost]
        public async Task<TeacherModel> Post([FromBody] TeacherModel value)
        {
            var model = new InsertTeacherCommand(value.Name, value.UserName, value.Password, value.ClassIds);
            return await _mediatr.Send(model);
        }

    }
}
