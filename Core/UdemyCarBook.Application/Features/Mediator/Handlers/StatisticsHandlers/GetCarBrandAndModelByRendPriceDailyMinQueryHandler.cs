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
    internal class GetCarBrandAndModelByRendPriceDailyMinQueryHandler : IRequestHandler<GetCarBrandAndModelByRendPriceDailyMinQuery, GetCarBrandAndModelByRendPriceDailyMinQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetCarBrandAndModelByRendPriceDailyMinQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetCarBrandAndModelByRendPriceDailyMinQueryResult> Handle(GetCarBrandAndModelByRendPriceDailyMinQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarBrandAndModelByRendPriceDailyMin();
            return new GetCarBrandAndModelByRendPriceDailyMinQueryResult
            {
                CarBrandAndModelByRendPriceDailyMin = value
            };
        }
    }
}
