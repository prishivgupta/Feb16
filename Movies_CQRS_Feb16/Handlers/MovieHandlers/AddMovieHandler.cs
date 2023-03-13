using MediatR;
using Movies_CQRS_Feb16.Commands.MovieCommands;
using Movies_CQRS_Feb16.Data_Access.Interfaces;
using Movies_CQRS_Feb16.Models;

namespace Movies_CQRS_Feb16.Handlers.MovieHandlers
{
    public class AddMovieHandler : IRequestHandler<AddMovieCommand, List<Movie>>
    {
        private readonly IMovie movie;

        public AddMovieHandler(IMovie movie) 
        {
            this.movie = movie;
        }

        public async Task<List<Movie>> Handle(AddMovieCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(movie.AddMovie(request.movie)) ;
        }
    }
}
