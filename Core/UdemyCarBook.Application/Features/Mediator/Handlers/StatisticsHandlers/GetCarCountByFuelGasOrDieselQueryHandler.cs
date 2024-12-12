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
    public class GetCarCountByFuelGasOrDieselQueryHandler : IRequestHandler<GetCarCountByFuelGasOrDieselQuery, GetCarCountByFuelGasOrDieselQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetCarCountByFuelGasOrDieselQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetCarCountByFuelGasOrDieselQueryResult> Handle(GetCarCountByFuelGasOrDieselQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountByFuelGasOrDiesel();
            return new GetCarCountByFuelGasOrDieselQueryResult
            {
                CarCountByFuelGasOrDiesel = value
            };
        }
    }
}
