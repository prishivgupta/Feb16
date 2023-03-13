
using Movies_CQRS_Feb16.Models;

namespace Movies_CQRS_Feb16.Data_Access.Interfaces
{
    public interface IGenre
    {
        public List<Genre> AddGenre(Genre genre);

        public List<Genre> UpdateGenre(Genre genre);

        public List<Genre> GetAllGenres();

        public string DeleteGenre(int id);

        public Genre GetGenreById(int id);
    }
}
