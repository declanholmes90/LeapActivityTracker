using AutoMapper;
using LeapActivityTracker.Core;
using LeapActivityTracker.Core.Activity.Queries;
using LeapActivityTracker.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LeapActivityTracker.Controllers
{
    [ApiController, Route("api/activities")]
    public class ActivityTrackerController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public ActivityTrackerController(IMapper mapper, IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpPost(nameof(GetSummaryOfActivities))]
        public async Task<GetActivitySummaryViewModel> GetSummaryOfActivities(GetActivitySummaryRequest request, CancellationToken cancellationToken)
        {
            var query = _mapper.Map<GetActivitySummaryQuery>(request);
            var result = await _mediator.Send(query, cancellationToken);
            return result;
        }

        [HttpPost(nameof(CreateActivity))]
        public async Task<Unit> CreateActivity(GetActivitySummaryRequest request, CancellationToken cancellationToken)
        {
            return Unit.Value;
        }
    }
}
