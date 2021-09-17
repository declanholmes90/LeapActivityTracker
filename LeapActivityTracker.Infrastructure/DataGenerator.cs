using LeapActivityTracker.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace LeapActivityTracker.Infrastructure
{
    public static class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ActivitiesDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ActivitiesDbContext>>()))
            {
                if (context.Activities.Any())
                {
                    return;
                }

                context.Activities.AddRange(
                    new ActivityEntity
                    {
                        Id = 1,
                        Name = "PHONE CALL - Spoke with my ma'",
                        TimeFrom = new DateTime(2021, 1, 6, 9, 0, 0),
                        TimeTo = new DateTime(2021, 1, 6, 9, 8, 11),
                        TimeElapsed = new TimeSpan(0, 8, 11),
                        Type = 1,
                    },
                    new ActivityEntity
                    {
                        Id = 2,
                        Name = "PHONE CALL - Spoke with my da'",
                        TimeFrom = new DateTime(2021, 1, 6, 9, 0, 0),
                        TimeTo = new DateTime(2021, 1, 6, 9, 8, 11),
                        TimeElapsed = new TimeSpan(0, 8, 11),
                        Type = 1,
                    },
                    new ActivityEntity
                    {
                        Id = 4,
                        Name = "PHONE CALL - Spoke with my tax agent",
                        TimeFrom = new DateTime(2021, 1, 6, 9, 0, 0),
                        TimeTo = new DateTime(2021, 1, 6, 9, 8, 11),
                        TimeElapsed = new TimeSpan(0, 8, 11),
                        Type = 1,
                    },
                    new ActivityEntity
                    {
                        Id = 3,
                        Name = "READ EMAIL - Cleared out the spam",
                        TimeFrom = new DateTime(2021, 1, 6, 9, 45, 0),
                        TimeTo = new DateTime(2021, 1, 6, 10, 0, 0),
                        TimeElapsed = new TimeSpan(0, 15, 0),
                        Type = 2,
                    },
                    new ActivityEntity
                    {
                        Id = 6,
                        Name = "READ EMAIL - Replied to Nigerian prince",
                        TimeFrom = new DateTime(2021, 1, 6, 9, 45, 0),
                        TimeTo = new DateTime(2021, 1, 6, 10, 0, 0),
                        TimeElapsed = new TimeSpan(0, 15, 0),
                        Type = 2,
                    },
                    new ActivityEntity
                    {
                        Id = 7,
                        Name = "MADE DOCUMENT - Made a list of groceries",
                        TimeFrom = new DateTime(2021, 1, 6, 13, 22, 24),
                        TimeTo = new DateTime(2021, 1, 6, 13, 28, 0),
                        TimeElapsed = new TimeSpan(0, 5, 36),
                        Type = 3
                    },
                    new ActivityEntity
                    {
                        Id = 5,
                        Name = "MADE APPOINTMENT - For the haridressers",
                        TimeFrom = new DateTime(2021, 1, 6, 9, 45, 0),
                        TimeTo = new DateTime(2021, 1, 6, 10, 0, 0),
                        TimeElapsed = new TimeSpan(0, 15, 0),
                        Type = 2,
                    },
                    new ActivityEntity
                    {
                        Id = 9,
                        Name = "MADE APPOINTMENT - For the dentist",
                        TimeFrom = new DateTime(2021, 1, 6, 9, 45, 0),
                        TimeTo = new DateTime(2021, 1, 6, 10, 0, 0),
                        TimeElapsed = new TimeSpan(0, 15, 0),
                        Type = 2,
                    });

                context.SaveChanges();

            }
        }
    }
}
