using AutoFixture;
using LeapActivityTracker.Core.Activity.Commands;
using LeapActivityTracker.Core.Activity.Commands.CreateActivity;
using Shouldly;
using System;
using Xunit;

namespace LeapActivityTracker.UnitTests.CreateActivityCommandTests
{
    public class ValidatorTests : TestBase
    {
        private readonly CreateActivityCommandValidator _sut;
        public ValidatorTests()
        {
            _sut = new CreateActivityCommandValidator();
        }

        [Fact]
        public void Validate_TimeFromGreaterThanTimeTo_Error()
        {
            var cmd = Fixture.Build<CreateActivityCommand>()
                .With(q => q.TimeFrom, new DateTime(2021, 9, 10))
                .With(q => q.TimeTo, new DateTime(2021, 9, 9))
                .Create();

            var results = _sut.Validate(cmd);

            results.IsValid.ShouldBeFalse();
        }

        [Fact]
        public void Validate_TimeFromEqualsTimeTo_Error()
        {
            var cmd = Fixture.Build<CreateActivityCommand>()
                .With(q => q.TimeFrom, new DateTime(2021, 9, 10))
                .With(q => q.TimeTo, new DateTime(2021, 9, 10))
                .Create();

            var results = _sut.Validate(cmd);

            results.IsValid.ShouldBeFalse();
        }

        [Fact]
        public void Validate_IdLessThanZero_Error()
        {
            var cmd = Fixture.Build<CreateActivityCommand>()
                .With(q => q.Id, -1)
                .Create();

            var results = _sut.Validate(cmd);

            results.IsValid.ShouldBeFalse();
        }
    }
}
