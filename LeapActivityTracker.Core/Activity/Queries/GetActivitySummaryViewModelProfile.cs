using AutoMapper;
using LeapActivityTracker.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeapActivityTracker.Core.Activity.Queries
{
    public class GetActivitySummaryViewModelProfile : Profile
    {
        public GetActivitySummaryViewModelProfile()
        {
            CreateMap<List<ActivityEntity>, GetActivitySummaryViewModel>()
                .ForMember(d => d.ActivitiesCollection, o => o.MapFrom(s => s));
        }
    }
}
