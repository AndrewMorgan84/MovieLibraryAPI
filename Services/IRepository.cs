using MovieLibraryAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieLibraryAPI.Services
{
    public interface IRepository
    {
        Task<List<Genre>> GetAllGenres();
        Genre GetGenreById(int Id);
    }
}
