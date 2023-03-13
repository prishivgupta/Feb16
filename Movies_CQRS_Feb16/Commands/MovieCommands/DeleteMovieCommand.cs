using MediatR;

namespace Movies_CQRS_Feb16.Commands.MovieCommands
{
    public record DeleteMovieCommand(int id) : IRequest<string>
    {
    }
}
