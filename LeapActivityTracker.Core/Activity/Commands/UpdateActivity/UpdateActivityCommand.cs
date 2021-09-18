using LeapActivityTracker.Core.Activity.Common;
using MediatR;
using System;

namespace LeapActivityTracker.Core.Activity.Commands.UpdateActivity
{
    public class UpdateActivityCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? TimeFrom { get; set; }
        public DateTime? TimeTo { get; set; }
        public TimeSpan TimeElapsed { get; set; }
    }
}