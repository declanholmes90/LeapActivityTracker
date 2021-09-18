using System;

namespace LeapActivityTracker.Requests
{
    public class UpdateActivityRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? TimeFrom { get; set; }
        public DateTime? TimeTo { get; set; }
    }
}
