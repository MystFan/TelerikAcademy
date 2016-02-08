namespace MoviesSystem.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    public sealed class Configuration : DbMigrationsConfiguration<MoviesDbContext>
    {
        private static Random rand = new Random();

        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MoviesDbContext context)
        {
            if (!context.Movies.Any())
            {

                context.Movies.Add(new Movie
                {
                    Title = "The Revenant",
                    Year = 2015,
                    Director = new MovieMember()
                    {
                        Name = "Alejandro Gonzalez Inarritu",
                        Age = 52
                    },
                    LeadingMaleRole = new MovieMember()
                    {
                        Name = "Leonardo DiCaprio",
                        Age = 41
                    },
                    LeadingFemaleRole = new MovieMember()
                    {
                        Name = "Veronica Marlowe",
                        Age = 25
                    },
                    Studio = new MovieStudio()
                    {
                        Name = "New Regency Pictures",
                        Address = "U.S.A."
                    }
                });

                context.Movies.Add(new Movie
                {
                    Title = "Deadpool",
                    Year = 2016,
                    Director = new MovieMember()
                    {
                        Name = "Tim Miller",
                        Age = 39
                    },
                    LeadingMaleRole = new MovieMember()
                    {
                        Name = "Ryan Reynolds",
                        Age = 39
                    },
                    LeadingFemaleRole = new MovieMember()
                    {
                        Name = "Morena Baccarin",
                        Age = 37
                    },
                    Studio = new MovieStudio()
                    {
                        Name = "Marvel Enterprises",
                        Address = "U.S.A"
                    }
                });

                context.Movies.Add(new Movie
                {
                    Title = "Star Wars: Episode VII - The Force Awakens",
                    Year = 2015,
                    Director = new MovieMember()
                    {
                        Name = "J.J. Abrams",
                        Age = 49
                    },
                    LeadingMaleRole = new MovieMember()
                    {
                        Name = "Harrison Ford",
                        Age = 73
                    },
                    LeadingFemaleRole = new MovieMember()
                    {
                        Name = "Daisy Ridley",
                        Age = 23
                    },
                    Studio = new MovieStudio()
                    {
                        Name = "Lucasfilm",
                        Address = "U.S.A"
                    }
                });

                context.Movies.Add(new Movie
                {
                    Title = "The Finest Hours",
                    Year = 2016,
                    Director = new MovieMember()
                    {
                        Name = "Craig Gillespie",
                        Age = 54
                    },
                    LeadingMaleRole = new MovieMember()
                    {
                        Name = "Chris Pine",
                        Age = 35
                    },
                    LeadingFemaleRole = new MovieMember()
                    {
                        Name = "Holliday Grainger",
                        Age = 27
                    },
                    Studio = new MovieStudio()
                    {
                        Name = "Walt Disney Pictures",
                        Address = "U.S.A"
                    }
                });

                context.SaveChanges();

                context.MovieStudios.Add(new MovieStudio()
                {
                    Name = "Paramount pictures",
                    Address = "U.S.A"
                });

                context.MovieStudios.Add(new MovieStudio()
                {
                    Name = "20 Senchery Fox",
                    Address = "U.S.A"
                });

                context.MovieStudios.Add(new MovieStudio()
                {
                    Name = "Universal Studios",
                    Address = "U.S.A"
                });

                context.MovieStudios.Add(new MovieStudio()
                {
                    Name = "Warner Bros",
                    Address = "U.S.A"
                });

                context.SaveChanges();
            }
        }
    }
}
