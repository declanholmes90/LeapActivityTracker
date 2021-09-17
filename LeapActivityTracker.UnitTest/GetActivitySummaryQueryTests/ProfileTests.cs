using AutoFixture;
using AutoMapper;
using LeapActivityTracker.Core;
using LeapActivityTracker.Core.Activity.Queries;
using LeapActivityTracker.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using Shouldly;
using System.Threading.Tasks;
using Xunit;
using LeapActivityTracker.Requests;

namespace LeapActivityTracker.UnitTests.GetActivitySummaryQueryTests
{
    public class ProfileTests : TestBase
    {

        [Fact]
        public async Task Profile_RequestMapsCorrectlyToQuery()
        {
            var request = Fixture.Create<GetActivitySummaryRequest>();

            var query = Mapper.Map<GetActivitySummaryQuery>(request);

            query.TimeFrom.ShouldBe(request.TimeFrom);
            query.TimeTo.ShouldBe(request.TimeTo);
        }
    }
}
