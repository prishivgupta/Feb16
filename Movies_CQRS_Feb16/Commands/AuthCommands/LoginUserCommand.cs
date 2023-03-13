using MediatR;
using Movies_CQRS_Feb16.ModelsDTO;

namespace Movies_CQRS_Feb16.Commands.AuthCommands
{
    public record LoginUserCommand(UserDTO user) : IRequest<UserDTO>
    {
    }
}
