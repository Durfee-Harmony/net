using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
  public static class SeedData
  {
    public static void Initialize(IServiceProvider serviceProvider)
    {
      using (var context = new MvcMovieContext(
          serviceProvider.GetRequiredService<
              DbContextOptions<MvcMovieContext>>()))
      {
        // Look for any movies.
        if (context.Movie.Any())
        {
          return;   // DB has been seeded
        }

        context.Movie.AddRange(
            new Movie
            {
              Title = "The Other Side of Heaven",
              ReleaseDate = DateTime.Parse("2001-12-14"),
              Genre = "Adventure",
              Rating = "PG",
              Price = 7.99M
            },

            new Movie
            {
              Title = "The Best Two Years",
              ReleaseDate = DateTime.Parse("2004-2-20"),
              Genre = "Comedy-Drama",
              Rating = "PG",
              Price = 8.99M
            },

            new Movie
            {
              Title = "The R.M.",
              ReleaseDate = DateTime.Parse("2003-1-31"),
              Genre = "Religious-Comedy",
              Rating = "PG",
              Price = 9.99M
            },

            new Movie
            {
              Title = "Baptists at Our Barbeque",
              ReleaseDate = DateTime.Parse("2004-10-8"),
              Genre = "Religious-Romance",
              Rating = "PG",
              Price = 3.99M
            }
        );
        context.SaveChanges();
      }
    }
  }
}