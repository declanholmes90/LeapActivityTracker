using AutoMapper;
using LeapActivityTracker.Infrastructure.Entities;

namespace LeapActivityTracker.Core.Activity.Queries
{
    public class ActivityProfile : Profile
    {
        public ActivityProfile()
        {
            CreateMap<ActivityEntity, ActivityDto>();
        }
    }
}
