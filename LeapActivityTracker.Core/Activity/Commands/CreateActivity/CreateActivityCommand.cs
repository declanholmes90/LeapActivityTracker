using LeapActivityTracker.Core.Activity.Common;
using LeapActivityTracker.Core.Activity.Queries;
using MediatR;
using System;

namespace LeapActivityTracker.Core.Activity.Commands.CreateActivity
{
    public class CreateActivityCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ActivityType Type { get; set; }
        public DateTime? TimeFrom { get; set; }
        public DateTime? TimeTo { get; set; }
        public TimeSpan TimeElapsed { get; set; }
    }
}
