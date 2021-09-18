using AutoFixture;
using LeapActivityTracker.Core;
using LeapActivityTracker.Core.Activity.Queries;
using Shouldly;
using System;
using Xunit;

namespace LeapActivityTracker.UnitTests.GetActivitySummaryQueryTests
{
    public class ValidatorTests : TestBase
    {
        private readonly GetActivitySummaryQueryValidator _sut;
        public ValidatorTests()
        {
            _sut = new GetActivitySummaryQueryValidator();
        }

        [Fact]
        public void Validate_TimeFromGreaterThanTimeTo_Error()
        {
            var query = Fixture.Build<GetActivitySummaryQuery>()
                .With(q => q.TimeFrom, new DateTime(2021, 9, 10))
                .With(q => q.TimeTo, new DateTime(2021, 9, 9))
                .Create();

            var results = _sut.Validate(query);

            results.IsValid.ShouldBeFalse();
        }

        [Fact]
        public void Validate_TimeFromEqualsTimeTo_Error()
        {
            var query = Fixture.Build<GetActivitySummaryQuery>()
                .With(q => q.TimeFrom, new DateTime(2021, 9, 10))
                .With(q => q.TimeTo, new DateTime(2021, 9, 10))
                .Create();

            var results = _sut.Validate(query);

            results.IsValid.ShouldBeFalse();
        }
    }
}
