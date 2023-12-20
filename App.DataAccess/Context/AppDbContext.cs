using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opts) : base(opts)
        {

        }

       public DbSet<Actor> Actors { get; set; }
       public DbSet<Biography> Biographies { get; set; }
      public  DbSet<Genre> Genres { get; set; }
       public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Actor>().HasData(new Actor
            {
                Id = 1,
                FirstName = "actor1",
                LastName = "actor2",
            },
            new Actor
            {
                Id = 2,
                FirstName = "actor2",
                LastName = "actor2",
            },
            new Actor
            {
                Id = 3,
                FirstName = "actor3",
                LastName = "actor3",
            });


            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id=1,
                    Name="movie1",
                    Description="des1",
                    ActorId=1
                },
                new Movie
                {
                    Id = 2,
                    Name = "movie2",
                    Description = "des2",
                    ActorId = 2
                },
                new Movie
                {
                    Id = 3,
                    Name = "movie3",
                    Description = "des3",
                    ActorId = 1
                },
                new Movie
                {
                    Id = 4,
                    Name = "movie4",
                    Description = "des4",
                    ActorId = 3
                }
                );
        }
    }
}
