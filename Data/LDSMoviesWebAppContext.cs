using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LDSMoviesWebApp.Models
{
    public class LDSMoviesWebAppContext : DbContext
    {
        public LDSMoviesWebAppContext (DbContextOptions<LDSMoviesWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<LDSMoviesWebApp.Models.Movie> Movie { get; set; }
    }
}
