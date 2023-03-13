using MediatR;
using Movies_CQRS_Feb16.Models;

namespace Movies_CQRS_Feb16.Queries.MovieQueries
{
    public record GetAllMoviesQuery : IRequest<List<Movie>>
    {
    }
}
