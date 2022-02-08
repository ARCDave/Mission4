using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class MovieFormContext : DbContext
    {

        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base(options)
        {

        }

        public DbSet<MovieForm> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieForm>().HasData(

                    new MovieForm
                    {
                        MovieId = 1,
                        Title = "About Time",
                        Category = "Comedy/Drama/Fantasy",
                        Year = 2013,
                        Director = "Richard Curtis",
                        Rating = "R",
                        Edited = false,
                        Lent_To = "Sharon Meyers",
                        Notes = "A movie about Time Travel"
                    },
                    new MovieForm
                    {
                        MovieId = 2,
                        Title = "Good Will Hunting",
                        Category = "Drama/Romance",
                        Year = 1997,
                        Director = "Gus Van Sant",
                        Rating = "R",
                        Edited = false,
                        Lent_To = "Sharon Meyers",
                        Notes = "He stole my line"
                    },
                    new MovieForm
                    {
                        MovieId = 3,
                        Title = "Spider-Man: No Way Home",
                        Category = "Action/Adventure/Fantasy",
                        Year = 2021,
                        Director = "Jon Watts",
                        Rating = "PG-13",
                        Edited = false,
                        Lent_To = "Sharon Meyers",
                        Notes = "It has Three Spiders"
                    }
                );


        }
    }
}
