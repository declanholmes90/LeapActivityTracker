using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeapActivityTracker.Core.Activity.Queries
{
    public static class ActivityTypes
    {
        public static readonly ActivityType PhoneCall = new ActivityType { Id = 1, Name = "Phone Call"};
        public static readonly ActivityType Email = new ActivityType { Id = 2, Name = "Email"};
        public static readonly ActivityType Document = new ActivityType { Id = 3, Name = "Document"};
        public static readonly ActivityType Appointment = new ActivityType { Id = 4, Name = "Appointment"};

        private static IList<ActivityType> ActivityTypesCollection = new List<ActivityType>()
        {
            PhoneCall,
            Email,
            Document,
            Appointment
        };

        public static ActivityType GetById(int Id)
        {
            return ActivityTypesCollection.FirstOrDefault(a => a.Id == Id);
        }
    }

    public class ActivityType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}