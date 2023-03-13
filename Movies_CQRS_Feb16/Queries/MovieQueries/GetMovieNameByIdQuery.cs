using MediatR;

namespace Movies_CQRS_Feb16.Queries.MovieQueries
{
    public record GetMovieNameByIdQuery(int id) : IRequest<string>
    {
    }
}
