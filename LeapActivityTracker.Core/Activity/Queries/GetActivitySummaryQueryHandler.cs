using AutoMapper;
using LeapActivityTracker.Infrastructure;
using LeapActivityTracker.Infrastructure.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LeapActivityTracker.Core.Activity.Queries
{
    public class GetActivitySummaryQueryHandler : IRequestHandler<GetActivitySummaryQuery, GetAllActivitySummaryViewModel>
    {
        private IMapper _mapper;
        private ActivitiesDbContext _dbContext;

        public GetActivitySummaryQueryHandler(IMapper mapper, ActivitiesDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }
        public async Task<GetAllActivitySummaryViewModel> Handle(GetActivitySummaryQuery request, CancellationToken cancellationToken)
        {
            GetAllActivitySummaryViewModel returnViewModel = new GetAllActivitySummaryViewModel();

            GetActivitySummaryViewModel phoneSummaryViewModel = new GetActivitySummaryViewModel()
            {
                ActivityType = ActivityTypes.PhoneCall,
                ActivitiesCollection = _mapper.Map<IList<ActivityDto>>(await _dbContext.Activities.Where(a => a.Type == ActivityTypes.PhoneCall.Id
                    && a.TimeFrom >= request.TimeFrom
                    && a.TimeTo <= request.TimeTo
                ).ToListAsync(cancellationToken))
            };

            GetActivitySummaryViewModel EmailSummaryViewModel = new GetActivitySummaryViewModel()
            {
                ActivityType = ActivityTypes.Email,
                ActivitiesCollection = _mapper.Map<IList<ActivityDto>>(await _dbContext.Activities.Where(a => a.Type == ActivityTypes.Email.Id
                    && a.TimeFrom >= request.TimeFrom
                    && a.TimeTo <= request.TimeTo
                ).ToListAsync(cancellationToken))
            };

            GetActivitySummaryViewModel DocumentSummaryViewModel = new GetActivitySummaryViewModel()
            {
                ActivityType = ActivityTypes.Document,
                ActivitiesCollection = _mapper.Map<IList<ActivityDto>>(await _dbContext.Activities.Where(a => a.Type == ActivityTypes.Document.Id
                    && a.TimeFrom >= request.TimeFrom
                    && a.TimeTo <= request.TimeTo
                ).ToListAsync(cancellationToken))
            };

            GetActivitySummaryViewModel AppointmentSummaryViewModel = new GetActivitySummaryViewModel()
            {
                ActivityType = ActivityTypes.Appointment,
                ActivitiesCollection = _mapper.Map<IList<ActivityDto>>(await _dbContext.Activities.Where(a => a.Type == ActivityTypes.Appointment.Id
                    && a.TimeFrom >= request.TimeFrom
                    && a.TimeTo <= request.TimeTo
                ).ToListAsync(cancellationToken))
            };

            returnViewModel.ActivityByTypeCollection = new List<GetActivitySummaryViewModel> { phoneSummaryViewModel, EmailSummaryViewModel, DocumentSummaryViewModel, AppointmentSummaryViewModel };

            return returnViewModel;
        }
    }
}
