using MediatR;
using System;

namespace LeapActivityTracker.Core.Activity.Queries
{
    public class GetActivitySummaryQuery : IRequest<GetAllActivitySummaryViewModel>
    {
        public DateTime? TimeFrom { get; set; }
        public DateTime? TimeTo { get; set; }
    }
}
