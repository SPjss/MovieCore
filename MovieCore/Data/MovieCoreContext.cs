using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieCore.Models;

namespace MovieCore.Data
{
    public class MovieCoreContext : DbContext
    {
        public MovieCoreContext (DbContextOptions<MovieCoreContext> options)
            : base(options)
        {
        }

        public DbSet<MovieCore.Models.Movie> Movie { get; set; } = default!;
    }
}
