using System;

namespace LeapActivityTracker.Infrastructure.Entities
{
    public class ActivityEntity
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public DateTime? TimeFrom { get; set; }
        public DateTime? TimeTo { get; set; }
        public TimeSpan TimeElapsed { get; set; }
    }
}
