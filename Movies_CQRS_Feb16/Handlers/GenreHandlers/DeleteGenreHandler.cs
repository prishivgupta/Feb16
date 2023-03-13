using MediatR;
using Movies_CQRS_Feb16.Commands.GenreCommands;
using Movies_CQRS_Feb16.Data_Access.Interfaces;
using Movies_CQRS_Feb16.Models;

namespace Movies_CQRS_Feb16.Handlers.GenreHandlers
{
    public class DeleteGenreHandler : IRequestHandler<DeleteGenreCommand, string>
    {
        private readonly IGenre genre;

        public DeleteGenreHandler(IGenre genre) 
        { 
            this.genre = genre;
        }

        public async Task<string> Handle(DeleteGenreCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(genre.DeleteGenre(request.id));
        }
    }
}
