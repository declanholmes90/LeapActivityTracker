using System.Collections.Generic;

namespace LeapActivityTracker.Core.Activity.Queries
{
    public class GetAllActivitySummaryViewModel
    {
        public IList<GetActivitySummaryViewModel> ActivityByTypeCollection { get; set; } = new List<GetActivitySummaryViewModel>();
    }
}
