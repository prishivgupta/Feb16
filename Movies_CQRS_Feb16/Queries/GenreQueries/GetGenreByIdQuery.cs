using MediatR;
using Movies_CQRS_Feb16.Models;

namespace Movies_CQRS_Feb16.Queries.GenreQueries
{
    public record GetGenreByIdQuery(int id) : IRequest<Genre>
    {
    }
}
