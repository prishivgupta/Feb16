using Microsoft.EntityFrameworkCore;
using Movies_CQRS_Feb16.Data_Access.Interfaces;
using Movies_CQRS_Feb16.Models;

namespace Movies_CQRS_Feb16.Repositories
{
    public class MovieRepository : IMovie
    {
        private readonly MoviesContext moviesContext;

        public MovieRepository(MoviesContext moviesContext)
        {
            this.moviesContext = moviesContext;
        }

        public List<Movie> AddMovie(Movie movie)
        {
            this.moviesContext.Movies.Add(movie);
            this.moviesContext.SaveChanges();
            return this.moviesContext.Movies.ToList();
        }

        public string DeleteMovie(int id)
        {
            var movie = this.moviesContext.Movies.Find(id);

            if (movie != null)
            {
                this.moviesContext.Movies.Remove(movie);
                this.moviesContext.SaveChanges();
                return "Deleted Successfully";
            }
            else
            {
                return "Record Not Found";
            }
        }

        public List<Movie> GetAllMovies()
        {
            return this.moviesContext.Movies.ToList();
        }

        public Movie GetMovieByGenre(int genreId)
        {
            return this.moviesContext.Movies.FirstOrDefault(e => e.GenreId == genreId);
        }

        public Movie GetMovieById(int id)
        {
            var movie = this.moviesContext.Movies.Where(j => j.MovieId == id).FirstOrDefault();
            return movie;
        }

        public string GetMovieNameById(int id)
        {
            var movieName = this.moviesContext.Movies.Where(m => m.MovieId == id).Select(m => m.MovieName).FirstOrDefault();
            Console.WriteLine(movieName);
            return movieName;
        }

        public List<Movie> UpdateMovie(Movie movie)
        {
            var movie1 = this.moviesContext.Movies.Find(movie.MovieId);

            if (movie1 != null)
            {
                movie1.MovieName = movie.MovieName;
                movie1.GenreId = movie.GenreId;

                this.moviesContext.SaveChanges();
            }

            this.moviesContext.SaveChanges();
            return this.moviesContext.Movies.ToList();
        }
    }
}
