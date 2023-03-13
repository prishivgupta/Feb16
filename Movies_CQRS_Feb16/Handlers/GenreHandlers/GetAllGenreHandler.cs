using MediatR;
using Movies_CQRS_Feb16.Data_Access.Interfaces;
using Movies_CQRS_Feb16.Models;
using Movies_CQRS_Feb16.Queries.GenreQueries;

namespace Movies_CQRS_Feb16.Handlers.GenreHandlers
{
    public class GetAllGenreHandler : IRequestHandler<GetAllGenreQuery, List<Genre>>
    {
        private readonly IGenre genre;

        public GetAllGenreHandler(IGenre genre)
        {
            this.genre = genre;
        }

        public async Task<List<Genre>> Handle(GetAllGenreQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(genre.GetAllGenres());
        }
    }
}
