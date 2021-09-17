﻿using LeapActivityTracker.Core.Activity.Queries;
using MediatR;
using System;

namespace LeapActivityTracker.Core
{
    public class GetActivitySummaryQuery : IRequest<GetAllActivitySummaryViewModel>
    {
        public DateTime? TimeFrom { get; set; }
        public DateTime? TimeTo { get; set; }
    }
}
