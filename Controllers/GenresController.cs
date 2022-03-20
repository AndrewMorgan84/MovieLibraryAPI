using Microsoft.AspNetCore.Mvc;
using MovieLibraryAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieLibraryAPI.Controllers
{
    public class GenresController : Controller
    {
        private readonly IRepository repository;

        public GenresController(IRepository repository)
        {
            this.repository = repository;
        }
    }
}
