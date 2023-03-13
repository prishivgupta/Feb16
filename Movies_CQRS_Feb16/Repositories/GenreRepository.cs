using Microsoft.AspNetCore.Mvc;
using Movies_CQRS_Feb16.Data_Access.Interfaces;
using Movies_CQRS_Feb16.Models;

namespace Movies_CQRS_Feb16.Repositories
{
    public class GenreRepository : IGenre
    {

        private readonly MoviesContext moviesContext;

        public GenreRepository(MoviesContext moviesContext)
        {
            this.moviesContext = moviesContext;
        }

        public List<Genre> AddGenre(Genre genre)
        {
            try
            {
                this.moviesContext.Genres.Add(genre);
                this.moviesContext.SaveChanges();

                return this.moviesContext.Genres.ToList();
            }
            catch(Exception addGenreException)
            {
                Console.WriteLine(addGenreException.Message);
                return null;
            }
        }

        public string DeleteGenre(int id)
        {
            try
            {
                var genre = this.moviesContext.Genres.Find(id);

                if (genre != null)
                {
                    this.moviesContext.Genres.Remove(genre);
                    this.moviesContext.SaveChanges();
                    return "Deleted Successfully";
                }
                else
                {
                    return "Record Not Found";
                }
            }
            catch(Exception delteGenreException)
            {
                Console.WriteLine(delteGenreException.Message);
                return delteGenreException.Message;
            }
            
        }

        public List<Genre> GetAllGenres()
        {
            try
            {
                return this.moviesContext.Genres.ToList();
            }
            catch (Exception getAllGenresException) 
            { 
                Console.WriteLine(getAllGenresException.Message);
                return null;
            }

        }

        public Genre GetGenreById(int id)
        {
            try
            {
                return this.moviesContext.Genres.FirstOrDefault(e => e.GenreId == id);
            }
            catch (Exception getGenreByIdException)
            {
                Console.WriteLine(getGenreByIdException.Message);
                return null;
            }
        }

        public List<Genre> UpdateGenre(Genre genre)
        {
            try
            {
                var genre1 = this.moviesContext.Genres.Find(genre.GenreId);

                if (genre1 != null)
                {
                    genre1.GenreName = genre.GenreName;

                    this.moviesContext.SaveChanges();
                }

                this.moviesContext.SaveChanges();

                return this.moviesContext.Genres.ToList();
            }
            catch(Exception updateGenreException)
            {
                Console.WriteLine(updateGenreException.Message);
                return null;
            }
        }
    }
}
