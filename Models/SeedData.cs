using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LDSMoviesWebApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LDSMoviesWebAppContext(
                serviceProvider.GetRequiredService<DbContextOptions<LDSMoviesWebAppContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                     new Movie
                     {
                         Title = "The RM",
                         ReleaseDate = DateTime.Parse("2003-1-31"),
                         Genre = "Comedy",
                         Price = 34.75M,
                         Rating = "PG"
                     },

                     new Movie
                     {
                         Title = "Meet the Mormons ",
                         ReleaseDate = DateTime.Parse("2014-10-10"),
                         Genre = "Documentary",
                         Price = 3.99M,
                         Rating = "PG"
                     },

                     new Movie
                     {
                         Title = "God's Army",
                         ReleaseDate = DateTime.Parse("2000-3-10"),
                         Genre = "Religious",
                         Price = 15.66M,
                         Rating = "PG"
                     },

                   new Movie
                   {
                       Title = "The Single's Ward",
                       ReleaseDate = DateTime.Parse("2002-2-1"),
                       Genre = "Comedy",
                       Price = 19.95M,
                       Rating = "PG"
                   }
                );
                context.SaveChanges();
            }
        }
    }
}
