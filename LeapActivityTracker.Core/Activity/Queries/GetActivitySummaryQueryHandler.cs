using AutoMapper;
using FluentValidation;
using LeapActivityTracker.Core.Activity.Common;
using LeapActivityTracker.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
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

            GetActivitySummaryViewModel phoneSummaryViewModel = await GetActivityByTypeAndTime(ActivityTypes.PhoneCall, request.TimeFrom, request.TimeTo, cancellationToken);
            GetActivitySummaryViewModel EmailSummaryViewModel = await GetActivityByTypeAndTime(ActivityTypes.Email, request.TimeFrom, request.TimeTo, cancellationToken);
            GetActivitySummaryViewModel documentSummaryViewModel = await GetActivityByTypeAndTime(ActivityTypes.Document, request.TimeFrom, request.TimeTo, cancellationToken);
            GetActivitySummaryViewModel appointmentSummaryViewModel = await GetActivityByTypeAndTime(ActivityTypes.Appointment, request.TimeFrom, request.TimeTo, cancellationToken);

            returnViewModel.ActivityByTypeCollection = new List<GetActivitySummaryViewModel> { phoneSummaryViewModel, EmailSummaryViewModel, documentSummaryViewModel, appointmentSummaryViewModel };

            return returnViewModel;
        }

        private async Task<GetActivitySummaryViewModel> GetActivityByTypeAndTime(ActivityType activityType, DateTime? timeFrom, DateTime? timeTo, CancellationToken cancellationToken)
        {
            var viewModel = new GetActivitySummaryViewModel()
            {
                ActivityType = activityType,
                ActivitiesCollection = _mapper.Map<IList<ActivityDto>>(await _dbContext.Activities.Where(a => a.TypeId == activityType.Id
                    && a.TimeFrom >= timeFrom
                    && a.TimeTo <= timeTo
                ).ToListAsync(cancellationToken)),
            };

            viewModel.TimeTotalElapsed = new TimeSpan(viewModel.ActivitiesCollection.Sum(a => a.TimeElapsed.Ticks));

            return viewModel;
        }
    }
}
