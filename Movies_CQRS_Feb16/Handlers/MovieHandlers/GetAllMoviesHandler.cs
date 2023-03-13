using MediatR;
using Movies_CQRS_Feb16.Data_Access.Interfaces;
using Movies_CQRS_Feb16.Models;
using Movies_CQRS_Feb16.Queries.MovieQueries;

namespace Movies_CQRS_Feb16.Handlers.MovieHandlers
{
    public class GetAllMoviesHandler : IRequestHandler<GetAllMoviesQuery, List<Movie>>
    {
        private readonly IMovie movie;

        public GetAllMoviesHandler(IMovie movie)
        {
            this.movie = movie;
        }

        public async Task<List<Movie>> Handle(GetAllMoviesQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(movie.GetAllMovies());
        }
    }
}
