using System;

namespace LeapActivityTracker.Core.Activity.Queries
{
    public class ActivityDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime? TimeFrom { get; set; }
        public DateTime? TimeTo { get; set; }
        public TimeSpan TimeElapsed { get; set; }
    }
}
