using MediatR;
using Movies_CQRS_Feb16.Data_Access.Interfaces;
using Movies_CQRS_Feb16.Queries.MovieQueries;

namespace Movies_CQRS_Feb16.Handlers.MovieHandlers
{
    public class GetMovieNameByIdHandler : IRequestHandler<GetMovieNameByIdQuery, string>
    {
        private readonly IMovie movie;

        public GetMovieNameByIdHandler(IMovie movie)
        {
            this.movie = movie;
        }

        public async Task<string> Handle(GetMovieNameByIdQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(movie.GetMovieNameById(request.id));
        }
    }
}
