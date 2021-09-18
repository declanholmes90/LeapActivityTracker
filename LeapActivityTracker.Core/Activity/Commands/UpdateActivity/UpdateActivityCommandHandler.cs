using AutoMapper;
using LeapActivityTracker.Infrastructure;
using LeapActivityTracker.Infrastructure.Entities;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LeapActivityTracker.Core.Activity.Commands.UpdateActivity
{
    public class UpdateActivityCommandHandler : IRequestHandler<UpdateActivityCommand>
    {
        private IMapper _mapper;
        private ActivitiesDbContext _dbContext;

        public UpdateActivityCommandHandler(IMapper mapper, ActivitiesDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateActivityCommand request, CancellationToken cancellationToken)
        {
            var activityEntity = _mapper.Map<ActivityEntity>(request);

            if(!_dbContext.Activities.Any(a => a.Id == activityEntity.Id))
            {
                throw new ArgumentException("Id does not exist.");
            }

            var activity = _dbContext.Activities.Find(activityEntity.Id);
            activity.Name = activityEntity.Name;
            activity.TimeFrom = activityEntity.TimeFrom;
            activity.TimeTo = activityEntity.TimeTo;
            activity.TimeElapsed = activityEntity.TimeElapsed;

            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
