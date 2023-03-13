using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies_CQRS_Feb16.Commands.AuthCommands;
using Movies_CQRS_Feb16.ModelsDTO;
using Movies_CQRS_Feb16.Queries.MovieQueries;

namespace Movies_CQRS_Feb16.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator mediator;

        public AuthController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        [Route("LoginUser")]

        public async Task<ActionResult> LoginUser(UserDTO user)
        {
            var user1 = await mediator.Send(new LoginUserCommand(user));
            return Ok(user1);
        }
    }
}
