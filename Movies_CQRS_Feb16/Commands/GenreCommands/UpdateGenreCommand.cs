using MediatR;
using Movies_CQRS_Feb16.Models;

namespace Movies_CQRS_Feb16.Commands.GenreCommands
{
    public record UpdateGenreCommand(Genre genre) : IRequest<List<Genre>>
    {
    }
}
