using System;

namespace LeapActivityTracker.Requests
{
    public class GetActivitySummaryRequest
    {
        public DateTime? TimeFrom { get; set; }
        public DateTime? TimeTo { get; set; }
    }
}
