using MovieLibraryAPI.Entities;
using System.Collections.Generic;

namespace MovieLibraryAPI.Services
{
    public interface IRepository
    {
        List<Genre> GetAllGenres();
        Genre GetGenreById(int Id);
    }
}
