using AutoFixture;
using AutoFixture.AutoMoq;
using AutoMapper;

namespace LeapActivityTracker.UnitTests
{
    public class TestBase
    {
        protected readonly IFixture Fixture;
        protected readonly IMapper Mapper;

        public TestBase()
        {
            Fixture = new Fixture()
                .Customize(new AutoMoqCustomization());
        }
    }
}
