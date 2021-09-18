using System;

namespace LeapActivityTracker.Requests
{
    public class CreateActivityRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public DateTime? TimeFrom { get; set; }
        public DateTime? TimeTo { get; set; }
    }
}
