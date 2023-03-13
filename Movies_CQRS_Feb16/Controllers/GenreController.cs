using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies_CQRS_Feb16.Commands.GenreCommands;
using Movies_CQRS_Feb16.Models;
using Movies_CQRS_Feb16.Queries.GenreQueries;

namespace Movies_CQRS_Feb16.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class GenreController : ControllerBase
    {
        private readonly IMediator mediator;

        public GenreController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("GetAllGenres")]
        public async Task<IActionResult> GetAllGenres()
        {
            var genres = await mediator.Send(new GetAllGenreQuery());
            return Ok(genres);
        }

        [HttpGet]
        [Route("GetGenreById/{id}")]

        public async Task<ActionResult> GetGenreById(int id)
        {
            var genre = await mediator.Send(new GetGenreByIdQuery(id));
            return Ok(genre);
        }


        [HttpPost]
        [Route("AddGenre")]

        public async Task<ActionResult> AddGenre([FromBody] Genre genre)
        {
            await mediator.Send(new AddGenreCommand(genre));
            return StatusCode(201);
        }

        [HttpPut]
        [Route("UpdateGenre")]

        public async Task<ActionResult> UpdateGenre([FromBody] Genre genre)
        {
            await mediator.Send(new UpdateGenreCommand(genre));
            return StatusCode(201);
        }

        [HttpDelete]
        [Route("DeleteGenre")]

        public async Task<ActionResult> DeleteGenre(int id)
        {
            await mediator.Send(new DeleteGenreCommand(id));
            return StatusCode(201);
        }
    }
}
