using Microsoft.EntityFrameworkCore;
using MovieLibraryAPI.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace MovieLibraryAPI
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {

        }

        public DbSet<Actor> Actors { get; set; }

        public DbSet<Genre> Genres { get; set; }
    }
}
