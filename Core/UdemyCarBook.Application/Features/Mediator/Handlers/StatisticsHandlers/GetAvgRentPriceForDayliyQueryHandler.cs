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
    public class GetAvgRentPriceForDayliyQueryHandler : IRequestHandler<GetAvgRentPriceForDayliyQuery, GetAvgRentPriceForDailyQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetAvgRentPriceForDayliyQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetAvgRentPriceForDailyQueryResult> Handle(GetAvgRentPriceForDayliyQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetAvgRentPriceForDayliy();
            return new GetAvgRentPriceForDailyQueryResult
            {
                AvgPriceDaily = value
            };
        }
    }
}
