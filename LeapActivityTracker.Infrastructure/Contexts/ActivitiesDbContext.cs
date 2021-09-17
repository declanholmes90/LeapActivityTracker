using LeapActivityTracker.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace LeapActivityTracker.Infrastructure
{
    public class ActivitiesDbContext : DbContext
    {
        public DbSet<ActivityEntity> Activities => Set<ActivityEntity>();

        public ActivitiesDbContext(DbContextOptions<ActivitiesDbContext> options)
        : base(options) { }
    }
}
