using AutoMapper;
using LeapActivityTracker.Core;
using LeapActivityTracker.Requests;

namespace LeapActivityTracker.Profiles
{
    public class GetActivitySummaryProfile : Profile
    {
        public GetActivitySummaryProfile()
        {
            CreateMap<GetActivitySummaryRequest, GetActivitySummaryQuery>();
        }
    }
}
