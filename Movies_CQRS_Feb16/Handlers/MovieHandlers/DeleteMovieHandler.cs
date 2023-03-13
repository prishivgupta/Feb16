using MediatR;
using Movies_CQRS_Feb16.Commands.MovieCommands;
using Movies_CQRS_Feb16.Data_Access.Interfaces;

namespace Movies_CQRS_Feb16.Handlers.MovieHandlers
{
    public class DeleteMovieHandler : IRequestHandler<DeleteMovieCommand, string>
    {
        private readonly IMovie movie;

        public DeleteMovieHandler(IMovie movie)
        {
            this.movie = movie;
        }

        public async Task<string> Handle(DeleteMovieCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(movie.DeleteMovie(request.id));
        }
    }
}
