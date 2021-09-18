using AutoMapper;
using LeapActivityTracker.Infrastructure.Entities;

namespace LeapActivityTracker.Core.Activity.Commands.CreateActivity
{
    public class CreateActivityProfile : Profile
    {
        public CreateActivityProfile()
        {
            CreateMap<CreateActivityCommand, ActivityEntity>()
                .ForMember(d => d.TypeId, o => o.MapFrom(s => s.Type.Id));
        }
    }
}
