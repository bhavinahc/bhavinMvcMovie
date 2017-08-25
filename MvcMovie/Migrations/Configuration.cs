namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovie.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MvcMovie.Models.MovieDBContext";
        }

        protected override void Seed(MvcMovie.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title,
                new MvcMovie.Models.Movies
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-1-11"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M,
                    Rating = "PG"
                },

                new MvcMovie.Models.Movies
                {
                    Title = "Jab We Met",
                    ReleaseDate = DateTime.Parse("1989-1-11"),
                    Genre = "Romantic Comedy",
                    Price = 11.99M,
                    Rating = "PG"
                },
                 new MvcMovie.Models.Movies
                 {
                     Title = "Ghostbusters ",
                     ReleaseDate = DateTime.Parse("1984-3-13"),
                     Genre = "Comedy",
                     Price = 8.99M,
                     Rating = "G"
                 },

                 new MvcMovie.Models.Movies
                 {
                     Title = "Ghostbusters 2",
                     ReleaseDate = DateTime.Parse("1986-2-23"),
                     Genre = "Comedy",
                     Price = 9.99M,
                     Rating = "G"
                 },

               new MvcMovie.Models.Movies
               {
                   Title = "Rio Bravo",
                   ReleaseDate = DateTime.Parse("1959-4-15"),
                   Genre = "Western",
                   Price = 3.99M,
                   Rating = "PG"
               },
               new MvcMovie.Models.Movies
               {
                   Title = "Scooby Doo",
                   ReleaseDate = DateTime.Parse("1959-4-15"),
                   Genre = "Cartoon",
                   Price = 3.99M,
                   Rating = "G"
               },
               new MvcMovie.Models.Movies
               {
                   Title = "Wall St",
                   ReleaseDate = DateTime.Parse("1959-4-15"),
                   Genre = "Documentary",
                   Price = 3.99M,
                   Rating = "G"
               },
               new MvcMovie.Models.Movies
               {
                   Title = "BlackFish",
                   ReleaseDate = DateTime.Parse("1959-4-15"),
                   Genre = "Documentary",
                   Price = 15.99M,
                   Rating = "G"
               },
               new MvcMovie.Models.Movies
               {
                   Title = "Ghayal",
                   ReleaseDate = DateTime.Parse("1959-4-15"),
                   Genre = "Action",
                   Price = 5.99M,
                   Rating = "PG"
               }, new MvcMovie.Models.Movies
               {
                   Title = "Himatwalla",
                   ReleaseDate = DateTime.Parse("1959-4-15"),
                   Genre = "Bollywood",
                   Price = 0.99M,
                   Rating = "G"
               }, new MvcMovie.Models.Movies
               {
                   Title = "Deewana",
                   ReleaseDate = DateTime.Parse("1959-4-15"),
                   Genre = "Bollywood",
                   Price = 1.99M,
                   Rating = "G"
               }, new MvcMovie.Models.Movies
               {
                   Title = "Hum Tum",
                   ReleaseDate = DateTime.Parse("1959-4-15"),
                   Genre = "Romantic Comedy",
                   Price = 8.99M,
                   Rating = "G"
               }, new MvcMovie.Models.Movies
               {
                   Title = "The Whole Nine Yards",
                   ReleaseDate = DateTime.Parse("1959-4-15"),
                   Genre = "Comedy",
                   Price = 15.99M,
                   Rating = "PG"
               }, new MvcMovie.Models.Movies
               {
                   Title = "Casino",
                   ReleaseDate = DateTime.Parse("1959-4-15"),
                   Genre = "Drama",
                   Price = 12.99M,
                   Rating = "PG"
               }, new MvcMovie.Models.Movies
               {
                   Title = "Good Fellas",
                   ReleaseDate = DateTime.Parse("1959-4-15"),
                   Genre = "Drama",
                   Price = 9.99M,
                   Rating = "PG"
               }, new MvcMovie.Models.Movies
               {
                   Title = "Kung Fu Panda",
                   ReleaseDate = DateTime.Parse("1959-4-15"),
                   Genre = "Animation",
                   Price = 7.99M,
                   Rating = "G"
               }, new MvcMovie.Models.Movies
               {
                   Title = "Toy Story",
                   ReleaseDate = DateTime.Parse("1959-4-15"),
                   Genre = "Animation",
                   Price = 6.99M,
                   Rating = "G"
               }, new MvcMovie.Models.Movies
               {
                   Title = "Mickey at Christmas PArty",
                   ReleaseDate = DateTime.Parse("1959-4-15"),
                   Genre = "Cartoon",
                   Price = 4.99M,
                   Rating = "G"
               }

           );

        }
    }
}
