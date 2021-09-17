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

namespace LeapActivityTracker.UnitTests
{

    public class HandlerTests : TestBase
    {

        [Fact]
        public async Task Handler_Returns_GetAllActivitySummaryViewModel()
        {
            DbContext context = Fixture.Create<ActivitiesDbContext>();
            Fixture.Inject(context);

            GetActivitySummaryQueryHandler _sut = Fixture.Create<GetActivitySummaryQueryHandler>();
            GetActivitySummaryQuery _request = Fixture.Build<GetActivitySummaryQuery>()
                .With(r => r.TimeFrom)
                .Create();

            var viewModel = await _sut.Handle(_request, default);

            viewModel.ShouldNotBeNull();
        }
    }
}
