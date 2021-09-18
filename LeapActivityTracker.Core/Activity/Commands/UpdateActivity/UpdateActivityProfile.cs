using AutoMapper;
using LeapActivityTracker.Infrastructure.Entities;

namespace LeapActivityTracker.Core.Activity.Commands.UpdateActivity
{
    public class UpdateActivityProfile : Profile
    {
        public UpdateActivityProfile()
        {
            CreateMap<UpdateActivityCommand, ActivityEntity>();
        }
    }
}
