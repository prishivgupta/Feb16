using MediatR;
using Movies_CQRS_Feb16.Models;

namespace Movies_CQRS_Feb16.Queries.MovieQueries
{
    public record GetMovieByGenreQuery(int id) :  IRequest<Movie>
    {
    }
}
