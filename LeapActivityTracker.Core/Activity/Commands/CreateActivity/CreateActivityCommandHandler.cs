using AutoMapper;
using LeapActivityTracker.Infrastructure;
using LeapActivityTracker.Infrastructure.Entities;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LeapActivityTracker.Core.Activity.Commands.CreateActivity
{
    public class CreateActivityCommandHandler : IRequestHandler<CreateActivityCommand>
    {
        private IMapper _mapper;
        private ActivitiesDbContext _dbContext;

        public CreateActivityCommandHandler(IMapper mapper, ActivitiesDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(CreateActivityCommand request, CancellationToken cancellationToken)
        {
            var activityEntity = _mapper.Map<ActivityEntity>(request);

            if(_dbContext.Activities.Any(a => a.Id == activityEntity.Id))
            {
                throw new ArgumentException("Id already exists. Id must be unique.");
            }

            await _dbContext.Activities.AddAsync(activityEntity, cancellationToken);
            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
