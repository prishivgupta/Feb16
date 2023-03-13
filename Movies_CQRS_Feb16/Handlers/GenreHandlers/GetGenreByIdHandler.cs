using MediatR;
using Movies_CQRS_Feb16.Data_Access.Interfaces;
using Movies_CQRS_Feb16.Models;
using Movies_CQRS_Feb16.Queries.GenreQueries;

namespace Movies_CQRS_Feb16.Handlers.GenreHandlers
{
    public class GetGenreByIdHandler : IRequestHandler<GetGenreByIdQuery, Genre>
    {
        private readonly IGenre genre;

        public GetGenreByIdHandler(IGenre genre)
        {
            this.genre = genre;
        }

        public async Task<Genre> Handle(GetGenreByIdQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(genre.GetGenreById(request.id));
        }
    }
}
