using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using UdemyCarBook.Application.Features.Mediator.Results.StatisticsResults;
using UdemyCarBook.Application.Interfaces.StatistcsInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetBLogCountQueryHandler : IRequestHandler<GetBLogCountQuery, GetBlogCountQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetBLogCountQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetBlogCountQueryResult> Handle(GetBLogCountQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetBLogCount();
            return new GetBlogCountQueryResult
            {
                BlogCount = value
            };
        }
    }
}
