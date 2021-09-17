using System;
using System.Collections.Generic;

namespace LeapActivityTracker.Core.Activity.Queries
{
    public class GetActivitySummaryViewModel
    {
        public ActivityType ActivityType { get; set; }
        public TimeSpan TimeTotalElapsed { get; set; }
        public IList<ActivityDto> ActivitiesCollection { get; set; }
    }
}