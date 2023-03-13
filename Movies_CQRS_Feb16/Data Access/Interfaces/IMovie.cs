using Movies_CQRS_Feb16.Models;

namespace Movies_CQRS_Feb16.Data_Access.Interfaces
{
    public interface IMovie
    {
        public List<Movie> AddMovie(Movie movie);

        public List<Movie> UpdateMovie(Movie movie);

        public List<Movie> GetAllMovies();

        public string DeleteMovie(int id);

        public string GetMovieNameById(int id);

        public Movie GetMovieById(int id);

        public Movie GetMovieByGenre(int genreId);
    }
}
