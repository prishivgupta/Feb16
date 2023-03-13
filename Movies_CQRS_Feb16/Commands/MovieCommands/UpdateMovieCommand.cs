using MediatR;
using Movies_CQRS_Feb16.Models;

namespace Movies_CQRS_Feb16.Commands.MovieCommands
{
    public record UpdateMovieCommand(Movie movie) : IRequest<List<Movie>>
    {
    }
}
