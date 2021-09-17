using AutoMapper;
using LeapActivityTracker.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

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
