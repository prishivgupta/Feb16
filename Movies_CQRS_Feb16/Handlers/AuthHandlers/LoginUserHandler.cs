using MediatR;
using Movies_CQRS_Feb16.Commands.AuthCommands;
using Movies_CQRS_Feb16.Data_Access.Interfaces;
using Movies_CQRS_Feb16.ModelsDTO;

namespace Movies_CQRS_Feb16.Handlers.AuthHandlers
{
    public class LoginUserHandler : IRequestHandler<LoginUserCommand, UserDTO>
    {
        private readonly IAuth auth;

        public LoginUserHandler(IAuth auth)
        {
            this.auth = auth;
        }

        public async Task<UserDTO> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(auth.LoginUser(request.user));
        }
    }
}
