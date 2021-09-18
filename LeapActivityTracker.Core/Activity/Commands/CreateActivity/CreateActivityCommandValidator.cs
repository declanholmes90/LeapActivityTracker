using FluentValidation;

namespace LeapActivityTracker.Core.Activity.Commands.CreateActivity
{
    public class CreateActivityCommandValidator : AbstractValidator<CreateActivityCommand>
    {
        public CreateActivityCommandValidator()
        {
            RuleFor(q => q.TimeFrom).LessThan(q => q.TimeTo).WithMessage("Start cannot be after end time.");
            RuleFor(q => q.TimeFrom).NotEqual(q => q.TimeTo).WithMessage("Start and end time cannot be the same.");
            RuleFor(q => q.Id).GreaterThan(0).WithMessage("Id must be greater than zero.");
        }
    }
}
