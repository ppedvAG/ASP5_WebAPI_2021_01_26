using Microsoft.EntityFrameworkCore;
using MovieDBService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDBService.Data
{
    public class MovieDBContext : DbContext
    {
        public MovieDBContext(DbContextOptions<MovieDBContext> options)
            : base (options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
