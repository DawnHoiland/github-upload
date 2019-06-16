namespace MoviesFinal.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MoviesFinal.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MoviesFinal.Models.MovieDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MoviesFinal.Models.MovieDb context)
        {
            context.Movies.AddOrUpdate(m=>m.Title,
                    new Movie { Title = "Star Wars", ReleaseYear = 1977, Runtime = 121 },
                    new Movie { Title = "E.T.", ReleaseYear = 1981, Runtime = 130 },
                    new Movie { Title = "Toy Story", ReleaseYear = 1994, Runtime = 90 }
                );
        }
    }
}
