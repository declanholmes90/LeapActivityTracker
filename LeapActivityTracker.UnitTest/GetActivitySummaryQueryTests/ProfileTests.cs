using AutoFixture;
using AutoMapper;
using LeapActivityTracker.Core.Activity.Queries;
using LeapActivityTracker.Requests;
using Shouldly;
using Xunit;

namespace LeapActivityTracker.UnitTests.GetActivitySummaryQueryTests
{
    public class ProfileTests : TestBase
    {
        private readonly IMapper _mapper;
        public ProfileTests()
        {
            var config = new MapperConfiguration(configure => configure.AddMaps(typeof(GetActivitySummaryQuery), typeof(GetActivitySummaryRequest)));
            _mapper = config.CreateMapper();
        }

        [Fact]
        public void Profile_RequestMapsCorrectlyToQuery()
        {
            var request = Fixture.Create<GetActivitySummaryRequest>();

            var query = _mapper.Map<GetActivitySummaryQuery>(request);

            query.TimeFrom.ShouldBe(request.TimeFrom);
            query.TimeTo.ShouldBe(request.TimeTo);
        }
    }
}
