using AutoMapper;
using LeapActivityTracker.Core.Activity.Commands.UpdateActivity;
using LeapActivityTracker.Requests;

namespace LeapActivityTracker.Profiles
{
    public class UpdateActivityProfile : Profile
    {
        public UpdateActivityProfile()
        {
            CreateMap<UpdateActivityRequest, UpdateActivityCommand>()
                .ForMember(d => d.TimeElapsed, o => o.MapFrom(s => s.TimeTo - s.TimeFrom));
        }
    }
}
