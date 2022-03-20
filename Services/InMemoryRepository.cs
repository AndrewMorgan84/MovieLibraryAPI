using MovieLibraryAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieLibraryAPI.Services
{
    public class InMemoryRepository : IRepository
    {
        private List<Genre> _genres;
        public InMemoryRepository()
        {
            _genres = new List<Genre>()
            {
                new Genre(){Id = 1, Name = "Action"},
                new Genre(){Id = 2, Name = "Family"},
                new Genre(){Id = 3, Name = "Drama"},
                new Genre(){Id = 4, Name = "Romance"},
                new Genre(){Id = 5, Name = "Sci Fi"},
                new Genre(){Id = 6, Name = "Childrens"},
                new Genre(){Id = 7, Name = "Comedy"},
            };
        }

        public List<Genre> GetAllGenres()
        {
            return _genres;
        }

        public Genre GetGenreById(int Id)
        {
            return _genres.FirstOrDefault(g => g.Id == Id);
        }
    }
}
