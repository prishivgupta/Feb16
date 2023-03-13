using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies_CQRS_Feb16.Commands.GenreCommands;
using Movies_CQRS_Feb16.Commands.MovieCommands;
using Movies_CQRS_Feb16.Models;
using Movies_CQRS_Feb16.Queries.GenreQueries;
using Movies_CQRS_Feb16.Queries.MovieQueries;

namespace Movies_CQRS_Feb16.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MovieController : ControllerBase
    {
        private readonly IMediator mediator;

        public MovieController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("GetAllMovies")]
        public async Task<IActionResult> GetAllMovies()
        {
            var movies = await mediator.Send(new GetAllMoviesQuery());
            return Ok(movies);
        }

        [HttpGet]
        [Route("GetMovieByGenre/{id}")]

        public async Task<ActionResult> GetMovieByGenre(int id)
        {
            var movie = await mediator.Send(new GetMovieByGenreQuery(id));
            return Ok(movie);
        }

        [HttpGet]
        [Route("GetMovieById/{id}")]

        public async Task<ActionResult> GetMovieById(int id)
        {
            var movie = await mediator.Send(new GetMovieByIdQuery(id));
            return Ok(movie);
        }

        [HttpGet]
        [Route("GetMovieNameById/{id}")]

        public async Task<ActionResult> GetMovieNameById(int id)
        {
            var movieName = await mediator.Send(new GetMovieNameByIdQuery(id));
            return Ok(movieName);
        }


        [HttpPost]
        [Route("AddMovie")]

        public async Task<ActionResult> AddMovie([FromBody] Movie movie)
        {
            await mediator.Send(new AddMovieCommand(movie));
            return StatusCode(201);
        }

        [HttpPut]
        [Route("UpdateMovie")]

        public async Task<ActionResult> UpdateMovie([FromBody] Movie movie)
        {
            await mediator.Send(new UpdateMovieCommand(movie));
            return StatusCode(201);
        }

        [HttpDelete]
        [Route("DeleteMovie")]

        public async Task<ActionResult> DeleteMovie(int id)
        {
            await mediator.Send(new DeleteMovieCommand(id));
            return StatusCode(201);
        }
    }
}
