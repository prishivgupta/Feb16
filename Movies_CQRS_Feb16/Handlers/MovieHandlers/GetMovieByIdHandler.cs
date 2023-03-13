using MediatR;
using Movies_CQRS_Feb16.Data_Access.Interfaces;
using Movies_CQRS_Feb16.Models;
using Movies_CQRS_Feb16.Queries.MovieQueries;

namespace Movies_CQRS_Feb16.Handlers.MovieHandlers
{
    public class GetMovieByIdHandler : IRequestHandler<GetMovieByIdQuery, Movie>
    {
        private readonly IMovie movie;

        public GetMovieByIdHandler(IMovie movie)
        {
            this.movie = movie;
        }

        public async Task<Movie> Handle(GetMovieByIdQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(movie.GetMovieById(request.id));
        }
    }
}
