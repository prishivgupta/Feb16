using MediatR;
using Movies_CQRS_Feb16.Data_Access.Interfaces;
using Movies_CQRS_Feb16.Models;
using Movies_CQRS_Feb16.Queries.MovieQueries;

namespace Movies_CQRS_Feb16.Handlers.MovieHandlers
{
    public class GetMovieByGenreHandler : IRequestHandler<GetMovieByGenreQuery, Movie>
    {
        private readonly IMovie movie;

        public GetMovieByGenreHandler(IMovie movie)
        {
            this.movie = movie;
        }

        public async Task<Movie> Handle(GetMovieByGenreQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(movie.GetMovieByGenre(request.id));
        }
    }
}
