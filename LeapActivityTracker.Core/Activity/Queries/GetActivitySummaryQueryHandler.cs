using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeapActivityTracker.Core.Activity.Queries
{
    public class GetActivitySummaryQueryHandler : IRequestHandler<GetActivitySummaryQuery, GetActivitySummaryViewModel>
    {
        private IMapper _mapper;
        private DbContext _dbContext;

        public GetActivitySummaryQueryHandler(IMapper mapper, DbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }
        public async Task<GetActivitySummaryViewModel> Handle(GetActivitySummaryQuery request, CancellationToken cancellationToken)
        {
            return new GetActivitySummaryViewModel();
        }
    }
}
