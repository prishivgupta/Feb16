using MediatR;
using Movies_CQRS_Feb16.Models;

namespace Movies_CQRS_Feb16.Queries.GenreQueries
{
    public record GetAllGenreQuery : IRequest<List<Genre>>
    {

    }
}
