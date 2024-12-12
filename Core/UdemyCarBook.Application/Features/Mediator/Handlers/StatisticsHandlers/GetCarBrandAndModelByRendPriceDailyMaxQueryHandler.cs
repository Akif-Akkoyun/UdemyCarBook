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
    public class GetCarBrandAndModelByRendPriceDailyMaxQueryHandler : IRequestHandler<GetCarBrandAndModelByRendPriceDailyMaxQuery, GetCarBrandAndModelByRendPriceDailyMaxQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetCarBrandAndModelByRendPriceDailyMaxQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetCarBrandAndModelByRendPriceDailyMaxQueryResult> Handle(GetCarBrandAndModelByRendPriceDailyMaxQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarBrandAndModelByRendPriceDailyMax();
            return new GetCarBrandAndModelByRendPriceDailyMaxQueryResult
            {
                CarBrandAndModelByRendPriceDailyMax = value
            };
        }
    }
}
