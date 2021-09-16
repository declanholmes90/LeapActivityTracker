using LeapActivityTracker.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace LeapActivityTracker.Infrastructure
{
    public class InMemoryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("InMemoryDb");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>().HasData(
                new List<Activity>
                {
                    new Activity 
                    { 
                        Id = 1, Name = "Made some coffee",
                        TimeFrom = new DateTime(2021, 1, 6, 9, 0, 0), 
                        TimeTo = new DateTime(2021, 1, 6, 9, 8, 11),
                        TimeElapsed = new TimeSpan(0, 8, 11)
                    },
                    new Activity
                    {
                        Id = 1, Name = "Read the news",
                        TimeFrom = new DateTime(2021, 1, 6, 9, 45, 0),
                        TimeTo = new DateTime(2021, 1, 6, 10, 0, 0),
                        TimeElapsed = new TimeSpan(0, 15, 0)
                    },new Activity
                    {
                        Id = 1, Name = "Pet the cat",
                        TimeFrom = new DateTime(2021, 1, 6, 13, 22, 24),
                        TimeTo = new DateTime(2021, 1, 6, 13, 28, 0),
                        TimeElapsed = new TimeSpan(0, 5, 36)
                    },
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
