using AutoMapper;
using LeapActivityTracker.Infrastructure.Entities;
using System.Collections.Generic;

namespace LeapActivityTracker.Core.Activity.Queries
{
    public class GetActivitySummaryProfile : Profile
    {
        public GetActivitySummaryProfile()
        {
            CreateMap<IList<ActivityEntity>, GetActivitySummaryProfile>();
        }
    }
}
