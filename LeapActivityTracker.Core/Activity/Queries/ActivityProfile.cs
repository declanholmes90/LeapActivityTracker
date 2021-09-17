using AutoMapper;
using LeapActivityTracker.Core.Activity.Queries;
using LeapActivityTracker.Infrastructure.Entities;
using System.Collections.Generic;

namespace LeapActivityTracker.Core
{
    public class ActivityProfile : Profile
    {
        public ActivityProfile()
        {
            CreateMap<ActivityEntity, ActivityDto>();
        }
    }
}
