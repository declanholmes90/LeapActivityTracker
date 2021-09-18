using FluentValidation;

namespace LeapActivityTracker.Core.Activity.Queries
{
    public class GetActivitySummaryQueryValidator : AbstractValidator<GetActivitySummaryQuery>
    {
        public GetActivitySummaryQueryValidator()
        {
            RuleFor(q => q.TimeFrom).LessThan(q => q.TimeTo).WithMessage("Start cannot be after end time.");
            RuleFor(q => q.TimeFrom).NotEqual(q => q.TimeTo).WithMessage("Start and end time cannot be the same.");
        }
    }
}
