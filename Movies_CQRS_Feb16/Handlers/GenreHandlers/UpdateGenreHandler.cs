using MediatR;
using Movies_CQRS_Feb16.Commands.GenreCommands;
using Movies_CQRS_Feb16.Data_Access.Interfaces;
using Movies_CQRS_Feb16.Models;

namespace Movies_CQRS_Feb16.Handlers.GenreHandlers
{
    public class UpdateGenreHandler : IRequestHandler<UpdateGenreCommand, List<Genre>>
    {
        private readonly IGenre genre;

        public UpdateGenreHandler(IGenre genre) 
        {
            this.genre = genre;
        }

        public async Task<List<Genre>> Handle(UpdateGenreCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(genre.UpdateGenre(request.genre));
        }
    }
}
