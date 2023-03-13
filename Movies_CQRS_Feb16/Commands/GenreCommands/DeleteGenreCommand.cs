using MediatR;

namespace Movies_CQRS_Feb16.Commands.GenreCommands
{
    public record DeleteGenreCommand(int id) : IRequest<string>
    {
    }
}
