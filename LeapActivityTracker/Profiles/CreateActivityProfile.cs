using AutoMapper;
using LeapActivityTracker.Core.Activity.Commands.CreateActivity;
using LeapActivityTracker.Core.Activity.Common;
using LeapActivityTracker.Requests;

namespace LeapActivityTracker.Profiles
{
    public class CreateActivityProfile : Profile
    {
        public CreateActivityProfile()
        {
            CreateMap<CreateActivityRequest, CreateActivityCommand>()
                .ForMember(d => d.Type, o => o.MapFrom(s => ActivityTypes.GetById(s.TypeId)))
                .ForMember(d => d.TimeElapsed, o => o.MapFrom(s => s.TimeTo - s.TimeFrom));
        }
    }
}
