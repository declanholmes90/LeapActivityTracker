using AutoFixture;
using AutoMapper;
using LeapActivityTracker.Core.Activity.Commands.CreateActivity;
using LeapActivityTracker.Infrastructure.Entities;
using LeapActivityTracker.Requests;
using Shouldly;
using Xunit;

namespace LeapActivityTracker.UnitTests.CreateActivityCommandTests
{
    public class ProfileTests : TestBase
    {
        private readonly IMapper _mapper;
        public ProfileTests()
        {
            var config = new MapperConfiguration(configure => configure.AddMaps(typeof(CreateActivityCommand), typeof(CreateActivityRequest)));
            _mapper = config.CreateMapper();
        }

        [Fact]
        public void Profile_RequestMapsCorrectlyToCommand()
        {
            var request = Fixture.Create<CreateActivityRequest>();

            var cmd = _mapper.Map<CreateActivityCommand>(request);

            cmd.Id.ShouldBe(request.Id);
            cmd.Name.ShouldBe(request.Name);
            cmd.TimeFrom.ShouldBe(request.TimeFrom);
            cmd.TimeTo.ShouldBe(request.TimeTo);
            cmd.TimeElapsed.ShouldBeEquivalentTo(request.TimeTo - request.TimeFrom);
        }

        [Fact]
        public void Profile_CommandMapsCorrectlyToEntity()
        {
            var cmd = Fixture.Create<CreateActivityCommand>();

            var entity = _mapper.Map<ActivityEntity>(cmd);

            entity.Id.ShouldBe(cmd.Id);
            entity.Name.ShouldBe(cmd.Name);
            entity.TimeFrom.ShouldBe(cmd.TimeFrom);
            entity.TimeTo.ShouldBe(cmd.TimeTo);
            entity.TimeElapsed.ShouldBeEquivalentTo(cmd.TimeElapsed);
        }
    }
}
